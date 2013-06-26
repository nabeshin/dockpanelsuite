using System.Windows.Forms;

namespace WeifenLuo.WinFormsUI.Docking
{
	/// <summary>
	/// 子供ウィンドウが閉じられようとしている時に発生するイベントの引数オブジェクトです。
	/// </summary>
	public class DockContentClosingEventArgs : DockContentEventArgs
	{
		/// <summary>
		/// オブジェクトを初期化します。
		/// </summary>
		/// <param name="content">閉じられる子供ウィンドウを指定します。</param>
		/// <param name="closeReason">子供ウィンドウが閉じられた理由を指定します。</param>
		public DockContentClosingEventArgs( IDockContent content, CloseReason closeReason ) : base( content )
		{
			this.CloseReason = closeReason;
		}

		/// <summary>
		/// 閉じる処理を中断するかどうかを取得または設定します。
		/// </summary>
		public bool Cancel
		{
			get;
			set;
		}

		/// <summary>
		/// 子供ウィンドウが閉じられた原因を取得します。
		/// </summary>
		public CloseReason CloseReason
		{
			get;
			private set;
		}
	}
}
