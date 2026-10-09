import pyautogui
import webbrowser
import sys
from time import sleep

def enviar_mensaje(numero_telefono, mensaje):
    webbrowser.open(f'https://web.whatsapp.com/send?phone={numero_telefono}')
    sleep(18)
    pyautogui.typewrite(mensaje)
    pyautogui.press('enter')

if __name__ == "__main__":
    numero_telefono = sys.argv[1]
    mensaje = sys.argv[2]
    enviar_mensaje(numero_telefono, mensaje)
