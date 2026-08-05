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
		private int VCUPTQJLKSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int KZHUBAXIDBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private Orientation HETQZGDOHWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool MWDNCIQQSVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Texture KVCQJGXBCMP;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static Shader RLPGWGKQFTW;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static Shader HPRHXSDZUUS;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static Shader VATFDOZTVXL;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static Shader FBJKOHVNPJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private bool MZRARSMIKKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Material GMYZPXFNOIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private List<UIVertex> MZHEYECPHAH;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static List<int> GKMBCQJTQLD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MediaPlayer KQMOFRDRBWC
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xB30730", Offset = "0xB2EF30", VA = "0x180B30730")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x2805240", Offset = "0x2803A40", VA = "0x182805240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Texture HQTCKZIRPEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xCE65E0", Offset = "0xCE4DE0", VA = "0x180CE65E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x28051B0", Offset = "0x28039B0", VA = "0x1828051B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Rect ZKIBGZJOZQO
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x1F0C3D0", Offset = "0x1F0ABD0", VA = "0x181F0C3D0")]
			get
			{
				return default(Rect);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x1F0B0F0", Offset = "0x1F098F0", VA = "0x181F0B0F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool CENCCNXCVIX
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x1040BF0", Offset = "0x103F3F0", VA = "0x181040BF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x1245C50", Offset = "0x1244450", VA = "0x181245C50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ScaleMode UWQSQQYPXSE
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x1622D60", Offset = "0x1621560", VA = "0x181622D60")]
			get
			{
				return default(ScaleMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x1622E20", Offset = "0x1621620", VA = "0x181622E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool BDHGWONLYCB
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x1577E70", Offset = "0x1576670", VA = "0x181577E70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x1577EE0", Offset = "0x15766E0", VA = "0x181577EE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool CZRPIHHROIB
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x1B59010", Offset = "0x1B57810", VA = "0x181B59010")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x1B58E80", Offset = "0x1B57680", VA = "0x181B58E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override Texture mainTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2804FA0", Offset = "0x28037A0", VA = "0x182804FA0", Slot = "36")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public MediaPlayer AXYZGLFWRYZ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xB30730", Offset = "0xB2EF30", VA = "0x180B30730")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2805110", Offset = "0x2803910", VA = "0x182805110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Rect SXQRGZGZGWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x1F0C3D0", Offset = "0x1F0ABD0", VA = "0x181F0C3D0")]
			get
			{
				return default(Rect);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x2805250", Offset = "0x2803A50", VA = "0x182805250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2802870", Offset = "0x2801070", VA = "0x182802870", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2803580", Offset = "0x2801D80", VA = "0x182803580")]
		private void KSXHLQWISYF(MediaPlayer a, MediaPlayerEvent.EventType b, ErrorCode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2804590", Offset = "0x2802D90", VA = "0x182804590")]
		private void QUSBDWUFQAU(MediaPlayer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2804D20", Offset = "0x2803520", VA = "0x182804D20")]
		private static Shader ZDEEKRMYYBK(Shader a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x28033A0", Offset = "0x2801BA0", VA = "0x1828033A0")]
		private static Shader HQLDIQDANRZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x28047F0", Offset = "0x2802FF0", VA = "0x1828047F0")]
		private static Shader SQQKHZHMWTP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2804C80", Offset = "0x2803480", VA = "0x182804C80")]
		private Shader TMHYJBRSPHS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2804750", Offset = "0x2802F50", VA = "0x182804750")]
		private static Shader QVDBWOMBOHB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2804B90", Offset = "0x2803390", VA = "0x182804B90", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2803CE0", Offset = "0x28024E0", VA = "0x182803CE0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2802950", Offset = "0x2801150", VA = "0x182802950")]
		private Shader BGMBWKTUKGN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2803440", Offset = "0x2801C40", VA = "0x182803440")]
		public bool HasValidTexture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2803AE0", Offset = "0x28022E0", VA = "0x182803AE0")]
		private void OMANBXUIHUK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2803670", Offset = "0x2801E70", VA = "0x182803670")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2804890", Offset = "0x2803090", VA = "0x182804890", Slot = "46")]
		[ContextMenu("Set Native Size")]
		public override void SetNativeSize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2803DB0", Offset = "0x28025B0", VA = "0x182803DB0", Slot = "45")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2802EF0", Offset = "0x28016F0", VA = "0x182802EF0")]
		private void DAARVVWSEGJ(List<UIVertex> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2803E50", Offset = "0x2802650", VA = "0x182803E50")]
		private Vector4 PWGEQGLIBCI(ScaleMode a, Rect b)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2804ED0", Offset = "0x28036D0", VA = "0x182804ED0")]
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
		public MediaPlayer KQMOFRDRBWC
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2805AD0", Offset = "0x28042D0", VA = "0x182805AD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Text GOTIJJVBZCM
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0F0", Offset = "0xAAB8F0", VA = "0x180AAD0F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xAB0170", Offset = "0xAAE970", VA = "0x180AB0170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2805A90", Offset = "0x2804290", VA = "0x182805A90")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2805950", Offset = "0x2804150", VA = "0x182805950")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2805AA0", Offset = "0x28042A0", VA = "0x182805AA0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x28052C0", Offset = "0x2803AC0", VA = "0x1828052C0")]
		public void ChangeMediaPlayer(MediaPlayer newPlayer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2805470", Offset = "0x2803C70", VA = "0x182805470")]
		private void EEEBJFNVRSK(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2805960", Offset = "0x2804160", VA = "0x182805960")]
		private string RDVJLYVGGXP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x28054B0", Offset = "0x2803CB0", VA = "0x1828054B0")]
		private void EPCCFPCCGZG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x28056F0", Offset = "0x2803EF0", VA = "0x1828056F0")]
		private void KSXHLQWISYF(MediaPlayer a, MediaPlayerEvent.EventType b, ErrorCode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2805AB0", Offset = "0x28042B0", VA = "0x182805AB0")]
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
