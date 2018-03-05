# Why?
I am Nick Reeder, I love to program and hack software. I want to make an application that is simple and easy to use to test out security implementations. I don't want to bar people from anything, that is why it is going to be and stay open source. I want this to be a learning expereince for myself and any others who want to try. 
I plan to try new things with my coding and tyry and implement security into the application. I will then later go through and try and hack my games and systems, using tools like ILSpy and OllyDbg.
# FrameHost
An open source game engine meant to run games off floppy disks. This software using the file extensions .FLOP and .FLOPX.
# FLOP
FLOP files are the games data and settings. all .FLOPS are encrypted with a simple XOR function found in the FileIO DLL. FLOP files will be used primarilly to test inter-file communication. FLOP files will have a private game edit key passed as a paramater to edit the file, matching that of the FLOPX.
# FLOPX
FLOPX files are games them selves. FLOPX, the X meaning executable. I will be adding file identity to them through registry. FLOPX will be able to be edited through the main application if given the games edit key as a plain text paramater. This key will be used to edit any FLOP files as well.
# FrameHost
FrameHost is the main window for any FLOPX games as well as the window for editing FLOP values.
# FileIO
FileIO has everything needed to encrypt and decrypt .FLOP and .FLOPX files. This will handle inter/intra file communications.
# TODO
Finish Readme
