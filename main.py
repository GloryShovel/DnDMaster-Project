import tkinter as tk
from tkinter import ttk


def hello_call_back():
    print("Hello")


def shutdown():
    exit()


# This makes window I guess and starts body of program loop
window = tk.Tk()

# Some window settings
# Window name
window.title("DND Masters")
# Resolution
window.geometry("500x200")

# To instanciate object use .pack()/.grid()/.place() you can also make variable for it
# Grid is more flexible than pack and both of them cannot be used in same window
tk.Label(window, text="Test", fg="red", bg="white").grid(row=0, column=0)

scrollbar = tk.Scrollbar().grid(column=10)

button = tk.Button(text="Yolo", command=hello_call_back, fg="#0f0").grid(row=1)
b_exit = tk.Button(text="Exit", command=shutdown).grid(row=3, column=3)

# Example menu see also Menubutton for more flexible menu
# To make sub menu you need to add_cascade(label="", menu=menuNameToAddTo)
menu = tk.Menu()
menu.add_command(label="option1", command=hello_call_back)
menu.add_command(label="option2", command=hello_call_back)
menu.add_separator()
menu.add_command(label="Exit", command=shutdown)
window.config(menu=menu)

# Here tkinter halts main loop of program (see also update() and update_idletasks())
window.mainloop()
