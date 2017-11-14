# -*- coding: utf-8 -*-
from __future__ import unicode_literals
from django.db import models
import uuid
from django.core.exceptions import ValidationError
from django.core.validators import RegexValidator
class usermodel(models.Model):
    email=models.EmailField(null=False)
    username=models.CharField(max_length=100,unique=True)
    name=models.CharField(max_length=100)
    phone=models.IntegerField(max_length=10,unique=True,validators=[RegexValidator(regex='^\d{10}$',message='Length has to be 10',code='Invalid number')])
    # phone=models.IntegerField(max_length=10)
    password=models.CharField(max_length=10)
    created_on=models.DateTimeField(auto_now=True)
    update_on=models.DateTimeField(auto_now=True)




# Create your models here.
