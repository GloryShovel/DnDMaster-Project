import tkinter as tk


def placeholder():
    print("place is being holded ;)")


def back_to_the_future(window):
    window.destroy()
    main.mainloop()


def begin():
    window = tk.Tk()

    window.title("Creating new session")

    # Margins XD
    tk.Label(window, text="  ").grid(row=0, column=0)
    tk.Label(window, text="  ").grid(row=10, column=10)

    tk.Label(window, text="Session name").grid(row=1, column=1)
    session_name = tk.Entry(window).grid(row=1, column=2)

    tk.Label(window, text="Select/Create party").grid(row=2, column=1, pady=10)
    tk.Label(window, text="No party selected", foreground='red').grid(row=2, column=2)
    tk.Button(window, text="Select party", command=placeholder).grid(row=2, column=3)
    tk.Button(window, text="Create new party", command=placeholder).grid(row=2, column=4)

    tk.Button(window, text="Back", command=lambda:back_to_the_future(window)).grid(row=9, column=8)
    tk.Button(window, text="Save", command=placeholder).grid(row=9, column=9)

    window.mainloop()
