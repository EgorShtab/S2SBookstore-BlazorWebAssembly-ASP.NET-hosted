PGDMP     &                    y            S2SBookStore    13.2    13.2     ?           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            ?           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            ?           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            ?           1262    24576    S2SBookStore    DATABASE     k   CREATE DATABASE "S2SBookStore" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Russian_Russia.1251';
    DROP DATABASE "S2SBookStore";
                postgres    false            ?            1259    24628    Books    TABLE     ?   CREATE TABLE public."Books" (
    "ID" integer NOT NULL,
    "Author" text,
    "Name" text,
    "ReleaseDate" integer NOT NULL
);
    DROP TABLE public."Books";
       public         heap    postgres    false            ?            1259    24626    Books_ID_seq    SEQUENCE     ?   ALTER TABLE public."Books" ALTER COLUMN "ID" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."Books_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    202            ?            1259    24621    __EFMigrationsHistory    TABLE     ?   CREATE TABLE public."__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL
);
 +   DROP TABLE public."__EFMigrationsHistory";
       public         heap    postgres    false            ?          0    24628    Books 
   TABLE DATA           H   COPY public."Books" ("ID", "Author", "Name", "ReleaseDate") FROM stdin;
    public          postgres    false    202   I       ?          0    24621    __EFMigrationsHistory 
   TABLE DATA           R   COPY public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") FROM stdin;
    public          postgres    false    200   Z       ?           0    0    Books_ID_seq    SEQUENCE SET     <   SELECT pg_catalog.setval('public."Books_ID_seq"', 8, true);
          public          postgres    false    201            *           2606    24635    Books PK_Books 
   CONSTRAINT     R   ALTER TABLE ONLY public."Books"
    ADD CONSTRAINT "PK_Books" PRIMARY KEY ("ID");
 <   ALTER TABLE ONLY public."Books" DROP CONSTRAINT "PK_Books";
       public            postgres    false    202            (           2606    24625 .   __EFMigrationsHistory PK___EFMigrationsHistory 
   CONSTRAINT     {   ALTER TABLE ONLY public."__EFMigrationsHistory"
    ADD CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId");
 \   ALTER TABLE ONLY public."__EFMigrationsHistory" DROP CONSTRAINT "PK___EFMigrationsHistory";
       public            postgres    false    200            ?     x?5??n?@?Ϟ??T????)??(j/\??&??1r!޾C?'???/v
6?f??g?)2??޽??R??qߘx?9????8)?qq?%Wmb?????????B????-,??n????3z????????a,?	~??`L[nTk?5Ũz??Wzjx"?~h?lHa?'*????8?Ɨ?̍`?%?'? ??	???K??c|Wr?ư ?Tv???#?l.??~?O?)χ??{K?`J????4v?G????9??j7      ?   *   x?32024012041670????,?L??4?3?3?????? ???     