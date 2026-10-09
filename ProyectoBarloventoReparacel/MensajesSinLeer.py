# -- coding: utf-8 --
import pyautogui
import webbrowser
from time import sleep
import io
import hashlib

def detectar_color(color_rgb, area, tolerance=30):
    x_start, y_start, x_end, y_end = area
    screenshot = pyautogui.screenshot(region=(x_start, y_start, x_end - x_start, y_end - y_start))
    screenshot = screenshot.convert('RGB')
    
    width, height = screenshot.size
    for x in range(width):
        for y in range(height):
            pixel_color = screenshot.getpixel((x, y))
            if all(abs(pixel_color[i] - color_rgb[i]) <= tolerance for i in range(3)):
                return (x_start + x, y_start + y)
    return None

def obtener_id_chat(area):
    x_start, y_start, x_end, y_end = area
    screenshot = pyautogui.screenshot(region=(x_start, y_start, x_end - x_start, y_end - y_start))
    screenshot = screenshot.convert('RGB')
    
    with io.BytesIO() as buffer:
        screenshot.save(buffer, format='PNG')
        return hashlib.md5(buffer.getvalue()).hexdigest()

def enviar_mensaje(mensaje):
    pyautogui.typewrite(mensaje)
    pyautogui.press('enter')
    return True

def abrir_whatsapp_web():
    webbrowser.open('https://web.whatsapp.com')
    sleep(15)  # Tiempo para que se cargue la página y para escanear el QR

def main():
    abrir_whatsapp_web()
    
    mensaje_respuesta = "Hola, gracias por contactarnos. En breve nos comunicaremos contigo."
    color_a_buscar = (37, 211, 102)  # Color verde en formato RGB (para los chats)
    area_busqueda = (64, 265, 473, 720)  # Ajusta estas coordenadas a tu necesidad
    area_nombre_chat = (130, 271, 472, 355)  # Ajusta esta área para capturar el nombre del chat
     
    chats_atendidos = set()  # Conjunto para almacenar los identificadores de los chats

    # Coordenadas específicas donde se encuentra el botón "No leídos"
    posicion_no_leidos = (193, 248)  # Reemplaza con las coordenadas correctas

    # Ingreso al apartado "No leídos"
    pyautogui.click(posicion_no_leidos)
    sleep(2)  # Espera para que el chat se abra

    while True:
        # Detectar el color en el área de los chats
        color_pos = detectar_color(color_a_buscar, area_busqueda)
        if color_pos:
            pyautogui.click(color_pos)
            sleep(5)  # Espera para que el chat se abra

            id_chat = obtener_id_chat(area_nombre_chat)
            
            if id_chat not in chats_atendidos:
                try:
                    if enviar_mensaje(mensaje_respuesta):
                        chats_atendidos.add(id_chat)
                except Exception as e:
                    print(f"Error al enviar el mensaje: {e}")
            else:
                print("Este chat ya ha sido atendido.")
        else:
            print("No hay chats por leer.")
            break  # Salir si no hay chats por leer
        
        sleep(5)  # Verifica cada 5 segundos

if __name__ == "__main__":
    main()

