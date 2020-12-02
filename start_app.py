import tkinter as tk
import menu
import new_session
from tkinter import ttk


# Should work: https://www.geeksforgeeks.org/tkinter-application-to-switch-between-different-page-frames/
class TkinterApp(tk.Tk):

    def __init__(self, *args, **kwargs):
        tk.Tk.__init__(self, *args, **kwargs)

        container = tk.Frame(self)
        container.pack(side="top", fill="both", expand=True)

        container.grid_rowconfigure(0, weight=1)
        container.grid_columnconfigure(0, weight=1)

        self.frames = {}

        for F in (menu.Menu, new_session.NewSession):
            frame = F(container, self)

            self.frames[F] = frame

            frame.grid(row=0, column=0, sticky="new")

        self.show_frame(menu)

    def show_frame(self, cont):
        frame = self.frames[cont]
        frame.tkraise()


app = TkinterApp()
app.mainloop()
