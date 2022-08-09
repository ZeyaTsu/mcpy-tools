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

def mineshaft():
    print(g + "- - - - - Mineshaft mirror - - - - -")
    print(g + "                                                  " )
    print(g + "- - - - - - Coordinates - - - - - - ")
    x = int(input("X: "))
    y = int(input("Y: "))
    z = int(input("Z:"))

    mine_x = x * -1
    mine_z = z * -1

    print(g + "Mineshaft found!")
    print("X:", mine_x)
    print("Y:", y)
    print("Z:", mine_z)
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
            mineshaft()
            w = False