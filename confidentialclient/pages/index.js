export default function MainPage() {
  function getAuthCode() {
    var httpsReq = new XMLHttpRequest();
    httpsReq.open("GET", "http://localhost:5088/user/login");
    httpsReq.send();
  }
  return (
    <>
      <div>Read Contact from Google</div>
      <button onClick={getAuthCode}>Continue</button>
    </>
  );
}
