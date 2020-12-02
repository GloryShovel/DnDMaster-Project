import tkinter as tk


def placeholder():
    print("place is being holded ;)")


class NewSession(tk.Frame):
    def __init__(self, parent, controller):
        # Margins XD
        tk.Label(self, text="  ").grid(row=0, column=0)
        tk.Label(self, text="  ").grid(row=10, column=10)

        tk.Label(self, text="Session name").grid(row=1, column=1)
        session_name = tk.Entry(self).grid(row=1, column=2)

        tk.Label(self, text="Select/Create party").grid(row=2, column=1, pady=10)
        tk.Label(self, text="No party selected", foreground='red').grid(row=2, column=2)
        tk.Button(self, text="Select party", command=placeholder).grid(row=2, column=3)
        tk.Button(self, text="Create new party", command=placeholder).grid(row=2, column=4)

        tk.Button(self, text="Back", command=placeholder).grid(row=9, column=8)
        tk.Button(self, text="Save", command=placeholder).grid(row=9, column=9)

