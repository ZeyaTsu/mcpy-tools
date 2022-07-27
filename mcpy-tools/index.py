import digging
import canplacedestroy
import debugmode
from debugmode import *
import colorama
from colorama import Fore, Back, Style
colorama.init()


bm = Back.MAGENTA
g = Fore.GREEN
b = Fore.BLUE
c = Fore.CYAN
w = Fore.WHITE

def menu():
    print(b + "- - - - - MCPy Tools - - - - -")
    print(b + "- - - - -     By     - - - - -")
    print(b + "- - - - -  ZeyaTsu   - - - - -")

    print(c + "- - - - - Choose an App - - - - -")
    print(b + "1. Area Block Counter - Count blocks from a given area.")
    print(b + "2. Mineshaft mirror - Find another mineshaft by finding a mineshaft.")
    print(b + "3. CanPlaceOn&CanDestroy - Command generator to give item that can destroy/be place on specific block.")
    print(c + "Write 'list' to open this list.")
    s = True
    while s:
        choice = str(input("> "))
        if choice == "list":
            menu()
        if choice == "debug":
            print(bm + w +"Debug Mode activated. Write 's-d' to stop debugging."+ Back.RESET, c)
            debugmode.debug = True
        if choice == "s-d":
            debugmode.debug = False


        elif choice == "1":
            digging.setpos()
            break
        elif choice == "3":
            canplacedestroy.choix()
            break
        

