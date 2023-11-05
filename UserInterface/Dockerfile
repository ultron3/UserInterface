# Utilizza un'immagine di base di Windows
FROM mcr.microsoft.com/windows/servercore:ltsc2019

# Copia i file dell'applicazione nel container
COPY ./App/bin/Release/net6.0/publish/ App/

# Specifica il comando per avviare l'applicazione
CMD ["App/UserInterface.exe"]