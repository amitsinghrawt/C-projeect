from django import forms

from models import usermodel

class IndexUPfrom(forms.ModelForm):
    class Meta:
        model=usermodel
        fields=['name','phone']
class SignUpFrom(forms.ModelForm):
    class Meta:
        model =usermodel
        fields=['email', 'username',  'password']
