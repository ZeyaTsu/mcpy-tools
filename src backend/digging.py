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
def setpos():
    print(g+"- - - - - Block Counter - - - - -")
    print(g+"                                 ")
    print(g+"- - - - - - -  Pos1   - - - - - -")


    x = int(input("X: "))
    y = int(input("Y: "))
    z = int(input("Z: "))

    print(g+"- - - - - - -  Pos2   - - - - - -")

    x2 = int(input("X2: "))

   

    y2 = int(input("Y2: "))


    x3 = x - x2
    if x3 < 0:
        x3 = x3 * (-1)
    x3 += 1
    
    

    z2 = int(input("Z2: "))


    z3 = z -z2
    if z3 < 0:
        z3 = z3 * (-1)
    z3 += 1

   

    y3 = y - y2
    if y3 < 0:
        y3 = y3 * (-1)
    if y3 == 0:
        y3 += 1    

    if debugmode.debug == True:

        print(w, bm, x3, y3, z3, Fore.RESET, Back.RESET)
    fi = x3 * z3 * y3
    print(g + "- - - - - Number of blocks - - - - -")
    print(fi, "Blocks.")
    lo = True
    while lo:
        print(c+"Write 'list' to go back. r to restart this app.")
        back = str(input("> "))
        if back == "list":
            index.menu()
            lo = False
        elif back == "r" or "res" or "restart":
            setpos()




