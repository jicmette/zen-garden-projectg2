@import url("https://fonts.googleapis.com/css2?family=Kdam+Thmor+Pro&family=Sora&display=swap");
@media only screen and (min-width: 43.75em) {
  .intro {
    display: grid;
    grid-template-columns: repeat(2, 1fr);
  }
}

[role=banner] {
  background: linear-gradient(rgba(0, 0, 0, 0.3), rgba(0, 0, 0, 0.3)), url("/zen-garden-projectg2/assets/Clone-Trooper-wallpapers-HD-for-desktop-backgrounds.jpg");
  background-size: cover;
  border-radius: 1.5rem;
  text-align: right;
  width: 95%;
  height: 100vh;
  margin: 1rem auto;
  text-shadow: 2px 2px 4px rgba(0, 0, 0, 0.5);
  align-items: center;
  justify-content: center;
  display: flex;
  flex-direction: column;
  column-gap: 1rem;
}
@media only screen and (min-width: 43.75em) {
  [role=banner] {
    grid-column: 1/4;
  }
}
[role=banner] h1 {
  font-size: 2rem;
  color: #ffe81f;
  font-weight: bolder;
}
@media only screen and (min-width: 43.75em) {
  [role=banner] h1 {
    font-size: 4rem;
    align-self: end;
    padding-right: 2rem;
    margin: 0;
  }
}
@media only screen and (min-width: 56.25em) {
  [role=banner] h1 {
    font-size: 6rem;
  }
}
[role=banner] h2 {
  font-size: 1rem;
  font-style: italic;
}
@media only screen and (min-width: 43.75em) {
  [role=banner] h2 {
    font-size: 2rem;
    align-self: flex-end;
    padding-right: 2rem;
    margin: 0;
  }
}

.summary {
  display: flex;
  flex-wrap: wrap;
  background-color: #ffe81f;
  color: rgb(37, 37, 37);
  padding: 10% 2.5rem;
  width: 95%;
  border-radius: 100px/150px;
  margin: 1rem auto;
  margin-top: -3rem;
  text-align: center;
  line-height: 1.5rem;
}
.summary a {
  background-color: rgb(37, 37, 37);
  border: none;
  color: #fff;
  padding: 6px 13px;
  text-align: center;
  text-decoration: none;
  display: inline-block;
  border-radius: 1.5rem;
  transition: background-color 0.3s ease;
}
.summary a:hover {
  background-color: rgb(54, 187, 248);
  color: rgb(37, 37, 37);
}

.summary::before {
  content: "";
  padding: 2rem;
  background: url(/zen-garden-projectg2/assets/icons8-star-wars.svg) no-repeat center center;
  margin: 1rem auto;
}

.summary::after {
  content: "";
  background: url(/zen-garden-projectg2/assets/millennium-falcon.svg) no-repeat center;
  background-size: cover;
  padding: 3rem;
  margin: 1rem;
  animation: hyperspace 10s linear infinite;
}

@keyframes hyperspace {
  0% {
    transform: scale(0.8);
  }
  5% {
    transform: rotate(45deg);
  }
  10% {
    transform: rotate(90deg);
  }
  15% {
    transform: translate(1rem) rotate(90deg);
  }
  20% {
    transform: translate(1.5rem) rotate(90deg);
  }
  25% {
    transform: translate(2rem) rotate(90deg);
  }
  30% {
    transform: translate(2.5rem) rotate(90deg);
  }
  35% {
    transform: translate(3rem) rotate(90deg);
  }
  40% {
    transform: translate(3rem) rotate(-45deg);
  }
  45% {
    transform: translate(3rem) rotate(-90deg);
  }
  50% {
    transform: translate(-0.5rem) rotate(-90deg);
  }
}
.preamble h3::before {
  content: "";
  background: url(/zen-garden-projectg2/assets/icons8-jedi-order.svg) no-repeat center;
  padding: 3rem;
  margin-top: -3rem;
  display: block;
}

.design-archives ul {
  display: flex;
  gap: 1rem;
  padding: 0.5rem 0;
  justify-content: center;
}
.design-archives ul a {
  background-color: #ffe81f;
  border-radius: 1.5rem;
  color: rgb(37, 37, 37);
  padding: 0.5rem;
  cursor: pointer;
  text-transform: uppercase;
  font-weight: bold;
}
.design-archives ul a:hover {
  color: #ffe81f;
  background: linear-gradient(rgba(0, 0, 0, 0.3), rgba(0, 0, 0, 0.3)), url("/zen-garden-projectg2/assets/Clone-Trooper-wallpapers-HD-for-desktop-backgrounds.jpg");
  object-fit: fill;
}

.supporting footer {
  background: linear-gradient(90deg, rgb(2, 0, 36) 0%, rgb(140, 122, 36) 100%);
  text-align: center;
  padding: 4rem 2rem;
  border-radius: 1.5rem;
  display: flex;
  justify-content: space-around;
  align-items: center;
  width: 95%;
  margin: 1rem auto;
}
.supporting footer a {
  background-color: rgba(0, 0, 0, 0);
  font-style: italic;
}
.supporting footer a:hover {
  color: #fff;
}

.zen-validate-html::before {
  content: "";
  background: url(/zen-garden-projectg2/assets/icons8-html-5.svg);
  background-repeat: no-repeat;
  display: block;
  padding: 1.5rem;
  margin: 0.5rem;
}

.zen-validate-css::before {
  content: "";
  background: url(/zen-garden-projectg2/assets/icons8-css.svg);
  background-repeat: no-repeat;
  display: block;
  padding: 1.5rem;
  margin: 0.5rem;
}

.zen-license::before {
  content: "";
  background: url(https://creativecommons.org/wp-content/themes/vocabulary-theme/vocabulary/svg/cc/icons/cc-icons.svg#cc-logo);
  background-repeat: no-repeat;
  display: block;
  padding: 1.5rem;
  margin: 0.5rem;
}

.zen-github::before {
  content: "";
  background: url(/zen-garden-projectg2/assets/icons8-github.svg);
  background-repeat: no-repeat;
  display: block;
  padding: 1.5rem;
  margin: 0.5rem;
}

h3 {
  background-image: linear-gradient(rgba(0, 0, 0, 0.3), rgba(0, 0, 0, 0.3));
  font-size: 1.5rem;
  text-align: center;
  border-radius: 1.5rem;
  width: 85%;
  color: #ffe81f;
  margin: 1rem auto;
  padding: 1rem;
}

p {
  line-height: 1.5rem;
}

a {
  background-color: black;
  color: #ffe81f;
}
a:hover {
  color: rgb(54, 187, 248);
}

[role=contentinfo] {
  background: linear-gradient(rgba(0, 0, 0, 0.3), rgba(0, 0, 0, 0.5)), url(/zen-garden-projectg2/assets/hyper-space.jpg) no-repeat center;
  width: 85%;
  height: auto;
  padding: 1rem;
  border-radius: 1.5rem;
  font-size: 1.5rem;
  line-height: 2rem;
  margin: 1rem auto;
  text-align: right;
}

[role=navigation] {
  margin: 1rem auto;
  width: 95%;
}

.designer-name {
  font-style: italic;
}

.design-archives {
  background: linear-gradient(rgba(0, 0, 0, 0.3), rgba(0, 0, 0, 0.3)), url("/zen-garden-projectg2/assets/archive-foto.jpg") no-repeat;
  border-radius: 1.5rem;
  padding: 1rem;
  margin: 1rem auto;
  width: 95%;
}

.design-selection ul {
  text-align: center;
  display: grid;
  grid-template-columns: repeat(2, 1fr);
  padding: 1rem;
  gap: 2rem;
  width: 95%;
  margin: 1rem auto;
  align-items: center;
  margin: 1rem auto;
}
.design-selection ul .design-name {
  font-size: 1.5rem;
  color: #fff;
  text-align: center;
  background-color: rgb(37, 37, 37);
}
.design-selection ul .design-name:hover {
  color: #ffe81f;
}

.preamble {
  background-color: #2b2a23;
  text-align: center;
  margin: 1rem auto;
  padding: 1rem;
  border-radius: 1.5rem;
  width: 95%;
}

#zen-supporting {
  background: linear-gradient(rgba(0, 0, 0, 0.3), rgba(0, 0, 0, 0.3)), url("/zen-garden-projectg2/assets/stars.jpg");
  margin: 1rem auto;
  padding: 1rem;
  border-radius: 1.5rem;
  width: 95%;
}

.zen-resources ul {
  text-align: center;
  display: grid;
  grid-template-columns: repeat(2, 1fr);
  padding: 1rem;
  gap: 2rem;
  width: 95%;
  margin: 1rem auto;
  align-items: center;
}
.zen-resources ul a {
  background-color: inherit;
}
.zen-resources ul li:nth-child(5) {
  grid-column: 1/3;
}

.design-selection li:nth-child(1)::after {
  content: "";
  background: url(/zen-garden-projectg2/assets/icons8-mando.svg) no-repeat center;
  transform: scale(0.9);
}
.design-selection li:nth-child(1)::after {
  padding: 3rem;
  display: block;
  margin: 1rem;
}

.design-selection li:nth-child(2)::after {
  content: "";
  background: url(/zen-garden-projectg2/assets/icons8-luke-skywalker.svg) no-repeat center center;
  transform: scale(1.5);
}
.design-selection li:nth-child(2)::after {
  padding: 3rem;
  display: block;
  margin: 1rem;
}

.design-selection li:nth-child(3)::after {
  content: "";
  background: url(/zen-garden-projectg2/assets/icons8-darthvader.svg) no-repeat center center;
  transform: scale(1.5);
}
.design-selection li:nth-child(3)::after {
  padding: 3rem;
  display: block;
  margin: 1rem;
}

.design-selection li:nth-child(4)::after {
  content: "";
  background: url(/zen-garden-projectg2/assets/icons8-r2-d2.svg) no-repeat center center;
  transform: scale(1.5);
}
.design-selection li:nth-child(4)::after {
  padding: 3rem;
  display: block;
  margin: 1rem;
}

.design-selection li:nth-child(5)::after {
  content: "";
  background: url(/zen-garden-projectg2/assets/icons8-trooper.svg) no-repeat center center;
  transform: scale(0.9);
}
.design-selection li:nth-child(5)::after {
  padding: 3rem;
  display: block;
  margin: 1rem;
}

.design-selection li:nth-child(6)::after {
  content: "";
  background: url(/zen-garden-projectg2/assets/icons8-yoda.svg) no-repeat center center;
  transform: scale(0.8);
}
.design-selection li:nth-child(6)::after {
  padding: 3rem;
  display: block;
  margin: 1rem;
}

.design-selection li:nth-child(7)::after {
  content: "";
  background: url(/zen-garden-projectg2/assets/icons8-chewbacca.svg) no-repeat center center;
  transform: scale(1.5);
}
.design-selection li:nth-child(7)::after {
  padding: 3rem;
  display: block;
  margin: 1rem;
}

.design-selection li:nth-child(8)::after {
  content: "";
  background: url(/zen-garden-projectg2/assets/icons8-c-3po.svg) no-repeat center center;
  transform: scale(1.5);
}
.design-selection li:nth-child(8)::after {
  padding: 3rem;
  display: block;
  margin: 1rem;
}

* {
  box-sizing: border-box;
}

html {
  background-color: rgb(37, 37, 37);
}

body {
  font-family: "Sora", sans-serif;
  color: #fff;
  margin: 1 auto;
}

li {
  list-style-type: none;
}

a {
  text-decoration: none;
}

/*# sourceMappingURL=style.cs.map */
