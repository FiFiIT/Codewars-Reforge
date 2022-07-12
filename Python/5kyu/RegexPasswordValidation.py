from re import search

regex = "(?=^[a-zA-Z0-9]+$)(?=.*[a-z])(?=.*[A-Z])(?=.*\d)"
# regex = "(?=^\w{6,}$)(?=.*[a-z])(?=.*[A-Z])"

print(bool(search(regex, 'Xp_Xe5ZDrNEukq')))
