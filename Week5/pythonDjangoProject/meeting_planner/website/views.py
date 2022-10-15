from django.shortcuts import render
from datetime import datetime
from django.http import HttpResponse

from meetings.models import Meeting
# Create your views here.
def welcome(request):
    return render(request, "website/welcome.html",
                  {"meetings": Meeting.objects.all()})


def date(request):
    return HttpResponse("This page was serverd at: " + str(datetime.now()))


def about(request):
    return HttpResponse("This is a page about me: ")
