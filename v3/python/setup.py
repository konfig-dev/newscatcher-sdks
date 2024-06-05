# coding: utf-8

"""
    NewsCatcher-V3 Production API

    <img src='https://uploads-ssl.webflow.com/6429857b17973b636c2195c5/646c6f1eb774ff2f2997bec5_newscatcher_.svg' width='286' height='35' /> <br>  <br>Visit our website  <a href='https://newscatcherapi.com'>https://newscatcherapi.com</a>

    The version of the OpenAPI document: 3.2.16
    Contact: maksym@newscatcherapi.com
    Generated by: https://konfigthis.com
"""

from setuptools import setup, find_packages  # noqa: H301

NAME = "newscatcherapi-python-sdk"
VERSION = "6.0.7"
# To install the library, run the following
#
# python setup.py install
#
# prerequisite: setuptools
# http://pypi.python.org/pypi/setuptools

# read the contents of README file
from pathlib import Path
this_directory = Path(__file__).parent
long_description = (this_directory / "README.md").read_text()

REQUIRES = [
    "certifi >= 2023.7.22",
    "python-dateutil ~= 2.8.2",
    "typing_extensions ~= 4.3.0",
    "urllib3 ~= 1.26.18, ~= 2.0.0",
    "cryptography ~= 42.0.5",
    "frozendict ~= 2.3.4",
    "aiohttp ~= 3.8.4",
    "pydantic ~= 2.4.2"
]

setup(
    name=NAME,
    version=VERSION,
    description="NewsCatcher-V3 Production API",
    author="Maksym Sugonyaka",
    author_email="maksym@newscatcherapi.com",
    url="https://github.com/konfig-dev/newscatcher-sdks/tree/main/v3/python",
    keywords=["Konfig", "NewsCatcher-V3 Production API"],
    python_requires=">=3.7",
    install_requires=REQUIRES,
    packages=find_packages(exclude=["test", "tests"]),
    include_package_data=True,
    license="MIT",
    long_description=long_description,
    long_description_content_type='text/markdown'
)
