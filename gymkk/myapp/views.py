# -*- coding: utf-8 -*-
from __future__ import unicode_literals

from django.shortcuts import render
import MySQLdb
from models import usermodel
from froms import SignUpFrom,IndexUPfrom
from django.contrib.auth.hashers import make_password, check_password

# Create your views here.def home(request)

def index_view(request):

    return render(request,'index.html')


def signup_view(request):
    response_data = {}
    if request.method=="POST":
        form = SignUpFrom(request.POST)
        if form.is_valid():

            username = form.cleaned_data['username']

            email = form.cleaned_data['email']
            password = form.cleaned_data['password']
            phone=form.cleaned_data['phone']
            # saving data to DB
            user = usermodel(password=make_password(password), email=email, username=username)

            user.save()

            return render(request, 'success.html') # return redirect('login/')
        else:
            print "worng username"
            return render(request,"sign_up.html")
