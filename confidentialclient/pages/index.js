export default function MainPage() {
  function getAuthCode() {
    var httpsReq = new XMLHttpRequest();

    httpsReq.open(
      "GET",
      "http://localhost:5088/user/login?ClientId=1072856184116-jnj01odv5fq0tifstbh8c6mop1qpcoap.apps.googleusercontent.com&ClientSecret=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"
    );
    httpsReq.setRequestHeader(
      "Content-Type",
      "application/x-www-form-urlencoded"
    );
    httpsReq.send();
  }
  return (
    <>
      <div>Read Contact from Google</div>
      <button onClick={getAuthCode}>Continue</button>
    </>
  );
}
