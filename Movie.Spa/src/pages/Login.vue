<template>
 <body class="text-center">
  <nav id="mainNav" class="navbar navbar-light" style="background-color:#47494e">
    <div class="container">
      <!--Icon Part-->
      <a href class="navbar-brand">
        <i class="fas fa-binoculars mr-2"></i>
        <!-- <img id="body" src="../imgs/smartiks.png" /> -->
      </a>
      <!-- <a class="nav-link" @click="$router.push('signup')" style="cursor: pointer" id="menu">
        <img src="https://img.icons8.com/windows/32/000000/add-user-male.png" />Sign Up
      </a> -->
    </div>
  </nav>
  <div class="text-center">
    <section id="header" class="jumbotron text-center">
      <h1 class="display-3">MOVIE LOGIN</h1>
    </section>
    <form class="form-signin">
      <input
        type="email"
        id="inputEmail"
        class="text-center"
        placeholder="Email address"
        float
        style="width: 300px"
      />
      <label for="inputEmail" class="sr-only">Email address</label>
      
      <label for="inputPassword" class="sr-only">Password</label>
      <input
        type="password"
        id="inputPassword"
        class="mb-3 text-center"
        placeholder="Password"
        style="width:300px"
      />
      <div class="checkbox mb-3">
        <label>
          <input type="checkbox" value="remember-me" /> Remember me
        </label>
      </div>
      <button
        class="btn btn-lg btn-primary"
        width="100"
        type="button"
        
      >Sign in</button>
    </form>
  </div>
</body>   
</template>

<script>
export default {

}
</script>

<style>
body {
  background-color: #47494e ;
  font-family: "Nunito", sans-serif;
}
#mainNav{
    background-color: #47494e ;
}
#header{
    background-color: #797d88;
}
</style>
