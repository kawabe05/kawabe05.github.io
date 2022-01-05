.some-section {
  overflow: hidden;
  *zoom: 1; }

html {
  font-size: 62.5%; }

header {
  background: #f9f8f6; }
  header #header_in {
    padding: 15px 20px; }
  @media (max-width: 549px) {
    header .logo h1 {
      margin: 0;
      text-align: center; }
    header .sp_navi {
      height: 30px;
      display: flex;
      justify-content: center;
      align-items: center; }
      header .sp_navi h2 {
        margin: 5px; }
    header .pc_navi {
      display: none; } }
  header .sp_navi_li {
    width: 90%;
    position: absolute;
    top: 100px;
    left: 0;
    border: 1px solid #eee;
    background: #ff6d77;
    margin: 0;
    padding: 15px;
    display: none;
    z-index: 100; }
    header .sp_navi_li li {
      list-style: none;
      padding: 0; }
      header .sp_navi_li li a {
        display: block;
        padding: 10px;
        border-bottom: 1px solid #eee;
        font-size: 14px;
        color: white;
        text-decoration: none; }
  @media (min-width: 550px) {
    header .clearfix::after {
      clear: both;
      content: '';
      display: block; }
    header .sp_navi {
      display: none; }
    header #header_in {
      padding: 15px 0 10px 0; }
    header .pc_navi_li {
      margin: 0;
      padding: 35px 0 0 0;
      display: flex; }
      header .pc_navi_li li {
        list-style: none;
        margin: 0;
        padding: 0; }
        header .pc_navi_li li a {
          padding-right: 10px; } }

main {
  background: #f9f8f6;
  padding-bottom: 0; }
  main .container {
    padding: 0; }
  main .owl-carousel {
    margin: 0; }
  main #new_items h1 {
    text-align: center; }
  main #new_items .container {
    margin: 0;
    display: flex;
    width: 50%; }
  main #new_items .item-box {
    background: white;
    margin: 1px;
    padding: 10px; }
  main .sidebar {
    background: #f9f8f6; }
    main .sidebar .link_box {
      background: white;
      display: none;
      margin: 0 10px; }
      main .sidebar .link_box li {
        list-style: none;
        border: 1px solid #eee;
        margin: 0 0 1px 0;
        padding: 10px;
        position: relative; }
        main .sidebar .link_box li a {
          text-decoration: none;
          color: black; }
        main .sidebar .link_box li img {
          position: absolute;
          right: 10px;
          top: 15px; }
    main .sidebar .categories_box {
      background: white;
      display: none;
      margin: 0 10px; }
      main .sidebar .categories_box li {
        list-style: none;
        border: 1px solid #eee;
        margin: 0 0 1px 0;
        padding: 10px;
        position: relative; }
        main .sidebar .categories_box li a {
          text-decoration: none;
          color: black;
          display: block; }
        main .sidebar .categories_box li img {
          position: absolute;
          right: 10px;
          top: 15px; }
    @media (max-width: 549px) {
      main .sidebar .pc_sidebar {
        display: none; }
      main .sidebar .item_search {
        background: white;
        height: 70px;
        padding: 10px 15px;
        margin: 10px;
        position: relative; }
        main .sidebar .item_search input {
          background: #eeeeee;
          border-radius: 1px;
          margin: 15px 0;
          width: 100%; }
        main .sidebar .item_search p {
          position: absolute;
          top: 35px;
          right: 35px; }
      main .sidebar #page_link {
        background: #887f69;
        height: 50px;
        margin: 10px 10px 0 10px;
        position: relative; }
        main .sidebar #page_link p {
          position: absolute;
          top: 13px;
          left: 10px; }
        main .sidebar #page_link span {
          position: absolute;
          top: 13px;
          right: 10px; }
      main .sidebar #categories {
        background: #887f69;
        height: 50px;
        margin: 10px 10px 0 10px;
        position: relative; }
        main .sidebar #categories p {
          position: absolute;
          top: 13px;
          left: 10px; }
        main .sidebar #categories span {
          position: absolute;
          top: 13px;
          right: 10px; }
      main .sidebar #about {
        background: #887f69;
        height: 50px;
        margin: 10px 10px 0 10px;
        position: relative; }
        main .sidebar #about p {
          position: absolute;
          top: 13px;
          left: 10px; }
      main .sidebar #shop_info {
        background: #887f69;
        height: 50px;
        margin: 10px 10px 0 10px;
        position: relative; }
        main .sidebar #shop_info p {
          position: absolute;
          top: 13px;
          left: 10px; }
      main .sidebar .explain {
        background: white;
        position: relative;
        padding: 10px;
        margin: 0 10px;
        display: flex;
        flex: initial;
        height: 130px; }
        main .sidebar .explain img {
          width: 45%;
          height: 65%;
          margin: 5px 0; }
        main .sidebar .explain h5 {
          font-size: 12px;
          font-size: 1.2rem;
          width: 50%;
          margin: 5px 10px; }
        main .sidebar .explain p {
          position: absolute;
          top: 90px;
          width: 80%;
          text-align: right; } }
    @media (min-width: 550px) {
      main .sidebar .sp_sidebar {
        display: none; }
      main .sidebar .item_search {
        background: white;
        height: 70px;
        padding: 10px 15px;
        position: relative; }
        main .sidebar .item_search input {
          background: #eeeeee;
          padding: 5px 5px 8px 5px;
          max-width: 95%;
          border-radius: 1px; }
        main .sidebar .item_search p {
          position: absolute;
          top: 45px;
          right: 35px; }
      main .sidebar #page_link {
        background: #887f69;
        height: 50px;
        margin: 10px 0 0 0;
        position: relative; }
        main .sidebar #page_link p {
          position: absolute;
          top: 13px;
          left: 10px; }
        main .sidebar #page_link span {
          position: absolute;
          top: 13px;
          right: 10px; }
      main .sidebar .link_box {
        margin: 0; }
      main .sidebar #categories {
        background: #887f69;
        height: 50px;
        margin: 10px 0 0 0;
        position: relative; }
        main .sidebar #categories p {
          position: absolute;
          top: 13px;
          left: 10px; }
        main .sidebar #categories span {
          position: absolute;
          top: 13px;
          right: 10px; }
      main .sidebar .categories_box {
        margin: 0; }
      main .sidebar #about {
        background: #887f69;
        height: 50px;
        margin: 10px 0 0 0;
        position: relative; }
        main .sidebar #about p {
          position: absolute;
          top: 13px;
          left: 10px; }
        main .sidebar #about span {
          position: absolute;
          top: 13px;
          right: 10px; }
      main .sidebar .explain {
        background: white;
        position: relative;
        padding: 10px;
        margin: 0 0 10px 0;
        height: 230px; }
        main .sidebar .explain h5 {
          font-size: 13px;
          font-size: 1.3rem; }
        main .sidebar .explain p {
          margin: 0;
          position: absolute;
          bottom: 5px;
          left: 50px; }
      main .sidebar #shop_info {
        background: #887f69;
        height: 50px;
        margin: 10px 0 0 0;
        position: relative; }
        main .sidebar #shop_info p {
          position: absolute;
          top: 13px;
          left: 10px; }
        main .sidebar #shop_info span {
          position: absolute;
          top: 13px;
          right: 10px; }
      main .sidebar .explain {
        background: white;
        position: relative;
        padding: 10px;
        margin: 0 0 10px 0;
        height: 230px; }
        main .sidebar .explain h5 {
          font-size: 13px;
          font-size: 1.3rem; }
        main .sidebar .explain p {
          margin: 0;
          position: absolute;
          bottom: 5px;
          left: 50px; } }

footer {
  background: #f9f8f6; }
  footer .container {
    padding: 0; }
  footer h3 {
    text-align: center; }
  footer hr {
    margin: 20px 10px; }
  footer h4 {
    font-size: 13px;
    font-size: 1.3rem;
    text-align: center;
    margin: 20px 10px; }
  footer .copy {
    text-align: center;
    font-size: 9px;
    font-size: 0.9rem;
    color: #e2ddd4;
    margin: 60; }
  @media (min-width: 550px) {
    footer h3 {
      text-align: right;
      margin: 20px 10px; } }

/*# sourceMappingURL=style.cs.map */
