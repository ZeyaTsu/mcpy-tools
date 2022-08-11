import colorama
from colorama import Fore, Back, Style
import index
import debugmode
from debugmode import *

colorama.init()
bm = Back.MAGENTA
w = Fore.WHITE
g = Fore.GREEN
c = Fore.CYAN

import math

def method():
    x = int(input("X: "))
    z = int(input("Z: "))

    x2 = int(input("X2: "))
    z2 = int(input("Z2 "))

    x3 = x - x2
    if x3 < 0:
        x3 = x3 * -1
    x3 += 1

    z3 = z - z2
    if z3 < 0:
        z3 = z3 * -1
    z3 += 1

    print("Please write a transport method: elytra/run")
    way = str(input("> "))
    if way == "run":
        v = 5.6
    elif way == "elytra":
        v = 7.2
         

    distance = int(math.sqrt((x3-2)**2 + (z3-2)**2))
    print("From X:", x, "Z:", z)
    print("To X:", x2, "Z:", z2)
    print("Distance: around", distance, "Blocks.")
    t = distance / v
    print("Duration:", int(t), "seconds")
    print("         ", t//60, "minutes")
    choix()

def choix():
    print(c+"Write 'list' to go back. 'r' to restart.")
    w = True
    while w:
        
        ca = str(input("> "))
        if ca == "list":
            index.menu()
            w = False
        elif ca == "r" or "res" or "restart":
            method()
            w = False










