using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RenderHeads.Media.AVProVideo
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[HelpURL("http://renderheads.com/products/avpro-video/")]
	[AddComponentMenu("AVPro Video/Display uGUI", 200)]
	[RequireComponent(typeof(CanvasRenderer))]
	public class DisplayUGUI : MaskableGraphic
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private MediaPlayer _mediaPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[Tooltip("Default texture to display when the video texture is preparing")]
		[SerializeField]
		private Texture _defaultTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[FormerlySerializedAs("m_UVRect")]
		[SerializeField]
		private Rect _uvRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private bool _setNativeSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private ScaleMode _scaleMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		private bool _noDefaultDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x109")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private bool _displayInEditor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int KGVBJBMZXXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int UVNCAYZJDUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private Orientation CDDXVBPGLNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool BZMAEWRUUHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Texture UFESPRSKBEG;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static Shader LBGCARQCUYR;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static Shader KLCIAOHSXSJ;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static Shader ECKMQEJHDKW;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static Shader UZKTWQDHJOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private bool HEHHBBXMIFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Material VKHSCBVZZTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private List<UIVertex> SOQWGXVSKUM;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static List<int> PJSOZDLAEDM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MediaPlayer OBAVPYYGRFR
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xC666E0", Offset = "0xC65AE0", VA = "0x180C666E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x279A810", Offset = "0x2799C10", VA = "0x18279A810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Texture VHKPVCBVPHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xC666C0", Offset = "0xC65AC0", VA = "0x180C666C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x279A780", Offset = "0x2799B80", VA = "0x18279A780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Rect XYWBUAGTJPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x1E685F0", Offset = "0x1E679F0", VA = "0x181E685F0")]
			get
			{
				return default(Rect);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x1E668A0", Offset = "0x1E65CA0", VA = "0x181E668A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool XFCOCMZFLMU
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xFC9BB0", Offset = "0xFC8FB0", VA = "0x180FC9BB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x12410E0", Offset = "0x12404E0", VA = "0x1812410E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ScaleMode ZFXOTKRLVZZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x15A0500", Offset = "0x159F900", VA = "0x1815A0500")]
			get
			{
				return default(ScaleMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x15A05C0", Offset = "0x159F9C0", VA = "0x1815A05C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UMUDEKUXPYQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x15063A0", Offset = "0x15057A0", VA = "0x1815063A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x1506410", Offset = "0x1505810", VA = "0x181506410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool RZVCEQLJRFI
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x1AD47D0", Offset = "0x1AD3BD0", VA = "0x181AD47D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x1AD4040", Offset = "0x1AD3440", VA = "0x181AD4040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override Texture mainTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x279A570", Offset = "0x2799970", VA = "0x18279A570", Slot = "36")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public MediaPlayer QWIHORDHXLS
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xC666E0", Offset = "0xC65AE0", VA = "0x180C666E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x279A6E0", Offset = "0x2799AE0", VA = "0x18279A6E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Rect OPEERTCYDMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x1E685F0", Offset = "0x1E679F0", VA = "0x181E685F0")]
			get
			{
				return default(Rect);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x279A820", Offset = "0x2799C20", VA = "0x18279A820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2797E50", Offset = "0x2797250", VA = "0x182797E50", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2798190", Offset = "0x2797590", VA = "0x182798190")]
		private void EKJZPGNFSEE(MediaPlayer a, MediaPlayerEvent.EventType b, ErrorCode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2797F30", Offset = "0x2797330", VA = "0x182797F30")]
		private void CTIXMMVMWMT(MediaPlayer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2798280", Offset = "0x2797680", VA = "0x182798280")]
		private static Shader HHDHXHFAOXL(Shader a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2799810", Offset = "0x2798C10", VA = "0x182799810")]
		private static Shader QOASFAJHEXQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x27980F0", Offset = "0x27974F0", VA = "0x1827980F0")]
		private static Shader DZPDUSCYKTA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x27984A0", Offset = "0x27978A0", VA = "0x1827984A0")]
		private Shader IKLWTRGRAJD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2799400", Offset = "0x2798800", VA = "0x182799400")]
		private static Shader MMXPLRCCFOC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2799BB0", Offset = "0x2798FB0", VA = "0x182799BB0", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x27996A0", Offset = "0x2798AA0", VA = "0x1827996A0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2798540", Offset = "0x2797940", VA = "0x182798540")]
		private Shader JPPIBMOPKTQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2798360", Offset = "0x2797760", VA = "0x182798360")]
		public bool HasValidTexture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x27994A0", Offset = "0x27988A0", VA = "0x1827994A0")]
		private void OQGJNJESGFZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2798F90", Offset = "0x2798390", VA = "0x182798F90")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x27998B0", Offset = "0x2798CB0", VA = "0x1827998B0", Slot = "46")]
		[ContextMenu("Set Native Size")]
		public override void SetNativeSize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2799770", Offset = "0x2798B70", VA = "0x182799770", Slot = "45")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2798AE0", Offset = "0x2797EE0", VA = "0x182798AE0")]
		private void LGLALAYAUDK(List<UIVertex> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2799CA0", Offset = "0x27990A0", VA = "0x182799CA0")]
		private Vector4 XDIAPDZCCFH(ScaleMode a, Rect b)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x279A4A0", Offset = "0x27998A0", VA = "0x18279A4A0")]
		public DisplayUGUI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AddComponentMenu("AVPro Video/Subtitles uGUI", 201)]
	[HelpURL("http://renderheads.com/products/avpro-video/")]
	public class SubtitlesUGUI : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private MediaPlayer _mediaPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		private Text _text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		private Image _backgroundImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private int _backgroundHorizontalPadding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		private int _backgroundVerticalPadding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		[Range(-1f, 1024f)]
		private int _maxCharacters;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public MediaPlayer OBAVPYYGRFR
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x279B0A0", Offset = "0x279A4A0", VA = "0x18279B0A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Text NDLHNVCRWBD
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x279B020", Offset = "0x279A420", VA = "0x18279B020")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x279AEE0", Offset = "0x279A2E0", VA = "0x18279AEE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x279B030", Offset = "0x279A430", VA = "0x18279B030")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x279A890", Offset = "0x2799C90", VA = "0x18279A890")]
		public void ChangeMediaPlayer(MediaPlayer newPlayer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x279B040", Offset = "0x279A440", VA = "0x18279B040")]
		private void VMZWGIBXOLX(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x279AEF0", Offset = "0x279A2F0", VA = "0x18279AEF0")]
		private string QQOLTJXAPBQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x279ACA0", Offset = "0x279A0A0", VA = "0x18279ACA0")]
		private void KBETDETUSGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x279AA40", Offset = "0x2799E40", VA = "0x18279AA40")]
		private void EKJZPGNFSEE(MediaPlayer a, MediaPlayerEvent.EventType b, ErrorCode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x279B080", Offset = "0x279A480", VA = "0x18279B080")]
		public SubtitlesUGUI()
		{
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
