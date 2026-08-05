using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using RenderHeads.Media.AVProVideo;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.Serialization;
using UnityEngine.Video;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class ApplyToFarPlane_CameraApplier : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[SerializeField]
	private Material _material;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Material FJEHDIIFJLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x29ECA00", Offset = "0x29EB800", VA = "0x1829ECA00")]
	private void OnWillRenderObject()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xA969E0", Offset = "0xA957E0", VA = "0x180A969E0")]
	public ApplyToFarPlane_CameraApplier()
	{
	}
}
namespace RenderHeads.Media.AVProVideo
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CreateAssetMenu(fileName = "MediaReference", menuName = "AVPro Video/Media Reference", order = 51)]
	public class MediaReference : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private string _alias;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private MediaPath _mediaPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[Header("Media Hints")]
		[SerializeField]
		private MediaHints _hints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		[Header("Platform Overrides")]
		private MediaReference _macOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		private MediaReference _windows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private MediaReference _android;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private MediaReference _openharmony;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private MediaReference _iOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private MediaReference _tvOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		private MediaReference _windowsUWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[SerializeField]
		private MediaReference _webGL;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public string Alias
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public MediaPath MediaPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public MediaHints Hints
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x165EFF0", Offset = "0x165DDF0", VA = "0x18165EFF0")]
			get
			{
				return default(MediaHints);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x29FB4B0", Offset = "0x29FA2B0", VA = "0x1829FB4B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x29FB2E0", Offset = "0x29FA0E0", VA = "0x1829FB2E0")]
		public MediaReference EIBDACMFEIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x29FB350", Offset = "0x29FA150", VA = "0x1829FB350")]
		public MediaReference LBFCDHLJDKG(AGCLFFMNHJA BMMNCBMEGCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x29FB3E0", Offset = "0x29FA1E0", VA = "0x1829FB3E0")]
		public MediaReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[HelpURL("https://www.renderheads.com/products/avpro-video/")]
	[AddComponentMenu("AVPro Video/Apply To Far Plane", 300)]
	public sealed class ApplyToFarPlane : ApplyToBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum PAGHLJNCPNO
		{
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			Left,
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			Right
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		[Tooltip("The color override to apply to the material")]
		[Header("Shader Options")]
		private Color _mainColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		[Tooltip("The Main Texture that is being written to by the Media Player")]
		private Texture _texture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[Tooltip("The Chroma Texture to apply to the material")]
		[SerializeField]
		private Texture _chroma;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[Tooltip("Alpha of the far plane that is drawn")]
		[SerializeField]
		private float _alpha;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[Tooltip("The Camera far plane to draw to, if left empty main cam will be selected")]
		[SerializeField]
		private Camera _camera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[Tooltip("The aspect ratio of the video shown, not used when a custom scaling is set")]
		[SerializeField]
		private VideoAspectRatio _aspectRatio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[Tooltip("How much to offset the image by")]
		public Vector2 _drawOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[Tooltip("Will replace the Aspect Ratio with custom scaling for the video, when both values are non-zero")]
		public Vector2 _customScaling;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private GameObject KPOAOCBKDLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool KAMKHBEFCPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[Header("Display")]
		[SerializeField]
		[Tooltip("Default texture to display when the video texture is preparing")]
		private Texture2D _defaultTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[Tooltip("The Material to use when rendering the video, if not set will use internal \n Note: Material must use the AVProVideo/Background/AVProVideo-ApplyToFarPlane shader")]
		[SerializeField]
		private Material _material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		private string _texturePropertyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Vector2 _offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private Vector2 _scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private Texture EMAGHNDIBHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private FNCEDKJJNKJ JJDFNLLMIPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private FNCEDKJJNKJ NOIKMHICNLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private Texture PKEIHCEFPIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Vector2 CODJLPJECOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Vector2 KPNFPBHKNAM;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Color HOLBPHLLBHA
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xF5AAD0", Offset = "0xF598D0", VA = "0x180F5AAD0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x29EE800", Offset = "0x29ED600", VA = "0x1829EE800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Texture IKJGNDCECOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97960", VA = "0x180A98B60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x29EEA50", Offset = "0x29ED850", VA = "0x1829EEA50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Texture ILEBIHFBOPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xA98CF0", Offset = "0xA97AF0", VA = "0x180A98CF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x29EE4F0", Offset = "0x29ED2F0", VA = "0x1829EE4F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float HHGGAPDIOPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x1284C80", Offset = "0x1283A80", VA = "0x181284C80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x29EE370", Offset = "0x29ED170", VA = "0x1829EE370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Camera FFKNMKCLCGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA931F0", Offset = "0xA91FF0", VA = "0x180A931F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x29EE420", Offset = "0x29ED220", VA = "0x1829EE420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public VideoAspectRatio KNKEEDKEAOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xD4C240", Offset = "0xD4B040", VA = "0x180D4C240")]
			get
			{
				return default(VideoAspectRatio);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x29EEB10", Offset = "0x29ED910", VA = "0x1829EEB10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Vector2 MLNEOMAODEF
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x29EE310", Offset = "0x29ED110", VA = "0x1829EE310")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x29EE720", Offset = "0x29ED520", VA = "0x1829EE720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Vector2 DOONEKIDKEN
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x1284C90", Offset = "0x1283A90", VA = "0x181284C90")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x29EE5B0", Offset = "0x29ED3B0", VA = "0x1829EE5B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Texture2D AOOJCECPEIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xA9EEE0", Offset = "0xA9DCE0", VA = "0x180A9EEE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x29EE690", Offset = "0x29ED490", VA = "0x1829EE690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public string DCGHAKEANMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xA9EE60", Offset = "0xA9DC60", VA = "0x180A9EE60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x29EE960", Offset = "0x29ED760", VA = "0x1829EE960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Vector2 CFPFFIDODCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x29EE330", Offset = "0x29ED130", VA = "0x1829EE330")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x29EE8C0", Offset = "0x29ED6C0", VA = "0x1829EE8C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Vector2 JLNAGFEDOMC
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x29EE350", Offset = "0x29ED150", VA = "0x1829EE350")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x29EE910", Offset = "0x29ED710", VA = "0x1829EE910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private Vector2 NIHBODLOODC
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x29ECFA0", Offset = "0x29EBDA0", VA = "0x1829ECFA0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x29EC910", Offset = "0x29EB710", VA = "0x1829EC910")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x29ED720", Offset = "0x29EC520", VA = "0x1829ED720", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x29ED6D0", Offset = "0x29EC4D0", VA = "0x1829ED6D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x29EDFF0", Offset = "0x29ECDF0", VA = "0x1829EDFF0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x29ECC10", Offset = "0x29EBA10", VA = "0x1829ECC10")]
		public Mesh CreateQuadMesh()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x29ECAB0", Offset = "0x29EB8B0", VA = "0x1829ECAB0")]
		public void CreateMaterial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x29ED7F0", Offset = "0x29EC5F0", VA = "0x1829ED7F0", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xAF99E0", Offset = "0xAF87E0", VA = "0x180AF99E0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x29EDD30", Offset = "0x29ECB30", VA = "0x1829EDD30")]
		public void UpdateMaterialProperties(int BNIHAACOHPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x29EC3D0", Offset = "0x29EB1D0", VA = "0x1829EC3D0", Slot = "8")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x29ED210", Offset = "0x29EC010", VA = "0x1829ED210")]
		private void NKEGPLCPOIM(Texture JDNNGPGPIOL, bool MMAPPOJNDEM, int PIPPAANOGKJ = 0, PAGHLJNCPNO EHIIBJIFNCD = PAGHLJNCPNO.Left)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x29EDAF0", Offset = "0x29EC8F0", VA = "0x1829EDAF0", Slot = "6")]
		protected override void POBPADLKBOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x29ED070", Offset = "0x29EBE70", VA = "0x1829ED070", Slot = "7")]
		protected override void JLDPNMHAAGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x29EE1A0", Offset = "0x29ECFA0", VA = "0x1829EE1A0")]
		public ApplyToFarPlane()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[HelpURL("https://www.renderheads.com/products/avpro-video/")]
	[AddComponentMenu("AVPro Video/Apply To Material", 300)]
	public sealed class ApplyToMaterial : ApplyToBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private enum JPAFHJEEDIE
		{
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			Left,
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			Right
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[Header("Display")]
		[SerializeField]
		[Tooltip("Default texture to display when the video texture is preparing")]
		private Texture2D _defaultTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[Header("Material Target")]
		[SerializeField]
		[Space(8f)]
		private Material _material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[SerializeField]
		private string _texturePropertyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		private Vector2 _offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[SerializeField]
		private Vector2 _scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private Texture EMAGHNDIBHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private FNCEDKJJNKJ JJDFNLLMIPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private FNCEDKJJNKJ NOIKMHICNLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private Texture PKEIHCEFPIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private Vector2 CODJLPJECOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private Vector2 KPNFPBHKNAM;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Texture2D AOOJCECPEIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x29EF9F0", Offset = "0x29EE7F0", VA = "0x1829EF9F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Material FJEHDIIFJLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x29EFA70", Offset = "0x29EE870", VA = "0x1829EFA70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string DCGHAKEANMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97960", VA = "0x180A98B60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x29EFB90", Offset = "0x29EE990", VA = "0x1829EFB90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector2 CFPFFIDODCG
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x29EF9B0", Offset = "0x29EE7B0", VA = "0x1829EF9B0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x29EFAF0", Offset = "0x29EE8F0", VA = "0x1829EFAF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Vector2 JLNAGFEDOMC
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x29EF9D0", Offset = "0x29EE7D0", VA = "0x1829EF9D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x29EFB40", Offset = "0x29EE940", VA = "0x1829EFB40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xAF99E0", Offset = "0xAF87E0", VA = "0x180AF99E0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x29EEBC0", Offset = "0x29ED9C0", VA = "0x1829EEBC0", Slot = "8")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x29EF260", Offset = "0x29EE060", VA = "0x1829EF260")]
		private void NKEGPLCPOIM(Texture JDNNGPGPIOL, bool MMAPPOJNDEM, int PIPPAANOGKJ = 0, JPAFHJEEDIE EHIIBJIFNCD = JPAFHJEEDIE.Left)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x29EF660", Offset = "0x29EE460", VA = "0x1829EF660", Slot = "6")]
		protected override void POBPADLKBOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x29EF0F0", Offset = "0x29EDEF0", VA = "0x1829EF0F0", Slot = "7")]
		protected override void JLDPNMHAAGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x29EF860", Offset = "0x29EE660", VA = "0x1829EF860")]
		public ApplyToMaterial()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[AddComponentMenu("AVPro Video/Apply To Mesh", 300)]
	[HelpURL("https://www.renderheads.com/products/avpro-video/")]
	public sealed class ApplyToMesh : ApplyToBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private enum KJPAFODCJJK
		{
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			Left,
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			Right
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[Header("Display")]
		[Space(8f)]
		[Tooltip("Default texture to display when the video texture is preparing")]
		[SerializeField]
		private Texture2D _defaultTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[Header("Renderer Target")]
		[FormerlySerializedAs("_mesh")]
		[SerializeField]
		[Space(8f)]
		private Renderer _renderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private int _materialIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private string _texturePropertyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		private Vector2 _offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		private Vector2 _scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private Texture EMAGHNDIBHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private FNCEDKJJNKJ JJDFNLLMIPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private FNCEDKJJNKJ NOIKMHICNLI;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Texture2D AOOJCECPEIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x29F01E0", Offset = "0x29EEFE0", VA = "0x1829F01E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Renderer GNEPJHGPILD
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x29F0290", Offset = "0x29EF090", VA = "0x1829F0290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public int ELMKOMNABBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xB16A90", Offset = "0xB15890", VA = "0x180B16A90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xB169F0", Offset = "0xB157F0", VA = "0x180B169F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public string DCGHAKEANMB
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA98CF0", Offset = "0xA97AF0", VA = "0x180A98CF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x29F0B40", Offset = "0x29EF940", VA = "0x1829F0B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector2 CFPFFIDODCG
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x29EF9D0", Offset = "0x29EE7D0", VA = "0x1829EF9D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x29EFB40", Offset = "0x29EE940", VA = "0x1829EFB40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector2 JLNAGFEDOMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x29F0AD0", Offset = "0x29EF8D0", VA = "0x1829F0AD0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x29F0AF0", Offset = "0x29EF8F0", VA = "0x1829F0AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x29F01E0", Offset = "0x29EEFE0", VA = "0x1829F01E0")]
		private void FPCONLCJHNE(Texture2D JDNNGPGPIOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x29F0290", Offset = "0x29EF090", VA = "0x1829F0290")]
		private void KLBHPCLHIED(Renderer NNEJGKAIJNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xAF99E0", Offset = "0xAF87E0", VA = "0x180AF99E0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x29EFC60", Offset = "0x29EEA60", VA = "0x1829EFC60", Slot = "8")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x29F0370", Offset = "0x29EF170", VA = "0x1829F0370")]
		private void NKEGPLCPOIM(Texture JDNNGPGPIOL, bool MMAPPOJNDEM, int PIPPAANOGKJ, KJPAFODCJJK EHIIBJIFNCD = KJPAFODCJJK.Left, int IDNAPJMNGPO = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x29F0820", Offset = "0x29EF620", VA = "0x1829F0820", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x29F07F0", Offset = "0x29EF5F0", VA = "0x1829F07F0", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x29F0960", Offset = "0x29EF760", VA = "0x1829F0960", Slot = "6")]
		protected override void POBPADLKBOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x29F0A00", Offset = "0x29EF800", VA = "0x1829F0A00")]
		public ApplyToMesh()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[HelpURL("https://www.renderheads.com/products/avpro-video/")]
	[AddComponentMenu("AVPro Video/Audio Channel Mixer", 401)]
	public class AudioChannelMixer : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const int FHJJMNBKBLF = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[Range(0f, 1f)]
		[SerializeField]
		private float[] _channels;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float[] LCFEAAEINDH
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x29F0EC0", Offset = "0x29EFCC0", VA = "0x1829F0EC0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x29F0C10", Offset = "0x29EFA10", VA = "0x1829F0C10")]
		private void DKODEKJKIAL(int KDOCNAFDGBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x29F0D10", Offset = "0x29EFB10", VA = "0x1829F0D10")]
		private void OnAudioFilterRead(float[] KANAIIDGHCH, int GBHDIJIKCIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA969E0", Offset = "0xA957E0", VA = "0x180A969E0")]
		public AudioChannelMixer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[HelpURL("https://www.renderheads.com/products/avpro-video/")]
	[AddComponentMenu("AVPro Video/Audio Output", 400)]
	[RequireComponent(typeof(AudioSource))]
	public class AudioOutput : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public enum LDMLFEBJEDA
		{
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			OneToAllChannels,
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			MultipleChannels
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		private MediaPlayer _mediaPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		private LDMLFEBJEDA _audioOutputMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[HideInInspector]
		[SerializeField]
		private int _channelMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		private bool _supportPositionalAudio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private int FEBFFHCPAEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private AudioSource HOPKCAMEIBK;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public MediaPlayer JDMOPPJJKDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x29F1A40", Offset = "0x29F0840", VA = "0x1829F1A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public LDMLFEBJEDA NGPCBDNIBLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAE69D0", Offset = "0xAE57D0", VA = "0x180AE69D0")]
			get
			{
				return default(LDMLFEBJEDA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xAE69E0", Offset = "0xAE57E0", VA = "0x180AE69E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int BNGDPBLDJBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xC38810", Offset = "0xC37610", VA = "0x180C38810")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x107E820", Offset = "0x107D620", VA = "0x18107E820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x29F0F50", Offset = "0x29EFD50", VA = "0x1829F0F50")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x29F18B0", Offset = "0x29F06B0", VA = "0x1829F18B0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x29F1730", Offset = "0x29F0530", VA = "0x1829F1730")]
		private void PKCAJAJMBAF(bool DKMHBOMDKHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x29F1720", Offset = "0x29F0520", VA = "0x1829F1720")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x29F1940", Offset = "0x29F0740", VA = "0x1829F1940")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		public AudioSource GetAudioSource()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x29F1810", Offset = "0x29F0610", VA = "0x1829F1810")]
		public void SetAudioSource(AudioSource MKPEOGPFEFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x29F0FA0", Offset = "0x29EFDA0", VA = "0x1829F0FA0")]
		public void ChangeMediaPlayer(MediaPlayer DKNBBLLPJCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x29F1640", Offset = "0x29F0440", VA = "0x1829F1640")]
		private void HCDNFBKOBGE(MediaPlayer IABBFMOBIIL, MediaPlayerEvent.BALPDIFPDHA FIJBBOMCDKN, DLLKIBIDOAK KAFEFLDOPOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x29F1480", Offset = "0x29F0280", VA = "0x1829F1480")]
		private static void FGKIBLKNBPG(MediaPlayer GLMBLPAKFLM, AudioSource FBABCNPBHOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x29F16A0", Offset = "0x29F04A0", VA = "0x1829F16A0")]
		private void OnAudioFilterRead(float[] PJLPHHNGJFC, int KMCPCDKHDCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x29F1A20", Offset = "0x29F0820", VA = "0x1829F1A20")]
		public AudioOutput()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[ExecuteInEditMode]
	[HelpURL("https://www.renderheads.com/products/avpro-video/")]
	[AddComponentMenu("AVPro Video/Display IMGUI", 200)]
	public class DisplayIMGUI : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[SerializeField]
		private MediaPlayer _mediaPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[SerializeField]
		private ScaleMode _scaleMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[SerializeField]
		private Color _color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		[FormerlySerializedAs("_alphaBlend")]
		private bool _allowTransparency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		private bool _useDepth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		private int _depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Header("Area")]
		[SerializeField]
		[FormerlySerializedAs("_fullScreen")]
		private bool _isAreaFullScreen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[SerializeField]
		[Range(0f, 1f)]
		[FormerlySerializedAs("_x")]
		private float _areaX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		[Range(0f, 1f)]
		[FormerlySerializedAs("_y")]
		private float _areaY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[SerializeField]
		[Range(0f, 1f)]
		[FormerlySerializedAs("_width")]
		private float _areaWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[Range(0f, 1f)]
		[FormerlySerializedAs("_height")]
		[SerializeField]
		private float _areaHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		[FormerlySerializedAs("_displayInEditor")]
		private bool _showAreaInEditor;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static Shader APBCJELIHIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private Material MMGJMIDGJHL;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public MediaPlayer JDMOPPJJKDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x29F2960", Offset = "0x29F1760", VA = "0x1829F2960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public ScaleMode FPOCMACEGMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAE69D0", Offset = "0xAE57D0", VA = "0x180AE69D0")]
			get
			{
				return default(ScaleMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xAE69E0", Offset = "0xAE57E0", VA = "0x180AE69E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Color MDANDEECNMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xEA1490", Offset = "0xEA0290", VA = "0x180EA1490")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x10A7600", Offset = "0x10A6400", VA = "0x1810A7600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool JBOFLAGCKEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xF01590", Offset = "0xF00390", VA = "0x180F01590")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xF17A70", Offset = "0xF16870", VA = "0x180F17A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool MCCKGNJBKGE
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xF17B70", Offset = "0xF16970", VA = "0x180F17B70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xF17840", Offset = "0xF16640", VA = "0x180F17840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public int BBKOLINEDMC
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xAB29F0", Offset = "0xAB17F0", VA = "0x180AB29F0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xED3350", Offset = "0xED2150", VA = "0x180ED3350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool JOHMHDPODJM
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xFBC1B0", Offset = "0xFBAFB0", VA = "0x180FBC1B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xFBC1A0", Offset = "0xFBAFA0", VA = "0x180FBC1A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float DGMJJILHEAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xD5B910", Offset = "0xD5A710", VA = "0x180D5B910")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xD5BD60", Offset = "0xD5AB60", VA = "0x180D5BD60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public float GGFKNDCEMCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xE6D8E0", Offset = "0xE6C6E0", VA = "0x180E6D8E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x1C6DA20", Offset = "0x1C6C820", VA = "0x181C6DA20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float DHCPHFCJBKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xAE5FF0", Offset = "0xAE4DF0", VA = "0x180AE5FF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x107B020", Offset = "0x1079E20", VA = "0x18107B020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float DPDEIPBLKBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xF29370", Offset = "0xF28170", VA = "0x180F29370")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xF29380", Offset = "0xF28180", VA = "0x180F29380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool GCINBNBHKDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xB1E4C0", Offset = "0xB1D2C0", VA = "0x180B1E4C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xB1E540", Offset = "0xB1D340", VA = "0x180B1E540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x29F2610", Offset = "0x29F1410", VA = "0x1829F2610")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x29F2740", Offset = "0x29F1540", VA = "0x1829F2740")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x29F1EC0", Offset = "0x29F0CC0", VA = "0x1829F1EC0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x29F1BA0", Offset = "0x29F09A0", VA = "0x1829F1BA0")]
		private Shader CPFPHFMBNGJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x29F1D20", Offset = "0x29F0B20", VA = "0x1829F1D20")]
		private void KFHEIAHFDAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x29F1F60", Offset = "0x29F0D60", VA = "0x1829F1F60")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x29F1BE0", Offset = "0x29F09E0", VA = "0x1829F1BE0")]
		public Rect GetAreaRect()
		{
			return default(Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x29F2930", Offset = "0x29F1730", VA = "0x1829F2930")]
		public DisplayIMGUI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteInEditMode]
	[AddComponentMenu("AVPro Video/Media Player", -100)]
	[HelpURL("https://www.renderheads.com/products/avpro-video/")]
	public class MediaPlayer : MonoBehaviour, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public delegate void NADFOEFJBCG(Texture2D LCGOFFJOHCL);

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public class PlatformOptions
		{
			[Cpp2IlInjected.Token(Token = "0x2000011")]
			public enum AEOODFKOHHK
			{
				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				BGRA = 0,
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				YCbCr420_OES = 1,
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				[Obsolete]
				YCbCr420 = 1
			}

			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public enum MBKOMHCDJMJ
			{
				[Cpp2IlInjected.Token(Token = "0x40000AF")]
				NoPreference,
				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				_480p,
				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				_720p,
				[Cpp2IlInjected.Token(Token = "0x40000B2")]
				_1080p,
				[Cpp2IlInjected.Token(Token = "0x40000B3")]
				_1440p,
				[Cpp2IlInjected.Token(Token = "0x40000B4")]
				_2160p,
				[Cpp2IlInjected.Token(Token = "0x40000B5")]
				Custom
			}

			[Cpp2IlInjected.Token(Token = "0x2000013")]
			public enum JPPENGBFOHB
			{
				[Cpp2IlInjected.Token(Token = "0x40000B7")]
				SystemDirect,
				[Cpp2IlInjected.Token(Token = "0x40000B8")]
				Unity,
				[Cpp2IlInjected.Token(Token = "0x40000B9")]
				SystemDirectWithCapture,
				[Cpp2IlInjected.Token(Token = "0x40000BA")]
				FacebookAudio360
			}

			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public enum BAFDNCBMIGG
			{
				[Cpp2IlInjected.Token(Token = "0x40000BC")]
				bps,
				[Cpp2IlInjected.Token(Token = "0x40000BD")]
				Kbps,
				[Cpp2IlInjected.Token(Token = "0x40000BE")]
				Mbps
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public HttpHeaderData httpHeaders;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public KeyAuthData keyAuth;

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x29FD070", Offset = "0x29FBE70", VA = "0x1829FD070", Slot = "4")]
			public virtual string OOCLHNONGLP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xF710E0", Offset = "0xF6FEE0", VA = "0x180F710E0", Slot = "5")]
			public virtual byte[] BFKFMDNMJBP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "6")]
			public virtual bool JGNBIPCDGKJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x29FD090", Offset = "0x29FBE90", VA = "0x1829FD090")]
			public PlatformOptions()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public class OptionsWindows : PlatformOptions, ISerializationCallbackReceiver
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public FLMELIEPEAF.DAKPCCEKBCE videoApi;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public bool useHardwareDecoding;

			[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public bool useRendererSync;

			[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public bool useTextureMips;

			[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public bool use10BitTextures;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public bool hintAlphaChannel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public bool useLowLatency;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public bool useCustomMovParser;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public bool useHapNotchLC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public bool useStereoDetection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public bool useTextTrackSupport;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public bool useFacebookAudio360Support;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public bool useAudioDelay;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public string forceAudioOutputDeviceName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public List<string> preferredFilters;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public FLMELIEPEAF.OBGBGEBPJMN _audioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public PAEMJPLEELJ audio360ChannelMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public bool startWithHighestBitrate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public bool useLowLiveLatency;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			[Range(1f, 16f)]
			public int parallelFrameCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			[Range(1f, 16f)]
			public int prerollFrameCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			[HideInInspector]
			[SerializeField]
			private bool useUnityAudio;

			[Cpp2IlInjected.FieldOffset(Offset = "0x55")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			[SerializeField]
			[HideInInspector]
			private bool enableAudio360;

			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0xD913B0", Offset = "0xD901B0", VA = "0x180D913B0", Slot = "6")]
			public override bool JGNBIPCDGKJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "7")]
			void ISerializationCallbackReceiver.OnBeforeSerialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x29FB9B0", Offset = "0x29FA7B0", VA = "0x1829FB9B0", Slot = "8")]
			void ISerializationCallbackReceiver.OnAfterDeserialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x29FB9E0", Offset = "0x29FA7E0", VA = "0x1829FB9E0")]
			public OptionsWindows()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public class OptionsWindowsUWP : PlatformOptions
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public bool useHardwareDecoding;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public bool useRendererSync;

			[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public bool useTextureMips;

			[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public bool use10BitTextures;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public bool hintOutput10Bit;

			[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public bool useLowLatency;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public JEKKKFNBGNL.BMPJNEFOAKA videoApi;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public JEKKKFNBGNL.OGCHEGAPLLK _audioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public PAEMJPLEELJ audio360ChannelMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public bool startWithHighestBitrate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public bool useLowLiveLatency;

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0xF01590", Offset = "0xF00390", VA = "0x180F01590", Slot = "6")]
			public override bool JGNBIPCDGKJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x29FB990", Offset = "0x29FA790", VA = "0x1829FB990")]
			public OptionsWindowsUWP()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public class OptionsApple : PlatformOptions
		{
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			[Flags]
			public enum BOIIGFBFEAM
			{
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				None = 0,
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				GenerateMipMaps = 1,
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				AllowExternalPlayback = 0x100,
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				PlayWithoutBuffering = 0x200,
				[Cpp2IlInjected.Token(Token = "0x40000F3")]
				UseSinglePlayerItem = 0x400,
				[Cpp2IlInjected.Token(Token = "0x40000F4")]
				ResumeMediaPlaybackAfterAudioSessionRouteChange = 0x10000
			}

			[Cpp2IlInjected.Token(Token = "0x2000019")]
			[Flags]
			public enum ECGILKKMDKB
			{
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				None = 0,
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				PreferredPeakBitRate = 2,
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				PreferredForwardBufferDuration = 4,
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				PlayWithoutBuffering = 8,
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				PreferredMaximumResolution = 0x10,
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				AudioMode = 0x20,
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				ResumeMediaPlaybackAfterAudioSessionRouteChange = 0x40,
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				All = -1
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			private readonly AEOODFKOHHK DefaultTextureFormat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			private readonly BOIIGFBFEAM DefaultFlags;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public AEOODFKOHHK textureFormat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private JPPENGBFOHB _previousAudioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			[SerializeField]
			private JPPENGBFOHB _audioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			[SerializeField]
			private BOIIGFBFEAM _flags;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public float maximumPlaybackRate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private ECGILKKMDKB _changed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			[SerializeField]
			private float _preferredPeakBitRate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			[SerializeField]
			private BAFDNCBMIGG _preferredPeakBitRateUnits;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			[SerializeField]
			private double _preferredForwardBufferDuration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			[SerializeField]
			private MBKOMHCDJMJ _preferredMaximumResolution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			[SerializeField]
			private Vector2Int _customPreferredMaximumResolution;

			[Cpp2IlInjected.Token(Token = "0x17000064")]
			public JPPENGBFOHB audioMode
			{
				[Cpp2IlInjected.Token(Token = "0x6000144")]
				[Cpp2IlInjected.Address(RVA = "0x29FB8E0", Offset = "0x29FA6E0", VA = "0x1829FB8E0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000065")]
			public BOIIGFBFEAM flags
			{
				[Cpp2IlInjected.Token(Token = "0x6000145")]
				[Cpp2IlInjected.Address(RVA = "0x29FB900", Offset = "0x29FA700", VA = "0x1829FB900")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x29FB830", Offset = "0x29FA630", VA = "0x1829FB830")]
			public OptionsApple(AEOODFKOHHK PPNJDGPOFJA, BOIIGFBFEAM PBNCFOKEPJN)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public class OptionsAndroid : PlatformOptions, ISerializationCallbackReceiver
		{
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			[Flags]
			public enum NLHMKHCKIOC
			{
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				None = 0,
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				PreferredPeakBitRate = 2,
				[Cpp2IlInjected.Token(Token = "0x400011D")]
				PreferredMaximumResolution = 4,
				[Cpp2IlInjected.Token(Token = "0x400011E")]
				PreferredCustomResolution = 8,
				[Cpp2IlInjected.Token(Token = "0x400011F")]
				AudioMode = 0x10,
				[Cpp2IlInjected.Token(Token = "0x4000120")]
				GenerateMipmaps = 0x20,
				[Cpp2IlInjected.Token(Token = "0x4000121")]
				All = -1
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private NLHMKHCKIOC _changed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private readonly AEOODFKOHHK DefaultTextureFormat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public AEOODFKOHHK textureFormat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			[SerializeField]
			private bool _generateMipmaps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			private JPPENGBFOHB _previousAudioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			[SerializeField]
			private JPPENGBFOHB _audioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			[SerializeField]
			private MBKOMHCDJMJ _preferredMaximumResolution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			[SerializeField]
			private Vector2Int _customPreferredMaximumResolution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			[SerializeField]
			private float _preferredPeakBitRate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			[SerializeField]
			private BAFDNCBMIGG _preferredPeakBitRateUnits;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public FPLCNBHMGOM.PFMBLEABMND videoApi;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public bool showPosterFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public PAEMJPLEELJ audio360ChannelMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public int audio360LatencyMS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public bool preferSoftwareDecoder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public bool forceRtpTCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5E")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public bool forceEnableMediaCodecAsynchronousQueueing;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			[SerializeField]
			[Tooltip("Byte offset into the file where the media file is located.  This is useful when hiding or packing media files within another file.")]
			public int fileOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public bool startWithHighestBitrate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public int minBufferMs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public int maxBufferMs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public int bufferForPlaybackMs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public int bufferForPlaybackAfterRebufferMs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			[Obsolete("useFastOesPath is deprecated and replaced with TextureFormat")]
			public bool useFastOesPath;

			[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			[Obsolete("audioOutput is deprecated and replaced with audioMode")]
			public int audioOutput;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			[Obsolete("blitTextureFiltering is deprecated and its functionality has been removed")]
			public int blitTextureFiltering;

			[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			[Obsolete("forceEnableMediaCodecAsyncQueueing is deprecated and replaced with forceEnableMediaCodecAsynchronousQueueing")]
			public bool forceEnableMediaCodecAsyncQueueing;

			[Cpp2IlInjected.FieldOffset(Offset = "0x85")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			[HideInInspector]
			[SerializeField]
			private bool enableAudio360;

			[Cpp2IlInjected.Token(Token = "0x17000066")]
			public JPPENGBFOHB audioMode
			{
				[Cpp2IlInjected.Token(Token = "0x6000147")]
				[Cpp2IlInjected.Address(RVA = "0xAD5DB0", Offset = "0xAD4BB0", VA = "0x180AD5DB0")]
				get
				{
					return default(JPPENGBFOHB);
				}
				[Cpp2IlInjected.Token(Token = "0x6000148")]
				[Cpp2IlInjected.Address(RVA = "0x29FB810", Offset = "0x29FA610", VA = "0x1829FB810")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xA98D30", Offset = "0xA97B30", VA = "0x180A98D30", Slot = "6")]
			public override bool JGNBIPCDGKJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "7")]
			void ISerializationCallbackReceiver.OnBeforeSerialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x29FB770", Offset = "0x29FA570", VA = "0x1829FB770", Slot = "8")]
			void ISerializationCallbackReceiver.OnAfterDeserialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x29FB7A0", Offset = "0x29FA5A0", VA = "0x1829FB7A0")]
			public OptionsAndroid()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public class OptionsOpenHarmony : PlatformOptions, ISerializationCallbackReceiver
		{
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			[Flags]
			public enum KPOOKOJICHM
			{
				[Cpp2IlInjected.Token(Token = "0x400012B")]
				None = 0,
				[Cpp2IlInjected.Token(Token = "0x400012C")]
				PreferredPeakBitRate = 2,
				[Cpp2IlInjected.Token(Token = "0x400012D")]
				PreferredMaximumResolution = 4,
				[Cpp2IlInjected.Token(Token = "0x400012E")]
				PreferredCustomResolution = 8,
				[Cpp2IlInjected.Token(Token = "0x400012F")]
				AudioMode = 0x10,
				[Cpp2IlInjected.Token(Token = "0x4000130")]
				GenerateMipmaps = 0x20,
				[Cpp2IlInjected.Token(Token = "0x4000131")]
				All = -1
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			private KPOOKOJICHM _changed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			private readonly AEOODFKOHHK DefaultTextureFormat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public AEOODFKOHHK textureFormat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			[SerializeField]
			private bool _generateMipmapsOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private JPPENGBFOHB _previousAudioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			[SerializeField]
			private JPPENGBFOHB _audioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			[SerializeField]
			private MBKOMHCDJMJ _preferredMaximumResolution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			[SerializeField]
			private Vector2Int _customPreferredMaximumResolution;

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "7")]
			void ISerializationCallbackReceiver.OnBeforeSerialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "8")]
			void ISerializationCallbackReceiver.OnAfterDeserialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x29FB930", Offset = "0x29FA730", VA = "0x1829FB930")]
			public OptionsOpenHarmony()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public class OptionsWebGL : PlatformOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			public enum EJJPIGJNNPD
			{
				[Cpp2IlInjected.Token(Token = "0x4000138")]
				None = 0,
				[Cpp2IlInjected.Token(Token = "0x4000139")]
				PreferredPeakBitRate = 2,
				[Cpp2IlInjected.Token(Token = "0x400013A")]
				PreferredMaximumResolution = 4,
				[Cpp2IlInjected.Token(Token = "0x400013B")]
				PreferredCustomResolution = 8,
				[Cpp2IlInjected.Token(Token = "0x400013C")]
				AudioMode = 16,
				[Cpp2IlInjected.Token(Token = "0x400013D")]
				GenerateMipmaps = 32,
				[Cpp2IlInjected.Token(Token = "0x400013E")]
				All = -1
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			private EJJPIGJNNPD _changed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public APJPCABNIGG.NAEJFMAACGK externalLibrary;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public bool useTextureMips;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			private JPPENGBFOHB _previousAudioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			[SerializeField]
			private JPPENGBFOHB _audioMode;

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "4")]
			public override string OOCLHNONGLP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "5")]
			public override byte[] BFKFMDNMJBP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x29FB980", Offset = "0x29FA780", VA = "0x1829FB980")]
			public OptionsWebGL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private enum ABIHHPKCBAL
		{
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			AbsolutePathOrURL,
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			RelativeToProjectFolder,
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			RelativeToStreamingAssetsFolder,
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			RelativeToDataFolder,
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			RelativeToPersistentDataFolder
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class DNBBJAOONOD : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public MediaPlayer <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			private YieldInstruction <wait>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000067")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000156")]
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000158")]
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
			[DebuggerHidden]
			public DNBBJAOONOD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x29F1A50", Offset = "0x29F0850", VA = "0x1829F1A50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x29F1B50", Offset = "0x29F0950", VA = "0x1829F1B50", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class FPBIJLAAOBI : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public Texture2D target;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public MediaPlayer <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public double timeSeconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public int timeThresholdMs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public bool accurateSeek;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public NADFOEFJBCG callback;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			private Texture2D <result>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			private int <currFc>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			private int <iterations>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private int <maxIterations>5__5;

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600015E")]
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
			[DebuggerHidden]
			public FPBIJLAAOBI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x29F2990", Offset = "0x29F1790", VA = "0x1829F2990", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x29F2EB0", Offset = "0x29F1CB0", VA = "0x1829F2EB0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class NJGEOOMOFJP : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public string url;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			public MediaPlayer <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public MediaPath mediaPath;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private UnityWebRequest <www>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000162")]
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000164")]
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
			[DebuggerHidden]
			public NJGEOOMOFJP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x29FB4C0", Offset = "0x29FA2C0", VA = "0x1829FB4C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x29FB720", Offset = "0x29FA520", VA = "0x1829FB720", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		private JMNOJPHIMOB _mediaSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		private MediaReference _mediaReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		private MediaPath _mediaPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		private MediaHints _fallbackMediaHints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[FormerlySerializedAs("m_AutoOpen")]
		[SerializeField]
		private bool _autoOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[SerializeField]
		[FormerlySerializedAs("m_AutoStart")]
		private bool _autoPlayOnStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[SerializeField]
		[FormerlySerializedAs("m_Loop")]
		private bool _loop;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[FormerlySerializedAs("m_Volume")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _audioVolume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[Range(-1f, 1f)]
		[FormerlySerializedAs("m_Balance")]
		[SerializeField]
		private float _audioBalance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[FormerlySerializedAs("m_Muted")]
		[SerializeField]
		private bool _audioMuted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private AudioSource HOPKCAMEIBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[SerializeField]
		[Range(-4f, 4f)]
		[FormerlySerializedAs("m_PlaybackRate")]
		private float _playbackRate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[SerializeField]
		[FormerlySerializedAs("m_Resample")]
		private bool _useResampler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[SerializeField]
		[FormerlySerializedAs("m_ResampleMode")]
		private CEPMLAGONFB.OKMGENDNIDG _resampleMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Range(3f, 10f)]
		[SerializeField]
		[FormerlySerializedAs("m_ResampleBufferSize")]
		private int _resampleBufferSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private CEPMLAGONFB FJLCDKLIBBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		[FormerlySerializedAs("m_videoMapping")]
		private EFJNCJNHBFH _videoMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[FormerlySerializedAs("m_FilterMode")]
		[SerializeField]
		private FilterMode _textureFilterMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[FormerlySerializedAs("m_WrapMode")]
		[SerializeField]
		private TextureWrapMode _textureWrapMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[SerializeField]
		[Range(0f, 16f)]
		[FormerlySerializedAs("m_AnisoLevel")]
		private int _textureAnisoLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[FormerlySerializedAs("m_LoadSubtitles")]
		[SerializeField]
		private bool _sideloadSubtitles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[SerializeField]
		private MediaPath _subtitlePath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[FormerlySerializedAs("m_AudioHeadTransform")]
		[SerializeField]
		private Transform _audioHeadTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[FormerlySerializedAs("m_AudioFocusEnabled")]
		[SerializeField]
		private bool _audioFocusEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		[FormerlySerializedAs("m_AudioFocusTransform")]
		private Transform _audioFocusTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[Range(40f, 120f)]
		[FormerlySerializedAs("m_AudioFocusWidthDegrees")]
		[SerializeField]
		private float _audioFocusWidthDegrees;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[SerializeField]
		[FormerlySerializedAs("m_AudioFocusOffLevelDB")]
		[Range(-24f, 0f)]
		private float _audioFocusOffLevelDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[SerializeField]
		private HttpHeaderData _httpHeaders;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[SerializeField]
		private KeyAuthData _keyAuth;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[FormerlySerializedAs("m_events")]
		[SerializeField]
		private MediaPlayerEvent _events;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[FormerlySerializedAs("m_eventMask")]
		[SerializeField]
		private int _eventMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		private bool _pauseMediaOnAppPause;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCD")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private bool _playMediaOnAppUnpause;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCE")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[FormerlySerializedAs("m_Persistent")]
		[SerializeField]
		private bool _persistent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[FormerlySerializedAs("m_forceFileFormat")]
		private HBPIEKMDMJL _forceFileFormat;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		protected PIPIIHKKDDP FHCKKFNHHIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private KJEJOPIEFGH PAIGDNMHPOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private NMPLAHIBBEO HPOJNLHFEGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private LHFAOOCJGAN ECDCDMOKKLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private HLHNLCJHBHI FNPONDONIEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private HGHONHMOBLD PEJPIPDIDMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private HGJDEKFCBDC KILEPJJAOOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private NDOFADIJFIN AJLLBECKNIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private FMOEJCHFCHP DMKGDNHGOCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private NMDKKCFFLJB HPOAENPBEID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private LCLFIFJNIDK OGCBLNEMBMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private IDisposable JJKEEICBLBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private bool FFDAGKEPOGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x139")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private bool OFBNFDMPKMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13A")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private bool JLOOKPCJHNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private Coroutine BFMHBONJOCO;

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private static bool OMGJLGLPAPO;

		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private static bool DJIAOIBKKDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private MediaPath HKEIGJDABMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private Coroutine LELDOJIKDDD;

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static Camera DHFOLEFNGGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private bool GBNBBGDBCLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private bool MLAKBEPBCJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15A")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private bool MNKIJOPEFMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15B")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private bool IPJMCPIHOJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private bool BMNJGPLDNJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15D")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private bool KNDMLOMINJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15E")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private bool DPCEFOHJOON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15F")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private bool MGOGEHDFCCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private int NNLNDNEADIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private int OECGKHJJOCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private int IKJHKJMLFBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private bool CMHGGONKJFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16D")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private bool DJMJMDHNECE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[SerializeField]
		private OptionsWindows _optionsWindows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[SerializeField]
		private OptionsApple _options_macOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		private OptionsApple _options_iOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[SerializeField]
		private OptionsApple _options_tvOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		private OptionsApple _options_visionOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		private OptionsAndroid _optionsAndroid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		private OptionsOpenHarmony _optionsOpenHarmony;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[SerializeField]
		private OptionsWindowsUWP _optionsWindowsUWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[SerializeField]
		private OptionsWebGL _optionsWebGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[HideInInspector]
		[SerializeField]
		private string m_VideoPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[HideInInspector]
		[SerializeField]
		private ABIHHPKCBAL m_VideoLocation;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public JMNOJPHIMOB FJEBCHHDAFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xA94B20", Offset = "0xA93920", VA = "0x180A94B20")]
			get
			{
				return default(JMNOJPHIMOB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xA94B80", Offset = "0xA93980", VA = "0x180A94B80")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public MediaReference JLKIKBALEFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MediaPath APOOMDABHKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public MediaHints ALMCIKDPDPC
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x11CE250", Offset = "0x11CD050", VA = "0x1811CE250")]
			get
			{
				return default(MediaHints);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2233290", Offset = "0x2232090", VA = "0x182233290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool AKPBLMHPIAG
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xFBC1B0", Offset = "0xFBAFB0", VA = "0x180FBC1B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xFBC1A0", Offset = "0xFBAFA0", VA = "0x180FBC1A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool HJHDKFCMHLP
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xFBC1C0", Offset = "0xFBAFC0", VA = "0x180FBC1C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xFBC7B0", Offset = "0xFBB5B0", VA = "0x180FBC7B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool DDMOONFKJBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x29FAA50", Offset = "0x29F9850", VA = "0x1829FAA50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x29FAF80", Offset = "0x29F9D80", VA = "0x1829FAF80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public virtual float AJNAKDPMMJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x29FA8E0", Offset = "0x29F96E0", VA = "0x1829FA8E0", Slot = "6")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x29FAF00", Offset = "0x29F9D00", VA = "0x1829FAF00", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float ANHNEIHPOFP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x29FA820", Offset = "0x29F9620", VA = "0x1829FA820")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x29FAE10", Offset = "0x29F9C10", VA = "0x1829FAE10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public virtual bool EDNPPCJJFGB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x29FA880", Offset = "0x29F9680", VA = "0x1829FA880", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x29FAE90", Offset = "0x29F9C90", VA = "0x1829FAE90", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public AudioSource OJDICELOIJF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xA931C0", Offset = "0xA91FC0", VA = "0x180A931C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA93190", Offset = "0xA91F90", VA = "0x180A93190")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float FHKDICNEMFC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x29FAAE0", Offset = "0x29F98E0", VA = "0x1829FAAE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x29FB020", Offset = "0x29F9E20", VA = "0x1829FB020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool ILIJCGHFELP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x1060E60", Offset = "0x105FC60", VA = "0x181060E60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x105E950", Offset = "0x105D750", VA = "0x18105E950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public CEPMLAGONFB.OKMGENDNIDG KFGPECJANDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xD4C240", Offset = "0xD4B040", VA = "0x180D4C240")]
			get
			{
				return default(CEPMLAGONFB.OKMGENDNIDG);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xEFAC30", Offset = "0xEF9A30", VA = "0x180EFAC30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public int MMOOKPMMILM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xFF1040", Offset = "0xFEFE40", VA = "0x180FF1040")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x29FB090", Offset = "0x29F9E90", VA = "0x1829FB090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public CEPMLAGONFB GDMLGDIPEBM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xA931D0", Offset = "0xA91FD0", VA = "0x180A931D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public EFJNCJNHBFH LDABHAOCPJI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xABC1F0", Offset = "0xABAFF0", VA = "0x180ABC1F0")]
			get
			{
				return default(EFJNCJNHBFH);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x15BB3B0", Offset = "0x15BA1B0", VA = "0x1815BB3B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public FilterMode ICENCNDBNNB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x29FAC30", Offset = "0x29F9A30", VA = "0x1829FAC30")]
			get
			{
				return default(FilterMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x29FB110", Offset = "0x29F9F10", VA = "0x1829FB110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public TextureWrapMode BHLAJNNFKIC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x29FAD20", Offset = "0x29F9B20", VA = "0x1829FAD20")]
			get
			{
				return default(TextureWrapMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x29FB180", Offset = "0x29F9F80", VA = "0x1829FB180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public int PBEIDIGOKAC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x29FAB40", Offset = "0x29F9940", VA = "0x1829FAB40")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x29FB0A0", Offset = "0x29F9EA0", VA = "0x1829FB0A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool OKMJNBAFBIL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xD3B1E0", Offset = "0xD39FE0", VA = "0x180D3B1E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xDF0090", Offset = "0xDEEE90", VA = "0x180DF0090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public MediaPath NBMJJOCFOLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xA9EEE0", Offset = "0xA9DCE0", VA = "0x180A9EEE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xA9EDF0", Offset = "0xA9DBF0", VA = "0x180A9EDF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public Transform JILAOAEAPDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xB1E590", Offset = "0xB1D390", VA = "0x180B1E590")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xB633E0", Offset = "0xB621E0", VA = "0x180B633E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool MNNKAGCJDEB
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xFBC190", Offset = "0xFBAF90", VA = "0x180FBC190")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xFBCA80", Offset = "0xFBB880", VA = "0x180FBCA80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public Transform KOMBNFKNHPG
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xB631C0", Offset = "0xB61FC0", VA = "0x180B631C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xB635F0", Offset = "0xB623F0", VA = "0x180B635F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public float IBEFJANDJMN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x1F6A400", Offset = "0x1F69200", VA = "0x181F6A400")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x1F6A560", Offset = "0x1F69360", VA = "0x181F6A560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public float GGPBKNOAECO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x1D2D710", Offset = "0x1D2C510", VA = "0x181D2D710")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x1F6A410", Offset = "0x1F69210", VA = "0x181F6A410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public HttpHeaderData LFDLNJCGKKM
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0xB631D0", Offset = "0xB61FD0", VA = "0x180B631D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xB633B0", Offset = "0xB621B0", VA = "0x180B633B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public KeyAuthData AICGPBBGOOL
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xEB9C60", Offset = "0xEB8A60", VA = "0x180EB9C60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xEB9C70", Offset = "0xEB8A70", VA = "0x180EB9C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public MediaPlayerEvent KCHFBJHAPPF
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x29FA940", Offset = "0x29F9740", VA = "0x1829FA940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public int MJMLHHPLHDD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0xFCE410", Offset = "0xFCD210", VA = "0x180FCE410")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0xFCE0B0", Offset = "0xFCCEB0", VA = "0x180FCE0B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public bool NCBKGFHNBIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x29FAAB0", Offset = "0x29F98B0", VA = "0x1829FAAB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x29FAFF0", Offset = "0x29F9DF0", VA = "0x1829FAFF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool MKKKKGFFGEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x29FAAD0", Offset = "0x29F98D0", VA = "0x1829FAAD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x29FB010", Offset = "0x29F9E10", VA = "0x1829FB010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool FPLGCLCJBGK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x29FAAC0", Offset = "0x29F98C0", VA = "0x1829FAAC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x29FB000", Offset = "0x29F9E00", VA = "0x1829FB000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public HBPIEKMDMJL KPJNKPKBGOB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0xB4DEA0", Offset = "0xB4CCA0", VA = "0x180B4DEA0")]
			get
			{
				return default(HBPIEKMDMJL);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xB4D720", Offset = "0xB4C520", VA = "0x180B4D720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public virtual LHFAOOCJGAN BHOPPAHBFEC
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xB21D60", Offset = "0xB20B60", VA = "0x180B21D60", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public virtual KJEJOPIEFGH BIILPFGCDIE
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xB275F0", Offset = "0xB263F0", VA = "0x180B275F0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public virtual HLHNLCJHBHI JDMOPPJJKDM
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xB2FB40", Offset = "0xB2E940", VA = "0x180B2FB40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public virtual NMPLAHIBBEO GCDNNMJDCIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xB275E0", Offset = "0xB263E0", VA = "0x180B275E0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual HGHONHMOBLD JINFOHJKABK
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xB23880", Offset = "0xB22680", VA = "0x180B23880", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public virtual NDOFADIJFIN AHCMAIJKFOP
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xB25420", Offset = "0xB24220", VA = "0x180B25420", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual FMOEJCHFCHP FECOCJKCKPD
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xAFA620", Offset = "0xAF9420", VA = "0x180AFA620", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual NMDKKCFFLJB PBGEKAEELLO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xC0C380", Offset = "0xC0B180", VA = "0x180C0C380", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual LCLFIFJNIDK BLDBPPBAJGK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xB89730", Offset = "0xB88530", VA = "0x180B89730", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public virtual HGJDEKFCBDC ECMDEPHNFPO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xB25570", Offset = "0xB24370", VA = "0x180B25570", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool NJADJGIAHBE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x2219B20", Offset = "0x2218920", VA = "0x182219B20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public OptionsWindows GPHFFBHFBLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0xC1D100", Offset = "0xC1BF00", VA = "0x180C1D100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public OptionsApple LKODJDCMKGL
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xC0E3F0", Offset = "0xC0D1F0", VA = "0x180C0E3F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public OptionsApple LHHCCOJBMOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0xC08F80", Offset = "0xC07D80", VA = "0x180C08F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public OptionsApple FOENMICFKNK
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0xC17990", Offset = "0xC16790", VA = "0x180C17990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public OptionsApple CPKHFMKKHIK
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0xB34EE0", Offset = "0xB33CE0", VA = "0x180B34EE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public OptionsAndroid CPMFHJPJBFI
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0xC01ED0", Offset = "0xC00CD0", VA = "0x180C01ED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public OptionsOpenHarmony NGBINOEOLCC
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0xB2FDB0", Offset = "0xB2EBB0", VA = "0x180B2FDB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public OptionsWindowsUWP PJMLAPOOADC
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0xB46AC0", Offset = "0xB458C0", VA = "0x180B46AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public OptionsWebGL IPBDDFJGNBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xB6C990", Offset = "0xB6B790", VA = "0x180B6C990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA94B80", Offset = "0xA93980", VA = "0x180A94B80")]
		public void SetMediaSource(JMNOJPHIMOB MKPEOGPFEFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		public void SetMediaReference(MediaReference FPGCHODNKEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		public void SetMediaPath(MediaPath GHADMHNDJBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xA93190", Offset = "0xA91F90", VA = "0x180A93190")]
		public void SetAudioSource(AudioSource FBABCNPBHOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x29F47D0", Offset = "0x29F35D0", VA = "0x1829F47D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x29F5860", Offset = "0x29F4660", VA = "0x1829F5860")]
		protected void FAIFMDMLCJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x29F9C80", Offset = "0x29F8A80", VA = "0x1829F9C80")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x29F8F80", Offset = "0x29F7D80", VA = "0x1829F8F80")]
		public bool OpenMedia(MediaPath GHADMHNDJBK, bool PHBIFBIEFPF = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x29F8E80", Offset = "0x29F7C80", VA = "0x1829F8E80")]
		public bool OpenMedia(KENNAPNBNBB DGEMNDFNJFC, string GHADMHNDJBK, bool PHBIFBIEFPF = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x29F8F30", Offset = "0x29F7D30", VA = "0x1829F8F30")]
		public bool OpenMedia(MediaReference GKJFMEPLMJE, bool PHBIFBIEFPF = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x29F8F00", Offset = "0x29F7D00", VA = "0x1829F8F00")]
		public bool OpenMedia(bool PHBIFBIEFPF = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x29F6D10", Offset = "0x29F5B10", VA = "0x1829F6D10")]
		private bool IEPLGMNOMDA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x29F5F40", Offset = "0x29F4D40", VA = "0x1829F5F40")]
		private void FDACIBHKDNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x29F8300", Offset = "0x29F7100", VA = "0x1829F8300")]
		private void NPGGCGJFFBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x29F49A0", Offset = "0x29F37A0", VA = "0x1829F49A0")]
		public void CloseMedia()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x29F9280", Offset = "0x29F8080", VA = "0x1829F9280", Slot = "20")]
		public virtual void Play()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x29F9200", Offset = "0x29F8000", VA = "0x1829F9200", Slot = "21")]
		public virtual void Pause()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x29F9D60", Offset = "0x29F8B60", VA = "0x1829F9D60")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x29F9310", Offset = "0x29F8110", VA = "0x1829F9310")]
		public void Rewind(bool JNLFJBENNFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x29F9AB0", Offset = "0x29F88B0", VA = "0x1829F9AB0")]
		public void SeekToLiveTime(double IBOFMHFOKKF = 0.0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x29F9EC0", Offset = "0x29F8CC0", VA = "0x1829F9EC0", Slot = "22")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x29F7AE0", Offset = "0x29F68E0", VA = "0x1829F7AE0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x29F8420", Offset = "0x29F7220", VA = "0x1829F8420")]
		private void OGOCFPBLCIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x29F8D40", Offset = "0x29F7B40", VA = "0x1829F8D40")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x29F8C80", Offset = "0x29F7A80", VA = "0x1829F8C80")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x29F8B00", Offset = "0x29F7900", VA = "0x1829F8B00", Slot = "23")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x29F6290", Offset = "0x29F5090", VA = "0x1829F6290")]
		public void ForceDispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x29F78C0", Offset = "0x29F66C0", VA = "0x1829F78C0")]
		private static void KOEABGPJKLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x29F88D0", Offset = "0x29F76D0", VA = "0x1829F88D0")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x29F64B0", Offset = "0x29F52B0", VA = "0x1829F64B0")]
		protected void HEINBFGCGLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x29F7A90", Offset = "0x29F6890", VA = "0x1829F7A90")]
		private void LNKBPLKBLHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x29F77C0", Offset = "0x29F65C0", VA = "0x1829F77C0")]
		[IteratorStateMachine(typeof(DNBBJAOONOD))]
		private IEnumerator JFIIIAJPBGP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00")]
		public static AGCLFFMNHJA GetPlatform()
		{
			return default(AGCLFFMNHJA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xC1D100", Offset = "0xC1BF00", VA = "0x180C1D100")]
		public PlatformOptions GetCurrentPlatformOptions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x29F4630", Offset = "0x29F3430", VA = "0x1829F4630")]
		private string ADEDKNBNCNK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00")]
		private long ICFAELMBODK()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x29F7550", Offset = "0x29F6350", VA = "0x1829F7550")]
		private string ILELPIAAHJG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x29F7A20", Offset = "0x29F6820", VA = "0x1829F7A20")]
		private string LAPJIDEPLDN(string GLIMJFLPLJE, KENNAPNBNBB CFCMELLMDMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x29F6BC0", Offset = "0x29F59C0", VA = "0x1829F6BC0")]
		private static PIPIIHKKDDP HPBBGOJPHNA(OptionsWindows PMEODJMCJOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x29F7870", Offset = "0x29F6670", VA = "0x1829F7870")]
		private static PIPIIHKKDDP KCBHEOPLNDF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x29F4B10", Offset = "0x29F3910", VA = "0x1829F4B10", Slot = "24")]
		public virtual PIPIIHKKDDP CreateMediaPlayer()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x29F7E70", Offset = "0x29F6C70", VA = "0x1829F7E70")]
		private void MGKFDIHKABG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x29F6360", Offset = "0x29F5160", VA = "0x1829F6360")]
		private void GIJPGALCGAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x29F8520", Offset = "0x29F7320", VA = "0x1829F8520")]
		private void OHBJAHCKOGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0")]
		public bool IsUsingAndroidOESPath()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0")]
		public bool IsUsingYCbCr()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x29F97C0", Offset = "0x29F85C0", VA = "0x1829F97C0")]
		[ContextMenu("Save Frame To PNG")]
		public void SaveFrameToPng()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x29F9390", Offset = "0x29F8190", VA = "0x1829F9390")]
		[ContextMenu("Save Frame To EXR")]
		public void SaveFrameToExr()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0")]
		private void OnApplicationFocus(bool ACHDPBFPMKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0")]
		private void OnApplicationPause(bool GKMKPKFNAHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x29F7840", Offset = "0x29F6640", VA = "0x1829F7840")]
		private void JGMGCHCDHBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x29F61C0", Offset = "0x29F4FC0", VA = "0x1829F61C0")]
		private void FKEOCIGPBDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x29F8270", Offset = "0x29F7070", VA = "0x1829F8270")]
		private void NHLANBLMHHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x29F8690", Offset = "0x29F7490", VA = "0x1829F8690")]
		private void OPJKMLCAOLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x29F7600", Offset = "0x29F6400", VA = "0x1829F7600")]
		private void JCIGILAMLGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x29F6B90", Offset = "0x29F5990", VA = "0x1829F6B90")]
		protected bool HLDCGAFCIBN(MediaPlayerEvent.BALPDIFPDHA HFNHABBHAHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x29F4840", Offset = "0x29F3640", VA = "0x1829F4840")]
		private bool BIIEPECAJAI(MediaPlayerEvent.BALPDIFPDHA HFNHABBHAHJ, bool PMLJOLKBKDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x29F6570", Offset = "0x29F5370", VA = "0x1829F6570")]
		private bool HEMNDOGBABE(MediaPlayerEvent.BALPDIFPDHA FIJBBOMCDKN, bool PMLJOLKBKDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x29F80B0", Offset = "0x29F6EB0", VA = "0x1829F80B0")]
		private bool MKANBBMGJEK(int EGBGJHLMEGJ, float KEOMMGKCHGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x29F7C20", Offset = "0x29F6A20", VA = "0x1829F7C20")]
		private static Camera MGGBEAINLHP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x29F48D0", Offset = "0x29F36D0", VA = "0x1829F48D0")]
		[IteratorStateMachine(typeof(FPBIJLAAOBI))]
		private IEnumerator CCLGJKNNOPH(Texture2D BNIHAACOHPG, NADFOEFJBCG LBJMJKFNAPH, double JACNDAAIEHD = -1.0, bool NAICLJPKPHM = true, int KEOMMGKCHGH = 1000, int GCGPKCBJBJF = 100)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x29F5600", Offset = "0x29F4400", VA = "0x1829F5600")]
		public void ExtractFrameAsync(Texture2D BNIHAACOHPG, NADFOEFJBCG LBJMJKFNAPH, double JACNDAAIEHD = -1.0, bool NAICLJPKPHM = true, int KEOMMGKCHGH = 1000, int GCGPKCBJBJF = 100)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x29F56E0", Offset = "0x29F44E0", VA = "0x1829F56E0")]
		public Texture2D ExtractFrame(Texture2D BNIHAACOHPG, double JACNDAAIEHD = -1.0, bool NAICLJPKPHM = true, int KEOMMGKCHGH = 1000, int GCGPKCBJBJF = 100)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x29F8FB0", Offset = "0x29F7DB0", VA = "0x1829F8FB0")]
		private Texture PCIFMCPAPFC(double JACNDAAIEHD = -1.0, bool NAICLJPKPHM = true, int KEOMMGKCHGH = 1000, int GCGPKCBJBJF = 100)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x29F8DC0", Offset = "0x29F7BC0", VA = "0x1829F8DC0")]
		public bool OpenMediaFromBuffer(byte[] ALPKAMHLIAF, bool PHBIFBIEFPF = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x29F9BC0", Offset = "0x29F89C0", VA = "0x1829F9BC0")]
		public bool StartOpenChunkedMediaFromBuffer(ulong MCJGICKIGFF, bool PHBIFBIEFPF = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x29F46B0", Offset = "0x29F34B0", VA = "0x1829F46B0")]
		public bool AddChunkToVideoBuffer(byte[] FLFGHPEEGLF, ulong IBOFMHFOKKF, ulong NOCIMGAIKLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x29F5580", Offset = "0x29F4380", VA = "0x1829F5580")]
		public bool EndOpenChunkedVideoFromBuffer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x29F4F80", Offset = "0x29F3D80", VA = "0x1829F4F80")]
		private bool EGHIANGDCDO(byte[] ALPKAMHLIAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x29F7340", Offset = "0x29F6140", VA = "0x1829F7340")]
		private bool IJHBFLLBGAP(ulong MCJGICKIGFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x29F46B0", Offset = "0x29F34B0", VA = "0x1829F46B0")]
		private bool BGBEPHMLNKG(byte[] FLFGHPEEGLF, ulong IBOFMHFOKKF, ulong NOCIMGAIKLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x29F5580", Offset = "0x29F4380", VA = "0x1829F5580")]
		private bool GNAPAJLLNFB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x29F51A0", Offset = "0x29F3FA0", VA = "0x1829F51A0")]
		public bool EnableSubtitles(MediaPath NJDMEPLCGOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x29F6AE0", Offset = "0x29F58E0", VA = "0x1829F6AE0")]
		[IteratorStateMachine(typeof(NJGEOOMOFJP))]
		private IEnumerator HGFNPJIMHNF(string MOGHIIFJJCA, MediaPath NJDMEPLCGOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x29F4EA0", Offset = "0x29F3CA0", VA = "0x1829F4EA0")]
		public void DisableSubtitles()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x29F9DC0", Offset = "0x29F8BC0", VA = "0x1829F9DC0", Slot = "5")]
		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x29FA2F0", Offset = "0x29F90F0", VA = "0x1829FA2F0")]
		public MediaPlayer()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class MediaPlaylist
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public class MediaItem
		{
			[Cpp2IlInjected.Token(Token = "0x2000026")]
			public enum IFPJHIFDMKO
			{
				[Cpp2IlInjected.Token(Token = "0x400016A")]
				AVProVideoPlayer
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			[SerializeField]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			[SerializeField]
			public IFPJHIFDMKO sourceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			[SerializeField]
			public MediaPath mediaPath;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			[SerializeField]
			public Texture2D texture;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			[SerializeField]
			public float textureDuration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			[SerializeField]
			public bool loop;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			[SerializeField]
			public PlaylistMediaPlayer.DDNFDADMIGI startMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			[SerializeField]
			public PlaylistMediaPlayer.MFPDKCMGGEO progressMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			[SerializeField]
			public float progressTimeSeconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			[SerializeField]
			public bool isOverrideTransition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			[SerializeField]
			public PlaylistMediaPlayer.GBJAAAKFDOK overrideTransition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			[SerializeField]
			public float overrideTransitionDuration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			[SerializeField]
			public IAMMGBEBDAI.KDJFOFCLBKA overrideTransitionEasing;

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x29F42F0", Offset = "0x29F30F0", VA = "0x1829F42F0")]
			public MediaItem()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[SerializeField]
		private List<MediaItem> _items;

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public List<MediaItem> Items
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x29FB1F0", Offset = "0x29F9FF0", VA = "0x1829FB1F0")]
		public bool IIENDAICIAC(int JJJJBEGKNIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x29FB250", Offset = "0x29FA050", VA = "0x1829FB250")]
		public MediaPlaylist()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[AddComponentMenu("AVPro Video/Playlist Media Player", -80)]
	[HelpURL("https://www.renderheads.com/products/avpro-video/")]
	public class PlaylistMediaPlayer : MediaPlayer, NMPLAHIBBEO
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public enum GBJAAAKFDOK
		{
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			Fade,
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			Black,
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			White,
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			Transparent,
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			Horiz,
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			Vert,
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			Diag,
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			MirrorH,
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			MirrorV,
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			MirrorD,
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			ScrollV,
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			ScrollH,
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			Circle,
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			Diamond,
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			Blinds,
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			Arrows,
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			SlideH,
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			SlideV,
			[Cpp2IlInjected.Token(Token = "0x400019C")]
			Zoom,
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			RectV,
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			Random
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public enum GMOFKFPONPP
		{
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			Loop
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public enum DDNFDADMIGI
		{
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			Immediate,
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			Manual
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public enum MFPDKCMGGEO
		{
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			OnFinish,
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			BeforeFinish,
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			Manual
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private sealed class MGLBMOCJDFG : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			public PlaylistMediaPlayer <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
			[DebuggerHidden]
			public MGLBMOCJDFG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x29F3C20", Offset = "0x29F2A20", VA = "0x1829F3C20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x29F42A0", Offset = "0x29F30A0", VA = "0x1829F42A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[SerializeField]
		private Shader _transitionShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		[SerializeField]
		private MediaPlayer _playerA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[SerializeField]
		private MediaPlayer _playerB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[SerializeField]
		private bool _playlistAutoProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E1")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[Tooltip("Close the video on the other MediaPlayer when it is not visible any more. This is useful for freeing up memory and GPU decoding resources.")]
		[SerializeField]
		private bool _autoCloseVideo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		[SerializeField]
		private GMOFKFPONPP _playlistLoopMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		[SerializeField]
		private MediaPlaylist _playlist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		[SerializeField]
		[Tooltip("Pause the previously playing video. This is useful for systems that will struggle to play 2 videos at once")]
		private bool _pausePreviousOnTransition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F4")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		[SerializeField]
		private GBJAAAKFDOK _defaultTransition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[SerializeField]
		private float _defaultTransitionDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[SerializeField]
		private IAMMGBEBDAI.KDJFOFCLBKA _defaultTransitionEasing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _playlistAudioVolume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[SerializeField]
		private bool _playlistAudioMuted;

		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private static readonly FNCEDKJJNKJ CBICICNCMMO;

		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private static readonly FNCEDKJJNKJ NGLMDLAGHCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x205")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private bool LNOPKFHKKOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private int NADIFGNJKMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private MediaPlayer GFDLFMMEJBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private Material MMGJMIDGJHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private GBJAAAKFDOK PECAGEPLBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private string IMPFFJHDEIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private float LGOCEOHHGCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x234")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private IAMMGBEBDAI.KDJFOFCLBKA OJGNHMGFOAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private float MDBIPHIFDGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private Func<float, float> BBBLPDHLIHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private RenderTexture PPJBBOJDALA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private MediaPlaylist.MediaItem DCHLJGKHFJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private MediaPlaylist.MediaItem IDAJDAENMLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private WaitForEndOfFrame IEMAKNCPPKD;

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public MediaPlayer PGJJMGHCJFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x29FFE00", Offset = "0x29FEC00", VA = "0x1829FFE00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public MediaPlayer BGLPNEBNCCK
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xBC1140", Offset = "0xBBFF40", VA = "0x180BC1140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public MediaPlaylist LEOKPMGHMJD
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xB89720", Offset = "0xB88520", VA = "0x180B89720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public int MAMGOHDJACL
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x26CBBE0", Offset = "0x26CA9E0", VA = "0x1826CBBE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public MediaPlaylist.MediaItem OLBMLJFMDKD
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x29FFF50", Offset = "0x29FED50", VA = "0x1829FFF50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public GBJAAAKFDOK FBFILILLHDE
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xD8F900", Offset = "0xD8E700", VA = "0x180D8F900")]
			get
			{
				return default(GBJAAAKFDOK);
			}
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x15E5E60", Offset = "0x15E4C60", VA = "0x1815E5E60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public float FNHHMLNFOJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x1F022A0", Offset = "0x1F010A0", VA = "0x181F022A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x217AAD0", Offset = "0x21798D0", VA = "0x18217AAD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public IAMMGBEBDAI.KDJFOFCLBKA HAEHEAGIBIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0xB46C80", Offset = "0xB45A80", VA = "0x180B46C80")]
			get
			{
				return default(IAMMGBEBDAI.KDJFOFCLBKA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xB44FB0", Offset = "0xB43DB0", VA = "0x180B44FB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public bool IDMGKAMOAEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x15FBE40", Offset = "0x15FAC40", VA = "0x1815FBE40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x15FEA20", Offset = "0x15FD820", VA = "0x1815FEA20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public GMOFKFPONPP ADKKCKHBNID
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x29FFF40", Offset = "0x29FED40", VA = "0x1829FFF40")]
			get
			{
				return default(GMOFKFPONPP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x2A001D0", Offset = "0x29FEFD0", VA = "0x182A001D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public bool EJMBIKMPKGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xC0EB30", Offset = "0xC0D930", VA = "0x180C0EB30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xC091C0", Offset = "0xC07FC0", VA = "0x180C091C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public override LHFAOOCJGAN BHOPPAHBFEC
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x29FFEA0", Offset = "0x29FECA0", VA = "0x1829FFEA0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public override KJEJOPIEFGH BIILPFGCDIE
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x29FFD60", Offset = "0x29FEB60", VA = "0x1829FFD60", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public override NMPLAHIBBEO GCDNNMJDCIM
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xE08C40", Offset = "0xE07A40", VA = "0x180E08C40", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public override float AJNAKDPMMJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x217A4F0", Offset = "0x21792F0", VA = "0x18217A4F0", Slot = "6")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x2A000E0", Offset = "0x29FEEE0", VA = "0x182A000E0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public override bool EDNPPCJJFGB
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x29FFD50", Offset = "0x29FEB50", VA = "0x1829FFD50", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x2A00010", Offset = "0x29FEE10", VA = "0x182A00010", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x29FF1B0", Offset = "0x29FDFB0", VA = "0x1829FF1B0", Slot = "20")]
		public override void Play()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x29FF0A0", Offset = "0x29FDEA0", VA = "0x1829FF0A0", Slot = "21")]
		public override void Pause()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x29FE410", Offset = "0x29FD210", VA = "0x1829FE410")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x29FD910", Offset = "0x29FC710", VA = "0x1829FD910")]
		[IteratorStateMachine(typeof(MGLBMOCJDFG))]
		private IEnumerator GCCKDINELPN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x29FD2D0", Offset = "0x29FC0D0", VA = "0x1829FD2D0")]
		private Texture BCEKILCFGKP(int JJJJBEGKNIN = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x29FD4B0", Offset = "0x29FC2B0", VA = "0x1829FD4B0")]
		private Texture DDJPLDHGIGA(int JJJJBEGKNIN = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x29FD140", Offset = "0x29FBF40", VA = "0x1829FD140")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x29FE8C0", Offset = "0x29FD6C0", VA = "0x1829FE8C0", Slot = "23")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x29FF370", Offset = "0x29FE170", VA = "0x1829FF370")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x29FEB40", Offset = "0x29FD940", VA = "0x1829FEB40")]
		public void OnMediaPlayerEvent(MediaPlayer JOIFCBAGHAJ, MediaPlayerEvent.BALPDIFPDHA HFNHABBHAHJ, DLLKIBIDOAK KAFEFLDOPOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x29FF2C0", Offset = "0x29FE0C0", VA = "0x1829FF2C0")]
		public bool PrevItem()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x29FE840", Offset = "0x29FD640", VA = "0x1829FE840")]
		public bool NextItem()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x29FD3E0", Offset = "0x29FC1E0", VA = "0x1829FD3E0")]
		public bool CanJumpToItem(int JJJJBEGKNIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x29FE420", Offset = "0x29FD220", VA = "0x1829FE420")]
		public bool JumpToItem(int JJJJBEGKNIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x29FED00", Offset = "0x29FDB00", VA = "0x1829FED00")]
		public void OpenVideoFile(MediaPlaylist.MediaItem LDAFDBKEKIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x29FE820", Offset = "0x29FD620", VA = "0x1829FE820")]
		private bool MMOGCMGJODK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x29FD5A0", Offset = "0x29FC3A0", VA = "0x1829FD5A0")]
		private void DKKAEENLAGB(GBJAAAKFDOK GLIMIDMDHDG, float DFOOIFEDPMI, IAMMGBEBDAI.KDJFOFCLBKA KMPDHJMKCEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x29FF5A0", Offset = "0x29FE3A0", VA = "0x1829FF5A0", Slot = "22")]
		protected override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x29FE1F0", Offset = "0x29FCFF0", VA = "0x1829FE1F0", Slot = "26")]
		public Texture GetTexture(int JJJJBEGKNIN = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x29FDC60", Offset = "0x29FCA60", VA = "0x1829FDC60", Slot = "25")]
		public int GetTextureCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x29FDD00", Offset = "0x29FCB00", VA = "0x1829FDD00", Slot = "27")]
		public int GetTextureFrameCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x29FF500", Offset = "0x29FE300", VA = "0x1829FF500", Slot = "28")]
		public bool SupportsTextureFrameCount()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x29FE020", Offset = "0x29FCE20", VA = "0x1829FE020", Slot = "29")]
		public long GetTextureTimeStamp()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x29FDED0", Offset = "0x29FCCD0", VA = "0x1829FDED0", Slot = "30")]
		public float GetTexturePixelAspectRatio()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x29FF2D0", Offset = "0x29FE0D0", VA = "0x1829FF2D0", Slot = "31")]
		public bool RequiresVerticalFlip()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x29FE2E0", Offset = "0x29FD0E0", VA = "0x1829FE2E0", Slot = "35")]
		public Matrix4x4 GetYpCbCrTransform()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x29FDF80", Offset = "0x29FCD80", VA = "0x1829FDF80", Slot = "32")]
		public AABCGFAHNKC GetTextureStereoPacking()
		{
			return default(AABCGFAHNKC);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x29FE150", Offset = "0x29FCF50", VA = "0x1829FE150", Slot = "33")]
		public MLNFFEOLPKN GetTextureTransparency()
		{
			return default(MLNFFEOLPKN);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x29FDBC0", Offset = "0x29FC9C0", VA = "0x1829FDBC0", Slot = "34")]
		public EMDBPPLBOLG GetTextureAlphaPacking()
		{
			return default(EMDBPPLBOLG);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x29FD990", Offset = "0x29FC790", VA = "0x1829FD990", Slot = "36")]
		public float[] GetAffineTransform()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x29FDDA0", Offset = "0x29FCBA0", VA = "0x1829FDDA0", Slot = "37")]
		public Matrix4x4 GetTextureMatrix()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x29FDA80", Offset = "0x29FC880", VA = "0x1829FDA80", Slot = "38")]
		public RenderTextureFormat GetCompatibleRenderTextureFormat(MAIDPACCNCF PMEODJMCJOL, int PIPPAANOGKJ)
		{
			return default(RenderTextureFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x29FE560", Offset = "0x29FD360", VA = "0x1829FE560")]
		private static string KBCGCODMMBI(GBJAAAKFDOK GLIMIDMDHDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x29FFBA0", Offset = "0x29FE9A0", VA = "0x1829FFBA0")]
		public PlaylistMediaPlayer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[HelpURL("https://www.renderheads.com/products/avpro-video/")]
	[AddComponentMenu("AVPro Video/Resolve To RenderTexture", 330)]
	public class ResolveToRenderTexture : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[SerializeField]
		private MediaPlayer _mediaPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[SerializeField]
		private VideoResolveOptions _options;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[SerializeField]
		private PGIPGAFFCGK.GAOPMDJCONL _resolveFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[SerializeField]
		private RenderTexture _externalTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private Material DEANJNMJADH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private bool NCJDMPDHPPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x69")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private bool JDCMCDFNBEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6A")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private bool MOBKBIOIFJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private RenderTexture DHLDGCEDIEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private int NKKHBGEEJEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private Material IONIBMFFDEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private int MJGOJLJJJEF;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public MediaPlayer BHJPCDLONOB
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x2A001E0", Offset = "0x29FEFE0", VA = "0x182A001E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public VideoResolveOptions KBKKELBLAHK
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x2A00CE0", Offset = "0x29FFAE0", VA = "0x182A00CE0")]
			get
			{
				return default(VideoResolveOptions);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x2A00D00", Offset = "0x29FFB00", VA = "0x182A00D00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public RenderTexture HKPHJNEOBJK
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xA931F0", Offset = "0xA91FF0", VA = "0x180A931F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xA931A0", Offset = "0xA91FA0", VA = "0x180A931A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public RenderTexture BLBLFHBEDJE
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x2A00C60", Offset = "0x29FFA60", VA = "0x182A00C60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2A00A90", Offset = "0x29FF890", VA = "0x182A00A90")]
		public void SetMaterialDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x2A001E0", Offset = "0x29FEFE0", VA = "0x182A001E0")]
		private void LDMPGMLNNCH(MediaPlayer JOIFCBAGHAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x2A00AA0", Offset = "0x29FF8A0", VA = "0x182A00AA0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2A00280", Offset = "0x29FF080", VA = "0x182A00280")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x2A003B0", Offset = "0x29FF1B0", VA = "0x182A003B0")]
		public void Resolve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x2A00330", Offset = "0x29FF130", VA = "0x182A00330")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2A00290", Offset = "0x29FF090", VA = "0x182A00290")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2A00C10", Offset = "0x29FFA10", VA = "0x182A00C10")]
		public ResolveToRenderTexture()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[HelpURL("https://www.renderheads.com/products/avpro-video/")]
	[AddComponentMenu("AVPro Video/Update Multi-Pass Stereo", 320)]
	public class UpdateMultiPassStereo : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[Header("Stereo camera")]
		[SerializeField]
		private Camera _camera;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private static readonly FNCEDKJJNKJ OMDLHEMJNDH;

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private static readonly FNCEDKJJNKJ EMHEGJICMPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private Camera DGFGDBLNKAJ;

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Camera FFKNMKCLCGF
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2A01160", Offset = "0x29FFF60", VA = "0x182A01160")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2A01610", Offset = "0x2A00410", VA = "0x182A01610")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2A00D20", Offset = "0x29FFB20", VA = "0x182A00D20")]
		private void AMDKKLJFHHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2A01200", Offset = "0x2A00000", VA = "0x182A01200")]
		private static bool LKIOJFFDJGP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2A01230", Offset = "0x2A00030", VA = "0x182A01230")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA969E0", Offset = "0xA957E0", VA = "0x180A969E0")]
		public UpdateMultiPassStereo()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public abstract class ApplyToBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[Header("Media Source")]
		[SerializeField]
		protected MediaPlayer _media;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[Header("Display")]
		[SerializeField]
		[Space(8f)]
		private bool _automaticStereoPacking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[SerializeField]
		private AABCGFAHNKC _overrideStereoPacking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[SerializeField]
		private bool _stereoRedGreenTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		protected bool IMMCADINOKP;

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public MediaPlayer JDMOPPJJKDM
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x29EC3B0", Offset = "0x29EB1B0", VA = "0x1829EC3B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public bool FIIBJNKBOPP
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xA98D20", Offset = "0xA97B20", VA = "0x180A98D20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x29EC390", Offset = "0x29EB190", VA = "0x1829EC390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public AABCGFAHNKC CLIKEFAICOH
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xC38810", Offset = "0xC37610", VA = "0x180C38810")]
			get
			{
				return default(AABCGFAHNKC);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x29EC3A0", Offset = "0x29EB1A0", VA = "0x1829EC3A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public bool PICKICHDPDF
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xC38800", Offset = "0xC37600", VA = "0x180C38800")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x29EC3C0", Offset = "0x29EB1C0", VA = "0x1829EC3C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x29EC0B0", Offset = "0x29EAEB0", VA = "0x1829EC0B0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x29EC140", Offset = "0x29EAF40", VA = "0x1829EC140")]
		private void LDMPGMLNNCH(MediaPlayer GLMBLPAKFLM, bool PPPGPLMAHNI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x29EC100", Offset = "0x29EAF00", VA = "0x1829EC100")]
		private void HCDNFBKOBGE(MediaPlayer IABBFMOBIIL, MediaPlayerEvent.BALPDIFPDHA FIJBBOMCDKN, DLLKIBIDOAK KAFEFLDOPOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x29EC0C0", Offset = "0x29EAEC0", VA = "0x1829EC0C0")]
		public void ForceUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x29EC350", Offset = "0x29EB150", VA = "0x1829EC350")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x29EC300", Offset = "0x29EB100", VA = "0x1829EC300", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x1A68B70", Offset = "0x1A67970", VA = "0x181A68B70", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x29EC2F0", Offset = "0x29EB0F0", VA = "0x1829EC2F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "6")]
		protected virtual void POBPADLKBOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "7")]
		protected virtual void JLDPNMHAAGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void Apply();

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x18451C0", Offset = "0x1843FC0", VA = "0x1818451C0")]
		protected ApplyToBase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class HHMOGGFDNFF
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	protected class IIJJDEFHOEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public HashSet<AudioOutput> GJKFFKIPDNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public float[] DAIGEMFAHOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public bool AHGCHCFEONM;

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public IIJJDEFHOEH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private static HHMOGGFDNFF IBKIAAFDJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private Dictionary<int, IIJJDEFHOEH> MOECNAEPNPN;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public static HHMOGGFDNFF MOIOIMEFPHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x29F3A90", Offset = "0x29F2890", VA = "0x1829F3A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x29F3B90", Offset = "0x29F2990", VA = "0x1829F3B90")]
	private HHMOGGFDNFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x29F37C0", Offset = "0x29F25C0", VA = "0x1829F37C0")]
	public void DDALAMPEHFF(int EOENKEDMJDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x29F38C0", Offset = "0x29F26C0", VA = "0x1829F38C0")]
	public void DEMLBLIHLDE(int EOENKEDMJDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x29F2F00", Offset = "0x29F1D00", VA = "0x1829F2F00")]
	public void BIJCNOFGPCA(AudioOutput NPNIMCALGMH, MediaPlayer JOIFCBAGHAJ, int EOENKEDMJDC, float[] PJLPHHNGJFC, int GBNAFNMOGOE, int OAPKBDOHHPA, AudioOutput.LDMLFEBJEDA KPEPACEKNCE, bool NFPOBDBMHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x29F3940", Offset = "0x29F2740", VA = "0x1829F3940")]
	private void LEMLGOLMLBO(float[] PJLPHHNGJFC, int PPNMKFHAJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x29F3980", Offset = "0x29F2780", VA = "0x1829F3980")]
	private bool OCKEPPHAFEK(MediaPlayer GLMBLPAKFLM, float[] PJLPHHNGJFC, int KMCPCDKHDCK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[DefaultMember("Item")]
public abstract class PIPIIHKKDDP : HLHNLCJHBHI, KJEJOPIEFGH, LHFAOOCJGAN, HGJDEKFCBDC, NMPLAHIBBEO, HGHONHMOBLD, NDOFADIJFIN, FMOEJCHFCHP, NMDKKCFFLJB, LCLFIFJNIDK, IEnumerable, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	protected string KNINBNMDAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	protected DLLKIBIDOAK NMENBFPICDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	protected FilterMode FCAPEOOFAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	protected TextureWrapMode APKFIFNMLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	protected int CIPNGKBNHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	protected MediaHints NJKNDMNJKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	protected CMJGFCMNHKM PCBKFKOMOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	protected CMJGFCMNHKM JACPKEKOPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private float HBPLJLGJOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private int FPKJMFFLNLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private float FHMAAGLAAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private float EOOIDAFDAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private int DGBANMJPDAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private int MDFEFKGNNOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	protected List<EAEBBCMKIMC> CDPKHNHBPNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	protected EAEBBCMKIMC PFLNLFGJJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	protected AGEEOOMJNOM GEKAHKNAFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	protected MHADJKOPADC DAHEIHNANIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	protected AJIOFAOJEKD PNCNMPDDFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	protected PNLMGJOCNGA CNMLKCNBPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	protected CGJCHMANIHO GPAOKIBOBKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	protected EPPOCLBAPDO[] ICHKOILHKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	protected List<ALBFPNCIJIA> CNPPMFDHAIF;

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x29FCCE0", Offset = "0x29FBAE0", VA = "0x1829FCCE0")]
	public PIPIIHKKDDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "82")]
	public abstract string GDKGLLEKLDO();

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "83")]
	public abstract string NFBPNIDLGAF();

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "84")]
	public abstract bool JOCHMHJBIGK(string GHADMHNDJBK, long IBOFMHFOKKF, string GDEHNJIJHCC, MediaHints ALELCMHDHAM, int JMJCBIMCCHC = 0, bool FKACMOLDPFO = false);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "85")]
	public virtual bool MBPCLKLBCGM(byte[] ALPKAMHLIAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "86")]
	public virtual bool JJPEKPGEBGH(ulong MCJGICKIGFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "87")]
	public virtual bool JCPEKCBOPJI(byte[] FLFGHPEEGLF, ulong IBOFMHFOKKF, ulong MCJGICKIGFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "88")]
	public virtual bool CLDCNNDMOIN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x29FC690", Offset = "0x29FB490", VA = "0x1829FC690", Slot = "89")]
	public virtual void JIKEGLOGNLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "90")]
	public abstract void LHKOCACDLAM(bool DFDEHFEDCLP);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "91")]
	public abstract bool DMFKDCAGEOP();

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "92")]
	public abstract bool EKEBMLKJHOO();

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "93")]
	public abstract bool JPNCONIJFFA();

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "94")]
	public abstract void EIOMMCKMPJC();

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "95")]
	public abstract void BDCEPMMAHDG();

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "96")]
	public abstract void PMKEICCMJHA();

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x29FCBE0", Offset = "0x29FB9E0", VA = "0x1829FCBE0", Slot = "97")]
	public virtual void OMFMMEKAIEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "98")]
	public abstract void BOPNDEIGLFI(double GJEDFMHCPFI);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "99")]
	public abstract void GECNJGBBJJB(double GJEDFMHCPFI);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "100")]
	public abstract double LLJMAOJMLFO();

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "101")]
	public abstract float CCGBCKDPHNG();

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "102")]
	public abstract void NLMGBEGOKLM(float GAFEGGNEMAE);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "103")]
	public abstract double FNEDCKLMGLM();

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "104")]
	public abstract int PJCEHKOHKJM();

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "105")]
	public abstract int BIDJNENGKJL();

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "106")]
	public abstract float GNDDNLOAJGE();

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "107")]
	public abstract bool ACFDNLNJFJN();

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "108")]
	public abstract bool AMPMEKMCPCC();

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "109")]
	public abstract bool ACDJCHIIOOE();

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "110")]
	public abstract bool IADKMMNPFPB();

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "111")]
	public abstract bool LCMDBILBFDM();

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "112")]
	public abstract bool JEALKMODOFM();

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "113")]
	public abstract bool NPAILJJMPJO();

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "114")]
	public virtual bool DMLFIGLOPIO(Camera ELMGFHEHLEP, int EMEJCBKDPCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0xC21FD0", Offset = "0xC20DD0", VA = "0x180C21FD0", Slot = "115")]
	public virtual int GetTextureCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "116")]
	public abstract Texture GetTexture(int JJJJBEGKNIN = 0);

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "117")]
	public abstract int GetTextureFrameCount();

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660", Slot = "118")]
	public virtual bool SupportsTextureFrameCount()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x29FC540", Offset = "0x29FB340", VA = "0x1829FC540", Slot = "119")]
	public virtual long GetTextureTimeStamp()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "120")]
	public abstract bool RequiresVerticalFlip();

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0xC387F0", Offset = "0xC375F0", VA = "0x180C387F0", Slot = "121")]
	public virtual float GetTexturePixelAspectRatio()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x29FC550", Offset = "0x29FB350", VA = "0x1829FC550", Slot = "122")]
	public virtual Matrix4x4 GetYpCbCrTransform()
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x29FC240", Offset = "0x29FB040", VA = "0x1829FC240", Slot = "123")]
	public virtual float[] GetAffineTransform()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x29FC5B0", Offset = "0x29FB3B0", VA = "0x1829FC5B0", Slot = "124")]
	public virtual float[] HDMIJLKIBJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x29FC380", Offset = "0x29FB180", VA = "0x1829FC380", Slot = "125")]
	public virtual Matrix4x4 GetTextureMatrix()
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0xF12F90", Offset = "0xF11D90", VA = "0x180F12F90", Slot = "126")]
	public virtual RenderTextureFormat GetCompatibleRenderTextureFormat(MAIDPACCNCF PMEODJMCJOL, int PIPPAANOGKJ)
	{
		return default(RenderTextureFormat);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x29FC510", Offset = "0x29FB310", VA = "0x1829FC510", Slot = "70")]
	public AABCGFAHNKC GetTextureStereoPacking()
	{
		return default(AABCGFAHNKC);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "127")]
	internal abstract AABCGFAHNKC IIAEMBFLHIL();

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0xA94B30", Offset = "0xA93930", VA = "0x180A94B30", Slot = "128")]
	public virtual MLNFFEOLPKN GetTextureTransparency()
	{
		return default(MLNFFEOLPKN);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x29FC340", Offset = "0x29FB140", VA = "0x1829FC340", Slot = "72")]
	public EMDBPPLBOLG GetTextureAlphaPacking()
	{
		return default(EMDBPPLBOLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "129")]
	public abstract void MJPINGMBIEP(bool OKMCFMAKENH);

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "130")]
	public abstract bool LNAKKGGBEJN();

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "131")]
	public abstract void OENEOLIAHGD(float ILEBLACHCBE);

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "132")]
	public virtual void GLNKILGCALN(float LOILCHOIMMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "133")]
	public abstract float DHBENLHDCNE();

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0xAE5B60", Offset = "0xAE4960", VA = "0x180AE5B60", Slot = "134")]
	public virtual float GCEDIKFGPOB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0xAE5B70", Offset = "0xAE4970", VA = "0x180AE5B70", Slot = "135")]
	public virtual int FKIPHPANEFM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "136")]
	public virtual int OCKEPPHAFEK(float[] PJLPHHNGJFC, int ECFJNCANNAJ, int KMCPCDKHDCK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "137")]
	public virtual void AIJIMKFFMLM(bool DKMHBOMDKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "138")]
	public virtual void FFAAKMMPCOH(Quaternion CGMILECIDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "139")]
	public virtual void GGJHGNBLMNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "140")]
	public virtual void FODCENPENMP(PAEMJPLEELJ FDDPCOLMFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "141")]
	public virtual void MABOALOJICM(bool GDNKPNFMPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "142")]
	public virtual void MEEJAAEMDNF(float MNABCDABJNN, float BNECOIIDDBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "143")]
	public virtual void OODOLFAFCJB(Quaternion CGMILECIDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "144")]
	public virtual void LHAADKDFBJG(string OBGCPOCPFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "145")]
	public virtual void EGAPFNMGFNM(byte[] OPGJHIOADCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(Slot = "146")]
	public abstract void AFCEEABIEMI();

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "147")]
	public virtual void DHAAJBADCBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "148")]
	public abstract void BMMCDIAKPMG();

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(Slot = "149")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "150")]
	public virtual void AMMOEGHOJHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x29FC680", Offset = "0x29FB480", VA = "0x1829FC680", Slot = "40")]
	public DLLKIBIDOAK ILCGGLDIEEF()
	{
		return default(DLLKIBIDOAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660", Slot = "151")]
	public virtual bool MBDAJGABKLP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97960", VA = "0x180A98B60", Slot = "39")]
	public CMJGFCMNHKM BFPACJMOCDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x29FC220", Offset = "0x29FB020", VA = "0x1829FC220", Slot = "42")]
	public void GNMFPHAKFEH([Out] FilterMode IPLIBKINCBA, [Out] TextureWrapMode DOOOCPNDHFN, [Out] int LIFJAFCBOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x29FBEF0", Offset = "0x29FACF0", VA = "0x1829FBEF0", Slot = "41")]
	public void EJCPFENBKFC(FilterMode IPLIBKINCBA = FilterMode.Bilinear, TextureWrapMode DOOOCPNDHFN = TextureWrapMode.Clamp, int LIFJAFCBOMF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x29FBC30", Offset = "0x29FAA30", VA = "0x1829FBC30", Slot = "152")]
	protected virtual void DCELPFDOMPM(Texture JDNNGPGPIOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x29FC730", Offset = "0x29FB530", VA = "0x1829FC730")]
	protected void JMJNCEENOEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x29FBAB0", Offset = "0x29FA8B0", VA = "0x1829FBAB0")]
	protected bool BCIPDPMDMPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x29FBF80", Offset = "0x29FAD80", VA = "0x1829FBF80", Slot = "153")]
	public virtual bool FHKIMBMELFA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x29FC7D0", Offset = "0x29FB5D0", VA = "0x1829FC7D0", Slot = "77")]
	public bool KLGGDLDJIEP(string KANAIIDGHCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x29FBCD0", Offset = "0x29FAAD0", VA = "0x1829FBCD0", Slot = "154")]
	public virtual void DFOMCGPELOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x29FCC00", Offset = "0x29FBA00", VA = "0x1829FCC00", Slot = "155")]
	public virtual int PAPFEALMACA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x29FC840", Offset = "0x29FB640", VA = "0x1829FC840", Slot = "156")]
	public virtual string LJGLLAPEBIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "157")]
	public virtual void MDBAGKDBGJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x29FCC20", Offset = "0x29FBA20", VA = "0x1829FCC20", Slot = "158")]
	public int PBBEJJEPFFA(float CAPIBINFEJC = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x29FBE10", Offset = "0x29FAC10", VA = "0x1829FBE10")]
	protected bool EEEGOAODEPH(bool PPPGPLMAHNI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "159")]
	internal abstract bool IPIALJCHCJK();

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "160")]
	internal abstract string ALIJFKNMHLM();

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(Slot = "161")]
	internal abstract bool PHOCDFLJFKH(DLOGHDOADKK HFCGJADJPNC);

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(Slot = "162")]
	internal abstract int PDHIEFPHIFA(DLOGHDOADKK HFCGJADJPNC);

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "163")]
	internal abstract JFNIFAPOMPO KKLPLALMPFF(DLOGHDOADKK HFCGJADJPNC, int FCFCDKODNHK, bool OOKPIIMIAEE);

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x29FC8B0", Offset = "0x29FB6B0", VA = "0x1829FC8B0")]
	private void NOHEBBMLGND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x29FC5D0", Offset = "0x29FB3D0", VA = "0x1829FC5D0")]
	protected void IFGHCJMMEHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x29FCA10", Offset = "0x29FB810", VA = "0x1829FCA10")]
	private void OIIAICEAEHG(EPPOCLBAPDO OKDBCONHNNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x29FC2B0", Offset = "0x29FB0B0", VA = "0x1829FC2B0", Slot = "164")]
	public virtual IEnumerator GetEnumerator()
	{
		return null;
	}
}
namespace RenderHeads.Media.AVProVideo
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class MediaPlayerEvent : UnityEvent<MediaPlayer, MediaPlayerEvent.BALPDIFPDHA, DLLKIBIDOAK>
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public enum BALPDIFPDHA
		{
			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			MetaDataReady = 0,
			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			ReadyToPlay = 1,
			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			Started = 2,
			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			FirstFrameReady = 3,
			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			FinishedPlaying = 4,
			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			Closing = 5,
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			Error = 6,
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			SubtitleChange = 7,
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			Stalled = 8,
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			Unstalled = 9,
			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			ResolutionChanged = 10,
			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			StartedSeeking = 11,
			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			FinishedSeeking = 12,
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			StartedBuffering = 13,
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			FinishedBuffering = 14,
			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			PropertiesChanged = 15,
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			PlaylistItemChanged = 16,
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			PlaylistFinished = 17,
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			TextTracksChanged = 18,
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			Paused = 19,
			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			Unpaused = 20,
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			TextCueChanged = 7
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private List<UnityAction<MediaPlayer, BALPDIFPDHA, DLLKIBIDOAK>> _listeners;

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x29F4440", Offset = "0x29F3240", VA = "0x1829F4440")]
		public bool FNOBLBCAHNC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x29F44A0", Offset = "0x29F32A0", VA = "0x1829F44A0")]
		public void ICJJGOLINDN(UnityAction<MediaPlayer, BALPDIFPDHA, DLLKIBIDOAK> PBBFIIKAOEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x29F43A0", Offset = "0x29F31A0", VA = "0x1829F43A0")]
		public void DLICPHBOHEO(UnityAction<MediaPlayer, BALPDIFPDHA, DLLKIBIDOAK> PBBFIIKAOEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x29F4590", Offset = "0x29F3390", VA = "0x1829F4590")]
		public MediaPlayerEvent()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class NJGCLNDEFPC
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static Matrix4x4 IMBDLABIPCD;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static Matrix4x4 LKPAJICEAPL;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static Matrix4x4 BDIGKCDHMCM;

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x2A14B60", Offset = "0x2A13960", VA = "0x182A14B60")]
	public static string MGGPIIFBHGL(KENNAPNBNBB HFACKDKFNFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x2A14790", Offset = "0x2A13590", VA = "0x182A14790")]
	public static string GEBACFJOOII(string GHADMHNDJBK, KENNAPNBNBB HFACKDKFNFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x2A14630", Offset = "0x2A13430", VA = "0x182A14630")]
	public static string GBLIBEAIDLO(DLLKIBIDOAK OIBEBELDBPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x2A14C60", Offset = "0x2A13A60", VA = "0x182A14C60")]
	public static void PNFPEMPPIPE(string JDFCBBCKOGJ, [Optional] UnityEngine.Object KKBNGKDBMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x2A14760", Offset = "0x2A13560", VA = "0x182A14760")]
	public static int GDIOGKMHHNG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x2A13FD0", Offset = "0x2A12DD0", VA = "0x182A13FD0")]
	public static int BNBGJNFAALJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x2A14950", Offset = "0x2A13750", VA = "0x182A14950")]
	public static BMHOCCNNMLI LEDALPIMCNM(float[] DDCPKPIHIOM)
	{
		return default(BMHOCCNNMLI);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x2A14210", Offset = "0x2A13010", VA = "0x182A14210")]
	public static int DANCLKOCBNB(double KBODPDIPNAF, float GGDLALIMJJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x2A13EF0", Offset = "0x2A12CF0", VA = "0x182A13EF0")]
	private static extern int BHLJHIABGOC(string KMDAAFIBHEC, StringBuilder CHEJOLBENIE, int BBOMMBDHFHG);

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x2A14060", Offset = "0x2A12E60", VA = "0x182A14060")]
	internal static string CPJLKPOGMHH(string GHADMHNDJBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x2A14290", Offset = "0x2A13090", VA = "0x182A14290")]
	public static Texture2D EHGKBCDIDFO(Texture DFNDNJPCLAB, bool OHLEOPNCPCE, BMHOCCNNMLI GDNHBNOODLC, [Optional] Texture2D IJMODPINCHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface HLHNLCJHBHI
{
	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MDBAGKDBGJA();

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AFCEEABIEMI();

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AMMOEGHOJHH();

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DHAAJBADCBJ();

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BMMCDIAKPMG();
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface HGHONHMOBLD
{
	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KLGGDLDJIEP(string KANAIIDGHCH);

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int PAPFEALMACA();

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string LJGLLAPEBIL();
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface KJEJOPIEFGH
{
	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JOCHMHJBIGK(string GHADMHNDJBK, long IBOFMHFOKKF, string GDEHNJIJHCC, MediaHints EPGPPCHCGPA, int JMJCBIMCCHC = 0, bool FKACMOLDPFO = false);

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MBPCLKLBCGM(byte[] ALPKAMHLIAF);

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JJPEKPGEBGH(ulong MCJGICKIGFF);

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JCPEKCBOPJI(byte[] FLFGHPEEGLF, ulong IBOFMHFOKKF, ulong MCJGICKIGFF);

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CLDCNNDMOIN();

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JIKEGLOGNLN();

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LHKOCACDLAM(bool FMNFBBFJOPI);

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool DMFKDCAGEOP();

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool EKEBMLKJHOO();

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool JPNCONIJFFA();

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool IADKMMNPFPB();

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool ACDJCHIIOOE();

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool LCMDBILBFDM();

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool JEALKMODOFM();

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool NPAILJJMPJO();

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void EIOMMCKMPJC();

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BDCEPMMAHDG();

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void PMKEICCMJHA();

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void OMFMMEKAIEA();

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void BOPNDEIGLFI(double GJEDFMHCPFI);

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void GECNJGBBJJB(double GJEDFMHCPFI);

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(Slot = "21")]
	double LLJMAOJMLFO();

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(Slot = "22")]
	float CCGBCKDPHNG();

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void NLMGBEGOKLM(float GAFEGGNEMAE);

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void MJPINGMBIEP(bool ACDFLBADDLI);

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool LNAKKGGBEJN();

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void OENEOLIAHGD(float ILEBLACHCBE);

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void GLNKILGCALN(float LOILCHOIMMD);

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "28")]
	float DHBENLHDCNE();

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float GCEDIKFGPOB();

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(Slot = "30")]
	CMJGFCMNHKM BFPACJMOCDH();

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DLLKIBIDOAK ILCGGLDIEEF();

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void EJCPFENBKFC(FilterMode IPLIBKINCBA = FilterMode.Bilinear, TextureWrapMode DOOOCPNDHFN = TextureWrapMode.Clamp, int LIFJAFCBOMF = 1);

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void GNMFPHAKFEH([Out] FilterMode IPLIBKINCBA, [Out] TextureWrapMode DOOOCPNDHFN, [Out] int LIFJAFCBOMF);

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(Slot = "34")]
	int OCKEPPHAFEK(float[] ALPKAMHLIAF, int BLJFLHLLHAB, int KMCPCDKHDCK);

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(Slot = "35")]
	int FKIPHPANEFM();

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void AIJIMKFFMLM(bool DKMHBOMDKHC);

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void FODCENPENMP(PAEMJPLEELJ FDDPCOLMFAN);

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void FFAAKMMPCOH(Quaternion CGMILECIDLP);

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void GGJHGNBLMNO();

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void MABOALOJICM(bool GDNKPNFMPCI);

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void MEEJAAEMDNF(float MNABCDABJNN, float BNECOIIDDBO);

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void OODOLFAFCJB(Quaternion CGMILECIDLP);

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(Slot = "43")]
	bool DMLFIGLOPIO(Camera ELMGFHEHLEP, int EMEJCBKDPCN);

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void LHAADKDFBJG(string OBGCPOCPFIJ);

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(Slot = "45")]
	void EGAPFNMGFNM(byte[] OPGJHIOADCK);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface LHFAOOCJGAN
{
	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(Slot = "0")]
	double FNEDCKLMGLM();

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int PJCEHKOHKJM();

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int BIDJNENGKJL();

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float GNDDNLOAJGE();

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AMPMEKMCPCC();

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MBDAJGABKLP();

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FHKIMBMELFA();

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float[] HDMIJLKIBJL();
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface HGJDEKFCBDC
{
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface NMPLAHIBBEO
{
	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int GetTextureCount();

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Texture GetTexture(int JJJJBEGKNIN = 0);

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int GetTextureFrameCount();

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool SupportsTextureFrameCount();

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(Slot = "4")]
	long GetTextureTimeStamp();

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(Slot = "5")]
	float GetTexturePixelAspectRatio();

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool RequiresVerticalFlip();

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AABCGFAHNKC GetTextureStereoPacking();

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(Slot = "8")]
	MLNFFEOLPKN GetTextureTransparency();

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(Slot = "9")]
	EMDBPPLBOLG GetTextureAlphaPacking();

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Matrix4x4 GetYpCbCrTransform();

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float[] GetAffineTransform();

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Matrix4x4 GetTextureMatrix();

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	RenderTextureFormat GetCompatibleRenderTextureFormat(MAIDPACCNCF PMEODJMCJOL = MAIDPACCNCF.Default, int PIPPAANOGKJ = 0);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[Flags]
public enum MAIDPACCNCF
{
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	ForResolve = 1,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	RequiresAlpha = 2
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum AGCLFFMNHJA
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	Windows = 0,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	macOS = 1,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	iOS = 2,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	tvOS = 3,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	visionOS = 4,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	Android = 5,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	WindowsUWP = 6,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	WebGL = 7,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	OpenHarmony = 8,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	Count = 8,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	Unknown = 100
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public enum JMNOJPHIMOB
{
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	Reference,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	Path
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public enum KENNAPNBNBB
{
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	AbsolutePathOrURL,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	RelativeToProjectFolder,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	RelativeToStreamingAssetsFolder,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	RelativeToDataFolder,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	RelativeToPersistentDataFolder
}
namespace RenderHeads.Media.AVProVideo
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class MediaPath
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		[SerializeField]
		private KENNAPNBNBB _pathType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		[SerializeField]
		private string _path;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public KENNAPNBNBB PathType
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
			get
			{
				return default(KENNAPNBNBB);
			}
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public string Path
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x2A13DE0", Offset = "0x2A12BE0", VA = "0x182A13DE0")]
		public MediaPath()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x2A13D50", Offset = "0x2A12B50", VA = "0x182A13D50")]
		public MediaPath(MediaPath OKBLFANOAAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x2A13E60", Offset = "0x2A12C60", VA = "0x182A13E60")]
		public MediaPath(string GHADMHNDJBK, KENNAPNBNBB DGEMNDFNJFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x2A139A0", Offset = "0x2A127A0", VA = "0x182A139A0")]
		public string NFNKLOFLCKO()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x2A138F0", Offset = "0x2A126F0", VA = "0x182A138F0")]
		public static MediaPath MIDAFINGFAP(string BEBMEOPHIHO)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x2A138D0", Offset = "0x2A126D0", VA = "0x182A138D0")]
		public static bool IKIADGFKNFC(MediaPath GENJGFGGINA, MediaPath KMNEIBIPMKI)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x2A13840", Offset = "0x2A12640", VA = "0x182A13840")]
		public static bool GFAFFKCBFKA(MediaPath GENJGFGGINA, MediaPath KMNEIBIPMKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x2A13740", Offset = "0x2A12540", VA = "0x182A13740", Slot = "0")]
		public override bool Equals(object ALGAKMGCCLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x2A13880", Offset = "0x2A12680", VA = "0x182A13880", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public enum AABCGFAHNKC
{
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	TopBottom = 1,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	LeftRight = 2,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	CustomUV = 3,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	TwoTextures = 4,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	Unknown = 10
}
namespace RenderHeads.Media.AVProVideo
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct MediaHints
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public MLNFFEOLPKN transparency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public EMDBPPLBOLG alphaPacking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public AABCGFAHNKC stereoPacking;

		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private static MediaHints defaultHints;

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public static MediaHints Default
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x2A136F0", Offset = "0x2A124F0", VA = "0x182A136F0")]
			get
			{
				return default(MediaHints);
			}
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct VideoResolveOptions
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public enum BGMHCPKGPGA
		{
			[Cpp2IlInjected.Token(Token = "0x4000228")]
			NoScaling,
			[Cpp2IlInjected.Token(Token = "0x4000229")]
			FitVertically,
			[Cpp2IlInjected.Token(Token = "0x400022A")]
			FitHorizontally,
			[Cpp2IlInjected.Token(Token = "0x400022B")]
			FitInside,
			[Cpp2IlInjected.Token(Token = "0x400022C")]
			FitOutside,
			[Cpp2IlInjected.Token(Token = "0x400022D")]
			Stretch
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		[SerializeField]
		public bool applyHSBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		[Range(0f, 1f)]
		[SerializeField]
		public float hue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		[Range(0f, 1f)]
		[SerializeField]
		public float saturation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		[Range(0f, 1f)]
		[SerializeField]
		public float brightness;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		[Range(0f, 1f)]
		[SerializeField]
		public float contrast;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		[SerializeField]
		[Range(0.0001f, 10f)]
		public float gamma;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		[SerializeField]
		public Color tint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		[SerializeField]
		public bool generateMipmaps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		[SerializeField]
		public BGMHCPKGPGA aspectRatio;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x2A17AC0", Offset = "0x2A168C0", VA = "0x182A17AC0")]
		public bool BEKHNNNFFAO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x2A17A90", Offset = "0x2A16890", VA = "0x182A17A90")]
		internal void ACFPIHHDHEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x2A17B20", Offset = "0x2A16920", VA = "0x182A17B20")]
		public static VideoResolveOptions INIHOJCCLPM()
		{
			return default(VideoResolveOptions);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public enum MLNFFEOLPKN
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	Opaque,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	Transparent
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public enum BIHFCBEIMJA
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	Both,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	Left,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	Right
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public enum EMDBPPLBOLG
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	TopBottom,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	LeftRight
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public enum DLLKIBIDOAK
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	LoadFailed = 100,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	DecodeFailed = 200
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public enum BMHOCCNNMLI
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	Landscape,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	LandscapeFlipped,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	Portrait,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	PortraitFlipped,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	PortraitHorizontalMirror
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public enum EFJNCJNHBFH
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	EquiRectangular360,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	EquiRectangular180,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	CubeMap3x2
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public enum HBPIEKMDMJL
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	HLS,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	DASH,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	SmoothStreaming
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class FLMELIEPEAF
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public enum DAKPCCEKBCE
	{
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		MediaFoundation,
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		DirectShow,
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		WinRT
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public enum OBGBGEBPJMN
	{
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		System,
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		Unity,
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		FacebookAudio360,
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		None
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class JEKKKFNBGNL
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public enum BMPJNEFOAKA
	{
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		MediaFoundation,
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		WinRT
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public enum OGCHEGAPLLK
	{
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		System,
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		Unity,
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		FacebookAudio360,
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		None
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class FPLCNBHMGOM
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public enum PFMBLEABMND
	{
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		MediaPlayer = 1,
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		ExoPlayer
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class APJPCABNIGG
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public enum NAEJFMAACGK
	{
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		DashJs,
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		HlsJs,
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		Custom
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public enum PAEMJPLEELJ
{
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	TBE_8_2,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	TBE_8,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	TBE_6_2,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	TBE_6,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	TBE_4_2,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	TBE_4,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	TBE_8_PAIR0,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	TBE_8_PAIR1,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	TBE_8_PAIR2,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	TBE_8_PAIR3,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	TBE_CHANNEL0,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	TBE_CHANNEL1,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	TBE_CHANNEL2,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	TBE_CHANNEL3,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	TBE_CHANNEL4,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	TBE_CHANNEL5,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	TBE_CHANNEL6,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	TBE_CHANNEL7,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	HEADLOCKED_STEREO,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	HEADLOCKED_CHANNEL0,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	HEADLOCKED_CHANNEL1,
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	AMBIX_4,
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	AMBIX_4_2,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	AMBIX_9,
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	AMBIX_9_2,
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	AMBIX_16,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	AMBIX_16_2,
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	MONO,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	STEREO,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	UNKNOWN,
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	INVALID
}
[StructLayout((LayoutKind)0, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct JHOPPHAADOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public double FNCCBDMLILN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public double DFOOIFEDPMI;
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[DefaultMember("Item")]
public class CMJGFCMNHKM : IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	internal JHOPPHAADOC[] FHBACGPHGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	internal double ALLHIOAOBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	internal double KHDBLEHICBI;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public int KFMIHBFLPLI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x290F670", Offset = "0x290E470", VA = "0x18290F670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public double DNGFAJPJNLA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x2A0A340", Offset = "0x2A09140", VA = "0x182A0A340")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public double DHFJKANMBHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x2A0A330", Offset = "0x2A09130", VA = "0x182A0A330")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public double GKGDODHFGNB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x2A0A4C0", Offset = "0x2A092C0", VA = "0x182A0A4C0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x2A0A700", Offset = "0x2A09500", VA = "0x182A0A700")]
	internal CMJGFCMNHKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x2A0A350", Offset = "0x2A09150", VA = "0x182A0A350", Slot = "4")]
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x2A0A4D0", Offset = "0x2A092D0", VA = "0x182A0A4D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x2A0A370", Offset = "0x2A09170", VA = "0x182A0A370")]
	internal void HCEDLLBIDIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class AGEEOOMJNOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private int HCGIFCNEOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private long HNFILCKDPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private PIPIIHKKDDP HLFMBAMIOAE;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public int HOMOLMAGGFC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public int EAMMCJCLKHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xAE1B10", Offset = "0xAE0910", VA = "0x180AE1B10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0xB8DFD0", Offset = "0xB8CDD0", VA = "0x180B8DFD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public int HDKGLCJLIAL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xA94B20", Offset = "0xA93920", VA = "0x180A94B20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xA94B80", Offset = "0xA93980", VA = "0x180A94B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private float PHLMIEMPPIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xEB8B40", Offset = "0xEB7940", VA = "0x180EB8B40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private string PGMJKHLHNPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private int ENLFOGCCJLA
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xA94B30", Offset = "0xA93930", VA = "0x180A94B30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0xA94B60", Offset = "0xA93960", VA = "0x180A94B60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private int JPPMOABDOEP
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xAE48E0", Offset = "0xAE36E0", VA = "0x180AE48E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x168AAA0", Offset = "0x16898A0", VA = "0x18168AAA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool CEHMBCPPIMC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0xAC2580", Offset = "0xAC1380", VA = "0x180AC2580")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x2A023F0", Offset = "0x2A011F0", VA = "0x182A023F0")]
	public void KNFHOLHMALL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x2A02040", Offset = "0x2A00E40", VA = "0x182A02040")]
	internal void DGOFKDGOMGH(PIPIIHKKDDP GLMBLPAKFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x2A016F0", Offset = "0x2A004F0", VA = "0x182A016F0")]
	internal void AFCEEABIEMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660")]
	private static bool LGGMBBJJHII()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public AGEEOOMJNOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public sealed class LPJGOMEONLA : PIPIIHKKDDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private bool KJNDKGOMOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private bool LNOPKFHKKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private double CHILPOEBCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private float JHJCLJMMMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private float EMMNNPNEMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	private bool MKFFEEHBCIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private int FNMHCHEMJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private int DKEDCDKCHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	private Texture2D KAOCINECGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	private Texture2D LDADIGLCOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	private Texture2D PHACAGIGDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	private float PGFFOECDAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	private int MALCGIFDJKI;

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x2A133A0", Offset = "0x2A121A0", VA = "0x182A133A0", Slot = "82")]
	public override string GDKGLLEKLDO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x2A13660", Offset = "0x2A12460", VA = "0x182A13660", Slot = "83")]
	public override string NFBPNIDLGAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x2A13460", Offset = "0x2A12260", VA = "0x182A13460", Slot = "84")]
	public override bool JOCHMHJBIGK(string GHADMHNDJBK, long IBOFMHFOKKF, string IIMKFOJELGI, MediaHints ALELCMHDHAM, int JMJCBIMCCHC = 0, bool FKACMOLDPFO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x2A13420", Offset = "0x2A12220", VA = "0x182A13420", Slot = "89")]
	public override void JIKEGLOGNLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0xD4E100", Offset = "0xD4CF00", VA = "0x180D4E100", Slot = "90")]
	public override void LHKOCACDLAM(bool FMNFBBFJOPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x10B1A80", Offset = "0x10B0880", VA = "0x1810B1A80", Slot = "91")]
	public override bool DMFKDCAGEOP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660", Slot = "92")]
	public override bool EKEBMLKJHOO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660", Slot = "93")]
	public override bool JPNCONIJFFA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "107")]
	public override bool ACFDNLNJFJN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "108")]
	public override bool AMPMEKMCPCC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x2A13370", Offset = "0x2A12170", VA = "0x182A13370", Slot = "94")]
	public override void EIOMMCKMPJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x2A13350", Offset = "0x2A12150", VA = "0x182A13350", Slot = "95")]
	public override void BDCEPMMAHDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x2A13680", Offset = "0x2A12480", VA = "0x182A13680", Slot = "96")]
	public override void PMKEICCMJHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "109")]
	public override bool ACDJCHIIOOE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0xB635E0", Offset = "0xB623E0", VA = "0x180B635E0", Slot = "110")]
	public override bool IADKMMNPFPB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0xB63400", Offset = "0xB62200", VA = "0x180B63400", Slot = "111")]
	public override bool LCMDBILBFDM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x2A133D0", Offset = "0x2A121D0", VA = "0x182A133D0", Slot = "112")]
	public override bool JEALKMODOFM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "113")]
	public override bool NPAILJJMPJO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x2A13390", Offset = "0x2A12190", VA = "0x182A13390", Slot = "103")]
	public override double FNEDCKLMGLM()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x10B1430", Offset = "0x10B0230", VA = "0x1810B1430", Slot = "104")]
	public override int PJCEHKOHKJM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0xFCE410", Offset = "0xFCD210", VA = "0x180FCE410", Slot = "105")]
	public override int BIDJNENGKJL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0xB23990", Offset = "0xB22790", VA = "0x180B23990", Slot = "116")]
	public override Texture GetTexture(int JJJJBEGKNIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x1753320", Offset = "0x1752120", VA = "0x181753320", Slot = "117")]
	public override int GetTextureFrameCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0xF19000", Offset = "0xF17E00", VA = "0x180F19000", Slot = "127")]
	internal override AABCGFAHNKC IIAEMBFLHIL()
	{
		return default(AABCGFAHNKC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "120")]
	public override bool RequiresVerticalFlip()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x2A13360", Offset = "0x2A12160", VA = "0x182A13360", Slot = "98")]
	public override void BOPNDEIGLFI(double GJEDFMHCPFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x2A13360", Offset = "0x2A12160", VA = "0x182A13360", Slot = "99")]
	public override void GECNJGBBJJB(double GJEDFMHCPFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x2A13650", Offset = "0x2A12450", VA = "0x182A13650", Slot = "100")]
	public override double LLJMAOJMLFO()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x168EA20", Offset = "0x168D820", VA = "0x18168EA20", Slot = "102")]
	public override void NLMGBEGOKLM(float GAFEGGNEMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x168E9C0", Offset = "0x168D7C0", VA = "0x18168E9C0", Slot = "101")]
	public override float CCGBCKDPHNG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "129")]
	public override void MJPINGMBIEP(bool OKMCFMAKENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660", Slot = "130")]
	public override bool LNAKKGGBEJN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x1C9B2A0", Offset = "0x1C9A0A0", VA = "0x181C9B2A0", Slot = "131")]
	public override void OENEOLIAHGD(float ILEBLACHCBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x1C9D920", Offset = "0x1C9C720", VA = "0x181C9D920", Slot = "133")]
	public override float DHBENLHDCNE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0xAE5B60", Offset = "0xAE4960", VA = "0x180AE5B60", Slot = "106")]
	public override float GNDDNLOAJGE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x2A131D0", Offset = "0x2A11FD0", VA = "0x182A131D0", Slot = "146")]
	public override void AFCEEABIEMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "148")]
	public override void BMMCDIAKPMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "149")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "161")]
	internal override bool PHOCDFLJFKH(DLOGHDOADKK HFCGJADJPNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "162")]
	internal override int PDHIEFPHIFA(DLOGHDOADKK HFCGJADJPNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "163")]
	internal override JFNIFAPOMPO KKLPLALMPFF(DLOGHDOADKK HFCGJADJPNC, int JJJJBEGKNIN, bool OOKPIIMIAEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "159")]
	internal override bool IPIALJCHCJK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "160")]
	internal override string ALIJFKNMHLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x2A13690", Offset = "0x2A12490", VA = "0x182A13690")]
	public LPJGOMEONLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class PCOFLNCPBFL
{
	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public string IGGPKICNHFN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public string BIKAJNDLCFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public byte[] DFEOEJLBHOH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x2A15070", Offset = "0x2A13E70", VA = "0x182A15070")]
	public PCOFLNCPBFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x2A14FF0", Offset = "0x2A13DF0", VA = "0x182A14FF0")]
	public void FMJEOCFJDAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class BFEALDKDAMG : PIPIIHKKDDP
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	private struct DLIPNLPPMEE
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		internal enum JACLMGFMCMO
		{
			[Cpp2IlInjected.Token(Token = "0x40002D3")]
			Seekable,
			[Cpp2IlInjected.Token(Token = "0x40002D4")]
			Buffered
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public enum HNEKGAJGNBN
		{
			[Cpp2IlInjected.Token(Token = "0x40002D6")]
			BeginRender,
			[Cpp2IlInjected.Token(Token = "0x40002D7")]
			UpdateAllTextures,
			[Cpp2IlInjected.Token(Token = "0x40002D8")]
			FreeTextures,
			[Cpp2IlInjected.Token(Token = "0x40002D9")]
			WaitForNewFrame
		}

		[StructLayout((LayoutKind)0, Pack = 1, Size = 28)]
		[Cpp2IlInjected.Token(Token = "0x2000060")]
		public struct EDJLCNNOJBG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002DA")]
			public string MOGHIIFJJCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002DB")]
			public string OBGCPOCPFIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002DC")]
			public IntPtr GOHCCLMFAGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			public int IBCHOLGKBJC;
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x2A0ADE0", Offset = "0x2A09BE0", VA = "0x182A0ADE0")]
		public static extern bool AEJCMNIFEPN(IntPtr HNKFODIAFKO, DLOGHDOADKK HFCGJADJPNC);

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x2A0B1F0", Offset = "0x2A09FF0", VA = "0x182A0B1F0")]
		public static extern int CGPGLJCENAP(IntPtr HNKFODIAFKO, DLOGHDOADKK HFCGJADJPNC);

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x2A0D810", Offset = "0x2A0C610", VA = "0x182A0D810")]
		public static extern bool PEMPIAOAJJO(IntPtr HNKFODIAFKO, DLOGHDOADKK HFCGJADJPNC, int JJJJBEGKNIN, int OMOJNJCDJEB, bool FDHEJHHBGMN, StringBuilder PFLDDMDPCBI, int ABADGAEMOCO, StringBuilder NLMAHGPPCGM, int FEMEINMPFKO);

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x2A0B0F0", Offset = "0x2A09EF0", VA = "0x182A0B0F0")]
		public static extern bool CCDEHBNCCDH(IntPtr HNKFODIAFKO);

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x2A0B070", Offset = "0x2A09E70", VA = "0x182A0B070")]
		public static extern IntPtr BGAAFHMBCBD(IntPtr HNKFODIAFKO);

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x2A0B7B0", Offset = "0x2A0A5B0", VA = "0x182A0B7B0")]
		public static extern int FBFCOGPMDAM(IntPtr FLFACEEPNPI, [Out] JHOPPHAADOC[] FFGLELJCKKE, int IOOFLJJPNKN, JACLMGFMCMO GPCEKOPMMKJ);

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x2A0CDA0", Offset = "0x2A0BBA0", VA = "0x182A0CDA0")]
		public static extern bool MHDKBDCHLCM(bool KEPKPPAJMJL);

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x2A0B3A0", Offset = "0x2A0A1A0", VA = "0x182A0B3A0")]
		public static extern void DPGGAJAONAL();

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x2A0BD30", Offset = "0x2A0AB30", VA = "0x182A0BD30")]
		public static extern IntPtr GNIIMBPPBOA();

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x2A0C240", Offset = "0x2A0B040", VA = "0x182A0C240")]
		public static extern IntPtr IFDMDPDJIFA(IntPtr HNKFODIAFKO, FLMELIEPEAF.DAKPCCEKBCE EFPGHMDJDPP, FLMELIEPEAF.OBGBGEBPJMN EKOANDFBBHB, bool JHDBAAOCCDO, bool GBOJFKPDJLF, bool KMIEBFAEEEC, bool PNKGCONPGDP, bool ODJBCJJEEAF, bool CEFMOHMCADG, string LKFKMPEIALA, int PBDJGOELLJK, IntPtr[] NHLFFAHOMPC, uint IPEPDMDCGPN, int EHDFHGJHDAN, string IIMKFOJELGI, bool FKACMOLDPFO);

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x2A0C810", Offset = "0x2A0B610", VA = "0x182A0C810")]
		public static extern IntPtr KKMNBGDNFIN(IntPtr HNKFODIAFKO, string GHADMHNDJBK);

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x2A0BAF0", Offset = "0x2A0A8F0", VA = "0x182A0BAF0")]
		public static extern IntPtr GGICHMNFPBI(IntPtr HNKFODIAFKO, byte[] ALPKAMHLIAF, ulong BPICFFHDDJE, FLMELIEPEAF.DAKPCCEKBCE EFPGHMDJDPP, FLMELIEPEAF.OBGBGEBPJMN EKOANDFBBHB, bool JHDBAAOCCDO, bool GBOJFKPDJLF, bool KMIEBFAEEEC, bool PNKGCONPGDP, bool ODJBCJJEEAF, bool CEFMOHMCADG, string LKFKMPEIALA, int PBDJGOELLJK, IntPtr[] NHLFFAHOMPC, uint IPEPDMDCGPN);

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x2A0D970", Offset = "0x2A0C770", VA = "0x182A0D970")]
		public static extern IntPtr PIBAEDLJPED(IntPtr HNKFODIAFKO, FLMELIEPEAF.DAKPCCEKBCE EFPGHMDJDPP, ulong BPICFFHDDJE);

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x2A0CA90", Offset = "0x2A0B890", VA = "0x182A0CA90")]
		public static extern bool LLBOMMKLECJ(IntPtr HNKFODIAFKO, byte[] ALPKAMHLIAF, ulong IBOFMHFOKKF, ulong KCHPJHNNALB);

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x2A0C400", Offset = "0x2A0B200", VA = "0x182A0C400")]
		public static extern IntPtr IMEBDPHMHND(IntPtr HNKFODIAFKO, FLMELIEPEAF.OBGBGEBPJMN EKOANDFBBHB, bool JHDBAAOCCDO, bool GBOJFKPDJLF, bool KMIEBFAEEEC, bool PNKGCONPGDP, bool ODJBCJJEEAF, bool CEFMOHMCADG, string LKFKMPEIALA, int PBDJGOELLJK, IntPtr[] NHLFFAHOMPC, uint IPEPDMDCGPN);

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x2A0C580", Offset = "0x2A0B380", VA = "0x182A0C580")]
		public static extern void IOKEPIKAGJL(IntPtr HNKFODIAFKO);

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x2A0C0C0", Offset = "0x2A0AEC0", VA = "0x182A0C0C0")]
		public static extern IntPtr HNEMKHOIGAA(IntPtr HNKFODIAFKO);

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x2A0BFA0", Offset = "0x2A0ADA0", VA = "0x182A0BFA0")]
		public static extern void HKINHJEKDEH(IntPtr HNKFODIAFKO, bool GDNKPNFMPCI);

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x2A0CD10", Offset = "0x2A0BB10", VA = "0x182A0CD10")]
		public static extern void MGMCNEFFGBC(IntPtr HNKFODIAFKO, bool GDNKPNFMPCI);

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x2A0C030", Offset = "0x2A0AE30", VA = "0x182A0C030")]
		public static extern void HMLLPOOKFON(IntPtr HNKFODIAFKO, bool GDNKPNFMPCI);

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x2A0C8B0", Offset = "0x2A0B6B0", VA = "0x182A0C8B0")]
		public static extern void KMCPJHGFHPK(IntPtr HNKFODIAFKO, bool GDNKPNFMPCI);

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x2A0CBD0", Offset = "0x2A0B9D0", VA = "0x182A0CBD0")]
		public static extern void LNFFLICFKJM(IntPtr HNKFODIAFKO, bool GDNKPNFMPCI, bool NOHGGBLOHPG, double JACNDAAIEHD);

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x2A0B410", Offset = "0x2A0A210", VA = "0x182A0B410")]
		public static extern void EBMFDDGDCND(IntPtr HNKFODIAFKO, bool GDNKPNFMPCI);

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x2A0C770", Offset = "0x2A0B570", VA = "0x182A0C770")]
		public static extern void JPOHIEJCNOC(IntPtr HNKFODIAFKO, int GDDNNIKHOJP, int POANEMIKHOA);

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x2A0C1C0", Offset = "0x2A0AFC0", VA = "0x182A0C1C0")]
		public static extern int IBEHKFIJOGB(IntPtr HNKFODIAFKO);

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x2A0B5B0", Offset = "0x2A0A3B0", VA = "0x182A0B5B0")]
		public static extern void EIOMMCKMPJC(IntPtr HNKFODIAFKO);

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x2A0AFF0", Offset = "0x2A09DF0", VA = "0x182A0AFF0")]
		public static extern void BDCEPMMAHDG(IntPtr HNKFODIAFKO);

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x2A0B4A0", Offset = "0x2A0A2A0", VA = "0x182A0B4A0")]
		public static extern void EDGAOGNLOGA(IntPtr HNKFODIAFKO, bool AEINFDFOGCD);

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x2A0D210", Offset = "0x2A0C010", VA = "0x182A0D210")]
		public static extern void OENEOLIAHGD(IntPtr HNKFODIAFKO, float ILEBLACHCBE);

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x2A0BCA0", Offset = "0x2A0AAA0", VA = "0x182A0BCA0")]
		public static extern void GLNKILGCALN(IntPtr HNKFODIAFKO, float ILEBLACHCBE);

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x2A0CA00", Offset = "0x2A0B800", VA = "0x182A0CA00")]
		public static extern void LHKOCACDLAM(IntPtr HNKFODIAFKO, bool DFDEHFEDCLP);

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x2A0AF70", Offset = "0x2A09D70", VA = "0x182A0AF70")]
		public static extern bool AMPMEKMCPCC(IntPtr HNKFODIAFKO);

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x2A0AD60", Offset = "0x2A09B60", VA = "0x182A0AD60")]
		public static extern bool ACFDNLNJFJN(IntPtr HNKFODIAFKO);

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x2A0BEA0", Offset = "0x2A0ACA0", VA = "0x182A0BEA0")]
		public static extern int GPCMODMGLLI(IntPtr HNKFODIAFKO);

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x2A0DA10", Offset = "0x2A0C810", VA = "0x182A0DA10")]
		public static extern int PNEAJEDGLCE(IntPtr HNKFODIAFKO);

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x2A0D790", Offset = "0x2A0C590", VA = "0x182A0D790")]
		public static extern float OOMCFBBPMAC(IntPtr HNKFODIAFKO);

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x2A0B6B0", Offset = "0x2A0A4B0", VA = "0x182A0B6B0")]
		public static extern AABCGFAHNKC EJNMOFCOEOF(IntPtr HNKFODIAFKO);

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x2A0B9E0", Offset = "0x2A0A7E0", VA = "0x182A0B9E0")]
		public static extern double FNEDCKLMGLM(IntPtr HNKFODIAFKO);

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x2A0B8E0", Offset = "0x2A0A6E0", VA = "0x182A0B8E0")]
		public static extern bool FHKIMBMELFA(IntPtr HNKFODIAFKO);

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x2A0B730", Offset = "0x2A0A530", VA = "0x182A0B730")]
		public static extern bool EKEBMLKJHOO(IntPtr HNKFODIAFKO);

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x2A0C6F0", Offset = "0x2A0B4F0", VA = "0x182A0C6F0")]
		public static extern bool JPNCONIJFFA(IntPtr HNKFODIAFKO);

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x2A0ACE0", Offset = "0x2A09AE0", VA = "0x182A0ACE0")]
		public static extern bool ACDJCHIIOOE(IntPtr HNKFODIAFKO);

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x2A0C140", Offset = "0x2A0AF40", VA = "0x182A0C140")]
		public static extern bool IADKMMNPFPB(IntPtr HNKFODIAFKO);

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x2A0C670", Offset = "0x2A0B470", VA = "0x182A0C670")]
		public static extern bool JEALKMODOFM(IntPtr HNKFODIAFKO);

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x2A0D0D0", Offset = "0x2A0BED0", VA = "0x182A0D0D0")]
		public static extern bool NPAILJJMPJO(IntPtr HNKFODIAFKO);

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x2A0CB50", Offset = "0x2A0B950", VA = "0x182A0CB50")]
		public static extern double LLJMAOJMLFO(IntPtr HNKFODIAFKO);

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x2A0B300", Offset = "0x2A0A100", VA = "0x182A0B300")]
		public static extern void DJCGLKNGFMO(IntPtr HNKFODIAFKO, double GJEDFMHCPFI, bool EKOBFJJCKGB);

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x2A0B170", Offset = "0x2A09F70", VA = "0x182A0B170")]
		public static extern float CCGBCKDPHNG(IntPtr HNKFODIAFKO);

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x2A0D040", Offset = "0x2A0BE40", VA = "0x182A0D040")]
		public static extern void NLMGBEGOKLM(IntPtr HNKFODIAFKO, float GAFEGGNEMAE);

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x2A0CE20", Offset = "0x2A0BC20", VA = "0x182A0CE20")]
		public static extern void MJCKDGEAPEH(IntPtr HNKFODIAFKO);

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x2A0B530", Offset = "0x2A0A330", VA = "0x182A0B530")]
		public static extern void EIGPLFNMDBH(IntPtr HNKFODIAFKO);

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x2A0AE70", Offset = "0x2A09C70", VA = "0x182A0AE70")]
		public static extern void AFCEEABIEMI(IntPtr HNKFODIAFKO);

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x2A0AEF0", Offset = "0x2A09CF0", VA = "0x182A0AEF0")]
		public static extern void AMMOEGHOJHH(IntPtr HNKFODIAFKO);

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x2A0BE20", Offset = "0x2A0AC20", VA = "0x182A0BE20")]
		public static extern IntPtr GOIPJFAIHHC(IntPtr HNKFODIAFKO);

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x2A0B280", Offset = "0x2A0A080", VA = "0x182A0B280")]
		public static extern int CKBOJCOGDBD(IntPtr HNKFODIAFKO);

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x2A0BF20", Offset = "0x2A0AD20", VA = "0x182A0BF20")]
		public static extern bool HGMIEJLEPGB(IntPtr HNKFODIAFKO);

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x2A0CEA0", Offset = "0x2A0BCA0", VA = "0x182A0CEA0")]
		public static extern bool NBDGCFKOPMN(IntPtr HNKFODIAFKO);

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x2A0CF20", Offset = "0x2A0BD20", VA = "0x182A0CF20")]
		public static extern int NDGFLKMEDNP(IntPtr HNKFODIAFKO);

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x2A0B630", Offset = "0x2A0A430", VA = "0x182A0B630")]
		public static extern long EJEAPIBBIBN(IntPtr HNKFODIAFKO);

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x2A0BDA0", Offset = "0x2A0ABA0", VA = "0x182A0BDA0")]
		public static extern float GOGKFOHKPJP(IntPtr HNKFODIAFKO);

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x2A0C600", Offset = "0x2A0B400", VA = "0x182A0C600")]
		public static extern IntPtr JAFOEBCLLLI();

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x2A0D150", Offset = "0x2A0BF50", VA = "0x182A0D150")]
		public static extern int OCKEPPHAFEK(IntPtr HNKFODIAFKO, float[] ALPKAMHLIAF, int BLJFLHLLHAB, int KMCPCDKHDCK);

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x2A0B960", Offset = "0x2A0A760", VA = "0x182A0B960")]
		public static extern int FKIPHPANEFM(IntPtr HNKFODIAFKO);

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x2A0BA60", Offset = "0x2A0A860", VA = "0x182A0BA60")]
		public static extern int FODCENPENMP(IntPtr HNKFODIAFKO, int EHDFHGJHDAN);

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x2A0C940", Offset = "0x2A0B740", VA = "0x182A0C940")]
		public static extern void LHFKCLCKBKH(IntPtr HNKFODIAFKO, float DBBMOEGPNPP, float COFKGIHGCOO, float OONOCAMNEIP, float GFOPEPPIPGD);

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x2A0CC80", Offset = "0x2A0BA80", VA = "0x182A0CC80")]
		public static extern void MABOALOJICM(IntPtr HNKFODIAFKO, bool GDNKPNFMPCI);

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x2A0CFA0", Offset = "0x2A0BDA0", VA = "0x182A0CFA0")]
		public static extern void NHCBLGLCNEM(IntPtr HNKFODIAFKO, float MNABCDABJNN, float BNECOIIDDBO);

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x2A0D6D0", Offset = "0x2A0C4D0", VA = "0x182A0D6D0")]
		public static extern void OODOLFAFCJB(IntPtr HNKFODIAFKO, float DBBMOEGPNPP, float COFKGIHGCOO, float OONOCAMNEIP, float GFOPEPPIPGD);

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x2A0D2A0", Offset = "0x2A0C0A0", VA = "0x182A0D2A0")]
		public static void OLNKNAFADLD(IntPtr HNKFODIAFKO, PCOFLNCPBFL FOLMCJCHLNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x2A0D570", Offset = "0x2A0C370", VA = "0x182A0D570")]
		private static extern void OLNKNAFADLD(IntPtr HNKFODIAFKO, EDJLCNNOJBG KPEEHKACMCL);
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	private FLMELIEPEAF.OBGBGEBPJMN OBMGPEOKOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	private string KFOPJFELHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	private List<string> AJLOBFAKCDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	private PAEMJPLEELJ FBLKPHGBGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	private bool GLONBOAIMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC5")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	private bool PIPAJNHFFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC6")]
	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	private bool GHJBKGABBAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC7")]
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	private bool FFKLDCNBABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	private bool IIFMBEJHKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	private bool CHAALCJOGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	private int BEIFFPDLDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	private int KNJCGPOGJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	private bool KJNDKGOMOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD5")]
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	private bool LNOPKFHKKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD6")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	private bool DCFBCLAKBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private float JHJCLJMMMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private float GCDGMOJPHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private bool KBJPPFCDNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private bool HNFNNCKFEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE2")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private bool LLCFLGLECKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private int MMJIPACFAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private int DKEDCDKCHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private float EIADNNDPOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private bool HKIDFGIJNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF1")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	private bool DFBCENNAPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF2")]
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	private bool NOMIDFHMEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	private IntPtr GHNDMGABGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	private Texture2D KAOCINECGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	private RenderTexture LDJEHMBEPND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	private IntPtr IBKIAAFDJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private FLMELIEPEAF.DAKPCCEKBCE AIPDMHGOCNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private bool AMEKIHCFFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11D")]
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private bool FHOEKKAFHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11E")]
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	private bool HPDHMCJEBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11F")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	private bool FHAODCIMOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	private bool KOMLJGGEEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x121")]
	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	private bool FBLMJJKBJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x122")]
	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	private bool DLBFPFABIBK;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	private static bool DHNECNHJFNC;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	private static string AGJEHFBIIHI;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	private static IntPtr OMGNEEEPABG;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	private static int PICBBAIBCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	private PCOFLNCPBFL JOADFNECEJL;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public PCOFLNCPBFL MACNFCBKOOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x2A05220", Offset = "0x2A04020", VA = "0x182A05220")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x2A03D90", Offset = "0x2A02B90", VA = "0x182A03D90")]
	public static bool FHPCKAJLJCJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x2A070D0", Offset = "0x2A05ED0", VA = "0x182A070D0")]
	public static void OJGHJOKIJCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x2A041A0", Offset = "0x2A02FA0", VA = "0x182A041A0", Slot = "135")]
	public override int FKIPHPANEFM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x2A07420", Offset = "0x2A06220", VA = "0x182A07420")]
	public BFEALDKDAMG(MediaPlayer.OptionsWindows PMEODJMCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x2A04330", Offset = "0x2A03130", VA = "0x182A04330")]
	public void GCMCGONKALC(MediaPlayer.OptionsWindows PMEODJMCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x2A043E0", Offset = "0x2A031E0", VA = "0x182A043E0")]
	public void GCMCGONKALC(FLMELIEPEAF.DAKPCCEKBCE EFPGHMDJDPP, FLMELIEPEAF.OBGBGEBPJMN EKOANDFBBHB, bool JHDBAAOCCDO, bool GBOJFKPDJLF, bool NBPNNOFNGKM, bool CEFMOHMCADG, bool PNKGCONPGDP, bool ODJBCJJEEAF, string CMCIOIMIIGJ, List<string> JNPCDJMEMCJ, bool LDKPCHEGODF, int GDDNNIKHOJP, int POANEMIKHOA, bool PMEDKGJCKIJ, bool HIENLOFMNDG, bool JJCJKGJLGIO, bool AFAEDMFKHFJ, bool POKCOOGBHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x2A04620", Offset = "0x2A03420", VA = "0x182A04620", Slot = "82")]
	public override string GDKGLLEKLDO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x2A06EA0", Offset = "0x2A05CA0", VA = "0x182A06EA0", Slot = "83")]
	public override string NFBPNIDLGAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x2A04690", Offset = "0x2A03490", VA = "0x182A04690")]
	private bool GFGOCGBEGNH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x2A05870", Offset = "0x2A04670", VA = "0x182A05870", Slot = "84")]
	public override bool JOCHMHJBIGK(string GHADMHNDJBK, long IBOFMHFOKKF, string IIMKFOJELGI, MediaHints ALELCMHDHAM, int JMJCBIMCCHC = 0, bool FKACMOLDPFO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x2A067B0", Offset = "0x2A055B0", VA = "0x182A067B0", Slot = "85")]
	public override bool MBPCLKLBCGM(byte[] ALPKAMHLIAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x2A05650", Offset = "0x2A04450", VA = "0x182A05650", Slot = "86")]
	public override bool JJPEKPGEBGH(ulong MCJGICKIGFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x2A05260", Offset = "0x2A04060", VA = "0x182A05260", Slot = "87")]
	public override bool JCPEKCBOPJI(byte[] FLFGHPEEGLF, ulong IBOFMHFOKKF, ulong MCJGICKIGFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x2A03470", Offset = "0x2A02270", VA = "0x182A03470", Slot = "88")]
	public override bool CLDCNNDMOIN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x2A06C40", Offset = "0x2A05A40", VA = "0x182A06C40")]
	private void MCCEBKLCKGA(string GHADMHNDJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x2A053D0", Offset = "0x2A041D0", VA = "0x182A053D0", Slot = "89")]
	public override void JIKEGLOGNLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x2A06680", Offset = "0x2A05480", VA = "0x182A06680", Slot = "90")]
	public override void LHKOCACDLAM(bool DFDEHFEDCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0xB63390", Offset = "0xB62190", VA = "0x180B63390", Slot = "91")]
	public override bool DMFKDCAGEOP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0xB631E0", Offset = "0xB61FE0", VA = "0x180B631E0", Slot = "92")]
	public override bool EKEBMLKJHOO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x1716D70", Offset = "0x1715B70", VA = "0x181716D70", Slot = "107")]
	public override bool ACFDNLNJFJN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x2615470", Offset = "0x2614270", VA = "0x182615470", Slot = "108")]
	public override bool AMPMEKMCPCC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0xB63190", Offset = "0xB61F90", VA = "0x180B63190", Slot = "93")]
	public override bool JPNCONIJFFA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x2A03C10", Offset = "0x2A02A10", VA = "0x182A03C10", Slot = "94")]
	public override void EIOMMCKMPJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x2A03240", Offset = "0x2A02040", VA = "0x182A03240", Slot = "95")]
	public override void BDCEPMMAHDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x2A07370", Offset = "0x2A06170", VA = "0x182A07370", Slot = "96")]
	public override void PMKEICCMJHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x2A02590", Offset = "0x2A01390", VA = "0x182A02590", Slot = "109")]
	public override bool ACDJCHIIOOE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x2A05100", Offset = "0x2A03F00", VA = "0x182A05100", Slot = "110")]
	public override bool IADKMMNPFPB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x2A065E0", Offset = "0x2A053E0", VA = "0x182A065E0", Slot = "111")]
	public override bool LCMDBILBFDM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x2A05320", Offset = "0x2A04120", VA = "0x182A05320", Slot = "112")]
	public override bool JEALKMODOFM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x2A06F60", Offset = "0x2A05D60", VA = "0x182A06F60", Slot = "113")]
	public override bool NPAILJJMPJO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x2A04220", Offset = "0x2A03020", VA = "0x182A04220", Slot = "103")]
	public override double FNEDCKLMGLM()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x1EFCC00", Offset = "0x1EFBA00", VA = "0x181EFCC00", Slot = "104")]
	public override int PJCEHKOHKJM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0xB36280", Offset = "0xB35080", VA = "0x180B36280", Slot = "105")]
	public override int BIDJNENGKJL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x223FB30", Offset = "0x223E930", VA = "0x18223FB30", Slot = "106")]
	public override float GNDDNLOAJGE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x2A04A30", Offset = "0x2A03830", VA = "0x182A04A30", Slot = "116")]
	public override Texture GetTexture(int JJJJBEGKNIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x2A048F0", Offset = "0x2A036F0", VA = "0x182A048F0", Slot = "117")]
	public override int GetTextureFrameCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x2A049B0", Offset = "0x2A037B0", VA = "0x182A049B0", Slot = "119")]
	public override long GetTextureTimeStamp()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x2A04900", Offset = "0x2A03700", VA = "0x182A04900", Slot = "121")]
	public override float GetTexturePixelAspectRatio()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x26915C0", Offset = "0x26903C0", VA = "0x1826915C0", Slot = "120")]
	public override bool RequiresVerticalFlip()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x2A05110", Offset = "0x2A03F10", VA = "0x182A05110", Slot = "127")]
	internal override AABCGFAHNKC IIAEMBFLHIL()
	{
		return default(AABCGFAHNKC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x2A033D0", Offset = "0x2A021D0", VA = "0x182A033D0", Slot = "98")]
	public override void BOPNDEIGLFI(double GJEDFMHCPFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x2A04670", Offset = "0x2A03470", VA = "0x182A04670", Slot = "99")]
	public override void GECNJGBBJJB(double GJEDFMHCPFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x2A066A0", Offset = "0x2A054A0", VA = "0x182A066A0", Slot = "100")]
	public override double LLJMAOJMLFO()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x2A06ED0", Offset = "0x2A05CD0", VA = "0x182A06ED0", Slot = "102")]
	public override void NLMGBEGOKLM(float GAFEGGNEMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x2A033F0", Offset = "0x2A021F0", VA = "0x182A033F0", Slot = "101")]
	public override float CCGBCKDPHNG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x2A06E10", Offset = "0x2A05C10", VA = "0x182A06E10", Slot = "129")]
	public override void MJPINGMBIEP(bool OKMCFMAKENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x2691560", Offset = "0x2690360", VA = "0x182691560", Slot = "130")]
	public override bool LNAKKGGBEJN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x2A070B0", Offset = "0x2A05EB0", VA = "0x182A070B0", Slot = "131")]
	public override void OENEOLIAHGD(float ILEBLACHCBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0xC010D0", Offset = "0xBFFED0", VA = "0x180C010D0", Slot = "133")]
	public override float DHBENLHDCNE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x2A047A0", Offset = "0x2A035A0", VA = "0x182A047A0", Slot = "132")]
	public override void GLNKILGCALN(float LOILCHOIMMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x1F6A1F0", Offset = "0x1F68FF0", VA = "0x181F6A1F0", Slot = "134")]
	public override float GCEDIKFGPOB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x2A03CE0", Offset = "0x2A02AE0", VA = "0x182A03CE0", Slot = "153")]
	public override bool FHKIMBMELFA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x2A039E0", Offset = "0x2A027E0", VA = "0x182A039E0", Slot = "114")]
	public override bool DMLFIGLOPIO(Camera ELMGFHEHLEP, int EMEJCBKDPCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x2A042A0", Offset = "0x2A030A0", VA = "0x182A042A0", Slot = "140")]
	public override void FODCENPENMP(PAEMJPLEELJ FDDPCOLMFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x2A03CA0", Offset = "0x2A02AA0", VA = "0x182A03CA0", Slot = "138")]
	public override void FFAAKMMPCOH(Quaternion CGMILECIDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x2A046A0", Offset = "0x2A034A0", VA = "0x182A046A0", Slot = "139")]
	public override void GGJHGNBLMNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x2A06720", Offset = "0x2A05520", VA = "0x182A06720", Slot = "141")]
	public override void MABOALOJICM(bool GDNKPNFMPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x2A06D70", Offset = "0x2A05B70", VA = "0x182A06D70", Slot = "142")]
	public override void MEEJAAEMDNF(float MNABCDABJNN, float BNECOIIDDBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x2A07180", Offset = "0x2A05F80", VA = "0x182A07180", Slot = "143")]
	public override void OODOLFAFCJB(Quaternion CGMILECIDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x2A02620", Offset = "0x2A01420", VA = "0x182A02620", Slot = "146")]
	public override void AFCEEABIEMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x2A05750", Offset = "0x2A04550", VA = "0x182A05750")]
	private void JKHLHMGNFCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x2A04AD0", Offset = "0x2A038D0", VA = "0x182A04AD0")]
	private void HIEKBBDEGPE(IntPtr BNIIOLPCAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x2A031C0", Offset = "0x2A01FC0", VA = "0x182A031C0", Slot = "150")]
	public override void AMMOEGHOJHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0")]
	private void INBNKAJFMIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x2A03920", Offset = "0x2A02720", VA = "0x182A03920", Slot = "147")]
	public override void DHAAJBADCBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x2A032D0", Offset = "0x2A020D0", VA = "0x182A032D0", Slot = "148")]
	public override void BMMCDIAKPMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "149")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x2A06FF0", Offset = "0x2A05DF0", VA = "0x182A06FF0", Slot = "136")]
	public override int OCKEPPHAFEK(float[] ALPKAMHLIAF, int BLJFLHLLHAB, int KMCPCDKHDCK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x2135B30", Offset = "0x2134930", VA = "0x182135B30", Slot = "151")]
	public override bool MBDAJGABKLP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x2A05580", Offset = "0x2A04380", VA = "0x182A05580")]
	private static void JJKCPJOMKNK(DLIPNLPPMEE.HNEKGAJGNBN KPBCHEFJNMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x2A04840", Offset = "0x2A03640", VA = "0x182A04840")]
	private static string GNIIMBPPBOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x2A05190", Offset = "0x2A03F90", VA = "0x182A05190", Slot = "159")]
	internal override bool IPIALJCHCJK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x2A030D0", Offset = "0x2A01ED0", VA = "0x182A030D0", Slot = "160")]
	internal override string ALIJFKNMHLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x2A072D0", Offset = "0x2A060D0", VA = "0x182A072D0", Slot = "161")]
	internal override bool PHOCDFLJFKH(DLOGHDOADKK HFCGJADJPNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x2A07230", Offset = "0x2A06030", VA = "0x182A07230", Slot = "162")]
	internal override int PDHIEFPHIFA(DLOGHDOADKK HFCGJADJPNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x2A06230", Offset = "0x2A05030", VA = "0x182A06230", Slot = "163")]
	internal override JFNIFAPOMPO KKLPLALMPFF(DLOGHDOADKK HFCGJADJPNC, int FCFCDKODNHK, bool OOKPIIMIAEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x2A06620", Offset = "0x2A05420", VA = "0x182A06620", Slot = "144")]
	public override void LHAADKDFBJG(string OBGCPOCPFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x2A03BB0", Offset = "0x2A029B0", VA = "0x182A03BB0", Slot = "145")]
	public override void EGAPFNMGFNM(byte[] OPGJHIOADCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x2A03060", Offset = "0x2A01E60", VA = "0x182A03060")]
	private void AJKAIKLGJIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x2A03850", Offset = "0x2A02650", VA = "0x182A03850")]
	private void CMECFKDBPAL(JHOPPHAADOC[] JBEBIIPBGHG, DLIPNLPPMEE.JACLMGFMCMO GPCEKOPMMKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public enum MDHNJEHCNKN
{
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	Opening = 1,
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	Buffering = 2,
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	Playing = 3,
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	Paused = 4,
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	StateMask = 7,
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	Seeking = 32
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public sealed class HJGLEJNOPNJ : PIPIIHKKDDP
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	private struct FPKBPMAGMDE
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		public enum OPCOPNLJEGM
		{
			[Cpp2IlInjected.Token(Token = "0x40002F3")]
			Fast,
			[Cpp2IlInjected.Token(Token = "0x40002F4")]
			Accurate
		}

		[StructLayout((LayoutKind)0, Pack = 1, Size = 20)]
		[Cpp2IlInjected.Token(Token = "0x2000065")]
		public struct ICGDGPNPOAJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002F5")]
			public int FCFCDKODNHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002F6")]
			public int NLKOJDAPCIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002F7")]
			public int EHMAGAMMGAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40002F8")]
			public float GGDLALIMJJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002F9")]
			public uint GJKKHHBLIBN;
		}

		[StructLayout((LayoutKind)0, Pack = 1, Size = 12)]
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		public struct NFMHLBIFEHL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002FA")]
			public double JACNDAAIEHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002FB")]
			public OPCOPNLJEGM KJLMJGOOKJM;
		}

		[StructLayout((LayoutKind)0, Pack = 1, Size = 28)]
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		public struct JNPALJHDOAK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002FC")]
			public string MOGHIIFJJCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002FD")]
			public string OBGCPOCPFIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002FE")]
			public IntPtr GOHCCLMFAGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002FF")]
			public int IBCHOLGKBJC;
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		internal enum DOBGJNHKMMJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000301")]
			Seekable,
			[Cpp2IlInjected.Token(Token = "0x4000302")]
			Buffered
		}

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private static IntPtr OMGNEEEPABG;

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x2A0DB30", Offset = "0x2A0C930", VA = "0x182A0DB30")]
		public static extern bool AEJCMNIFEPN(IntPtr HNKFODIAFKO, DLOGHDOADKK HFCGJADJPNC);

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x2A0E050", Offset = "0x2A0CE50", VA = "0x182A0E050")]
		public static extern int CGPGLJCENAP(IntPtr HNKFODIAFKO, DLOGHDOADKK HFCGJADJPNC);

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x2A0F270", Offset = "0x2A0E070", VA = "0x182A0F270")]
		public static extern bool PEMPIAOAJJO(IntPtr HNKFODIAFKO, DLOGHDOADKK HFCGJADJPNC, int JJJJBEGKNIN, int OMOJNJCDJEB, bool FDHEJHHBGMN, StringBuilder PFLDDMDPCBI, int ABADGAEMOCO, StringBuilder NLMAHGPPCGM, int FEMEINMPFKO);

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x2A0DED0", Offset = "0x2A0CCD0", VA = "0x182A0DED0")]
		public static extern bool CCDEHBNCCDH(IntPtr HNKFODIAFKO);

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x2A0DDC0", Offset = "0x2A0CBC0", VA = "0x182A0DDC0")]
		public static extern IntPtr BGAAFHMBCBD(IntPtr HNKFODIAFKO);

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x2A0E870", Offset = "0x2A0D670", VA = "0x182A0E870")]
		private static extern IntPtr IIJGMFJNMCN();

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x2A0E6B0", Offset = "0x2A0D4B0", VA = "0x182A0E6B0")]
		public static string GNIIMBPPBOA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x2A0F3D0", Offset = "0x2A0E1D0", VA = "0x182A0F3D0")]
		public static extern IntPtr PHEEIAMPPNP();

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x2A0DFD0", Offset = "0x2A0CDD0", VA = "0x182A0DFD0")]
		public static extern void CDEBJPCKDDD(IntPtr FLFACEEPNPI);

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x2A0EA60", Offset = "0x2A0D860", VA = "0x182A0EA60")]
		public static extern bool JOCHMHJBIGK(IntPtr FLFACEEPNPI, string GLIMJFLPLJE, string IIMKFOJELGI, HBPIEKMDMJL HBLLACFHCDO, bool FKACMOLDPFO, bool CEFMOHMCADG);

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x2A0E9E0", Offset = "0x2A0D7E0", VA = "0x182A0E9E0")]
		public static extern void JIKEGLOGNLN(IntPtr FLFACEEPNPI);

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x2A0DD40", Offset = "0x2A0CB40", VA = "0x182A0DD40")]
		public static extern void BDCEPMMAHDG(IntPtr FLFACEEPNPI);

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x2A0E370", Offset = "0x2A0D170", VA = "0x182A0E370")]
		public static extern void EIOMMCKMPJC(IntPtr FLFACEEPNPI);

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x2A0EBD0", Offset = "0x2A0D9D0", VA = "0x182A0EBD0")]
		public static extern void LKDKMFEKMLJ(IntPtr FLFACEEPNPI, float ILEBLACHCBE);

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x2A0E950", Offset = "0x2A0D750", VA = "0x182A0E950")]
		public static extern void JDEHFFFHFFK(IntPtr FLFACEEPNPI, float LOILCHOIMMD);

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x2A0EDB0", Offset = "0x2A0DBB0", VA = "0x182A0EDB0")]
		public static extern void NLMGBEGOKLM(IntPtr FLFACEEPNPI, float GAFEGGNEMAE);

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x2A0E470", Offset = "0x2A0D270", VA = "0x182A0E470")]
		public static extern void ENAHNJCGFJC(IntPtr FLFACEEPNPI, bool AEINFDFOGCD);

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x2A0E230", Offset = "0x2A0D030", VA = "0x182A0E230")]
		public static extern bool EFCOACMHPJN(IntPtr FLFACEEPNPI);

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x2A0E1B0", Offset = "0x2A0CFB0", VA = "0x182A0E1B0")]
		public static extern float DNOHGKJPDLN(IntPtr FLFACEEPNPI);

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x2A0DF50", Offset = "0x2A0CD50", VA = "0x182A0DF50")]
		public static extern float CCGBCKDPHNG(IntPtr FLFACEEPNPI);

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x2A0EB40", Offset = "0x2A0D940", VA = "0x182A0EB40")]
		public static extern void LHKOCACDLAM(IntPtr FLFACEEPNPI, bool DFDEHFEDCLP);

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x2A0E7F0", Offset = "0x2A0D5F0", VA = "0x182A0E7F0")]
		public static extern int IBEHKFIJOGB(IntPtr FLFACEEPNPI);

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x2A0DBC0", Offset = "0x2A0C9C0", VA = "0x182A0DBC0")]
		public static extern void AFCEEABIEMI(IntPtr FLFACEEPNPI);

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x2A0E630", Offset = "0x2A0D430", VA = "0x182A0E630")]
		public static extern double FNEDCKLMGLM(IntPtr FLFACEEPNPI);

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x2A0E3F0", Offset = "0x2A0D1F0", VA = "0x182A0E3F0")]
		public static extern AABCGFAHNKC EJNMOFCOEOF(IntPtr FLFACEEPNPI);

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x2A0DCC0", Offset = "0x2A0CAC0", VA = "0x182A0DCC0")]
		public static extern double AOBNCGOCGJD(IntPtr FLFACEEPNPI);

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x2A0E0E0", Offset = "0x2A0CEE0", VA = "0x182A0E0E0")]
		public static extern bool DADFPNIJHIH(IntPtr FLFACEEPNPI, [Out] IntPtr GKJOECOFOAM, [Out] IntPtr COHKIHANOBN, [Out] ulong CFKIDHMHOCB, [Out] int FIJCBEGFDBD, [Out] int HBJICDOMHDE);

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x2A0DC40", Offset = "0x2A0CA40", VA = "0x182A0DC40")]
		public static extern MDHNJEHCNKN ALILIBNPKIL(IntPtr FLFACEEPNPI);

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x2A0ED20", Offset = "0x2A0DB20", VA = "0x182A0ED20")]
		public static extern bool NFNDPPJFKPH(IntPtr FLFACEEPNPI, [Out] ICGDGPNPOAJ PLBALLGDFCG);

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x2A0E760", Offset = "0x2A0D560", VA = "0x182A0E760")]
		public static extern void HCLKLBMOJLA(IntPtr FLFACEEPNPI, double KBODPDIPNAF);

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x2A0DE40", Offset = "0x2A0CC40", VA = "0x182A0DE40")]
		public static extern void BOPNDEIGLFI(IntPtr FLFACEEPNPI, NFMHLBIFEHL LLMEELBMKOM);

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x2A0EE40", Offset = "0x2A0DC40", VA = "0x182A0EE40")]
		public static void OLNKNAFADLD(IntPtr FLFACEEPNPI, PCOFLNCPBFL FOLMCJCHLNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x2A0F110", Offset = "0x2A0DF10", VA = "0x182A0F110")]
		private static extern void OLNKNAFADLD(IntPtr FLFACEEPNPI, JNPALJHDOAK KPEEHKACMCL);

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x2A0E500", Offset = "0x2A0D300", VA = "0x182A0E500")]
		public static extern int FBFCOGPMDAM(IntPtr FLFACEEPNPI, [Out] JHOPPHAADOC[] FFGLELJCKKE, int IOOFLJJPNKN, DOBGJNHKMMJ GPCEKOPMMKJ);

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x2A0E8E0", Offset = "0x2A0D6E0", VA = "0x182A0E8E0")]
		public static extern IntPtr JAFOEBCLLLI();

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x2A0E2B0", Offset = "0x2A0D0B0", VA = "0x182A0E2B0")]
		public static void EGMGKFKLLHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x2A0EC60", Offset = "0x2A0DA60", VA = "0x182A0EC60")]
		public static void MMCIPABFOEF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private class KKLNKKNBEHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public Texture2D JDNNGPGPIOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public IntPtr IJAKALHPFKM;

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x2A12FC0", Offset = "0x2A11DC0", VA = "0x182A12FC0")]
		public void FFICDEPBOPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x2A130A0", Offset = "0x2A11EA0", VA = "0x182A130A0")]
		public KKLNKKNBEHD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private bool IHNLCOBDKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private bool KBJPPFCDNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private float JHJCLJMMMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	private bool FHAODCIMOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	private bool JMHHAOMMLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private PCOFLNCPBFL JOADFNECEJL;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private static bool DHNECNHJFNC;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private static string AGJEHFBIIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private ulong EKAHHDILKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private IntPtr NLJNIOOGEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private KKLNKKNBEHD[] FIEIDNBGLIJ;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public PCOFLNCPBFL MACNFCBKOOF
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x2A109F0", Offset = "0x2A0F7F0", VA = "0x182A109F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x2A11BB0", Offset = "0x2A109B0", VA = "0x182A11BB0")]
	public HJGLEJNOPNJ(MediaPlayer.OptionsWindows PMEODJMCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x2A10600", Offset = "0x2A0F400", VA = "0x182A10600")]
	public void GCMCGONKALC(MediaPlayer.OptionsWindows PMEODJMCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x2A10E30", Offset = "0x2A0FC30", VA = "0x182A10E30", Slot = "93")]
	public override bool JPNCONIJFFA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x2A0FFE0", Offset = "0x2A0EDE0", VA = "0x182A0FFE0", Slot = "149")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "151")]
	public override bool MBDAJGABKLP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x2A11250", Offset = "0x2A10050", VA = "0x182A11250", Slot = "100")]
	public override double LLJMAOJMLFO()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x2A10570", Offset = "0x2A0F370", VA = "0x182A10570", Slot = "103")]
	public override double FNEDCKLMGLM()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x2A0FE90", Offset = "0x2A0EC90", VA = "0x182A0FE90", Slot = "101")]
	public override float CCGBCKDPHNG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x2A10870", Offset = "0x2A0F670", VA = "0x182A10870", Slot = "116")]
	public override Texture GetTexture(int JJJJBEGKNIN = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x2A107E0", Offset = "0x2A0F5E0", VA = "0x182A107E0", Slot = "115")]
	public override int GetTextureCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x1E81D40", Offset = "0x1E80B40", VA = "0x181E81D40", Slot = "117")]
	public override int GetTextureFrameCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x2A108E0", Offset = "0x2A0F6E0", VA = "0x182A108E0", Slot = "127")]
	internal override AABCGFAHNKC IIAEMBFLHIL()
	{
		return default(AABCGFAHNKC);
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x2A10630", Offset = "0x2A0F430", VA = "0x182A10630", Slot = "82")]
	public override string GDKGLLEKLDO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x2A113F0", Offset = "0x2A101F0", VA = "0x182A113F0", Slot = "83")]
	public override string NFBPNIDLGAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x2A10730", Offset = "0x2A0F530", VA = "0x182A10730", Slot = "106")]
	public override float GNDDNLOAJGE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x2A11A70", Offset = "0x2A10870", VA = "0x182A11A70", Slot = "104")]
	public override int PJCEHKOHKJM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x2A0FD30", Offset = "0x2A0EB30", VA = "0x182A0FD30", Slot = "105")]
	public override int BIDJNENGKJL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x1D2D710", Offset = "0x1D2C510", VA = "0x181D2D710", Slot = "133")]
	public override float DHBENLHDCNE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x2A106A0", Offset = "0x2A0F4A0", VA = "0x182A106A0", Slot = "132")]
	public override void GLNKILGCALN(float LOILCHOIMMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x2A10580", Offset = "0x2A0F380", VA = "0x182A10580", Slot = "134")]
	public override float GCEDIKFGPOB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x2A0F460", Offset = "0x2A0E260", VA = "0x182A0F460", Slot = "107")]
	public override bool ACFDNLNJFJN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x2A102C0", Offset = "0x2A0F0C0", VA = "0x182A102C0", Slot = "92")]
	public override bool EKEBMLKJHOO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x2A0FC70", Offset = "0x2A0EA70", VA = "0x182A0FC70", Slot = "108")]
	public override bool AMPMEKMCPCC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x2A114B0", Offset = "0x2A102B0", VA = "0x182A114B0", Slot = "113")]
	public override bool NPAILJJMPJO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x2A10A30", Offset = "0x2A0F830", VA = "0x182A10A30", Slot = "112")]
	public override bool JEALKMODOFM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0xB63400", Offset = "0xB62200", VA = "0x180B63400", Slot = "91")]
	public override bool DMFKDCAGEOP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x2A112D0", Offset = "0x2A100D0", VA = "0x182A112D0", Slot = "130")]
	public override bool LNAKKGGBEJN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x2A111B0", Offset = "0x2A0FFB0", VA = "0x182A111B0", Slot = "111")]
	public override bool LCMDBILBFDM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x2A108C0", Offset = "0x2A0F6C0", VA = "0x182A108C0", Slot = "110")]
	public override bool IADKMMNPFPB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x2A0F440", Offset = "0x2A0E240", VA = "0x182A0F440", Slot = "109")]
	public override bool ACDJCHIIOOE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x2A11360", Offset = "0x2A10160", VA = "0x182A11360", Slot = "129")]
	public override void MJPINGMBIEP(bool OKMCFMAKENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x2A10B90", Offset = "0x2A0F990", VA = "0x182A10B90", Slot = "84")]
	public override bool JOCHMHJBIGK(string GHADMHNDJBK, long IBOFMHFOKKF, string IIMKFOJELGI, MediaHints ALELCMHDHAM, int JMJCBIMCCHC = 0, bool FKACMOLDPFO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x2A10AE0", Offset = "0x2A0F8E0", VA = "0x182A10AE0", Slot = "89")]
	public override void JIKEGLOGNLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x2A0FCB0", Offset = "0x2A0EAB0", VA = "0x182A0FCB0", Slot = "95")]
	public override void BDCEPMMAHDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x2A10240", Offset = "0x2A0F040", VA = "0x182A10240", Slot = "94")]
	public override void EIOMMCKMPJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x2A0E2B0", Offset = "0x2A0D0B0", VA = "0x182A0E2B0", Slot = "148")]
	public override void BMMCDIAKPMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x2A11540", Offset = "0x2A10340", VA = "0x182A11540")]
	private void OPEBLCKEJNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660", Slot = "120")]
	public override bool RequiresVerticalFlip()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x2A0FE00", Offset = "0x2A0EC00", VA = "0x182A0FE00", Slot = "98")]
	public override void BOPNDEIGLFI(double GJEDFMHCPFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x2A10680", Offset = "0x2A0F480", VA = "0x182A10680", Slot = "99")]
	public override void GECNJGBBJJB(double GJEDFMHCPFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x2A11230", Offset = "0x2A10030", VA = "0x182A11230", Slot = "90")]
	public override void LHKOCACDLAM(bool FMNFBBFJOPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x2A11420", Offset = "0x2A10220", VA = "0x182A11420", Slot = "102")]
	public override void NLMGBEGOKLM(float GAFEGGNEMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x2A114D0", Offset = "0x2A102D0", VA = "0x182A114D0", Slot = "131")]
	public override void OENEOLIAHGD(float ILEBLACHCBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x2A07370", Offset = "0x2A06170", VA = "0x182A07370", Slot = "96")]
	public override void PMKEICCMJHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x2A0FB10", Offset = "0x2A0E910", VA = "0x182A0FB10")]
	private void AJKAIKLGJIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x2A0FF10", Offset = "0x2A0ED10", VA = "0x182A0FF10")]
	private void CMECFKDBPAL(JHOPPHAADOC[] JBEBIIPBGHG, FPKBPMAGMDE.DOBGJNHKMMJ GPCEKOPMMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x2A0F4A0", Offset = "0x2A0E2A0", VA = "0x182A0F4A0", Slot = "146")]
	public override void AFCEEABIEMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x2A111D0", Offset = "0x2A0FFD0", VA = "0x182A111D0", Slot = "144")]
	public override void LHAADKDFBJG(string OBGCPOCPFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x2A101E0", Offset = "0x2A0EFE0", VA = "0x182A101E0", Slot = "145")]
	public override void EGAPFNMGFNM(byte[] OPGJHIOADCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x2A119E0", Offset = "0x2A107E0", VA = "0x182A119E0", Slot = "161")]
	internal override bool PHOCDFLJFKH(DLOGHDOADKK HFCGJADJPNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x2A11950", Offset = "0x2A10750", VA = "0x182A11950", Slot = "162")]
	internal override int PDHIEFPHIFA(DLOGHDOADKK HFCGJADJPNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x2A10E50", Offset = "0x2A0FC50", VA = "0x182A10E50", Slot = "163")]
	internal override JFNIFAPOMPO KKLPLALMPFF(DLOGHDOADKK HFCGJADJPNC, int FCFCDKODNHK, bool OOKPIIMIAEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x2A10960", Offset = "0x2A0F760", VA = "0x182A10960", Slot = "159")]
	internal override bool IPIALJCHCJK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x2A0FB80", Offset = "0x2A0E980", VA = "0x182A0FB80", Slot = "160")]
	internal override string ALIJFKNMHLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2A102F0", Offset = "0x2A0F0F0", VA = "0x182A102F0")]
	public static bool FHPCKAJLJCJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x2A114F0", Offset = "0x2A102F0", VA = "0x182A114F0")]
	public static void OJGHJOKIJCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class MHADJKOPADC
{
	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public string JEMNDLOEAAI
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0xA9BE10", Offset = "0xA9AC10", VA = "0x180A9BE10")]
	internal MHADJKOPADC(string IMIIGPOLNDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public enum DLOGHDOADKK
{
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	Video,
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	Audio,
	[Cpp2IlInjected.Token(Token = "0x4000309")]
	Text
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class JFNIFAPOMPO
{
	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public int KDDDNGAPLDG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	private DLOGHDOADKK FEGIDAKCOGA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0xB8DFD0", Offset = "0xB8CDD0", VA = "0x180B8DFD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	private string FLIJPJIHMOO
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public string PFJMEOIMPID
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private bool KPAOKNOOJHI
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xAC2300", Offset = "0xAC1100", VA = "0x180AC2300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x2A12EB0", Offset = "0x2A11CB0", VA = "0x182A12EB0")]
	internal JFNIFAPOMPO(DLOGHDOADKK HFCGJADJPNC, int OMOJNJCDJEB, string PFLDDMDPCBI, string NLMAHGPPCGM, bool NDCBKJHJNAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x2A12DF0", Offset = "0x2A11BF0", VA = "0x182A12DF0")]
	protected string FECBDKJIDBK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public abstract class EPPOCLBAPDO : IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public virtual DLOGHDOADKK FEGIDAKCOGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DLOGHDOADKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public abstract int KFMIHBFLPLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract IEnumerator GetEnumerator();

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(Slot = "8")]
	internal abstract void FMJEOCFJDAJ();

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void DPHJBDIDPOG(JFNIFAPOMPO FLFHALJLNAD);

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract void PHIBFOBENNL(JFNIFAPOMPO FLFHALJLNAD);

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	protected EPPOCLBAPDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[DefaultMember("Item")]
public class LKBAMBINHJL<T> : EPPOCLBAPDO where T : JFNIFAPOMPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	internal List<T> DGKIGEJMBBA;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	internal T OFICKEPGLGP
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public override int KFMIHBFLPLI
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x5699030", Offset = "0x5697E30", VA = "0x185699030", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x56991E0", Offset = "0x5697FE0", VA = "0x1856991E0")]
	internal LKBAMBINHJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x5699070", Offset = "0x5697E70", VA = "0x185699070", Slot = "7")]
	public override IEnumerator GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x5698FD0", Offset = "0x5697DD0", VA = "0x185698FD0", Slot = "8")]
	internal override void FMJEOCFJDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x5698EF0", Offset = "0x5697CF0", VA = "0x185698EF0", Slot = "9")]
	internal override void DPHJBDIDPOG(JFNIFAPOMPO FLFHALJLNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x5699100", Offset = "0x5697F00", VA = "0x185699100", Slot = "10")]
	internal override void PHIBFOBENNL(JFNIFAPOMPO FLFHALJLNAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class AJIOFAOJEKD : LKBAMBINHJL<DLJGPGMLPHD>
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public override DLOGHDOADKK FEGIDAKCOGA
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "5")]
		get
		{
			return default(DLOGHDOADKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x2A02440", Offset = "0x2A01240", VA = "0x182A02440")]
	public AJIOFAOJEKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class PNLMGJOCNGA : LKBAMBINHJL<ILGBDLIAFKL>
{
	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public override DLOGHDOADKK FEGIDAKCOGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0xC21FD0", Offset = "0xC20DD0", VA = "0x180C21FD0", Slot = "5")]
		get
		{
			return default(DLOGHDOADKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x2A17A50", Offset = "0x2A16850", VA = "0x182A17A50")]
	public PNLMGJOCNGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class CGJCHMANIHO : LKBAMBINHJL<MPGNJJHKFPA>
{
	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public override DLOGHDOADKK FEGIDAKCOGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0xAEE190", Offset = "0xAECF90", VA = "0x180AEE190", Slot = "5")]
		get
		{
			return default(DLOGHDOADKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x2A0A2F0", Offset = "0x2A090F0", VA = "0x182A0A2F0")]
	public CGJCHMANIHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class DLJGPGMLPHD : JFNIFAPOMPO
{
	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x2A0DA90", Offset = "0x2A0C890", VA = "0x182A0DA90")]
	internal DLJGPGMLPHD(int OMOJNJCDJEB, string PFLDDMDPCBI, string NLMAHGPPCGM, bool NDCBKJHJNAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class ILGBDLIAFKL : JFNIFAPOMPO
{
	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x2A12DC0", Offset = "0x2A11BC0", VA = "0x182A12DC0")]
	internal ILGBDLIAFKL(int OMOJNJCDJEB, string PFLDDMDPCBI, string NLMAHGPPCGM, bool NDCBKJHJNAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class MPGNJJHKFPA : JFNIFAPOMPO
{
	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x2A136C0", Offset = "0x2A124C0", VA = "0x182A136C0")]
	internal MPGNJJHKFPA(int OMOJNJCDJEB, string PFLDDMDPCBI, string NLMAHGPPCGM, bool NDCBKJHJNAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface NDOFADIJFIN
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface FMOEJCHFCHP
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface NMDKKCFFLJB
{
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public static class IAMMGBEBDAI
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public enum KDJFOFCLBKA
	{
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		Step,
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		Linear,
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		InQuad,
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		OutQuad,
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		InOutQuad,
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		InCubic,
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		OutCubic,
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		InOutCubic,
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		InQuint,
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		OutQuint,
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		InOutQuint,
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		InQuart,
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		OutQuart,
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		InOutQuart,
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		InExpo,
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		OutExpo,
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		InOutExpo,
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		Random,
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		RandomNotStep
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x2A12670", Offset = "0x2A11470", VA = "0x182A12670")]
	public static Func<float, float> JGNPAAIGNDD(KDJFOFCLBKA ECGODIPEMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x2A12D30", Offset = "0x2A11B30", VA = "0x182A12D30")]
	public static float OJDKGIBPCAJ(float DDCPKPIHIOM, float KDOOFOADDJE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x2A12510", Offset = "0x2A11310", VA = "0x182A12510")]
	public static float GADINFCLFDG(float DDCPKPIHIOM, float KDOOFOADDJE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x2A12440", Offset = "0x2A11240", VA = "0x182A12440")]
	public static float EAEFNICDJBM(float DDCPKPIHIOM, float KDOOFOADDJE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x2A12300", Offset = "0x2A11100", VA = "0x182A12300")]
	public static float CAFDDMOMBCL(float DDCPKPIHIOM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0")]
	public static float KKBJHANFDOJ(float DDCPKPIHIOM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x2A12550", Offset = "0x2A11350", VA = "0x182A12550")]
	public static float GLGEPIBFEML(float DDCPKPIHIOM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x2A124D0", Offset = "0x2A112D0", VA = "0x182A124D0")]
	public static float FOLNIHDHJBD(float DDCPKPIHIOM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x2A123C0", Offset = "0x2A111C0", VA = "0x182A123C0")]
	public static float DAJLNIFLBFA(float DDCPKPIHIOM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x2A124C0", Offset = "0x2A112C0", VA = "0x182A124C0")]
	public static float EBCIMAOHECJ(float DDCPKPIHIOM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x2A12CB0", Offset = "0x2A11AB0", VA = "0x182A12CB0")]
	public static float NHECECNMNKA(float DDCPKPIHIOM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x2A12D40", Offset = "0x2A11B40", VA = "0x182A12D40")]
	public static float PGOLJFPHCJH(float DDCPKPIHIOM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x2A123B0", Offset = "0x2A111B0", VA = "0x182A123B0")]
	public static float COBGABJLOMK(float DDCPKPIHIOM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x2A12CF0", Offset = "0x2A11AF0", VA = "0x182A12CF0")]
	public static float NHHIHCGCJCN(float DDCPKPIHIOM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x2A12C30", Offset = "0x2A11A30", VA = "0x182A12C30")]
	public static float MBBGHMJOPGG(float DDCPKPIHIOM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x2A12BE0", Offset = "0x2A119E0", VA = "0x182A12BE0")]
	public static float LKPMNFKNHKH(float DDCPKPIHIOM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x2A12BF0", Offset = "0x2A119F0", VA = "0x182A12BF0")]
	public static float LONCDIGFEPB(float DDCPKPIHIOM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x2A12560", Offset = "0x2A11360", VA = "0x182A12560")]
	public static float HGMDNAKGEGF(float DDCPKPIHIOM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x2A125E0", Offset = "0x2A113E0", VA = "0x182A125E0")]
	public static float IMIOFIMJBIA(float DDCPKPIHIOM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x2A12620", Offset = "0x2A11420", VA = "0x182A12620")]
	public static float JDNIICNKBIE(float DDCPKPIHIOM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x2A12320", Offset = "0x2A11120", VA = "0x182A12320")]
	public static float CMKHCCKOFBH(float DDCPKPIHIOM)
	{
		return default(float);
	}
}
namespace RenderHeads.Media.AVProVideo
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public struct HttpHeader
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public string value;

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x2A122C0", Offset = "0x2A110C0", VA = "0x182A122C0")]
		public bool POBAPHEIPOI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x2A120B0", Offset = "0x2A10EB0", VA = "0x182A120B0")]
		public string ELMHAACJLHC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x2A12180", Offset = "0x2A10F80", VA = "0x182A12180")]
		public static bool HCIMLNOEIII(string IMIIGPOLNDC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x2A12250", Offset = "0x2A11050", VA = "0x182A12250")]
		private static bool KKHKHHCKCGI(string IMIIGPOLNDC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x2A12140", Offset = "0x2A10F40", VA = "0x182A12140")]
		private bool HCIMLNOEIII()
		{
			return default(bool);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[DefaultMember("Item")]
	public class HttpHeaderData : IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		[SerializeField]
		private List<HttpHeader> httpHeaders;

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x2A11FA0", Offset = "0x2A10DA0", VA = "0x182A11FA0", Slot = "4")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x2A11DB0", Offset = "0x2A10BB0", VA = "0x182A11DB0")]
		public string ELMHAACJLHC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x2A12020", Offset = "0x2A10E20", VA = "0x182A12020")]
		public HttpHeaderData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class KeyAuthData : ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		[SerializeField]
		public string keyServerToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		[SerializeField]
		[Multiline]
		public string overrideDecryptionKeyBase64;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private byte[] _overrideDecryptionKey;

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public byte[] overrideDecryptionKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x2A130F0", Offset = "0x2A11EF0", VA = "0x182A130F0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public KeyAuthData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class CEPMLAGONFB
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private class PJAPCKJJJCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public RenderTexture JDNNGPGPIOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public long OGDGGANCJIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public bool EHAFMGBMOJF;

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public PJAPCKJJJCL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public enum OKMGENDNIDG
	{
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		POINT,
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		LINEAR
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private List<PJAPCKJJJCL[]> NNABGJIGEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private MediaPlayer EEAEPAMODCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private RenderTexture[] MHIKOBCJAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private int BFLICNFFJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private int GBJMKNCIHGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private int ABDGFOEMCOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private long AFCFCBPLMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private float OPLOKJKNGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private Material EMLBJOMMIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private OKMGENDNIDG IJGAKNADJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private string FBGMEKFLBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private long HNFILCKDPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private int ANLIOMGOMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private long FFLFKCHHIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private int PKEAJOIPJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	private long NNAICJDGJDB;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	private const string NPPGLBHHBAI = "_t";

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	private const string PKFBNPAINFD = "_AfterTex";

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000341")]
	private int EDNABHJDMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000342")]
	private int GEKBHBILPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000343")]
	private float CIJGGLONOCF;

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private float EAOGACLIKFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x160AF60", Offset = "0x1609D60", VA = "0x18160AF60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	private long PKCAENBHIBI
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x2A099C0", Offset = "0x2A087C0", VA = "0x182A099C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public Texture[] COLPIODLAKG
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x2A092E0", Offset = "0x2A080E0", VA = "0x182A092E0")]
	public void IMDKKEKKNHH(MediaPlayer IABBFMOBIIL, MediaPlayerEvent.BALPDIFPDHA FIJBBOMCDKN, DLLKIBIDOAK KAFEFLDOPOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x2A0A000", Offset = "0x2A08E00", VA = "0x182A0A000")]
	public CEPMLAGONFB(MediaPlayer GLMBLPAKFLM, string PFLDDMDPCBI, int HJHGJJAOCMD = 2, OKMGENDNIDG DBGGJPCLBMK = OKMGENDNIDG.LINEAR)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x2A09770", Offset = "0x2A08570", VA = "0x182A09770")]
	public void KNFHOLHMALL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x2A099D0", Offset = "0x2A087D0", VA = "0x182A099D0")]
	public void OJNCHOHBCNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x2A07660", Offset = "0x2A06460", VA = "0x182A07660")]
	private void AEHGDINLMAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x2A08D60", Offset = "0x2A07B60", VA = "0x182A08D60")]
	private void IJFIKEODJEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x2A09A90", Offset = "0x2A08890", VA = "0x182A09A90")]
	private bool ONGCCNJDOJD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x2A08B40", Offset = "0x2A07940", VA = "0x182A08B40")]
	private int IEMGOPMMBND(int DOFBIKGEHIK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x2A09E40", Offset = "0x2A08C40", VA = "0x182A09E40")]
	private int OOBHJLEMFHB(int DOFBIKGEHIK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x2A08810", Offset = "0x2A07610", VA = "0x182A08810")]
	private void FMJIFEGCIOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x2A086B0", Offset = "0x2A074B0", VA = "0x182A086B0")]
	private void CHDGKDCNJCJ(int DOFBIKGEHIK, int LOEGBCPJAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x2A094C0", Offset = "0x2A082C0", VA = "0x182A094C0")]
	private void KMEOAGBJECK(int LOEGBCPJAGN, int OIEPMFCJIEO, int IKFPCHBILHD, float DDCPKPIHIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x2A09790", Offset = "0x2A08590", VA = "0x182A09790")]
	private void KPEBBAKIBPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x2A093C0", Offset = "0x2A081C0", VA = "0x182A093C0")]
	private void KLDJJHIDDFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x2A083F0", Offset = "0x2A071F0", VA = "0x182A083F0")]
	private float BOAKGJACJCE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x2A078B0", Offset = "0x2A066B0", VA = "0x182A078B0")]
	public void AFCEEABIEMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x2A08690", Offset = "0x2A07490", VA = "0x182A08690")]
	public void CELKNPGNDGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class EAEBBCMKIMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public int JJJJBEGKNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public string IMIIGPOLNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public double OBDDAIFKEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public double JKEOFBCIAJE;

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x2A0DAC0", Offset = "0x2A0C8C0", VA = "0x182A0DAC0")]
	public bool LGFEGFDCPLH(double GJEDFMHCPFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public EAEBBCMKIMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public class DGAMCEALAFA
{
	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x2A0A760", Offset = "0x2A09560", VA = "0x182A0A760")]
	private static double FMAINOEGINL(string IMIIGPOLNDC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x2A0A8A0", Offset = "0x2A096A0", VA = "0x182A0A8A0")]
	public static List<EAEBBCMKIMC> JGJBKLMHFAO(string KANAIIDGHCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct FNCEDKJJNKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private string FBGMEKFLBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private int ELMOPHOHMGJ;

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public int FBLHFPABBMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x2A0DAE0", Offset = "0x2A0C8E0", VA = "0x182A0DAE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x2A0DB10", Offset = "0x2A0C910", VA = "0x182A0DB10")]
	public FNCEDKJJNKJ(string PFLDDMDPCBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class PGIPGAFFCGK
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[Flags]
	public enum GAOPMDJCONL
	{
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		Mipmaps = 1,
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		PackedAlpha = 2,
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		StereoLeft = 4,
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		StereoRight = 8,
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		ColorspaceSRGB = 0x10
	}

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly FNCEDKJJNKJ JLPCEBFJLNG;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly FNCEDKJJNKJ EDGKJJDENDL;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly FNCEDKJJNKJ CFFJIBHPIBG;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly FNCEDKJJNKJ ODFLMLOLAKM;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly FNCEDKJJNKJ DKCEPPEBOEI;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly FNCEDKJJNKJ JOLECOBPDIF;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly FNCEDKJJNKJ JCNPJFOECFH;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly FNCEDKJJNKJ PPPKCBPCMOP;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly FNCEDKJJNKJ NPGFMAMOKLD;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly FNCEDKJJNKJ MOCOIHOHEKE;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static string KBAALBJBNDN;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly FNCEDKJJNKJ HOGDPPIAPPF;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly FNCEDKJJNKJ IBLNGHDHDJM;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly FNCEDKJJNKJ PACHMGKDKGD;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly FNCEDKJJNKJ FHCJCIEFEOP;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly FNCEDKJJNKJ MHKGKHCGFAC;

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x2A17330", Offset = "0x2A16130", VA = "0x182A17330")]
	public static Material NEODCGNPMOJ(bool IGCOHIDALIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x2A153A0", Offset = "0x2A141A0", VA = "0x182A153A0")]
	public static void CPIIGJHJHLB(Material GKIFPALLDIK, EFJNCJNHBFH AODPIHLJLMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x2A150F0", Offset = "0x2A13EF0", VA = "0x182A150F0")]
	public static void BBDEFAJOHBH(Material GKIFPALLDIK, AABCGFAHNKC PBPAPEBJCHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x2A15C90", Offset = "0x2A14A90", VA = "0x182A15C90")]
	public static void GOIKBLNHIMI(Material GKIFPALLDIK, EMDBPPLBOLG PBPAPEBJCHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x2A15650", Offset = "0x2A14450", VA = "0x182A15650")]
	public static void FNNFIPAKGAI(Material GKIFPALLDIK, bool AOPLDNAIHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x2A173D0", Offset = "0x2A161D0", VA = "0x182A173D0")]
	public static void OLEHDGOJEJC(Material GKIFPALLDIK, Matrix4x4 DNNOOFELIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x2A155A0", Offset = "0x2A143A0", VA = "0x182A155A0")]
	public static void EKNLPLELEEJ(Material GKIFPALLDIK, bool PDDENJEIIGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x2A15440", Offset = "0x2A14240", VA = "0x182A15440")]
	public static Texture ECMMLGHLGAO(MediaPlayer JOIFCBAGHAJ, int MPPJJLKAMNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x2A156E0", Offset = "0x2A144E0", VA = "0x182A156E0")]
	public static void GIFBKANBEHP(Material GKIFPALLDIK, MediaPlayer JOIFCBAGHAJ, int CPFFNEFDDJD = -1, [Optional] Texture KJCMKCJAPOL, bool LDPCCANGEFG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x2A169E0", Offset = "0x2A157E0", VA = "0x182A169E0")]
	internal static void KFHEIAHFDAE(Material GKIFPALLDIK, bool KKCGCOHIJCN, bool AOPLDNAIHED, Matrix4x4 EKCDLIFPOPJ, Texture OLAPIAFPEFD, Matrix4x4 GFHAIDAKHAK, EFJNCJNHBFH AODPIHLJLMH = EFJNCJNHBFH.Normal, AABCGFAHNKC BOJDODIDDAF = AABCGFAHNKC.None, EMDBPPLBOLG AHAAOHOKJIJ = EMDBPPLBOLG.None)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x2A16EE0", Offset = "0x2A15CE0", VA = "0x182A16EE0")]
	public static void KKBDFHCPECB(Material GKIFPALLDIK, VideoResolveOptions PMEODJMCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x2A15DD0", Offset = "0x2A14BD0", VA = "0x182A15DD0")]
	public static RenderTexture IMNDHHJJDOC(Material IBLBCJHBJEF, RenderTexture IJMODPINCHF, NMPLAHIBBEO JDNNGPGPIOL, GAOPMDJCONL AEDIGFLCOAJ, ScaleMode HCFJHCNMPCC = ScaleMode.StretchToFill)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x2A171B0", Offset = "0x2A15FB0", VA = "0x182A171B0")]
	public static void MLHCAHDFJBE(EMDBPPLBOLG AHAAOHOKJIJ, AABCGFAHNKC BOJDODIDDAF, BIHFCBEIMJA BDPGNKDECAK, float HMBNMLLKJEK, Matrix4x4 JEIKHFIEHCJ, int FIJCBEGFDBD, int HBJICDOMHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x2A163C0", Offset = "0x2A151C0", VA = "0x182A163C0")]
	public static void JGKMEOCNHMP(Rect LLKMKFKDELJ, Texture JDNNGPGPIOL, ScaleMode HCFJHCNMPCC, EMDBPPLBOLG AHAAOHOKJIJ, float HMBNMLLKJEK, Material GKIFPALLDIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public enum HPMLCCBLIBH
{
	[Cpp2IlInjected.Token(Token = "0x4000367")]
	SDR,
	[Cpp2IlInjected.Token(Token = "0x4000368")]
	HLG,
	[Cpp2IlInjected.Token(Token = "0x4000369")]
	PQ
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public enum MGEFNECFKJN : uint
{
	[Cpp2IlInjected.Token(Token = "0x400036B")]
	ac_3 = 1633889587u,
	[Cpp2IlInjected.Token(Token = "0x400036C")]
	alac = 1634492771u,
	[Cpp2IlInjected.Token(Token = "0x400036D")]
	avc1 = 1635148593u,
	[Cpp2IlInjected.Token(Token = "0x400036E")]
	avc3 = 1635148595u,
	[Cpp2IlInjected.Token(Token = "0x400036F")]
	dvh1 = 1685481521u,
	[Cpp2IlInjected.Token(Token = "0x4000370")]
	dvhe = 1685481573u,
	[Cpp2IlInjected.Token(Token = "0x4000371")]
	ec_3 = 1700998451u,
	[Cpp2IlInjected.Token(Token = "0x4000372")]
	fLaC = 1716281667u,
	[Cpp2IlInjected.Token(Token = "0x4000373")]
	hev1 = 1751479857u,
	[Cpp2IlInjected.Token(Token = "0x4000374")]
	hvc1 = 1752589105u,
	[Cpp2IlInjected.Token(Token = "0x4000375")]
	mjpg = 1835692135u,
	[Cpp2IlInjected.Token(Token = "0x4000376")]
	mp4a = 1836069985u,
	[Cpp2IlInjected.Token(Token = "0x4000377")]
	stpp = 1937010800u,
	[Cpp2IlInjected.Token(Token = "0x4000378")]
	wvtt = 2004251764u,
	[Cpp2IlInjected.Token(Token = "0x4000379")]
	unknown = 0u
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class ALBFPNCIJIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400037A")]
	private int GOGFLNOELNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400037B")]
	private int HCKEJHABDBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400037C")]
	private int BECEIJAKNMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400037D")]
	private int OJCHIOGEDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400037E")]
	private int ECPLKHJHOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400037F")]
	private MGEFNECFKJN HCELPDGMAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000380")]
	private float ILHCNLDDNIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000381")]
	private HPMLCCBLIBH IAIJCIMOEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000382")]
	private MGEFNECFKJN OGMBMGCGLMM;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	private static ALBFPNCIJIA EBDDCBAMFDL;

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x2A02510", Offset = "0x2A01310", VA = "0x182A02510")]
	public ALBFPNCIJIA(int IGAGEGNALKK, int KIJFBKMOEPO, int LDAOJGCJKCM, int DOLAKGCBBFC, int FNFKKOMPIGD = 0, MGEFNECFKJN JJIAGFILPKD = MGEFNECFKJN.unknown, float IFGAJONKNBD = 0f, HPMLCCBLIBH LOHBJGMJBLN = HPMLCCBLIBH.SDR, MGEFNECFKJN EMOLDGBGNBJ = MGEFNECFKJN.unknown)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[DefaultMember("Item")]
public interface LCLFIFJNIDK : IEnumerable
{
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
