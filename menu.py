import random
import tkinter as tk
from tkinter import *
from PIL import Image
from PIL import ImageTk
from os import listdir
from os.path import isfile, join


def hello_call_back():
    print("Hello")


def go_to_new_session(window):
    window.destroy()
    newSession.begin()


def random_image():
    """
    Searches for files in MenuImages folder and returns random one as path
    """
    # TODO: check if chosen file is image
    images_path = "MenuImages"
    files = [f for f in listdir(images_path) if isfile(join(images_path, f))]
    image = random.choice(files)
    return images_path + "/" + image


def shutdown():
    exit()


def begin():
    # This makes window I guess and starts body of program loop
    window = tk.Tk()

    # getting window size
    window_size = [window.winfo_screenwidth(), window.winfo_screenheight()]
    # print("Window size: ", window_size[0], "x", window_size[1])

    # Some window settings
    # Window name
    window.title("DND Masters")

    # Resolution (not set for auto scale)
    # window.attributes('-fullscreen', True)
    # window.geometry('1280x720')

    # Example menu see also Menubutton for more flexible menu
    # To make sub menu you need to add_cascade(label="", menu=menuNameToAddTo)
    menu = tk.Menu()
    menu.add_command(label="Continue last session", command=hello_call_back)
    menu.add_command(label="New session", command=lambda:go_to_new_session(window))
    menu.add_command(label="Load session", command=hello_call_back)
    menu.add_command(label="Settings", command=hello_call_back)
    menu.add_separator()
    menu.add_command(label="Exit", command=shutdown)
    window.config(menu=menu)

    # Displaying menu image
    # TODO: download/make more Menu Images
    img = Image.open(random_image())
    resize_x = window_size[0] / 3
    resize_y = window_size[1] / 3
    img = img.resize((int(resize_x), int(resize_y)), Image.ANTIALIAS)
    photo_image = ImageTk.PhotoImage(img)
    menu_image = Canvas(window, width=photo_image.width(), height=photo_image.height())
    menu_image.pack()
    menu_image.create_image(1, 1, anchor=NW, image=photo_image)

    # Here tkinter halts main loop of program (see also update() and update_idletasks())
    window.mainloop()


begin()
