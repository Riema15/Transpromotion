create database if not exists reignsensc character set utf8 collate utf8_unicode_ci;
use reignsensc;

grant all privileges on reignsensc.* to 'reignsEnsc_user'@'localhost' identified by 'secret';