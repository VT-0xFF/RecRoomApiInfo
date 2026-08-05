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
		private int RFIYFKXYDHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int LOXVYSNAAHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private Orientation NFQEFFYSTBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool ALVNQVOSSTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Texture YHGEFCQNUXO;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static Shader SFUZCCCHCTZ;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static Shader WIDVSMPWNXV;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static Shader LQEQSHAKCWE;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static Shader AOAPPSNWPIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private bool HDFRVWJYRVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Material EFJRRKBSQDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private List<UIVertex> GQBTEKTRPGS;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static List<int> EAKEDGESNOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private Vector4 JGECESTPHZO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MediaPlayer LJFVYFOWVJT
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xB5C290", Offset = "0xB5B490", VA = "0x180B5C290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x2829A60", Offset = "0x2828C60", VA = "0x182829A60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Texture USZIIRDQWGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xD11790", Offset = "0xD10990", VA = "0x180D11790")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x28299D0", Offset = "0x2828BD0", VA = "0x1828299D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Rect UUUHFIFPCHT
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x1F549D0", Offset = "0x1F53BD0", VA = "0x181F549D0")]
			get
			{
				return default(Rect);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x1F53BE0", Offset = "0x1F52DE0", VA = "0x181F53BE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool AOMUVDGDYIS
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x106F4E0", Offset = "0x106E6E0", VA = "0x18106F4E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x124C3F0", Offset = "0x124B5F0", VA = "0x18124C3F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ScaleMode WNTIXIIECHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x16745F0", Offset = "0x16737F0", VA = "0x1816745F0")]
			get
			{
				return default(ScaleMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x16746B0", Offset = "0x16738B0", VA = "0x1816746B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool SHLUQQFTNVE
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x15AB070", Offset = "0x15AA270", VA = "0x1815AB070")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x15AB0E0", Offset = "0x15AA2E0", VA = "0x1815AB0E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool ZMIMVWMYGNG
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x1B8B1F0", Offset = "0x1B8A3F0", VA = "0x181B8B1F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x1B8AA50", Offset = "0x1B89C50", VA = "0x181B8AA50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Vector4 OTXVHYGRGXF
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x28297B0", Offset = "0x28289B0", VA = "0x1828297B0")]
			get
			{
				return default(Vector4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override Texture mainTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x28297C0", Offset = "0x28289C0", VA = "0x1828297C0", Slot = "36")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public MediaPlayer XUEKICGNWYW
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xB5C290", Offset = "0xB5B490", VA = "0x180B5C290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2829930", Offset = "0x2828B30", VA = "0x182829930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Rect OICXFICZJOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1F549D0", Offset = "0x1F53BD0", VA = "0x181F549D0")]
			get
			{
				return default(Rect);
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2829A70", Offset = "0x2828C70", VA = "0x182829A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2827060", Offset = "0x2826260", VA = "0x182827060", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28294F0", Offset = "0x28286F0", VA = "0x1828294F0")]
		private void ZGHABMWFMSS(MediaPlayer a, MediaPlayerEvent.EventType b, ErrorCode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2828450", Offset = "0x2827650", VA = "0x182828450")]
		private void PHIAORNHOYV(MediaPlayer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x28275C0", Offset = "0x28267C0", VA = "0x1828275C0")]
		private static Shader KTZPKBZJXIX(Shader a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2827B10", Offset = "0x2826D10", VA = "0x182827B10")]
		private static Shader NSEIXUFGNMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2827340", Offset = "0x2826540", VA = "0x182827340")]
		private static Shader EBCGIDEORKY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2827520", Offset = "0x2826720", VA = "0x182827520")]
		private Shader JWUIPIUMTDR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2828BB0", Offset = "0x2827DB0", VA = "0x182828BB0")]
		private static Shader RDEZQXHSUII()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2828F50", Offset = "0x2828150", VA = "0x182828F50", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x28282E0", Offset = "0x28274E0", VA = "0x1828282E0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2828610", Offset = "0x2827810", VA = "0x182828610")]
		private Shader QKHZKUSZUJC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x28273E0", Offset = "0x28265E0", VA = "0x1828273E0")]
		public bool HasValidTexture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2827140", Offset = "0x2826340", VA = "0x182827140")]
		private void DSNAEKPVDSZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x28276A0", Offset = "0x28268A0", VA = "0x1828276A0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2828C50", Offset = "0x2827E50", VA = "0x182828C50", Slot = "46")]
		[ContextMenu("Set Native Size")]
		public override void SetNativeSize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x28283B0", Offset = "0x28275B0", VA = "0x1828283B0", Slot = "45")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2829040", Offset = "0x2828240", VA = "0x182829040")]
		private void TUOPQQQOMHM(List<UIVertex> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2827BB0", Offset = "0x2826DB0", VA = "0x182827BB0")]
		private Vector4 NXXIFJPLRWH(ScaleMode a, Rect b)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x28296B0", Offset = "0x28288B0", VA = "0x1828296B0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		private MediaPlayer _mediaPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		private Text _text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private Image _backgroundImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		private int _backgroundHorizontalPadding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private int _backgroundVerticalPadding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		[Range(-1f, 1024f)]
		private int _maxCharacters;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public MediaPlayer LJFVYFOWVJT
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xABA440", Offset = "0xAB9640", VA = "0x180ABA440")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x282A2F0", Offset = "0x28294F0", VA = "0x18282A2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Text EJCURYRQPTR
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xABA480", Offset = "0xAB9680", VA = "0x180ABA480")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xAB8170", Offset = "0xAB7370", VA = "0x180AB8170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2829E10", Offset = "0x2829010", VA = "0x182829E10")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2829E00", Offset = "0x2829000", VA = "0x182829E00")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2829E20", Offset = "0x2829020", VA = "0x182829E20")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2829AE0", Offset = "0x2828CE0", VA = "0x182829AE0")]
		public void ChangeMediaPlayer(MediaPlayer newPlayer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2829DC0", Offset = "0x2828FC0", VA = "0x182829DC0")]
		private void MMVLMQWDXLB(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2829C90", Offset = "0x2828E90", VA = "0x182829C90")]
		private string KYJOFOAMJKY(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x282A090", Offset = "0x2829290", VA = "0x18282A090")]
		private void ZZQVBPJNJTN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2829E30", Offset = "0x2829030", VA = "0x182829E30")]
		private void ZGHABMWFMSS(MediaPlayer a, MediaPlayerEvent.EventType b, ErrorCode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x282A2D0", Offset = "0x28294D0", VA = "0x18282A2D0")]
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
