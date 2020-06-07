#pragma once

#include "utinni.h"

namespace utinni
{
class UTINNI_API Graphics
{
public:
    static void addPreUpdateLoopCallback(void (*func)(float elapsedTime));
    static void addPostUpdateLoopCallback(void (*func)(float elapsedTime));
    static void addPreBeginSceneCallback(void (*func)());
    static void addPostBeginSceneCallback(void (*func)());
    static void addPreEndSceneCallback(void (*func)());
    static void addPostEndSceneCallback(void (*func)());
    static void addPrePresentWindowCallback(void (*func)(HWND hwnd, int width, int height));
    static void addPostPresentWindowCallback(void (*func)(HWND hwnd, int width, int height));
    static void addPrePresentCallback(void (*func)());
    static void addPostPresentCallback(void (*func)());

    static void detour();

    static void useHardwareCursor(bool value);
    static void showMouseCursor(bool isShown);
    static void setSystemMouseCursorPosition(int X, int Y);

    static int getCurrentRenderTargetWidth();
    static int getCurrentRenderTargetHeight();

    static void flushResources(bool fullFlush);

    static void reloadTextures();
};
};

