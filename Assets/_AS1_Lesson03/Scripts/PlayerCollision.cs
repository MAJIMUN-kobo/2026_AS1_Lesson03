using UnityEngine;

// ===============================
// プレイヤーの衝突コンポーネント
// ===============================
public class PlayerCollision : MonoBehaviour
{
    private bool _useItem = false;  // アイテムを取ったフラグ
    private int _enemyCount = 0;    // 倒した敵の数
    private int _playerLevel = 1;   // プレイヤーのレベル
    private float _playerSpeed = 1.0f;  // プレイヤーの速度

    // === 自分のプロフィールに必要な変数 ==>>
    private string _playerName;
    private int _playerAge;
    private int _playerBirthYear;
    private float _playerWeight;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // === 衝突を検知するメソッド === //
    // Rigidbody2D が Collider2D との衝突を検知したときに、
    // 呼び出されるメソッドです。
    void OnCollisionEnter2D( Collision2D hitObject )
    {   
        Debug.Log($"{ hitObject.transform.name }にぶつかったよ");

        // === 特定のオブジェクトのみを仕分ける分岐 === >>
        if( hitObject.transform.name == "Enemy" && _useItem == true)
        {   // 名前を使った仕分け（Enemey）
            hitObject.gameObject.SetActive(false);
        }

        if( hitObject.transform.name == "Item" )
        {   // 名前を使った仕分け（Item）
            hitObject.gameObject.SetActive(false);
            _useItem = true;
        }

        // - 衝突したオブジェクトを隠す
        // hitObject.gameObject.SetActive( false );

        // - 衝突したオブジェクトを破棄する
        // Destroy(hitObject.gameObject);
    }
}
