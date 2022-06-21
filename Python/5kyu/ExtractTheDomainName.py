import re


def domain_name(url):
    url = url.replace("https://", "")
    url = url.replace("http://", "")
    url = url.replace("www.", "")

    return url.split('.')[0]


def domain_name_kata_1(url):
    return re.search('(?:http(?:s)?:\/\/)?(?:w{3}\.)?([^\.]+)', url).group(1)


def domain_name_kata_2(url):
    return url.split("//")[-1].split("www.")[-1].split(".")[0]


print(domain_name_kata_2("https://youtube.com"))
