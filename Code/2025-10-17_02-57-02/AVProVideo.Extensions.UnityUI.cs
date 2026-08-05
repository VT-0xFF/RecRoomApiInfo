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
		private int UPRHTVRXKDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int YFUEFOVPJIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private Orientation QRIXWPIVDRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool YCNYNORDPAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Texture ISWJTIGIJEM;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static Shader TURPPBPXUQD;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static Shader ZVSBJTWOXPB;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static Shader MJAEMBIRRJO;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static Shader PSOQPYJJUOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private bool SBCGJWFKVQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Material VUDPHIHDOTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private List<UIVertex> ZMLFQFQOXYC;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static List<int> YVEAJMUXQUM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MediaPlayer EIEFMZKSIFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xB0E990", Offset = "0xB0CF90", VA = "0x180B0E990")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x2A29000", Offset = "0x2A27600", VA = "0x182A29000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Texture FAEFBMKNMZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xB10300", Offset = "0xB0E900", VA = "0x180B10300")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x2A28F70", Offset = "0x2A27570", VA = "0x182A28F70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Rect WGQIYEQLJHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xD7D570", Offset = "0xD7BB70", VA = "0x180D7D570")]
			get
			{
				return default(Rect);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xD7D2F0", Offset = "0xD7B8F0", VA = "0x180D7D2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool WSMKACJDJQS
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xB0E9C0", Offset = "0xB0CFC0", VA = "0x180B0E9C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xB0E9E0", Offset = "0xB0CFE0", VA = "0x180B0E9E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ScaleMode ABZZRRVDMHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x19114C0", Offset = "0x190FAC0", VA = "0x1819114C0")]
			get
			{
				return default(ScaleMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x1911570", Offset = "0x190FB70", VA = "0x181911570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool DWRQTGBPEXQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xBBA5E0", Offset = "0xBB8BE0", VA = "0x180BBA5E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xBB8300", Offset = "0xBB6900", VA = "0x180BB8300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool ZVYFXWECIHG
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x1DF91C0", Offset = "0x1DF77C0", VA = "0x181DF91C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x1DF8C90", Offset = "0x1DF7290", VA = "0x181DF8C90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override Texture mainTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2A28D60", Offset = "0x2A27360", VA = "0x182A28D60", Slot = "36")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public MediaPlayer PDJYKSNGRTY
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xB0E990", Offset = "0xB0CF90", VA = "0x180B0E990")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2A28ED0", Offset = "0x2A274D0", VA = "0x182A28ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Rect NWYHUIJSHUR
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xD7D570", Offset = "0xD7BB70", VA = "0x180D7D570")]
			get
			{
				return default(Rect);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x2A29010", Offset = "0x2A27610", VA = "0x182A29010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2A26640", Offset = "0x2A24C40", VA = "0x182A26640", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2A267C0", Offset = "0x2A24DC0", VA = "0x182A267C0")]
		private void DFYFTAWCHGC(MediaPlayer a, MediaPlayerEvent.EventType b, ErrorCode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2A28A00", Offset = "0x2A27000", VA = "0x182A28A00")]
		private void ZBZIHGIYIPT(MediaPlayer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2A28920", Offset = "0x2A26F20", VA = "0x182A28920")]
		private static Shader YSJYQCYERCP(Shader a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2A26720", Offset = "0x2A24D20", VA = "0x182A26720")]
		private static Shader CBPGEXASKGY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2A28880", Offset = "0x2A26E80", VA = "0x182A28880")]
		private static Shader VSOOTFUEUZK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2A268B0", Offset = "0x2A24EB0", VA = "0x182A268B0")]
		private Shader DONTWOWXDID()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2A287E0", Offset = "0x2A26DE0", VA = "0x182A287E0")]
		private static Shader VRTAOZWZSAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2A286F0", Offset = "0x2A26CF0", VA = "0x182A286F0", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2A28280", Offset = "0x2A26880", VA = "0x182A28280", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2A27CE0", Offset = "0x2A262E0", VA = "0x182A27CE0")]
		private Shader MFIFIQLJSFO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2A27080", Offset = "0x2A25680", VA = "0x182A27080")]
		public bool HasValidTexture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2A271C0", Offset = "0x2A257C0", VA = "0x182A271C0")]
		private void KRQEYSBVKYV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2A27870", Offset = "0x2A25E70", VA = "0x182A27870")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2A283F0", Offset = "0x2A269F0", VA = "0x182A283F0", Slot = "46")]
		[ContextMenu("Set Native Size")]
		public override void SetNativeSize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2A28350", Offset = "0x2A26950", VA = "0x182A28350", Slot = "45")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2A273C0", Offset = "0x2A259C0", VA = "0x182A273C0")]
		private void LOQKRBNZPCG(List<UIVertex> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2A26950", Offset = "0x2A24F50", VA = "0x182A26950")]
		private Vector4 HACUFFTUSUT(ScaleMode a, Rect b)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2A28C90", Offset = "0x2A27290", VA = "0x182A28C90")]
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
		public MediaPlayer EIEFMZKSIFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2A29890", Offset = "0x2A27E90", VA = "0x182A29890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Text NYDKNPIFIRN
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xAAFED0", Offset = "0xAAE4D0", VA = "0x180AAFED0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xAA8690", Offset = "0xAA6C90", VA = "0x180AA8690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2A29850", Offset = "0x2A27E50", VA = "0x182A29850")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2A29840", Offset = "0x2A27E40", VA = "0x182A29840")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2A29860", Offset = "0x2A27E60", VA = "0x182A29860")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2A29080", Offset = "0x2A27680", VA = "0x182A29080")]
		public void ChangeMediaPlayer(MediaPlayer newPlayer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2A29800", Offset = "0x2A27E00", VA = "0x182A29800")]
		private void NXMMYNECEQP(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2A296D0", Offset = "0x2A27CD0", VA = "0x182A296D0")]
		private string NWRUBPBJMZK(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2A29490", Offset = "0x2A27A90", VA = "0x182A29490")]
		private void HZEMHIBGFWL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2A29230", Offset = "0x2A27830", VA = "0x182A29230")]
		private void DFYFTAWCHGC(MediaPlayer a, MediaPlayerEvent.EventType b, ErrorCode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2A29870", Offset = "0x2A27E70", VA = "0x182A29870")]
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
