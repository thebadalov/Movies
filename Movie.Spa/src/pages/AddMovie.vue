<template>
    <body class="text-center">
  <nav class="navbar navbar-light" style="background-color: #47494e">
    <div class="container">
      <!--Icon Part-->
      <a href class="navbar-brand">
        <i class="fas fa-binoculars mr-2"></i>
        <!-- <img id="body" src="../imgs/smartiks.png" /> -->
      </a>
    </div>
  </nav>
  <div class="text-center">
    <section id="header" class="jumbotron text-center">
      <h1 class="display-3">MOVIE ADD MOVIE</h1>
    </section>
    <form class="form-signin">
      <input
        style="width:300px"
        type="text"
        id="sign"
        class="text-center"
        placeholder="Title"
        required
      />
      <!-- Title -->
      <label for="inputName" class="sr-only">Name</label>
      <br />
      <input
        style="width:300px"
        type="text"
        id="sign"
        class="text-center"
        placeholder="Movie type"
        required
      />
      <!-- Movie Type -->
      <label for="inputSurname" class="sr-only">Surname</label>
      <br />
      <input
        style="width:300px"
        type="date"
        id="sign"
        class="text-center"
        placeholder="Release at"
        required
      />
      <!-- Release at -->
      <label for="inputBday" class="sr-only">Relese at</label>
      <br />
      <input
        style="width:300px"
        type="date"
        id="sign"
        class="text-center"
        placeholder="End at"
        required
      />
      <label for="inputEmail" class="sr-only">End at</label>
      <br />
      <label for="inputNewpassword" class="sr-only">Duration</label>
      <!-- End at -->
      <input
        style="width:300px"
        type="text"
        id="sign"
        class="text-center"
        placeholder="Duration"
        required
      />
      <br />
      <label for="inputAgainpassword" class="sr-only">PGRating</label>
      <!-- PGRating -->
      <input
        style="width:300px"
        type="password"
        id="pgrating"
        class="mb-3 text-center"
        placeholder="PGRating"
        minlength="8"
        required
      />
      <div class="checkbox mb-3"></div>
      <button class="btn btn-lg btn-primary" width="100" type="button">Sign up</button>
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
  background-color: #47494e;
}

#header {
  background-color: #797d88;
}
#sign{
    margin-bottom: 10px;
}
#pgrating{
    margin-right: 4px;
}
</style>
