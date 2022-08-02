import colorama
from colorama import Fore, Back, Style
import index
import debugmode
from debugmode import *


colorama.init()
bm = Fore.MAGENTA
w = Fore.WHITE
g = Fore.GREEN
c = Fore.CYAN
ytr = Fore.YELLOW
r = Fore.RED

b = Fore.BLUE
def y():
    print(w+"- - - - - Y Levels - - - - -")
    print(w+"O-Copper: 47-48")
    print(w+"O-Coal: 95-96")
    print(b+"O-Lapis Lazuli: 0")
    print(ytr+"O.N-Gold: 32 or -64/-16")
    print(r+"O-Redstone: -58 or -64")
    print(c+"O-Diamond: -58 ")
    print(g+"O-Emerald: 256")
    print(w+"N-Quartz: 12-80")
    print(bm+"N-Netherite: 11-13")
    print(ytr+"Note: Gold is more present in Badlands biome or Nether.")
    print(g+"Note: Can be found in negative Y caves.")
    print(w+"N = Nether, O = Overworld.")
    xd = True
    while xd:
        print(c+"Write 'list' to go back.")
        choiccr = str(input("> "))
        if choiccr == "list":
            index.menu()
            xd = False
