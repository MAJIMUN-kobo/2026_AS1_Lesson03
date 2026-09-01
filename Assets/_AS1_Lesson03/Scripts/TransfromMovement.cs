using UnityEngine;
using UnityEngine.InputSystem;

// ------------------------------
// クラス定義
// ------------------------------
public class TransfromMovement : MonoBehaviour
{

    // ------------------------------
    // メソッド（スクラッチでいうところのカスタムブロック）
    // メソッド名：Start
    // 引数　　　：ない
    // 戻り値　　：ない
    // ------------------------------
    void Start( )
    {
        
    }

    // ------------------------------
    // メソッド（スクラッチでいうところのカスタムブロック）
    // メソッド名：Update
    // 引数　　　：ない
    // 戻り値　　：ない
    // ------------------------------
    void Update()
    {
        // ■　座標（ベクトル）を作る
        Vector3 position = new Vector3(0, 0);

        // ■　座標の値を変更する
        //position.x = 0f;
        //position.y = 2.5f;

        if ( Keyboard.current.leftArrowKey.isPressed )
        {   // 左矢印キーが押されている場合、左に移動する
            position.x = -2.5f;
        }

        if( Keyboard.current.rightArrowKey.isPressed)
        {   // 右矢印キーが押されている場合、右に移動する
            position.x = 2.5f;
        }

        if( Keyboard.current.upArrowKey.isPressed )
        {   // 上矢印キーが押されている場合、上に移動する
            position.y = 2.5f;
        }

        if(Keyboard.current.downArrowKey.isPressed)
        {   // 下矢印キーが押されている場合、下に移動する
            position.y = -2.5f;
        }

        // ============================================================
        // 問題. 画面の端に行ったら、反対側に移動するようにしてみよう
        // ヒント：transform.position.x の値を使うと、現在の座標を取得できる
        // ============================================================
        if( transform.position.x < -9.8f )
        {   // x座標が -9.8 より＜小さく＞なったら、x座標を 9.0 にする
            Vector3 warpPosition = new Vector3(9.0f, transform.position.y);
            transform.position = warpPosition;  // 移動先を反映させる
        }

        if( transform.position.x > 9.8f )
        {   // x座標が 9.8 より＜大きく＞なったら、x座標を -9.0 にする
            Vector3 warpPosition = new Vector3(-9.0f, transform.position.y);
            transform.position = warpPosition;  // 移動先を反映させる
        }

        // ■　座標を反映する
        // ※ Time.deltaTimeを掛けることで、フレームレートに依存しない動きになる
        transform.position += position * Time.deltaTime;
    }
}
