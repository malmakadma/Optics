PGDMP     '    ;                z            testdb    14.5    14.5 +    $           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            %           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            &           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            '           1262    24604    testdb    DATABASE     d   CREATE DATABASE testdb WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Russian_Ukraine.1251';
    DROP DATABASE testdb;
                postgres    false            �            1259    24801 	   customers    TABLE       CREATE TABLE public.customers (
    id bigint NOT NULL,
    firstname text NOT NULL,
    lastname text NOT NULL,
    phone text NOT NULL,
    email text NOT NULL,
    createddate date NOT NULL,
    dob date NOT NULL,
    country text NOT NULL,
    address text NOT NULL
);
    DROP TABLE public.customers;
       public         heap    postgres    false            �            1259    24806    Customers_Id_seq    SEQUENCE     �   ALTER TABLE public.customers ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Customers_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    209            �            1259    32962 	   employees    TABLE     �   CREATE TABLE public.employees (
    id bigint NOT NULL,
    firstname text NOT NULL,
    lastname text NOT NULL,
    hiringdate date NOT NULL,
    phone text NOT NULL,
    email text NOT NULL,
    contract text NOT NULL
);
    DROP TABLE public.employees;
       public         heap    postgres    false            �            1259    32967    employees_id_seq    SEQUENCE     �   ALTER TABLE public.employees ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.employees_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    219            �            1259    24807 
   orderitems    TABLE     �   CREATE TABLE public.orderitems (
    id bigint NOT NULL,
    productid bigint NOT NULL,
    price numeric NOT NULL,
    quantity bigint NOT NULL,
    orderid bigint NOT NULL,
    recipeid bigint
);
    DROP TABLE public.orderitems;
       public         heap    postgres    false            �            1259    24810    orderitems_id_seq    SEQUENCE     �   ALTER TABLE public.orderitems ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.orderitems_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    211            �            1259    24811    orders    TABLE     �   CREATE TABLE public.orders (
    id bigint NOT NULL,
    customerid bigint NOT NULL,
    createddate date NOT NULL,
    employeeid bigint NOT NULL
);
    DROP TABLE public.orders;
       public         heap    postgres    false            �            1259    24814    orders_id_seq    SEQUENCE     �   ALTER TABLE public.orders ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.orders_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    213            �            1259    24815    products    TABLE     �   CREATE TABLE public.products (
    id bigint NOT NULL,
    name text NOT NULL,
    description text,
    price numeric NOT NULL,
    country_origin text NOT NULL,
    article text NOT NULL,
    recipeisreq boolean DEFAULT false
);
    DROP TABLE public.products;
       public         heap    postgres    false            �            1259    24820    products_id_seq    SEQUENCE     �   ALTER TABLE public.products ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.products_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    215            �            1259    32945    recipes    TABLE     �   CREATE TABLE public.recipes (
    id bigint NOT NULL,
    customerid bigint NOT NULL,
    createddate date NOT NULL,
    dp bigint,
    r bigint,
    sph bigint,
    cyl bigint,
    ax bigint,
    add bigint,
    bas bigint
);
    DROP TABLE public.recipes;
       public         heap    postgres    false            �            1259    32948    recipts_id_seq    SEQUENCE     �   ALTER TABLE public.recipes ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.recipts_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    217                      0    24801 	   customers 
   TABLE DATA           n   COPY public.customers (id, firstname, lastname, phone, email, createddate, dob, country, address) FROM stdin;
    public          postgres    false    209   �1                  0    32962 	   employees 
   TABLE DATA           `   COPY public.employees (id, firstname, lastname, hiringdate, phone, email, contract) FROM stdin;
    public          postgres    false    219   �4                 0    24807 
   orderitems 
   TABLE DATA           W   COPY public.orderitems (id, productid, price, quantity, orderid, recipeid) FROM stdin;
    public          postgres    false    211   �5                 0    24811    orders 
   TABLE DATA           I   COPY public.orders (id, customerid, createddate, employeeid) FROM stdin;
    public          postgres    false    213   �6                 0    24815    products 
   TABLE DATA           f   COPY public.products (id, name, description, price, country_origin, article, recipeisreq) FROM stdin;
    public          postgres    false    215   �7                 0    32945    recipes 
   TABLE DATA           ]   COPY public.recipes (id, customerid, createddate, dp, r, sph, cyl, ax, add, bas) FROM stdin;
    public          postgres    false    217   '9       (           0    0    Customers_Id_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public."Customers_Id_seq"', 14, true);
          public          postgres    false    210            )           0    0    employees_id_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public.employees_id_seq', 4, true);
          public          postgres    false    220            *           0    0    orderitems_id_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.orderitems_id_seq', 58, true);
          public          postgres    false    212            +           0    0    orders_id_seq    SEQUENCE SET     <   SELECT pg_catalog.setval('public.orders_id_seq', 30, true);
          public          postgres    false    214            ,           0    0    products_id_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public.products_id_seq', 14, true);
          public          postgres    false    216            -           0    0    recipts_id_seq    SEQUENCE SET     <   SELECT pg_catalog.setval('public.recipts_id_seq', 7, true);
          public          postgres    false    218            w           2606    24822    customers customers_pkey 
   CONSTRAINT     V   ALTER TABLE ONLY public.customers
    ADD CONSTRAINT customers_pkey PRIMARY KEY (id);
 B   ALTER TABLE ONLY public.customers DROP CONSTRAINT customers_pkey;
       public            postgres    false    209            �           2606    32969    employees employees_pkey 
   CONSTRAINT     V   ALTER TABLE ONLY public.employees
    ADD CONSTRAINT employees_pkey PRIMARY KEY (id);
 B   ALTER TABLE ONLY public.employees DROP CONSTRAINT employees_pkey;
       public            postgres    false    219            {           2606    24824    orderitems orderitems_pkey 
   CONSTRAINT     X   ALTER TABLE ONLY public.orderitems
    ADD CONSTRAINT orderitems_pkey PRIMARY KEY (id);
 D   ALTER TABLE ONLY public.orderitems DROP CONSTRAINT orderitems_pkey;
       public            postgres    false    211            ~           2606    24826    orders pk_orderid 
   CONSTRAINT     O   ALTER TABLE ONLY public.orders
    ADD CONSTRAINT pk_orderid PRIMARY KEY (id);
 ;   ALTER TABLE ONLY public.orders DROP CONSTRAINT pk_orderid;
       public            postgres    false    213            �           2606    24828    products products_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.products
    ADD CONSTRAINT products_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.products DROP CONSTRAINT products_pkey;
       public            postgres    false    215            �           2606    32977    recipes recipes_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public.recipes
    ADD CONSTRAINT recipes_pkey PRIMARY KEY (id);
 >   ALTER TABLE ONLY public.recipes DROP CONSTRAINT recipes_pkey;
       public            postgres    false    217            x           1259    24829    fki_fk_orderId_IdOrder    INDEX     R   CREATE INDEX "fki_fk_orderId_IdOrder" ON public.orderitems USING btree (orderid);
 ,   DROP INDEX public."fki_fk_orderId_IdOrder";
       public            postgres    false    211            |           1259    24830    fki_order_customer_fk    INDEX     N   CREATE INDEX fki_order_customer_fk ON public.orders USING btree (customerid);
 )   DROP INDEX public.fki_order_customer_fk;
       public            postgres    false    213            y           1259    32989    fki_r    INDEX     @   CREATE INDEX fki_r ON public.orderitems USING btree (recipeid);
    DROP INDEX public.fki_r;
       public            postgres    false    211            �           2606    24831    orderitems fk_orderId_Idorder    FK CONSTRAINT     �   ALTER TABLE ONLY public.orderitems
    ADD CONSTRAINT "fk_orderId_Idorder" FOREIGN KEY (orderid) REFERENCES public.orders(id) NOT VALID;
 I   ALTER TABLE ONLY public.orderitems DROP CONSTRAINT "fk_orderId_Idorder";
       public          postgres    false    213    3198    211            �           2606    24836    orderitems fk_productId_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.orderitems
    ADD CONSTRAINT "fk_productId_id" FOREIGN KEY (productid) REFERENCES public.products(id);
 F   ALTER TABLE ONLY public.orderitems DROP CONSTRAINT "fk_productId_id";
       public          postgres    false    211    3200    215            �           2606    32984    orderitems fk_rp_oi    FK CONSTRAINT        ALTER TABLE ONLY public.orderitems
    ADD CONSTRAINT fk_rp_oi FOREIGN KEY (recipeid) REFERENCES public.recipes(id) NOT VALID;
 =   ALTER TABLE ONLY public.orderitems DROP CONSTRAINT fk_rp_oi;
       public          postgres    false    217    3202    211            �           2606    24841    orders order_customer_fk    FK CONSTRAINT     ~   ALTER TABLE ONLY public.orders
    ADD CONSTRAINT order_customer_fk FOREIGN KEY (customerid) REFERENCES public.customers(id);
 B   ALTER TABLE ONLY public.orders DROP CONSTRAINT order_customer_fk;
       public          postgres    false    209    3191    213            �           2606    32970    orders orders_employeeid_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.orders
    ADD CONSTRAINT orders_employeeid_fkey FOREIGN KEY (employeeid) REFERENCES public.employees(id) NOT VALID;
 G   ALTER TABLE ONLY public.orders DROP CONSTRAINT orders_employeeid_fkey;
       public          postgres    false    219    213    3204            �           2606    32990    recipes recipes_customerid_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.recipes
    ADD CONSTRAINT recipes_customerid_fkey FOREIGN KEY (customerid) REFERENCES public.customers(id) NOT VALID;
 I   ALTER TABLE ONLY public.recipes DROP CONSTRAINT recipes_customerid_fkey;
       public          postgres    false    209    3191    217                 x���MKA�ϳ�b�6��}vn����z,��bLkb1A�f|kŖ�%��1����7�3����j�6����o����F����K�t��nO���ݺk���<yD�*%Za��TH
UYl�W�Vjiu�<�\C�0�)����pL)&
ٟ���m�d7��u�j�ޓ��ܦ=���'09�=��v��׎)��۞�8�{��� t��=�M��~dl��B��8I�V/��
Ш�h��g@+�ȦZLM�d<� ��=�d������d�$F+)P���x ��f5�H�d\d��2��n]�r��v����p���y+KXs�����te.�+�_I(��p�����0�r���`\�>��ێe��#�a'�X�?{�v<kNjJRp�)C��z��*)�3d��"���]S�;^
��_~'���gd:��㮏_.`6�T>�M�j�V�i�p�#	�D،�}	���
c��D#64q`�A�_�~��Ք�YE�V����nv섺�3���E�e7Nr0QH�>��ۃ�\�҅�g ř�z�\���FF.Ϛ.*���wژ�c�-'[��E;��I0m�E�q�<���P����FAR�m{nk�Ts�1D�Y$���ǰ��z=D�a��n�wW��	��[%Q��8��Vs!�a�<G,h2k�
��=�1�=]X�1�
e��B/�̰��K����sh�cB��*S�|n+{�?��e�58Z��!�Z��r}-��X�:���u4]��:J"��GX
�����e�h�y8���J�xQ]����>!�#BF��Q�9�          �   x�]��J�@���H����fsӷ��K	�iE��S�0��S��x/~Q���}#'1��0�00?�c	sl�!��>�I�.ݤ�t-�GY����f�d��G]0�q̖�.����.ONGGӚ����yVX�&-�-a�mj���@�Lǁ�.�����?��A�b)Gh��>R�{r�E�O��煏!�f���]�V��|����]�˯�������&[�QYM�/e�q{m�x������         �   x�URە!��b���Q��
n�u,�������Q#��}~�|���j�d � v[m��X�t9(Z�H�t9�C��1nL��i�,֜H�~<1ݮ� U���H ��Z�hn��s,�+�!��#��b1�X$��%�F�_Ň櫙1����B���h�����D�k3�Uc ������<W�U���' w�+l��]�:���Qv� �*��l�=14^`�韟���j�         �   x�e�A� �5�%��!w���Q0�b�r�|P��P�C�!��A�AsEw�ϖF�W���Iu����
8H��!��nA�)r�QSg�O:Yp��DCl>�xx�o(;�P�	]St�||�[��}��jZH]��Ǵd�k�t��ߤ.�e�t���ɨ������U�         n  x���?O�P���O�6�)���(�tsiNZ0ѭb�ň�D�qq��Z�
�}#�+ѥ.Ms�=���{6Uj���#���lI^��2@"{����@,�,DD��^Y�>�T�]g�5��${,���\��D��1�۱,��Z�0�L��(y��'J�]Ax��ƈeO����a2�E�l���B��!�&�mD�,�cZ
�Å�tA����`2����#y����r�Q�t~�߄��BYUo�TՃ���.��Kq�i���g�_�{�D9]e��7��w����'Fs�43e��2�c����X^�3�f:��r�A�ylQ�my��{^8�7jɀS�b9O��f�m�N��{�_�4�9D          `   x�m��	�0��s�gjJv��s41%�P�߉n�Jj1�r�G}��"U�����f�D|��G�y��v���
�Ō��K�k�<m��CD�l     