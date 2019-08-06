<template>
<body>
  <nav id="mainNavbar" class="navbar navbar-dark navbar-expand-md py-0 fixed-top">
    <a href="#" class="navbar-brand">MOVİE</a>
    <button
      class="navbar-toggler"
      data-toggle="collapse"
      data-target="#navLinks"
      aria-label="Toggle navigation"
    >
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navLinks">
      <ul class="navbar-nav">
        <li class="nav-item" @click="$router.push('/login')">
          <a href class="nav-link">LOGIN</a>
        </li>
        <li class="nav-item">
          <a href class="nav-link" @click="$router.push('/signup')">SIGNUP</a>
        </li>
        <li class="nav-item">
          <a href class="nav-link" @click="$router.push('/addmovie')" >ADD MOVIE</a>
        </li>
        <li class="nav-item">
          <a href class="nav-link" @click="$router.push('/addseries')" >ADD SERIES</a>
        </li>
      </ul>
    </div>
  </nav>

  <section class="container-fluid px-0">
    <div class="row align-items-center content">
      <div class="col-md-6 text-center">
        <div class="row justify-content-center">
          <div class="col-10 col-lg-8 blurb mb-5 mb-md-0">
            <h2>AVATAR </h2>
            <img src="@/imgs/lolli_icon.png" alt class="d-none d-lg-inline" />
            <p class="lead">
              Lorem ipsum dolor sit amet consectetur adipisicing elit. Neque, iste molestiae
              beatae, maiores deserunt
              in voluptatibus
              aspernatur architecto excepturi delectus soluta? Ipsa, deleniti dolorem hic consequatur
              repellat eveniet quidem
              voluptate necessitatibus dolorum delectus minus vitae, ut, veritatis sint ipsum magnam
              autem nam ex deserunt debitis
              eaque ratione! Nobis, quidem assumenda.
            </p>
          </div>
        </div>
      </div>
      <div class="col-md-6">
        <img src="@/imgs/avatar.jpg" alt class="img-fluid" />
      </div>
    </div>
    <div class="row align-items-center content">
      <div class="col-md-6 order-2 order-md-1">
        <img src="@/imgs/avengeers.jpg" alt class="img-fluid" />
      </div>
      <div class="col-md-6 text-center order-1 order-md-2">
        <div class="row justify-content-center">
          <div class="col-10 col-lg-8 blurb mb-5 mb-md-0">
            <h2>AVENGERS</h2>
            <img src="@/imgs/lolli_icon.png" alt class="d-none d-lg-inline" />
            <p class="lead">
              Lorem ipsum dolor sit amet consectetur adipisicing elit. Neque, iste molestiae
              beatae, maiores deserunt
              in voluptatibus
              aspernatur architecto excepturi delectus soluta? Ipsa, deleniti dolorem hic consequatur
              repellat eveniet quidem
              voluptate necessitatibus dolorum delectus minus vitae, ut, veritatis sint ipsum magnam
              autem nam ex deserunt debitis
              eaque ratione! Nobis, quidem assumenda.
            </p>
          </div>
        </div>
      </div>
    </div>
    <div class="row align-items-center content">
      <div class="col-md-6 text-center">
        <div class="row justify-content-center">
          <div class="col-10 col-lg-8 blurb mb-5 mb-md-0">
            <h2>TRANSFORMERS </h2>
            <img src="@/imgs/lolli_icon.png" alt class="d-none d-lg-inline" />
            <p class="lead">
              Lorem ipsum dolor sit amet consectetur adipisicing elit. Neque, iste molestiae
              beatae, maiores deserunt
              in voluptatibus
              aspernatur architecto excepturi delectus soluta? Ipsa, deleniti dolorem hic consequatur
              repellat eveniet quidem
              voluptate necessitatibus dolorum delectus minus vitae, ut, veritatis sint ipsum magnam
              autem nam ex deserunt debitis
              eaque ratione! Nobis, quidem assumenda.
            </p>
          </div>
        </div>
      </div>
      <div class="col-md-6">
        <img src="@/imgs/transformers.jpg" alt class="img-fluid" />
      </div>
    </div>
    <div class="row align-items-center content">
      <div class="col-md-6 order-2 order-md-1">
        <img src="@/imgs/lionking.jpeg" alt class="img-fluid" />
      </div>
      <div class="col-md-6 text-center order-1 order-md-2">
        <div class="row justify-content-center">
          <div class="col-10 col-lg-8 blurb mb-5 mb-md-0">
            <h2>LION KING</h2>
            <img src="@/imgs/lolli_icon.png" alt class="d-none d-lg-inline" />
            <p class="lead">
              Lorem ipsum dolor sit amet consectetur adipisicing elit. Neque, iste molestiae
              beatae, maiores
              deserunt
              in voluptatibus
              aspernatur architecto excepturi delectus soluta? Ipsa, deleniti dolorem hic consequatur
              repellat eveniet
              quidem
              voluptate necessitatibus dolorum delectus minus vitae, ut, veritatis sint ipsum magnam
              autem nam ex deserunt
              debitis
              eaque ratione! Nobis, quidem assumenda.
            </p>
          </div>
        </div>
      </div>
    </div>
  </section>
</body>
</template>

<script>
export default {};
</script>

<style>
body {
  background: #47494e ;
  font-family: "Nunito", sans-serif;
}

.blurb h2 {
  color: aliceblue;
  font-weight: 100;
  font-size: 2.5rem;
}

.blurb p {
  color: aliceblue;
  font-weight: 100;
  font-size: 1.125rem;
  line-height: 2;
}

.content {
  margin-top: 100px;
  margin-bottom: 100px;
}

#mainNavbar {
  font-size: 1.5rem;
  font-weight: 100;
  background-color: #47494e;
}

#mainNavbar .nav-link {
  color: aliceblue;
}

#mainNavbar .nav-link:hover {
  color: aliceblue;
}

#mainNavbar .navbar-brand {
  color: aliceblue;
  font-size: 1.5rem;
}

.navbar.scrolled {
  background: rgb(222, 192, 222);
  transition: background 500ms;
}

@media (max-width: 1200px) {
  #headingGroup h1 {
    font-weight: 100;
    font-size: 3rem;
  }
  .blurb h2 {
    font-size: 2rem;
  }
}
#navLinks{
    background-color: #47494e;
}
</style>
