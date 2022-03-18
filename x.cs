using System.Runtime.InteropServices;

namespace X11;

using  __u_char = System.Byte;
using  __u_short = System.UInt16;
using  __u_int = System.UInt32;
using  __u_long = System.UInt64;
using  __int8_t = System.SByte;
using  __uint8_t = System.Byte;
using  __int16_t = System.Int16;
using  __uint16_t = System.UInt16;
using  __int32_t = System.Int32;
using  __uint32_t = System.UInt32;
using  __int64_t = System.Int64;
using  __uint64_t = System.UInt64;
using  __int_least8_t = System.SByte;
using  __uint_least8_t = System.SByte;
using  __int_least16_t = System.Int32;
using  __uint_least16_t = System.Int32;
using  __int_least32_t = System.Int32;
using  __uint_least32_t = System.Int32;
using  __int_least64_t = System.Int32;
using  __uint_least64_t = System.Int32;
using  __quad_t = System.Int64;
using  __u_quad_t = System.UInt64;
using  __intmax_t = System.Int64;
using  __uintmax_t = System.UInt64;
using  __dev_t = System.UInt64;
using  __uid_t = System.UInt32;
using  __gid_t = System.UInt32;
using  __ino_t = System.UInt64;
using  __ino64_t = System.UInt64;
using  __mode_t = System.UInt32;
using  __nlink_t = System.UInt64;
using  __off_t = System.Int64;
using  __off64_t = System.Int64;
using  __pid_t = System.Int32;
using  __clock_t = System.Int64;
using  __rlim_t = System.UInt64;
using  __rlim64_t = System.UInt64;
using  __id_t = System.UInt32;
using  __time_t = System.Int64;
using  __useconds_t = System.UInt32;
using  __suseconds_t = System.Int64;
using  __daddr_t = System.Int32;
using  __key_t = System.Int32;
using  __clockid_t = System.Int32;
using  __timer_t = System.IntPtr /*void*/;
using  __blksize_t = System.Int64;
using  __blkcnt_t = System.Int64;
using  __blkcnt64_t = System.Int64;
using  __fsblkcnt_t = System.UInt64;
using  __fsblkcnt64_t = System.UInt64;
using  __fsfilcnt_t = System.UInt64;
using  __fsfilcnt64_t = System.UInt64;
using  __fsword_t = System.Int64;
using  __ssize_t = System.Int64;
using  __syscall_slong_t = System.Int64;
using  __syscall_ulong_t = System.UInt64;
using  __loff_t = System.Int32;
using  __caddr_t = System.IntPtr /*System.SByte*/;
using  __intptr_t = System.Int64;
using  __socklen_t = System.UInt32;
using  __sig_atomic_t = System.Int32;
using  u_char = System.SByte;
using  u_short = System.Int32;
using  u_int = System.Int32;
using  u_long = System.Int32;
using  quad_t = System.Int32;
using  u_quad_t = System.Int32;
using  loff_t = System.Int32;
using  ino_t = System.Int32;
using  dev_t = System.Int32;
using  gid_t = System.Int32;
using  mode_t = System.Int32;
using  nlink_t = System.Int32;
using  uid_t = System.Int32;
using  off_t = System.Int32;
using  pid_t = System.Int32;
using  id_t = System.Int32;
using  ssize_t = System.Int32;
using  daddr_t = System.Int32;
using  caddr_t = System.SByte;
using  key_t = System.Int32;
using  clock_t = System.Int32;
using  clockid_t = System.Int32;
using  time_t = System.Int32;
using  timer_t = System.IntPtr;
using  int8_t = System.SByte;
using  int16_t = System.Int32;
using  int32_t = System.Int32;
using  int64_t = System.Int32;
using  u_int8_t = System.SByte;
using  u_int16_t = System.Int32;
using  u_int32_t = System.Int32;
using  u_int64_t = System.Int32;
using  suseconds_t = System.Int32;
using  __fd_mask = System.Int64;
using  fd_mask = System.Int32;
using  blksize_t = System.Int32;
using  blkcnt_t = System.Int32;
using  fsblkcnt_t = System.Int32;
using  fsfilcnt_t = System.Int32;
using  pthread_t = System.UInt64;
using  pthread_key_t = System.UInt32;
using  pthread_once_t = System.Int32;
using  XID = System.UInt64;
using  Mask = System.UInt64;
using  Atom = System.UInt64;
using  VisualID = System.UInt64;
using  Time = System.UInt64;
using  Window = System.Int64;
using  Drawable = System.Int64;
using  Font = System.Int64;
using  Pixmap = System.Int64;
using  Cursor = System.Int64;
using  Colormap = System.Int64;
using  GContext = System.Int64;
using  KeySym = System.Int64;
using  KeyCode = System.Byte;
using  ptrdiff_t = System.Int64;
using  wchar_t = System.Int32;
using  XPointer = System.IntPtr /*System.SByte*/;
using  GC = System.IntPtr /*|_XGC*|*/ ;
using  Display = System.IntPtr;
using  XOM = System.IntPtr /*|_XOM*|*/ ;
using  XIM = System.IntPtr /*|_XIM*|*/ ;
using  XIC = System.IntPtr /*|_XIC*|*/ ;
using  XIMStyle = System.UInt64;
using  XVaNestedList = System.IntPtr /*void*/;
using  XIMFeedback = System.UInt64;
using  XIMPreeditState = System.UInt64;
using  XIMResetState = System.UInt64;
using  XIMStringConversionFeedback = System.UInt64;
using  XIMStringConversionPosition = System.UInt16;
using  XIMStringConversionType = System.UInt16;
using  XIMStringConversionOperation = System.UInt16;
using  XIMHotKeyState = System.UInt64;
public unsafe struct __fsid_t {
    public unsafe fixed System.Int32 __val[2];
}

public unsafe struct __sigset_t {
}

public unsafe struct fd_set {
}

public unsafe struct __pthread_list_t {
    public unsafe System.IntPtr /*|__pthread_internal_list*|*/  __prev;
    public unsafe System.IntPtr /*|__pthread_internal_list*|*/  __next;
}

[StructLayout(LayoutKind.Explicit)]
public struct XEvent {
    [System.Runtime.InteropServices.FieldOffset(0)] public unsafe int type;		/* must not be changed; first element */
	[System.Runtime.InteropServices.FieldOffset(0)] public unsafe XAnyEvent xany;
	[System.Runtime.InteropServices.FieldOffset(0)] public unsafe XKeyEvent xkey;
	[System.Runtime.InteropServices.FieldOffset(0)] public unsafe XButtonEvent xbutton;
	[System.Runtime.InteropServices.FieldOffset(0)] public unsafe XMotionEvent xmotion;
	[System.Runtime.InteropServices.FieldOffset(0)] public unsafe XCrossingEvent xcrossing;
	[System.Runtime.InteropServices.FieldOffset(0)] public unsafe XFocusChangeEvent xfocus;
	[System.Runtime.InteropServices.FieldOffset(0)] public unsafe XExposeEvent xexpose;
	[System.Runtime.InteropServices.FieldOffset(0)] public unsafe XGraphicsExposeEvent xgraphicsexpose;
	[System.Runtime.InteropServices.FieldOffset(0)] public unsafe XNoExposeEvent xnoexpose;
	[System.Runtime.InteropServices.FieldOffset(0)] public unsafe XVisibilityEvent xvisibility;
	[System.Runtime.InteropServices.FieldOffset(0)] public unsafe XCreateWindowEvent xcreatewindow;
	[System.Runtime.InteropServices.FieldOffset(0)] public unsafe XDestroyWindowEvent xdestroywindow;
	[System.Runtime.InteropServices.FieldOffset(0)] public unsafe XUnmapEvent xunmap;
	[System.Runtime.InteropServices.FieldOffset(0)] public unsafe XMapEvent xmap;
	[System.Runtime.InteropServices.FieldOffset(0)] public unsafe XMapRequestEvent xmaprequest;
	[System.Runtime.InteropServices.FieldOffset(0)] public unsafe XReparentEvent xreparent;
	[System.Runtime.InteropServices.FieldOffset(0)] public unsafe XConfigureEvent xconfigure;
	[System.Runtime.InteropServices.FieldOffset(0)] public unsafe XGravityEvent xgravity;
	[System.Runtime.InteropServices.FieldOffset(0)] public unsafe XResizeRequestEvent xresizerequest;
	[System.Runtime.InteropServices.FieldOffset(0)] public unsafe XConfigureRequestEvent xconfigurerequest;
	[System.Runtime.InteropServices.FieldOffset(0)] public unsafe XCirculateEvent xcirculate;
	[System.Runtime.InteropServices.FieldOffset(0)] public unsafe XCirculateRequestEvent xcirculaterequest;
	[System.Runtime.InteropServices.FieldOffset(0)] public unsafe XPropertyEvent xproperty;
	[System.Runtime.InteropServices.FieldOffset(0)] public unsafe XSelectionClearEvent xselectionclear;
	[System.Runtime.InteropServices.FieldOffset(0)] public unsafe XSelectionRequestEvent xselectionrequest;
	[System.Runtime.InteropServices.FieldOffset(0)] public unsafe XSelectionEvent xselection;
	[System.Runtime.InteropServices.FieldOffset(0)] public unsafe XColormapEvent xcolormap;
	[System.Runtime.InteropServices.FieldOffset(0)] public unsafe XClientMessageEvent xclient;
	[System.Runtime.InteropServices.FieldOffset(0)] public unsafe XMappingEvent xmapping;
	[System.Runtime.InteropServices.FieldOffset(0)] public unsafe XErrorEvent xerror;
	[System.Runtime.InteropServices.FieldOffset(0)] public unsafe XKeymapEvent xkeymap;
	[System.Runtime.InteropServices.FieldOffset(0)] public unsafe XGenericEvent xgeneric;
	[System.Runtime.InteropServices.FieldOffset(0)] public unsafe XGenericEventCookie xcookie;
	[System.Runtime.InteropServices.FieldOffset(0)] public unsafe fixed long pad[24];
}

public unsafe struct __pthread_slist_t {
    public unsafe System.IntPtr /*|__pthread_internal_slist*|*/  __next;
}

public unsafe struct max_align_t {
}

public unsafe struct XExtData {
    public unsafe System.Int32 number;
    public unsafe System.IntPtr /*|_XExtData*|*/  next;
    public unsafe XPointer private_data;
}

public unsafe struct XExtCodes {
    public unsafe System.Int32 extension;
    public unsafe System.Int32 major_opcode;
    public unsafe System.Int32 first_event;
    public unsafe System.Int32 first_error;
}

public unsafe struct XPixmapFormatValues {
    public unsafe System.Int32 depth;
    public unsafe System.Int32 bits_per_pixel;
    public unsafe System.Int32 scanline_pad;
}

public unsafe struct XGCValues {
    public unsafe System.Int32 function;
    public unsafe System.UInt64 plane_mask;
    public unsafe System.UInt64 foreground;
    public unsafe System.UInt64 background;
    public unsafe System.Int32 line_width;
    public unsafe System.Int32 line_style;
    public unsafe System.Int32 cap_style;
    public unsafe System.Int32 join_style;
    public unsafe System.Int32 fill_style;
    public unsafe System.Int32 fill_rule;
    public unsafe System.Int32 arc_mode;
    public unsafe Pixmap tile;
    public unsafe Pixmap stipple;
    public unsafe System.Int32 ts_x_origin;
    public unsafe System.Int32 ts_y_origin;
    public unsafe Font font;
    public unsafe System.Int32 subwindow_mode;
    public unsafe System.Int32 graphics_exposures;
    public unsafe System.Int32 clip_x_origin;
    public unsafe System.Int32 clip_y_origin;
    public unsafe Pixmap clip_mask;
    public unsafe System.Int32 dash_offset;
    public unsafe System.SByte dashes;
}

public unsafe struct Visual {
    public unsafe System.IntPtr /*|XExtData*|*/  ext_data;
    public unsafe VisualID visualid;
    public unsafe System.Int32 class_;
    public unsafe System.Int32 bits_per_rgb;
    public unsafe System.Int32 map_entries;
}

public unsafe struct Depth {
    public unsafe System.Int32 depth;
    public unsafe System.Int32 nvisuals;
    public unsafe System.IntPtr /*|Visual*|*/  visuals;
}

public unsafe struct Screen {
    public unsafe System.IntPtr /*|XExtData*|*/  ext_data;
    public unsafe System.IntPtr /*|_XDisplay*|*/  display;
    public unsafe Window root;
    public unsafe System.Int32 ndepths;
    public unsafe System.IntPtr /*|Depth*|*/  depths;
    public unsafe System.Int32 root_depth;
    public unsafe System.IntPtr /*|Visual*|*/  root_visual;
    public unsafe GC default_gc;
    public unsafe Colormap cmap;
    public unsafe System.UInt64 white_pixel;
    public unsafe System.UInt64 black_pixel;
    public unsafe System.Int32 backing_store;
    public unsafe System.Int32 save_unders;
    public unsafe System.Int64 root_input_mask;
}

public unsafe struct ScreenFormat {
    public unsafe System.IntPtr /*|XExtData*|*/  ext_data;
    public unsafe System.Int32 depth;
    public unsafe System.Int32 bits_per_pixel;
    public unsafe System.Int32 scanline_pad;
}

public unsafe struct XSetWindowAttributes {
    public unsafe Pixmap background_pixmap;
    public unsafe System.UInt64 background_pixel;
    public unsafe Pixmap border_pixmap;
    public unsafe System.UInt64 border_pixel;
    public unsafe System.Int32 bit_gravity;
    public unsafe System.Int32 win_gravity;
    public unsafe System.Int32 backing_store;
    public unsafe System.UInt64 backing_planes;
    public unsafe System.UInt64 backing_pixel;
    public unsafe System.Int32 save_under;
    public unsafe System.Int64 event_mask;
    public unsafe System.Int64 do_not_propagate_mask;
    public unsafe System.Int32 override_redirect;
    public unsafe Colormap colormap;
    public unsafe Cursor cursor;
}

public unsafe struct XWindowAttributes {
    public unsafe System.Int32 border_width;
    public unsafe System.Int32 depth;
    public unsafe System.IntPtr /*|Visual*|*/  visual;
    public unsafe Window root;
    public unsafe System.Int32 class_;
    public unsafe System.Int32 bit_gravity;
    public unsafe System.Int32 win_gravity;
    public unsafe System.Int32 backing_store;
    public unsafe System.UInt64 backing_planes;
    public unsafe System.UInt64 backing_pixel;
    public unsafe System.Int32 save_under;
    public unsafe Colormap colormap;
    public unsafe System.Int32 map_installed;
    public unsafe System.Int32 map_state;
    public unsafe System.Int64 all_event_masks;
    public unsafe System.Int64 your_event_mask;
    public unsafe System.Int64 do_not_propagate_mask;
    public unsafe System.Int32 override_redirect;
    public unsafe System.IntPtr /*|Screen*|*/  screen;
}

public unsafe struct XHostAddress {
    public unsafe System.Int32 family;
    public unsafe System.Int32 length;
    public unsafe System.IntPtr /*System.SByte*/ address;
}

public unsafe struct XServerInterpretedAddress {
    public unsafe System.Int32 typelength;
    public unsafe System.Int32 valuelength;
    public unsafe System.IntPtr /*System.SByte*/ type;
    public unsafe System.IntPtr /*System.SByte*/ value;
}

public unsafe struct XImage {
    public unsafe System.Int32 xoffset;
    public unsafe System.Int32 format;
    public unsafe System.IntPtr /*System.SByte*/ data;
    public unsafe System.Int32 byte_order;
    public unsafe System.Int32 bitmap_unit;
    public unsafe System.Int32 bitmap_bit_order;
    public unsafe System.Int32 bitmap_pad;
    public unsafe System.Int32 depth;
    public unsafe System.Int32 bytes_per_line;
    public unsafe System.Int32 bits_per_pixel;
    public unsafe System.UInt64 red_mask;
    public unsafe System.UInt64 green_mask;
    public unsafe System.UInt64 blue_mask;
    public unsafe XPointer obdata;
    public unsafe IntPtr f;
}

public unsafe struct XWindowChanges {
    public unsafe System.Int32 border_width;
    public unsafe Window sibling;
    public unsafe System.Int32 stack_mode;
}

public unsafe struct XColor {
    public unsafe System.UInt64 pixel;
    public unsafe System.SByte flags;
    public unsafe System.SByte pad;
}

public unsafe struct XSegment {
}

public unsafe struct XPoint {
}

public unsafe struct XRectangle {
}

public unsafe struct XArc {
}

public unsafe struct XKeyboardControl {
    public unsafe System.Int32 key_click_percent;
    public unsafe System.Int32 bell_percent;
    public unsafe System.Int32 bell_pitch;
    public unsafe System.Int32 bell_duration;
    public unsafe System.Int32 led;
    public unsafe System.Int32 led_mode;
    public unsafe System.Int32 key;
    public unsafe System.Int32 auto_repeat_mode;
}

public unsafe struct XKeyboardState {
    public unsafe System.Int32 key_click_percent;
    public unsafe System.Int32 bell_percent;
    public unsafe System.UInt64 led_mask;
    public unsafe System.Int32 global_auto_repeat;
}

public unsafe struct XTimeCoord {
    public unsafe Time time;
}

public unsafe struct XModifierKeymap {
    public unsafe System.Int32 max_keypermod;
    public unsafe System.IntPtr /*|KeyCode*|*/  modifiermap;
}



public unsafe struct XKeyEvent {
    public unsafe System.Int32 type;
    public unsafe System.UInt64 serial;
    public unsafe System.Int32 send_event;
    public unsafe System.IntPtr /*|Display*|*/  display;
    public unsafe Window window;
    public unsafe Window root;
    public unsafe Window subwindow;
    public unsafe Time time;
    public unsafe System.UInt32 state;
    public unsafe System.UInt32 keycode;
    public unsafe System.Int32 same_screen;
}

public unsafe struct XButtonEvent {
    public unsafe System.Int32 type;
    public unsafe System.UInt64 serial;
    public unsafe System.Int32 send_event;
    public unsafe System.IntPtr /*|Display*|*/  display;
    public unsafe Window window;
    public unsafe Window root;
    public unsafe Window subwindow;
    public unsafe Time time;
    public unsafe System.UInt32 state;
    public unsafe System.UInt32 button;
    public unsafe System.Int32 same_screen;
}

public unsafe struct XMotionEvent {
    public unsafe System.Int32 type;
    public unsafe System.UInt64 serial;
    public unsafe System.Int32 send_event;
    public unsafe System.IntPtr /*|Display*|*/  display;
    public unsafe Window window;
    public unsafe Window root;
    public unsafe Window subwindow;
    public unsafe Time time;
    public unsafe System.UInt32 state;
    public unsafe System.SByte is_hint;
    public unsafe System.Int32 same_screen;
}

public unsafe struct XCrossingEvent {
    public unsafe System.Int32 type;
    public unsafe System.UInt64 serial;
    public unsafe System.Int32 send_event;
    public unsafe System.IntPtr /*|Display*|*/  display;
    public unsafe Window window;
    public unsafe Window root;
    public unsafe Window subwindow;
    public unsafe Time time;
    public unsafe System.Int32 mode;
    public unsafe System.Int32 detail;
    public unsafe System.Int32 same_screen;
    public unsafe System.Int32 focus;
    public unsafe System.UInt32 state;
}

public unsafe struct XFocusChangeEvent {
    public unsafe System.Int32 type;
    public unsafe System.UInt64 serial;
    public unsafe System.Int32 send_event;
    public unsafe System.IntPtr /*|Display*|*/  display;
    public unsafe Window window;
    public unsafe System.Int32 mode;
    public unsafe System.Int32 detail;
}

public unsafe struct XKeymapEvent {
    public unsafe System.Int32 type;
    public unsafe System.UInt64 serial;
    public unsafe System.Int32 send_event;
    public unsafe System.IntPtr /*|Display*|*/  display;
    public unsafe Window window;
}

public unsafe struct XExposeEvent {
    public unsafe System.Int32 type;
    public unsafe System.UInt64 serial;
    public unsafe System.Int32 send_event;
    public unsafe System.IntPtr /*|Display*|*/  display;
    public unsafe Window window;
    public unsafe System.Int32 count;
}

public unsafe struct XGraphicsExposeEvent {
    public unsafe System.Int32 type;
    public unsafe System.UInt64 serial;
    public unsafe System.Int32 send_event;
    public unsafe System.IntPtr /*|Display*|*/  display;
    public unsafe Drawable drawable;
    public unsafe System.Int32 count;
    public unsafe System.Int32 major_code;
    public unsafe System.Int32 minor_code;
}

public unsafe struct XNoExposeEvent {
    public unsafe System.Int32 type;
    public unsafe System.UInt64 serial;
    public unsafe System.Int32 send_event;
    public unsafe System.IntPtr /*|Display*|*/  display;
    public unsafe Drawable drawable;
    public unsafe System.Int32 major_code;
    public unsafe System.Int32 minor_code;
}

public unsafe struct XVisibilityEvent {
    public unsafe System.Int32 type;
    public unsafe System.UInt64 serial;
    public unsafe System.Int32 send_event;
    public unsafe System.IntPtr /*|Display*|*/  display;
    public unsafe Window window;
    public unsafe System.Int32 state;
}

public unsafe struct XCreateWindowEvent {
    public unsafe System.Int32 type;
    public unsafe System.UInt64 serial;
    public unsafe System.Int32 send_event;
    public unsafe System.IntPtr /*|Display*|*/  display;
    public unsafe Window parent;
    public unsafe Window window;
    public unsafe System.Int32 border_width;
    public unsafe System.Int32 override_redirect;
}

public unsafe struct XDestroyWindowEvent {
    public unsafe System.Int32 type;
    public unsafe System.UInt64 serial;
    public unsafe System.Int32 send_event;
    public unsafe System.IntPtr /*|Display*|*/  display;
    public unsafe Window event_;
    public unsafe Window window;
}

public unsafe struct XUnmapEvent {
    public unsafe System.Int32 type;
    public unsafe System.UInt64 serial;
    public unsafe System.Int32 send_event;
    public unsafe System.IntPtr /*|Display*|*/  display;
    public unsafe Window event_;
    public unsafe Window window;
    public unsafe System.Int32 from_configure;
}

public unsafe struct XMapEvent {
    public unsafe System.Int32 type;
    public unsafe System.UInt64 serial;
    public unsafe System.Int32 send_event;
    public unsafe System.IntPtr /*|Display*|*/  display;
    public unsafe Window event_;
    public unsafe Window window;
    public unsafe System.Int32 override_redirect;
}

public unsafe struct XMapRequestEvent {
    public unsafe System.Int32 type;
    public unsafe System.UInt64 serial;
    public unsafe System.Int32 send_event;
    public unsafe System.IntPtr /*|Display*|*/  display;
    public unsafe Window parent;
    public unsafe Window window;
}

public unsafe struct XReparentEvent {
    public unsafe System.Int32 type;
    public unsafe System.UInt64 serial;
    public unsafe System.Int32 send_event;
    public unsafe System.IntPtr /*|Display*|*/  display;
    public unsafe Window event_;
    public unsafe Window window;
    public unsafe Window parent;
    public unsafe System.Int32 override_redirect;
}

public unsafe struct XConfigureEvent {
    public unsafe System.Int32 type;
    public unsafe System.UInt64 serial;
    public unsafe System.Int32 send_event;
    public unsafe System.IntPtr /*|Display*|*/  display;
    public unsafe Window event_;
    public unsafe Window window;
    public unsafe System.Int32 border_width;
    public unsafe Window above;
    public unsafe System.Int32 override_redirect;
}

public unsafe struct XGravityEvent {
    public unsafe System.Int32 type;
    public unsafe System.UInt64 serial;
    public unsafe System.Int32 send_event;
    public unsafe System.IntPtr /*|Display*|*/  display;
    public unsafe Window event_;
    public unsafe Window window;
}

public unsafe struct XResizeRequestEvent {
    public unsafe System.Int32 type;
    public unsafe System.UInt64 serial;
    public unsafe System.Int32 send_event;
    public unsafe System.IntPtr /*|Display*|*/  display;
    public unsafe Window window;
}

public unsafe struct XConfigureRequestEvent {
    public unsafe System.Int32 type;
    public unsafe System.UInt64 serial;
    public unsafe System.Int32 send_event;
    public unsafe System.IntPtr /*|Display*|*/  display;
    public unsafe Window parent;
    public unsafe Window window;
    public unsafe System.Int32 border_width;
    public unsafe Window above;
    public unsafe System.Int32 detail;
    public unsafe System.UInt64 value_mask;
}

public unsafe struct XCirculateEvent {
    public unsafe System.Int32 type;
    public unsafe System.UInt64 serial;
    public unsafe System.Int32 send_event;
    public unsafe System.IntPtr /*|Display*|*/  display;
    public unsafe Window event_;
    public unsafe Window window;
    public unsafe System.Int32 place;
}

public unsafe struct XCirculateRequestEvent {
    public unsafe System.Int32 type;
    public unsafe System.UInt64 serial;
    public unsafe System.Int32 send_event;
    public unsafe System.IntPtr /*|Display*|*/  display;
    public unsafe Window parent;
    public unsafe Window window;
    public unsafe System.Int32 place;
}

public unsafe struct XPropertyEvent {
    public unsafe System.Int32 type;
    public unsafe System.UInt64 serial;
    public unsafe System.Int32 send_event;
    public unsafe System.IntPtr /*|Display*|*/  display;
    public unsafe Window window;
    public unsafe Atom atom;
    public unsafe Time time;
    public unsafe System.Int32 state;
}

public unsafe struct XSelectionClearEvent {
    public unsafe System.Int32 type;
    public unsafe System.UInt64 serial;
    public unsafe System.Int32 send_event;
    public unsafe System.IntPtr /*|Display*|*/  display;
    public unsafe Window window;
    public unsafe Atom selection;
    public unsafe Time time;
}

public unsafe struct XSelectionRequestEvent {
    public unsafe System.Int32 type;
    public unsafe System.UInt64 serial;
    public unsafe System.Int32 send_event;
    public unsafe System.IntPtr /*|Display*|*/  display;
    public unsafe Window owner;
    public unsafe Window requestor;
    public unsafe Atom selection;
    public unsafe Atom target;
    public unsafe Atom property;
    public unsafe Time time;
}

public unsafe struct XSelectionEvent {
    public unsafe System.Int32 type;
    public unsafe System.UInt64 serial;
    public unsafe System.Int32 send_event;
    public unsafe System.IntPtr /*|Display*|*/  display;
    public unsafe Window requestor;
    public unsafe Atom selection;
    public unsafe Atom target;
    public unsafe Atom property;
    public unsafe Time time;
}

public unsafe struct XColormapEvent {
    public unsafe System.Int32 type;
    public unsafe System.UInt64 serial;
    public unsafe System.Int32 send_event;
    public unsafe System.IntPtr /*|Display*|*/  display;
    public unsafe Window window;
    public unsafe Colormap colormap;
    public unsafe System.Int32 new_;
    public unsafe System.Int32 state;
}

public unsafe struct XEDataObject{ 
    public unsafe Display *display;
    public unsafe GC gc;
    public unsafe Visual *visual;
    public unsafe Screen *screen;
    public unsafe ScreenFormat *pixmap_format;
    public unsafe XFontStruct *font; 
}

public unsafe struct XClientMessageEvent {
    public unsafe System.Int32 type;
    public unsafe System.UInt64 serial;
    public unsafe System.Int32 send_event;
    public unsafe System.IntPtr /*|Display*|*/  display;
    public unsafe Window window;
    public unsafe Atom message_type;
    public unsafe System.Int32 format;
    public unsafe fixed System.Int64 l[5];
    public unsafe fixed char data[20];
}

public unsafe struct XMappingEvent {
    public unsafe System.Int32 type;
    public unsafe System.UInt64 serial;
    public unsafe System.Int32 send_event;
    public unsafe System.IntPtr /*|Display*|*/  display;
    public unsafe Window window;
    public unsafe System.Int32 request;
    public unsafe System.Int32 first_keycode;
    public unsafe System.Int32 count;
}

public unsafe struct XErrorEvent {
    public unsafe System.Int32 type;
    public unsafe System.IntPtr /*|Display*|*/  display;
    public unsafe XID resourceid;
    public unsafe System.UInt64 serial;
    public unsafe System.Byte error_code;
    public unsafe System.Byte request_code;
    public unsafe System.Byte minor_code;
}

public unsafe struct XAnyEvent {
    public unsafe System.Int32 type;
    public unsafe System.UInt64 serial;
    public unsafe System.Int32 send_event;
    public unsafe System.IntPtr /*|Display*|*/  display;
    public unsafe Window window;
}

public unsafe struct XGenericEvent {
    public unsafe System.Int32 type;
    public unsafe System.UInt64 serial;
    public unsafe System.Int32 send_event;
    public unsafe System.IntPtr /*|Display*|*/  display;
    public unsafe System.Int32 extension;
    public unsafe System.Int32 evtype;
}

public unsafe struct XGenericEventCookie {
    public unsafe System.Int32 type;
    public unsafe System.UInt64 serial;
    public unsafe System.Int32 send_event;
    public unsafe System.IntPtr /*|Display*|*/  display;
    public unsafe System.Int32 extension;
    public unsafe System.Int32 evtype;
    public unsafe System.UInt32 cookie;
    public unsafe System.IntPtr /*void*/ data;
}

public unsafe struct XCharStruct {
    public unsafe System.Int16 lbearing;
    public unsafe System.Int16 rbearing;
    public unsafe System.Int16 width;
    public unsafe System.Int16 ascent;
    public unsafe System.Int16 descent;
    public unsafe System.UInt16 attributes;
}

public unsafe struct XFontProp {
    public unsafe Atom name;
    public unsafe System.UInt64 card32;
}

public unsafe struct XFontStruct {
    public unsafe System.IntPtr /*|XExtData*|*/  ext_data;
    public unsafe Font fid;
    public unsafe uint direction;
    public unsafe uint min_char_or_byte2;
    public unsafe uint max_char_or_byte2;
    public unsafe uint min_byte1;
    public unsafe uint max_byte1;
    public unsafe System.Int32 all_chars_exist;
    public unsafe uint default_char;
    public unsafe System.Int32 n_properties;
    public unsafe System.IntPtr /*|XFontProp*|*/  properties;
    public unsafe XCharStruct min_bounds;
    public unsafe XCharStruct max_bounds;
    public unsafe System.IntPtr /*|XCharStruct*|*/  per_char;
    public unsafe System.Int32 ascent;
    public unsafe System.Int32 descent;
}

public unsafe struct XTextItem {
    public unsafe System.IntPtr /*System.SByte*/ chars;
    public unsafe System.Int32 nchars;
    public unsafe System.Int32 delta;
    public unsafe Font font;
}

public unsafe struct XChar2b {
    public unsafe System.Byte byte1;
    public unsafe System.Byte byte2;
}

public unsafe struct XTextItem16 {
    public unsafe System.IntPtr /*|XChar2b*|*/  chars;
    public unsafe System.Int32 nchars;
    public unsafe System.Int32 delta;
    public unsafe Font font;
}

public unsafe struct XFontSetExtents {
    public unsafe XRectangle max_ink_extent;
    public unsafe XRectangle max_logical_extent;
}

public unsafe struct XmbTextItem {
    public unsafe System.IntPtr /*System.SByte*/ chars;
    public unsafe System.Int32 nchars;
    public unsafe System.Int32 delta;
    public unsafe IntPtr font_set;
}

public unsafe struct XwcTextItem {
    public unsafe System.IntPtr /*|wchar_t*|*/  chars;
    public unsafe System.Int32 nchars;
    public unsafe System.Int32 delta;
    public unsafe IntPtr font_set;
}

public unsafe struct XOMCharSetList {
    public unsafe System.Int32 charset_count;
    public unsafe System.IntPtr /*System.SByte*/ charset_list;
}

public unsafe struct XOMOrientation {
    public unsafe System.Int32 num_orientation;
    public unsafe System.IntPtr /*|XOrientation*|*/  orientation;
}

public unsafe struct XOMFontInfo {
    public unsafe System.Int32 num_font;
    public unsafe System.IntPtr /*|XFontStruct**|*/  font_struct_list;
    public unsafe System.IntPtr /*System.SByte*/ font_name_list;
}

public unsafe struct XIMStyles {
    public unsafe System.UInt16 count_styles;
    public unsafe System.IntPtr /*|XIMStyle*|*/  supported_styles;
}

public unsafe struct XIMCallback {
    public unsafe XPointer client_data;
    public unsafe IntPtr callback;
}

public unsafe struct XICCallback {
    public unsafe XPointer client_data;
    public unsafe IntPtr callback;
}

public unsafe struct XIMText {
    public unsafe System.UInt16 length;
    public unsafe System.IntPtr /*|XIMFeedback*|*/  feedback;
    public unsafe System.Int32 encoding_is_wchar;
    public unsafe System.IntPtr /*System.SByte*/ multi_byte;
    public unsafe System.IntPtr /*|wchar_t*|*/  wide_char;
    public unsafe IntPtr string_;
}

public unsafe struct XIMPreeditStateNotifyCallbackStruct {
    public unsafe XIMPreeditState state;
}

public unsafe struct XIMStringConversionText {
    public unsafe System.UInt16 length;
    public unsafe System.IntPtr /*|XIMStringConversionFeedback*|*/  feedback;
    public unsafe System.Int32 encoding_is_wchar;
    public unsafe System.IntPtr /*System.SByte*/ mbs;
    public unsafe System.IntPtr /*|wchar_t*|*/  wcs;
    public unsafe IntPtr string_;
}

public unsafe struct XIMStringConversionCallbackStruct {
    public unsafe XIMStringConversionPosition position;
    public unsafe int direction;
    public unsafe XIMStringConversionOperation operation;
    public unsafe System.UInt16 factor;
    public unsafe System.IntPtr /*|XIMStringConversionText*|*/  text;
}

public unsafe struct XIMPreeditDrawCallbackStruct {
    public unsafe System.Int32 caret;
    public unsafe System.Int32 chg_first;
    public unsafe System.Int32 chg_length;
    public unsafe System.IntPtr /*|XIMText*|*/  text;
}

public unsafe struct XIMPreeditCaretCallbackStruct {
    public unsafe System.Int32 position;
    public unsafe int direction;
    public unsafe int style;
}

public unsafe struct XIMStatusDrawCallbackStruct {
    public unsafe int type;
    public unsafe System.IntPtr /*|XIMText*|*/  text;
    public unsafe Pixmap bitmap;
    public unsafe IntPtr data;
}

public unsafe struct XIMHotKeyTrigger {
    public unsafe KeySym keysym;
    public unsafe System.Int32 modifier;
    public unsafe System.Int32 modifier_mask;
}

public unsafe struct XIMHotKeyTriggers {
    public unsafe System.Int32 num_hot_key;
    public unsafe System.IntPtr /*|XIMHotKeyTrigger*|*/  key;
}

public unsafe struct XIMValuesList {
    public unsafe System.UInt16 count_values;
    public unsafe System.IntPtr /*System.SByte*/ supported_values;
}



public static class X{
    public const string LibPath = "libX11.so";
    
    
    public const string XNRequiredCharSet = "requiredCharSet";
    public const string XNQueryOrientation = "queryOrientation";
    public const string XNBaseFontName = "baseFontName";
    public const string XNOMAutomatic = "omAutomatic";
    public const string XNMissingCharSet = "missingCharSet";
    public const string XNDefaultString = "defaultString";
    public const string XNOrientation = "orientation";
    public const string XNDirectionalDependentDrawing = "directionalDependentDrawing";
    public const string XNContextualDrawing = "contextualDrawing";
    public const string XNFontInfo = "fontInfo";
    public const string XNVaNestedList = "XNVaNestedList";
    public const string XNQueryInputStyle = "queryInputStyle";
    public const string XNClientWindow = "clientWindow";
    public const string XNInputStyle = "inputStyle";
    public const string XNFocusWindow = "focusWindow";
    public const string XNResourceName = "resourceName";
    public const string XNResourceClass = "resourceClass";
    public const string XNGeometryCallback = "geometryCallback";
    public const string XNDestroyCallback = "destroyCallback";
    public const string XNFilterEvents = "filterEvents";
    public const string XNPreeditStartCallback = "preeditStartCallback";
    public const string XNPreeditDoneCallback = "preeditDoneCallback";
    public const string XNPreeditDrawCallback = "preeditDrawCallback";
    public const string XNPreeditCaretCallback = "preeditCaretCallback";
    public const string XNPreeditStateNotifyCallback = "preeditStateNotifyCallback";
    public const string XNPreeditAttributes = "preeditAttributes";
    public const string XNStatusStartCallback = "statusStartCallback";
    public const string XNStatusDoneCallback = "statusDoneCallback";
    public const string XNStatusDrawCallback = "statusDrawCallback";
    public const string XNStatusAttributes = "statusAttributes";
    public const string XNArea = "area";
    public const string XNAreaNeeded = "areaNeeded";
    public const string XNSpotLocation = "spotLocation";
    public const string XNColormap = "colorMap";
    public const string XNStdColormap = "stdColorMap";
    public const string XNForeground = "foreground";
    public const string XNBackground = "background";
    public const string XNBackgroundPixmap = "backgroundPixmap";
    public const string XNFontSet = "fontSet";
    public const string XNLineSpace = "lineSpace";
    public const string XNCursor = "cursor";
    public const string XNQueryIMValuesList = "queryIMValuesList";
    public const string XNQueryICValuesList = "queryICValuesList";
    public const string XNVisiblePosition = "visiblePosition";
    public const string XNR6PreeditCallback = "r6PreeditCallback";
    public const string XNStringConversionCallback = "stringConversionCallback";
    public const string XNStringConversion = "stringConversion";
    public const string XNResetState = "resetState";
    public const string XNHotKey = "hotKey";
    public const string XNHotKeyState = "hotKeyState";
    public const string XNPreeditState = "preeditState";
    public const string XNSeparatorofNestedList = "separatorofNestedList";
    public const long X_HAVE_UTF8_STRING = 1;
    public const long True = 1;
    public const long False = 0;
    public const long QueuedAlready = 0;
    public const long QueuedAfterReading = 1;
    public const long QueuedAfterFlush = 2;
    public const long AllPlanes = ((long)~0L);
    public const long XIMPreeditArea = 0x0001L;
    public const long XIMPreeditCallbacks = 0x0002L;
    public const long XIMPreeditPosition = 0x0004L;
    public const long XIMPreeditNothing = 0x0008L;
    public const long XIMPreeditNone = 0x0010L;
    public const long XIMStatusArea = 0x0100L;
    public const long XIMStatusCallbacks = 0x0200L;
    public const long XIMStatusNothing = 0x0400L;
    public const long XIMStatusNone = 0x0800L;
    public const long XBufferOverflow = -1;
    public const long XLookupNone = 1;
    public const long XLookupChars = 2;
    public const long XLookupKeySym = 3;
    public const long XLookupBoth = 4;
    public const long XIMReverse = 1L;
    public const long XIMUnderline = (1L<<1);
    public const long XIMHighlight = (1L<<2);
    public const long XIMPrimary = (1L<<5);
    public const long XIMSecondary = (1L<<6);
    public const long XIMTertiary = (1L<<7);
    public const long XIMVisibleToForward = (1L<<8);
    public const long XIMVisibleToBackword = (1L<<9);
    public const long XIMVisibleToCenter = (1L<<10);
    public const long XIMPreeditUnKnown = 0L;
    public const long XIMPreeditEnable = 1L;
    public const long XIMPreeditDisable = (1L<<1);
    public const long XIMInitialState = 1L;
    public const long XIMPreserveState = (1L<<1);
    public const long XIMStringConversionLeftEdge = (0x00000001);
    public const long XIMStringConversionRightEdge = (0x00000002);
    public const long XIMStringConversionTopEdge = (0x00000004);
    public const long XIMStringConversionBottomEdge = (0x00000008);
    public const long XIMStringConversionConcealed = (0x00000010);
    public const long XIMStringConversionWrapped = (0x00000020);
    public const long XIMStringConversionBuffer = (0x0001);
    public const long XIMStringConversionLine = (0x0002);
    public const long XIMStringConversionWord = (0x0003);
    public const long XIMStringConversionChar = (0x0004);
    public const long XIMStringConversionSubstitution = (0x0001);
    public const long XIMStringConversionRetrieval = (0x0002);
    public const long XIMHotKeyStateON = (0x0001L);
    public const long XIMHotKeyStateOFF = (0x0002L);
    
    
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 _Xmblen ( System.IntPtr /*System.SByte*/ str, System.Int32 len);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*|XFontStruct*|*/  XLoadQueryFont ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.SByte*/ arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*|XFontStruct*|*/  XQueryFont ( System.IntPtr /*|Display*|*/  arg0, XID arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*|XTimeCoord*|*/  XGetMotionEvents ( System.IntPtr /*|Display*|*/  arg0, Window arg1, Time arg2, Time arg3, System.IntPtr /*System.Int32*/ arg4);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*|XModifierKeymap*|*/  XDeleteModifiermapEntry ( System.IntPtr /*|XModifierKeymap*|*/  arg0, KeyCode arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*|XModifierKeymap*|*/  XGetModifierMapping ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*|XModifierKeymap*|*/  XInsertModifiermapEntry ( System.IntPtr /*|XModifierKeymap*|*/  arg0, KeyCode arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*|XModifierKeymap*|*/  XNewModifiermap ( System.Int32 arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*|XImage*|*/  XCreateImage ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|Visual*|*/  arg1, System.Int32 arg2, System.Int32 arg3, System.Int32 arg4, System.IntPtr /*System.SByte*/ arg5, System.Int32 arg6, System.Int32 arg7, System.Int32 arg8, System.Int32 arg9);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XInitImage ( System.IntPtr /*|XImage*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*|XImage*|*/  XGetImage ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, System.Int32 arg2, System.Int32 arg3, System.Int32 arg4, System.Int32 arg5, System.Int64 arg6, System.Int32 arg7);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*|XImage*|*/  XGetSubImage ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, System.Int32 arg2, System.Int32 arg3, System.Int32 arg4, System.Int32 arg5, System.Int64 arg6, System.Int32 arg7, System.IntPtr /*|XImage*|*/  arg8, System.Int32 arg9, System.Int32 arg10);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*|Display*|*/  XOpenDisplay ( System.IntPtr /*System.SByte*/ arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern void XrmInitialize ();
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*System.SByte*/ XFetchBytes ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.Int32*/ arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*System.SByte*/ XFetchBuffer ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.Int32*/ arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*System.SByte*/ XGetAtomName ( System.IntPtr /*|Display*|*/  arg0, Atom arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XGetAtomNames ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|Atom*|*/  arg1, System.Int32 arg2, System.IntPtr /*System.SByte*/ arg3);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*System.SByte*/ XGetDefault ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.SByte*/ arg1, System.IntPtr /*System.SByte*/ arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*System.SByte*/ XDisplayName ( System.IntPtr /*System.SByte*/ arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*System.SByte*/ XKeysymToString ( KeySym arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern Atom XInternAtom ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.SByte*/ arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XInternAtoms ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.SByte*/ arg1, System.Int32 arg2, System.Int32 arg3, System.IntPtr /*|Atom*|*/  arg4);
    
    [DllImport(LibPath)]
    public static unsafe extern Colormap XCopyColormapAndFree ( System.IntPtr /*|Display*|*/  arg0, Colormap arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern Colormap XCreateColormap ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.IntPtr /*|Visual*|*/  arg2, System.Int32 arg3);
    
    [DllImport(LibPath)]
    public static unsafe extern Cursor XCreatePixmapCursor ( System.IntPtr /*|Display*|*/  arg0, Pixmap arg1, Pixmap arg2, System.IntPtr /*|XColor*|*/  arg3, System.IntPtr /*|XColor*|*/  arg4, System.Int32 arg5, System.Int32 arg6);
    
    [DllImport(LibPath)]
    public static unsafe extern Cursor XCreateGlyphCursor ( System.IntPtr /*|Display*|*/  arg0, Font arg1, Font arg2, System.Int32 arg3, System.Int32 arg4, System.IntPtr /*|XColor*|*/  arg5, System.IntPtr /*|XColor*|*/  arg6);
    
    [DllImport(LibPath)]
    public static unsafe extern Cursor XCreateFontCursor ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern Font XLoadFont ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.SByte*/ arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern GC XCreateGC ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, System.Int64 arg2, System.IntPtr /*|XGCValues*|*/  arg3);
    
    [DllImport(LibPath)]
    public static unsafe extern GContext XGContextFromGC ( GC arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern void XFlushGC ( System.IntPtr /*|Display*|*/  arg0, GC arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern Pixmap XCreatePixmap ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, System.Int32 arg2, System.Int32 arg3, System.Int32 arg4);
    
    [DllImport(LibPath)]
    public static unsafe extern Pixmap XCreateBitmapFromData ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, System.IntPtr /*System.SByte*/ arg2, System.Int32 arg3, System.Int32 arg4);
    
    [DllImport(LibPath)]
    public static unsafe extern Pixmap XCreatePixmapFromBitmapData ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, System.IntPtr /*System.SByte*/ arg2, System.Int32 arg3, System.Int32 arg4, System.Int64 arg5, System.Int64 arg6, System.Int32 arg7);
    
    [DllImport(LibPath)]
    public static unsafe extern Window XCreateSimpleWindow ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int32 arg2, System.Int32 arg3, System.UInt32 arg4, System.UInt32 arg5, System.UInt32 arg6, System.Int64 arg7, System.Int64 arg8);
    
    [DllImport(LibPath)]
    public static unsafe extern Window XGetSelectionOwner ( System.IntPtr /*|Display*|*/  arg0, Atom arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern Window XCreateWindow ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int32 arg2, System.Int32 arg3, System.Int32 arg4, System.Int32 arg5, System.Int32 arg6, System.Int32 arg7, System.Int32 arg8, System.IntPtr /*|Visual*|*/  arg9, System.Int64 arg10, System.IntPtr /*|XSetWindowAttributes*|*/  arg11);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*|Colormap*|*/  XListInstalledColormaps ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.IntPtr /*System.Int32*/ arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*System.SByte*/ XListFonts ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.SByte*/ arg1, System.Int32 arg2, System.IntPtr /*System.Int32*/ arg3);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*System.SByte*/ XListFontsWithInfo ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.SByte*/ arg1, System.Int32 arg2, System.IntPtr /*System.Int32*/ arg3, System.IntPtr /*|XFontStruct**|*/  arg4);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*System.SByte*/ XGetFontPath ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.Int32*/ arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*System.SByte*/ XListExtensions ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.Int32*/ arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*|Atom*|*/  XListProperties ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.IntPtr /*System.Int32*/ arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*|XHostAddress*|*/  XListHosts ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.Int32*/ arg1, System.IntPtr /*System.Int32*/ arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern KeySym XKeycodeToKeysym ( System.IntPtr /*|Display*|*/  arg0, KeyCode arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern KeySym XLookupKeysym ( System.IntPtr /*|XKeyEvent*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*|KeySym*|*/  XGetKeyboardMapping ( System.IntPtr /*|Display*|*/  arg0, KeyCode arg1, System.Int32 arg2, System.IntPtr /*System.Int32*/ arg3);
    
    [DllImport(LibPath)]
    public static unsafe extern KeySym XStringToKeysym ( System.IntPtr /*System.SByte*/ arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int64 XMaxRequestSize ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int64 XExtendedMaxRequestSize ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*System.SByte*/ XResourceManagerString ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*System.SByte*/ XScreenResourceString ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.UInt64 XDisplayMotionBufferSize ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern VisualID XVisualIDFromVisual ( System.IntPtr /*|Visual*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XInitThreads ();
    
    [DllImport(LibPath)]
    public static unsafe extern void XLockDisplay ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern void XUnlockDisplay ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*|XExtCodes*|*/  XInitExtension ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.SByte*/ arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*|XExtCodes*|*/  XAddExtension ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*|XExtData*|*/  XFindOnExtensionList ( System.IntPtr /*|XExtData**|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*|XExtData**|*/  XEHeadOfExtensionList ( XEDataObject arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern Window XRootWindow ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern Window XDefaultRootWindow ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern Window XRootWindowOfScreen ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*|Visual*|*/  XDefaultVisual ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*|Visual*|*/  XDefaultVisualOfScreen ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern GC XDefaultGC ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern GC XDefaultGCOfScreen ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.UInt64 XBlackPixel ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.UInt64 XWhitePixel ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.UInt64 XAllPlanes ();
    
    [DllImport(LibPath)]
    public static unsafe extern System.UInt64 XBlackPixelOfScreen ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.UInt64 XWhitePixelOfScreen ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.UInt64 XNextRequest ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.UInt64 XLastKnownRequestProcessed ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*System.SByte*/ XServerVendor ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*System.SByte*/ XDisplayString ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern Colormap XDefaultColormap ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern Colormap XDefaultColormapOfScreen ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*|Display*|*/  XDisplayOfScreen ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*|Screen*|*/  XScreenOfDisplay ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*|Screen*|*/  XDefaultScreenOfDisplay ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int64 XEventMaskOfScreen ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XScreenNumberOfScreen ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern IntPtr XSetErrorHandler ( IntPtr arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern IntPtr XSetIOErrorHandler ( IntPtr arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*|XPixmapFormatValues*|*/  XListPixmapFormats ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.Int32*/ arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*System.Int32*/ XListDepths ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1, System.IntPtr /*System.Int32*/ arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XReconfigureWMWindow ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int32 arg2, System.Int32 arg3, System.IntPtr /*|XWindowChanges*|*/  arg4);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XGetWMProtocols ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.IntPtr /*|Atom**|*/  arg2, System.IntPtr /*System.Int32*/ arg3);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSetWMProtocols ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.IntPtr /*|Atom*|*/  arg2, System.Int32 arg3);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XIconifyWindow ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XWithdrawWindow ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XGetCommand ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.IntPtr /*System.SByte*/ arg2, System.IntPtr /*System.Int32*/ arg3);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XGetWMColormapWindows ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.IntPtr /*|Window**|*/  arg2, System.IntPtr /*System.Int32*/ arg3);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSetWMColormapWindows ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.IntPtr /*|Window*|*/  arg2, System.Int32 arg3);
    
    [DllImport(LibPath)]
    public static unsafe extern void XFreeStringList ( System.IntPtr /*System.SByte*/ arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSetTransientForHint ( System.IntPtr /*|Display*|*/  arg0, Window arg1, Window arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XActivateScreenSaver ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XAddHost ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|XHostAddress*|*/  arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XAddHosts ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|XHostAddress*|*/  arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XAddToExtensionList ( System.IntPtr /*|_XExtData**|*/  arg0, System.IntPtr /*|XExtData*|*/  arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XAddToSaveSet ( System.IntPtr /*|Display*|*/  arg0, Window arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XAllocColor ( System.IntPtr /*|Display*|*/  arg0, Colormap arg1, System.IntPtr /*|XColor*|*/  arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XAllocColorCells ( System.IntPtr /*|Display*|*/  arg0, Colormap arg1, System.Int32 arg2, System.IntPtr /*System.Int64*/ arg3, System.Int32 arg4, System.IntPtr /*System.Int64*/ arg5, System.Int32 arg6);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XAllocColorPlanes ( System.IntPtr /*|Display*|*/  arg0, Colormap arg1, System.Int32 arg2, System.IntPtr /*System.Int64*/ arg3, System.Int32 arg4, System.Int32 arg5, System.Int32 arg6, System.Int32 arg7, System.IntPtr /*System.Int64*/ arg8, System.IntPtr /*System.Int64*/ arg9, System.IntPtr /*System.Int64*/ arg10);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XAllocNamedColor ( System.IntPtr /*|Display*|*/  arg0, Colormap arg1, System.IntPtr /*System.SByte*/ arg2, System.IntPtr /*|XColor*|*/  arg3, System.IntPtr /*|XColor*|*/  arg4);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XAllowEvents ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1, Time arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XAutoRepeatOff ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XAutoRepeatOn ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XBell ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XBitmapBitOrder ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XBitmapPad ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XBitmapUnit ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XCellsOfScreen ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XChangeActivePointerGrab ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1, Cursor arg2, Time arg3);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XChangeGC ( System.IntPtr /*|Display*|*/  arg0, GC arg1, System.Int64 arg2, System.IntPtr /*|XGCValues*|*/  arg3);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XChangeKeyboardControl ( System.IntPtr /*|Display*|*/  arg0, System.Int64 arg1, System.IntPtr /*|XKeyboardControl*|*/  arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XChangeKeyboardMapping ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1, System.Int32 arg2, System.IntPtr /*|KeySym*|*/  arg3, System.Int32 arg4);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XChangePointerControl ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1, System.Int32 arg2, System.Int32 arg3, System.Int32 arg4, System.Int32 arg5);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XChangeProperty ( System.IntPtr /*|Display*|*/  arg0, Window arg1, Atom arg2, Atom arg3, System.Int32 arg4, System.Int32 arg5, System.IntPtr /*System.SByte*/ arg6, System.Int32 arg7);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XChangeSaveSet ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XChangeWindowAttributes ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int64 arg2, System.IntPtr /*|XSetWindowAttributes*|*/  arg3);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XCheckIfEvent ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|XEvent*|*/  arg1, System.Int32 arg2, System.IntPtr /*|Display*|*/  arg3, System.IntPtr /*|XEvent*|*/  arg4, XPointer arg5, XPointer arg6);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XCheckMaskEvent ( System.IntPtr /*|Display*|*/  arg0, System.Int64 arg1, System.IntPtr /*|XEvent*|*/  arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XCheckTypedEvent ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1, System.IntPtr /*|XEvent*|*/  arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XCheckTypedWindowEvent ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int32 arg2, System.IntPtr /*|XEvent*|*/  arg3);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XCheckWindowEvent ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int64 arg2, System.IntPtr /*|XEvent*|*/  arg3);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XCirculateSubwindows ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XCirculateSubwindowsDown ( System.IntPtr /*|Display*|*/  arg0, Window arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XCirculateSubwindowsUp ( System.IntPtr /*|Display*|*/  arg0, Window arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XClearArea ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int32 arg2, System.Int32 arg3, System.Int32 arg4, System.Int32 arg5, System.Int32 arg6);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XClearWindow ( System.IntPtr /*|Display*|*/  arg0, Window arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XCloseDisplay ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XConfigureWindow ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int32 arg2, System.IntPtr /*|XWindowChanges*|*/  arg3);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XConnectionNumber ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XConvertSelection ( System.IntPtr /*|Display*|*/  arg0, Atom arg1, Atom arg2, Atom arg3, Window arg4, Time arg5);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XCopyArea ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, Drawable arg2, GC arg3, System.Int32 arg4, System.Int32 arg5, System.Int32 arg6, System.Int32 arg7, System.Int32 arg8, System.Int32 arg9);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XCopyGC ( System.IntPtr /*|Display*|*/  arg0, GC arg1, System.Int64 arg2, GC arg3);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XCopyPlane ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, Drawable arg2, GC arg3, System.Int32 arg4, System.Int32 arg5, System.Int32 arg6, System.Int32 arg7, System.Int32 arg8, System.Int32 arg9, System.Int64 arg10);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XDefaultDepth ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XDefaultDepthOfScreen ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XDefaultScreen ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XDefineCursor ( System.IntPtr /*|Display*|*/  arg0, Window arg1, Cursor arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XDeleteProperty ( System.IntPtr /*|Display*|*/  arg0, Window arg1, Atom arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XDestroyWindow ( System.IntPtr /*|Display*|*/  arg0, Window arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XDestroySubwindows ( System.IntPtr /*|Display*|*/  arg0, Window arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XDoesBackingStore ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XDoesSaveUnders ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XDisableAccessControl ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XDisplayCells ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XDisplayHeight ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XDisplayHeightMM ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XDisplayKeycodes ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.Int32*/ arg1, System.IntPtr /*System.Int32*/ arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XDisplayPlanes ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XDisplayWidth ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XDisplayWidthMM ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XDrawArc ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.Int32 arg3, System.Int32 arg4, System.Int32 arg5, System.Int32 arg6, System.Int32 arg7, System.Int32 arg8);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XDrawArcs ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.IntPtr /*|XArc*|*/  arg3, System.Int32 arg4);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XDrawImageString ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.Int32 arg3, System.Int32 arg4, System.IntPtr /*System.SByte*/ arg5, System.Int32 arg6);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XDrawImageString16 ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.Int32 arg3, System.Int32 arg4, System.IntPtr /*|XChar2b*|*/  arg5, System.Int32 arg6);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XDrawLine ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.Int32 arg3, System.Int32 arg4, System.Int32 arg5, System.Int32 arg6);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XDrawLines ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.IntPtr /*|XPoint*|*/  arg3, System.Int32 arg4, System.Int32 arg5);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XDrawPoint ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.Int32 arg3, System.Int32 arg4);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XDrawPoints ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.IntPtr /*|XPoint*|*/  arg3, System.Int32 arg4, System.Int32 arg5);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XDrawRectangle ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.Int32 arg3, System.Int32 arg4, System.Int32 arg5, System.Int32 arg6);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XDrawRectangles ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.IntPtr /*|XRectangle*|*/  arg3, System.Int32 arg4);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XDrawSegments ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.IntPtr /*|XSegment*|*/  arg3, System.Int32 arg4);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XDrawString ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.Int32 arg3, System.Int32 arg4, System.IntPtr /*System.SByte*/ arg5, System.Int32 arg6);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XDrawString16 ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.Int32 arg3, System.Int32 arg4, System.IntPtr /*|XChar2b*|*/  arg5, System.Int32 arg6);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XDrawText ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.Int32 arg3, System.Int32 arg4, System.IntPtr /*|XTextItem*|*/  arg5, System.Int32 arg6);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XDrawText16 ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.Int32 arg3, System.Int32 arg4, System.IntPtr /*|XTextItem16*|*/  arg5, System.Int32 arg6);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XEnableAccessControl ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XEventsQueued ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XFetchName ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.IntPtr /*System.SByte*/ arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XFillArc ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.Int32 arg3, System.Int32 arg4, System.Int32 arg5, System.Int32 arg6, System.Int32 arg7, System.Int32 arg8);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XFillArcs ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.IntPtr /*|XArc*|*/  arg3, System.Int32 arg4);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XFillPolygon ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.IntPtr /*|XPoint*|*/  arg3, System.Int32 arg4, System.Int32 arg5, System.Int32 arg6);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XFillRectangle ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.Int32 arg3, System.Int32 arg4, System.Int32 arg5, System.Int32 arg6);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XFillRectangles ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.IntPtr /*|XRectangle*|*/  arg3, System.Int32 arg4);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XFlush ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XForceScreenSaver ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XFree ( System.IntPtr /*void*/ arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XFreeColormap ( System.IntPtr /*|Display*|*/  arg0, Colormap arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XFreeColors ( System.IntPtr /*|Display*|*/  arg0, Colormap arg1, System.IntPtr /*System.Int64*/ arg2, System.Int32 arg3, System.Int64 arg4);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XFreeCursor ( System.IntPtr /*|Display*|*/  arg0, Cursor arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XFreeExtensionList ( System.IntPtr /*System.SByte*/ arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XFreeFont ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|XFontStruct*|*/  arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XFreeFontInfo ( System.IntPtr /*System.SByte*/ arg0, System.IntPtr /*|XFontStruct*|*/  arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XFreeFontNames ( System.IntPtr /*System.SByte*/ arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XFreeFontPath ( System.IntPtr /*System.SByte*/ arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XFreeGC ( System.IntPtr /*|Display*|*/  arg0, GC arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XFreeModifiermap ( System.IntPtr /*|XModifierKeymap*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XFreePixmap ( System.IntPtr /*|Display*|*/  arg0, Pixmap arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XGeometry ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1, System.IntPtr /*System.SByte*/ arg2, System.IntPtr /*System.SByte*/ arg3, System.Int32 arg4, System.Int32 arg5, System.Int32 arg6, System.Int32 arg7, System.Int32 arg8, System.IntPtr /*System.Int32*/ arg9, System.IntPtr /*System.Int32*/ arg10, System.IntPtr /*System.Int32*/ arg11, System.IntPtr /*System.Int32*/ arg12);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XGetErrorDatabaseText ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.SByte*/ arg1, System.IntPtr /*System.SByte*/ arg2, System.IntPtr /*System.SByte*/ arg3, System.IntPtr /*System.SByte*/ arg4, System.Int32 arg5);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XGetErrorText ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1, System.IntPtr /*System.SByte*/ arg2, System.Int32 arg3);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XGetFontProperty ( System.IntPtr /*|XFontStruct*|*/  arg0, Atom arg1, System.IntPtr /*System.Int64*/ arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XGetGCValues ( System.IntPtr /*|Display*|*/  arg0, GC arg1, System.Int64 arg2, System.IntPtr /*|XGCValues*|*/  arg3);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XGetGeometry ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, System.IntPtr /*|Window*|*/  arg2, System.IntPtr /*System.Int32*/ arg3, System.IntPtr /*System.Int32*/ arg4, System.IntPtr /*System.Int32*/ arg5, System.IntPtr /*System.Int32*/ arg6, System.IntPtr /*System.Int32*/ arg7, System.IntPtr /*System.Int32*/ arg8);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XGetIconName ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.IntPtr /*System.SByte*/ arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XGetInputFocus ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|Window*|*/  arg1, System.IntPtr /*System.Int32*/ arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XGetKeyboardControl ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|XKeyboardState*|*/  arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XGetPointerControl ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.Int32*/ arg1, System.IntPtr /*System.Int32*/ arg2, System.IntPtr /*System.Int32*/ arg3);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XGetPointerMapping ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.SByte*/ arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XGetScreenSaver ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.Int32*/ arg1, System.IntPtr /*System.Int32*/ arg2, System.IntPtr /*System.Int32*/ arg3, System.IntPtr /*System.Int32*/ arg4);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XGetTransientForHint ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.IntPtr /*|Window*|*/  arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XGetWindowProperty ( System.IntPtr /*|Display*|*/  arg0, Window arg1, Atom arg2, System.Int64 arg3, System.Int64 arg4, System.Int32 arg5, Atom arg6, System.IntPtr /*|Atom*|*/  arg7, System.IntPtr /*System.Int32*/ arg8, System.IntPtr /*System.Int64*/ arg9, System.IntPtr /*System.Int64*/ arg10, System.IntPtr /*System.SByte*/ arg11);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XGetWindowAttributes ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.IntPtr /*|XWindowAttributes*|*/  arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XGrabButton ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1, System.Int32 arg2, Window arg3, System.Int32 arg4, System.Int32 arg5, System.Int32 arg6, System.Int32 arg7, Window arg8, Cursor arg9);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XGrabKey ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1, System.Int32 arg2, Window arg3, System.Int32 arg4, System.Int32 arg5, System.Int32 arg6);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XGrabKeyboard ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int32 arg2, System.Int32 arg3, System.Int32 arg4, Time arg5);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XGrabPointer ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int32 arg2, System.Int32 arg3, System.Int32 arg4, System.Int32 arg5, Window arg6, Cursor arg7, Time arg8);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XGrabServer ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XHeightMMOfScreen ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XHeightOfScreen ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XIfEvent ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|XEvent*|*/  arg1, System.Int32 arg2, System.IntPtr /*|Display*|*/  arg3, System.IntPtr /*|XEvent*|*/  arg4, XPointer arg5, XPointer arg6);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XImageByteOrder ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XInstallColormap ( System.IntPtr /*|Display*|*/  arg0, Colormap arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern KeyCode XKeysymToKeycode ( System.IntPtr /*|Display*|*/  arg0, KeySym arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XKillClient ( System.IntPtr /*|Display*|*/  arg0, XID arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XLookupColor ( System.IntPtr /*|Display*|*/  arg0, Colormap arg1, System.IntPtr /*System.SByte*/ arg2, System.IntPtr /*|XColor*|*/  arg3, System.IntPtr /*|XColor*|*/  arg4);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XLowerWindow ( System.IntPtr /*|Display*|*/  arg0, Window arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XMapRaised ( System.IntPtr /*|Display*|*/  arg0, Window arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XMapSubwindows ( System.IntPtr /*|Display*|*/  arg0, Window arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XMapWindow ( System.IntPtr /*|Display*|*/  arg0, Window arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XMaskEvent ( System.IntPtr /*|Display*|*/  arg0, System.Int64 arg1, System.IntPtr /*|XEvent*|*/  arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XMaxCmapsOfScreen ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XMinCmapsOfScreen ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XMoveResizeWindow ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int32 arg2, System.Int32 arg3, System.Int32 arg4, System.Int32 arg5);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XMoveWindow ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int32 arg2, System.Int32 arg3);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XNextEvent ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|XEvent*|*/  arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XNoOp ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XParseColor ( System.IntPtr /*|Display*|*/  arg0, Colormap arg1, System.IntPtr /*System.SByte*/ arg2, System.IntPtr /*|XColor*|*/  arg3);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XParseGeometry ( System.IntPtr /*System.SByte*/ arg0, System.IntPtr /*System.Int32*/ arg1, System.IntPtr /*System.Int32*/ arg2, System.IntPtr /*System.Int32*/ arg3, System.IntPtr /*System.Int32*/ arg4);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XPeekEvent ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|XEvent*|*/  arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XPeekIfEvent ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|XEvent*|*/  arg1, System.Int32 arg2, System.IntPtr /*|Display*|*/  arg3, System.IntPtr /*|XEvent*|*/  arg4, XPointer arg5, XPointer arg6);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XPending ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XPlanesOfScreen ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XProtocolRevision ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XProtocolVersion ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XPutBackEvent ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|XEvent*|*/  arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XPutImage ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.IntPtr /*|XImage*|*/  arg3, System.Int32 arg4, System.Int32 arg5, System.Int32 arg6, System.Int32 arg7, System.Int32 arg8, System.Int32 arg9);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XQLength ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XQueryBestCursor ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, System.Int32 arg2, System.Int32 arg3, System.IntPtr /*System.Int32*/ arg4, System.IntPtr /*System.Int32*/ arg5);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XQueryBestSize ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1, Drawable arg2, System.Int32 arg3, System.Int32 arg4, System.IntPtr /*System.Int32*/ arg5, System.IntPtr /*System.Int32*/ arg6);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XQueryBestStipple ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, System.Int32 arg2, System.Int32 arg3, System.IntPtr /*System.Int32*/ arg4, System.IntPtr /*System.Int32*/ arg5);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XQueryBestTile ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, System.Int32 arg2, System.Int32 arg3, System.IntPtr /*System.Int32*/ arg4, System.IntPtr /*System.Int32*/ arg5);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XQueryColor ( System.IntPtr /*|Display*|*/  arg0, Colormap arg1, System.IntPtr /*|XColor*|*/  arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XQueryColors ( System.IntPtr /*|Display*|*/  arg0, Colormap arg1, System.IntPtr /*|XColor*|*/  arg2, System.Int32 arg3);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XQueryExtension ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.SByte*/ arg1, System.IntPtr /*System.Int32*/ arg2, System.IntPtr /*System.Int32*/ arg3, System.IntPtr /*System.Int32*/ arg4);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XQueryKeymap ( System.IntPtr /*|Display*|*/  arg0, char* arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XQueryPointer ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.IntPtr /*|Window*|*/  arg2, System.IntPtr /*|Window*|*/  arg3, System.IntPtr /*System.Int32*/ arg4, System.IntPtr /*System.Int32*/ arg5, System.IntPtr /*System.Int32*/ arg6, System.IntPtr /*System.Int32*/ arg7, System.IntPtr /*System.Int32*/ arg8);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XQueryTextExtents ( System.IntPtr /*|Display*|*/  arg0, XID arg1, System.IntPtr /*System.SByte*/ arg2, System.Int32 arg3, System.IntPtr /*System.Int32*/ arg4, System.IntPtr /*System.Int32*/ arg5, System.IntPtr /*System.Int32*/ arg6, System.IntPtr /*|XCharStruct*|*/  arg7);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XQueryTextExtents16 ( System.IntPtr /*|Display*|*/  arg0, XID arg1, System.IntPtr /*|XChar2b*|*/  arg2, System.Int32 arg3, System.IntPtr /*System.Int32*/ arg4, System.IntPtr /*System.Int32*/ arg5, System.IntPtr /*System.Int32*/ arg6, System.IntPtr /*|XCharStruct*|*/  arg7);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XQueryTree ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.IntPtr /*|Window*|*/  arg2, System.IntPtr /*|Window*|*/  arg3, System.IntPtr /*|Window**|*/  arg4, System.IntPtr /*System.Int32*/ arg5);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XRaiseWindow ( System.IntPtr /*|Display*|*/  arg0, Window arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XReadBitmapFile ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, System.IntPtr /*System.SByte*/ arg2, System.IntPtr /*System.Int32*/ arg3, System.IntPtr /*System.Int32*/ arg4, System.IntPtr /*|Pixmap*|*/  arg5, System.IntPtr /*System.Int32*/ arg6, System.IntPtr /*System.Int32*/ arg7);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XReadBitmapFileData ( System.IntPtr /*System.SByte*/ arg0, System.IntPtr /*System.Int32*/ arg1, System.IntPtr /*System.Int32*/ arg2, System.IntPtr /*System.SByte*/ arg3, System.IntPtr /*System.Int32*/ arg4, System.IntPtr /*System.Int32*/ arg5);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XRebindKeysym ( System.IntPtr /*|Display*|*/  arg0, KeySym arg1, System.IntPtr /*|KeySym*|*/  arg2, System.Int32 arg3, System.IntPtr /*System.SByte*/ arg4, System.Int32 arg5);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XRecolorCursor ( System.IntPtr /*|Display*|*/  arg0, Cursor arg1, System.IntPtr /*|XColor*|*/  arg2, System.IntPtr /*|XColor*|*/  arg3);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XRefreshKeyboardMapping ( System.IntPtr /*|XMappingEvent*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XRemoveFromSaveSet ( System.IntPtr /*|Display*|*/  arg0, Window arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XRemoveHost ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|XHostAddress*|*/  arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XRemoveHosts ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|XHostAddress*|*/  arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XReparentWindow ( System.IntPtr /*|Display*|*/  arg0, Window arg1, Window arg2, System.Int32 arg3, System.Int32 arg4);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XResetScreenSaver ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XResizeWindow ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int32 arg2, System.Int32 arg3);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XRestackWindows ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|Window*|*/  arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XRotateBuffers ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XRotateWindowProperties ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.IntPtr /*|Atom*|*/  arg2, System.Int32 arg3, System.Int32 arg4);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XScreenCount ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSelectInput ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int64 arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSendEvent ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int32 arg2, System.Int64 arg3, System.IntPtr /*|XEvent*|*/  arg4);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSetAccessControl ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSetArcMode ( System.IntPtr /*|Display*|*/  arg0, GC arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSetBackground ( System.IntPtr /*|Display*|*/  arg0, GC arg1, System.Int64 arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSetClipMask ( System.IntPtr /*|Display*|*/  arg0, GC arg1, Pixmap arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSetClipOrigin ( System.IntPtr /*|Display*|*/  arg0, GC arg1, System.Int32 arg2, System.Int32 arg3);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSetClipRectangles ( System.IntPtr /*|Display*|*/  arg0, GC arg1, System.Int32 arg2, System.Int32 arg3, System.IntPtr /*|XRectangle*|*/  arg4, System.Int32 arg5, System.Int32 arg6);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSetCloseDownMode ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSetCommand ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.IntPtr /*System.SByte*/ arg2, System.Int32 arg3);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSetDashes ( System.IntPtr /*|Display*|*/  arg0, GC arg1, System.Int32 arg2, System.IntPtr /*System.SByte*/ arg3, System.Int32 arg4);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSetFillRule ( System.IntPtr /*|Display*|*/  arg0, GC arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSetFillStyle ( System.IntPtr /*|Display*|*/  arg0, GC arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSetFont ( System.IntPtr /*|Display*|*/  arg0, GC arg1, Font arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSetFontPath ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.SByte*/ arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSetForeground ( System.IntPtr /*|Display*|*/  arg0, GC arg1, System.Int64 arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSetFunction ( System.IntPtr /*|Display*|*/  arg0, GC arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSetGraphicsExposures ( System.IntPtr /*|Display*|*/  arg0, GC arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSetIconName ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.IntPtr /*System.SByte*/ arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSetInputFocus ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int32 arg2, Time arg3);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSetLineAttributes ( System.IntPtr /*|Display*|*/  arg0, GC arg1, System.Int32 arg2, System.Int32 arg3, System.Int32 arg4, System.Int32 arg5);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSetModifierMapping ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|XModifierKeymap*|*/  arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSetPlaneMask ( System.IntPtr /*|Display*|*/  arg0, GC arg1, System.Int64 arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSetPointerMapping ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.SByte*/ arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSetScreenSaver ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1, System.Int32 arg2, System.Int32 arg3, System.Int32 arg4);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSetSelectionOwner ( System.IntPtr /*|Display*|*/  arg0, Atom arg1, Window arg2, Time arg3);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSetState ( System.IntPtr /*|Display*|*/  arg0, GC arg1, System.Int64 arg2, System.Int64 arg3, System.Int32 arg4, System.Int64 arg5);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSetStipple ( System.IntPtr /*|Display*|*/  arg0, GC arg1, Pixmap arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSetSubwindowMode ( System.IntPtr /*|Display*|*/  arg0, GC arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSetTSOrigin ( System.IntPtr /*|Display*|*/  arg0, GC arg1, System.Int32 arg2, System.Int32 arg3);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSetTile ( System.IntPtr /*|Display*|*/  arg0, GC arg1, Pixmap arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSetWindowBackground ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int64 arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSetWindowBackgroundPixmap ( System.IntPtr /*|Display*|*/  arg0, Window arg1, Pixmap arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSetWindowBorder ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int64 arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSetWindowBorderPixmap ( System.IntPtr /*|Display*|*/  arg0, Window arg1, Pixmap arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSetWindowBorderWidth ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSetWindowColormap ( System.IntPtr /*|Display*|*/  arg0, Window arg1, Colormap arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XStoreBuffer ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.SByte*/ arg1, System.Int32 arg2, System.Int32 arg3);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XStoreBytes ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.SByte*/ arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XStoreColor ( System.IntPtr /*|Display*|*/  arg0, Colormap arg1, System.IntPtr /*|XColor*|*/  arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XStoreColors ( System.IntPtr /*|Display*|*/  arg0, Colormap arg1, System.IntPtr /*|XColor*|*/  arg2, System.Int32 arg3);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XStoreName ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.IntPtr /*System.SByte*/ arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XStoreNamedColor ( System.IntPtr /*|Display*|*/  arg0, Colormap arg1, System.IntPtr /*System.SByte*/ arg2, System.Int64 arg3, System.Int32 arg4);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSync ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XTextExtents ( System.IntPtr /*|XFontStruct*|*/  arg0, System.IntPtr /*System.SByte*/ arg1, System.Int32 arg2, System.IntPtr /*System.Int32*/ arg3, System.IntPtr /*System.Int32*/ arg4, System.IntPtr /*System.Int32*/ arg5, System.IntPtr /*|XCharStruct*|*/  arg6);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XTextExtents16 ( System.IntPtr /*|XFontStruct*|*/  arg0, System.IntPtr /*|XChar2b*|*/  arg1, System.Int32 arg2, System.IntPtr /*System.Int32*/ arg3, System.IntPtr /*System.Int32*/ arg4, System.IntPtr /*System.Int32*/ arg5, System.IntPtr /*|XCharStruct*|*/  arg6);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XTextWidth ( System.IntPtr /*|XFontStruct*|*/  arg0, System.IntPtr /*System.SByte*/ arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XTextWidth16 ( System.IntPtr /*|XFontStruct*|*/  arg0, System.IntPtr /*|XChar2b*|*/  arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XTranslateCoordinates ( System.IntPtr /*|Display*|*/  arg0, Window arg1, Window arg2, System.Int32 arg3, System.Int32 arg4, System.IntPtr /*System.Int32*/ arg5, System.IntPtr /*System.Int32*/ arg6, System.IntPtr /*|Window*|*/  arg7);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XUndefineCursor ( System.IntPtr /*|Display*|*/  arg0, Window arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XUngrabButton ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1, System.Int32 arg2, Window arg3);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XUngrabKey ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1, System.Int32 arg2, Window arg3);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XUngrabKeyboard ( System.IntPtr /*|Display*|*/  arg0, Time arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XUngrabPointer ( System.IntPtr /*|Display*|*/  arg0, Time arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XUngrabServer ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XUninstallColormap ( System.IntPtr /*|Display*|*/  arg0, Colormap arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XUnloadFont ( System.IntPtr /*|Display*|*/  arg0, Font arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XUnmapSubwindows ( System.IntPtr /*|Display*|*/  arg0, Window arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XUnmapWindow ( System.IntPtr /*|Display*|*/  arg0, Window arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XVendorRelease ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XWarpPointer ( System.IntPtr /*|Display*|*/  arg0, Window arg1, Window arg2, System.Int32 arg3, System.Int32 arg4, System.Int32 arg5, System.Int32 arg6, System.Int32 arg7, System.Int32 arg8);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XWidthMMOfScreen ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XWidthOfScreen ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XWindowEvent ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int64 arg2, System.IntPtr /*|XEvent*|*/  arg3);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XWriteBitmapFile ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.SByte*/ arg1, Pixmap arg2, System.Int32 arg3, System.Int32 arg4, System.Int32 arg5, System.Int32 arg6);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XSupportsLocale ();
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*System.SByte*/ XSetLocaleModifiers ( System.IntPtr /*System.SByte*/ arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern XOM XOpenOM ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|_XrmHashBucketRec*|*/  arg1, System.IntPtr /*System.SByte*/ arg2, System.IntPtr /*System.SByte*/ arg3);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XCloseOM ( XOM arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*|Display*|*/  XDisplayOfOM ( XOM arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*System.SByte*/ XLocaleOfOM ( XOM arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern void XDestroyOC ( IntPtr arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern XOM XOMOfOC ( IntPtr arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern IntPtr XCreateFontSet ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.SByte*/ arg1, System.IntPtr /*System.SByte*/ arg2, System.IntPtr /*System.Int32*/ arg3, System.IntPtr /*System.SByte*/ arg4);
    
    [DllImport(LibPath)]
    public static unsafe extern void XFreeFontSet ( System.IntPtr /*|Display*|*/  arg0, IntPtr arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XFontsOfFontSet ( IntPtr arg0, System.IntPtr /*|XFontStruct***|*/  arg1, System.IntPtr /*System.SByte*/ arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*System.SByte*/ XBaseFontNameListOfFontSet ( IntPtr arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*System.SByte*/ XLocaleOfFontSet ( IntPtr arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XContextDependentDrawing ( IntPtr arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XDirectionalDependentDrawing ( IntPtr arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XContextualDrawing ( IntPtr arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*|XFontSetExtents*|*/  XExtentsOfFontSet ( IntPtr arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XmbTextEscapement ( IntPtr arg0, System.IntPtr /*System.SByte*/ arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XwcTextEscapement ( IntPtr arg0, System.IntPtr /*|wchar_t*|*/  arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 Xutf8TextEscapement ( IntPtr arg0, System.IntPtr /*System.SByte*/ arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XmbTextExtents ( IntPtr arg0, System.IntPtr /*System.SByte*/ arg1, System.Int32 arg2, System.IntPtr /*|XRectangle*|*/  arg3, System.IntPtr /*|XRectangle*|*/  arg4);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XwcTextExtents ( IntPtr arg0, System.IntPtr /*|wchar_t*|*/  arg1, System.Int32 arg2, System.IntPtr /*|XRectangle*|*/  arg3, System.IntPtr /*|XRectangle*|*/  arg4);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 Xutf8TextExtents ( IntPtr arg0, System.IntPtr /*System.SByte*/ arg1, System.Int32 arg2, System.IntPtr /*|XRectangle*|*/  arg3, System.IntPtr /*|XRectangle*|*/  arg4);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XmbTextPerCharExtents ( IntPtr arg0, System.IntPtr /*System.SByte*/ arg1, System.Int32 arg2, System.IntPtr /*|XRectangle*|*/  arg3, System.IntPtr /*|XRectangle*|*/  arg4, System.Int32 arg5, System.IntPtr /*System.Int32*/ arg6, System.IntPtr /*|XRectangle*|*/  arg7, System.IntPtr /*|XRectangle*|*/  arg8);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XwcTextPerCharExtents ( IntPtr arg0, System.IntPtr /*|wchar_t*|*/  arg1, System.Int32 arg2, System.IntPtr /*|XRectangle*|*/  arg3, System.IntPtr /*|XRectangle*|*/  arg4, System.Int32 arg5, System.IntPtr /*System.Int32*/ arg6, System.IntPtr /*|XRectangle*|*/  arg7, System.IntPtr /*|XRectangle*|*/  arg8);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 Xutf8TextPerCharExtents ( IntPtr arg0, System.IntPtr /*System.SByte*/ arg1, System.Int32 arg2, System.IntPtr /*|XRectangle*|*/  arg3, System.IntPtr /*|XRectangle*|*/  arg4, System.Int32 arg5, System.IntPtr /*System.Int32*/ arg6, System.IntPtr /*|XRectangle*|*/  arg7, System.IntPtr /*|XRectangle*|*/  arg8);
    
    [DllImport(LibPath)]
    public static unsafe extern void XmbDrawText ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.Int32 arg3, System.Int32 arg4, System.IntPtr /*|XmbTextItem*|*/  arg5, System.Int32 arg6);
    
    [DllImport(LibPath)]
    public static unsafe extern void XwcDrawText ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.Int32 arg3, System.Int32 arg4, System.IntPtr /*|XwcTextItem*|*/  arg5, System.Int32 arg6);
    
    [DllImport(LibPath)]
    public static unsafe extern void Xutf8DrawText ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.Int32 arg3, System.Int32 arg4, System.IntPtr /*|XmbTextItem*|*/  arg5, System.Int32 arg6);
    
    [DllImport(LibPath)]
    public static unsafe extern void XmbDrawString ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, IntPtr arg2, GC arg3, System.Int32 arg4, System.Int32 arg5, System.IntPtr /*System.SByte*/ arg6, System.Int32 arg7);
    
    [DllImport(LibPath)]
    public static unsafe extern void XwcDrawString ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, IntPtr arg2, GC arg3, System.Int32 arg4, System.Int32 arg5, System.IntPtr /*|wchar_t*|*/  arg6, System.Int32 arg7);
    
    [DllImport(LibPath)]
    public static unsafe extern void Xutf8DrawString ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, IntPtr arg2, GC arg3, System.Int32 arg4, System.Int32 arg5, System.IntPtr /*System.SByte*/ arg6, System.Int32 arg7);
    
    [DllImport(LibPath)]
    public static unsafe extern void XmbDrawImageString ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, IntPtr arg2, GC arg3, System.Int32 arg4, System.Int32 arg5, System.IntPtr /*System.SByte*/ arg6, System.Int32 arg7);
    
    [DllImport(LibPath)]
    public static unsafe extern void XwcDrawImageString ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, IntPtr arg2, GC arg3, System.Int32 arg4, System.Int32 arg5, System.IntPtr /*|wchar_t*|*/  arg6, System.Int32 arg7);
    
    [DllImport(LibPath)]
    public static unsafe extern void Xutf8DrawImageString ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, IntPtr arg2, GC arg3, System.Int32 arg4, System.Int32 arg5, System.IntPtr /*System.SByte*/ arg6, System.Int32 arg7);
    
    [DllImport(LibPath)]
    public static unsafe extern XIM XOpenIM ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|_XrmHashBucketRec*|*/  arg1, System.IntPtr /*System.SByte*/ arg2, System.IntPtr /*System.SByte*/ arg3);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XCloseIM ( XIM arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*|Display*|*/  XDisplayOfIM ( XIM arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*System.SByte*/ XLocaleOfIM ( XIM arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern void XDestroyIC ( XIC arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern void XSetICFocus ( XIC arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern void XUnsetICFocus ( XIC arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*|wchar_t*|*/  XwcResetIC ( XIC arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*System.SByte*/ XmbResetIC ( XIC arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.IntPtr /*System.SByte*/ Xutf8ResetIC ( XIC arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern XIM XIMOfIC ( XIC arg0);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XFilterEvent ( System.IntPtr /*|XEvent*|*/  arg0, Window arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XmbLookupString ( XIC arg0, System.IntPtr /*|XKeyPressedEvent*|*/  arg1, System.IntPtr /*System.SByte*/ arg2, System.Int32 arg3, System.IntPtr /*|KeySym*|*/  arg4, System.IntPtr /*System.Int32*/ arg5);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XwcLookupString ( XIC arg0, System.IntPtr /*|XKeyPressedEvent*|*/  arg1, System.IntPtr /*|wchar_t*|*/  arg2, System.Int32 arg3, System.IntPtr /*|KeySym*|*/  arg4, System.IntPtr /*System.Int32*/ arg5);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 Xutf8LookupString ( XIC arg0, System.IntPtr /*|XKeyPressedEvent*|*/  arg1, System.IntPtr /*System.SByte*/ arg2, System.Int32 arg3, System.IntPtr /*|KeySym*|*/  arg4, System.IntPtr /*System.Int32*/ arg5);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XRegisterIMInstantiateCallback ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|_XrmHashBucketRec*|*/  arg1, System.IntPtr /*System.SByte*/ arg2, System.IntPtr /*System.SByte*/ arg3, IntPtr arg4, XPointer arg5);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XUnregisterIMInstantiateCallback ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|_XrmHashBucketRec*|*/  arg1, System.IntPtr /*System.SByte*/ arg2, System.IntPtr /*System.SByte*/ arg3, IntPtr arg4, XPointer arg5);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XInternalConnectionNumbers ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.Int32*/ arg1, System.IntPtr /*System.Int32*/ arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern void XProcessInternalConnection ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XAddConnectionWatch ( System.IntPtr /*|Display*|*/  arg0, IntPtr arg1, XPointer arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern void XRemoveConnectionWatch ( System.IntPtr /*|Display*|*/  arg0, IntPtr arg1, XPointer arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern void XSetAuthorization ( System.IntPtr /*System.SByte*/ arg0, System.Int32 arg1, System.IntPtr /*System.SByte*/ arg2, System.Int32 arg3);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 _Xmbtowc ( System.IntPtr /*|wchar_t*|*/  arg0, System.IntPtr /*System.SByte*/ arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 _Xwctomb ( System.IntPtr /*System.SByte*/ arg0, wchar_t arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern System.Int32 XGetEventData ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|XGenericEventCookie*|*/  arg1);
    
    [DllImport(LibPath)]
    public static unsafe extern void XFreeEventData ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|XGenericEventCookie*|*/  arg1);
    
    
    
    
    
    public unsafe struct funcs {
    }
    
    [StructLayout(LayoutKind.Explicit)] 
    public unsafe struct Type_2_data {
        [FieldOffset(0)] public unsafe System.Int32 type;
        [FieldOffset(0)] public unsafe System.UInt64 serial;
        [FieldOffset(0)] public unsafe System.Int32 send_event;
        [FieldOffset(0)] public unsafe System.IntPtr /*|Display*|*/  display;
        [FieldOffset(0)] public unsafe Window window;
        [FieldOffset(0)] public unsafe Atom message_type;
        [FieldOffset(0)] public unsafe System.Int32 format;
        [FieldOffset(0)] public unsafe fixed System.Int64 l[5];
    }
    
    [StructLayout(LayoutKind.Explicit)] 
    public unsafe struct Type_3_string_ {
        [FieldOffset(0)] public unsafe System.UInt16 length;
        [FieldOffset(0)] public unsafe System.IntPtr /*|XIMFeedback*|*/  feedback;
        [FieldOffset(0)] public unsafe System.Int32 encoding_is_wchar;
        [FieldOffset(0)] public unsafe System.IntPtr /*System.SByte*/ multi_byte;
        [FieldOffset(0)] public unsafe System.IntPtr /*|wchar_t*|*/  wide_char;
    }
    
    [StructLayout(LayoutKind.Explicit)] 
    public unsafe struct Type_4_string_ {
        [FieldOffset(0)] public unsafe System.UInt16 length;
        [FieldOffset(0)] public unsafe System.IntPtr /*|XIMStringConversionFeedback*|*/  feedback;
        [FieldOffset(0)] public unsafe System.Int32 encoding_is_wchar;
        [FieldOffset(0)] public unsafe System.IntPtr /*System.SByte*/ mbs;
        [FieldOffset(0)] public unsafe System.IntPtr /*|wchar_t*|*/  wcs;
    }
    
    [StructLayout(LayoutKind.Explicit)] 
    public unsafe struct Type_5_data {
        [FieldOffset(0)] public unsafe int type;
        [FieldOffset(0)] public unsafe System.IntPtr /*|XIMText*|*/  text;
        [FieldOffset(0)] public unsafe Pixmap bitmap;
    }
    
    
}
/* errors:
construction:{}, value_c:{struct  {
	XExtData* ext_data;
	_XPrivate* private1;
	int fd;
	int private2;
	int proto_major_version;
	int proto_minor_version;
	char* vendor;
	XID private3;
	XID private4;
	XID private5;
	int private6;
	int byte_order;
	int bitmap_unit;
	int bitmap_pad;
	int bitmap_bit_order;
	int nformats;
	ScreenFormat* pixmap_format;
	int private8;
	int release;
	int qlen;
	unsigned long last_request_read;
	unsigned long request;
	XPointer private11;
	XPointer private12;
	XPointer private13;
	XPointer private14;
	unsigned max_request_size;
	_XrmHashBucketRec* db;
	char* display_name;
	int default_screen;
	int nscreens;
	Screen* screens;
	unsigned long motion_buffer;
	unsigned long private16;
	int min_keycode;
	int max_keycode;
	XPointer private17;
	XPointer private18;
	int private19;
	char* xdefaults;
}}
    construction:{__attribute__}, value_c:{long __max_align_ll __attribute__ (__aligned__ arg0,__alignof__ arg1,long long long)}
    construction:{__attribute__}, value_c:{__max_align_ld __attribute__ (__aligned__ arg0,__alignof__ arg1,long long double)}
    construction:{}, value_c:{struct  {
	unsigned int __low;
	unsigned int __high;
}}
    construction:{}, value_c:{struct  {
	unsigned int __low;
	unsigned int __high;
}}*/
