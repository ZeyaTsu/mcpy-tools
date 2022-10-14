#include <stdio.h>

int blockchunk() {
    int blocks = 16;
    int ch;
    ch = blocks / 16;
    printf("%d equals to %d Chunks.", blocks, ch);
    return 0;
}

int chunkblock() {
    int chunks = 1;
    int bl;
    bl = chunks * 16;
    printf("%d equals to %d Blocks", chunks, bl);
}

/* TODO

loop to choose smth*/

