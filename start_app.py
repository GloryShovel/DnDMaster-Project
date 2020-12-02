import tkinter as tk
import menu
import newSession
from tkinter import ttk


# Should work: geeksforgeeks.org/tkinter-application-to-switch-between-different-page-frames/
class TkinterApp(tk.Tk):
    def __init__(self, *args, **kwargs):
        tk.Tk.__init__(self, *args, **kwargs)

        container = tk.Frame(self)
        container.pack(side="top", fill="both", expand=True)

        container.grid_rowconfigure(0, weight=1)
        container.grid_columnconfigure(0, weight=1)

        self.frames = {}

        for F in (menu, newSession):
            frame = F(container, self)

            self.frame[F] = frame

            frame.grid(row=0, column=0, sticky='nsew')

        self.show_frame(menu)

    def show_frame(self, cont):
        frame = self.frames[cont]
        frame.tkrise()

app = TkinterApp()
app.mainloop()
