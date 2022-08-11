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
b = Fore.BLUE

def blockchunk():
    print(g+"- - - - - Blocks to Chunks - - - - -")
    blocks = int(input("Number of blocks: "))
    ch = blocks // 16
    print(blocks, "equals to", ch,"Chunks.")
    cc()

def chunkblock():
    print(g+"- - - - - Chunks to Blocks - - - - -")
    chunks = int(input("Number of chunks: "))
    bl = chunks * 16
    print(chunks, "equals to", bl, "Blocks")
    cc()


def cc():
    wa = True
    while wa:
        print(b+"- - - - - Choose an option - - - - -")
        print(b+"1. Blocks to Chunks")
        print(b+"2. Chunks to Blocks")
        print(c+"Write 'list' to go back.")
        cf = str(input("> "))
        if cf == "1":
            blockchunk()
            break
        elif cf == "2":
            chunkblock()
            break
        elif cf == "list":
            index.menu()
            break

