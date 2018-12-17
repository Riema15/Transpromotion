create database if not exists reignsEnsc character set utf8 collate utf8_unicode_ci;
use reignsEnsc;

grant all privileges on reignsEnsc.* to 'reignsEnsc_user'@'localhost' identified by 'secret';