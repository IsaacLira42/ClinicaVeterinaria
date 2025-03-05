from Crypto.Cipher import AES
import base64
import hashlib

class View:
    @staticmethod
    def criptografar_aes(texto, chave="1234567890123456", iv="abcdefghijklmnop"):
        chave = chave.encode('utf-8')
        iv = iv.encode('utf-8')

        while len(texto) % 16 != 0:
            texto += ' ' 

        cipher = AES.new(chave, AES.MODE_CBC, iv)
        texto_criptografado = cipher.encrypt(texto.encode('utf-8'))

        return base64.b64encode(texto_criptografado).decode('utf-8')

    @staticmethod
    def descriptografar_aes(texto_criptografado, chave="1234567890123456", iv="abcdefghijklmnop"):
        chave = chave.encode('utf-8')
        iv = iv.encode('utf-8')

        texto_criptografado = base64.b64decode(texto_criptografado)

        cipher = AES.new(chave, AES.MODE_CBC, iv)
        texto_descriptografado = cipher.decrypt(texto_criptografado).decode('utf-8')

        return texto_descriptografado.rstrip()
