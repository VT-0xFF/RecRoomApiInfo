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
	public Material OCAHEHKLJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2A7A5F0", Offset = "0x2A78FF0", VA = "0x182A7A5F0")]
	private void OnWillRenderObject()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
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
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public MediaPath MediaPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public MediaHints Hints
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x16B7AA0", Offset = "0x16B64A0", VA = "0x1816B7AA0")]
			get
			{
				return default(MediaHints);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x2A896C0", Offset = "0x2A880C0", VA = "0x182A896C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2A894E0", Offset = "0x2A87EE0", VA = "0x182A894E0")]
		public MediaReference DHDKAMAOHEJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2A89550", Offset = "0x2A87F50", VA = "0x182A89550")]
		public MediaReference NKHAHKHMJFC(MAPINHBEDKP OCEOABGJOBL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2A895E0", Offset = "0x2A87FE0", VA = "0x182A895E0")]
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
		private enum PGEBJJBDFJO
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
		private GameObject CGCBIJCFKOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool LFCNEIOPFLL;

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
		private Texture FPMCBOCAHLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private OIGDOFJJJDO AAJJHDJCELJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private OIGDOFJJJDO MPNNCEEFJBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private Texture DNFAJKDFKNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Vector2 JKFNADOBNAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Vector2 OFGMDODNOIG;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Color PJHAFNEJJEP
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xF84360", Offset = "0xF82D60", VA = "0x180F84360")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x2A7C100", Offset = "0x2A7AB00", VA = "0x182A7C100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Texture DOODMBFAKHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2A7C350", Offset = "0x2A7AD50", VA = "0x182A7C350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Texture NNFFPABFKHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xAB5A70", Offset = "0xAB4470", VA = "0x180AB5A70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2A7BDF0", Offset = "0x2A7A7F0", VA = "0x182A7BDF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float IKPLLGAABLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x12CD6A0", Offset = "0x12CC0A0", VA = "0x1812CD6A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2A7BC70", Offset = "0x2A7A670", VA = "0x182A7BC70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Camera AMAFDKGJECI
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xAB4840", Offset = "0xAB3240", VA = "0x180AB4840")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2A7BD20", Offset = "0x2A7A720", VA = "0x182A7BD20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public VideoAspectRatio DJFFDHPMAEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xD71C20", Offset = "0xD70620", VA = "0x180D71C20")]
			get
			{
				return default(VideoAspectRatio);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x2A7C410", Offset = "0x2A7AE10", VA = "0x182A7C410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Vector2 ILKDGJFDGEC
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2A7BC10", Offset = "0x2A7A610", VA = "0x182A7BC10")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2A7C020", Offset = "0x2A7AA20", VA = "0x182A7C020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Vector2 NFOMAIBIIFM
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x12CD6B0", Offset = "0x12CC0B0", VA = "0x1812CD6B0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2A7BEB0", Offset = "0x2A7A8B0", VA = "0x182A7BEB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Texture2D LMENDGHLPIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B50", Offset = "0xAB6550", VA = "0x180AB7B50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x2A7BF90", Offset = "0x2A7A990", VA = "0x182A7BF90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public string ADGEEJFFIDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xAB7A80", Offset = "0xAB6480", VA = "0x180AB7A80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2A7C260", Offset = "0x2A7AC60", VA = "0x182A7C260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Vector2 MMNMLIHNLBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2A7BC30", Offset = "0x2A7A630", VA = "0x182A7BC30")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2A7C1C0", Offset = "0x2A7ABC0", VA = "0x182A7C1C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Vector2 JHKBPPBGAJM
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2A7BC50", Offset = "0x2A7A650", VA = "0x182A7BC50")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x2A7C210", Offset = "0x2A7AC10", VA = "0x182A7C210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private Vector2 BLNEPJFLPNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x2A7A520", Offset = "0x2A78F20", VA = "0x182A7A520")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2A7A1F0", Offset = "0x2A78BF0", VA = "0x182A7A1F0")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2A7B250", Offset = "0x2A79C50", VA = "0x182A7B250", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2A7B200", Offset = "0x2A79C00", VA = "0x182A7B200")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2A7B8E0", Offset = "0x2A7A2E0", VA = "0x182A7B8E0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2A7A800", Offset = "0x2A79200", VA = "0x182A7A800")]
		public Mesh CreateQuadMesh()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2A7A6A0", Offset = "0x2A790A0", VA = "0x182A7A6A0")]
		public void CreateMaterial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2A7B320", Offset = "0x2A79D20", VA = "0x182A7B320", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xB11430", Offset = "0xB0FE30", VA = "0x180B11430")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2A7B620", Offset = "0x2A7A020", VA = "0x182A7B620")]
		public void UpdateMaterialProperties(int JFBLIPHGGPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2A79CB0", Offset = "0x2A786B0", VA = "0x182A79CB0", Slot = "8")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2A7AB90", Offset = "0x2A79590", VA = "0x182A7AB90")]
		private void EAAFBJIAKBB(Texture JBOOEIGKOID, bool FPLECIAJHIB, int DHOBCGOKNFP = 0, PGEBJJBDFJO OGFIDCBJACA = PGEBJJBDFJO.Left)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2A7A2E0", Offset = "0x2A78CE0", VA = "0x182A7A2E0", Slot = "6")]
		protected override void BKBEGLKMLPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2A7B060", Offset = "0x2A79A60", VA = "0x182A7B060", Slot = "7")]
		protected override void EBFIPMDAJNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2A7BA90", Offset = "0x2A7A490", VA = "0x182A7BA90")]
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
		private enum HNGHIEKHABI
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
		private Texture FPMCBOCAHLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private OIGDOFJJJDO AAJJHDJCELJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private OIGDOFJJJDO MPNNCEEFJBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private Texture DNFAJKDFKNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private Vector2 JKFNADOBNAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private Vector2 OFGMDODNOIG;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Texture2D LMENDGHLPIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x2A7D300", Offset = "0x2A7BD00", VA = "0x182A7D300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Material OCAHEHKLJJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x2A7D380", Offset = "0x2A7BD80", VA = "0x182A7D380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string ADGEEJFFIDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x2A7D4A0", Offset = "0x2A7BEA0", VA = "0x182A7D4A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector2 MMNMLIHNLBN
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x2A7D2C0", Offset = "0x2A7BCC0", VA = "0x182A7D2C0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x2A7D400", Offset = "0x2A7BE00", VA = "0x182A7D400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Vector2 JHKBPPBGAJM
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x2A7D2E0", Offset = "0x2A7BCE0", VA = "0x182A7D2E0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x2A7D450", Offset = "0x2A7BE50", VA = "0x182A7D450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xB11430", Offset = "0xB0FE30", VA = "0x180B11430")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2A7C4C0", Offset = "0x2A7AEC0", VA = "0x182A7C4C0", Slot = "8")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2A7CBE0", Offset = "0x2A7B5E0", VA = "0x182A7CBE0")]
		private void EAAFBJIAKBB(Texture JBOOEIGKOID, bool FPLECIAJHIB, int DHOBCGOKNFP = 0, HNGHIEKHABI OGFIDCBJACA = HNGHIEKHABI.Left)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2A7C9E0", Offset = "0x2A7B3E0", VA = "0x182A7C9E0", Slot = "6")]
		protected override void BKBEGLKMLPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2A7CFF0", Offset = "0x2A7B9F0", VA = "0x182A7CFF0", Slot = "7")]
		protected override void EBFIPMDAJNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D160", Offset = "0x2A7BB60", VA = "0x182A7D160")]
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
		private enum KPHHMDOHDEE
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
		private Texture FPMCBOCAHLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private OIGDOFJJJDO AAJJHDJCELJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private OIGDOFJJJDO MPNNCEEFJBF;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Texture2D LMENDGHLPIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x2A7E100", Offset = "0x2A7CB00", VA = "0x182A7E100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Renderer IPIJLGJBILK
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x2A7DAF0", Offset = "0x2A7C4F0", VA = "0x182A7DAF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public int KAFKAFJHFCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xB2EC70", Offset = "0xB2D670", VA = "0x180B2EC70")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xB2EDB0", Offset = "0xB2D7B0", VA = "0x180B2EDB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public string ADGEEJFFIDB
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xAB5A70", Offset = "0xAB4470", VA = "0x180AB5A70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x2A7E470", Offset = "0x2A7CE70", VA = "0x182A7E470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector2 MMNMLIHNLBN
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x2A7D2E0", Offset = "0x2A7BCE0", VA = "0x182A7D2E0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x2A7D450", Offset = "0x2A7BE50", VA = "0x182A7D450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector2 JHKBPPBGAJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x2A7E400", Offset = "0x2A7CE00", VA = "0x182A7E400")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x2A7E420", Offset = "0x2A7CE20", VA = "0x182A7E420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2A7E100", Offset = "0x2A7CB00", VA = "0x182A7E100")]
		private void HLPJBMHFFPL(Texture2D JBOOEIGKOID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2A7DAF0", Offset = "0x2A7C4F0", VA = "0x182A7DAF0")]
		private void BDPKGOAAOFF(Renderer ALKNEOONPNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xB11430", Offset = "0xB0FE30", VA = "0x180B11430")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D570", Offset = "0x2A7BF70", VA = "0x182A7D570", Slot = "8")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2A7DC70", Offset = "0x2A7C670", VA = "0x182A7DC70")]
		private void EAAFBJIAKBB(Texture JBOOEIGKOID, bool FPLECIAJHIB, int DHOBCGOKNFP, KPHHMDOHDEE OGFIDCBJACA = KPHHMDOHDEE.Left, int EMJCACMKDGG = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2A7E1E0", Offset = "0x2A7CBE0", VA = "0x182A7E1E0", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2A7E1B0", Offset = "0x2A7CBB0", VA = "0x182A7E1B0", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2A7DBD0", Offset = "0x2A7C5D0", VA = "0x182A7DBD0", Slot = "6")]
		protected override void BKBEGLKMLPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2A7E320", Offset = "0x2A7CD20", VA = "0x182A7E320")]
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
		private const int NOBJLDFPIJN = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[Range(0f, 1f)]
		[SerializeField]
		private float[] _channels;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float[] FJEIABBLJCE
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2A7E7F0", Offset = "0x2A7D1F0", VA = "0x182A7E7F0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2A7E540", Offset = "0x2A7CF40", VA = "0x182A7E540")]
		private void HECKJHLCOLG(int CFIOLAIGPDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2A7E640", Offset = "0x2A7D040", VA = "0x182A7E640")]
		private void OnAudioFilterRead(float[] BLPDDGCLNPE, int MCAKEJBBCAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
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
		public enum OBFAHBDOFIO
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
		private OBFAHBDOFIO _audioOutputMode;

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
		private int AAJPMIONGHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private AudioSource OJPNHKLDPOE;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public MediaPlayer BFPLOHOCBOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2A7F370", Offset = "0x2A7DD70", VA = "0x182A7F370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public OBFAHBDOFIO PNMFBCABLHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xB0E380", Offset = "0xB0CD80", VA = "0x180B0E380")]
			get
			{
				return default(OBFAHBDOFIO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xB0D970", Offset = "0xB0C370", VA = "0x180B0D970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int JHHNLGEDHMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xC5E970", Offset = "0xC5D370", VA = "0x180C5E970")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x10BA490", Offset = "0x10B8E90", VA = "0x1810BA490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2A7E880", Offset = "0x2A7D280", VA = "0x182A7E880")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2A7F1E0", Offset = "0x2A7DBE0", VA = "0x182A7F1E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2A7EDB0", Offset = "0x2A7D7B0", VA = "0x182A7EDB0")]
		private void DLFAOPLANEN(bool KNIEHHHDKEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2A7F130", Offset = "0x2A7DB30", VA = "0x182A7F130")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2A7F270", Offset = "0x2A7DC70", VA = "0x182A7F270")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		public AudioSource GetAudioSource()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2A7F140", Offset = "0x2A7DB40", VA = "0x182A7F140")]
		public void SetAudioSource(AudioSource PBOCDEMNFLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2A7E8D0", Offset = "0x2A7D2D0", VA = "0x182A7E8D0")]
		public void ChangeMediaPlayer(MediaPlayer PEEGJOGDPIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2A7EE90", Offset = "0x2A7D890", VA = "0x182A7EE90")]
		private void GBPFINLHGGH(MediaPlayer IBNLHPFFIEL, MediaPlayerEvent.OPGAEJDGMGO DBMNAJLECLK, GHCKFLJBDJH NGDAMNDJLIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2A7EEF0", Offset = "0x2A7D8F0", VA = "0x182A7EEF0")]
		private static void HIGHLHAFNKD(MediaPlayer BLHNDOLLIDD, AudioSource FNBEJKIAEFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2A7F0B0", Offset = "0x2A7DAB0", VA = "0x182A7F0B0")]
		private void OnAudioFilterRead(float[] AOPHCOCAFFL, int MCJPLGCDCKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2A7F350", Offset = "0x2A7DD50", VA = "0x182A7F350")]
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
		private static Shader CMPGAOAGFBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private Material NPMNFMAPBPG;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public MediaPlayer BFPLOHOCBOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x2A80160", Offset = "0x2A7EB60", VA = "0x182A80160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public ScaleMode GBAKIHONPBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xB0E380", Offset = "0xB0CD80", VA = "0x180B0E380")]
			get
			{
				return default(ScaleMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xB0D970", Offset = "0xB0C370", VA = "0x180B0D970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Color JCMKCPCHLFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xECFB90", Offset = "0xECE590", VA = "0x180ECFB90")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x10D0D90", Offset = "0x10CF790", VA = "0x1810D0D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool PDNJMMEODJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xF2C990", Offset = "0xF2B390", VA = "0x180F2C990")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xF46860", Offset = "0xF45260", VA = "0x180F46860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool NBMABGEGCMI
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xF46590", Offset = "0xF44F90", VA = "0x180F46590")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xF46440", Offset = "0xF44E40", VA = "0x180F46440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public int NODBBMMLICD
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xACB3E0", Offset = "0xAC9DE0", VA = "0x180ACB3E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xEFC730", Offset = "0xEFB130", VA = "0x180EFC730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool BNKPEEOPKDG
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xFEB810", Offset = "0xFEA210", VA = "0x180FEB810")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xFEB700", Offset = "0xFEA100", VA = "0x180FEB700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float PGNBJAHIPDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xD84490", Offset = "0xD82E90", VA = "0x180D84490")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xD84650", Offset = "0xD83050", VA = "0x180D84650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public float CDLEEJJNGKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xE96F40", Offset = "0xE95940", VA = "0x180E96F40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x1CF6920", Offset = "0x1CF5320", VA = "0x181CF6920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float BPHJIEPGAEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xAFE5D0", Offset = "0xAFCFD0", VA = "0x180AFE5D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x10B3AB0", Offset = "0x10B24B0", VA = "0x1810B3AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float PJOJNJBGEGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xF562B0", Offset = "0xF54CB0", VA = "0x180F562B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xF562C0", Offset = "0xF54CC0", VA = "0x180F562C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool BGEPONEDMFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xB2F7F0", Offset = "0xB2E1F0", VA = "0x180B2F7F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xB2F850", Offset = "0xB2E250", VA = "0x180B2F850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2A7FE00", Offset = "0x2A7E800", VA = "0x182A7FE00")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2A7FF40", Offset = "0x2A7E940", VA = "0x182A7FF40")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2A7F6B0", Offset = "0x2A7E0B0", VA = "0x182A7F6B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2A7F380", Offset = "0x2A7DD80", VA = "0x182A7F380")]
		private Shader BGFKEDHGIOO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2A7F500", Offset = "0x2A7DF00", VA = "0x182A7F500")]
		private void JOEBPBIBJIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2A7F750", Offset = "0x2A7E150", VA = "0x182A7F750")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2A7F3C0", Offset = "0x2A7DDC0", VA = "0x182A7F3C0")]
		public Rect GetAreaRect()
		{
			return default(Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2A80130", Offset = "0x2A7EB30", VA = "0x182A80130")]
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
		public delegate void MGFDIOLEODH(Texture2D CLAAMPOGJHO);

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public class PlatformOptions
		{
			[Cpp2IlInjected.Token(Token = "0x2000011")]
			public enum JMCOJGFIDLM
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
			public enum IMIPBCMHEPL
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
			public enum KJNLCLBELJH
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
			public enum BJNHHAFHKPE
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
			[Cpp2IlInjected.Address(RVA = "0x2A8A740", Offset = "0x2A89140", VA = "0x182A8A740", Slot = "4")]
			public virtual string HFAENLEFOEE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xFA7D10", Offset = "0xFA6710", VA = "0x180FA7D10", Slot = "5")]
			public virtual byte[] OOPGJEFKBHJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "6")]
			public virtual bool GHIGIPNOEBF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x2A8A760", Offset = "0x2A89160", VA = "0x182A8A760")]
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
			public MGGAHIBDKHJ.AHCHGFBGJFF videoApi;

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
			public MGGAHIBDKHJ.FCODHMFKNCI _audioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public BBFMIMIONBN audio360ChannelMode;

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
			[Cpp2IlInjected.Address(RVA = "0xDB85A0", Offset = "0xDB6FA0", VA = "0x180DB85A0", Slot = "6")]
			public override bool GHIGIPNOEBF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "7")]
			void ISerializationCallbackReceiver.OnBeforeSerialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x2A89920", Offset = "0x2A88320", VA = "0x182A89920", Slot = "8")]
			void ISerializationCallbackReceiver.OnAfterDeserialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x2A89950", Offset = "0x2A88350", VA = "0x182A89950")]
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
			public OKDJKCAIGNG.KNOKJCIFJII videoApi;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public OKDJKCAIGNG.EBJBCFMJKGH _audioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public BBFMIMIONBN audio360ChannelMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public bool startWithHighestBitrate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public bool useLowLiveLatency;

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0xF2C990", Offset = "0xF2B390", VA = "0x180F2C990", Slot = "6")]
			public override bool GHIGIPNOEBF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x2A89900", Offset = "0x2A88300", VA = "0x182A89900")]
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
			public enum PNDAPPOAPKE
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
			public enum EOFEJDLIGMC
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
			private readonly JMCOJGFIDLM DefaultTextureFormat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			private readonly PNDAPPOAPKE DefaultFlags;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public JMCOJGFIDLM textureFormat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private KJNLCLBELJH _previousAudioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			[SerializeField]
			private KJNLCLBELJH _audioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			[SerializeField]
			private PNDAPPOAPKE _flags;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public float maximumPlaybackRate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private EOFEJDLIGMC _changed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			[SerializeField]
			private float _preferredPeakBitRate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			[SerializeField]
			private BJNHHAFHKPE _preferredPeakBitRateUnits;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			[SerializeField]
			private double _preferredForwardBufferDuration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			[SerializeField]
			private IMIPBCMHEPL _preferredMaximumResolution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			[SerializeField]
			private Vector2Int _customPreferredMaximumResolution;

			[Cpp2IlInjected.Token(Token = "0x17000064")]
			public KJNLCLBELJH audioMode
			{
				[Cpp2IlInjected.Token(Token = "0x6000144")]
				[Cpp2IlInjected.Address(RVA = "0x2A89850", Offset = "0x2A88250", VA = "0x182A89850")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000065")]
			public PNDAPPOAPKE flags
			{
				[Cpp2IlInjected.Token(Token = "0x6000145")]
				[Cpp2IlInjected.Address(RVA = "0x2A89870", Offset = "0x2A88270", VA = "0x182A89870")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x2A897A0", Offset = "0x2A881A0", VA = "0x182A897A0")]
			public OptionsApple(JMCOJGFIDLM OPDDFCFBJHC, PNDAPPOAPKE AJFNAFICICO)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public class OptionsAndroid : PlatformOptions, ISerializationCallbackReceiver
		{
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			[Flags]
			public enum LCHILDIKLJB
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
			private LCHILDIKLJB _changed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private readonly JMCOJGFIDLM DefaultTextureFormat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public JMCOJGFIDLM textureFormat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			[SerializeField]
			private bool _generateMipmaps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			private KJNLCLBELJH _previousAudioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			[SerializeField]
			private KJNLCLBELJH _audioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			[SerializeField]
			private IMIPBCMHEPL _preferredMaximumResolution;

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
			private BJNHHAFHKPE _preferredPeakBitRateUnits;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public CFIIODKOJGC.OBDLBMMMIHK videoApi;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public bool showPosterFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public BBFMIMIONBN audio360ChannelMode;

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
			public KJNLCLBELJH audioMode
			{
				[Cpp2IlInjected.Token(Token = "0x6000147")]
				[Cpp2IlInjected.Address(RVA = "0xAEE7D0", Offset = "0xAED1D0", VA = "0x180AEE7D0")]
				get
				{
					return default(KJNLCLBELJH);
				}
				[Cpp2IlInjected.Token(Token = "0x6000148")]
				[Cpp2IlInjected.Address(RVA = "0x2A89780", Offset = "0x2A88180", VA = "0x182A89780")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xABA8F0", Offset = "0xAB92F0", VA = "0x180ABA8F0", Slot = "6")]
			public override bool GHIGIPNOEBF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "7")]
			void ISerializationCallbackReceiver.OnBeforeSerialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x2A896D0", Offset = "0x2A880D0", VA = "0x182A896D0", Slot = "8")]
			void ISerializationCallbackReceiver.OnAfterDeserialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x2A89700", Offset = "0x2A88100", VA = "0x182A89700")]
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
			public enum KHIKFMGJFIO
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
			private KHIKFMGJFIO _changed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			private readonly JMCOJGFIDLM DefaultTextureFormat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public JMCOJGFIDLM textureFormat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			[SerializeField]
			private bool _generateMipmapsOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private KJNLCLBELJH _previousAudioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			[SerializeField]
			private KJNLCLBELJH _audioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			[SerializeField]
			private IMIPBCMHEPL _preferredMaximumResolution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			[SerializeField]
			private Vector2Int _customPreferredMaximumResolution;

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "7")]
			void ISerializationCallbackReceiver.OnBeforeSerialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "8")]
			void ISerializationCallbackReceiver.OnAfterDeserialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x2A898A0", Offset = "0x2A882A0", VA = "0x182A898A0")]
			public OptionsOpenHarmony()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public class OptionsWebGL : PlatformOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			public enum JGNELLKFDBO
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
			private JGNELLKFDBO _changed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public OMCEGMCCEJG.COOCNEDJIJC externalLibrary;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public bool useTextureMips;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			private KJNLCLBELJH _previousAudioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			[SerializeField]
			private KJNLCLBELJH _audioMode;

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "4")]
			public override string HFAENLEFOEE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "5")]
			public override byte[] OOPGJEFKBHJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x2A898F0", Offset = "0x2A882F0", VA = "0x182A898F0")]
			public OptionsWebGL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private enum FDELEHKLLDA
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
		private sealed class HFAHEPFLECO : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
			[DebuggerHidden]
			public HFAHEPFLECO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x2A81E40", Offset = "0x2A80840", VA = "0x182A81E40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x2A81F40", Offset = "0x2A80940", VA = "0x182A81F40", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class HPODCFLJGGE : IEnumerator<object>, IEnumerator, IDisposable
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
			public MGFDIOLEODH callback;

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
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
			[DebuggerHidden]
			public HPODCFLJGGE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x2A81F90", Offset = "0x2A80990", VA = "0x182A81F90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x2A824A0", Offset = "0x2A80EA0", VA = "0x182A824A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class AOBHHCHMGLH : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
			[DebuggerHidden]
			public AOBHHCHMGLH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x2A796D0", Offset = "0x2A780D0", VA = "0x182A796D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x2A79940", Offset = "0x2A78340", VA = "0x182A79940", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		private NCHLKIPGCLF _mediaSource;

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
		private AudioSource OJPNHKLDPOE;

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
		private FMKCEIIHLNJ.BNHCKNCEMNF _resampleMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Range(3f, 10f)]
		[SerializeField]
		[FormerlySerializedAs("m_ResampleBufferSize")]
		private int _resampleBufferSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private FMKCEIIHLNJ LOHGCCHEANM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		[FormerlySerializedAs("m_videoMapping")]
		private GEPIBILIAMH _videoMapping;

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
		private OCMKEPJKDIM _forceFileFormat;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		protected GABHJLCHGNK ENDBLCPLFDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private KEBKGACMKPD IFDFBHJEAPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private LDFGOJKCIJG JIEPJBPDOEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private HGPLPFAPJHK BPMPHFBOABD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private EGFHCLGHIGN DBFDDBIMIEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private FIJPNHDDIHB OJDFOBHENFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private KDONLKGEIHO HGPBECPKBOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private BAEGDPICBGL JOMGKFEOIDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private HODDBBEOBGJ GKGGEILFOFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private DJMENNNFNHN GAHILGAJGGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private LDMNOMMHDFN IDKCPKAOLCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private IDisposable IAHEKFHDNLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private bool HLKBCOGELGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x139")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private bool NFGKKFADOMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13A")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private bool GAPJFEALHLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private Coroutine PNLOKKPEOCD;

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private static bool EOLBKCFHCMM;

		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private static bool JGKNEFBNOBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private MediaPath ECBNAIPLLBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private Coroutine BLCHBABELIB;

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static Camera ACPHMNCMCGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private bool JPOBMNFHGHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private bool EFIOFMOOKMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15A")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private bool APMDPBLGBHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15B")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private bool GPBLGFDCBHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private bool OAIFBAIDJNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15D")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private bool KIOIJBBIPDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15E")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private bool CBHLNPJJDFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15F")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private bool GFPHDGNOGJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private int ENNIKKCDEPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private int KHOONONGLOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private int JIDMOKKJPAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private bool IMADEMBFEEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16D")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private bool JILADHDEKOM;

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
		private FDELEHKLLDA m_VideoLocation;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public NCHLKIPGCLF BLJGOLBGMLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20")]
			get
			{
				return default(NCHLKIPGCLF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xAB33F0", Offset = "0xAB1DF0", VA = "0x180AB33F0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public MediaReference DOBHLGGGCBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MediaPath MAGBHFBLKOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public MediaHints HDNDPCNJGPL
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x1223400", Offset = "0x1221E00", VA = "0x181223400")]
			get
			{
				return default(MediaHints);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x22AACF0", Offset = "0x22A96F0", VA = "0x1822AACF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool KKMJJFBBHCM
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xFEB810", Offset = "0xFEA210", VA = "0x180FEB810")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xFEB700", Offset = "0xFEA100", VA = "0x180FEB700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool PCKPBLCAOCO
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xFEB7F0", Offset = "0xFEA1F0", VA = "0x180FEB7F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xFEB0F0", Offset = "0xFE9AF0", VA = "0x180FEB0F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool BHPLFHIBEDC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x2A88C50", Offset = "0x2A87650", VA = "0x182A88C50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x2A89180", Offset = "0x2A87B80", VA = "0x182A89180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public virtual float JPMMDOLAMEB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x2A88AE0", Offset = "0x2A874E0", VA = "0x182A88AE0", Slot = "6")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x2A89100", Offset = "0x2A87B00", VA = "0x182A89100", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float HMFEEGKCMHK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x2A88A20", Offset = "0x2A87420", VA = "0x182A88A20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x2A89010", Offset = "0x2A87A10", VA = "0x182A89010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public virtual bool MGJGLDLNDHN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x2A88A80", Offset = "0x2A87480", VA = "0x182A88A80", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x2A89090", Offset = "0x2A87A90", VA = "0x182A89090", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public AudioSource MHDBMCIEGLA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xAB4860", Offset = "0xAB3260", VA = "0x180AB4860")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xAB4880", Offset = "0xAB3280", VA = "0x180AB4880")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float HPAEDCDGGPA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2A88CE0", Offset = "0x2A876E0", VA = "0x182A88CE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x2A89220", Offset = "0x2A87C20", VA = "0x182A89220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool EKADLCPIALM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x1F1ECE0", Offset = "0x1F1D6E0", VA = "0x181F1ECE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x18D8440", Offset = "0x18D6E40", VA = "0x1818D8440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public FMKCEIIHLNJ.BNHCKNCEMNF LBFHOPHNIPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xD71C20", Offset = "0xD70620", VA = "0x180D71C20")]
			get
			{
				return default(FMKCEIIHLNJ.BNHCKNCEMNF);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x145F120", Offset = "0x145DB20", VA = "0x18145F120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public int NMAAMKDFIGB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x1027570", Offset = "0x1025F70", VA = "0x181027570")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x2A89290", Offset = "0x2A87C90", VA = "0x182A89290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public FMKCEIIHLNJ DMLMPEAJMHI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xAB4870", Offset = "0xAB3270", VA = "0x180AB4870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public GEPIBILIAMH KNHAIGKILJB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xAD4A70", Offset = "0xAD3470", VA = "0x180AD4A70")]
			get
			{
				return default(GEPIBILIAMH);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x1618FE0", Offset = "0x16179E0", VA = "0x181618FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public FilterMode CMAJCPKCDKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x2A88E30", Offset = "0x2A87830", VA = "0x182A88E30")]
			get
			{
				return default(FilterMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x2A89310", Offset = "0x2A87D10", VA = "0x182A89310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public TextureWrapMode FOEDGONLIDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x2A88F20", Offset = "0x2A87920", VA = "0x182A88F20")]
			get
			{
				return default(TextureWrapMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x2A89380", Offset = "0x2A87D80", VA = "0x182A89380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public int AMHIGNMBGBG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x2A88D40", Offset = "0x2A87740", VA = "0x182A88D40")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x2A892A0", Offset = "0x2A87CA0", VA = "0x182A892A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool DGKEMGDHDAC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xD54F60", Offset = "0xD53960", VA = "0x180D54F60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xE218E0", Offset = "0xE202E0", VA = "0x180E218E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public MediaPath KMIKCLBPHNO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B50", Offset = "0xAB6550", VA = "0x180AB7B50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xAB7AD0", Offset = "0xAB64D0", VA = "0x180AB7AD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public Transform LIELKPDKHCK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xB2F7C0", Offset = "0xB2E1C0", VA = "0x180B2F7C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xB79800", Offset = "0xB78200", VA = "0x180B79800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool MBINLDFPOGE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xFEB740", Offset = "0xFEA140", VA = "0x180FEB740")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xFEB720", Offset = "0xFEA120", VA = "0x180FEB720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public Transform GLDMPEHEENG
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xB79620", Offset = "0xB78020", VA = "0x180B79620")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xB795D0", Offset = "0xB77FD0", VA = "0x180B795D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public float CMMEIOINDOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x1FF6B10", Offset = "0x1FF5510", VA = "0x181FF6B10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x1FF6C70", Offset = "0x1FF5670", VA = "0x181FF6C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public float AJDGMCEKFEG
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x1DB7690", Offset = "0x1DB6090", VA = "0x181DB7690")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x1FF6B20", Offset = "0x1FF5520", VA = "0x181FF6B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public HttpHeaderData NFCBPNPKCCL
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0xB793D0", Offset = "0xB77DD0", VA = "0x180B793D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xB795F0", Offset = "0xB77FF0", VA = "0x180B795F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public KeyAuthData JKDIEFCDCJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xEE2960", Offset = "0xEE1360", VA = "0x180EE2960")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xEE2970", Offset = "0xEE1370", VA = "0x180EE2970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public MediaPlayerEvent NNGKKHHDLED
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x2A88B40", Offset = "0x2A87540", VA = "0x182A88B40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public int LELIHMOMPHI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x1005710", Offset = "0x1004110", VA = "0x181005710")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x1005720", Offset = "0x1004120", VA = "0x181005720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public bool GBBJOKJPKNA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x2A88CB0", Offset = "0x2A876B0", VA = "0x182A88CB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x2A891F0", Offset = "0x2A87BF0", VA = "0x182A891F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool JFMLAMOAPID
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x2A88CD0", Offset = "0x2A876D0", VA = "0x182A88CD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x2A89210", Offset = "0x2A87C10", VA = "0x182A89210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool ACFPOEBGLJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x2A88CC0", Offset = "0x2A876C0", VA = "0x182A88CC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x2A89200", Offset = "0x2A87C00", VA = "0x182A89200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public OCMKEPJKDIM GAMONMAHMEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0xB68B60", Offset = "0xB67560", VA = "0x180B68B60")]
			get
			{
				return default(OCMKEPJKDIM);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xB68A10", Offset = "0xB67410", VA = "0x180B68A10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public virtual HGPLPFAPJHK DNOJJDBMGEA
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xB3BA70", Offset = "0xB3A470", VA = "0x180B3BA70", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public virtual KEBKGACMKPD OCGIGPPMJAM
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xB40E90", Offset = "0xB3F890", VA = "0x180B40E90", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public virtual EGFHCLGHIGN BFPLOHOCBOL
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xB49720", Offset = "0xB48120", VA = "0x180B49720", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public virtual LDFGOJKCIJG ACLMGIMAHPO
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xB40E80", Offset = "0xB3F880", VA = "0x180B40E80", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual FIJPNHDDIHB JOOBNPGEMIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xB3D0B0", Offset = "0xB3BAB0", VA = "0x180B3D0B0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public virtual BAEGDPICBGL OPINBHMDPLH
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xB3ECA0", Offset = "0xB3D6A0", VA = "0x180B3ECA0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual HODDBBEOBGJ CFOMFJCCHKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xB11EE0", Offset = "0xB108E0", VA = "0x180B11EE0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual DJMENNNFNHN IMEKDKICJJI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xC269B0", Offset = "0xC253B0", VA = "0x180C269B0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual LDMNOMMHDFN DFKFOOFLEDP
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xBA4B00", Offset = "0xBA3500", VA = "0x180BA4B00", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public virtual KDONLKGEIHO HNHEEAGAHLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xB3EDF0", Offset = "0xB3D7F0", VA = "0x180B3EDF0", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool HBKMNLBNGHN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xBA47B0", Offset = "0xBA31B0", VA = "0x180BA47B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public OptionsWindows GMMGONIBHID
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0xC410F0", Offset = "0xC3FAF0", VA = "0x180C410F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public OptionsApple HFAAIMGFPLK
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xC25680", Offset = "0xC24080", VA = "0x180C25680")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public OptionsApple NHHLOJOFBNO
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0xC28670", Offset = "0xC27070", VA = "0x180C28670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public OptionsApple JIBMHGLEGKM
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0xC3B980", Offset = "0xC3A380", VA = "0x180C3B980")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public OptionsApple DNJHOHLIAFO
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0xB4F5B0", Offset = "0xB4DFB0", VA = "0x180B4F5B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public OptionsAndroid NNIIIOPNLJN
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0xB879E0", Offset = "0xB863E0", VA = "0x180B879E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public OptionsOpenHarmony JGIEKAGBELJ
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0xB49990", Offset = "0xB48390", VA = "0x180B49990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public OptionsWindowsUWP NFPHDKHAPPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0xB61760", Offset = "0xB60160", VA = "0x180B61760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public OptionsWebGL MPGLPPOJAOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xB879D0", Offset = "0xB863D0", VA = "0x180B879D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xAB33F0", Offset = "0xAB1DF0", VA = "0x180AB33F0")]
		public void SetMediaSource(NCHLKIPGCLF PBOCDEMNFLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		public void SetMediaReference(MediaReference NNPBLFMOKPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		public void SetMediaPath(MediaPath HEEMGKHJLID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xAB4880", Offset = "0xAB3280", VA = "0x180AB4880")]
		public void SetAudioSource(AudioSource FNBEJKIAEFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2A833D0", Offset = "0x2A81DD0", VA = "0x182A833D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2A82BD0", Offset = "0x2A815D0", VA = "0x182A82BD0")]
		protected void AHAFIHIDAHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2A87E80", Offset = "0x2A86880", VA = "0x182A87E80")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2A871C0", Offset = "0x2A85BC0", VA = "0x182A871C0")]
		public bool OpenMedia(MediaPath HEEMGKHJLID, bool FFHLHOAINGO = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2A870F0", Offset = "0x2A85AF0", VA = "0x182A870F0")]
		public bool OpenMedia(CDPFJCFHGLL KPJGHCOPAGJ, string HEEMGKHJLID, bool FFHLHOAINGO = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2A87170", Offset = "0x2A85B70", VA = "0x182A87170")]
		public bool OpenMedia(MediaReference OBIBCEBCCGE, bool FFHLHOAINGO = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2A870C0", Offset = "0x2A85AC0", VA = "0x182A870C0")]
		public bool OpenMedia(bool FFHLHOAINGO = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2A85730", Offset = "0x2A84130", VA = "0x182A85730")]
		private bool IJNCCHDAEEA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2A82950", Offset = "0x2A81350", VA = "0x182A82950")]
		private void AGPJNHAMPJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2A82830", Offset = "0x2A81230", VA = "0x182A82830")]
		private void AEMNDNPONMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2A83B40", Offset = "0x2A82540", VA = "0x182A83B40")]
		public void CloseMedia()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2A87490", Offset = "0x2A85E90", VA = "0x182A87490", Slot = "20")]
		public virtual void Play()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2A87410", Offset = "0x2A85E10", VA = "0x182A87410", Slot = "21")]
		public virtual void Pause()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2A87F60", Offset = "0x2A86960", VA = "0x182A87F60")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2A87520", Offset = "0x2A85F20", VA = "0x182A87520")]
		public void Rewind(bool ALPKHNAOIDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2A87CC0", Offset = "0x2A866C0", VA = "0x182A87CC0")]
		public void SeekToLiveTime(double JBCPGNDLJHB = 0.0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2A880C0", Offset = "0x2A86AC0", VA = "0x182A880C0", Slot = "22")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2A85F90", Offset = "0x2A84990", VA = "0x182A85F90")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2A84280", Offset = "0x2A82C80", VA = "0x182A84280")]
		private void EJKMFPFGMOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2A86F80", Offset = "0x2A85980", VA = "0x182A86F80")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2A86EC0", Offset = "0x2A858C0", VA = "0x182A86EC0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2A86D40", Offset = "0x2A85740", VA = "0x182A86D40", Slot = "23")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2A84D60", Offset = "0x2A83760", VA = "0x182A84D60")]
		public void ForceDispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2A84040", Offset = "0x2A82A40", VA = "0x182A84040")]
		private static void DBFCJADDJLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2A86B00", Offset = "0x2A85500", VA = "0x182A86B00")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2A83750", Offset = "0x2A82150", VA = "0x182A83750")]
		protected void BPLEMJFKDEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2A84E30", Offset = "0x2A83830", VA = "0x182A84E30")]
		private void GGCCNBCJJMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2A856B0", Offset = "0x2A840B0", VA = "0x182A856B0")]
		[IteratorStateMachine(typeof(HFAHEPFLECO))]
		private IEnumerator IFICLJEHOCC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570")]
		public static MAPINHBEDKP GetPlatform()
		{
			return default(MAPINHBEDKP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xC410F0", Offset = "0xC3FAF0", VA = "0x180C410F0")]
		public PlatformOptions GetCurrentPlatformOptions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2A860D0", Offset = "0x2A84AD0", VA = "0x182A860D0")]
		private string MCGJFDCNBOK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570")]
		private long AFMEAJGMFND()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2A865F0", Offset = "0x2A84FF0", VA = "0x182A865F0")]
		private string NHEGLIHGCEP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2A85D60", Offset = "0x2A84760", VA = "0x182A85D60")]
		private string LAPEEGBBFJK(string JAKIJIEGAGG, CDPFJCFHGLL KFOKJFAJBFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2A853F0", Offset = "0x2A83DF0", VA = "0x182A853F0")]
		private static GABHJLCHGNK GKCAKKLHJMC(OptionsWindows ALFCEIKBPNG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2A84D10", Offset = "0x2A83710", VA = "0x182A84D10")]
		private static GABHJLCHGNK FMCNFOJFOBM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2A83CB0", Offset = "0x2A826B0", VA = "0x182A83CB0", Slot = "24")]
		public virtual GABHJLCHGNK CreateMediaPlayer()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2A863B0", Offset = "0x2A84DB0", VA = "0x182A863B0")]
		private void NDDFMIDKPID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2A871F0", Offset = "0x2A85BF0", VA = "0x182A871F0")]
		private void PGLPLCBCFMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2A85540", Offset = "0x2A83F40", VA = "0x182A85540")]
		private void HNJKHJBNPBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250")]
		public bool IsUsingAndroidOESPath()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250")]
		public bool IsUsingYCbCr()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2A879D0", Offset = "0x2A863D0", VA = "0x182A879D0")]
		[ContextMenu("Save Frame To PNG")]
		public void SaveFrameToPng()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2A875A0", Offset = "0x2A85FA0", VA = "0x182A875A0")]
		[ContextMenu("Save Frame To EXR")]
		public void SaveFrameToExr()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		private void OnApplicationFocus(bool BOOMPIFFKFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		private void OnApplicationPause(bool KLLBBCAIKPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2A83720", Offset = "0x2A82120", VA = "0x182A83720")]
		private void BIEFHIGLACL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2A83440", Offset = "0x2A81E40", VA = "0x182A83440")]
		private void BAGBKPGJOLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2A84380", Offset = "0x2A82D80", VA = "0x182A84380")]
		private void EKPNCOAILHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2A84AD0", Offset = "0x2A834D0", VA = "0x182A84AD0")]
		private void FLINBGMDAEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2A85DD0", Offset = "0x2A847D0", VA = "0x182A85DD0")]
		private void LPLANMBGLEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2A83810", Offset = "0x2A82210", VA = "0x182A83810")]
		protected bool BPLJPBBHMCP(MediaPlayerEvent.OPGAEJDGMGO BLANOKBLJPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2A83840", Offset = "0x2A82240", VA = "0x182A83840")]
		private bool CFDEELPNHIH(MediaPlayerEvent.OPGAEJDGMGO BLANOKBLJPK, bool GEDCIHAEPIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2A84E80", Offset = "0x2A83880", VA = "0x182A84E80")]
		private bool GJGNJKOKIEB(MediaPlayerEvent.OPGAEJDGMGO DBMNAJLECLK, bool GEDCIHAEPIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2A838D0", Offset = "0x2A822D0", VA = "0x182A838D0")]
		private bool CKMOCLNINJD(int PJMCGBGHIHB, float CJJBEBJHDEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2A86150", Offset = "0x2A84B50", VA = "0x182A86150")]
		private static Camera MLODOGOGDHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2A87340", Offset = "0x2A85D40", VA = "0x182A87340")]
		[IteratorStateMachine(typeof(HPODCFLJGGE))]
		private IEnumerator PJJELCIDDJL(Texture2D JFBLIPHGGPK, MGFDIOLEODH AEPCPKCINPI, double BNJFNGGEIPK = -1.0, bool FOJCPLAPDPM = true, int CJJBEBJHDEB = 1000, int OJPPANALIAM = 100)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2A84870", Offset = "0x2A83270", VA = "0x182A84870")]
		public void ExtractFrameAsync(Texture2D JFBLIPHGGPK, MGFDIOLEODH AEPCPKCINPI, double BNJFNGGEIPK = -1.0, bool FOJCPLAPDPM = true, int CJJBEBJHDEB = 1000, int OJPPANALIAM = 100)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2A84950", Offset = "0x2A83350", VA = "0x182A84950")]
		public Texture2D ExtractFrame(Texture2D JFBLIPHGGPK, double BNJFNGGEIPK = -1.0, bool FOJCPLAPDPM = true, int CJJBEBJHDEB = 1000, int OJPPANALIAM = 100)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2A866A0", Offset = "0x2A850A0", VA = "0x182A866A0")]
		private Texture OBMGJBHIEEN(double BNJFNGGEIPK = -1.0, bool FOJCPLAPDPM = true, int CJJBEBJHDEB = 1000, int OJPPANALIAM = 100)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x2A87000", Offset = "0x2A85A00", VA = "0x182A87000")]
		public bool OpenMediaFromBuffer(byte[] FPGJFOLEKAK, bool FFHLHOAINGO = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x2A87DC0", Offset = "0x2A867C0", VA = "0x182A87DC0")]
		public bool StartOpenChunkedMediaFromBuffer(ulong AJDEGEPLAEO, bool FFHLHOAINGO = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2A832B0", Offset = "0x2A81CB0", VA = "0x182A832B0")]
		public bool AddChunkToVideoBuffer(byte[] FOLEMGCPIBM, ulong JBCPGNDLJHB, ulong JHMCDKNHBJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2A847F0", Offset = "0x2A831F0", VA = "0x182A847F0")]
		public bool EndOpenChunkedVideoFromBuffer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2A83510", Offset = "0x2A81F10", VA = "0x182A83510")]
		private bool BCOPFHHIAGM(byte[] FPGJFOLEKAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2A868F0", Offset = "0x2A852F0", VA = "0x182A868F0")]
		private bool OMFDLGMLJKN(ulong AJDEGEPLAEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2A832B0", Offset = "0x2A81CB0", VA = "0x182A832B0")]
		private bool MONMCGOIACK(byte[] FOLEMGCPIBM, ulong JBCPGNDLJHB, ulong JHMCDKNHBJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2A847F0", Offset = "0x2A831F0", VA = "0x182A847F0")]
		private bool KLIFHODGKEM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2A84410", Offset = "0x2A82E10", VA = "0x182A84410")]
		public bool EnableSubtitles(MediaPath CAPMJNNGMHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2A83A90", Offset = "0x2A82490", VA = "0x182A83A90")]
		[IteratorStateMachine(typeof(AOBHHCHMGLH))]
		private IEnumerator CPAMGENHNOK(string GJEEEEHJACP, MediaPath CAPMJNNGMHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2A841A0", Offset = "0x2A82BA0", VA = "0x182A841A0")]
		public void DisableSubtitles()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2A87FC0", Offset = "0x2A869C0", VA = "0x182A87FC0", Slot = "5")]
		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2A884F0", Offset = "0x2A86EF0", VA = "0x182A884F0")]
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
			public enum LENHODFIBCO
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
			public LENHODFIBCO sourceType;

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
			public PlaylistMediaPlayer.JAKPJLILFMJ startMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			[SerializeField]
			public PlaylistMediaPlayer.NBGLPPDFMFA progressMode;

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
			public PlaylistMediaPlayer.GNGFDGLLJBK overrideTransition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			[SerializeField]
			public float overrideTransitionDuration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			[SerializeField]
			public AIDCNOKABAE.KCHDBBOGDGF overrideTransitionEasing;

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x2A824F0", Offset = "0x2A80EF0", VA = "0x182A824F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2A893F0", Offset = "0x2A87DF0", VA = "0x182A893F0")]
		public bool CAFPNPKPGKD(int KABGMIEBEFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2A89450", Offset = "0x2A87E50", VA = "0x182A89450")]
		public MediaPlaylist()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[AddComponentMenu("AVPro Video/Playlist Media Player", -80)]
	[HelpURL("https://www.renderheads.com/products/avpro-video/")]
	public class PlaylistMediaPlayer : MediaPlayer, LDFGOJKCIJG
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public enum GNGFDGLLJBK
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
		public enum HLPHNMANJIK
		{
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			Loop
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public enum JAKPJLILFMJ
		{
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			Immediate,
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			Manual
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public enum NBGLPPDFMFA
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
		private sealed class EODOJCCDHCI : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
			[DebuggerHidden]
			public EODOJCCDHCI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x2A80190", Offset = "0x2A7EB90", VA = "0x182A80190", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x2A80820", Offset = "0x2A7F220", VA = "0x182A80820", Slot = "8")]
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
		private HLPHNMANJIK _playlistLoopMode;

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
		private GNGFDGLLJBK _defaultTransition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[SerializeField]
		private float _defaultTransitionDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[SerializeField]
		private AIDCNOKABAE.KCHDBBOGDGF _defaultTransitionEasing;

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
		private static readonly OIGDOFJJJDO CPGFLNGBCFC;

		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private static readonly OIGDOFJJJDO MFNAHGEBOKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x205")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private bool JLCPMPOFNKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private int ONFPHIKKHHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private MediaPlayer KGEKAKPNHNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private Material NPMNFMAPBPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private GNGFDGLLJBK KFJKFJIGANK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private string NAKFDJOJNMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private float FEGKGKCMECL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x234")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private AIDCNOKABAE.KCHDBBOGDGF APKIDNBEHFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private float LIMEFBMKHCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private Func<float, float> HIIFFPCENKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private RenderTexture JLAFDEADNJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private MediaPlaylist.MediaItem GABMPKHCDMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private MediaPlaylist.MediaItem NDNKGCBKKKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private WaitForEndOfFrame OIHPMKJCFOM;

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public MediaPlayer JDNLCGHFHJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x2A8D4F0", Offset = "0x2A8BEF0", VA = "0x182A8D4F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public MediaPlayer LEAOCNNBHJK
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xBDCBB0", Offset = "0xBDB5B0", VA = "0x180BDCBB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public MediaPlaylist JCOPJHMABIM
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xBDC160", Offset = "0xBDAB60", VA = "0x180BDC160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public int IMBEOILBJJL
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x2751440", Offset = "0x274FE40", VA = "0x182751440")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public MediaPlaylist.MediaItem KMNFLNCMCIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x2A8D640", Offset = "0x2A8C040", VA = "0x182A8D640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public GNGFDGLLJBK POIKHNKFNNP
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xDB6B00", Offset = "0xDB5500", VA = "0x180DB6B00")]
			get
			{
				return default(GNGFDGLLJBK);
			}
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x16453A0", Offset = "0x1643DA0", VA = "0x1816453A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public float LNJGGGJNGPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x1F70200", Offset = "0x1F6EC00", VA = "0x181F70200")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x21ECC70", Offset = "0x21EB670", VA = "0x1821ECC70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public AIDCNOKABAE.KCHDBBOGDGF LONGLADHBGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0xB61920", Offset = "0xB60320", VA = "0x180B61920")]
			get
			{
				return default(AIDCNOKABAE.KCHDBBOGDGF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xB5F900", Offset = "0xB5E300", VA = "0x180B5F900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public bool GANFOLMANAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x1659500", Offset = "0x1657F00", VA = "0x181659500")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x165C190", Offset = "0x165AB90", VA = "0x18165C190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public HLPHNMANJIK MMCADNKEOJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x2A8D630", Offset = "0x2A8C030", VA = "0x182A8D630")]
			get
			{
				return default(HLPHNMANJIK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x2A8D8C0", Offset = "0x2A8C2C0", VA = "0x182A8D8C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public bool IPBKMJFEANO
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xC27B70", Offset = "0xC26570", VA = "0x180C27B70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xC284D0", Offset = "0xC26ED0", VA = "0x180C284D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public override HGPLPFAPJHK DNOJJDBMGEA
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x2A8D590", Offset = "0x2A8BF90", VA = "0x182A8D590", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public override KEBKGACMKPD OCGIGPPMJAM
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x2A8D450", Offset = "0x2A8BE50", VA = "0x182A8D450", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public override LDFGOJKCIJG ACLMGIMAHPO
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xE2F470", Offset = "0xE2DE70", VA = "0x180E2F470", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public override float JPMMDOLAMEB
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x21EB2E0", Offset = "0x21E9CE0", VA = "0x1821EB2E0", Slot = "6")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x2A8D7D0", Offset = "0x2A8C1D0", VA = "0x182A8D7D0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public override bool MGJGLDLNDHN
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x2A8D440", Offset = "0x2A8BE40", VA = "0x182A8D440", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x2A8D700", Offset = "0x2A8C100", VA = "0x182A8D700", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C890", Offset = "0x2A8B290", VA = "0x182A8C890", Slot = "20")]
		public override void Play()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C780", Offset = "0x2A8B180", VA = "0x182A8C780", Slot = "21")]
		public override void Pause()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2A8BA50", Offset = "0x2A8A450", VA = "0x182A8BA50")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2A8A810", Offset = "0x2A89210", VA = "0x182A8A810")]
		[IteratorStateMachine(typeof(EODOJCCDHCI))]
		private IEnumerator ANJGOLLGGNF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2A8AA20", Offset = "0x2A89420", VA = "0x182A8AA20")]
		private Texture BBAOAEDFMBF(int KABGMIEBEFC = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2A8AB30", Offset = "0x2A89530", VA = "0x182A8AB30")]
		private Texture BCJOLILGJKP(int KABGMIEBEFC = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2A8A890", Offset = "0x2A89290", VA = "0x182A8A890")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2A8BC20", Offset = "0x2A8A620", VA = "0x182A8BC20", Slot = "23")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2A8CA50", Offset = "0x2A8B450", VA = "0x182A8CA50")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2A8BEA0", Offset = "0x2A8A8A0", VA = "0x182A8BEA0")]
		public void OnMediaPlayerEvent(MediaPlayer FFICBEDFFMG, MediaPlayerEvent.OPGAEJDGMGO BLANOKBLJPK, GHCKFLJBDJH NGDAMNDJLIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C9A0", Offset = "0x2A8B3A0", VA = "0x182A8C9A0")]
		public bool PrevItem()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2A8BBA0", Offset = "0x2A8A5A0", VA = "0x182A8BBA0")]
		public bool NextItem()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2A8AEE0", Offset = "0x2A898E0", VA = "0x182A8AEE0")]
		public bool CanJumpToItem(int KABGMIEBEFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2A8BA60", Offset = "0x2A8A460", VA = "0x182A8BA60")]
		public bool JumpToItem(int KABGMIEBEFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C060", Offset = "0x2A8AA60", VA = "0x182A8C060")]
		public void OpenVideoFile(MediaPlaylist.MediaItem DAFMHHNFEGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2A8BA30", Offset = "0x2A8A430", VA = "0x182A8BA30")]
		private bool ILCJNFEINEJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C400", Offset = "0x2A8AE00", VA = "0x182A8C400")]
		private void PHEDIALEILO(GNGFDGLLJBK GKEFKGMEBDD, float NDKGEJPCLBH, AIDCNOKABAE.KCHDBBOGDGF BMGNEMGGALN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2A8CC80", Offset = "0x2A8B680", VA = "0x182A8CC80", Slot = "22")]
		protected override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2A8B810", Offset = "0x2A8A210", VA = "0x182A8B810", Slot = "26")]
		public Texture GetTexture(int KABGMIEBEFC = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2A8B280", Offset = "0x2A89C80", VA = "0x182A8B280", Slot = "25")]
		public int GetTextureCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x2A8B320", Offset = "0x2A89D20", VA = "0x182A8B320", Slot = "27")]
		public int GetTextureFrameCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2A8CBE0", Offset = "0x2A8B5E0", VA = "0x182A8CBE0", Slot = "28")]
		public bool SupportsTextureFrameCount()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2A8B640", Offset = "0x2A8A040", VA = "0x182A8B640", Slot = "29")]
		public long GetTextureTimeStamp()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2A8B4F0", Offset = "0x2A89EF0", VA = "0x182A8B4F0", Slot = "30")]
		public float GetTexturePixelAspectRatio()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C9B0", Offset = "0x2A8B3B0", VA = "0x182A8C9B0", Slot = "31")]
		public bool RequiresVerticalFlip()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2A8B900", Offset = "0x2A8A300", VA = "0x182A8B900", Slot = "35")]
		public Matrix4x4 GetYpCbCrTransform()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2A8B5A0", Offset = "0x2A89FA0", VA = "0x182A8B5A0", Slot = "32")]
		public JMNFDNHCLCA GetTextureStereoPacking()
		{
			return default(JMNFDNHCLCA);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x2A8B770", Offset = "0x2A8A170", VA = "0x182A8B770", Slot = "33")]
		public DDBJIDEBBLJ GetTextureTransparency()
		{
			return default(DDBJIDEBBLJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x2A8B1E0", Offset = "0x2A89BE0", VA = "0x182A8B1E0", Slot = "34")]
		public GPFAOMIDBNE GetTextureAlphaPacking()
		{
			return default(GPFAOMIDBNE);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x2A8AFB0", Offset = "0x2A899B0", VA = "0x182A8AFB0", Slot = "36")]
		public float[] GetAffineTransform()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x2A8B3C0", Offset = "0x2A89DC0", VA = "0x182A8B3C0", Slot = "37")]
		public Matrix4x4 GetTextureMatrix()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x2A8B0A0", Offset = "0x2A89AA0", VA = "0x182A8B0A0", Slot = "38")]
		public RenderTextureFormat GetCompatibleRenderTextureFormat(POEIPIJOOCG ALFCEIKBPNG, int DHOBCGOKNFP)
		{
			return default(RenderTextureFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x2A8AC20", Offset = "0x2A89620", VA = "0x182A8AC20")]
		private static string CBGPCJBKIHA(GNGFDGLLJBK GKEFKGMEBDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D290", Offset = "0x2A8BC90", VA = "0x182A8D290")]
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
		private CLBGMPJIHKK.PNFJAJPGNAI _resolveFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[SerializeField]
		private RenderTexture _externalTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private Material PJKCKFMHOIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private bool BLMDMDCOOML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x69")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private bool IAFNFOPIIIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6A")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private bool OOBHODJMIAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private RenderTexture JHBBPLJOJFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private int OOEGIOALFGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private Material DKFNEOLOHAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private int NJOFGKDPOPN;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public MediaPlayer NHPMCMMBJKK
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x2A8D8E0", Offset = "0x2A8C2E0", VA = "0x182A8D8E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public VideoResolveOptions EOGNKDBBGLF
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x2A8E3D0", Offset = "0x2A8CDD0", VA = "0x182A8E3D0")]
			get
			{
				return default(VideoResolveOptions);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x2A8E3F0", Offset = "0x2A8CDF0", VA = "0x182A8E3F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public RenderTexture KFNCDIBNHOA
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xAB4840", Offset = "0xAB3240", VA = "0x180AB4840")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xAB4800", Offset = "0xAB3200", VA = "0x180AB4800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public RenderTexture AJAEFBBAEOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x2A8E350", Offset = "0x2A8CD50", VA = "0x182A8E350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2A8E180", Offset = "0x2A8CB80", VA = "0x182A8E180")]
		public void SetMaterialDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D8E0", Offset = "0x2A8C2E0", VA = "0x182A8D8E0")]
		private void NILCKEOMMON(MediaPlayer FFICBEDFFMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x2A8E190", Offset = "0x2A8CB90", VA = "0x182A8E190")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D8D0", Offset = "0x2A8C2D0", VA = "0x182A8D8D0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DAA0", Offset = "0x2A8C4A0", VA = "0x182A8DAA0")]
		public void Resolve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DA20", Offset = "0x2A8C420", VA = "0x182A8DA20")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D980", Offset = "0x2A8C380", VA = "0x182A8D980")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2A8E300", Offset = "0x2A8CD00", VA = "0x182A8E300")]
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
		private static readonly OIGDOFJJJDO MMFNJIMPDME;

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private static readonly OIGDOFJJJDO MBKFMEAMGAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private Camera DBGANBIFGIH;

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Camera AMAFDKGJECI
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2A8E410", Offset = "0x2A8CE10", VA = "0x182A8E410")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2A8ED00", Offset = "0x2A8D700", VA = "0x182A8ED00")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2A8E4E0", Offset = "0x2A8CEE0", VA = "0x182A8E4E0")]
		private void KNHMGDKLHDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2A8E4B0", Offset = "0x2A8CEB0", VA = "0x182A8E4B0")]
		private static bool DMDJHGJLMHG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2A8E920", Offset = "0x2A8D320", VA = "0x182A8E920")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
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
		private JMNFDNHCLCA _overrideStereoPacking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[SerializeField]
		private bool _stereoRedGreenTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		protected bool CFFFGDEFCCC;

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public MediaPlayer BFPLOHOCBOL
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x2A79C90", Offset = "0x2A78690", VA = "0x182A79C90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public bool BPBMMFIMIFE
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xAB5CA0", Offset = "0xAB46A0", VA = "0x180AB5CA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x2A79C70", Offset = "0x2A78670", VA = "0x182A79C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public JMNFDNHCLCA LNKGMDBPHGD
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xC5E970", Offset = "0xC5D370", VA = "0x180C5E970")]
			get
			{
				return default(JMNFDNHCLCA);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x2A79C80", Offset = "0x2A78680", VA = "0x182A79C80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public bool GILBDDPNNJD
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xC5E960", Offset = "0xC5D360", VA = "0x180C5E960")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x2A79CA0", Offset = "0x2A786A0", VA = "0x182A79CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x2A79990", Offset = "0x2A78390", VA = "0x182A79990")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x2A79A20", Offset = "0x2A78420", VA = "0x182A79A20")]
		private void NILCKEOMMON(MediaPlayer BLHNDOLLIDD, bool KEJIJALNLAM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x2A799E0", Offset = "0x2A783E0", VA = "0x182A799E0")]
		private void GBPFINLHGGH(MediaPlayer IBNLHPFFIEL, MediaPlayerEvent.OPGAEJDGMGO DBMNAJLECLK, GHCKFLJBDJH NGDAMNDJLIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x2A799A0", Offset = "0x2A783A0", VA = "0x182A799A0")]
		public void ForceUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x2A79C30", Offset = "0x2A78630", VA = "0x182A79C30")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x2A79BE0", Offset = "0x2A785E0", VA = "0x182A79BE0", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x1AD0890", Offset = "0x1ACF290", VA = "0x181AD0890", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x2A79BD0", Offset = "0x2A785D0", VA = "0x182A79BD0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "6")]
		protected virtual void BKBEGLKMLPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "7")]
		protected virtual void EBFIPMDAJNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void Apply();

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x18A4D60", Offset = "0x18A3760", VA = "0x1818A4D60")]
		protected ApplyToBase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class PALJHPNLABL
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	protected class EHJGNFMFPCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public HashSet<AudioOutput> KMNNAIEIKPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public float[] IMFLGGHCLAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public bool MEIGCMABJIG;

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public EHJGNFMFPCM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private static PALJHPNLABL GHBNEILHBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private Dictionary<int, EHJGNFMFPCM> GIBIMKGFBLN;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public static PALJHPNLABL FLGHCDNLMND
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x2A8A420", Offset = "0x2A88E20", VA = "0x182A8A420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x2A8A6B0", Offset = "0x2A890B0", VA = "0x182A8A6B0")]
	private PALJHPNLABL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x2A8A5B0", Offset = "0x2A88FB0", VA = "0x182A8A5B0")]
	public void OMDHCHEFBCL(int DLIMJBALHJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x2A8A530", Offset = "0x2A88F30", VA = "0x182A8A530")]
	public void NNPCHAGFMHH(int DLIMJBALHJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x2A89A20", Offset = "0x2A88420", VA = "0x182A89A20")]
	public void AEJGBNOFDEB(AudioOutput MCPGDJOGOEI, MediaPlayer FFICBEDFFMG, int DLIMJBALHJC, float[] AOPHCOCAFFL, int KACMJGAMACL, int FJEHHOKGFCI, AudioOutput.OBFAHBDOFIO JGHIGDDJECC, bool DLMNCGBEBLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x2A8A3E0", Offset = "0x2A88DE0", VA = "0x182A8A3E0")]
	private void DLJCDDLGMKG(float[] AOPHCOCAFFL, int FMNPGDAFNOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x2A8A2D0", Offset = "0x2A88CD0", VA = "0x182A8A2D0")]
	private bool CMPIJMLCJAG(MediaPlayer BLHNDOLLIDD, float[] AOPHCOCAFFL, int MCJPLGCDCKJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[DefaultMember("Item")]
public abstract class GABHJLCHGNK : EGFHCLGHIGN, KEBKGACMKPD, HGPLPFAPJHK, KDONLKGEIHO, LDFGOJKCIJG, FIJPNHDDIHB, BAEGDPICBGL, HODDBBEOBGJ, DJMENNNFNHN, LDMNOMMHDFN, IEnumerable, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	protected string KLGBPAJIALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	protected GHCKFLJBDJH BLNFADJPHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	protected FilterMode PILBDKDLMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	protected TextureWrapMode IFDLEAJDGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	protected int LHEHOJGCPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	protected MediaHints NKCBIIIMCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	protected FNMEDGNPBEI NNDIIPPMGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	protected FNMEDGNPBEI FBIMFMOBCLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private float EENICMBCGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private int GNJNAKBAGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private float JKEELNBKBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private float HGAGOLJGDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private int MMKBJACBJPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private int PPDMKIHKLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	protected List<FPCCDOHHPKP> ODMALLMNCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	protected FPCCDOHHPKP DGMHGKLHNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	protected LGIBLBBPHHG AKIBJPIINAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	protected AHDCKBPNELD PEGLCBEPIMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	protected BPOBCDLJEGH HDFKABEGCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	protected HKNILCENEPK FPBIHBAKNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	protected FKFJGLJGINK ACJIGCIHNLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	protected KAHKLGFPODH[] DBFBBCBIMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	protected List<ICALBHAONBL> LMOBPCMJNNH;

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x2A81AB0", Offset = "0x2A804B0", VA = "0x182A81AB0")]
	public GABHJLCHGNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "82")]
	public abstract string BIAMNKJPLHP();

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "83")]
	public abstract string BEGGLKMBLPB();

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "84")]
	public abstract bool LEJNLFBBHIE(string HEEMGKHJLID, long JBCPGNDLJHB, string APPABFLDNEE, MediaHints IINPFBHEALF, int BNLNIKEIFGC = 0, bool MJMDBIEIHMG = false);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "85")]
	public virtual bool IDLELOHDLCH(byte[] FPGJFOLEKAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "86")]
	public virtual bool KPFGPABKFPO(ulong AJDEGEPLAEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "87")]
	public virtual bool CGOMBGIPJGN(byte[] FOLEMGCPIBM, ulong JBCPGNDLJHB, ulong AJDEGEPLAEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "88")]
	public virtual bool BIEAHHFAACF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x2A80870", Offset = "0x2A7F270", VA = "0x182A80870", Slot = "89")]
	public virtual void ACBEEFJJDJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "90")]
	public abstract void LOLMHICLBEB(bool MAJEBNDNBGF);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "91")]
	public abstract bool LGIBEPJECNB();

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "92")]
	public abstract bool EOKBNLFNDPF();

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "93")]
	public abstract bool CLILAPGENKE();

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "94")]
	public abstract void HEKOJIOMLJA();

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "95")]
	public abstract void KBBEAMBLPCO();

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "96")]
	public abstract void ECGOBBCGDJE();

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x2A80BA0", Offset = "0x2A7F5A0", VA = "0x182A80BA0", Slot = "97")]
	public virtual void CNACLFDIJGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "98")]
	public abstract void NLPMHCNKEGN(double LKKNOPLOOPB);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "99")]
	public abstract void COFNIHPMBBJ(double LKKNOPLOOPB);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "100")]
	public abstract double CGKEJNFAGKP();

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "101")]
	public abstract float KDHMAPHBOOM();

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "102")]
	public abstract void BEAEFFKGKDH(float HODMIEFFAOA);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "103")]
	public abstract double PMEKMEOFELN();

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "104")]
	public abstract int FKOJKJBNIDI();

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "105")]
	public abstract int EBNOKLKNBCK();

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "106")]
	public abstract float DIMFCBGDJGH();

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "107")]
	public abstract bool NEBJCKDDAKL();

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "108")]
	public abstract bool EMMLCIHPPMG();

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "109")]
	public abstract bool GKACBBCODGO();

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "110")]
	public abstract bool PFDMKOJACHM();

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "111")]
	public abstract bool LDNHGJAAJFH();

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "112")]
	public abstract bool HNKHLMMKOBG();

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "113")]
	public abstract bool KDHEBGFICBK();

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "114")]
	public virtual bool DNKDFILFCAK(Camera GOPJCLJMGPB, int DBKDNPNHBLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0xC43520", Offset = "0xC41F20", VA = "0x180C43520", Slot = "115")]
	public virtual int GetTextureCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "116")]
	public abstract Texture GetTexture(int KABGMIEBEFC = 0);

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "117")]
	public abstract int GetTextureFrameCount();

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240", Slot = "118")]
	public virtual bool SupportsTextureFrameCount()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x2A81210", Offset = "0x2A7FC10", VA = "0x182A81210", Slot = "119")]
	public virtual long GetTextureTimeStamp()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "120")]
	public abstract bool RequiresVerticalFlip();

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0xC5E950", Offset = "0xC5D350", VA = "0x180C5E950", Slot = "121")]
	public virtual float GetTexturePixelAspectRatio()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x2A81220", Offset = "0x2A7FC20", VA = "0x182A81220", Slot = "122")]
	public virtual Matrix4x4 GetYpCbCrTransform()
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x2A80F00", Offset = "0x2A7F900", VA = "0x182A80F00", Slot = "123")]
	public virtual float[] GetAffineTransform()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x2A80AE0", Offset = "0x2A7F4E0", VA = "0x182A80AE0", Slot = "124")]
	public virtual float[] CHGAGOIPIHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x2A81040", Offset = "0x2A7FA40", VA = "0x182A81040", Slot = "125")]
	public virtual Matrix4x4 GetTextureMatrix()
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0xF447C0", Offset = "0xF431C0", VA = "0x180F447C0", Slot = "126")]
	public virtual RenderTextureFormat GetCompatibleRenderTextureFormat(POEIPIJOOCG ALFCEIKBPNG, int DHOBCGOKNFP)
	{
		return default(RenderTextureFormat);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x2A811E0", Offset = "0x2A7FBE0", VA = "0x182A811E0", Slot = "70")]
	public JMNFDNHCLCA GetTextureStereoPacking()
	{
		return default(JMNFDNHCLCA);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "127")]
	internal abstract JMNFDNHCLCA FBJPBDBIKEB();

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0xAB33E0", Offset = "0xAB1DE0", VA = "0x180AB33E0", Slot = "128")]
	public virtual DDBJIDEBBLJ GetTextureTransparency()
	{
		return default(DDBJIDEBBLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x2A81000", Offset = "0x2A7FA00", VA = "0x182A81000", Slot = "72")]
	public GPFAOMIDBNE GetTextureAlphaPacking()
	{
		return default(GPFAOMIDBNE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "129")]
	public abstract void FNNKPMICNJJ(bool NPIOFDKLNBI);

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "130")]
	public abstract bool GJFOOLMIHDG();

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "131")]
	public abstract void IEPJFHOHMPG(float IKEDDMJNIJO);

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "132")]
	public virtual void JGPDHBIEPON(float LMIGMDBHMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "133")]
	public abstract float FAMDHLNBGPE();

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0xAFDE10", Offset = "0xAFC810", VA = "0x180AFDE10", Slot = "134")]
	public virtual float NMACCHBHJEI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0xAFDE20", Offset = "0xAFC820", VA = "0x180AFDE20", Slot = "135")]
	public virtual int GDBEDMPJDND()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "136")]
	public virtual int CMPIJMLCJAG(float[] AOPHCOCAFFL, int AJIBOLFNMIM, int MCJPLGCDCKJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "137")]
	public virtual void NAJFNGPPGGE(bool KNIEHHHDKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "138")]
	public virtual void IOGMBKPIPDL(Quaternion EKOCBFMEKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "139")]
	public virtual void HEMHFDGFMHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "140")]
	public virtual void BMDBIABEMKF(BBFMIMIONBN CAKPAAFCOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "141")]
	public virtual void DNCPFCIDGIG(bool LEFHPHFNFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "142")]
	public virtual void CNGEIFIGNEK(float EGHOBCOOJNB, float MKABDJGGAFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "143")]
	public virtual void JOHMHCAGJLH(Quaternion EKOCBFMEKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "144")]
	public virtual void BKMHHICEHGL(string MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "145")]
	public virtual void KFKOPBJIFCL(byte[] HPFHOBCPNEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(Slot = "146")]
	public abstract void DBIPLKHEHMB();

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "147")]
	public virtual void NHKCNMDDBEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "148")]
	public abstract void EMFGHMOBDJJ();

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(Slot = "149")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "150")]
	public virtual void PLKECINBPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x2A81A00", Offset = "0x2A80400", VA = "0x182A81A00", Slot = "40")]
	public GHCKFLJBDJH OACGIHNJHMK()
	{
		return default(GHCKFLJBDJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240", Slot = "151")]
	public virtual bool BOGCAIACEFO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900", Slot = "39")]
	public FNMEDGNPBEI LPOIMKFDIEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x2A81530", Offset = "0x2A7FF30", VA = "0x182A81530", Slot = "42")]
	public void KBFBKDJIJJM([Out] FilterMode JICCDONLJBM, [Out] TextureWrapMode NBLIIHHAPLO, [Out] int KMEGEPIIEKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x2A81970", Offset = "0x2A80370", VA = "0x182A81970", Slot = "41")]
	public void NPHFAGKHJAI(FilterMode JICCDONLJBM = FilterMode.Bilinear, TextureWrapMode NBLIIHHAPLO = TextureWrapMode.Clamp, int KMEGEPIIEKH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x2A80B00", Offset = "0x2A7F500", VA = "0x182A80B00", Slot = "152")]
	protected virtual void CLOHLCKAAAI(Texture JBOOEIGKOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x2A81A10", Offset = "0x2A80410", VA = "0x182A81A10")]
	protected void PJCBFGOFKAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x2A81550", Offset = "0x2A7FF50", VA = "0x182A81550")]
	protected bool LLLHDDDNNIB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x2A816D0", Offset = "0x2A800D0", VA = "0x182A816D0", Slot = "153")]
	public virtual bool LPNLBBNHHBE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x2A814C0", Offset = "0x2A7FEC0", VA = "0x182A814C0", Slot = "77")]
	public bool IECNPCOEKOB(string BLPDDGCLNPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x2A81380", Offset = "0x2A7FD80", VA = "0x182A81380", Slot = "154")]
	public virtual void IBOPFAMIMGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x2A81280", Offset = "0x2A7FC80", VA = "0x182A81280", Slot = "155")]
	public virtual int HMMKALAEBGK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x2A80D30", Offset = "0x2A7F730", VA = "0x182A80D30", Slot = "156")]
	public virtual string EHNDMEOIADG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "157")]
	public virtual void HCIJLAOPINK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x2A80BC0", Offset = "0x2A7F5C0", VA = "0x182A80BC0", Slot = "158")]
	public int DGAEMHLCDEG(float MFIMCNMJMLC = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x2A812A0", Offset = "0x2A7FCA0", VA = "0x182A812A0")]
	protected bool HNLKBMNEDNG(bool KEJIJALNLAM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "159")]
	internal abstract bool PCBHAENNGGD();

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "160")]
	internal abstract string KPPAJMOHGFE();

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(Slot = "161")]
	internal abstract bool DDCCHAGIPDA(AFPKINGMBJK KCLKPKACMJM);

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(Slot = "162")]
	internal abstract int MDEMPMHGHMF(AFPKINGMBJK KCLKPKACMJM);

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "163")]
	internal abstract CJHKMLCMCDI BACPGKBCHHP(AFPKINGMBJK KCLKPKACMJM, int CACJCJEPCNM, bool PDDCHBMDDOO);

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x2A80DA0", Offset = "0x2A7F7A0", VA = "0x182A80DA0")]
	private void EOBGFEHEJFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x2A80C80", Offset = "0x2A7F680", VA = "0x182A80C80")]
	protected void DLAMHJMNEMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x2A80910", Offset = "0x2A7F310", VA = "0x182A80910")]
	private void AFOKEMADOKK(KAHKLGFPODH HHHHAPMJLOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x2A80F70", Offset = "0x2A7F970", VA = "0x182A80F70", Slot = "164")]
	public virtual IEnumerator GetEnumerator()
	{
		return null;
	}
}
namespace RenderHeads.Media.AVProVideo
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class MediaPlayerEvent : UnityEvent<MediaPlayer, MediaPlayerEvent.OPGAEJDGMGO, GHCKFLJBDJH>
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public enum OPGAEJDGMGO
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
		private List<UnityAction<MediaPlayer, OPGAEJDGMGO, GHCKFLJBDJH>> _listeners;

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x2A82690", Offset = "0x2A81090", VA = "0x182A82690")]
		public bool LCENKNBKBMK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x2A825A0", Offset = "0x2A80FA0", VA = "0x182A825A0")]
		public void DOHACPDDLPO(UnityAction<MediaPlayer, OPGAEJDGMGO, GHCKFLJBDJH> JBGOHEDFHDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x2A826F0", Offset = "0x2A810F0", VA = "0x182A826F0")]
		public void PEJALPLEBFN(UnityAction<MediaPlayer, OPGAEJDGMGO, GHCKFLJBDJH> JBGOHEDFHDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x2A82790", Offset = "0x2A81190", VA = "0x182A82790")]
		public MediaPlayerEvent()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class FEFFKBMMCNP
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static Matrix4x4 CNJBDPOBBHD;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static Matrix4x4 JMCAHFFBMPK;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static Matrix4x4 IKKNDMHCNPN;

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x2A95ED0", Offset = "0x2A948D0", VA = "0x182A95ED0")]
	public static string ECHOBOAIDJM(CDPFJCFHGLL FKEHPJNDECK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x2A96740", Offset = "0x2A95140", VA = "0x182A96740")]
	public static string NJMECPHLHMB(string HEEMGKHJLID, CDPFJCFHGLL FKEHPJNDECK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x2A96900", Offset = "0x2A95300", VA = "0x182A96900")]
	public static string NMAKFHACIMA(GHCKFLJBDJH DDFEAKLIDDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x2A95DF0", Offset = "0x2A947F0", VA = "0x182A95DF0")]
	public static void ALOOJBDIKIP(string JEBOHIALEMJ, [Optional] UnityEngine.Object IJNPIDPIBFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x2A95FD0", Offset = "0x2A949D0", VA = "0x182A95FD0")]
	public static int FMKHLDHCMDK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x2A966B0", Offset = "0x2A950B0", VA = "0x182A966B0")]
	public static int LKFOGLBEJJJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x2A96A30", Offset = "0x2A95430", VA = "0x182A96A30")]
	public static HNOAJGFKMFJ OOADDIHGFJO(float[] GGMLEPFJHKP)
	{
		return default(HNOAJGFKMFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x2A961B0", Offset = "0x2A94BB0", VA = "0x182A961B0")]
	public static int HFCPFMIGBMN(double JHMKMDEDCJN, float MLJOONJEMAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x2A96230", Offset = "0x2A94C30", VA = "0x182A96230")]
	private static extern int ILNKKDDBCHJ(string EDLFGDEPIDH, StringBuilder EGEMNKOBKPP, int NKOIACEGDAG);

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x2A96000", Offset = "0x2A94A00", VA = "0x182A96000")]
	internal static string GLMHOLBKPPA(string HEEMGKHJLID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x2A96310", Offset = "0x2A94D10", VA = "0x182A96310")]
	public static Texture2D JNBICKNBOIN(Texture HGCEGDCAKEA, bool JFGKKBKEHKF, HNOAJGFKMFJ GGODOAPMIHH, [Optional] Texture2D EINBDCPNOKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface EGFHCLGHIGN
{
	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HCIJLAOPINK();

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DBIPLKHEHMB();

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PLKECINBPDP();

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NHKCNMDDBEL();

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EMFGHMOBDJJ();
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface FIJPNHDDIHB
{
	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IECNPCOEKOB(string BLPDDGCLNPE);

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int HMMKALAEBGK();

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string EHNDMEOIADG();
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface KEBKGACMKPD
{
	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LEJNLFBBHIE(string HEEMGKHJLID, long JBCPGNDLJHB, string APPABFLDNEE, MediaHints CGEFEPGFLNG, int BNLNIKEIFGC = 0, bool MJMDBIEIHMG = false);

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IDLELOHDLCH(byte[] FPGJFOLEKAK);

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KPFGPABKFPO(ulong AJDEGEPLAEO);

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CGOMBGIPJGN(byte[] FOLEMGCPIBM, ulong JBCPGNDLJHB, ulong AJDEGEPLAEO);

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BIEAHHFAACF();

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ACBEEFJJDJF();

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LOLMHICLBEB(bool MKGPJMHLNNJ);

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool LGIBEPJECNB();

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool EOKBNLFNDPF();

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool CLILAPGENKE();

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool PFDMKOJACHM();

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool GKACBBCODGO();

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool LDNHGJAAJFH();

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool HNKHLMMKOBG();

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool KDHEBGFICBK();

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HEKOJIOMLJA();

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KBBEAMBLPCO();

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void ECGOBBCGDJE();

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void CNACLFDIJGK();

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void NLPMHCNKEGN(double LKKNOPLOOPB);

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void COFNIHPMBBJ(double LKKNOPLOOPB);

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(Slot = "21")]
	double CGKEJNFAGKP();

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(Slot = "22")]
	float KDHMAPHBOOM();

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void BEAEFFKGKDH(float HODMIEFFAOA);

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void FNNKPMICNJJ(bool BILFCOFADPE);

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool GJFOOLMIHDG();

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void IEPJFHOHMPG(float IKEDDMJNIJO);

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void JGPDHBIEPON(float LMIGMDBHMHN);

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "28")]
	float FAMDHLNBGPE();

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float NMACCHBHJEI();

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(Slot = "30")]
	FNMEDGNPBEI LPOIMKFDIEL();

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(Slot = "31")]
	GHCKFLJBDJH OACGIHNJHMK();

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void NPHFAGKHJAI(FilterMode JICCDONLJBM = FilterMode.Bilinear, TextureWrapMode NBLIIHHAPLO = TextureWrapMode.Clamp, int KMEGEPIIEKH = 1);

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void KBFBKDJIJJM([Out] FilterMode JICCDONLJBM, [Out] TextureWrapMode NBLIIHHAPLO, [Out] int KMEGEPIIEKH);

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(Slot = "34")]
	int CMPIJMLCJAG(float[] FPGJFOLEKAK, int BJFMLIOLMJE, int MCJPLGCDCKJ);

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(Slot = "35")]
	int GDBEDMPJDND();

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void NAJFNGPPGGE(bool KNIEHHHDKEA);

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void BMDBIABEMKF(BBFMIMIONBN CAKPAAFCOHA);

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void IOGMBKPIPDL(Quaternion EKOCBFMEKAG);

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void HEMHFDGFMHI();

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void DNCPFCIDGIG(bool LEFHPHFNFDO);

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void CNGEIFIGNEK(float EGHOBCOOJNB, float MKABDJGGAFP);

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void JOHMHCAGJLH(Quaternion EKOCBFMEKAG);

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(Slot = "43")]
	bool DNKDFILFCAK(Camera GOPJCLJMGPB, int DBKDNPNHBLF);

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void BKMHHICEHGL(string MFKHKDDANII);

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(Slot = "45")]
	void KFKOPBJIFCL(byte[] HPFHOBCPNEF);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface HGPLPFAPJHK
{
	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(Slot = "0")]
	double PMEKMEOFELN();

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int FKOJKJBNIDI();

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int EBNOKLKNBCK();

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float DIMFCBGDJGH();

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EMMLCIHPPMG();

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BOGCAIACEFO();

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LPNLBBNHHBE();

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float[] CHGAGOIPIHF();
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface KDONLKGEIHO
{
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface LDFGOJKCIJG
{
	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int GetTextureCount();

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Texture GetTexture(int KABGMIEBEFC = 0);

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
	JMNFDNHCLCA GetTextureStereoPacking();

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(Slot = "8")]
	DDBJIDEBBLJ GetTextureTransparency();

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(Slot = "9")]
	GPFAOMIDBNE GetTextureAlphaPacking();

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
	RenderTextureFormat GetCompatibleRenderTextureFormat(POEIPIJOOCG ALFCEIKBPNG = POEIPIJOOCG.Default, int DHOBCGOKNFP = 0);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[Flags]
public enum POEIPIJOOCG
{
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	ForResolve = 1,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	RequiresAlpha = 2
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum MAPINHBEDKP
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
public enum NCHLKIPGCLF
{
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	Reference,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	Path
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public enum CDPFJCFHGLL
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
		private CDPFJCFHGLL _pathType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		[SerializeField]
		private string _path;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public CDPFJCFHGLL PathType
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
			get
			{
				return default(CDPFJCFHGLL);
			}
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public string Path
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3890", Offset = "0x2AA2290", VA = "0x182AA3890")]
		public MediaPath()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3800", Offset = "0x2AA2200", VA = "0x182AA3800")]
		public MediaPath(MediaPath BNKBOCIIBDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3770", Offset = "0x2AA2170", VA = "0x182AA3770")]
		public MediaPath(string HEEMGKHJLID, CDPFJCFHGLL KPJGHCOPAGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x2AA33A0", Offset = "0x2AA1DA0", VA = "0x182AA33A0")]
		public string JGODFMLPFCN()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x2AA32E0", Offset = "0x2AA1CE0", VA = "0x182AA32E0")]
		public static MediaPath HDPJNBPLGPE(string HPKKCNLEGJA)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3750", Offset = "0x2AA2150", VA = "0x182AA3750")]
		public static bool NOPNAEDOCOI(MediaPath EICJFDNFOCB, MediaPath MIBIEOGGIAP)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3150", Offset = "0x2AA1B50", VA = "0x182AA3150")]
		public static bool DFNINOIAFHB(MediaPath EICJFDNFOCB, MediaPath MIBIEOGGIAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3190", Offset = "0x2AA1B90", VA = "0x182AA3190", Slot = "0")]
		public override bool Equals(object PMNHIPACJLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3290", Offset = "0x2AA1C90", VA = "0x182AA3290", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public enum JMNFDNHCLCA
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
		public DDBJIDEBBLJ transparency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public GPFAOMIDBNE alphaPacking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public JMNFDNHCLCA stereoPacking;

		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private static MediaHints defaultHints;

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public static MediaHints Default
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x2AA3100", Offset = "0x2AA1B00", VA = "0x182AA3100")]
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
		public enum EMOCEFEGLEL
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
		public EMOCEFEGLEL aspectRatio;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5320", Offset = "0x2AA3D20", VA = "0x182AA5320")]
		public bool LGAEDOBPIKM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x2AA52F0", Offset = "0x2AA3CF0", VA = "0x182AA52F0")]
		internal void GKNLJJNDKCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5380", Offset = "0x2AA3D80", VA = "0x182AA5380")]
		public static VideoResolveOptions MLAHKGEEKLJ()
		{
			return default(VideoResolveOptions);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public enum DDBJIDEBBLJ
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	Opaque,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	Transparent
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public enum OFCLOCFKGBK
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	Both,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	Left,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	Right
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public enum GPFAOMIDBNE
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	TopBottom,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	LeftRight
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public enum GHCKFLJBDJH
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	LoadFailed = 100,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	DecodeFailed = 200
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public enum HNOAJGFKMFJ
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
public enum GEPIBILIAMH
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
public enum OCMKEPJKDIM
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
public static class MGGAHIBDKHJ
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public enum AHCHGFBGJFF
	{
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		MediaFoundation,
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		DirectShow,
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		WinRT
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public enum FCODHMFKNCI
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
public static class OKDJKCAIGNG
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public enum KNOKJCIFJII
	{
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		MediaFoundation,
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		WinRT
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public enum EBJBCFMJKGH
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
public static class CFIIODKOJGC
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public enum OBDLBMMMIHK
	{
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		MediaPlayer = 1,
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		ExoPlayer
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class OMCEGMCCEJG
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public enum COOCNEDJIJC
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
public enum BBFMIMIONBN
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
public struct NAFBPINEGPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public double OFLPMAPNJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public double NDKGEJPCLBH;
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[DefaultMember("Item")]
public class FNMEDGNPBEI : IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	internal NAFBPINEGPG[] JKEOCKBMJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	internal double IGLDODLPMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	internal double EDEJLKMLODI;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public int BEFNAMGOJCC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x29A0D50", Offset = "0x299F750", VA = "0x1829A0D50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public double FDHJBFHHICJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x2A99D20", Offset = "0x2A98720", VA = "0x182A99D20")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public double PHBPAJKLMGE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x2A99D10", Offset = "0x2A98710", VA = "0x182A99D10")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public double FLKBEKIMIFC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x2A99D50", Offset = "0x2A98750", VA = "0x182A99D50")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x2A99F90", Offset = "0x2A98990", VA = "0x182A99F90")]
	internal FNMEDGNPBEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x2A99D30", Offset = "0x2A98730", VA = "0x182A99D30", Slot = "4")]
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x2A99D60", Offset = "0x2A98760", VA = "0x182A99D60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x2A99BC0", Offset = "0x2A985C0", VA = "0x182A99BC0")]
	internal void DIFOIPBNGEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class LGIBLBBPHHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private int GKMADALLHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private long GLDMPEIPMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private GABHJLCHGNK GLJNIPLLHAO;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public int KEKPPGKALPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public int MPJBPJBCMNG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xBAD7D0", Offset = "0xBAC1D0", VA = "0x180BAD7D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0xBAD7E0", Offset = "0xBAC1E0", VA = "0x180BAD7E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public int LPACNHBDAKG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xAB33F0", Offset = "0xAB1DF0", VA = "0x180AB33F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private float LCGELJNECAI
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xEE12E0", Offset = "0xEDFCE0", VA = "0x180EE12E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private string OGBGCHHIFAN
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private int HMCNKGCDGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xAB33E0", Offset = "0xAB1DE0", VA = "0x180AB33E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0xAB33D0", Offset = "0xAB1DD0", VA = "0x180AB33D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private int MONNDJHKHEE
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xAFDAE0", Offset = "0xAFC4E0", VA = "0x180AFDAE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x16E8640", Offset = "0x16E7040", VA = "0x1816E8640")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool BJDHBLAOFEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0xADB270", Offset = "0xAD9C70", VA = "0x180ADB270")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x2AA30B0", Offset = "0x2AA1AB0", VA = "0x182AA30B0")]
	public void NPPCJNEPLIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x2AA2D00", Offset = "0x2AA1700", VA = "0x182AA2D00")]
	internal void GLFALCCJJDG(GABHJLCHGNK BLHNDOLLIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x2AA23B0", Offset = "0x2AA0DB0", VA = "0x182AA23B0")]
	internal void DBIPLKHEHMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240")]
	private static bool OBIDPHDJEEE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public LGIBLBBPHHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public sealed class AMDNIBBFHFK : GABHJLCHGNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private bool HBJFAOCENAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private bool JLCPMPOFNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private double EEIOPNDPBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private float CDEEBHAGLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private float FADCIODCGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	private bool DIGJDPBPGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private int CFDKMKFGIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private int FPNJKDEEOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	private Texture2D NCLANJHOCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	private Texture2D EKHCCNABGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	private Texture2D AEBGOEFLDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	private float OJCOPGDDEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	private int NAMPMDIMAHM;

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F900", Offset = "0x2A8E300", VA = "0x182A8F900", Slot = "82")]
	public override string BIAMNKJPLHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F8E0", Offset = "0x2A8E2E0", VA = "0x182A8F8E0", Slot = "83")]
	public override string BEGGLKMBLPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x2A8FB60", Offset = "0x2A8E560", VA = "0x182A8FB60", Slot = "84")]
	public override bool LEJNLFBBHIE(string HEEMGKHJLID, long JBCPGNDLJHB, string NEHDJOFBJCA, MediaHints IINPFBHEALF, int BNLNIKEIFGC = 0, bool MJMDBIEIHMG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F8A0", Offset = "0x2A8E2A0", VA = "0x182A8F8A0", Slot = "89")]
	public override void ACBEEFJJDJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0xD75210", Offset = "0xD73C10", VA = "0x180D75210", Slot = "90")]
	public override void LOLMHICLBEB(bool MKGPJMHLNNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x10E8B30", Offset = "0x10E7530", VA = "0x1810E8B30", Slot = "91")]
	public override bool LGIBEPJECNB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240", Slot = "92")]
	public override bool EOKBNLFNDPF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240", Slot = "93")]
	public override bool CLILAPGENKE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "107")]
	public override bool NEBJCKDDAKL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "108")]
	public override bool EMMLCIHPPMG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x2A8FAE0", Offset = "0x2A8E4E0", VA = "0x182A8FAE0", Slot = "94")]
	public override void HEKOJIOMLJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x2A8FB50", Offset = "0x2A8E550", VA = "0x182A8FB50", Slot = "95")]
	public override void KBBEAMBLPCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x2A8FAD0", Offset = "0x2A8E4D0", VA = "0x182A8FAD0", Slot = "96")]
	public override void ECGOBBCGDJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "109")]
	public override bool GKACBBCODGO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0xB797F0", Offset = "0xB781F0", VA = "0x180B797F0", Slot = "110")]
	public override bool PFDMKOJACHM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0xB795A0", Offset = "0xB77FA0", VA = "0x180B795A0", Slot = "111")]
	public override bool LDNHGJAAJFH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x2A8FB00", Offset = "0x2A8E500", VA = "0x182A8FB00", Slot = "112")]
	public override bool HNKHLMMKOBG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "113")]
	public override bool KDHEBGFICBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x2A8FD50", Offset = "0x2A8E750", VA = "0x182A8FD50", Slot = "103")]
	public override double PMEKMEOFELN()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x10E79D0", Offset = "0x10E63D0", VA = "0x1810E79D0", Slot = "104")]
	public override int FKOJKJBNIDI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x1005710", Offset = "0x1004110", VA = "0x181005710", Slot = "105")]
	public override int EBNOKLKNBCK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0xB3D1C0", Offset = "0xB3BBC0", VA = "0x180B3D1C0", Slot = "116")]
	public override Texture GetTexture(int KABGMIEBEFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x17D0420", Offset = "0x17CEE20", VA = "0x1817D0420", Slot = "117")]
	public override int GetTextureFrameCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0xF3C0A0", Offset = "0xF3AAA0", VA = "0x180F3C0A0", Slot = "127")]
	internal override JMNFDNHCLCA FBJPBDBIKEB()
	{
		return default(JMNFDNHCLCA);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "120")]
	public override bool RequiresVerticalFlip()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F940", Offset = "0x2A8E340", VA = "0x182A8F940", Slot = "98")]
	public override void NLPMHCNKEGN(double LKKNOPLOOPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F940", Offset = "0x2A8E340", VA = "0x182A8F940", Slot = "99")]
	public override void COFNIHPMBBJ(double LKKNOPLOOPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F930", Offset = "0x2A8E330", VA = "0x182A8F930", Slot = "100")]
	public override double CGKEJNFAGKP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x16ECA70", Offset = "0x16EB470", VA = "0x1816ECA70", Slot = "102")]
	public override void BEAEFFKGKDH(float HODMIEFFAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x16ECA10", Offset = "0x16EB410", VA = "0x1816ECA10", Slot = "101")]
	public override float KDHMAPHBOOM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "129")]
	public override void FNNKPMICNJJ(bool NPIOFDKLNBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240", Slot = "130")]
	public override bool GJFOOLMIHDG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x1D05670", Offset = "0x1D04070", VA = "0x181D05670", Slot = "131")]
	public override void IEPJFHOHMPG(float IKEDDMJNIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x1D07590", Offset = "0x1D05F90", VA = "0x181D07590", Slot = "133")]
	public override float FAMDHLNBGPE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0xAFDE10", Offset = "0xAFC810", VA = "0x180AFDE10", Slot = "106")]
	public override float DIMFCBGDJGH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F950", Offset = "0x2A8E350", VA = "0x182A8F950", Slot = "146")]
	public override void DBIPLKHEHMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "148")]
	public override void EMFGHMOBDJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "149")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "161")]
	internal override bool DDCCHAGIPDA(AFPKINGMBJK KCLKPKACMJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "162")]
	internal override int MDEMPMHGHMF(AFPKINGMBJK KCLKPKACMJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "163")]
	internal override CJHKMLCMCDI BACPGKBCHHP(AFPKINGMBJK KCLKPKACMJM, int KABGMIEBEFC, bool PDDCHBMDDOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "159")]
	internal override bool PCBHAENNGGD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "160")]
	internal override string KPPAJMOHGFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x2A8FD60", Offset = "0x2A8E760", VA = "0x182A8FD60")]
	public AMDNIBBFHFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class PCFDCJPIAIM
{
	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public string DPIOAKBPMND
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public string EBOBALABOOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public byte[] MAMJMECHENJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3A10", Offset = "0x2AA2410", VA = "0x182AA3A10")]
	public PCFDCJPIAIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3990", Offset = "0x2AA2390", VA = "0x182AA3990")]
	public void EMMOLKMNHIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class KKJOHPEJMGF : GABHJLCHGNK
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	private struct ANCLOEMDMIK
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		internal enum JNOIJGIIDNK
		{
			[Cpp2IlInjected.Token(Token = "0x40002D3")]
			Seekable,
			[Cpp2IlInjected.Token(Token = "0x40002D4")]
			Buffered
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public enum CGHDNONHACN
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
		public struct NNBJGMIONHI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002DA")]
			public string GJEEEEHJACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002DB")]
			public string MFKHKDDANII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002DC")]
			public IntPtr GFFIPEFBEIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			public int GLOEEIFGJDN;
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x2A900F0", Offset = "0x2A8EAF0", VA = "0x182A900F0")]
		public static extern bool BHLBKGHHIDL(IntPtr GMFHHDBKLAN, AFPKINGMBJK KCLKPKACMJM);

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x2A92660", Offset = "0x2A91060", VA = "0x182A92660")]
		public static extern int NDGOKIAPIJH(IntPtr GMFHHDBKLAN, AFPKINGMBJK KCLKPKACMJM);

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x2A923F0", Offset = "0x2A90DF0", VA = "0x182A923F0")]
		public static extern bool MIMOIFOCELF(IntPtr GMFHHDBKLAN, AFPKINGMBJK KCLKPKACMJM, int KABGMIEBEFC, int LAOEGGMOIBD, bool DEEGFHNMGMB, StringBuilder IELIBBNCJAC, int JIAGFAFIBPL, StringBuilder CCOCFJEJLMG, int DJLAKNCHPHE);

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x2A92370", Offset = "0x2A90D70", VA = "0x182A92370")]
		public static extern bool MIFDKKGOOOE(IntPtr GMFHHDBKLAN);

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x2A92800", Offset = "0x2A91200", VA = "0x182A92800")]
		public static extern IntPtr NNKOBPAHCNH(IntPtr GMFHHDBKLAN);

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x2A916B0", Offset = "0x2A900B0", VA = "0x182A916B0")]
		public static extern int JKPHMICMDFO(IntPtr MNFBKCGKNIJ, [Out] NAFBPINEGPG[] BGLHMFOMAPE, int OIGKJCANPOI, JNOIJGIIDNK OHOBIILGIIL);

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x2A91DB0", Offset = "0x2A907B0", VA = "0x182A91DB0")]
		public static extern bool LHEJPJMHOBO(bool BGLGIDIMGAP);

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x2A90E20", Offset = "0x2A8F820", VA = "0x182A90E20")]
		public static extern void IDNAFMBEEMH();

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x2A90210", Offset = "0x2A8EC10", VA = "0x182A90210")]
		public static extern IntPtr BOBAONBLINL();

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x2A914F0", Offset = "0x2A8FEF0", VA = "0x182A914F0")]
		public static extern IntPtr JKKBIIKMMAE(IntPtr GMFHHDBKLAN, MGGAHIBDKHJ.AHCHGFBGJFF BCGKNFLPEKH, MGGAHIBDKHJ.FCODHMFKNCI CMPDCHKGJBC, bool IADPPKHHECO, bool LJBMLHIIOBC, bool PDOGMOMHHKM, bool OGBMKGOFOID, bool CHGLLOEOIIJ, bool BGCHMLPGCMO, string BPEKDBJGPDE, int DBHGKLMONMJ, IntPtr[] IKHMNPOEDOC, uint HFJNCGFBDKO, int JECCPHPFKJG, string NEHDJOFBJCA, bool MJMDBIEIHMG);

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x2A91340", Offset = "0x2A8FD40", VA = "0x182A91340")]
		public static extern IntPtr JBHIBBLJAOF(IntPtr GMFHHDBKLAN, string HEEMGKHJLID);

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x2A8FEB0", Offset = "0x2A8E8B0", VA = "0x182A8FEB0")]
		public static extern IntPtr AOOIBOJJPHE(IntPtr GMFHHDBKLAN, byte[] FPGJFOLEKAK, ulong LLNHENJACCJ, MGGAHIBDKHJ.AHCHGFBGJFF BCGKNFLPEKH, MGGAHIBDKHJ.FCODHMFKNCI CMPDCHKGJBC, bool IADPPKHHECO, bool LJBMLHIIOBC, bool PDOGMOMHHKM, bool OGBMKGOFOID, bool CHGLLOEOIIJ, bool BGCHMLPGCMO, string BPEKDBJGPDE, int DBHGKLMONMJ, IntPtr[] IKHMNPOEDOC, uint HFJNCGFBDKO);

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x2A90880", Offset = "0x2A8F280", VA = "0x182A90880")]
		public static extern IntPtr EJFNCJJPFEF(IntPtr GMFHHDBKLAN, MGGAHIBDKHJ.AHCHGFBGJFF BCGKNFLPEKH, ulong LLNHENJACCJ);

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x2A917E0", Offset = "0x2A901E0", VA = "0x182A917E0")]
		public static extern bool JMKLOBDEMAA(IntPtr GMFHHDBKLAN, byte[] FPGJFOLEKAK, ulong JBCPGNDLJHB, ulong GDJMFFFMNIJ);

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x2A91130", Offset = "0x2A8FB30", VA = "0x182A91130")]
		public static extern IntPtr ILLDMIADGFK(IntPtr GMFHHDBKLAN, MGGAHIBDKHJ.FCODHMFKNCI CMPDCHKGJBC, bool IADPPKHHECO, bool LJBMLHIIOBC, bool PDOGMOMHHKM, bool OGBMKGOFOID, bool CHGLLOEOIIJ, bool BGCHMLPGCMO, string BPEKDBJGPDE, int DBHGKLMONMJ, IntPtr[] IKHMNPOEDOC, uint HFJNCGFBDKO);

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x2A910B0", Offset = "0x2A8FAB0", VA = "0x182A910B0")]
		public static extern void IKADMAMDEIO(IntPtr GMFHHDBKLAN);

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x2A90640", Offset = "0x2A8F040", VA = "0x182A90640")]
		public static extern IntPtr DHFEILNJANA(IntPtr GMFHHDBKLAN);

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x2A912B0", Offset = "0x2A8FCB0", VA = "0x182A912B0")]
		public static extern void JAJAJONBALG(IntPtr GMFHHDBKLAN, bool LEFHPHFNFDO);

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x2A92550", Offset = "0x2A90F50", VA = "0x182A92550")]
		public static extern void NAMAILGBKII(IntPtr GMFHHDBKLAN, bool LEFHPHFNFDO);

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x2A92770", Offset = "0x2A91170", VA = "0x182A92770")]
		public static extern void NKNCOIGDJMA(IntPtr GMFHHDBKLAN, bool LEFHPHFNFDO);

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x2A90760", Offset = "0x2A8F160", VA = "0x182A90760")]
		public static extern void DLNEELLAIFO(IntPtr GMFHHDBKLAN, bool LEFHPHFNFDO);

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x2A91D00", Offset = "0x2A90700", VA = "0x182A91D00")]
		public static extern void LDAGAJPPJOD(IntPtr GMFHHDBKLAN, bool LEFHPHFNFDO, bool DCOEANLMANF, double BNJFNGGEIPK);

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x2A91020", Offset = "0x2A8FA20", VA = "0x182A91020")]
		public static extern void IHKBKMNDDLF(IntPtr GMFHHDBKLAN, bool LEFHPHFNFDO);

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x2A91C60", Offset = "0x2A90660", VA = "0x182A91C60")]
		public static extern void KJANOEMKBJD(IntPtr GMFHHDBKLAN, int KFLGMOOMFAJ, int MBOJIHCOMFN);

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x2A91AE0", Offset = "0x2A904E0", VA = "0x182A91AE0")]
		public static extern int KCNECCDNMFI(IntPtr GMFHHDBKLAN);

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x2A90CA0", Offset = "0x2A8F6A0", VA = "0x182A90CA0")]
		public static extern void HEKOJIOMLJA(IntPtr GMFHHDBKLAN);

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x2A91A60", Offset = "0x2A90460", VA = "0x182A91A60")]
		public static extern void KBBEAMBLPCO(IntPtr GMFHHDBKLAN);

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x2A90AA0", Offset = "0x2A8F4A0", VA = "0x182A90AA0")]
		public static extern void FKCKCLDLLHH(IntPtr GMFHHDBKLAN, bool EHBGINECADE);

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x2A90E90", Offset = "0x2A8F890", VA = "0x182A90E90")]
		public static extern void IEPJFHOHMPG(IntPtr GMFHHDBKLAN, float IKEDDMJNIJO);

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x2A91460", Offset = "0x2A8FE60", VA = "0x182A91460")]
		public static extern void JGPDHBIEPON(IntPtr GMFHHDBKLAN, float IKEDDMJNIJO);

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x2A91E30", Offset = "0x2A90830", VA = "0x182A91E30")]
		public static extern void LOLMHICLBEB(IntPtr GMFHHDBKLAN, bool MAJEBNDNBGF);

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x2A90920", Offset = "0x2A8F320", VA = "0x182A90920")]
		public static extern bool EMMLCIHPPMG(IntPtr GMFHHDBKLAN);

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x2A926F0", Offset = "0x2A910F0", VA = "0x182A926F0")]
		public static extern bool NEBJCKDDAKL(IntPtr GMFHHDBKLAN);

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x2A90F20", Offset = "0x2A8F920", VA = "0x182A90F20")]
		public static extern int IFPIDLOKIKB(IntPtr GMFHHDBKLAN);

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x2A90A20", Offset = "0x2A8F420", VA = "0x182A90A20")]
		public static extern int FHDFNFIEPCH(IntPtr GMFHHDBKLAN);

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x2A925E0", Offset = "0x2A90FE0", VA = "0x182A925E0")]
		public static extern float NCGDOACDOGF(IntPtr GMFHHDBKLAN);

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x2A8FD90", Offset = "0x2A8E790", VA = "0x182A8FD90")]
		public static extern JMNFDNHCLCA AECEKJDOBAF(IntPtr GMFHHDBKLAN);

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x2A92AC0", Offset = "0x2A914C0", VA = "0x182A92AC0")]
		public static extern double PMEKMEOFELN(IntPtr GMFHHDBKLAN);

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x2A91EC0", Offset = "0x2A908C0", VA = "0x182A91EC0")]
		public static extern bool LPNLBBNHHBE(IntPtr GMFHHDBKLAN);

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x2A909A0", Offset = "0x2A8F3A0", VA = "0x182A909A0")]
		public static extern bool EOKBNLFNDPF(IntPtr GMFHHDBKLAN);

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x2A90400", Offset = "0x2A8EE00", VA = "0x182A90400")]
		public static extern bool CLILAPGENKE(IntPtr GMFHHDBKLAN);

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x2A90C20", Offset = "0x2A8F620", VA = "0x182A90C20")]
		public static extern bool GKACBBCODGO(IntPtr GMFHHDBKLAN);

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x2A92880", Offset = "0x2A91280", VA = "0x182A92880")]
		public static extern bool PFDMKOJACHM(IntPtr GMFHHDBKLAN);

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x2A90DA0", Offset = "0x2A8F7A0", VA = "0x182A90DA0")]
		public static extern bool HNKHLMMKOBG(IntPtr GMFHHDBKLAN);

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x2A91B60", Offset = "0x2A90560", VA = "0x182A91B60")]
		public static extern bool KDHEBGFICBK(IntPtr GMFHHDBKLAN);

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x2A90300", Offset = "0x2A8ED00", VA = "0x182A90300")]
		public static extern double CGKEJNFAGKP(IntPtr GMFHHDBKLAN);

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x2A8FE10", Offset = "0x2A8E810", VA = "0x182A8FE10")]
		public static extern void AFGIMGMBEPA(IntPtr GMFHHDBKLAN, double LKKNOPLOOPB, bool JIMDIOGAEDC);

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x2A91BE0", Offset = "0x2A905E0", VA = "0x182A91BE0")]
		public static extern float KDHMAPHBOOM(IntPtr GMFHHDBKLAN);

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x2A90060", Offset = "0x2A8EA60", VA = "0x182A90060")]
		public static extern void BEAEFFKGKDH(IntPtr GMFHHDBKLAN, float HODMIEFFAOA);

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x2A92900", Offset = "0x2A91300", VA = "0x182A92900")]
		public static extern void PJDIDCPMDLH(IntPtr GMFHHDBKLAN);

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x2A913E0", Offset = "0x2A8FDE0", VA = "0x182A913E0")]
		public static extern void JFCCNJFHCPD(IntPtr GMFHHDBKLAN);

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x2A905C0", Offset = "0x2A8EFC0", VA = "0x182A905C0")]
		public static extern void DBIPLKHEHMB(IntPtr GMFHHDBKLAN);

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x2A92A40", Offset = "0x2A91440", VA = "0x182A92A40")]
		public static extern void PLKECINBPDP(IntPtr GMFHHDBKLAN);

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x2A919E0", Offset = "0x2A903E0", VA = "0x182A919E0")]
		public static extern IntPtr KANLFOEKJHO(IntPtr GMFHHDBKLAN);

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x2A90FA0", Offset = "0x2A8F9A0", VA = "0x182A90FA0")]
		public static extern int IHCIMPOEAMP(IntPtr GMFHHDBKLAN);

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x2A90D20", Offset = "0x2A8F720", VA = "0x182A90D20")]
		public static extern bool HJOPBIJPPEC(IntPtr GMFHHDBKLAN);

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x2A90380", Offset = "0x2A8ED80", VA = "0x182A90380")]
		public static extern bool CKECGJLAFCA(IntPtr GMFHHDBKLAN);

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x2A91960", Offset = "0x2A90360", VA = "0x182A91960")]
		public static extern int KAEKKECDFFI(IntPtr GMFHHDBKLAN);

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x2A90280", Offset = "0x2A8EC80", VA = "0x182A90280")]
		public static extern long CFKLOBNDALE(IntPtr GMFHHDBKLAN);

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x2A90480", Offset = "0x2A8EE80", VA = "0x182A90480")]
		public static extern float CMADMCFLJGK(IntPtr GMFHHDBKLAN);

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x2A90BB0", Offset = "0x2A8F5B0", VA = "0x182A90BB0")]
		public static extern IntPtr GGCMEIKEPPK();

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x2A90500", Offset = "0x2A8EF00", VA = "0x182A90500")]
		public static extern int CMPIJMLCJAG(IntPtr GMFHHDBKLAN, float[] FPGJFOLEKAK, int BJFMLIOLMJE, int MCJPLGCDCKJ);

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x2A90B30", Offset = "0x2A8F530", VA = "0x182A90B30")]
		public static extern int GDBEDMPJDND(IntPtr GMFHHDBKLAN);

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x2A90180", Offset = "0x2A8EB80", VA = "0x182A90180")]
		public static extern int BMDBIABEMKF(IntPtr GMFHHDBKLAN, int JECCPHPFKJG);

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x2A92980", Offset = "0x2A91380", VA = "0x182A92980")]
		public static extern void PKJGODEKDED(IntPtr GMFHHDBKLAN, float FKPKEFAKAOE, float KEEMKILMOML, float JLNCPHFMCKO, float LIPBKGAOLBA);

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x2A907F0", Offset = "0x2A8F1F0", VA = "0x182A907F0")]
		public static extern void DNCPFCIDGIG(IntPtr GMFHHDBKLAN, bool LEFHPHFNFDO);

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x2A906C0", Offset = "0x2A8F0C0", VA = "0x182A906C0")]
		public static extern void DIHPMCACJEB(IntPtr GMFHHDBKLAN, float EGHOBCOOJNB, float MKABDJGGAFP);

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x2A918A0", Offset = "0x2A902A0", VA = "0x182A918A0")]
		public static extern void JOHMHCAGJLH(IntPtr GMFHHDBKLAN, float FKPKEFAKAOE, float KEEMKILMOML, float JLNCPHFMCKO, float LIPBKGAOLBA);

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x2A91F40", Offset = "0x2A90940", VA = "0x182A91F40")]
		public static void MGKCOBANNLD(IntPtr GMFHHDBKLAN, PCFDCJPIAIM LMHCNNFGBJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x2A92210", Offset = "0x2A90C10", VA = "0x182A92210")]
		private static extern void MGKCOBANNLD(IntPtr GMFHHDBKLAN, NNBJGMIONHI IJJFFADPEHI);
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	private MGGAHIBDKHJ.FCODHMFKNCI OMOPBFHPMKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	private string DMPBLFOBHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	private List<string> PPDMBAPMBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	private BBFMIMIONBN ELFOKNOAOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	private bool FBKBOLDAAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC5")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	private bool PPJFEDDBKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC6")]
	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	private bool IGHDAELGNOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC7")]
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	private bool NKNPDCJOMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	private bool BFPMPJLJEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	private bool DIJCNCEGDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	private int GIKCGGDEICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	private int DFHEABIHKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	private bool HBJFAOCENAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD5")]
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	private bool JLCPMPOFNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD6")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	private bool JKNJDKHDDIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private float CDEEBHAGLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private float MDKFPMOAKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private bool MJNJJLAGPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private bool LLGPEMCOEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE2")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private bool ILFANHOHPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private int GNFJDPPEDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private int FPNJKDEEOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private float GHMLOFCGKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private bool EACILDKGAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF1")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	private bool DHHGFGJNPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF2")]
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	private bool NLKHNMOFLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	private IntPtr DCKMDJPAPKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	private Texture2D NCLANJHOCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	private RenderTexture BEACDAKAMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	private IntPtr GHBNEILHBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private MGGAHIBDKHJ.AHCHGFBGJFF ADMNAMNPOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private bool GBBPLBBEHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11D")]
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private bool BHIBKHPEBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11E")]
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	private bool IFNFGLLBEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11F")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	private bool GOCEMJCLLAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	private bool IBLJCDMJOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x121")]
	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	private bool OHKNKPMKFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x122")]
	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	private bool MJNNAGHKAMH;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	private static bool EBKCFHIBMHM;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	private static string MMJBEKALPAG;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	private static IntPtr CFGCEEIDCBC;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	private static int PGGLKBNLLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	private PCFDCJPIAIM LLADFKLJPAP;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public PCFDCJPIAIM OBAKLEIOCJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x2A9DC30", Offset = "0x2A9C630", VA = "0x182A9DC30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x2A9FF00", Offset = "0x2A9E900", VA = "0x182A9FF00")]
	public static bool JLPLDFJKODI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F580", Offset = "0x2A9DF80", VA = "0x182A9F580")]
	public static void HGFKLEAFGNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F0F0", Offset = "0x2A9DAF0", VA = "0x182A9F0F0", Slot = "135")]
	public override int GDBEDMPJDND()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x2AA2090", Offset = "0x2AA0A90", VA = "0x182AA2090")]
	public KKJOHPEJMGF(MediaPlayer.OptionsWindows ALFCEIKBPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x2AA1DB0", Offset = "0x2AA07B0", VA = "0x182AA1DB0")]
	public void OFONCBCLPCN(MediaPlayer.OptionsWindows ALFCEIKBPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x2AA1B70", Offset = "0x2AA0570", VA = "0x182AA1B70")]
	public void OFONCBCLPCN(MGGAHIBDKHJ.AHCHGFBGJFF BCGKNFLPEKH, MGGAHIBDKHJ.FCODHMFKNCI CMPDCHKGJBC, bool IADPPKHHECO, bool LJBMLHIIOBC, bool HEEEBDKCHDD, bool BGCHMLPGCMO, bool OGBMKGOFOID, bool CHGLLOEOIIJ, string CGBABHDNOGP, List<string> NOPNALOHIBD, bool GHBJMGIKJHP, int KFLGMOOMFAJ, int MBOJIHCOMFN, bool AIOAPGPKENE, bool KDAFCJLIELJ, bool LIDKICLHDCN, bool CPHLGEDFJPC, bool POLDNAJEFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x2A9D800", Offset = "0x2A9C200", VA = "0x182A9D800", Slot = "82")]
	public override string BIAMNKJPLHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x2A9D7D0", Offset = "0x2A9C1D0", VA = "0x182A9D7D0", Slot = "83")]
	public override string BEGGLKMBLPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F750", Offset = "0x2A9E150", VA = "0x182A9F750")]
	private bool ICFGDEDNKHK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x2AA0800", Offset = "0x2A9F200", VA = "0x182AA0800", Slot = "84")]
	public override bool LEJNLFBBHIE(string HEEMGKHJLID, long JBCPGNDLJHB, string NEHDJOFBJCA, MediaHints IINPFBHEALF, int BNLNIKEIFGC = 0, bool MJMDBIEIHMG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F760", Offset = "0x2A9E160", VA = "0x182A9F760", Slot = "85")]
	public override bool IDLELOHDLCH(byte[] FPGJFOLEKAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x2AA05D0", Offset = "0x2A9EFD0", VA = "0x182AA05D0", Slot = "86")]
	public override bool KPFGPABKFPO(ulong AJDEGEPLAEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x2A9DE90", Offset = "0x2A9C890", VA = "0x182A9DE90", Slot = "87")]
	public override bool CGOMBGIPJGN(byte[] FOLEMGCPIBM, ulong JBCPGNDLJHB, ulong AJDEGEPLAEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x2A9D850", Offset = "0x2A9C250", VA = "0x182A9D850", Slot = "88")]
	public override bool BIEAHHFAACF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x2AA11C0", Offset = "0x2A9FBC0", VA = "0x182AA11C0")]
	private void LFNBBGILMLA(string HEEMGKHJLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x2A9D1D0", Offset = "0x2A9BBD0", VA = "0x182A9D1D0", Slot = "89")]
	public override void ACBEEFJJDJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x2AA12F0", Offset = "0x2A9FCF0", VA = "0x182AA12F0", Slot = "90")]
	public override void LOLMHICLBEB(bool MAJEBNDNBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0xB79850", Offset = "0xB78250", VA = "0x180B79850", Slot = "91")]
	public override bool LGIBEPJECNB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0xB79860", Offset = "0xB78260", VA = "0x180B79860", Slot = "92")]
	public override bool EOKBNLFNDPF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x17726B0", Offset = "0x17710B0", VA = "0x1817726B0", Slot = "107")]
	public override bool NEBJCKDDAKL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x2692B20", Offset = "0x2691520", VA = "0x182692B20", Slot = "108")]
	public override bool EMMLCIHPPMG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0xB79630", Offset = "0xB78030", VA = "0x180B79630", Slot = "93")]
	public override bool CLILAPGENKE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F3E0", Offset = "0x2A9DDE0", VA = "0x182A9F3E0", Slot = "94")]
	public override void HEKOJIOMLJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x2AA03D0", Offset = "0x2A9EDD0", VA = "0x182AA03D0", Slot = "95")]
	public override void KBBEAMBLPCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x2A9B620", Offset = "0x2A9A020", VA = "0x182A9B620", Slot = "96")]
	public override void ECGOBBCGDJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F170", Offset = "0x2A9DB70", VA = "0x182A9F170", Slot = "109")]
	public override bool GKACBBCODGO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x2AA1EF0", Offset = "0x2AA08F0", VA = "0x182AA1EF0", Slot = "110")]
	public override bool PFDMKOJACHM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x2AA07C0", Offset = "0x2A9F1C0", VA = "0x182AA07C0", Slot = "111")]
	public override bool LDNHGJAAJFH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F630", Offset = "0x2A9E030", VA = "0x182A9F630", Slot = "112")]
	public override bool HNKHLMMKOBG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x2AA0460", Offset = "0x2A9EE60", VA = "0x182AA0460", Slot = "113")]
	public override bool KDHEBGFICBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x2AA1F80", Offset = "0x2AA0980", VA = "0x182AA1F80", Slot = "103")]
	public override double PMEKMEOFELN()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x1F672D0", Offset = "0x1F65CD0", VA = "0x181F672D0", Slot = "104")]
	public override int FKOJKJBNIDI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0xB50850", Offset = "0xB4F250", VA = "0x180B50850", Slot = "105")]
	public override int EBNOKLKNBCK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x22A2610", Offset = "0x22A1010", VA = "0x1822A2610", Slot = "106")]
	public override float DIMFCBGDJGH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F340", Offset = "0x2A9DD40", VA = "0x182A9F340", Slot = "116")]
	public override Texture GetTexture(int KABGMIEBEFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F200", Offset = "0x2A9DC00", VA = "0x182A9F200", Slot = "117")]
	public override int GetTextureFrameCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F2C0", Offset = "0x2A9DCC0", VA = "0x182A9F2C0", Slot = "119")]
	public override long GetTextureTimeStamp()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F210", Offset = "0x2A9DC10", VA = "0x182A9F210", Slot = "121")]
	public override float GetTexturePixelAspectRatio()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x2717750", Offset = "0x2716150", VA = "0x182717750", Slot = "120")]
	public override bool RequiresVerticalFlip()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x2A9EFE0", Offset = "0x2A9D9E0", VA = "0x182A9EFE0", Slot = "127")]
	internal override JMNFDNHCLCA FBJPBDBIKEB()
	{
		return default(JMNFDNHCLCA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x2AA1B50", Offset = "0x2AA0550", VA = "0x182AA1B50", Slot = "98")]
	public override void NLPMHCNKEGN(double LKKNOPLOOPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x2A9E0B0", Offset = "0x2A9CAB0", VA = "0x182A9E0B0", Slot = "99")]
	public override void COFNIHPMBBJ(double LKKNOPLOOPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x2A9DE10", Offset = "0x2A9C810", VA = "0x182A9DE10", Slot = "100")]
	public override double CGKEJNFAGKP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x2A9D740", Offset = "0x2A9C140", VA = "0x182A9D740", Slot = "102")]
	public override void BEAEFFKGKDH(float HODMIEFFAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x2AA04F0", Offset = "0x2A9EEF0", VA = "0x182AA04F0", Slot = "101")]
	public override float KDHMAPHBOOM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F060", Offset = "0x2A9DA60", VA = "0x182A9F060", Slot = "129")]
	public override void FNNKPMICNJJ(bool NPIOFDKLNBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x27176F0", Offset = "0x27160F0", VA = "0x1827176F0", Slot = "130")]
	public override bool GJFOOLMIHDG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x2A9FBF0", Offset = "0x2A9E5F0", VA = "0x182A9FBF0", Slot = "131")]
	public override void IEPJFHOHMPG(float IKEDDMJNIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0xC35990", Offset = "0xC34390", VA = "0x180C35990", Slot = "133")]
	public override float FAMDHLNBGPE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x2A9FE60", Offset = "0x2A9E860", VA = "0x182A9FE60", Slot = "132")]
	public override void JGPDHBIEPON(float LMIGMDBHMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x1FF6900", Offset = "0x1FF5300", VA = "0x181FF6900", Slot = "134")]
	public override float NMACCHBHJEI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x2AA1310", Offset = "0x2A9FD10", VA = "0x182AA1310", Slot = "153")]
	public override bool LPNLBBNHHBE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x2A9ED10", Offset = "0x2A9D710", VA = "0x182A9ED10", Slot = "114")]
	public override bool DNKDFILFCAK(Camera GOPJCLJMGPB, int DBKDNPNHBLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x2A9DCD0", Offset = "0x2A9C6D0", VA = "0x182A9DCD0", Slot = "140")]
	public override void BMDBIABEMKF(BBFMIMIONBN CAKPAAFCOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x2A9FC10", Offset = "0x2A9E610", VA = "0x182A9FC10", Slot = "138")]
	public override void IOGMBKPIPDL(Quaternion EKOCBFMEKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F470", Offset = "0x2A9DE70", VA = "0x182A9F470", Slot = "139")]
	public override void HEMHFDGFMHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x2A9EC80", Offset = "0x2A9D680", VA = "0x182A9EC80", Slot = "141")]
	public override void DNCPFCIDGIG(bool LEFHPHFNFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x2A9E010", Offset = "0x2A9CA10", VA = "0x182A9E010", Slot = "142")]
	public override void CNGEIFIGNEK(float EGHOBCOOJNB, float MKABDJGGAFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x2AA0320", Offset = "0x2A9ED20", VA = "0x182AA0320", Slot = "143")]
	public override void JOHMHCAGJLH(Quaternion EKOCBFMEKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x2A9E1A0", Offset = "0x2A9CBA0", VA = "0x182A9E1A0", Slot = "146")]
	public override void DBIPLKHEHMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x2A9FC50", Offset = "0x2A9E650", VA = "0x182A9FC50")]
	private void JAMJMPBAAFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x2AA1460", Offset = "0x2A9FE60", VA = "0x182AA1460")]
	private void MKHCKHBCJOO(IntPtr MIPHLOMKIHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x2AA1F00", Offset = "0x2AA0900", VA = "0x182AA1F00", Slot = "150")]
	public override void PLKECINBPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
	private void KELIFFPLJHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x2AA1A90", Offset = "0x2AA0490", VA = "0x182AA1A90", Slot = "147")]
	public override void NHKCNMDDBEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x2A9EEE0", Offset = "0x2A9D8E0", VA = "0x182A9EEE0", Slot = "148")]
	public override void EMFGHMOBDJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "149")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x2A9DF50", Offset = "0x2A9C950", VA = "0x182A9DF50", Slot = "136")]
	public override int CMPIJMLCJAG(float[] FPGJFOLEKAK, int BJFMLIOLMJE, int MCJPLGCDCKJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x22FDB90", Offset = "0x22FC590", VA = "0x1822FDB90", Slot = "151")]
	public override bool BOGCAIACEFO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x2A9FD80", Offset = "0x2A9E780", VA = "0x182A9FD80")]
	private static void JCNPFOBMJJP(ANCLOEMDMIK.CGHDNONHACN DFEGNOMHEBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x2A9DD60", Offset = "0x2A9C760", VA = "0x182A9DD60")]
	private static string BOBAONBLINL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x2AA1E60", Offset = "0x2AA0860", VA = "0x182AA1E60", Slot = "159")]
	internal override bool PCBHAENNGGD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x2AA06D0", Offset = "0x2A9F0D0", VA = "0x182AA06D0", Slot = "160")]
	internal override string KPPAJMOHGFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x2A9EBE0", Offset = "0x2A9D5E0", VA = "0x182A9EBE0", Slot = "161")]
	internal override bool DDCCHAGIPDA(AFPKINGMBJK KCLKPKACMJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x2AA13C0", Offset = "0x2A9FDC0", VA = "0x182AA13C0", Slot = "162")]
	internal override int MDEMPMHGHMF(AFPKINGMBJK KCLKPKACMJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x2A9D390", Offset = "0x2A9BD90", VA = "0x182A9D390", Slot = "163")]
	internal override CJHKMLCMCDI BACPGKBCHHP(AFPKINGMBJK KCLKPKACMJM, int CACJCJEPCNM, bool PDDCHBMDDOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x2A9DC70", Offset = "0x2A9C670", VA = "0x182A9DC70", Slot = "144")]
	public override void BKMHHICEHGL(string MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x2AA0570", Offset = "0x2A9EF70", VA = "0x182AA0570", Slot = "145")]
	public override void KFKOPBJIFCL(byte[] HPFHOBCPNEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F6E0", Offset = "0x2A9E0E0", VA = "0x182A9F6E0")]
	private void IAPKGOAINBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x2A9E0D0", Offset = "0x2A9CAD0", VA = "0x182A9E0D0")]
	private void DAALELPMBDA(NAFBPINEGPG[] FBOHMIMNCKO, ANCLOEMDMIK.JNOIJGIIDNK OHOBIILGIIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public enum HKBHKONKGEG
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
public sealed class HBFKICDBBIG : GABHJLCHGNK
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	private struct PCPDDCJMOJI
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		public enum FCHJDAAFCEA
		{
			[Cpp2IlInjected.Token(Token = "0x40002F3")]
			Fast,
			[Cpp2IlInjected.Token(Token = "0x40002F4")]
			Accurate
		}

		[StructLayout((LayoutKind)0, Pack = 1, Size = 20)]
		[Cpp2IlInjected.Token(Token = "0x2000065")]
		public struct DMNLPBNHDNE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002F5")]
			public int CACJCJEPCNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002F6")]
			public int FPPFKILFOJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002F7")]
			public int MHFJLBNNDIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40002F8")]
			public float MLJOONJEMAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002F9")]
			public uint KFNNGJPIBFH;
		}

		[StructLayout((LayoutKind)0, Pack = 1, Size = 12)]
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		public struct GLNDLKFCKMM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002FA")]
			public double BNJFNGGEIPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002FB")]
			public FCHJDAAFCEA GDIJNLEACAN;
		}

		[StructLayout((LayoutKind)0, Pack = 1, Size = 28)]
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		public struct JPFFLMIBDEE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002FC")]
			public string GJEEEEHJACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002FD")]
			public string MFKHKDDANII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002FE")]
			public IntPtr GFFIPEFBEIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002FF")]
			public int GLOEEIFGJDN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		internal enum CCPJGMJJDBK
		{
			[Cpp2IlInjected.Token(Token = "0x4000301")]
			Seekable,
			[Cpp2IlInjected.Token(Token = "0x4000302")]
			Buffered
		}

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private static IntPtr CFGCEEIDCBC;

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3DB0", Offset = "0x2AA27B0", VA = "0x182AA3DB0")]
		public static extern bool BHLBKGHHIDL(IntPtr GMFHHDBKLAN, AFPKINGMBJK KCLKPKACMJM);

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5050", Offset = "0x2AA3A50", VA = "0x182AA5050")]
		public static extern int NDGOKIAPIJH(IntPtr GMFHHDBKLAN, AFPKINGMBJK KCLKPKACMJM);

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4EF0", Offset = "0x2AA38F0", VA = "0x182AA4EF0")]
		public static extern bool MIMOIFOCELF(IntPtr GMFHHDBKLAN, AFPKINGMBJK KCLKPKACMJM, int KABGMIEBEFC, int LAOEGGMOIBD, bool DEEGFHNMGMB, StringBuilder IELIBBNCJAC, int JIAGFAFIBPL, StringBuilder CCOCFJEJLMG, int DJLAKNCHPHE);

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4E70", Offset = "0x2AA3870", VA = "0x182AA4E70")]
		public static extern bool MIFDKKGOOOE(IntPtr GMFHHDBKLAN);

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5170", Offset = "0x2AA3B70", VA = "0x182AA5170")]
		public static extern IntPtr NNKOBPAHCNH(IntPtr GMFHHDBKLAN);

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4E00", Offset = "0x2AA3800", VA = "0x182AA4E00")]
		private static extern IntPtr MHOOCCBLOAA();

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3E40", Offset = "0x2AA2840", VA = "0x182AA3E40")]
		public static string BOBAONBLINL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3CB0", Offset = "0x2AA26B0", VA = "0x182AA3CB0")]
		public static extern IntPtr AMJJHJHKFIG();

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x2AA51F0", Offset = "0x2AA3BF0", VA = "0x182AA51F0")]
		public static extern void OFLHGJNFFHH(IntPtr MNFBKCGKNIJ);

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4860", Offset = "0x2AA3260", VA = "0x182AA4860")]
		public static extern bool LEJNLFBBHIE(IntPtr MNFBKCGKNIJ, string JAKIJIEGAGG, string NEHDJOFBJCA, OCMKEPJKDIM IEAHCBDCIIP, bool MJMDBIEIHMG, bool BGCHMLPGCMO);

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3A90", Offset = "0x2AA2490", VA = "0x182AA3A90")]
		public static extern void ACBEEFJJDJF(IntPtr MNFBKCGKNIJ);

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x2AA45C0", Offset = "0x2AA2FC0", VA = "0x182AA45C0")]
		public static extern void KBBEAMBLPCO(IntPtr MNFBKCGKNIJ);

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4390", Offset = "0x2AA2D90", VA = "0x182AA4390")]
		public static extern void HEKOJIOMLJA(IntPtr MNFBKCGKNIJ);

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4740", Offset = "0x2AA3140", VA = "0x182AA4740")]
		public static extern void KENINLCDEPC(IntPtr MNFBKCGKNIJ, float IKEDDMJNIJO);

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3C20", Offset = "0x2AA2620", VA = "0x182AA3C20")]
		public static extern void AJNILCECHPF(IntPtr MNFBKCGKNIJ, float LMIGMDBHMHN);

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3D20", Offset = "0x2AA2720", VA = "0x182AA3D20")]
		public static extern void BEAEFFKGKDH(IntPtr MNFBKCGKNIJ, float HODMIEFFAOA);

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4210", Offset = "0x2AA2C10", VA = "0x182AA4210")]
		public static extern void EGAPPJNGIGO(IntPtr MNFBKCGKNIJ, bool EHBGINECADE);

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4090", Offset = "0x2AA2A90", VA = "0x182AA4090")]
		public static extern bool CLAAMGHFDDB(IntPtr MNFBKCGKNIJ);

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x2AA42A0", Offset = "0x2AA2CA0", VA = "0x182AA42A0")]
		public static extern float FBNOCLPOKGI(IntPtr MNFBKCGKNIJ);

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x2AA46C0", Offset = "0x2AA30C0", VA = "0x182AA46C0")]
		public static extern float KDHMAPHBOOM(IntPtr MNFBKCGKNIJ);

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4940", Offset = "0x2AA3340", VA = "0x182AA4940")]
		public static extern void LOLMHICLBEB(IntPtr MNFBKCGKNIJ, bool MAJEBNDNBGF);

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4640", Offset = "0x2AA3040", VA = "0x182AA4640")]
		public static extern int KCNECCDNMFI(IntPtr MNFBKCGKNIJ);

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4110", Offset = "0x2AA2B10", VA = "0x182AA4110")]
		public static extern void DBIPLKHEHMB(IntPtr MNFBKCGKNIJ);

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5270", Offset = "0x2AA3C70", VA = "0x182AA5270")]
		public static extern double PMEKMEOFELN(IntPtr MNFBKCGKNIJ);

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3B10", Offset = "0x2AA2510", VA = "0x182AA3B10")]
		public static extern JMNFDNHCLCA AECEKJDOBAF(IntPtr MNFBKCGKNIJ);

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4410", Offset = "0x2AA2E10", VA = "0x182AA4410")]
		public static extern double IHKMFFPKLDC(IntPtr MNFBKCGKNIJ);

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3FC0", Offset = "0x2AA29C0", VA = "0x182AA3FC0")]
		public static extern bool CJOICNHFFAD(IntPtr MNFBKCGKNIJ, [Out] IntPtr NLOEDAJNIEL, [Out] IntPtr NNIMAFKIOEE, [Out] ulong OBHKFFDAPCM, [Out] int ANOHMOCFGAJ, [Out] int NJLBPEGOCCN);

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4190", Offset = "0x2AA2B90", VA = "0x182AA4190")]
		public static extern HKBHKONKGEG DNMHENNIHPK(IntPtr MNFBKCGKNIJ);

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x2AA47D0", Offset = "0x2AA31D0", VA = "0x182AA47D0")]
		public static extern bool KFOGJPPMKMK(IntPtr MNFBKCGKNIJ, [Out] DMNLPBNHDNE IBDOIGFBCNL);

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3B90", Offset = "0x2AA2590", VA = "0x182AA3B90")]
		public static extern void AGPAAFLGCPH(IntPtr MNFBKCGKNIJ, double JHMKMDEDCJN);

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x2AA50E0", Offset = "0x2AA3AE0", VA = "0x182AA50E0")]
		public static extern void NLPMHCNKEGN(IntPtr MNFBKCGKNIJ, GLNDLKFCKMM KDFLHJHJAIE);

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x2AA49D0", Offset = "0x2AA33D0", VA = "0x182AA49D0")]
		public static void MGKCOBANNLD(IntPtr MNFBKCGKNIJ, PCFDCJPIAIM LMHCNNFGBJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4CA0", Offset = "0x2AA36A0", VA = "0x182AA4CA0")]
		private static extern void MGKCOBANNLD(IntPtr MNFBKCGKNIJ, JPFFLMIBDEE IJJFFADPEHI);

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4490", Offset = "0x2AA2E90", VA = "0x182AA4490")]
		public static extern int JKPHMICMDFO(IntPtr MNFBKCGKNIJ, [Out] NAFBPINEGPG[] BGLHMFOMAPE, int OIGKJCANPOI, CCPJGMJJDBK OHOBIILGIIL);

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4320", Offset = "0x2AA2D20", VA = "0x182AA4320")]
		public static extern IntPtr GGCMEIKEPPK();

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B640", Offset = "0x2A9A040", VA = "0x182A9B640")]
		public static void CFKJPOEGCIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3EF0", Offset = "0x2AA28F0", VA = "0x182AA3EF0")]
		public static void CFIAINBOOHI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private class FEEHPKGJKFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public Texture2D JBOOEIGKOID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public IntPtr AFHNPKPDLDP;

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x2A95CC0", Offset = "0x2A946C0", VA = "0x182A95CC0")]
		public void OKCDDGFOJCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x2A95DA0", Offset = "0x2A947A0", VA = "0x182A95DA0")]
		public FEEHPKGJKFK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private bool CJJNPFKIDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private bool MJNJJLAGPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private float CDEEBHAGLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	private bool GOCEMJCLLAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	private bool LDAHONMOLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private PCFDCJPIAIM LLADFKLJPAP;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private static bool EBKCFHIBMHM;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private static string MMJBEKALPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private ulong PDPAHPIAGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private IntPtr OLHHAALPGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private FEEHPKGJKFK[] KJMNKCBCOGE;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public PCFDCJPIAIM OBAKLEIOCJN
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x2A9A950", Offset = "0x2A99350", VA = "0x182A9A950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x2A9C8C0", Offset = "0x2A9B2C0", VA = "0x182A9C8C0")]
	public HBFKICDBBIG(MediaPlayer.OptionsWindows ALFCEIKBPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x2A9C750", Offset = "0x2A9B150", VA = "0x182A9C750")]
	public void OFONCBCLPCN(MediaPlayer.OptionsWindows ALFCEIKBPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x2A9AA70", Offset = "0x2A99470", VA = "0x182A9AA70", Slot = "93")]
	public override bool CLILAPGENKE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x2A9B330", Offset = "0x2A99D30", VA = "0x182A9B330", Slot = "149")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "151")]
	public override bool BOGCAIACEFO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x2A9A9F0", Offset = "0x2A993F0", VA = "0x182A9A9F0", Slot = "100")]
	public override double CGKEJNFAGKP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x2A9C830", Offset = "0x2A9B230", VA = "0x182A9C830", Slot = "103")]
	public override double PMEKMEOFELN()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x2A9C0C0", Offset = "0x2A9AAC0", VA = "0x182A9C0C0", Slot = "101")]
	public override float KDHMAPHBOOM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x2A9BAA0", Offset = "0x2A9A4A0", VA = "0x182A9BAA0", Slot = "116")]
	public override Texture GetTexture(int KABGMIEBEFC = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x2A9BA10", Offset = "0x2A9A410", VA = "0x182A9BA10", Slot = "115")]
	public override int GetTextureCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x1EE3830", Offset = "0x1EE2230", VA = "0x181EE3830", Slot = "117")]
	public override int GetTextureFrameCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x2A9B780", Offset = "0x2A9A180", VA = "0x182A9B780", Slot = "127")]
	internal override JMNFDNHCLCA FBJPBDBIKEB()
	{
		return default(JMNFDNHCLCA);
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x2A9A900", Offset = "0x2A99300", VA = "0x182A9A900", Slot = "82")]
	public override string BIAMNKJPLHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x2A9A8D0", Offset = "0x2A992D0", VA = "0x182A9A8D0", Slot = "83")]
	public override string BEGGLKMBLPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x2A9B280", Offset = "0x2A99C80", VA = "0x182A9B280", Slot = "106")]
	public override float DIMFCBGDJGH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x2A9B800", Offset = "0x2A9A200", VA = "0x182A9B800", Slot = "104")]
	public override int FKOJKJBNIDI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x2A9B550", Offset = "0x2A99F50", VA = "0x182A9B550", Slot = "105")]
	public override int EBNOKLKNBCK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x1DB7690", Offset = "0x1DB6090", VA = "0x181DB7690", Slot = "133")]
	public override float FAMDHLNBGPE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x2A9BD00", Offset = "0x2A9A700", VA = "0x182A9BD00", Slot = "132")]
	public override void JGPDHBIEPON(float LMIGMDBHMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x2A9C6D0", Offset = "0x2A9B0D0", VA = "0x182A9C6D0", Slot = "134")]
	public override float NMACCHBHJEI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x2A9C600", Offset = "0x2A9B000", VA = "0x182A9C600", Slot = "107")]
	public override bool NEBJCKDDAKL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x2A9B750", Offset = "0x2A9A150", VA = "0x182A9B750", Slot = "92")]
	public override bool EOKBNLFNDPF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x2A9B710", Offset = "0x2A9A110", VA = "0x182A9B710", Slot = "108")]
	public override bool EMMLCIHPPMG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x2A9C0A0", Offset = "0x2A9AAA0", VA = "0x182A9C0A0", Slot = "113")]
	public override bool KDHEBGFICBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x2A9BBC0", Offset = "0x2A9A5C0", VA = "0x182A9BBC0", Slot = "112")]
	public override bool HNKHLMMKOBG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0xB795A0", Offset = "0xB77FA0", VA = "0x180B795A0", Slot = "91")]
	public override bool LGIBEPJECNB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x2A9B960", Offset = "0x2A9A360", VA = "0x182A9B960", Slot = "130")]
	public override bool GJFOOLMIHDG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x2A9C290", Offset = "0x2A9AC90", VA = "0x182A9C290", Slot = "111")]
	public override bool LDNHGJAAJFH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x2A9C810", Offset = "0x2A9B210", VA = "0x182A9C810", Slot = "110")]
	public override bool PFDMKOJACHM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x2A9B9F0", Offset = "0x2A9A3F0", VA = "0x182A9B9F0", Slot = "109")]
	public override bool GKACBBCODGO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x2A9B8D0", Offset = "0x2A9A2D0", VA = "0x182A9B8D0", Slot = "129")]
	public override void FNNKPMICNJJ(bool NPIOFDKLNBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x2A9C2B0", Offset = "0x2A9ACB0", VA = "0x182A9C2B0", Slot = "84")]
	public override bool LEJNLFBBHIE(string HEEMGKHJLID, long JBCPGNDLJHB, string NEHDJOFBJCA, MediaHints IINPFBHEALF, int BNLNIKEIFGC = 0, bool MJMDBIEIHMG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x2A9A010", Offset = "0x2A98A10", VA = "0x182A9A010", Slot = "89")]
	public override void ACBEEFJJDJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x2A9C020", Offset = "0x2A9AA20", VA = "0x182A9C020", Slot = "95")]
	public override void KBBEAMBLPCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x2A9BAF0", Offset = "0x2A9A4F0", VA = "0x182A9BAF0", Slot = "94")]
	public override void HEKOJIOMLJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x2A9B640", Offset = "0x2A9A040", VA = "0x182A9B640", Slot = "148")]
	public override void EMFGHMOBDJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x2A9A0C0", Offset = "0x2A98AC0", VA = "0x182A9A0C0")]
	private void AODLEICBOJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240", Slot = "120")]
	public override bool RequiresVerticalFlip()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x2A9C640", Offset = "0x2A9B040", VA = "0x182A9C640", Slot = "98")]
	public override void NLPMHCNKEGN(double LKKNOPLOOPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x2A9AA90", Offset = "0x2A99490", VA = "0x182A9AA90", Slot = "99")]
	public override void COFNIHPMBBJ(double LKKNOPLOOPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x2A9C550", Offset = "0x2A9AF50", VA = "0x182A9C550", Slot = "90")]
	public override void LOLMHICLBEB(bool MKGPJMHLNNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x2A9A840", Offset = "0x2A99240", VA = "0x182A9A840", Slot = "102")]
	public override void BEAEFFKGKDH(float HODMIEFFAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x2A9BCE0", Offset = "0x2A9A6E0", VA = "0x182A9BCE0", Slot = "131")]
	public override void IEPJFHOHMPG(float IKEDDMJNIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x2A9B620", Offset = "0x2A9A020", VA = "0x182A9B620", Slot = "96")]
	public override void ECGOBBCGDJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x2A9BC70", Offset = "0x2A9A670", VA = "0x182A9BC70")]
	private void IAPKGOAINBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x2A9AAB0", Offset = "0x2A994B0", VA = "0x182A9AAB0")]
	private void DAALELPMBDA(NAFBPINEGPG[] FBOHMIMNCKO, PCPDDCJMOJI.CCPJGMJJDBK OHOBIILGIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x2A9AB80", Offset = "0x2A99580", VA = "0x182A9AB80", Slot = "146")]
	public override void DBIPLKHEHMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x2A9A990", Offset = "0x2A99390", VA = "0x182A9A990", Slot = "144")]
	public override void BKMHHICEHGL(string MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x2A9C140", Offset = "0x2A9AB40", VA = "0x182A9C140", Slot = "145")]
	public override void KFKOPBJIFCL(byte[] HPFHOBCPNEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x2A9B1F0", Offset = "0x2A99BF0", VA = "0x182A9B1F0", Slot = "161")]
	internal override bool DDCCHAGIPDA(AFPKINGMBJK KCLKPKACMJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x2A9C570", Offset = "0x2A9AF70", VA = "0x182A9C570", Slot = "162")]
	internal override int MDEMPMHGHMF(AFPKINGMBJK KCLKPKACMJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x2A9A4E0", Offset = "0x2A98EE0", VA = "0x182A9A4E0", Slot = "163")]
	internal override CJHKMLCMCDI BACPGKBCHHP(AFPKINGMBJK KCLKPKACMJM, int CACJCJEPCNM, bool PDDCHBMDDOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x2A9C780", Offset = "0x2A9B180", VA = "0x182A9C780", Slot = "159")]
	internal override bool PCBHAENNGGD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x2A9C1A0", Offset = "0x2A9ABA0", VA = "0x182A9C1A0", Slot = "160")]
	internal override string KPPAJMOHGFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2A9BD90", Offset = "0x2A9A790", VA = "0x182A9BD90")]
	public static bool JLPLDFJKODI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x2A9BB70", Offset = "0x2A9A570", VA = "0x182A9BB70")]
	public static void HGFKLEAFGNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class AHDCKBPNELD
{
	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public string MCFBIHIKFGH
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0xABA5E0", Offset = "0xAB8FE0", VA = "0x180ABA5E0")]
	internal AHDCKBPNELD(string AKEJFNGKBEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public enum AFPKINGMBJK
{
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	Video,
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	Audio,
	[Cpp2IlInjected.Token(Token = "0x4000309")]
	Text
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class CJHKMLCMCDI
{
	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public int CEGJBMMBANO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	private AFPKINGMBJK PMHEIFBHNEN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0xBAD7E0", Offset = "0xBAC1E0", VA = "0x180BAD7E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	private string MCPKJMFBHPC
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public string GGIHGIHLIEE
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private bool HDJAOOOJBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xADAFF0", Offset = "0xAD99F0", VA = "0x180ADAFF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x2A92C40", Offset = "0x2A91640", VA = "0x182A92C40")]
	internal CJHKMLCMCDI(AFPKINGMBJK KCLKPKACMJM, int LAOEGGMOIBD, string IELIBBNCJAC, string CCOCFJEJLMG, bool FAFKIJMEICM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x2A92B80", Offset = "0x2A91580", VA = "0x182A92B80")]
	protected string JDMOBFNEJMJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public abstract class KAHKLGFPODH : IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public virtual AFPKINGMBJK PMHEIFBHNEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(AFPKINGMBJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public abstract int BEFNAMGOJCC
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
	internal abstract void EMMOLKMNHIK();

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void HMDNMGBNKIA(CJHKMLCMCDI EHFNKGGPCIO);

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract void BJOBOIACNIA(CJHKMLCMCDI EHFNKGGPCIO);

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	protected KAHKLGFPODH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[DefaultMember("Item")]
public class IFENOMLJELD<T> : KAHKLGFPODH where T : CJHKMLCMCDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	internal List<T> JCIDGMIKJOP;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	internal T DCDIPEHBJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public override int BEFNAMGOJCC
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x52E0690", Offset = "0x52DF090", VA = "0x1852E0690", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x52E06D0", Offset = "0x52DF0D0", VA = "0x1852E06D0")]
	internal IFENOMLJELD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x52E0520", Offset = "0x52DEF20", VA = "0x1852E0520", Slot = "7")]
	public override IEnumerator GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x52E04C0", Offset = "0x52DEEC0", VA = "0x1852E04C0", Slot = "8")]
	internal override void EMMOLKMNHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x52E05B0", Offset = "0x52DEFB0", VA = "0x1852E05B0", Slot = "9")]
	internal override void HMDNMGBNKIA(CJHKMLCMCDI EHFNKGGPCIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x52E03F0", Offset = "0x52DEDF0", VA = "0x1852E03F0", Slot = "10")]
	internal override void BJOBOIACNIA(CJHKMLCMCDI EHFNKGGPCIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class BPOBCDLJEGH : IFENOMLJELD<OCMONDCMCDA>
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public override AFPKINGMBJK PMHEIFBHNEN
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "5")]
		get
		{
			return default(AFPKINGMBJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x2A92B40", Offset = "0x2A91540", VA = "0x182A92B40")]
	public BPOBCDLJEGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class HKNILCENEPK : IFENOMLJELD<HCNAJOELKEB>
{
	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public override AFPKINGMBJK PMHEIFBHNEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0xC43520", Offset = "0xC41F20", VA = "0x180C43520", Slot = "5")]
		get
		{
			return default(AFPKINGMBJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x2A9CAF0", Offset = "0x2A9B4F0", VA = "0x182A9CAF0")]
	public HKNILCENEPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class FKFJGLJGINK : IFENOMLJELD<JKCEMJOBJJJ>
{
	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public override AFPKINGMBJK PMHEIFBHNEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0xC56A80", Offset = "0xC55480", VA = "0x180C56A80", Slot = "5")]
		get
		{
			return default(AFPKINGMBJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x2A96F00", Offset = "0x2A95900", VA = "0x182A96F00")]
	public FKFJGLJGINK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class OCMONDCMCDA : CJHKMLCMCDI
{
	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3910", Offset = "0x2AA2310", VA = "0x182AA3910")]
	internal OCMONDCMCDA(int LAOEGGMOIBD, string IELIBBNCJAC, string CCOCFJEJLMG, bool FAFKIJMEICM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class HCNAJOELKEB : CJHKMLCMCDI
{
	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x2A9CAC0", Offset = "0x2A9B4C0", VA = "0x182A9CAC0")]
	internal HCNAJOELKEB(int LAOEGGMOIBD, string IELIBBNCJAC, string CCOCFJEJLMG, bool FAFKIJMEICM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class JKCEMJOBJJJ : CJHKMLCMCDI
{
	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x2A9D1A0", Offset = "0x2A9BBA0", VA = "0x182A9D1A0")]
	internal JKCEMJOBJJJ(int LAOEGGMOIBD, string IELIBBNCJAC, string CCOCFJEJLMG, bool FAFKIJMEICM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface BAEGDPICBGL
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface HODDBBEOBGJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface DJMENNNFNHN
{
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public static class AIDCNOKABAE
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public enum KCHDBBOGDGF
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
	[Cpp2IlInjected.Address(RVA = "0x2A8F100", Offset = "0x2A8DB00", VA = "0x182A8F100")]
	public static Func<float, float> FGLOLOCEDHF(KCHDBBOGDGF FLLOPDBMKKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x2A8EE80", Offset = "0x2A8D880", VA = "0x182A8EE80")]
	public static float AMKANCODGMM(float GGMLEPFJHKP, float CAGAFLPJDAC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F710", Offset = "0x2A8E110", VA = "0x182A8F710")]
	public static float IMMGOJFMALI(float GGMLEPFJHKP, float CAGAFLPJDAC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F080", Offset = "0x2A8DA80", VA = "0x182A8F080")]
	public static float FBHKPILOLHC(float GGMLEPFJHKP, float CAGAFLPJDAC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F060", Offset = "0x2A8DA60", VA = "0x182A8F060")]
	public static float ENPPILIONMJ(float GGMLEPFJHKP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
	public static float DPLJIBMFHNI(float GGMLEPFJHKP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F6F0", Offset = "0x2A8E0F0", VA = "0x182A8F6F0")]
	public static float IEEEPJABGAJ(float GGMLEPFJHKP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F790", Offset = "0x2A8E190", VA = "0x182A8F790")]
	public static float LEHHAAMOMPC(float GGMLEPFJHKP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x2A8EFE0", Offset = "0x2A8D9E0", VA = "0x182A8EFE0")]
	public static float DIPEMLNNMMO(float GGMLEPFJHKP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F700", Offset = "0x2A8E100", VA = "0x182A8F700")]
	public static float IHOJNJEGAPG(float GGMLEPFJHKP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x2A8EF10", Offset = "0x2A8D910", VA = "0x182A8EF10")]
	public static float BJACBKHHKOI(float GGMLEPFJHKP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x2A8EF50", Offset = "0x2A8D950", VA = "0x182A8EF50")]
	public static float CHIEBLCLFPH(float GGMLEPFJHKP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x2A8EFD0", Offset = "0x2A8D9D0", VA = "0x182A8EFD0")]
	public static float DANDNMCNPON(float GGMLEPFJHKP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F670", Offset = "0x2A8E070", VA = "0x182A8F670")]
	public static float GIKCNBDCKCJ(float GGMLEPFJHKP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x2A8EE90", Offset = "0x2A8D890", VA = "0x182A8EE90")]
	public static float APDKOBFHJHC(float GGMLEPFJHKP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x2A8EDE0", Offset = "0x2A8D7E0", VA = "0x182A8EDE0")]
	public static float AFAHJJDDKNP(float GGMLEPFJHKP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F750", Offset = "0x2A8E150", VA = "0x182A8F750")]
	public static float LEGJOLOJAGL(float GGMLEPFJHKP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F820", Offset = "0x2A8E220", VA = "0x182A8F820")]
	public static float PMNAOGBDECC(float GGMLEPFJHKP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F6B0", Offset = "0x2A8E0B0", VA = "0x182A8F6B0")]
	public static float GLEBLLAMIIP(float GGMLEPFJHKP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F7D0", Offset = "0x2A8E1D0", VA = "0x182A8F7D0")]
	public static float NICHLFEMPBH(float GGMLEPFJHKP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x2A8EDF0", Offset = "0x2A8D7F0", VA = "0x182A8EDF0")]
	public static float AHOCPELJAHF(float GGMLEPFJHKP)
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
		[Cpp2IlInjected.Address(RVA = "0x2A9CE30", Offset = "0x2A9B830", VA = "0x182A9CE30")]
		public bool EBANNPLEDEK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x2A9CFF0", Offset = "0x2A9B9F0", VA = "0x182A9CFF0")]
		public string OIFDILIFDGP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x2A9CEE0", Offset = "0x2A9B8E0", VA = "0x182A9CEE0")]
		public static bool OEBGFPNJFBL(string AKEJFNGKBEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x2A9CE70", Offset = "0x2A9B870", VA = "0x182A9CE70")]
		private static bool NMHMDGGLCPE(string AKEJFNGKBEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x2A9CFB0", Offset = "0x2A9B9B0", VA = "0x182A9CFB0")]
		private bool OEBGFPNJFBL()
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
		[Cpp2IlInjected.Address(RVA = "0x2A9CB30", Offset = "0x2A9B530", VA = "0x182A9CB30", Slot = "4")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x2A9CBB0", Offset = "0x2A9B5B0", VA = "0x182A9CBB0")]
		public string OIFDILIFDGP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x2A9CDA0", Offset = "0x2A9B7A0", VA = "0x182A9CDA0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x2AA22D0", Offset = "0x2AA0CD0", VA = "0x182AA22D0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public KeyAuthData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class FMKCEIIHLNJ
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private class NLMKFCICJEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public RenderTexture JBOOEIGKOID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public long NBNEJFGOCGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public bool EPMENDBOAAH;

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public NLMKFCICJEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public enum BNHCKNCEMNF
	{
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		POINT,
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		LINEAR
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private List<NLMKFCICJEA[]> EALKMFOFJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private MediaPlayer HKKOMLFPGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private RenderTexture[] MJMPPEKFPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private int LIGIGNNHDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private int KOOHJPIKEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private int NFJIGKIMEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private long OHECKOEHDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private float HIBLCLCOGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private Material EMMEDAIHKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private BNHCKNCEMNF GDNECENAMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private string KGHHGPDHHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private long GLDMPEIPMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private int BGOAAAAPNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private long DIHGOLHBFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private int DAJIEIAGLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	private long MNFKHPLCNFK;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	private const string OBLEOCIOALP = "_t";

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	private const string KIMGKODCAHE = "_AfterTex";

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000341")]
	private int FFHCGFOANOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000342")]
	private int IPHMLEJDOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000343")]
	private float MPGDBMLECDK;

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private float NJONFADHHHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x167DC50", Offset = "0x167C650", VA = "0x18167DC50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	private long NFPJKJPNHNM
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x2A98D80", Offset = "0x2A97780", VA = "0x182A98D80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public Texture[] FKNHFEBNCDB
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x2A98480", Offset = "0x2A96E80", VA = "0x182A98480")]
	public void FEDCLOBALHA(MediaPlayer IBNLHPFFIEL, MediaPlayerEvent.OPGAEJDGMGO DBMNAJLECLK, GHCKFLJBDJH NGDAMNDJLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x2A998D0", Offset = "0x2A982D0", VA = "0x182A998D0")]
	public FMKCEIIHLNJ(MediaPlayer BLHNDOLLIDD, string IELIBBNCJAC, int KEDDEALNKLA = 2, BNHCKNCEMNF BGEFDOFKHAH = BNHCKNCEMNF.LINEAR)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x2A993E0", Offset = "0x2A97DE0", VA = "0x182A993E0")]
	public void NPPCJNEPLIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x2A98D90", Offset = "0x2A97790", VA = "0x182A98D90")]
	public void KKMANOPBDMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x2A97F00", Offset = "0x2A96900", VA = "0x182A97F00")]
	private void EMBMNODKEBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x2A98560", Offset = "0x2A96F60", VA = "0x182A98560")]
	private void IMHBMPOFOPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x2A98E50", Offset = "0x2A97850", VA = "0x182A98E50")]
	private bool LILIAECEBHE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x2A996B0", Offset = "0x2A980B0", VA = "0x182A996B0")]
	private int OJIGCFLKOJE(int CCADJLBHFBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x2A99200", Offset = "0x2A97C00", VA = "0x182A99200")]
	private int NAEFHIOACGL(int CCADJLBHFBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x2A98150", Offset = "0x2A96B50", VA = "0x182A98150")]
	private void EPKIFBJGKNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x2A96F40", Offset = "0x2A95940", VA = "0x182A96F40")]
	private void BGGJILPKIDF(int CCADJLBHFBN, int OFJBNNMHANB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x2A99400", Offset = "0x2A97E00", VA = "0x182A99400")]
	private void OGAFABBNIAO(int OFJBNNMHANB, int JAPOLLEPDOB, int IDDFEHCCNLE, float GGMLEPFJHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x2A970A0", Offset = "0x2A95AA0", VA = "0x182A970A0")]
	private void CCMDMMCDBOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x2A97E00", Offset = "0x2A96800", VA = "0x182A97E00")]
	private void DFOCJEBHIJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x2A98AE0", Offset = "0x2A974E0", VA = "0x182A98AE0")]
	private float JNCOPCPEIAL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x2A972D0", Offset = "0x2A95CD0", VA = "0x182A972D0")]
	public void DBIPLKHEHMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x2A993C0", Offset = "0x2A97DC0", VA = "0x182A993C0")]
	public void NAOKDOCKMOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class FPCCDOHHPKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public int KABGMIEBEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public string AKEJFNGKBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public double PADIMHGPBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public double MJAFHOAOJJH;

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x2A99FF0", Offset = "0x2A989F0", VA = "0x182A99FF0")]
	public bool MNGHEFALCAL(double LKKNOPLOOPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public FPCCDOHHPKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public class DMDOGODCBCM
{
	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x2A95740", Offset = "0x2A94140", VA = "0x182A95740")]
	private static double HPLCCOILABC(string AKEJFNGKBEL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x2A95880", Offset = "0x2A94280", VA = "0x182A95880")]
	public static List<FPCCDOHHPKP> KGJELFGODLK(string BLPDDGCLNPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct OIGDOFJJJDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private string KGHHGPDHHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private int NFGFHJEGJDG;

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public int BKICOPKGOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3940", Offset = "0x2AA2340", VA = "0x182AA3940")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3970", Offset = "0x2AA2370", VA = "0x182AA3970")]
	public OIGDOFJJJDO(string IELIBBNCJAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class CLBGMPJIHKK
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[Flags]
	public enum PNFJAJPGNAI
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
	public static readonly OIGDOFJJJDO KPDKJMCHOHJ;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly OIGDOFJJJDO CFNPHAHJJAC;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly OIGDOFJJJDO AJJOOOACIID;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly OIGDOFJJJDO JJCAGHBNJIA;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly OIGDOFJJJDO HIEAEBJNNKO;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly OIGDOFJJJDO ONHGPKMIIPP;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly OIGDOFJJJDO AEJEAOJENGI;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly OIGDOFJJJDO PCPCKDGGCGA;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly OIGDOFJJJDO GLLJEOCHJHC;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly OIGDOFJJJDO OKNKMLEMANO;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static string HAMBMFEMPMC;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly OIGDOFJJJDO LFNONFCACCO;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly OIGDOFJJJDO BBINEPMOLEL;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly OIGDOFJJJDO JBHBEKPJCOJ;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly OIGDOFJJJDO DCBCGAOBJME;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly OIGDOFJJJDO GJGFLIJHAID;

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x2A92D50", Offset = "0x2A91750", VA = "0x182A92D50")]
	public static Material EDFMLLECEKM(bool ICPKMGBAOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x2A94540", Offset = "0x2A92F40", VA = "0x182A94540")]
	public static void MIJFHAIMPDK(Material PJPBFBIEGMK, GEPIBILIAMH PACCPKIAHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x2A94EB0", Offset = "0x2A938B0", VA = "0x182A94EB0")]
	public static void OKEDFBDCAOM(Material PJPBFBIEGMK, JMNFDNHCLCA MFHLFPOBGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x2A941F0", Offset = "0x2A92BF0", VA = "0x182A941F0")]
	public static void KMGHPMBFJAJ(Material PJPBFBIEGMK, GPFAOMIDBNE MFHLFPOBGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x2A94330", Offset = "0x2A92D30", VA = "0x182A94330")]
	public static void KNFEMIIBPKK(Material PJPBFBIEGMK, bool KMCFFJLKJLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x2A940F0", Offset = "0x2A92AF0", VA = "0x182A940F0")]
	public static void KHCPDFAKBLJ(Material PJPBFBIEGMK, Matrix4x4 HALOMIKDIAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x2A93570", Offset = "0x2A91F70", VA = "0x182A93570")]
	public static void JMNLDIJJCDP(Material PJPBFBIEGMK, bool ODHACGINIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x2A93410", Offset = "0x2A91E10", VA = "0x182A93410")]
	public static Texture INKLGALPLMC(MediaPlayer FFICBEDFFMG, int BOJMJDHJCHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x2A93B30", Offset = "0x2A92530", VA = "0x182A93B30")]
	public static void KDLKCCEAAKD(Material PJPBFBIEGMK, MediaPlayer FFICBEDFFMG, int JONIOHPIAKB = -1, [Optional] Texture ADHJINBLJOP, bool GBMDBJNJIKF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x2A93620", Offset = "0x2A92020", VA = "0x182A93620")]
	internal static void JOEBPBIBJIH(Material PJPBFBIEGMK, bool DDLLOAAAELC, bool KMCFFJLKJLA, Matrix4x4 DEANECLODEH, Texture FOBPFNECEPD, Matrix4x4 EOGIMBDCPKC, GEPIBILIAMH PACCPKIAHJG = GEPIBILIAMH.Normal, JMNFDNHCLCA NJGJGHJAMKA = JMNFDNHCLCA.None, GPFAOMIDBNE EANIPDGKJGJ = GPFAOMIDBNE.None)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x2A94BD0", Offset = "0x2A935D0", VA = "0x182A94BD0")]
	public static void NICDNBOMHOL(Material PJPBFBIEGMK, VideoResolveOptions ALFCEIKBPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x2A945E0", Offset = "0x2A92FE0", VA = "0x182A945E0")]
	public static RenderTexture MPFEJGBLAKJ(Material LABDJHJCMNG, RenderTexture EINBDCPNOKK, LDFGOJKCIJG JBOOEIGKOID, PNFJAJPGNAI JHBIAAAGFJK, ScaleMode NPGHPABMMEH = ScaleMode.StretchToFill)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x2A943C0", Offset = "0x2A92DC0", VA = "0x182A943C0")]
	public static void MEJJPLMDECI(GPFAOMIDBNE EANIPDGKJGJ, JMNFDNHCLCA NJGJGHJAMKA, OFCLOCFKGBK GCCAGPCHGPF, float JABFMEELCEB, Matrix4x4 PKFEMNMLJMA, int ANOHMOCFGAJ, int NJLBPEGOCCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x2A92DF0", Offset = "0x2A917F0", VA = "0x182A92DF0")]
	public static void ENLLCLJPNHE(Rect FGDLIKHJFJG, Texture JBOOEIGKOID, ScaleMode NPGHPABMMEH, GPFAOMIDBNE EANIPDGKJGJ, float JABFMEELCEB, Material PJPBFBIEGMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public enum HMDLBCNDJIF
{
	[Cpp2IlInjected.Token(Token = "0x4000367")]
	SDR,
	[Cpp2IlInjected.Token(Token = "0x4000368")]
	HLG,
	[Cpp2IlInjected.Token(Token = "0x4000369")]
	PQ
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public enum DJFBEAMEODO : uint
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
public class ICALBHAONBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400037A")]
	private int FFHLOJBNDOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400037B")]
	private int FPJBGLEBMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400037C")]
	private int GJDJEGMCKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400037D")]
	private int IPNCHIKJIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400037E")]
	private int MELNADGPGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400037F")]
	private DJFBEAMEODO MBCNGKJNKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000380")]
	private float DMJICGEBGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000381")]
	private HMDLBCNDJIF AMIKEGCOJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000382")]
	private DJFBEAMEODO BGKPNCANPKP;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	private static ICALBHAONBL BAECPFDPOJI;

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x2A9D120", Offset = "0x2A9BB20", VA = "0x182A9D120")]
	public ICALBHAONBL(int HKGPAFNMHMJ, int AKNDEMHAGCM, int FOFBIAFEEGG, int IKGBDMDMGCO, int HOKBHLOJADC = 0, DJFBEAMEODO IALGGHJCOJO = DJFBEAMEODO.unknown, float NMDKALLJEMK = 0f, HMDLBCNDJIF OACGEIFFEIB = HMDLBCNDJIF.SDR, DJFBEAMEODO ADEDEDOKIII = DJFBEAMEODO.unknown)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[DefaultMember("Item")]
public interface LDMNOMMHDFN : IEnumerable
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
