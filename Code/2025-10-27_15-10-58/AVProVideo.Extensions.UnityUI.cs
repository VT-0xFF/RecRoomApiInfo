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
		private int FEJGAZQNJTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int CQPRJGMCWSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private Orientation ESKFQLJCEMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool KJMBBJAXRWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Texture YNYVEDHBWWV;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static Shader IGGSYBYNDNA;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static Shader XCXJMJNPFME;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static Shader QFGIUGWBYWT;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static Shader GRCUSUNIKJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private bool OQXZXMWSSOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Material VBYNZSPHQFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private List<UIVertex> UMLSTNXAEEB;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static List<int> PFQTPHYQQOT;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MediaPlayer ISHKZMINKDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xB553E0", Offset = "0xB543E0", VA = "0x180B553E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x2A9E840", Offset = "0x2A9D840", VA = "0x182A9E840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Texture KANCJKGREGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xB554C0", Offset = "0xB544C0", VA = "0x180B554C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x2A9E7B0", Offset = "0x2A9D7B0", VA = "0x182A9E7B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Rect OORGMGCBMEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xDEA000", Offset = "0xDE9000", VA = "0x180DEA000")]
			get
			{
				return default(Rect);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xDEA0E0", Offset = "0xDE90E0", VA = "0x180DEA0E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool JUEYGVANVAR
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xB5C090", Offset = "0xB5B090", VA = "0x180B5C090")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xB5C0D0", Offset = "0xB5B0D0", VA = "0x180B5C0D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ScaleMode UGLQWHVXZFU
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x1981280", Offset = "0x1980280", VA = "0x181981280")]
			get
			{
				return default(ScaleMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x1981330", Offset = "0x1980330", VA = "0x181981330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool BFNQCZIINHB
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xC0C5B0", Offset = "0xC0B5B0", VA = "0x180C0C5B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xC0C7D0", Offset = "0xC0B7D0", VA = "0x180C0C7D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool WKHLUPCDFOT
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x1E6EC50", Offset = "0x1E6DC50", VA = "0x181E6EC50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x1E6EAC0", Offset = "0x1E6DAC0", VA = "0x181E6EAC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override Texture mainTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2A9E5A0", Offset = "0x2A9D5A0", VA = "0x182A9E5A0", Slot = "36")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public MediaPlayer RKYAIPZPFKH
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xB553E0", Offset = "0xB543E0", VA = "0x180B553E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2A9E710", Offset = "0x2A9D710", VA = "0x182A9E710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Rect IBZWMFZLTKU
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xDEA000", Offset = "0xDE9000", VA = "0x180DEA000")]
			get
			{
				return default(Rect);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x2A9E850", Offset = "0x2A9D850", VA = "0x182A9E850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2A9BE00", Offset = "0x2A9AE00", VA = "0x182A9BE00", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2A9D550", Offset = "0x2A9C550", VA = "0x182A9D550")]
		private void VDINSOIDHMD(MediaPlayer a, MediaPlayerEvent.EventType b, ErrorCode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2A9C8F0", Offset = "0x2A9B8F0", VA = "0x182A9C8F0")]
		private void PKKZCJXSVXE(MediaPlayer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2A9BEE0", Offset = "0x2A9AEE0", VA = "0x182A9BEE0")]
		private static Shader EDLFTNTWAUG(Shader a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2A9C6D0", Offset = "0x2A9B6D0", VA = "0x182A9C6D0")]
		private static Shader MYPURJPGWGF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2A9C1B0", Offset = "0x2A9B1B0", VA = "0x182A9C1B0")]
		private static Shader KBTBBCPWMHZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2A9C100", Offset = "0x2A9B100", VA = "0x182A9C100")]
		private Shader JNCHGSVUDHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2A9D640", Offset = "0x2A9C640", VA = "0x182A9D640")]
		private static Shader WKIYKNYUTXD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2A9CDB0", Offset = "0x2A9BDB0", VA = "0x182A9CDB0", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2A9C780", Offset = "0x2A9B780", VA = "0x182A9C780", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2A9DE30", Offset = "0x2A9CE30", VA = "0x182A9DE30")]
		private Shader ZXDVFJQUDMD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2A9BFC0", Offset = "0x2A9AFC0", VA = "0x182A9BFC0")]
		public bool HasValidTexture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2A9D350", Offset = "0x2A9C350", VA = "0x182A9D350")]
		private void UCCUAPBOOQU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2A9C260", Offset = "0x2A9B260", VA = "0x182A9C260")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2A9CAB0", Offset = "0x2A9BAB0", VA = "0x182A9CAB0", Slot = "46")]
		[ContextMenu("Set Native Size")]
		public override void SetNativeSize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2A9C850", Offset = "0x2A9B850", VA = "0x182A9C850", Slot = "45")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2A9CEA0", Offset = "0x2A9BEA0", VA = "0x182A9CEA0")]
		private void UBINAQELYXB(List<UIVertex> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2A9D6F0", Offset = "0x2A9C6F0", VA = "0x182A9D6F0")]
		private Vector4 ZCKSNONARZA(ScaleMode a, Rect b)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E4D0", Offset = "0x2A9D4D0", VA = "0x182A9E4D0")]
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
		public MediaPlayer ISHKZMINKDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xAD0670", Offset = "0xACF670", VA = "0x180AD0670")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2A9F0E0", Offset = "0x2A9E0E0", VA = "0x182A9F0E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Text LQFVZIEYBGS
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xACFF90", Offset = "0xACEF90", VA = "0x180ACFF90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xACFB20", Offset = "0xACEB20", VA = "0x180ACFB20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2A9EE00", Offset = "0x2A9DE00", VA = "0x182A9EE00")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2A9EDF0", Offset = "0x2A9DDF0", VA = "0x182A9EDF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2A9EE50", Offset = "0x2A9DE50", VA = "0x182A9EE50")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2A9EB00", Offset = "0x2A9DB00", VA = "0x182A9EB00")]
		public void ChangeMediaPlayer(MediaPlayer newPlayer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2A9EE10", Offset = "0x2A9DE10", VA = "0x182A9EE10")]
		private void UBPSPZRCCKU(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2A9ECB0", Offset = "0x2A9DCB0", VA = "0x182A9ECB0")]
		private string OZNLMSBHOST(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E8C0", Offset = "0x2A9D8C0", VA = "0x182A9E8C0")]
		private void AWIDXIKKOEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2A9EE60", Offset = "0x2A9DE60", VA = "0x182A9EE60")]
		private void VDINSOIDHMD(MediaPlayer a, MediaPlayerEvent.EventType b, ErrorCode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2A9F0C0", Offset = "0x2A9E0C0", VA = "0x182A9F0C0")]
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
