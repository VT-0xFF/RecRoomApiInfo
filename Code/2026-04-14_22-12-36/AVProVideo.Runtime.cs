using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.Serialization;
using UnityEngine.Video;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class ApplyToFarPlane_CameraApplier : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[SerializeField]
	private Material _material;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Material KSFJLDIUTJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xCF1770", Offset = "0xCF0370", VA = "0x180CF1770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2AA22C0", Offset = "0x2AA0EC0", VA = "0x182AA22C0")]
	private void OnWillRenderObject()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xCEFF20", Offset = "0xCEEB20", VA = "0x180CEFF20")]
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
		[Header("Platform Overrides")]
		[SerializeField]
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
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A10", Offset = "0xCF0610", VA = "0x180CF1A10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public MediaPath MediaPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xCF1770", Offset = "0xCF0370", VA = "0x180CF1770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public MediaHints Hints
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xECAF90", Offset = "0xEC9B90", VA = "0x180ECAF90")]
			get
			{
				return default(MediaHints);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xECB0E0", Offset = "0xEC9CE0", VA = "0x180ECB0E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2AB1850", Offset = "0x2AB0450", VA = "0x182AB1850")]
		public MediaReference GetCurrentPlatformMediaReference()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2AB18C0", Offset = "0x2AB04C0", VA = "0x182AB18C0")]
		public MediaReference GetPlatformMediaReference(Platform platform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2AB1950", Offset = "0x2AB0550", VA = "0x182AB1950")]
		public MediaReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AddComponentMenu("AVPro Video/Apply To Far Plane", 300)]
	[HelpURL("https://www.renderheads.com/products/avpro-video/")]
	public sealed class ApplyToFarPlane : ApplyToBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum Eye
		{
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			Left,
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			Right
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[Header("Shader Options")]
		[Tooltip("The color override to apply to the material")]
		[SerializeField]
		private Color _mainColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[Tooltip("The Main Texture that is being written to by the Media Player")]
		[SerializeField]
		private Texture _texture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[Tooltip("The Chroma Texture to apply to the material")]
		[SerializeField]
		private Texture _chroma;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[Tooltip("Alpha of the far plane that is drawn")]
		[SerializeField]
		private float _alpha;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[Tooltip("The Camera far plane to draw to, if left empty main cam will be selected")]
		[SerializeField]
		private Camera _camera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[Tooltip("The aspect ratio of the video shown, not used when a custom scaling is set")]
		[SerializeField]
		private VideoAspectRatio _aspectRatio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[Tooltip("How much to offset the image by")]
		public Vector2 _drawOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[Tooltip("Will replace the Aspect Ratio with custom scaling for the video, when both values are non-zero")]
		public Vector2 _customScaling;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private GameObject CIULVTBTVMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool TGEETDWBBTX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[Header("Display")]
		[Tooltip("Default texture to display when the video texture is preparing")]
		[SerializeField]
		private Texture2D _defaultTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[Tooltip("The Material to use when rendering the video, if not set will use internal \n Note: Material must use the AVProVideo/Background/AVProVideo-ApplyToFarPlane shader")]
		[SerializeField]
		private Material _material;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		private string _texturePropertyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Vector2 _offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private Vector2 _scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private Texture FGIXWFQKFBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private LazyShaderProperty XEFEOEUMWUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private LazyShaderProperty WSVOTVFXICO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private Texture KOOYULZNIXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Vector2 WEKYEVRKRHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Vector2 BAREGRWEECZ;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Color VQBWHFCQEPK
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x166D350", Offset = "0x166BF50", VA = "0x18166D350")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x2AA40F0", Offset = "0x2AA2CF0", VA = "0x182AA40F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Texture DPNAWKZJIJZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xCF42E0", Offset = "0xCF2EE0", VA = "0x180CF42E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2AA4340", Offset = "0x2AA2F40", VA = "0x182AA4340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Texture CZCPNTSYSKS
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xCEE120", Offset = "0xCECD20", VA = "0x180CEE120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2AA3DE0", Offset = "0x2AA29E0", VA = "0x182AA3DE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float QMNXSLTPZLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x12B84C0", Offset = "0x12B70C0", VA = "0x1812B84C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2AA3C60", Offset = "0x2AA2860", VA = "0x182AA3C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Camera JWJSLJKTSLR
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xCEE130", Offset = "0xCECD30", VA = "0x180CEE130")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2AA3D10", Offset = "0x2AA2910", VA = "0x182AA3D10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public VideoAspectRatio PXQWFBXLREW
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xE06CD0", Offset = "0xE058D0", VA = "0x180E06CD0")]
			get
			{
				return default(VideoAspectRatio);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x2AA4400", Offset = "0x2AA3000", VA = "0x182AA4400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Vector2 UDGFGRKVJXD
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x12B84D0", Offset = "0x12B70D0", VA = "0x1812B84D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2AA4010", Offset = "0x2AA2C10", VA = "0x182AA4010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Vector2 DVAXOFXRFQI
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x12AF210", Offset = "0x12ADE10", VA = "0x1812AF210")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2AA3EA0", Offset = "0x2AA2AA0", VA = "0x182AA3EA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Texture2D GNOUHNWCUSY
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xD1EC20", Offset = "0xD1D820", VA = "0x180D1EC20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x2AA3F80", Offset = "0x2AA2B80", VA = "0x182AA3F80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public string LDOLKKLXTTH
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xDD4470", Offset = "0xDD3070", VA = "0x180DD4470")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2AA4250", Offset = "0x2AA2E50", VA = "0x182AA4250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Vector2 RFBIZEQGAWX
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2AA3C20", Offset = "0x2AA2820", VA = "0x182AA3C20")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2AA41B0", Offset = "0x2AA2DB0", VA = "0x182AA41B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Vector2 JBTKORXHGDU
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2AA3C40", Offset = "0x2AA2840", VA = "0x182AA3C40")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x2AA4200", Offset = "0x2AA2E00", VA = "0x182AA4200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private Vector2 WTFOMIJBDOE
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x2AA3550", Offset = "0x2AA2150", VA = "0x182AA3550")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2AA21D0", Offset = "0x2AA0DD0", VA = "0x182AA21D0")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2A50", Offset = "0x2AA1650", VA = "0x182AA2A50", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2A00", Offset = "0x2AA1600", VA = "0x182AA2A00")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2AA38E0", Offset = "0x2AA24E0", VA = "0x182AA38E0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2AA24D0", Offset = "0x2AA10D0", VA = "0x182AA24D0")]
		public Mesh CreateQuadMesh()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2370", Offset = "0x2AA0F70", VA = "0x182AA2370")]
		public void CreateMaterial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2B30", Offset = "0x2AA1730", VA = "0x182AA2B30", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xD4FD60", Offset = "0xD4E960", VA = "0x180D4FD60")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3620", Offset = "0x2AA2220", VA = "0x182AA3620")]
		public void UpdateMaterialProperties(int target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1C90", Offset = "0x2AA0890", VA = "0x182AA1C90", Slot = "8")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3080", Offset = "0x2AA1C80", VA = "0x182AA3080")]
		private void SAWXDCPKFMG(Texture a, bool b, int c = 0, Eye d = Eye.Left)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2E40", Offset = "0x2AA1A40", VA = "0x182AA2E40", Slot = "6")]
		protected override void RDKWBKPVFMQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2860", Offset = "0x2AA1460", VA = "0x182AA2860", Slot = "7")]
		protected override void MAHZOPDWLVB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3AA0", Offset = "0x2AA26A0", VA = "0x182AA3AA0")]
		public ApplyToFarPlane()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[AddComponentMenu("AVPro Video/Apply To Material", 300)]
	[HelpURL("https://www.renderheads.com/products/avpro-video/")]
	public sealed class ApplyToMaterial : ApplyToBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private enum Eye
		{
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			Left,
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			Right
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[Header("Display")]
		[Tooltip("Default texture to display when the video texture is preparing")]
		[SerializeField]
		private Texture2D _defaultTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[Space(8f)]
		[Header("Material Target")]
		[SerializeField]
		private Material _material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[SerializeField]
		private string _texturePropertyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		private Vector2 _offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[SerializeField]
		private Vector2 _scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private Texture FGIXWFQKFBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private LazyShaderProperty XEFEOEUMWUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private LazyShaderProperty WSVOTVFXICO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private Texture KOOYULZNIXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private Vector2 WEKYEVRKRHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private Vector2 BAREGRWEECZ;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Texture2D GNOUHNWCUSY
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xCF4300", Offset = "0xCF2F00", VA = "0x180CF4300")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x2AA52F0", Offset = "0x2AA3EF0", VA = "0x182AA52F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Material KSFJLDIUTJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xCF43A0", Offset = "0xCF2FA0", VA = "0x180CF43A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x2AA5370", Offset = "0x2AA3F70", VA = "0x182AA5370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string LDOLKKLXTTH
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xCF42E0", Offset = "0xCF2EE0", VA = "0x180CF42E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x2AA5490", Offset = "0x2AA4090", VA = "0x182AA5490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector2 RFBIZEQGAWX
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x2AA52B0", Offset = "0x2AA3EB0", VA = "0x182AA52B0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x2AA53F0", Offset = "0x2AA3FF0", VA = "0x182AA53F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Vector2 JBTKORXHGDU
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x2AA52D0", Offset = "0x2AA3ED0", VA = "0x182AA52D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x2AA5440", Offset = "0x2AA4040", VA = "0x182AA5440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xD4FD60", Offset = "0xD4E960", VA = "0x180D4FD60")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2AA44B0", Offset = "0x2AA30B0", VA = "0x182AA44B0", Slot = "8")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4D40", Offset = "0x2AA3940", VA = "0x182AA4D40")]
		private void SAWXDCPKFMG(Texture a, bool b, int c = 0, Eye d = Eye.Left)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4B40", Offset = "0x2AA3740", VA = "0x182AA4B40", Slot = "6")]
		protected override void RDKWBKPVFMQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2AA49D0", Offset = "0x2AA35D0", VA = "0x182AA49D0", Slot = "7")]
		protected override void MAHZOPDWLVB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5150", Offset = "0x2AA3D50", VA = "0x182AA5150")]
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
		private enum Eye
		{
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			Left,
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			Right
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[Space(8f)]
		[Header("Display")]
		[Tooltip("Default texture to display when the video texture is preparing")]
		[SerializeField]
		private Texture2D _defaultTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[Space(8f)]
		[FormerlySerializedAs("_mesh")]
		[Header("Renderer Target")]
		[SerializeField]
		private Renderer _renderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private int _materialIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private string _texturePropertyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		private Vector2 _offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		private Vector2 _scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private Texture FGIXWFQKFBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private LazyShaderProperty XEFEOEUMWUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private LazyShaderProperty WSVOTVFXICO;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Texture2D GNOUHNWCUSY
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xCF4300", Offset = "0xCF2F00", VA = "0x180CF4300")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x2AA5C50", Offset = "0x2AA4850", VA = "0x182AA5C50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Renderer JWHXERBARRA
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xCF43A0", Offset = "0xCF2FA0", VA = "0x180CF43A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x2AA6240", Offset = "0x2AA4E40", VA = "0x182AA6240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public int QXKWBAWWHGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xD66FC0", Offset = "0xD65BC0", VA = "0x180D66FC0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xD68130", Offset = "0xD66D30", VA = "0x180D68130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public string LDOLKKLXTTH
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xCEE120", Offset = "0xCECD20", VA = "0x180CEE120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x2AA6470", Offset = "0x2AA5070", VA = "0x182AA6470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector2 RFBIZEQGAWX
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x2AA52D0", Offset = "0x2AA3ED0", VA = "0x182AA52D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x2AA5440", Offset = "0x2AA4040", VA = "0x182AA5440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector2 JBTKORXHGDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x2AA6400", Offset = "0x2AA5000", VA = "0x182AA6400")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x2AA6420", Offset = "0x2AA5020", VA = "0x182AA6420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5C50", Offset = "0x2AA4850", VA = "0x182AA5C50")]
		private void PBQEDRXTIKY(Texture2D a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2AA6240", Offset = "0x2AA4E40", VA = "0x182AA6240")]
		private void YKACNXRHWTB(Renderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xD4FD60", Offset = "0xD4E960", VA = "0x180D4FD60")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5560", Offset = "0x2AA4160", VA = "0x182AA5560", Slot = "8")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5DA0", Offset = "0x2AA49A0", VA = "0x182AA5DA0")]
		private void SAWXDCPKFMG(Texture a, bool b, int c, Eye d = Eye.Left, int e = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5B10", Offset = "0x2AA4710", VA = "0x182AA5B10", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5AE0", Offset = "0x2AA46E0", VA = "0x182AA5AE0", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5D00", Offset = "0x2AA4900", VA = "0x182AA5D00", Slot = "6")]
		protected override void RDKWBKPVFMQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2AA6320", Offset = "0x2AA4F20", VA = "0x182AA6320")]
		public ApplyToMesh()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[AddComponentMenu("AVPro Video/Audio Channel Mixer", 401)]
	[HelpURL("https://www.renderheads.com/products/avpro-video/")]
	public class AudioChannelMixer : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const int STNOFWKJPMC = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[Range(0f, 1f)]
		[SerializeField]
		private float[] _channels;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float[] QSSVGJRIXJV
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xCF1770", Offset = "0xCF0370", VA = "0x180CF1770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2AA6700", Offset = "0x2AA5300", VA = "0x182AA6700")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2AA6790", Offset = "0x2AA5390", VA = "0x182AA6790")]
		private void YSAKGKLPYWO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2AA6550", Offset = "0x2AA5150", VA = "0x182AA6550")]
		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF20", Offset = "0xCEEB20", VA = "0x180CEFF20")]
		public AudioChannelMixer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[RequireComponent(typeof(AudioSource))]
	[AddComponentMenu("AVPro Video/Audio Output", 400)]
	[HelpURL("https://www.renderheads.com/products/avpro-video/")]
	public class AudioOutput : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public enum AudioOutputMode
		{
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			OneToAllChannels,
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			MultipleChannels
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		private MediaPlayer _mediaPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		private AudioOutputMode _audioOutputMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[HideInInspector]
		[SerializeField]
		private int _channelMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		private bool _supportPositionalAudio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private int ENFSYYJNCWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private AudioSource ALPGXLBAMQM;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public MediaPlayer WWNRCTDPFVX
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2AA7350", Offset = "0x2AA5F50", VA = "0x182AA7350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public AudioOutputMode SSFHOXUAWNQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A00", Offset = "0xCF0600", VA = "0x180CF1A00")]
			get
			{
				return default(AudioOutputMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A20", Offset = "0xCF0620", VA = "0x180CF1A20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int ZXQCWRFGDQT
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xDE4620", Offset = "0xDE3220", VA = "0x180DE4620")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x1DF70A0", Offset = "0x1DF5CA0", VA = "0x181DF70A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2AA6890", Offset = "0x2AA5490", VA = "0x182AA6890")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7010", Offset = "0x2AA5C10", VA = "0x182AA7010")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2AA6E00", Offset = "0x2AA5A00", VA = "0x182AA6E00")]
		private void JOFRTEPKLUL(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2AA6F60", Offset = "0x2AA5B60", VA = "0x182AA6F60")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7250", Offset = "0x2AA5E50", VA = "0x182AA7250")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xCF4300", Offset = "0xCF2F00", VA = "0x180CF4300")]
		public AudioSource GetAudioSource()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2AA6F70", Offset = "0x2AA5B70", VA = "0x182AA6F70")]
		public void SetAudioSource(AudioSource source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2AA6940", Offset = "0x2AA5540", VA = "0x182AA6940")]
		public void ChangeMediaPlayer(MediaPlayer newPlayer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2AA68E0", Offset = "0x2AA54E0", VA = "0x182AA68E0")]
		private void BXERGFBGHPQ(MediaPlayer a, MediaPlayerEvent.EventType b, ErrorCode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7090", Offset = "0x2AA5C90", VA = "0x182AA7090")]
		private static void ULUDXYMFJRV(MediaPlayer a, AudioSource b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2AA6EE0", Offset = "0x2AA5AE0", VA = "0x182AA6EE0")]
		private void OnAudioFilterRead(float[] audioData, int channelCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7330", Offset = "0x2AA5F30", VA = "0x182AA7330")]
		public AudioOutput()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[AddComponentMenu("AVPro Video/Display IMGUI", 200)]
	[HelpURL("https://www.renderheads.com/products/avpro-video/")]
	[ExecuteInEditMode]
	public class DisplayIMGUI : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[SerializeField]
		private MediaPlayer _mediaPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[SerializeField]
		private ScaleMode _scaleMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[SerializeField]
		private Color _color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[FormerlySerializedAs("_alphaBlend")]
		[SerializeField]
		private bool _allowTransparency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		private bool _useDepth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		private int _depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Header("Area")]
		[FormerlySerializedAs("_fullScreen")]
		[SerializeField]
		private bool _isAreaFullScreen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[FormerlySerializedAs("_x")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _areaX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[FormerlySerializedAs("_y")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _areaY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[FormerlySerializedAs("_width")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _areaWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[FormerlySerializedAs("_height")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _areaHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[FormerlySerializedAs("_displayInEditor")]
		[SerializeField]
		private bool _showAreaInEditor;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static Shader NOPPPMTBUSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private Material FGFNKTYVVHG;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public MediaPlayer WWNRCTDPFVX
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x2AA94F0", Offset = "0x2AA80F0", VA = "0x182AA94F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public ScaleMode WBCKFBVLYLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A00", Offset = "0xCF0600", VA = "0x180CF1A00")]
			get
			{
				return default(ScaleMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A20", Offset = "0xCF0620", VA = "0x180CF1A20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Color LPXTJPZIKIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2AA94C0", Offset = "0x2AA80C0", VA = "0x182AA94C0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x2AA94E0", Offset = "0x2AA80E0", VA = "0x182AA94E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool FDGNZRCAWQT
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xF13570", Offset = "0xF12170", VA = "0x180F13570")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xFC6C30", Offset = "0xFC5830", VA = "0x180FC6C30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool YDBAFOJTIRK
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xFC7080", Offset = "0xFC5C80", VA = "0x180FC7080")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xFC6FE0", Offset = "0xFC5BE0", VA = "0x180FC6FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public int HYQFZMNIWUV
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xD0CD60", Offset = "0xD0B960", VA = "0x180D0CD60")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xD6E2C0", Offset = "0xD6CEC0", VA = "0x180D6E2C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool ACXYZMZSNLK
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x19BC230", Offset = "0x19BAE30", VA = "0x1819BC230")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x19BC1B0", Offset = "0x19BADB0", VA = "0x1819BC1B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float UFLUPNZJOFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x121C680", Offset = "0x121B280", VA = "0x18121C680")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2AA94D0", Offset = "0x2AA80D0", VA = "0x182AA94D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public float UFGNSHFMETS
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xF1C510", Offset = "0xF1B110", VA = "0x180F1C510")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xF1C520", Offset = "0xF1B120", VA = "0x180F1C520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float FRCYFRETVPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xD3FAF0", Offset = "0xD3E6F0", VA = "0x180D3FAF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x1088E30", Offset = "0x1087A30", VA = "0x181088E30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float PJFRZBEYOQW
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x1096B50", Offset = "0x1095750", VA = "0x181096B50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x1096B30", Offset = "0x1095730", VA = "0x181096B30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool MOKBUIKQOWO
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xDE65F0", Offset = "0xDE51F0", VA = "0x180DE65F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xDE6850", Offset = "0xDE5450", VA = "0x180DE6850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9120", Offset = "0x2AA7D20", VA = "0x182AA9120")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9260", Offset = "0x2AA7E60", VA = "0x182AA9260")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2AA89E0", Offset = "0x2AA75E0", VA = "0x182AA89E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9450", Offset = "0x2AA8050", VA = "0x182AA9450")]
		private Shader YRFKUZVEOAQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8840", Offset = "0x2AA7440", VA = "0x182AA8840")]
		private void JENGELTYZDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8A80", Offset = "0x2AA7680", VA = "0x182AA8A80")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8710", Offset = "0x2AA7310", VA = "0x182AA8710")]
		public Rect GetAreaRect()
		{
			return default(Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9490", Offset = "0x2AA8090", VA = "0x182AA9490")]
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
		public delegate void ProcessExtractedFrame(Texture2D extractedFrame);

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public class PlatformOptions
		{
			[Cpp2IlInjected.Token(Token = "0x2000011")]
			public enum TextureFormat
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
			public enum Resolution
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
			public enum AudioMode
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
			public enum BitRateUnits
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
			[Cpp2IlInjected.Address(RVA = "0x2AB1EB0", Offset = "0x2AB0AB0", VA = "0x182AB1EB0", Slot = "4")]
			public virtual string IMHOTJGHREP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xF84310", Offset = "0xF82F10", VA = "0x180F84310", Slot = "5")]
			public virtual byte[] CWBQBBRJNOM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "6")]
			public virtual bool PWNYWIKGXVL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1ED0", Offset = "0x2AB0AD0", VA = "0x182AB1ED0")]
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
			public TVJPRMLGCJL.VideoApi videoApi;

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
			public TVJPRMLGCJL.AudioOutput _audioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public Audio360ChannelMode audio360ChannelMode;

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
			[SerializeField]
			[HideInInspector]
			private bool useUnityAudio;

			[Cpp2IlInjected.FieldOffset(Offset = "0x55")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			[SerializeField]
			[HideInInspector]
			private bool enableAudio360;

			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0xD94380", Offset = "0xD92F80", VA = "0x180D94380", Slot = "6")]
			public override bool PWNYWIKGXVL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "7")]
			private void UNBOZVVQPFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1C60", Offset = "0x2AB0860", VA = "0x182AB1C60", Slot = "8")]
			private void DMVWLMWFJBU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1C90", Offset = "0x2AB0890", VA = "0x182AB1C90")]
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
			public USRIJRCXICL.VideoApi videoApi;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public USRIJRCXICL.AudioOutput _audioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public Audio360ChannelMode audio360ChannelMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public bool startWithHighestBitrate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public bool useLowLiveLatency;

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0xF21100", Offset = "0xF1FD00", VA = "0x180F21100", Slot = "6")]
			public override bool PWNYWIKGXVL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1C40", Offset = "0x2AB0840", VA = "0x182AB1C40")]
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
			public enum Flags
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
			public enum ChangeFlags
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
			private readonly TextureFormat KXTNCLSCZMT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			private readonly Flags TJTMNJHDDUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public TextureFormat textureFormat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private AudioMode GNXMLEVTQIZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			[SerializeField]
			private AudioMode _audioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			[SerializeField]
			private Flags _flags;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public float maximumPlaybackRate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private ChangeFlags TZASWROVWWX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			[SerializeField]
			private float _preferredPeakBitRate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			[SerializeField]
			private BitRateUnits _preferredPeakBitRateUnits;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			[SerializeField]
			private double _preferredForwardBufferDuration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			[SerializeField]
			private Resolution _preferredMaximumResolution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			[SerializeField]
			private Vector2Int _customPreferredMaximumResolution;

			[Cpp2IlInjected.Token(Token = "0x17000064")]
			public AudioMode audioMode
			{
				[Cpp2IlInjected.Token(Token = "0x6000144")]
				[Cpp2IlInjected.Address(RVA = "0x2AB1B90", Offset = "0x2AB0790", VA = "0x182AB1B90")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000065")]
			public Flags flags
			{
				[Cpp2IlInjected.Token(Token = "0x6000145")]
				[Cpp2IlInjected.Address(RVA = "0x2AB1BB0", Offset = "0x2AB07B0", VA = "0x182AB1BB0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1AE0", Offset = "0x2AB06E0", VA = "0x182AB1AE0")]
			public OptionsApple(TextureFormat defaultTextureFormat, Flags defaultFlags)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public class OptionsAndroid : PlatformOptions, ISerializationCallbackReceiver
		{
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public enum VideoOutputMode
			{
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				Texture
			}

			[Cpp2IlInjected.Token(Token = "0x200001C")]
			[Flags]
			public enum ChangeFlags
			{
				[Cpp2IlInjected.Token(Token = "0x400011E")]
				None = 0,
				[Cpp2IlInjected.Token(Token = "0x400011F")]
				PreferredPeakBitRate = 2,
				[Cpp2IlInjected.Token(Token = "0x4000120")]
				PreferredMaximumResolution = 4,
				[Cpp2IlInjected.Token(Token = "0x4000121")]
				PreferredCustomResolution = 8,
				[Cpp2IlInjected.Token(Token = "0x4000122")]
				AudioMode = 0x10,
				[Cpp2IlInjected.Token(Token = "0x4000123")]
				GenerateMipmaps = 0x20,
				[Cpp2IlInjected.Token(Token = "0x4000124")]
				All = -1
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private ChangeFlags TZASWROVWWX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public VideoOutputMode videoOutputMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			private readonly TextureFormat KXTNCLSCZMT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public TextureFormat textureFormat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			[SerializeField]
			private bool _generateMipmaps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			private AudioMode GNXMLEVTQIZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			[SerializeField]
			private AudioMode _audioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			[SerializeField]
			private Resolution _preferredMaximumResolution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			[SerializeField]
			private Vector2Int _customPreferredMaximumResolution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			[SerializeField]
			private float _preferredPeakBitRate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			[SerializeField]
			private BitRateUnits _preferredPeakBitRateUnits;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public Android.VideoApi videoApi;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public bool showPosterFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public Audio360ChannelMode audio360ChannelMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public int audio360LatencyMS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public bool preferSoftwareDecoder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public bool forceRtpTCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x62")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public bool forceEnableMediaCodecAsynchronousQueueing;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			[SerializeField]
			[Tooltip("Byte offset into the file where the media file is located.  This is useful when hiding or packing media files within another file.")]
			public int fileOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public bool startWithHighestBitrate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public int minBufferMs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public int maxBufferMs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public int bufferForPlaybackMs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public int bufferForPlaybackAfterRebufferMs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			[Obsolete("useFastOesPath is deprecated and replaced with TextureFormat")]
			public bool useFastOesPath;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			[Obsolete("audioOutput is deprecated and replaced with audioMode")]
			public int audioOutput;

			[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			[Obsolete("blitTextureFiltering is deprecated and its functionality has been removed")]
			public int blitTextureFiltering;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			[Obsolete("forceEnableMediaCodecAsyncQueueing is deprecated and replaced with forceEnableMediaCodecAsynchronousQueueing")]
			public bool forceEnableMediaCodecAsyncQueueing;

			[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			[SerializeField]
			[HideInInspector]
			private bool enableAudio360;

			[Cpp2IlInjected.Token(Token = "0x17000066")]
			public AudioMode audioMode
			{
				[Cpp2IlInjected.Token(Token = "0x6000147")]
				[Cpp2IlInjected.Address(RVA = "0xD1EF90", Offset = "0xD1DB90", VA = "0x180D1EF90")]
				get
				{
					return default(AudioMode);
				}
				[Cpp2IlInjected.Token(Token = "0x6000148")]
				[Cpp2IlInjected.Address(RVA = "0x2AB1AC0", Offset = "0x2AB06C0", VA = "0x182AB1AC0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xD00E90", Offset = "0xCFFA90", VA = "0x180D00E90", Slot = "6")]
			public override bool PWNYWIKGXVL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "7")]
			private void UNBOZVVQPFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1A10", Offset = "0x2AB0610", VA = "0x182AB1A10", Slot = "8")]
			private void DMVWLMWFJBU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1A40", Offset = "0x2AB0640", VA = "0x182AB1A40")]
			public OptionsAndroid()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public class OptionsOpenHarmony : PlatformOptions, ISerializationCallbackReceiver
		{
			[Cpp2IlInjected.Token(Token = "0x200001E")]
			[Flags]
			public enum ChangeFlags
			{
				[Cpp2IlInjected.Token(Token = "0x400012E")]
				None = 0,
				[Cpp2IlInjected.Token(Token = "0x400012F")]
				PreferredPeakBitRate = 2,
				[Cpp2IlInjected.Token(Token = "0x4000130")]
				PreferredMaximumResolution = 4,
				[Cpp2IlInjected.Token(Token = "0x4000131")]
				PreferredCustomResolution = 8,
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				AudioMode = 0x10,
				[Cpp2IlInjected.Token(Token = "0x4000133")]
				GenerateMipmaps = 0x20,
				[Cpp2IlInjected.Token(Token = "0x4000134")]
				All = -1
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			private ChangeFlags TZASWROVWWX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private readonly TextureFormat KXTNCLSCZMT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public TextureFormat textureFormat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			[SerializeField]
			private bool _generateMipmapsOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			private AudioMode GNXMLEVTQIZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			[SerializeField]
			private AudioMode _audioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			[SerializeField]
			private Resolution _preferredMaximumResolution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			[SerializeField]
			private Vector2Int _customPreferredMaximumResolution;

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "7")]
			private void UNBOZVVQPFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "8")]
			private void DMVWLMWFJBU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1BE0", Offset = "0x2AB07E0", VA = "0x182AB1BE0")]
			public OptionsOpenHarmony()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public class OptionsWebGL : PlatformOptions
		{
			[Cpp2IlInjected.Token(Token = "0x2000020")]
			public enum ChangeFlags
			{
				[Cpp2IlInjected.Token(Token = "0x400013B")]
				None = 0,
				[Cpp2IlInjected.Token(Token = "0x400013C")]
				PreferredPeakBitRate = 2,
				[Cpp2IlInjected.Token(Token = "0x400013D")]
				PreferredMaximumResolution = 4,
				[Cpp2IlInjected.Token(Token = "0x400013E")]
				PreferredCustomResolution = 8,
				[Cpp2IlInjected.Token(Token = "0x400013F")]
				AudioMode = 16,
				[Cpp2IlInjected.Token(Token = "0x4000140")]
				GenerateMipmaps = 32,
				[Cpp2IlInjected.Token(Token = "0x4000141")]
				All = -1
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			private ChangeFlags TZASWROVWWX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public GJRZPPCECEN.ExternalLibrary externalLibrary;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public bool useTextureMips;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			private AudioMode GNXMLEVTQIZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			[SerializeField]
			private AudioMode _audioMode;

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "4")]
			public override string IMHOTJGHREP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "5")]
			public override byte[] CWBQBBRJNOM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1C30", Offset = "0x2AB0830", VA = "0x182AB1C30")]
			public OptionsWebGL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		private enum FileLocation
		{
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			AbsolutePathOrURL,
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			RelativeToProjectFolder,
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			RelativeToStreamingAssetsFolder,
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			RelativeToDataFolder,
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			RelativeToPersistentDataFolder
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class YCAQLQSBPEY : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			private object PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public Texture2D OJSHIYWFHYV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public MediaPlayer DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public double CJOJXXEZTMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public int QDVNZSSHVXO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public bool QWRVIIPLEBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public ProcessExtractedFrame NOJJNBVDIQT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			private Texture2D VJYJBAEYEQY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			private int QXKNOTEOQKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			private int XJXBLUVNSNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			private int VBPQHEYFTPW;

			[Cpp2IlInjected.Token(Token = "0x17000067")]
			private object LDTKDHZVICR
			{
				[Cpp2IlInjected.Token(Token = "0x6000156")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x6000158")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
			[DebuggerHidden]
			public YCAQLQSBPEY(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x2AB6460", Offset = "0x2AB5060", VA = "0x182AB6460", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x2AB6420", Offset = "0x2AB5020", VA = "0x182AB6420", Slot = "8")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class POZEFNGVVGY : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private object PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public MediaPlayer DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			private YieldInstruction VSACEDYEHCQ;

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			private object LDTKDHZVICR
			{
				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x600015E")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
			[DebuggerHidden]
			public POZEFNGVVGY(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1D90", Offset = "0x2AB0990", VA = "0x182AB1D90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1D50", Offset = "0x2AB0950", VA = "0x182AB1D50", Slot = "8")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class YEYLLQOKDWU : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private object PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			public string KSRCTVTIIGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			public MediaPlayer DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public MediaPath HETRELHGLBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private UnityWebRequest HDAWWFNQGHI;

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			private object LDTKDHZVICR
			{
				[Cpp2IlInjected.Token(Token = "0x6000162")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x6000164")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
			[DebuggerHidden]
			public YEYLLQOKDWU(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x2AB69B0", Offset = "0x2AB55B0", VA = "0x182AB69B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x2AB6970", Offset = "0x2AB5570", VA = "0x182AB6970", Slot = "8")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		private MediaSource _mediaSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		private MediaReference _mediaReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		private MediaPath _mediaPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		private MediaHints _fallbackMediaHints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[FormerlySerializedAs("m_AutoOpen")]
		[SerializeField]
		private bool _autoOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[FormerlySerializedAs("m_AutoStart")]
		[SerializeField]
		private bool _autoPlayOnStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[FormerlySerializedAs("m_Loop")]
		[SerializeField]
		private bool _loop;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[FormerlySerializedAs("m_Volume")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _audioVolume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[FormerlySerializedAs("m_Balance")]
		[Range(-1f, 1f)]
		[SerializeField]
		private float _audioBalance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[FormerlySerializedAs("m_Muted")]
		[SerializeField]
		private bool _audioMuted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private AudioSource ALPGXLBAMQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[FormerlySerializedAs("m_PlaybackRate")]
		[Range(-4f, 4f)]
		[SerializeField]
		private float _playbackRate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[FormerlySerializedAs("m_Resample")]
		[SerializeField]
		private bool _useResampler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[FormerlySerializedAs("m_ResampleMode")]
		[SerializeField]
		private IHWCXXBHRYX.ResampleMode _resampleMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[FormerlySerializedAs("m_ResampleBufferSize")]
		[Range(3f, 10f)]
		[SerializeField]
		private int _resampleBufferSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private IHWCXXBHRYX NQGRXHLQFSA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[FormerlySerializedAs("m_videoMapping")]
		[SerializeField]
		private VideoMapping _videoMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[FormerlySerializedAs("m_FilterMode")]
		[SerializeField]
		private FilterMode _textureFilterMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[FormerlySerializedAs("m_WrapMode")]
		[SerializeField]
		private TextureWrapMode _textureWrapMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[FormerlySerializedAs("m_AnisoLevel")]
		[Range(0f, 16f)]
		[SerializeField]
		private int _textureAnisoLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[FormerlySerializedAs("m_LoadSubtitles")]
		[SerializeField]
		private bool _sideloadSubtitles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[SerializeField]
		private MediaPath _subtitlePath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[FormerlySerializedAs("m_AudioHeadTransform")]
		[SerializeField]
		private Transform _audioHeadTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[FormerlySerializedAs("m_AudioFocusEnabled")]
		[SerializeField]
		private bool _audioFocusEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[FormerlySerializedAs("m_AudioFocusTransform")]
		[SerializeField]
		private Transform _audioFocusTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[FormerlySerializedAs("m_AudioFocusWidthDegrees")]
		[SerializeField]
		[Range(40f, 120f)]
		private float _audioFocusWidthDegrees;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[FormerlySerializedAs("m_AudioFocusOffLevelDB")]
		[SerializeField]
		[Range(-24f, 0f)]
		private float _audioFocusOffLevelDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[SerializeField]
		private HttpHeaderData _httpHeaders;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[SerializeField]
		private KeyAuthData _keyAuth;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[FormerlySerializedAs("m_events")]
		[SerializeField]
		private MediaPlayerEvent _events;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[FormerlySerializedAs("m_eventMask")]
		[SerializeField]
		private int _eventMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		private bool _pauseMediaOnAppPause;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD5")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private bool _playMediaOnAppUnpause;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD6")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[FormerlySerializedAs("m_Persistent")]
		[SerializeField]
		private bool _persistent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[FormerlySerializedAs("m_forceFileFormat")]
		[SerializeField]
		private FileFormat _forceFileFormat;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		protected HLYYMTUNGKO LATOWPVUXMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private VQFTYACOXJA ZTAZERGHVTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private QOSOQPMLJWU GUYMNUQPULZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private MKYYHMIYGFD LBTXWDUNJKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private NHBIMHXARPO PJGJMMHRHST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private CKWZZXUVMEW XMNJRQVMUDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private IVVIHARYVRP IQNQYKERHNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private DFAYJFKHIBQ CSBNAPYDBBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private CQXJJYGCXEL TPQPSOWWANK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private LUHLXMRMVIM MKOONLZMYAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private JAFDMGAXOYN JMVQXMCQTRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private IDisposable GFKJEUTHNER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private bool CSCBWDQCURM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x141")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private bool LONAEDCHUKQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x142")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private bool OXHOAHQIJGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private Coroutine DKANJZDUSCX;

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private static bool RTOOKWLKUTU;

		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private static bool WQVGGDZRDMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private MediaPath QKQIGHQFODV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private Coroutine QCJDKSKFWDE;

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static Camera XTCNTGMUMDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private bool XPYZEOEICZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x161")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private bool YUHQUYQBKEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x162")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private bool WTGABWHMQEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x163")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private bool AEIGMAVEZTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private bool MOJSQBZEVNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x165")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private bool SKHAFIPAEIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x166")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private bool DFQFQQHTHDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x167")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private bool PVYAURCXTQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private int MCVPKELJESY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private int WKRVVEITAGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private int KUIUJPZCKGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private bool PQTJWCGASUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x175")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private bool INQROPTIRCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[SerializeField]
		private OptionsWindows _optionsWindows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[SerializeField]
		private OptionsApple _options_macOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		private OptionsApple _options_iOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[SerializeField]
		private OptionsApple _options_tvOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		private OptionsApple _options_visionOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		private OptionsAndroid _optionsAndroid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		private OptionsOpenHarmony _optionsOpenHarmony;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[SerializeField]
		private OptionsWindowsUWP _optionsWindowsUWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[SerializeField]
		private OptionsWebGL _optionsWebGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[SerializeField]
		[HideInInspector]
		private string m_VideoPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[SerializeField]
		[HideInInspector]
		private FileLocation m_VideoLocation;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public MediaSource PDCZRWKZDRT
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xD00670", Offset = "0xCFF270", VA = "0x180D00670")]
			get
			{
				return default(MediaSource);
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xD45780", Offset = "0xD44380", VA = "0x180D45780")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public MediaReference FJVXPHOTPHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2F50", VA = "0x180CF4350")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xCF1780", Offset = "0xCF0380", VA = "0x180CF1780")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MediaPath RRLDGCKSSIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF3820", VA = "0x180CF4C20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xCF64C0", Offset = "0xCF50C0", VA = "0x180CF64C0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public MediaHints YUFRCJNVCUI
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x1B6DF80", Offset = "0x1B6CB80", VA = "0x181B6DF80")]
			get
			{
				return default(MediaHints);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x1A86690", Offset = "0x1A85290", VA = "0x181A86690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool CFUJWMUXQYD
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x19BC230", Offset = "0x19BAE30", VA = "0x1819BC230")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x19BC1B0", Offset = "0x19BADB0", VA = "0x1819BC1B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool ZJFHZHOGFGN
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2766340", Offset = "0x2764F40", VA = "0x182766340")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x27664C0", Offset = "0x27650C0", VA = "0x1827664C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool DVNXYAQZRPM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x2AB0FD0", Offset = "0x2AAFBD0", VA = "0x182AB0FD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x2AB14F0", Offset = "0x2AB00F0", VA = "0x182AB14F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public virtual float KZHMDOLSXDC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x2AB0E80", Offset = "0x2AAFA80", VA = "0x182AB0E80", Slot = "6")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1470", Offset = "0x2AB0070", VA = "0x182AB1470", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float KSFTOCSMXNA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x2AB0DC0", Offset = "0x2AAF9C0", VA = "0x182AB0DC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1380", Offset = "0x2AAFF80", VA = "0x182AB1380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public virtual bool VXGVJSDPVYB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x2AB0E20", Offset = "0x2AAFA20", VA = "0x182AB0E20", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1400", Offset = "0x2AB0000", VA = "0x182AB1400", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public AudioSource HCPCCREBKKT
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xCEE150", Offset = "0xCECD50", VA = "0x180CEE150")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xCEE160", Offset = "0xCECD60", VA = "0x180CEE160")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float CPQJZTASHHR
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1060", Offset = "0x2AAFC60", VA = "0x182AB1060")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1590", Offset = "0x2AB0190", VA = "0x182AB1590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool OMPJRCPODJY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C10", Offset = "0xCF3810", VA = "0x180CF4C10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xCF42F0", Offset = "0xCF2EF0", VA = "0x180CF42F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public IHWCXXBHRYX.ResampleMode EXJMDLCZRMY
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xE06CD0", Offset = "0xE058D0", VA = "0x180E06CD0")]
			get
			{
				return default(IHWCXXBHRYX.ResampleMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xF09970", Offset = "0xF08570", VA = "0x180F09970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public int AMFKGPOGKRG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xED3CB0", Offset = "0xED28B0", VA = "0x180ED3CB0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1600", Offset = "0x2AB0200", VA = "0x182AB1600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public IHWCXXBHRYX QVRRGCMHVMU
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xCEE720", Offset = "0xCED320", VA = "0x180CEE720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public VideoMapping DEQGHJSPCKF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xD16340", Offset = "0xD14F40", VA = "0x180D16340")]
			get
			{
				return default(VideoMapping);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x161E940", Offset = "0x161D540", VA = "0x18161E940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public FilterMode SLZKZKHDZAG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x2AB11B0", Offset = "0x2AAFDB0", VA = "0x182AB11B0")]
			get
			{
				return default(FilterMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1680", Offset = "0x2AB0280", VA = "0x182AB1680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public TextureWrapMode SYDRYGLUPYY
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1290", Offset = "0x2AAFE90", VA = "0x182AB1290")]
			get
			{
				return default(TextureWrapMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1700", Offset = "0x2AB0300", VA = "0x182AB1700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public int SKIBDFDCDWV
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x2AB10C0", Offset = "0x2AAFCC0", VA = "0x182AB10C0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1610", Offset = "0x2AB0210", VA = "0x182AB1610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool ZUMIKPJDHWM
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xF95CA0", Offset = "0xF948A0", VA = "0x180F95CA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xF95820", Offset = "0xF94420", VA = "0x180F95820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public MediaPath UNZXBYQIOBB
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xD1EC20", Offset = "0xD1D820", VA = "0x180D1EC20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xF94180", Offset = "0xF92D80", VA = "0x180F94180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public Transform TFVKKKAOAYA
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xCF7E00", Offset = "0xCF6A00", VA = "0x180CF7E00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xCF7690", Offset = "0xCF6290", VA = "0x180CF7690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool UJZYYYXJXDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xDEEFD0", Offset = "0xDEDBD0", VA = "0x180DEEFD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x10E8430", Offset = "0x10E7030", VA = "0x1810E8430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public Transform QXMDGNIKKMW
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xCF2B90", Offset = "0xCF1790", VA = "0x180CF2B90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xCF2B00", Offset = "0xCF1700", VA = "0x180CF2B00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public float RRJCHZCDAIL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x10C2310", Offset = "0x10C0F10", VA = "0x1810C2310")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x10C23D0", Offset = "0x10C0FD0", VA = "0x1810C23D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public float BCBPZDFKNCF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x10C0CC0", Offset = "0x10BF8C0", VA = "0x1810C0CC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x10C0D80", Offset = "0x10BF980", VA = "0x1810C0D80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public HttpHeaderData SZPMMDMGGNY
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0xEE82E0", Offset = "0xEE6EE0", VA = "0x180EE82E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x1725840", Offset = "0x1724440", VA = "0x181725840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public KeyAuthData HUUMZKIXHDX
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xED14E0", Offset = "0xED00E0", VA = "0x180ED14E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xED14F0", Offset = "0xED00F0", VA = "0x180ED14F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public MediaPlayerEvent CGIREJRJVTH
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x2AB0EE0", Offset = "0x2AAFAE0", VA = "0x182AB0EE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public int WNOQODYLZTW
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x10C1210", Offset = "0x10BFE10", VA = "0x1810C1210")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x10C2430", Offset = "0x10C1030", VA = "0x1810C2430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public bool GMGVFLHRJOA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1030", Offset = "0x2AAFC30", VA = "0x182AB1030")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1560", Offset = "0x2AB0160", VA = "0x182AB1560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool ZDHVTSASVDT
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1050", Offset = "0x2AAFC50", VA = "0x182AB1050")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1580", Offset = "0x2AB0180", VA = "0x182AB1580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool RPXWAUSORIR
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1040", Offset = "0x2AAFC40", VA = "0x182AB1040")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1570", Offset = "0x2AB0170", VA = "0x182AB1570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public FileFormat OFCGBLKSAEC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0xDEEF40", Offset = "0xDEDB40", VA = "0x180DEEF40")]
			get
			{
				return default(FileFormat);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x199F260", Offset = "0x199DE60", VA = "0x18199F260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public virtual MKYYHMIYGFD QQEPSCRJPLK
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xE5B320", Offset = "0xE59F20", VA = "0x180E5B320", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public virtual VQFTYACOXJA EJKMMQAFLEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xF6C370", Offset = "0xF6AF70", VA = "0x180F6C370", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public virtual NHBIMHXARPO WWNRCTDPFVX
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xEFC480", Offset = "0xEFB080", VA = "0x180EFC480", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public virtual QOSOQPMLJWU YNACXXLKZOV
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xF6C380", Offset = "0xF6AF80", VA = "0x180F6C380", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual CKWZZXUVMEW FBRCGYKLNLL
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xF6C340", Offset = "0xF6AF40", VA = "0x180F6C340", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public virtual DFAYJFKHIBQ PHLBYEWSKZB
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xF6C320", Offset = "0xF6AF20", VA = "0x180F6C320", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual CQXJJYGCXEL RUKLNAXGXEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xD69E50", Offset = "0xD68A50", VA = "0x180D69E50", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual LUHLXMRMVIM YKPFPIIYBZB
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xD69E40", Offset = "0xD68A40", VA = "0x180D69E40", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual JAFDMGAXOYN BGHOAJURUKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xD69CA0", Offset = "0xD688A0", VA = "0x180D69CA0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public virtual IVVIHARYVRP KWDPHGWDCCG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xE74BD0", Offset = "0xE737D0", VA = "0x180E74BD0", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool QANKLPUHXRH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x1693940", Offset = "0x1692540", VA = "0x181693940")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public OptionsWindows UAMTXISMUDW
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0xDB5A80", Offset = "0xDB4680", VA = "0x180DB5A80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public OptionsApple WVBGCHWILSV
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xF6C1F0", Offset = "0xF6ADF0", VA = "0x180F6C1F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public OptionsApple TAETFKFJBNP
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0xF6C1E0", Offset = "0xF6ADE0", VA = "0x180F6C1E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public OptionsApple SVFIPVKYTQU
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0xF6C230", Offset = "0xF6AE30", VA = "0x180F6C230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public OptionsApple KOMKGUKKJPY
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0xF6C200", Offset = "0xF6AE00", VA = "0x180F6C200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public OptionsAndroid WYKWRGQTHUS
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0xE21080", Offset = "0xE1FC80", VA = "0x180E21080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public OptionsOpenHarmony ILQLJJBTQPB
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0xF6C430", Offset = "0xF6B030", VA = "0x180F6C430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public OptionsWindowsUWP ZMLCBJCNCAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0xF6C470", Offset = "0xF6B070", VA = "0x180F6C470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public OptionsWebGL REOLBOSEGOY
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xF6C460", Offset = "0xF6B060", VA = "0x180F6C460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xD45780", Offset = "0xD44380", VA = "0x180D45780")]
		public void SetMediaSource(MediaSource source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xCF1780", Offset = "0xCF0380", VA = "0x180CF1780")]
		public void SetMediaReference(MediaReference media)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xCF64C0", Offset = "0xCF50C0", VA = "0x180CF64C0")]
		public void SetMediaPath(MediaPath path)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xCEE160", Offset = "0xCECD60", VA = "0x180CEE160")]
		public void SetAudioSource(AudioSource audioSource)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2AAAF60", Offset = "0x2AA9B60", VA = "0x182AAAF60")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2AADBC0", Offset = "0x2AAC7C0", VA = "0x182AADBC0")]
		protected void NBHVUEOZUNR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF8B0", Offset = "0x2AAE4B0", VA = "0x182AAF8B0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE890", Offset = "0x2AAD490", VA = "0x182AAE890")]
		public bool OpenMedia(MediaPath path, bool autoPlay = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE790", Offset = "0x2AAD390", VA = "0x182AAE790")]
		public bool OpenMedia(MediaPathType pathType, string path, bool autoPlay = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE840", Offset = "0x2AAD440", VA = "0x182AAE840")]
		public bool OpenMedia(MediaReference mediaReference, bool autoPlay = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE810", Offset = "0x2AAD410", VA = "0x182AAE810")]
		public bool OpenMedia(bool autoPlay = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2AACFF0", Offset = "0x2AABBF0", VA = "0x182AACFF0")]
		private bool LCFTDDQMSGX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2AABCB0", Offset = "0x2AAA8B0", VA = "0x182AABCB0")]
		private void DHPPGNLXRSS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2AAED00", Offset = "0x2AAD900", VA = "0x182AAED00")]
		private void RPQFKTWPKYZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB790", Offset = "0x2AAA390", VA = "0x182AAB790")]
		public void CloseMedia()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2AAEBE0", Offset = "0x2AAD7E0", VA = "0x182AAEBE0", Slot = "20")]
		public virtual void Play()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2AAEB60", Offset = "0x2AAD760", VA = "0x182AAEB60", Slot = "21")]
		public virtual void Pause()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF9C0", Offset = "0x2AAE5C0", VA = "0x182AAF9C0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2AAEF80", Offset = "0x2AADB80", VA = "0x182AAEF80")]
		public void Rewind(bool pause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF6F0", Offset = "0x2AAE2F0", VA = "0x182AAF6F0")]
		public void SeekToLiveTime(double offset = 0.0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2AAFAF0", Offset = "0x2AAE6F0", VA = "0x182AAFAF0", Slot = "22")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2AAD600", Offset = "0x2AAC200", VA = "0x182AAD600")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB300", Offset = "0x2AA9F00", VA = "0x182AAB300")]
		private void CFANHHYVCNS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE650", Offset = "0x2AAD250", VA = "0x182AAE650")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE590", Offset = "0x2AAD190", VA = "0x182AAE590")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE410", Offset = "0x2AAD010", VA = "0x182AAE410", Slot = "23")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2AACC90", Offset = "0x2AAB890", VA = "0x182AACC90")]
		public void ForceDispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2AACDE0", Offset = "0x2AAB9E0", VA = "0x182AACDE0")]
		private static void ISMJIAOSZGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE1D0", Offset = "0x2AACDD0", VA = "0x182AAE1D0")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2AB05A0", Offset = "0x2AAF1A0", VA = "0x182AB05A0")]
		protected void XODONDCYYGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2AACD60", Offset = "0x2AAB960", VA = "0x182AACD60")]
		private void GENQPNXXAQK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2AB08A0", Offset = "0x2AAF4A0", VA = "0x182AB08A0")]
		[IteratorStateMachine(typeof(POZEFNGVVGY))]
		private IEnumerator YOFAUNENITE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40")]
		public static Platform GetPlatform()
		{
			return default(Platform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xDB5A80", Offset = "0xDB4680", VA = "0x180DB5A80")]
		public PlatformOptions GetCurrentPlatformOptions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2AAAD80", Offset = "0x2AA9980", VA = "0x182AAAD80")]
		private string AATRTYMDOBN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40")]
		private long DRZGFKTSIEG()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2AAC540", Offset = "0x2AAB140", VA = "0x182AAC540")]
		private string EYCNRWZARQK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2AAD740", Offset = "0x2AAC340", VA = "0x182AAD740")]
		private string MBKMTALHRZL(string a, MediaPathType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB400", Offset = "0x2AAA000", VA = "0x182AAB400")]
		private static HLYYMTUNGKO CFRAGNJIUGB(OptionsWindows a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2AAADF0", Offset = "0x2AA99F0", VA = "0x182AAADF0")]
		private static HLYYMTUNGKO AGOWJGPKXOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB900", Offset = "0x2AAA500", VA = "0x182AAB900", Slot = "24")]
		public virtual HLYYMTUNGKO CreateMediaPlayer()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2AAC0F0", Offset = "0x2AAACF0", VA = "0x182AAC0F0")]
		private void EDXLSCDBRNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2AAEE30", Offset = "0x2AADA30", VA = "0x182AAEE30")]
		private void RVDUMIVUBJX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2AAAFD0", Offset = "0x2AA9BD0", VA = "0x182AAAFD0")]
		private void BNSLNLCFKJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40")]
		public bool IsUsingAndroidOESPath()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40")]
		public bool IsUsingYCbCr()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF400", Offset = "0x2AAE000", VA = "0x182AAF400")]
		[ContextMenu("Save Frame To PNG")]
		public void SaveFrameToPng()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF000", Offset = "0x2AADC00", VA = "0x182AAF000")]
		[ContextMenu("Save Frame To EXR")]
		public void SaveFrameToExr()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
		private void OnApplicationFocus(bool focusStatus)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2AB0000", Offset = "0x2AAEC00", VA = "0x182AB0000")]
		private void VISCWIHFJHY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2AAFF30", Offset = "0x2AAEB30", VA = "0x182AAFF30")]
		private void VFOZWWBIAXV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE8C0", Offset = "0x2AAD4C0", VA = "0x182AAE8C0")]
		private void PBBYSZDSBWT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2AB0660", Offset = "0x2AAF260", VA = "0x182AB0660")]
		private void XWLQUDYBYTS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2AADA00", Offset = "0x2AAC600", VA = "0x182AADA00")]
		private void MPHZFQJMANW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2AACDB0", Offset = "0x2AAB9B0", VA = "0x182AACDB0")]
		protected bool IRBJNDVILBU(MediaPlayerEvent.EventType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2AAEC70", Offset = "0x2AAD870", VA = "0x182AAEC70")]
		private bool QZISJNZDCFG(MediaPlayerEvent.EventType a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2AB0030", Offset = "0x2AAEC30", VA = "0x182AB0030")]
		private bool VKBASUIEFDQ(MediaPlayerEvent.EventType a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB140", Offset = "0x2AA9D40", VA = "0x182AAB140")]
		private bool CDIOFZRDVSW(int a, float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2AAD7A0", Offset = "0x2AAC3A0", VA = "0x182AAD7A0")]
		private static Camera MCWVDBUSLZZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2AAFA20", Offset = "0x2AAE620", VA = "0x182AAFA20")]
		[IteratorStateMachine(typeof(YCAQLQSBPEY))]
		private IEnumerator TDCSRCIWSKI(Texture2D a, ProcessExtractedFrame b, double c = -1.0, bool d = true, int e = 1000, int f = 100)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2AACA40", Offset = "0x2AAB640", VA = "0x182AACA40")]
		public void ExtractFrameAsync(Texture2D target, ProcessExtractedFrame callback, double timeSeconds = -1.0, bool accurateSeek = true, int timeoutMs = 1000, int timeThresholdMs = 100)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2AACB10", Offset = "0x2AAB710", VA = "0x182AACB10")]
		public Texture2D ExtractFrame(Texture2D target, double timeSeconds = -1.0, bool accurateSeek = true, int timeoutMs = 1000, int timeThresholdMs = 100)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB540", Offset = "0x2AAA140", VA = "0x182AAB540")]
		private Texture CUPIEALKFQO(double a = -1.0, bool b = true, int c = 1000, int d = 100)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE6D0", Offset = "0x2AAD2D0", VA = "0x182AAE6D0")]
		public bool OpenMediaFromBuffer(byte[] buffer, bool autoPlay = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF7F0", Offset = "0x2AAE3F0", VA = "0x182AAF7F0")]
		public bool StartOpenChunkedMediaFromBuffer(ulong length, bool autoPlay = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2AAAE40", Offset = "0x2AA9A40", VA = "0x182AAAE40")]
		public bool AddChunkToVideoBuffer(byte[] chunk, ulong offset, ulong chunkSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2AAC9C0", Offset = "0x2AAB5C0", VA = "0x182AAC9C0")]
		public bool EndOpenChunkedVideoFromBuffer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE950", Offset = "0x2AAD550", VA = "0x182AAE950")]
		private bool PQJTGCMVKBJ(byte[] a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2AAC330", Offset = "0x2AAAF30", VA = "0x182AAC330")]
		private bool EVGPEXWZIOT(ulong a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2AAAE40", Offset = "0x2AA9A40", VA = "0x182AAAE40")]
		private bool IMOCZRHNPGW(byte[] a, ulong b, ulong c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2AAC9C0", Offset = "0x2AAB5C0", VA = "0x182AAC9C0")]
		private bool GOFPSKLGBIA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2AAC5F0", Offset = "0x2AAB1F0", VA = "0x182AAC5F0")]
		public bool EnableSubtitles(MediaPath mediaPath)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2AACF40", Offset = "0x2AABB40", VA = "0x182AACF40")]
		[IteratorStateMachine(typeof(YEYLLQOKDWU))]
		private IEnumerator IUAPESSEQIJ(string a, MediaPath b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2AAC020", Offset = "0x2AAAC20", VA = "0x182AAC020")]
		public void DisableSubtitles()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "4")]
		private void UNBOZVVQPFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2AABF20", Offset = "0x2AAAB20", VA = "0x182AABF20", Slot = "5")]
		private void DMVWLMWFJBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2AB0910", Offset = "0x2AAF510", VA = "0x182AB0910")]
		public MediaPlayer()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class MediaPlaylist
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public class MediaItem
		{
			[Cpp2IlInjected.Token(Token = "0x2000027")]
			public enum SourceType
			{
				[Cpp2IlInjected.Token(Token = "0x400016D")]
				AVProVideoPlayer
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			[SerializeField]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			[SerializeField]
			public SourceType sourceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			[SerializeField]
			public MediaPath mediaPath;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			[SerializeField]
			public Texture2D texture;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			[SerializeField]
			public float textureDuration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			[SerializeField]
			public bool loop;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			[SerializeField]
			public PlaylistMediaPlayer.StartMode startMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			[SerializeField]
			public PlaylistMediaPlayer.ProgressMode progressMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			[SerializeField]
			public float progressTimeSeconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			[SerializeField]
			public bool isOverrideTransition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			[SerializeField]
			public PlaylistMediaPlayer.Transition overrideTransition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			[SerializeField]
			public float overrideTransitionDuration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			[SerializeField]
			public XPZGRJVDVLT.Preset overrideTransitionEasing;

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x2AAAA60", Offset = "0x2AA9660", VA = "0x182AAAA60")]
			public MediaItem()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[SerializeField]
		private List<MediaItem> _items;

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public List<MediaItem> Items
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2AB1770", Offset = "0x2AB0370", VA = "0x182AB1770")]
		public bool OYAQQJXTHKK(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2AB17D0", Offset = "0x2AB03D0", VA = "0x182AB17D0")]
		public MediaPlaylist()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[AddComponentMenu("AVPro Video/Playlist Media Player", -80)]
	[HelpURL("https://www.renderheads.com/products/avpro-video/")]
	public class PlaylistMediaPlayer : MediaPlayer, QOSOQPMLJWU
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public enum Transition
		{
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			Fade,
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			Black,
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			White,
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			Transparent,
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			Horiz,
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			Vert,
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			Diag,
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			MirrorH,
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			MirrorV,
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			MirrorD,
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			ScrollV,
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			ScrollH,
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			Circle,
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			Diamond,
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			Blinds,
			[Cpp2IlInjected.Token(Token = "0x400019C")]
			Arrows,
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			SlideH,
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			SlideV,
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			Zoom,
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			RectV,
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			Random
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public enum PlaylistLoopMode
		{
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			Loop
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public enum StartMode
		{
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			Immediate,
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			Manual
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public enum ProgressMode
		{
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			OnFinish,
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			BeforeFinish,
			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			Manual
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private sealed class BZRAHKUXNJA : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			private object PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public PlaylistMediaPlayer DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			private object LDTKDHZVICR
			{
				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
			[DebuggerHidden]
			public BZRAHKUXNJA(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x2AA8090", Offset = "0x2AA6C90", VA = "0x182AA8090", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x2AA8050", Offset = "0x2AA6C50", VA = "0x182AA8050", Slot = "8")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[SerializeField]
		private Shader _transitionShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[SerializeField]
		private MediaPlayer _playerA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		[SerializeField]
		private MediaPlayer _playerB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		[SerializeField]
		private bool _playlistAutoProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E9")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		[Tooltip("Close the video on the other MediaPlayer when it is not visible any more. This is useful for freeing up memory and GPU decoding resources.")]
		[SerializeField]
		private bool _autoCloseVideo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		[SerializeField]
		private PlaylistLoopMode _playlistLoopMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[SerializeField]
		private MediaPlaylist _playlist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[Tooltip("Pause the previously playing video. This is useful for systems that will struggle to play 2 videos at once")]
		[SerializeField]
		private bool _pausePreviousOnTransition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		[SerializeField]
		private Transition _defaultTransition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[SerializeField]
		private float _defaultTransitionDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		[SerializeField]
		private XPZGRJVDVLT.Preset _defaultTransitionEasing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _playlistAudioVolume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		[SerializeField]
		private bool _playlistAudioMuted;

		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private static readonly LazyShaderProperty QYFZPYCAYUC;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private static readonly LazyShaderProperty SFGGWKSCJJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20D")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private bool WAWAHCVANZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private int WTLNLYJGOKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private MediaPlayer RGJQZIGQRXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private Material FGFNKTYVVHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private Transition YQPQWYHRXJT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private string JXATLLLAQIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private float PCGGQCHKXTX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23C")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private XPZGRJVDVLT.Preset AVINKEOHLII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private float YUWHFPMGICH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private Func<float, float> BDAQLHENABT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private RenderTexture QYLXRHMMICH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private MediaPlaylist.MediaItem CDKXSMPIUSF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private MediaPlaylist.MediaItem HDNCDACBZDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private WaitForEndOfFrame UXWFWAPMEDY;

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public MediaPlayer JHUUTZMDKSM
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x2AB4C50", Offset = "0x2AB3850", VA = "0x182AB4C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public MediaPlayer CPKVZBDJFWU
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xF6C1D0", Offset = "0xF6ADD0", VA = "0x180F6C1D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public MediaPlaylist XYZEYJLUVSG
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xDB5810", Offset = "0xDB4410", VA = "0x180DB5810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public int DKTHWAAYDVU
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x25A1330", Offset = "0x259FF30", VA = "0x1825A1330")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public MediaPlaylist.MediaItem ELUJDHTJPQJ
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x2AB4DA0", Offset = "0x2AB39A0", VA = "0x182AB4DA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Transition YLKVEZFWYEC
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x1660630", Offset = "0x165F230", VA = "0x181660630")]
			get
			{
				return default(Transition);
			}
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x1649E50", Offset = "0x1648A50", VA = "0x181649E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public float EYDXQGLSSAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x1CD89A0", Offset = "0x1CD75A0", VA = "0x181CD89A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x1CDA2F0", Offset = "0x1CD8EF0", VA = "0x181CDA2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public XPZGRJVDVLT.Preset ECEOVWPDDST
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x2441BC0", Offset = "0x24407C0", VA = "0x182441BC0")]
			get
			{
				return default(XPZGRJVDVLT.Preset);
			}
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x2883800", Offset = "0x2882400", VA = "0x182883800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public bool OGWKBYPZPBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x10C0FF0", Offset = "0x10BFBF0", VA = "0x1810C0FF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x1661BD0", Offset = "0x16607D0", VA = "0x181661BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public PlaylistLoopMode OAMLMCEKUQF
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x2AB4D90", Offset = "0x2AB3990", VA = "0x182AB4D90")]
			get
			{
				return default(PlaylistLoopMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x2369A70", Offset = "0x2368670", VA = "0x182369A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public bool QEFQLUBYSTS
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x10C2E20", Offset = "0x10C1A20", VA = "0x1810C2E20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x1661F40", Offset = "0x1660B40", VA = "0x181661F40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public override MKYYHMIYGFD QQEPSCRJPLK
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x2AB4CF0", Offset = "0x2AB38F0", VA = "0x182AB4CF0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public override VQFTYACOXJA EJKMMQAFLEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x2AB4BB0", Offset = "0x2AB37B0", VA = "0x182AB4BB0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public override QOSOQPMLJWU YNACXXLKZOV
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xDF96B0", Offset = "0xDF82B0", VA = "0x180DF96B0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public override float KZHMDOLSXDC
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x1CD9D60", Offset = "0x1CD8960", VA = "0x181CD9D60", Slot = "6")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x2AB4F30", Offset = "0x2AB3B30", VA = "0x182AB4F30", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public override bool VXGVJSDPVYB
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x10C17C0", Offset = "0x10C03C0", VA = "0x1810C17C0", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x2AB4E60", Offset = "0x2AB3A60", VA = "0x182AB4E60", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2AB3EF0", Offset = "0x2AB2AF0", VA = "0x182AB3EF0", Slot = "20")]
		public override void Play()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2AB3DE0", Offset = "0x2AB29E0", VA = "0x182AB3DE0", Slot = "21")]
		public override void Pause()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x10C0D60", Offset = "0x10BF960", VA = "0x1810C0D60")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2AB34C0", Offset = "0x2AB20C0", VA = "0x182AB34C0")]
		[IteratorStateMachine(typeof(BZRAHKUXNJA))]
		private IEnumerator MZBSJIZXOKP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4010", Offset = "0x2AB2C10", VA = "0x182AB4010")]
		private Texture RJXVPGYLJBJ(int a = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2540", Offset = "0x2AB1140", VA = "0x182AB2540")]
		private Texture DLLKNBDPJOM(int a = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2AB1F70", Offset = "0x2AB0B70", VA = "0x182AB1F70")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2AB35B0", Offset = "0x2AB21B0", VA = "0x182AB35B0", Slot = "23")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2AB41C0", Offset = "0x2AB2DC0", VA = "0x182AB41C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2AB3850", Offset = "0x2AB2450", VA = "0x182AB3850")]
		public void OnMediaPlayerEvent(MediaPlayer mediaPlayer, MediaPlayerEvent.EventType eventType, ErrorCode errorCode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4000", Offset = "0x2AB2C00", VA = "0x182AB4000")]
		public bool PrevItem()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2AB3530", Offset = "0x2AB2130", VA = "0x182AB3530")]
		public bool NextItem()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2470", Offset = "0x2AB1070", VA = "0x182AB2470")]
		public bool CanJumpToItem(int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2AB3380", Offset = "0x2AB1F80", VA = "0x182AB3380")]
		public bool JumpToItem(int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2AB3A10", Offset = "0x2AB2610", VA = "0x182AB3A10")]
		public void OpenVideoFile(MediaPlaylist.MediaItem mediaItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2AB3360", Offset = "0x2AB1F60", VA = "0x182AB3360")]
		private bool JLJJTLUFWXH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2100", Offset = "0x2AB0D00", VA = "0x182AB2100")]
		private void CWNLZVACICP(Transition a, float b, XPZGRJVDVLT.Preset c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4400", Offset = "0x2AB3000", VA = "0x182AB4400", Slot = "22")]
		protected override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2E80", Offset = "0x2AB1A80", VA = "0x182AB2E80", Slot = "26")]
		public Texture GetTexture(int index = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2900", Offset = "0x2AB1500", VA = "0x182AB2900", Slot = "25")]
		public int GetTextureCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x2AB29A0", Offset = "0x2AB15A0", VA = "0x182AB29A0", Slot = "27")]
		public int GetTextureFrameCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4360", Offset = "0x2AB2F60", VA = "0x182AB4360", Slot = "28")]
		public bool SupportsTextureFrameCount()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2CC0", Offset = "0x2AB18C0", VA = "0x182AB2CC0", Slot = "29")]
		public long GetTextureTimeStamp()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2B70", Offset = "0x2AB1770", VA = "0x182AB2B70", Slot = "30")]
		public float GetTexturePixelAspectRatio()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4120", Offset = "0x2AB2D20", VA = "0x182AB4120", Slot = "31")]
		public bool RequiresVerticalFlip()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2F70", Offset = "0x2AB1B70", VA = "0x182AB2F70", Slot = "35")]
		public Matrix4x4 GetYpCbCrTransform()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2C20", Offset = "0x2AB1820", VA = "0x182AB2C20", Slot = "32")]
		public StereoPacking GetTextureStereoPacking()
		{
			return default(StereoPacking);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2DE0", Offset = "0x2AB19E0", VA = "0x182AB2DE0", Slot = "33")]
		public TransparencyMode GetTextureTransparency()
		{
			return default(TransparencyMode);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2860", Offset = "0x2AB1460", VA = "0x182AB2860", Slot = "34")]
		public AlphaPacking GetTextureAlphaPacking()
		{
			return default(AlphaPacking);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2630", Offset = "0x2AB1230", VA = "0x182AB2630", Slot = "36")]
		public float[] GetAffineTransform()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2A40", Offset = "0x2AB1640", VA = "0x182AB2A40", Slot = "37")]
		public Matrix4x4 GetTextureMatrix()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2720", Offset = "0x2AB1320", VA = "0x182AB2720", Slot = "38")]
		public RenderTextureFormat GetCompatibleRenderTextureFormat(GetCompatibleRenderTextureFormatOptions options, int plane)
		{
			return default(RenderTextureFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x2AB30A0", Offset = "0x2AB1CA0", VA = "0x182AB30A0")]
		private static string ILDPUQMGKFK(Transition a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4A20", Offset = "0x2AB3620", VA = "0x182AB4A20")]
		public PlaylistMediaPlayer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[AddComponentMenu("AVPro Video/Resolve To RenderTexture", 330)]
	[HelpURL("https://www.renderheads.com/products/avpro-video/")]
	public class ResolveToRenderTexture : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[SerializeField]
		private MediaPlayer _mediaPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[SerializeField]
		private VideoResolveOptions _options;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		[SerializeField]
		private UJBEHFTDBMD.ResolveFlags _resolveFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[SerializeField]
		private RenderTexture _externalTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private Material YFPCMFVACRC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private bool VUXJCNOXQZD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x71")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private bool ZNGOXWMOHKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x72")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private bool HDTHJVEKKIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private RenderTexture SVXIZLPABFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private int QLCGGELKOMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private Material CFVUPUSSSDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private int FBNXZNYGGNF;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public MediaPlayer WMBUFECCIBP
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x2AB5150", Offset = "0x2AB3D50", VA = "0x182AB5150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public VideoResolveOptions WCUZXOEFFDT
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x2AB5B10", Offset = "0x2AB4710", VA = "0x182AB5B10")]
			get
			{
				return default(VideoResolveOptions);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x2AB5B30", Offset = "0x2AB4730", VA = "0x182AB5B30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public RenderTexture HKEVTITASFM
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xCEE130", Offset = "0xCECD30", VA = "0x180CEE130")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xCEE140", Offset = "0xCECD40", VA = "0x180CEE140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public RenderTexture AUCBKZIEADK
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x2AB5A90", Offset = "0x2AB4690", VA = "0x182AB5A90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2AB58D0", Offset = "0x2AB44D0", VA = "0x182AB58D0")]
		public void SetMaterialDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5150", Offset = "0x2AB3D50", VA = "0x182AB5150")]
		private void PZYQWGVSHCR(MediaPlayer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x2AB58E0", Offset = "0x2AB44E0", VA = "0x182AB58E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5020", Offset = "0x2AB3C20", VA = "0x182AB5020")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x2AB51F0", Offset = "0x2AB3DF0", VA = "0x182AB51F0")]
		public void Resolve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x2AB50D0", Offset = "0x2AB3CD0", VA = "0x182AB50D0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5030", Offset = "0x2AB3C30", VA = "0x182AB5030")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5A40", Offset = "0x2AB4640", VA = "0x182AB5A40")]
		public ResolveToRenderTexture()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[AddComponentMenu("AVPro Video/Update Multi-Pass Stereo", 320)]
	[HelpURL("https://www.renderheads.com/products/avpro-video/")]
	public class UpdateMultiPassStereo : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[Header("Stereo camera")]
		[SerializeField]
		private Camera _camera;

		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private static readonly LazyShaderProperty DMECEWPCKVB;

		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private static readonly LazyShaderProperty WWRVPJZAWNQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private Camera IBXWOXZUQMQ;

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Camera JWJSLJKTSLR
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0xCF1770", Offset = "0xCF0370", VA = "0x180CF1770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5B50", Offset = "0x2AB4750", VA = "0x182AB5B50")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2AB6000", Offset = "0x2AB4C00", VA = "0x182AB6000")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2AB6010", Offset = "0x2AB4C10", VA = "0x182AB6010")]
		private void YRLYMQMKRYA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5BF0", Offset = "0x2AB47F0", VA = "0x182AB5BF0")]
		private static bool ECLFGFVDCOF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5C20", Offset = "0x2AB4820", VA = "0x182AB5C20")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF20", Offset = "0xCEEB20", VA = "0x180CEFF20")]
		public UpdateMultiPassStereo()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public abstract class ApplyToBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[Header("Media Source")]
		[SerializeField]
		protected MediaPlayer _media;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[Space(8f)]
		[Header("Display")]
		[SerializeField]
		private bool _automaticStereoPacking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[SerializeField]
		private StereoPacking _overrideStereoPacking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		[SerializeField]
		private bool _stereoRedGreenTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		protected bool BTUDFYWRLMH;

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public MediaPlayer WWNRCTDPFVX
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x2AA1C70", Offset = "0x2AA0870", VA = "0x182AA1C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public bool CEQFHXJPWRQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xD86C20", Offset = "0xD85820", VA = "0x180D86C20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x2AA1C50", Offset = "0x2AA0850", VA = "0x182AA1C50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public StereoPacking ESWNPWPDZQX
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xDE4620", Offset = "0xDE3220", VA = "0x180DE4620")]
			get
			{
				return default(StereoPacking);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x2AA1C60", Offset = "0x2AA0860", VA = "0x182AA1C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public bool EMHNLZGNKCP
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xD4DD70", Offset = "0xD4C970", VA = "0x180D4DD70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x2AA1C80", Offset = "0x2AA0880", VA = "0x182AA1C80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1970", Offset = "0x2AA0570", VA = "0x182AA1970")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1A60", Offset = "0x2AA0660", VA = "0x182AA1A60")]
		private void PZYQWGVSHCR(MediaPlayer a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1980", Offset = "0x2AA0580", VA = "0x182AA1980")]
		private void BXERGFBGHPQ(MediaPlayer a, MediaPlayerEvent.EventType b, ErrorCode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x2AA19C0", Offset = "0x2AA05C0", VA = "0x182AA19C0")]
		public void ForceUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1C10", Offset = "0x2AA0810", VA = "0x182AA1C10")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1A10", Offset = "0x2AA0610", VA = "0x182AA1A10", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x1ADFCA0", Offset = "0x1ADE8A0", VA = "0x181ADFCA0", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1A00", Offset = "0x2AA0600", VA = "0x182AA1A00")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "6")]
		protected virtual void RDKWBKPVFMQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "7")]
		protected virtual void MAHZOPDWLVB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void Apply();

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x18B7A10", Offset = "0x18B6610", VA = "0x1818B7A10")]
		protected ApplyToBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class BSHZFMZBBVM
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		protected class KBJKYMPTHEW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public HashSet<AudioOutput> DDBBBDCXAVA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public float[] PUWENAASQAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public bool FCAQYDRMYKX;

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public KBJKYMPTHEW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private static BSHZFMZBBVM CUYIASSGSRY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private Dictionary<int, KBJKYMPTHEW> EGCALWHAFFV;

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public static BSHZFMZBBVM UXEDIFVFAQD
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x2AA7ED0", Offset = "0x2AA6AD0", VA = "0x182AA7ED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7FD0", Offset = "0x2AA6BD0", VA = "0x182AA7FD0")]
		private BSHZFMZBBVM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7530", Offset = "0x2AA6130", VA = "0x182AA7530")]
		public void GUKFSILPYMN(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7360", Offset = "0x2AA5F60", VA = "0x182AA7360")]
		public void AFHYPVJJPIW(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7620", Offset = "0x2AA6220", VA = "0x182AA7620")]
		public void IPNGCIXLGLH(AudioOutput a, MediaPlayer b, int c, float[] d, int e, int f, AudioOutput.AudioOutputMode g, bool h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x2AA74F0", Offset = "0x2AA60F0", VA = "0x182AA74F0")]
		private void GUHSRMCWLBW(float[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x2AA73E0", Offset = "0x2AA5FE0", VA = "0x182AA73E0")]
		private bool EZCGAZATDDC(MediaPlayer a, float[] b, int c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[DefaultMember("Item")]
	public abstract class HLYYMTUNGKO : NHBIMHXARPO, VQFTYACOXJA, MKYYHMIYGFD, IVVIHARYVRP, QOSOQPMLJWU, CKWZZXUVMEW, DFAYJFKHIBQ, CQXJJYGCXEL, LUHLXMRMVIM, JAFDMGAXOYN, IEnumerable, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		protected string ANECJQIXVQW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		protected ErrorCode WFPAIOWVXAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		protected FilterMode EWHEFMLIRLS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		protected TextureWrapMode PSYYGABXKHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		protected int KFMJZICMSCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		protected MediaHints AKKWFKDODUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		protected WZYGHYHBGMH KYLQYTRPZPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		protected WZYGHYHBGMH EFMDRFYKFJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private float JLCOUYKNPFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private int DKJSIWYGIFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private float HZXUNCKLOQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private float VITYIQTSVBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private int FTFFSFQCLIZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private int YXNSAUUPTMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		protected List<GOFAKXDZPAQ> QVMSBLXHALQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		protected GOFAKXDZPAQ SQUGFGXTTHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		protected UTPNJPMOGAZ ZQTCDNRRUTW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		protected YZEIMJQGRVU GPHXJJNGJCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		protected PHLBYEWSKZB APHBYSQXZEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		protected RUKLNAXGXEK FFCDTHTJQIZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		protected YKPFPIIYBZB UEVLUTWHMJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		protected PNDIVGTTIOT[] AZGGZSYQNAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		protected List<XLVJELDUGXT> FIWKZWLSDUD;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA710", Offset = "0x2AA9310", VA = "0x182AAA710")]
		public HLYYMTUNGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "82")]
		public abstract string QMSQUHHBFHO();

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "83")]
		public abstract string NMTBOLZNLRK();

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "84")]
		public abstract bool XLDAPSRNICQ(string a, long b, string c, MediaHints d, int e = 0, bool f = false);

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "85")]
		public virtual bool IHKGLATWNLM(byte[] a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "86")]
		public virtual bool GFOWBOHBHBM(ulong a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "87")]
		public virtual bool UFOXPVEBTMB(byte[] a, ulong b, ulong c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "88")]
		public virtual bool RCWBOHHZGYR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA670", Offset = "0x2AA9270", VA = "0x182AAA670", Slot = "89")]
		public virtual void ZRZNUGQFNZC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(Slot = "90")]
		public abstract void SCKUIAPFPVM(bool a);

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "91")]
		public abstract bool BOYNSEHBEIC();

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(Slot = "92")]
		public abstract bool UYJGCOFVFNP();

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "93")]
		public abstract bool EWICGHQDSIM();

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(Slot = "94")]
		public abstract void Play();

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(Slot = "95")]
		public abstract void Pause();

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(Slot = "96")]
		public abstract void Stop();

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA2C0", Offset = "0x2AA8EC0", VA = "0x182AAA2C0", Slot = "97")]
		public virtual void UOPRLMGIPQX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(Slot = "98")]
		public abstract void MDVTVUWZBXG(double a);

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(Slot = "99")]
		public abstract void YZVIFGHFQYO(double a);

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(Slot = "100")]
		public abstract double IUPLUCAUGQY();

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(Slot = "101")]
		public abstract float KDWTIWZJVGP();

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(Slot = "102")]
		public abstract void ISGDIXZBIUD(float a);

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(Slot = "103")]
		public abstract double WPGSAZQMYWY();

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(Slot = "104")]
		public abstract int SYAAPUEQMKV();

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(Slot = "105")]
		public abstract int RKHMUMQPFVK();

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(Slot = "106")]
		public abstract float VGCPPHDORVY();

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(Slot = "107")]
		public abstract bool OQHNRGFZQRQ();

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(Slot = "108")]
		public abstract bool KDAXMIIHXIH();

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(Slot = "109")]
		public abstract bool DUKCFZDUNTW();

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(Slot = "110")]
		public abstract bool NDJOXMKLKKS();

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(Slot = "111")]
		public abstract bool VTMTMYCZDNE();

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(Slot = "112")]
		public abstract bool RDEGVYYLYCK();

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "113")]
		public abstract bool ODQOTXUATLU();

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "114")]
		public virtual bool RZDCYAVBLBA(Camera a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xD5B4A0", Offset = "0xD5A0A0", VA = "0x180D5B4A0", Slot = "115")]
		public virtual int GetTextureCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "116")]
		public abstract Texture GetTexture(int index = 0);

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "117")]
		public abstract int GetTextureFrameCount();

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "118")]
		public virtual bool SupportsTextureFrameCount()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9A70", Offset = "0x2AA8670", VA = "0x182AA9A70", Slot = "119")]
		public virtual long GetTextureTimeStamp()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(Slot = "120")]
		public abstract bool RequiresVerticalFlip();

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xD9A780", Offset = "0xD99380", VA = "0x180D9A780", Slot = "121")]
		public virtual float GetTexturePixelAspectRatio()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9A80", Offset = "0x2AA8680", VA = "0x182AA9A80", Slot = "122")]
		public virtual Matrix4x4 GetYpCbCrTransform()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9760", Offset = "0x2AA8360", VA = "0x182AA9760", Slot = "123")]
		public virtual float[] GetAffineTransform()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA100", Offset = "0x2AA8D00", VA = "0x182AAA100", Slot = "124")]
		public virtual float[] PQRBTKOGAQJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x2AA98A0", Offset = "0x2AA84A0", VA = "0x182AA98A0", Slot = "125")]
		public virtual Matrix4x4 GetTextureMatrix()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xF2F330", Offset = "0xF2DF30", VA = "0x180F2F330", Slot = "126")]
		public virtual RenderTextureFormat GetCompatibleRenderTextureFormat(GetCompatibleRenderTextureFormatOptions options, int plane)
		{
			return default(RenderTextureFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9A40", Offset = "0x2AA8640", VA = "0x182AA9A40", Slot = "70")]
		public StereoPacking GetTextureStereoPacking()
		{
			return default(StereoPacking);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(Slot = "127")]
		internal abstract StereoPacking ILNOZEIRYRL();

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xCF1A00", Offset = "0xCF0600", VA = "0x180CF1A00", Slot = "128")]
		public virtual TransparencyMode GetTextureTransparency()
		{
			return default(TransparencyMode);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9860", Offset = "0x2AA8460", VA = "0x182AA9860", Slot = "72")]
		public AlphaPacking GetTextureAlphaPacking()
		{
			return default(AlphaPacking);
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(Slot = "129")]
		public abstract void WYTPLNWFJFP(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(Slot = "130")]
		public abstract bool URFJTSBQFCH();

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "131")]
		public abstract void HXJTFELGDHA(float a);

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "132")]
		public virtual void ZJJEEKCAOUU(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(Slot = "133")]
		public abstract float PXCIZNZZNIC();

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xD3F500", Offset = "0xD3E100", VA = "0x180D3F500", Slot = "134")]
		public virtual float GetBalance()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xD3F510", Offset = "0xD3E110", VA = "0x180D3F510", Slot = "135")]
		public virtual int FJBFLHJUHEE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "136")]
		public virtual int EZCGAZATDDC(float[] a, int b, int c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "137")]
		public virtual void JPIORPMMCRK(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "138")]
		public virtual void QEOMKJIPWRY(Quaternion a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "139")]
		public virtual void XQBCQSXNXEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "140")]
		public virtual void MLASEEMEIGO(Audio360ChannelMode a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "141")]
		public virtual void LCFDNSPADDR(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "142")]
		public virtual void UBAETCYCXMH(float a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "143")]
		public virtual void XMPOMJMWYCA(Quaternion a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "144")]
		public virtual void DWOQUCJMMEP(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "145")]
		public virtual void OOMHGQQSFSQ(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(Slot = "146")]
		public abstract void Update();

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "147")]
		public virtual void GCVWHSQPSVL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "148")]
		public abstract void Render();

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(Slot = "149")]
		public abstract void Dispose();

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "150")]
		public virtual void UCMLNSBZGFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA030", Offset = "0x2AA8C30", VA = "0x182AAA030", Slot = "40")]
		public ErrorCode NSRILIKZTYW()
		{
			return default(ErrorCode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "151")]
		public virtual bool LEPQSZEQTHF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xCF43A0", Offset = "0xCF2FA0", VA = "0x180CF43A0", Slot = "39")]
		public WZYGHYHBGMH DLMPNPRTKSL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9520", Offset = "0x2AA8120", VA = "0x182AA9520", Slot = "42")]
		public void AUTXZZFYOCS([Out] FilterMode a, [Out] TextureWrapMode b, [Out] int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA230", Offset = "0x2AA8E30", VA = "0x182AAA230", Slot = "41")]
		public void TILNSKPGBYO(FilterMode a = FilterMode.Bilinear, TextureWrapMode b = TextureWrapMode.Clamp, int c = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA5D0", Offset = "0x2AA91D0", VA = "0x182AAA5D0", Slot = "152")]
		protected virtual void XZLHGJZFCNU(Texture a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA120", Offset = "0x2AA8D20", VA = "0x182AAA120")]
		protected void QGLDUSQNAJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9EB0", Offset = "0x2AA8AB0", VA = "0x182AA9EB0")]
		protected bool MSMACBJXAQL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9C40", Offset = "0x2AA8840", VA = "0x182AA9C40", Slot = "153")]
		public virtual bool KIDVDKKOALG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA1C0", Offset = "0x2AA8DC0", VA = "0x182AAA1C0", Slot = "77")]
		public bool TIHBTQSXXTG(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9AE0", Offset = "0x2AA86E0", VA = "0x182AA9AE0", Slot = "154")]
		public virtual void HQKKSOXQGZI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9C20", Offset = "0x2AA8820", VA = "0x182AA9C20", Slot = "155")]
		public virtual int JQSBHXJUVRG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA2E0", Offset = "0x2AA8EE0", VA = "0x182AAA2E0", Slot = "156")]
		public virtual string UXOEZYACOTZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "157")]
		public virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA040", Offset = "0x2AA8C40", VA = "0x182AAA040", Slot = "158")]
		public int PASZTQTAWPY(float a = 0f)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA320", Offset = "0x2AA8F20", VA = "0x182AAA320")]
		protected bool UZEVEBQWRLT(bool a = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "159")]
		internal abstract bool DAHAKAFQDNN();

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(Slot = "160")]
		internal abstract string ZTKQEBYLFBA();

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "161")]
		internal abstract bool BXRUDEYLANN(TrackType a);

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "162")]
		internal abstract int VTDTTBETUAR(TrackType a);

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(Slot = "163")]
		internal abstract ODGOXWJTMPM CCFXRHXYIFY(TrackType a, int b, bool c);

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9540", Offset = "0x2AA8140", VA = "0x182AA9540")]
		private void BBXGUXPCKNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x2AA96B0", Offset = "0x2AA82B0", VA = "0x182AA96B0")]
		protected void BDQUWOZEUWV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA400", Offset = "0x2AA9000", VA = "0x182AAA400")]
		private void XPLONUCHMOZ(PNDIVGTTIOT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x2AA97D0", Offset = "0x2AA83D0", VA = "0x182AA97D0", Slot = "164")]
		public virtual IEnumerator GetEnumerator()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class MediaPlayerEvent : UnityEvent<MediaPlayer, MediaPlayerEvent.EventType, ErrorCode>
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public enum EventType
		{
			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			MetaDataReady = 0,
			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			ReadyToPlay = 1,
			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			Started = 2,
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			FirstFrameReady = 3,
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			FinishedPlaying = 4,
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			Closing = 5,
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			Error = 6,
			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			SubtitleChange = 7,
			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			Stalled = 8,
			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			Unstalled = 9,
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			ResolutionChanged = 10,
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			StartedSeeking = 11,
			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			FinishedSeeking = 12,
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			StartedBuffering = 13,
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			FinishedBuffering = 14,
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			PropertiesChanged = 15,
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			PlaylistItemChanged = 16,
			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			PlaylistFinished = 17,
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			TextTracksChanged = 18,
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			Paused = 19,
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			Unpaused = 20,
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			TextCueChanged = 7
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private List<UnityAction<MediaPlayer, EventType, ErrorCode>> FJLQLMFWQEG;

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x2AAAC90", Offset = "0x2AA9890", VA = "0x182AAAC90")]
		public bool WEYBFHMCCQR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x2AAAB00", Offset = "0x2AA9700", VA = "0x182AAAB00")]
		public void KEBZCUSVLIX(UnityAction<MediaPlayer, EventType, ErrorCode> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x2AAABF0", Offset = "0x2AA97F0", VA = "0x182AAABF0")]
		public void QVITPDQUUBG(UnityAction<MediaPlayer, EventType, ErrorCode> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x2AAACF0", Offset = "0x2AA98F0", VA = "0x182AAACF0")]
		public MediaPlayerEvent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class GGMGTYNCVEU
	{
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private static Matrix4x4 KAXGTOREHLM;

		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private static Matrix4x4 GKQUDAABUZG;

		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private static Matrix4x4 DZYKZMEMPBQ;

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC600", Offset = "0x2ABB200", VA = "0x182ABC600")]
		public static string TEJFSFZFWRR(MediaPathType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC3F0", Offset = "0x2ABAFF0", VA = "0x182ABC3F0")]
		public static string SWTBPDQCRBL(string a, MediaPathType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC2D0", Offset = "0x2ABAED0", VA = "0x182ABC2D0")]
		public static string MPNWXTXNEPD(ErrorCode a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x2ABBD20", Offset = "0x2ABA920", VA = "0x182ABBD20")]
		public static void EIITCSSNILU(string a, [Optional] UnityEngine.Object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x2ABBE00", Offset = "0x2ABAA00", VA = "0x182ABBE00")]
		public static int FELNECLOOTH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x2ABBF10", Offset = "0x2ABAB10", VA = "0x182ABBF10")]
		public static int HLJYVUPTJCJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x2ABB960", Offset = "0x2ABA560", VA = "0x182ABB960")]
		public static Orientation AGXVMRUKHKG(float[] a)
		{
			return default(Orientation);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC760", Offset = "0x2ABB360", VA = "0x182ABC760")]
		public static int VIIYWWLSRNR(double a, float b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x2ABBE30", Offset = "0x2ABAA30", VA = "0x182ABBE30")]
		private static extern int GetShortPathName(string pathName, StringBuilder shortName, int cbShortName);

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x2ABBB70", Offset = "0x2ABA770", VA = "0x182ABBB70")]
		internal static string CSDVPSODDWV(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x2ABBFA0", Offset = "0x2ABABA0", VA = "0x182ABBFA0")]
		public static Texture2D JDCCXUKXCNB(Texture a, bool b, Orientation c, [Optional] Texture2D d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public interface NHBIMHXARPO
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnEnable();

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Update();

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void UCMLNSBZGFC();

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void GCVWHSQPSVL();

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Render();
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public interface CKWZZXUVMEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TIHBTQSXXTG(string a);

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int JQSBHXJUVRG();

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(Slot = "2")]
		string UXOEZYACOTZ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public interface VQFTYACOXJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool XLDAPSRNICQ(string a, long b, string c, MediaHints d, int e = 0, bool f = false);

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool IHKGLATWNLM(byte[] a);

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool GFOWBOHBHBM(ulong a);

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool UFOXPVEBTMB(byte[] a, ulong b, ulong c);

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool RCWBOHHZGYR();

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void ZRZNUGQFNZC();

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void SCKUIAPFPVM(bool a);

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool BOYNSEHBEIC();

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool UYJGCOFVFNP();

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool EWICGHQDSIM();

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool NDJOXMKLKKS();

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool DUKCFZDUNTW();

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool VTMTMYCZDNE();

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(Slot = "13")]
		bool RDEGVYYLYCK();

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(Slot = "14")]
		bool ODQOTXUATLU();

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void Play();

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void Pause();

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void Stop();

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void UOPRLMGIPQX();

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void MDVTVUWZBXG(double a);

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void YZVIFGHFQYO(double a);

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(Slot = "21")]
		double IUPLUCAUGQY();

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(Slot = "22")]
		float KDWTIWZJVGP();

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void ISGDIXZBIUD(float a);

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void WYTPLNWFJFP(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(Slot = "25")]
		bool URFJTSBQFCH();

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void HXJTFELGDHA(float a);

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void ZJJEEKCAOUU(float a);

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(Slot = "28")]
		float PXCIZNZZNIC();

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(Slot = "29")]
		float GetBalance();

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(Slot = "30")]
		WZYGHYHBGMH DLMPNPRTKSL();

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(Slot = "31")]
		ErrorCode NSRILIKZTYW();

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(Slot = "32")]
		void TILNSKPGBYO(FilterMode a = FilterMode.Bilinear, TextureWrapMode b = TextureWrapMode.Clamp, int c = 1);

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(Slot = "33")]
		void AUTXZZFYOCS([Out] FilterMode a, [Out] TextureWrapMode b, [Out] int c);

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(Slot = "34")]
		int EZCGAZATDDC(float[] a, int b, int c);

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(Slot = "35")]
		int FJBFLHJUHEE();

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void JPIORPMMCRK(bool a);

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(Slot = "37")]
		void MLASEEMEIGO(Audio360ChannelMode a);

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(Slot = "38")]
		void QEOMKJIPWRY(Quaternion a);

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(Slot = "39")]
		void XQBCQSXNXEH();

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(Slot = "40")]
		void LCFDNSPADDR(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(Slot = "41")]
		void UBAETCYCXMH(float a, float b);

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(Slot = "42")]
		void XMPOMJMWYCA(Quaternion a);

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(Slot = "43")]
		bool RZDCYAVBLBA(Camera a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(Slot = "44")]
		void DWOQUCJMMEP(string a);

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(Slot = "45")]
		void OOMHGQQSFSQ(byte[] a);
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public interface MKYYHMIYGFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(Slot = "0")]
		double WPGSAZQMYWY();

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int SYAAPUEQMKV();

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int RKHMUMQPFVK();

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(Slot = "3")]
		float VGCPPHDORVY();

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool KDAXMIIHXIH();

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool LEPQSZEQTHF();

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool KIDVDKKOALG();

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float[] PQRBTKOGAQJ();
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public interface IVVIHARYVRP
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public interface QOSOQPMLJWU
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int GetTextureCount();

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Texture GetTexture(int index = 0);

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
		StereoPacking GetTextureStereoPacking();

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(Slot = "8")]
		TransparencyMode GetTextureTransparency();

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(Slot = "9")]
		AlphaPacking GetTextureAlphaPacking();

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
		RenderTextureFormat GetCompatibleRenderTextureFormat(GetCompatibleRenderTextureFormatOptions options = GetCompatibleRenderTextureFormatOptions.Default, int plane = 0);
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[Flags]
	public enum GetCompatibleRenderTextureFormatOptions
	{
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		ForResolve = 1,
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		RequiresAlpha = 2
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public enum Platform
	{
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		Windows = 0,
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		macOS = 1,
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		iOS = 2,
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		tvOS = 3,
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		visionOS = 4,
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		Android = 5,
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		WindowsUWP = 6,
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		WebGL = 7,
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		OpenHarmony = 8,
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		Count = 8,
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		Unknown = 100
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public enum MediaSource
	{
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		Reference,
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		Path
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public enum MediaPathType
	{
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		AbsolutePathOrURL,
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		RelativeToProjectFolder,
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		RelativeToStreamingAssetsFolder,
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		RelativeToDataFolder,
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		RelativeToPersistentDataFolder
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class MediaPath
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		[SerializeField]
		private MediaPathType _pathType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		[SerializeField]
		private string _path;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public MediaPathType PathType
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0xCEE110", Offset = "0xCECD10", VA = "0x180CEE110")]
			get
			{
				return default(MediaPathType);
			}
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A40", Offset = "0xCF0640", VA = "0x180CF1A40")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public string Path
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A10", Offset = "0xCF0610", VA = "0x180CF1A10")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0DD0", Offset = "0x2ABF9D0", VA = "0x182AC0DD0")]
		public MediaPath()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0D60", Offset = "0x2ABF960", VA = "0x182AC0D60")]
		public MediaPath(MediaPath copy)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0CF0", Offset = "0x2ABF8F0", VA = "0x182AC0CF0")]
		public MediaPath(string path, MediaPathType pathType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0AB0", Offset = "0x2ABF6B0", VA = "0x182AC0AB0")]
		public string RVBNJQCKFMG()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x2AC09E0", Offset = "0x2ABF5E0", VA = "0x182AC09E0")]
		public static MediaPath LBSJLKWWTAL(string a)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x2AC09C0", Offset = "0x2ABF5C0", VA = "0x182AC09C0")]
		public static bool IQJYWSDTJLC(MediaPath a, MediaPath b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0A70", Offset = "0x2ABF670", VA = "0x182AC0A70")]
		public static bool OOOEUMVNSLV(MediaPath a, MediaPath b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0880", Offset = "0x2ABF480", VA = "0x182AC0880", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0970", Offset = "0x2ABF570", VA = "0x182AC0970", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public enum StereoPacking
	{
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		TopBottom = 1,
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		LeftRight = 2,
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		CustomUV = 3,
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		TwoTextures = 4,
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		Unknown = 10
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct MediaHints
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public TransparencyMode transparency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public AlphaPacking alphaPacking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public StereoPacking stereoPacking;

		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private static MediaHints defaultHints;

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public static MediaHints FYIBPTBKDJH
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x2AC0830", Offset = "0x2ABF430", VA = "0x182AC0830")]
			get
			{
				return default(MediaHints);
			}
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct VideoResolveOptions
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public enum AspectRatio
		{
			[Cpp2IlInjected.Token(Token = "0x400022B")]
			NoScaling,
			[Cpp2IlInjected.Token(Token = "0x400022C")]
			FitVertically,
			[Cpp2IlInjected.Token(Token = "0x400022D")]
			FitHorizontally,
			[Cpp2IlInjected.Token(Token = "0x400022E")]
			FitInside,
			[Cpp2IlInjected.Token(Token = "0x400022F")]
			FitOutside,
			[Cpp2IlInjected.Token(Token = "0x4000230")]
			Stretch
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		[SerializeField]
		public bool applyHSBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		[SerializeField]
		[Range(0f, 1f)]
		public float hue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		[SerializeField]
		[Range(0f, 1f)]
		public float saturation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		[SerializeField]
		[Range(0f, 1f)]
		public float brightness;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		[SerializeField]
		[Range(0f, 1f)]
		public float contrast;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		[SerializeField]
		[Range(0.0001f, 10f)]
		public float gamma;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		[SerializeField]
		public Color tint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		[SerializeField]
		public bool generateMipmaps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		[SerializeField]
		public AspectRatio aspectRatio;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x2AC89C0", Offset = "0x2AC75C0", VA = "0x182AC89C0")]
		public bool CPWCUYNHJVV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x2AC8A90", Offset = "0x2AC7690", VA = "0x182AC8A90")]
		internal void VOCLVPROQOU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x2AC8A20", Offset = "0x2AC7620", VA = "0x182AC8A20")]
		public static VideoResolveOptions Create()
		{
			return default(VideoResolveOptions);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum TransparencyMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		Opaque,
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		Transparent
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public enum StereoEye
	{
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		Both,
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		Left,
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		Right
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public enum AlphaPacking
	{
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		TopBottom,
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		LeftRight
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public enum ErrorCode
	{
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		LoadFailed = 100,
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		DecodeFailed = 200
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public enum Orientation
	{
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		Landscape,
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		LandscapeFlipped,
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		Portrait,
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		PortraitFlipped,
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		PortraitHorizontalMirror
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public enum VideoMapping
	{
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		Normal,
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		EquiRectangular360,
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		EquiRectangular180,
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		CubeMap3x2
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public enum FileFormat
	{
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		HLS,
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		DASH,
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		SmoothStreaming
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class TVJPRMLGCJL
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public enum VideoApi
		{
			[Cpp2IlInjected.Token(Token = "0x4000252")]
			MediaFoundation,
			[Cpp2IlInjected.Token(Token = "0x4000253")]
			DirectShow,
			[Cpp2IlInjected.Token(Token = "0x4000254")]
			WinRT
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public enum AudioOutput
		{
			[Cpp2IlInjected.Token(Token = "0x4000256")]
			System,
			[Cpp2IlInjected.Token(Token = "0x4000257")]
			Unity,
			[Cpp2IlInjected.Token(Token = "0x4000258")]
			FacebookAudio360,
			[Cpp2IlInjected.Token(Token = "0x4000259")]
			None
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public static class USRIJRCXICL
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		public enum VideoApi
		{
			[Cpp2IlInjected.Token(Token = "0x400025B")]
			MediaFoundation,
			[Cpp2IlInjected.Token(Token = "0x400025C")]
			WinRT
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public enum AudioOutput
		{
			[Cpp2IlInjected.Token(Token = "0x400025E")]
			System,
			[Cpp2IlInjected.Token(Token = "0x400025F")]
			Unity,
			[Cpp2IlInjected.Token(Token = "0x4000260")]
			FacebookAudio360,
			[Cpp2IlInjected.Token(Token = "0x4000261")]
			None
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public static class Android
	{
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public enum VideoApi
		{
			[Cpp2IlInjected.Token(Token = "0x4000263")]
			MediaPlayer = 1,
			[Cpp2IlInjected.Token(Token = "0x4000264")]
			ExoPlayer
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public static class GJRZPPCECEN
	{
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public enum ExternalLibrary
		{
			[Cpp2IlInjected.Token(Token = "0x4000266")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000267")]
			DashJs,
			[Cpp2IlInjected.Token(Token = "0x4000268")]
			HlsJs,
			[Cpp2IlInjected.Token(Token = "0x4000269")]
			Custom
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public enum Audio360ChannelMode
	{
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		TBE_8_2,
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		TBE_8,
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		TBE_6_2,
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		TBE_6,
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		TBE_4_2,
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		TBE_4,
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		TBE_8_PAIR0,
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		TBE_8_PAIR1,
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		TBE_8_PAIR2,
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		TBE_8_PAIR3,
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		TBE_CHANNEL0,
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		TBE_CHANNEL1,
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		TBE_CHANNEL2,
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		TBE_CHANNEL3,
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		TBE_CHANNEL4,
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		TBE_CHANNEL5,
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		TBE_CHANNEL6,
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		TBE_CHANNEL7,
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		HEADLOCKED_STEREO,
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		HEADLOCKED_CHANNEL0,
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		HEADLOCKED_CHANNEL1,
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		AMBIX_4,
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		AMBIX_4_2,
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		AMBIX_9,
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		AMBIX_9_2,
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		AMBIX_16,
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		AMBIX_16_2,
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		MONO,
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		STEREO,
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		UNKNOWN,
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		INVALID
	}
	[StructLayout((LayoutKind)0, Pack = 1, Size = 16)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct TimeRange
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public double startTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public double duration;
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[DefaultMember("Item")]
	public class WZYGHYHBGMH : IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		internal TimeRange[] UBKPDPZQLLR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		internal double DFDMIVPNGNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		internal double GABRPWBJKWM;

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public int LHDUJAQMHJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x2838540", Offset = "0x2837140", VA = "0x182838540")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public double CADLFLDRHGN
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x2AC8E70", Offset = "0x2AC7A70", VA = "0x182AC8E70")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public double XRGJEUADYBV
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x2AC8C40", Offset = "0x2AC7840", VA = "0x182AC8C40")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public double RIPWOCYENUE
		{
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x2AC8C30", Offset = "0x2AC7830", VA = "0x182AC8C30")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x2AC8E80", Offset = "0x2AC7A80", VA = "0x182AC8E80")]
		internal WZYGHYHBGMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x2AC8C10", Offset = "0x2AC7810", VA = "0x182AC8C10", Slot = "4")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x2AC8C50", Offset = "0x2AC7850", VA = "0x182AC8C50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x2AC8AC0", Offset = "0x2AC76C0", VA = "0x182AC8AC0")]
		internal void BDSZFRGCION()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class UTPNJPMOGAZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private int EJPZXVENXID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private long XHJBUSFIYMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private HLYYMTUNGKO MTJZGFKVEVO;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public int ZWCCSAUCJFY
		{
			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0xCEE110", Offset = "0xCECD10", VA = "0x180CEE110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A40", Offset = "0xCF0640", VA = "0x180CF1A40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public int CKMATJMJKZZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0xDDD830", Offset = "0xDDC430", VA = "0x180DDD830")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0xDDD820", Offset = "0xDDC420", VA = "0x180DDD820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public int XKEUJAWHGUH
		{
			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0xCF76D0", Offset = "0xCF62D0", VA = "0x180CF76D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0xCF8B80", Offset = "0xCF7780", VA = "0x180CF8B80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		private float OJDEFRHLKVP
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x13F89C0", Offset = "0x13F75C0", VA = "0x1813F89C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		private string SDNNXJKNUSP
		{
			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0xCF1770", Offset = "0xCF0370", VA = "0x180CF1770")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		private int UBTFVVDCABV
		{
			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A00", Offset = "0xCF0600", VA = "0x180CF1A00")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A20", Offset = "0xCF0620", VA = "0x180CF1A20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		private int JJOXQHYMTUU
		{
			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0xDE4620", Offset = "0xDE3220", VA = "0x180DE4620")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x1DF70A0", Offset = "0x1DF5CA0", VA = "0x181DF70A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public bool NQUSWZAUYRM
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0xD4DD70", Offset = "0xD4C970", VA = "0x180D4DD70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x2AC7ED0", Offset = "0x2AC6AD0", VA = "0x182AC7ED0")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x2AC7F20", Offset = "0x2AC6B20", VA = "0x182AC7F20")]
		internal void Start(HLYYMTUNGKO player)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x2AC82D0", Offset = "0x2AC6ED0", VA = "0x182AC82D0")]
		internal void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0")]
		private static bool SVRRONRSLIN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public UTPNJPMOGAZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public sealed class MYEZNHIFBXI : HLYYMTUNGKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private bool GOEUQKIRAOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private bool WAWAHCVANZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private double MSLNHCQJTXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private float XGMXNCLCOOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private float NQSPBKZJOIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private bool RKQXEUTYZEX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private int LUOBXXSYKQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private int WISODELBNZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private Texture2D BYWVWJWZXQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private Texture2D TIHUHSMMXYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private Texture2D IGQVFIYMFCY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private float AMBYCFEUELI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private int PKWZTDZEQNL;

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x2AC03B0", Offset = "0x2ABEFB0", VA = "0x182AC03B0", Slot = "82")]
		public override string QMSQUHHBFHO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0360", Offset = "0x2ABEF60", VA = "0x182AC0360", Slot = "83")]
		public override string NMTBOLZNLRK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x2AC05D0", Offset = "0x2ABF1D0", VA = "0x182AC05D0", Slot = "84")]
		public override bool XLDAPSRNICQ(string a, long b, string c, MediaHints d, int e = 0, bool f = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x2AC07C0", Offset = "0x2ABF3C0", VA = "0x182AC07C0", Slot = "89")]
		public override void ZRZNUGQFNZC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xDEC020", Offset = "0xDEAC20", VA = "0x180DEC020", Slot = "90")]
		public override void SCKUIAPFPVM(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xDEBD20", Offset = "0xDEA920", VA = "0x180DEBD20", Slot = "91")]
		public override bool BOYNSEHBEIC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "92")]
		public override bool UYJGCOFVFNP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "93")]
		public override bool EWICGHQDSIM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "107")]
		public override bool OQHNRGFZQRQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "108")]
		public override bool KDAXMIIHXIH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0390", Offset = "0x2ABEF90", VA = "0x182AC0390", Slot = "94")]
		public override void Play()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0380", Offset = "0x2ABEF80", VA = "0x182AC0380", Slot = "95")]
		public override void Pause()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0430", Offset = "0x2ABF030", VA = "0x182AC0430", Slot = "96")]
		public override void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "109")]
		public override bool DUKCFZDUNTW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xFF9430", Offset = "0xFF8030", VA = "0x180FF9430", Slot = "110")]
		public override bool NDJOXMKLKKS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xEED340", Offset = "0xEEBF40", VA = "0x180EED340", Slot = "111")]
		public override bool VTMTMYCZDNE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x2AC03E0", Offset = "0x2ABEFE0", VA = "0x182AC03E0", Slot = "112")]
		public override bool RDEGVYYLYCK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "113")]
		public override bool ODQOTXUATLU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x2AC05C0", Offset = "0x2ABF1C0", VA = "0x182AC05C0", Slot = "103")]
		public override double WPGSAZQMYWY()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x10C2D20", Offset = "0x10C1920", VA = "0x1810C2D20", Slot = "104")]
		public override int SYAAPUEQMKV()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xFFC9E0", Offset = "0xFFB5E0", VA = "0x180FFC9E0", Slot = "105")]
		public override int RKHMUMQPFVK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xE44B00", Offset = "0xE43700", VA = "0x180E44B00", Slot = "116")]
		public override Texture GetTexture(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x1EB7FB0", Offset = "0x1EB6BB0", VA = "0x181EB7FB0", Slot = "117")]
		public override int GetTextureFrameCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xF1C560", Offset = "0xF1B160", VA = "0x180F1C560", Slot = "127")]
		internal override StereoPacking ILNOZEIRYRL()
		{
			return default(StereoPacking);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "120")]
		public override bool RequiresVerticalFlip()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0350", Offset = "0x2ABEF50", VA = "0x182AC0350", Slot = "98")]
		public override void MDVTVUWZBXG(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0350", Offset = "0x2ABEF50", VA = "0x182AC0350", Slot = "99")]
		public override void YZVIFGHFQYO(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0340", Offset = "0x2ABEF40", VA = "0x182AC0340", Slot = "100")]
		public override double IUPLUCAUGQY()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x2037280", Offset = "0x2035E80", VA = "0x182037280", Slot = "102")]
		public override void ISGDIXZBIUD(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x1F89030", Offset = "0x1F87C30", VA = "0x181F89030", Slot = "101")]
		public override float KDWTIWZJVGP()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "129")]
		public override void WYTPLNWFJFP(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "130")]
		public override bool URFJTSBQFCH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x1E3C7E0", Offset = "0x1E3B3E0", VA = "0x181E3C7E0", Slot = "131")]
		public override void HXJTFELGDHA(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x1E3B420", Offset = "0x1E3A020", VA = "0x181E3B420", Slot = "133")]
		public override float PXCIZNZZNIC()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xD3F500", Offset = "0xD3E100", VA = "0x180D3F500", Slot = "106")]
		public override float VGCPPHDORVY()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0440", Offset = "0x2ABF040", VA = "0x182AC0440", Slot = "146")]
		public override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "148")]
		public override void Render()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "149")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "161")]
		internal override bool BXRUDEYLANN(TrackType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "162")]
		internal override int VTDTTBETUAR(TrackType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "163")]
		internal override ODGOXWJTMPM CCFXRHXYIFY(TrackType a, int b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "159")]
		internal override bool DAHAKAFQDNN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "160")]
		internal override string ZTKQEBYLFBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0800", Offset = "0x2ABF400", VA = "0x182AC0800")]
		public MYEZNHIFBXI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class YUPKYYAQCXQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public string RBFVIQANYHT
		{
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2FC0", VA = "0x180CF43C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public string ZUWNXREQBJH
		{
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A10", Offset = "0xCF0610", VA = "0x180CF1A10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public byte[] ALNQIQOLOYK
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0xCF1770", Offset = "0xCF0370", VA = "0x180CF1770")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x2ACC250", Offset = "0x2ACAE50", VA = "0x182ACC250")]
		public YUPKYYAQCXQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x2ACC1F0", Offset = "0x2ACADF0", VA = "0x182ACC1F0")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class CYIVVYCESUK : HLYYMTUNGKO
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		private struct Native
		{
			[Cpp2IlInjected.Token(Token = "0x200005F")]
			internal enum TimeRangeTypes
			{
				[Cpp2IlInjected.Token(Token = "0x40002D7")]
				Seekable,
				[Cpp2IlInjected.Token(Token = "0x40002D8")]
				Buffered
			}

			[Cpp2IlInjected.Token(Token = "0x2000060")]
			public enum RenderThreadEvent
			{
				[Cpp2IlInjected.Token(Token = "0x40002DA")]
				BeginRender,
				[Cpp2IlInjected.Token(Token = "0x40002DB")]
				UpdateAllTextures,
				[Cpp2IlInjected.Token(Token = "0x40002DC")]
				FreeTextures,
				[Cpp2IlInjected.Token(Token = "0x40002DD")]
				WaitForNewFrame
			}

			[StructLayout((LayoutKind)0, Pack = 1, Size = 28)]
			[Cpp2IlInjected.Token(Token = "0x2000061")]
			public struct AuthData
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002DE")]
				public string url;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40002DF")]
				public string token;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002E0")]
				public IntPtr keyBytes;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002E1")]
				public int keyBytesLength;
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x2AC30F0", Offset = "0x2AC1CF0", VA = "0x182AC30F0")]
			public static extern bool IsChangedTracks(IntPtr instance, TrackType trackType);

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x2AC2740", Offset = "0x2AC1340", VA = "0x182AC2740")]
			public static extern int GetTrackCount(IntPtr instance, TrackType trackType);

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x2AC2860", Offset = "0x2AC1460", VA = "0x182AC2860")]
			public static extern bool GetTrackInfo(IntPtr instance, TrackType trackType, int index, int uid, bool isActive, StringBuilder name, int maxNameLength, StringBuilder language, int maxLanguageLength);

			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x2AC2F60", Offset = "0x2AC1B60", VA = "0x182AC2F60")]
			public static extern bool IsChangedTextCue(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x2AC1950", Offset = "0x2AC0550", VA = "0x182AC1950")]
			public static extern IntPtr GetCurrentTextCue(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x2AC2610", Offset = "0x2AC1210", VA = "0x182AC2610")]
			public static extern int GetTimeRanges(IntPtr playerInstance, [Out] TimeRange[] ranges, int rangeCount, TimeRangeTypes timeRangeType);

			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x2AC2DE0", Offset = "0x2AC19E0", VA = "0x182AC2DE0")]
			public static extern bool Init(bool linearColorSpace);

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x2AC1330", Offset = "0x2ABFF30", VA = "0x182AC1330")]
			public static extern void Deinit();

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x2AC2010", Offset = "0x2AC0C10", VA = "0x182AC2010")]
			public static extern IntPtr GetPluginVersion();

			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x2AC0F00", Offset = "0x2ABFB00", VA = "0x182AC0F00")]
			public static extern IntPtr BeginOpenSource(IntPtr instance, TVJPRMLGCJL.VideoApi videoApi, TVJPRMLGCJL.AudioOutput audioOutput, bool useHardwareDecoding, bool useRendererSync, bool generateTextureMips, bool hintAlphaChannel, bool useLowLatency, bool use10BitTextures, string forceAudioOutputDeviceName, int unitySampleRate, IntPtr[] preferredFilter, uint numFilters, int audio360ChannelMode, string httpHeader, bool startWithHighestBitrate);

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x2AC15A0", Offset = "0x2AC01A0", VA = "0x182AC15A0")]
			public static extern IntPtr EndOpenSource(IntPtr instance, string path);

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x2AC3B30", Offset = "0x2AC2730", VA = "0x182AC3B30")]
			public static extern IntPtr OpenSourceFromBuffer(IntPtr instance, byte[] buffer, ulong bufferLength, TVJPRMLGCJL.VideoApi videoApi, TVJPRMLGCJL.AudioOutput audioOutput, bool useHardwareDecoding, bool useRendererSync, bool generateTextureMips, bool hintAlphaChannel, bool useLowLatency, bool use10BitTextures, string forceAudioOutputDeviceName, int unitySampleRate, IntPtr[] preferredFilter, uint numFilters);

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x2AC5160", Offset = "0x2AC3D60", VA = "0x182AC5160")]
			public static extern IntPtr StartOpenSourceFromBuffer(IntPtr instance, TVJPRMLGCJL.VideoApi videoApi, ulong bufferLength);

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x2AC0E40", Offset = "0x2ABFA40", VA = "0x182AC0E40")]
			public static extern bool AddChunkToSourceBuffer(IntPtr instance, byte[] buffer, ulong offset, ulong chunkLength);

			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x2AC1420", Offset = "0x2AC0020", VA = "0x182AC1420")]
			public static extern IntPtr EndOpenSourceFromBuffer(IntPtr instance, TVJPRMLGCJL.AudioOutput audioOutput, bool useHardwareDecoding, bool useRendererSync, bool generateTextureMips, bool hintAlphaChannel, bool useLowLatency, bool use10BitTextures, string forceAudioOutputDeviceName, int unitySampleRate, IntPtr[] preferredFilter, uint numFilters);

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x2AC1240", Offset = "0x2ABFE40", VA = "0x182AC1240")]
			public static extern void CloseSource(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x2AC1F20", Offset = "0x2AC0B20", VA = "0x182AC1F20")]
			public static extern IntPtr GetPlayerDescription(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x2AC4600", Offset = "0x2AC3200", VA = "0x182AC4600")]
			public static extern void SetCustomMovParserEnabled(IntPtr instance, bool enabled);

			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x2AC47C0", Offset = "0x2AC33C0", VA = "0x182AC47C0")]
			public static extern void SetHapNotchLCEnabled(IntPtr instance, bool enabled);

			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x2AC4F30", Offset = "0x2AC3B30", VA = "0x182AC4F30")]
			public static extern void SetStereoDetectEnabled(IntPtr instance, bool enabled);

			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x2AC4FC0", Offset = "0x2AC3BC0", VA = "0x182AC4FC0")]
			public static extern void SetTextTrackSupportEnabled(IntPtr instance, bool enabled);

			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x2AC4110", Offset = "0x2AC2D10", VA = "0x182AC4110")]
			public static extern void SetAudioDelayEnabled(IntPtr instance, bool enabled, bool isAutomatic, double timeSeconds);

			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x2AC4730", Offset = "0x2AC3330", VA = "0x182AC4730")]
			public static extern void SetFacebookAudio360SupportEnabled(IntPtr instance, bool enabled);

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x2AC4690", Offset = "0x2AC3290", VA = "0x182AC4690")]
			public static extern void SetDecoderHints(IntPtr instance, int parallelFrameCount, int prerollFrameCount);

			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x2AC1C50", Offset = "0x2AC0850", VA = "0x182AC1C50")]
			public static extern int GetLastErrorCode(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x2AC3E60", Offset = "0x2AC2A60", VA = "0x182AC3E60")]
			public static extern void Play(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x2AC3CE0", Offset = "0x2AC28E0", VA = "0x182AC3CE0")]
			public static extern void Pause(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x2AC4AC0", Offset = "0x2AC36C0", VA = "0x182AC4AC0")]
			public static extern void SetMuted(IntPtr instance, bool muted);

			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x2AC5050", Offset = "0x2AC3C50", VA = "0x182AC5050")]
			public static extern void SetVolume(IntPtr instance, float volume);

			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x2AC44D0", Offset = "0x2AC30D0", VA = "0x182AC44D0")]
			public static extern void SetBalance(IntPtr instance, float volume);

			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x2AC49A0", Offset = "0x2AC35A0", VA = "0x182AC49A0")]
			public static extern void SetLooping(IntPtr instance, bool looping);

			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x2AC2D60", Offset = "0x2AC1960", VA = "0x182AC2D60")]
			public static extern bool HasVideo(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x2AC2C60", Offset = "0x2AC1860", VA = "0x182AC2C60")]
			public static extern bool HasAudio(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x2AC2B20", Offset = "0x2AC1720", VA = "0x182AC2B20")]
			public static extern int GetWidth(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x2AC1BD0", Offset = "0x2AC07D0", VA = "0x182AC1BD0")]
			public static extern int GetHeight(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x2AC1B50", Offset = "0x2AC0750", VA = "0x182AC1B50")]
			public static extern float GetFrameRate(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x2AC21E0", Offset = "0x2AC0DE0", VA = "0x182AC21E0")]
			public static extern StereoPacking GetStereoPacking(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x2AC1A50", Offset = "0x2AC0650", VA = "0x182AC1A50")]
			public static extern double GetDuration(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x2AC3200", Offset = "0x2AC1E00", VA = "0x182AC3200")]
			public static extern bool IsPlaybackStalled(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x2AC2CE0", Offset = "0x2AC18E0", VA = "0x182AC2CE0")]
			public static extern bool HasMetaData(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x2AC1140", Offset = "0x2ABFD40", VA = "0x182AC1140")]
			public static extern bool CanPlay(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x2AC3300", Offset = "0x2AC1F00", VA = "0x182AC3300")]
			public static extern bool IsSeeking(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x2AC3280", Offset = "0x2AC1E80", VA = "0x182AC3280")]
			public static extern bool IsPlaying(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x2AC3180", Offset = "0x2AC1D80", VA = "0x182AC3180")]
			public static extern bool IsFinished(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x2AC2EE0", Offset = "0x2AC1AE0", VA = "0x182AC2EE0")]
			public static extern bool IsBuffering(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x2AC19D0", Offset = "0x2AC05D0", VA = "0x182AC19D0")]
			public static extern double GetCurrentTime(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x2AC4560", Offset = "0x2AC3160", VA = "0x182AC4560")]
			public static extern void SetCurrentTime(IntPtr instance, double time, bool fast);

			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x2AC4E10", Offset = "0x2AC3A10", VA = "0x182AC4E10")]
			public static extern void SetPlaybackRate(IntPtr instance, float rate);

			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0x2AC50E0", Offset = "0x2AC3CE0", VA = "0x182AC50E0")]
			public static extern void StartExtractFrame(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0x2AC5300", Offset = "0x2AC3F00", VA = "0x182AC5300")]
			public static extern void WaitForExtract(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0x2AC5200", Offset = "0x2AC3E00", VA = "0x182AC5200")]
			public static extern void Update(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0x2AC1640", Offset = "0x2AC0240", VA = "0x182AC1640")]
			public static extern void EndUpdate(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0x2AC23E0", Offset = "0x2AC0FE0", VA = "0x182AC23E0")]
			public static extern IntPtr GetTexturePointer(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(RVA = "0x2AC2260", Offset = "0x2AC0E60", VA = "0x182AC2260")]
			public static extern int GetTextureFormat(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(RVA = "0x2AC3400", Offset = "0x2AC2000", VA = "0x182AC3400")]
			public static extern bool IsTextureTopDown(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0x2AC3380", Offset = "0x2AC1F80", VA = "0x182AC3380")]
			public static extern bool IsTextureSampleLinear(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0x2AC22E0", Offset = "0x2AC0EE0", VA = "0x182AC22E0")]
			public static extern int GetTextureFrameCount(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x2AC2460", Offset = "0x2AC1060", VA = "0x182AC2460")]
			public static extern long GetTextureTimeStamp(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x2AC2360", Offset = "0x2AC0F60", VA = "0x182AC2360")]
			public static extern float GetTexturePixelAspectRatio(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0x2AC20F0", Offset = "0x2AC0CF0", VA = "0x182AC20F0")]
			public static extern IntPtr GetRenderEventFunc();

			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x2AC2BA0", Offset = "0x2AC17A0", VA = "0x182AC2BA0")]
			public static extern int GrabAudio(IntPtr instance, float[] buffer, int sampleCount, int channelCount);

			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0x2AC17D0", Offset = "0x2AC03D0", VA = "0x182AC17D0")]
			public static extern int GetAudioChannelCount(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0x2AC4080", Offset = "0x2AC2C80", VA = "0x182AC4080")]
			public static extern int SetAudioChannelMode(IntPtr instance, int audio360ChannelMode);

			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x2AC4850", Offset = "0x2AC3450", VA = "0x182AC4850")]
			public static extern void SetHeadOrientation(IntPtr instance, float x, float y, float z, float w);

			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x2AC41C0", Offset = "0x2AC2DC0", VA = "0x182AC41C0")]
			public static extern void SetAudioFocusEnabled(IntPtr instance, bool enabled);

			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x2AC4250", Offset = "0x2AC2E50", VA = "0x182AC4250")]
			public static extern void SetAudioFocusProps(IntPtr instance, float offFocusLevel, float widthDegrees);

			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x2AC42F0", Offset = "0x2AC2EF0", VA = "0x182AC42F0")]
			public static extern void SetAudioFocusRotation(IntPtr instance, float x, float y, float z, float w);

			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x2AC3710", Offset = "0x2AC2310", VA = "0x182AC3710")]
			public static void JHDGLDFTOOH(IntPtr a, YUPKYYAQCXQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x2AC4B50", Offset = "0x2AC3750", VA = "0x182AC4B50")]
			private static extern void SetNextAuthData(IntPtr instance, AuthData authData);
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private TVJPRMLGCJL.AudioOutput INOMCHSJGJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		private string ERMVUUXIAMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private List<string> AXIERHPORDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private Audio360ChannelMode RDPSIWRBSEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private bool HIPFBWQTRQE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC5")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private bool JDKNFCFOMKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC6")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private bool NUCWEOCQZEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC7")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private bool SECJQFNPEEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private bool PKICFXBKQPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private bool ZHFRHXJVBSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private int KTMZPRKFLWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private int VTXZQNEPDVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private bool GOEUQKIRAOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD5")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private bool WAWAHCVANZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD6")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private bool XWQGBQGEFZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD7")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private bool XGYMIKDNFLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private bool LCCUXKQCGJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private int BSLNCQPOFGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private int WISODELBNZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private float ESZAJKHCOOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private float OOZNDJHOMTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private bool AQSRQYWGZCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private float XGMXNCLCOOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private float JHZVRAORSEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private bool OWVDQXMPRWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF9")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		private bool CFBNJBHAEJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFA")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private bool HKFHRXPMGXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private IntPtr LJQLQXLMEMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private Texture2D BYWVWJWZXQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		private RenderTexture NRFPYACXHEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private IntPtr CUYIASSGSRY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private TVJPRMLGCJL.VideoApi TMINKCAAVAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private bool RVDYKIYWZLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x125")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private bool FVQFUSAWOIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x126")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private bool MVJABROFBAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x127")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private bool AAJQHSSKKJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private bool ZWQEMCGVMNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x129")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private bool UEUDUHUPPOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12A")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private bool DQKPOQYOGNV;

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private static bool PMNFTUTVOMG;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private static string TDLYGZXXFBJ;

		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private static IntPtr ACUKJDUUQLC;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private static int TGOJDGLCXSI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private YUPKYYAQCXQ ZLTPSWOXKXI;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public YUPKYYAQCXQ OKITMMBYTLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x2AB6C40", Offset = "0x2AB5840", VA = "0x182AB6C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x2AB7140", Offset = "0x2AB5D40", VA = "0x182AB7140")]
		public static bool DOIUPDNRMOQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8040", Offset = "0x2AB6C40", VA = "0x182AB8040")]
		public static void IKQUSAKATCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x2AB77D0", Offset = "0x2AB63D0", VA = "0x182AB77D0", Slot = "135")]
		public override int FJBFLHJUHEE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x2ABB6E0", Offset = "0x2ABA2E0", VA = "0x182ABB6E0")]
		public CYIVVYCESUK(MediaPlayer.OptionsWindows a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x2ABAE00", Offset = "0x2AB9A00", VA = "0x182ABAE00")]
		public void XONDWKOSFBQ(MediaPlayer.OptionsWindows a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x2ABAEB0", Offset = "0x2AB9AB0", VA = "0x182ABAEB0")]
		public void XONDWKOSFBQ(TVJPRMLGCJL.VideoApi a, TVJPRMLGCJL.AudioOutput b, bool c, bool d, bool e, bool f, bool g, bool h, string i, List<string> j, bool k, int l, int m, bool n, bool o, bool p, bool q, bool r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8F40", Offset = "0x2AB7B40", VA = "0x182AB8F40", Slot = "82")]
		public override string QMSQUHHBFHO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x2AB84F0", Offset = "0x2AB70F0", VA = "0x182AB84F0", Slot = "83")]
		public override string NMTBOLZNLRK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8390", Offset = "0x2AB6F90", VA = "0x182AB8390")]
		private bool KOHHGZFAKIP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x2ABA340", Offset = "0x2AB8F40", VA = "0x182ABA340", Slot = "84")]
		public override bool XLDAPSRNICQ(string a, long b, string c, MediaHints d, int e = 0, bool f = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x2AB7BE0", Offset = "0x2AB67E0", VA = "0x182AB7BE0", Slot = "85")]
		public override bool IHKGLATWNLM(byte[] a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x2AB7910", Offset = "0x2AB6510", VA = "0x182AB7910", Slot = "86")]
		public override bool GFOWBOHBHBM(ulong a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x2AB9840", Offset = "0x2AB8440", VA = "0x182AB9840", Slot = "87")]
		public override bool UFOXPVEBTMB(byte[] a, ulong b, ulong c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8F90", Offset = "0x2AB7B90", VA = "0x182AB8F90", Slot = "88")]
		public override bool RCWBOHHZGYR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x2ABB0F0", Offset = "0x2AB9CF0", VA = "0x182ABB0F0")]
		private void XOWNMOMDEXC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x2ABB3F0", Offset = "0x2AB9FF0", VA = "0x182ABB3F0", Slot = "89")]
		public override void ZRZNUGQFNZC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x2AB96E0", Offset = "0x2AB82E0", VA = "0x182AB96E0", Slot = "90")]
		public override void SCKUIAPFPVM(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x2AB1040", Offset = "0x2AAFC40", VA = "0x182AB1040", Slot = "91")]
		public override bool BOYNSEHBEIC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0xEF1690", Offset = "0xEF0290", VA = "0x180EF1690", Slot = "92")]
		public override bool UYJGCOFVFNP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x10911D0", Offset = "0x108FDD0", VA = "0x1810911D0", Slot = "107")]
		public override bool OQHNRGFZQRQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x108F7A0", Offset = "0x108E3A0", VA = "0x18108F7A0", Slot = "108")]
		public override bool KDAXMIIHXIH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x2AB7700", Offset = "0x2AB6300", VA = "0x182AB7700", Slot = "93")]
		public override bool EWICGHQDSIM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8E70", Offset = "0x2AB7A70", VA = "0x182AB8E70", Slot = "94")]
		public override void Play()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8DE0", Offset = "0x2AB79E0", VA = "0x182AB8DE0", Slot = "95")]
		public override void Pause()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x2AB9700", Offset = "0x2AB8300", VA = "0x182AB9700", Slot = "96")]
		public override void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x2AB7530", Offset = "0x2AB6130", VA = "0x182AB7530", Slot = "109")]
		public override bool DUKCFZDUNTW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x2AB84E0", Offset = "0x2AB70E0", VA = "0x182AB84E0", Slot = "110")]
		public override bool NDJOXMKLKKS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x2ABA1F0", Offset = "0x2AB8DF0", VA = "0x182ABA1F0", Slot = "111")]
		public override bool VTMTMYCZDNE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x2AB9360", Offset = "0x2AB7F60", VA = "0x182AB9360", Slot = "112")]
		public override bool RDEGVYYLYCK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8520", Offset = "0x2AB7120", VA = "0x182AB8520", Slot = "113")]
		public override bool ODQOTXUATLU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x2ABA230", Offset = "0x2AB8E30", VA = "0x182ABA230", Slot = "103")]
		public override double WPGSAZQMYWY()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x24B2210", Offset = "0x24B0E10", VA = "0x1824B2210", Slot = "104")]
		public override int SYAAPUEQMKV()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x21AB3F0", Offset = "0x21A9FF0", VA = "0x1821AB3F0", Slot = "105")]
		public override int RKHMUMQPFVK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x1F3E1D0", Offset = "0x1F3CDD0", VA = "0x181F3E1D0", Slot = "106")]
		public override float VGCPPHDORVY()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x2AB7B20", Offset = "0x2AB6720", VA = "0x182AB7B20", Slot = "116")]
		public override Texture GetTexture(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x2AB79E0", Offset = "0x2AB65E0", VA = "0x182AB79E0", Slot = "117")]
		public override int GetTextureFrameCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x2AB7AA0", Offset = "0x2AB66A0", VA = "0x182AB7AA0", Slot = "119")]
		public override long GetTextureTimeStamp()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x2AB79F0", Offset = "0x2AB65F0", VA = "0x182AB79F0", Slot = "121")]
		public override float GetTexturePixelAspectRatio()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x108FC70", Offset = "0x108E870", VA = "0x18108FC70", Slot = "120")]
		public override bool RequiresVerticalFlip()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x2AB80F0", Offset = "0x2AB6CF0", VA = "0x182AB80F0", Slot = "127")]
		internal override StereoPacking ILNOZEIRYRL()
		{
			return default(StereoPacking);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8430", Offset = "0x2AB7030", VA = "0x182AB8430", Slot = "98")]
		public override void MDVTVUWZBXG(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x2ABB330", Offset = "0x2AB9F30", VA = "0x182ABB330", Slot = "99")]
		public override void YZVIFGHFQYO(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8190", Offset = "0x2AB6D90", VA = "0x182AB8190", Slot = "100")]
		public override double IUPLUCAUGQY()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8170", Offset = "0x2AB6D70", VA = "0x182AB8170", Slot = "102")]
		public override void ISGDIXZBIUD(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x17D8B50", Offset = "0x17D7750", VA = "0x1817D8B50", Slot = "101")]
		public override float KDWTIWZJVGP()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x2ABA2B0", Offset = "0x2AB8EB0", VA = "0x182ABA2B0", Slot = "129")]
		public override void WYTPLNWFJFP(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x10C15F0", Offset = "0x10C01F0", VA = "0x1810C15F0", Slot = "130")]
		public override bool URFJTSBQFCH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x2AB7BC0", Offset = "0x2AB67C0", VA = "0x182AB7BC0", Slot = "131")]
		public override void HXJTFELGDHA(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x28DAAC0", Offset = "0x28D96C0", VA = "0x1828DAAC0", Slot = "133")]
		public override float PXCIZNZZNIC()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x2ABB350", Offset = "0x2AB9F50", VA = "0x182ABB350", Slot = "132")]
		public override void ZJJEEKCAOUU(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x20DC470", Offset = "0x20DB070", VA = "0x1820DC470", Slot = "134")]
		public override float GetBalance()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x2AB82E0", Offset = "0x2AB6EE0", VA = "0x182AB82E0", Slot = "153")]
		public override bool KIDVDKKOALG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x2AB9410", Offset = "0x2AB8010", VA = "0x182AB9410", Slot = "114")]
		public override bool RZDCYAVBLBA(Camera a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8450", Offset = "0x2AB7050", VA = "0x182AB8450", Slot = "140")]
		public override void MLASEEMEIGO(Audio360ChannelMode a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8F00", Offset = "0x2AB7B00", VA = "0x182AB8F00", Slot = "138")]
		public override void QEOMKJIPWRY(Quaternion a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x2ABB220", Offset = "0x2AB9E20", VA = "0x182ABB220", Slot = "139")]
		public override void XQBCQSXNXEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x2AB83A0", Offset = "0x2AB6FA0", VA = "0x182AB83A0", Slot = "141")]
		public override void LCFDNSPADDR(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x2AB9720", Offset = "0x2AB8320", VA = "0x182AB9720", Slot = "142")]
		public override void UBAETCYCXMH(float a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x2ABAD50", Offset = "0x2AB9950", VA = "0x182ABAD50", Slot = "143")]
		public override void XMPOMJMWYCA(Quaternion a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x2AB9900", Offset = "0x2AB8500", VA = "0x182AB9900", Slot = "146")]
		public override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8C60", Offset = "0x2AB7860", VA = "0x182AB8C60")]
		private void PQYLOGDYRAY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x2AB86C0", Offset = "0x2AB72C0", VA = "0x182AB86C0")]
		private void OXDAYXXBFHO(IntPtr a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x2AB97C0", Offset = "0x2AB83C0", VA = "0x182AB97C0", Slot = "150")]
		public override void UCMLNSBZGFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
		private void TOZRXPDWNNR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x2AB7850", Offset = "0x2AB6450", VA = "0x182AB7850", Slot = "147")]
		public override void GCVWHSQPSVL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x2AB95E0", Offset = "0x2AB81E0", VA = "0x182AB95E0", Slot = "148")]
		public override void Render()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "149")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x2AB7710", Offset = "0x2AB6310", VA = "0x182AB7710", Slot = "136")]
		public override int EZCGAZATDDC(float[] a, int b, int c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x233DE60", Offset = "0x233CA60", VA = "0x18233DE60", Slot = "151")]
		public override bool LEPQSZEQTHF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x2AB7620", Offset = "0x2AB6220", VA = "0x182AB7620")]
		private static void ETWTCBARXVX(Native.RenderThreadEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x2AB85B0", Offset = "0x2AB71B0", VA = "0x182AB85B0")]
		private static string OMRIUVDZUNX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x2AB70B0", Offset = "0x2AB5CB0", VA = "0x182AB70B0", Slot = "159")]
		internal override bool DAHAKAFQDNN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x2ABB580", Offset = "0x2ABA180", VA = "0x182ABB580", Slot = "160")]
		internal override string ZTKQEBYLFBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x2AB6C80", Offset = "0x2AB5880", VA = "0x182AB6C80", Slot = "161")]
		internal override bool BXRUDEYLANN(TrackType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x2ABA150", Offset = "0x2AB8D50", VA = "0x182ABA150", Slot = "162")]
		internal override int VTDTTBETUAR(TrackType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x2AB6D20", Offset = "0x2AB5920", VA = "0x182AB6D20", Slot = "163")]
		internal override ODGOXWJTMPM CCFXRHXYIFY(TrackType a, int b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x2AB75C0", Offset = "0x2AB61C0", VA = "0x182AB75C0", Slot = "144")]
		public override void DWOQUCJMMEP(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8660", Offset = "0x2AB7260", VA = "0x182AB8660", Slot = "145")]
		public override void OOMHGQQSFSQ(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8D70", Offset = "0x2AB7970", VA = "0x182AB8D70")]
		private void PZBXQNNYLYO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8210", Offset = "0x2AB6E10", VA = "0x182AB8210")]
		private void JSAOPWBPELX(TimeRange[] a, Native.TimeRangeTypes b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public enum PlaybackState
	{
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		Opening = 1,
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		Buffering = 2,
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		Playing = 3,
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		Paused = 4,
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		StateMask = 7,
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		Seeking = 32
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public sealed class YFFHXAXMJPO : HLYYMTUNGKO
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		private struct Native
		{
			[Cpp2IlInjected.Token(Token = "0x2000065")]
			public enum SeekMode
			{
				[Cpp2IlInjected.Token(Token = "0x40002F7")]
				Fast,
				[Cpp2IlInjected.Token(Token = "0x40002F8")]
				Accurate
			}

			[StructLayout((LayoutKind)0, Pack = 1, Size = 20)]
			[Cpp2IlInjected.Token(Token = "0x2000066")]
			public struct VideoTrack
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F9")]
				public int trackIndex;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40002FA")]
				public int frameWidth;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40002FB")]
				public int frameHeight;

				[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
				[Cpp2IlInjected.Token(Token = "0x40002FC")]
				public float frameRate;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002FD")]
				public uint averageBitRate;
			}

			[StructLayout((LayoutKind)0, Pack = 1, Size = 12)]
			[Cpp2IlInjected.Token(Token = "0x2000067")]
			public struct SeekParams
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002FE")]
				public double timeSeconds;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40002FF")]
				public SeekMode mode;
			}

			[StructLayout((LayoutKind)0, Pack = 1, Size = 28)]
			[Cpp2IlInjected.Token(Token = "0x2000068")]
			public struct AuthData
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000300")]
				public string url;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000301")]
				public string token;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000302")]
				public IntPtr keyBytes;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000303")]
				public int keyBytesLength;
			}

			[Cpp2IlInjected.Token(Token = "0x2000069")]
			internal enum TimeRangeTypes
			{
				[Cpp2IlInjected.Token(Token = "0x4000305")]
				Seekable,
				[Cpp2IlInjected.Token(Token = "0x4000306")]
				Buffered
			}

			[Cpp2IlInjected.Token(Token = "0x40002F5")]
			private static IntPtr _nativeFunction_UnityRenderEvent;

			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0x2AC3060", Offset = "0x2AC1C60", VA = "0x182AC3060")]
			public static extern bool IsChangedTracks(IntPtr instance, TrackType trackType);

			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x2AC27D0", Offset = "0x2AC13D0", VA = "0x182AC27D0")]
			public static extern int GetTrackCount(IntPtr instance, TrackType trackType);

			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0x2AC29C0", Offset = "0x2AC15C0", VA = "0x182AC29C0")]
			public static extern bool GetTrackInfo(IntPtr instance, TrackType trackType, int index, int uid, bool isActive, StringBuilder name, int maxNameLength, StringBuilder language, int maxLanguageLength);

			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0x2AC2FE0", Offset = "0x2AC1BE0", VA = "0x182AC2FE0")]
			public static extern bool IsChangedTextCue(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0x2AC18D0", Offset = "0x2AC04D0", VA = "0x182AC18D0")]
			public static extern IntPtr GetCurrentTextCue(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0x2AC1FA0", Offset = "0x2AC0BA0", VA = "0x182AC1FA0")]
			private static extern IntPtr GetPluginVersionStringPointer();

			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0x2AC39A0", Offset = "0x2AC25A0", VA = "0x182AC39A0")]
			public static string OMRIUVDZUNX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0x2AC12C0", Offset = "0x2ABFEC0", VA = "0x182AC12C0")]
			public static extern IntPtr CreatePlayer();

			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x2AC13A0", Offset = "0x2ABFFA0", VA = "0x182AC13A0")]
			public static extern void DestroyPlayer(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0x2AC3A50", Offset = "0x2AC2650", VA = "0x182AC3A50")]
			public static extern bool OpenMedia(IntPtr playerInstance, string filePath, string httpHeader, FileFormat overrideFileFormat, bool startWithHighestBitrate, bool use10BitTextures);

			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0x2AC11C0", Offset = "0x2ABFDC0", VA = "0x182AC11C0")]
			public static extern void CloseMedia(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0x2AC3D60", Offset = "0x2AC2960", VA = "0x182AC3D60")]
			public static extern void Pause(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003D7")]
			[Cpp2IlInjected.Address(RVA = "0x2AC3DE0", Offset = "0x2AC29E0", VA = "0x182AC3DE0")]
			public static extern void Play(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003D8")]
			[Cpp2IlInjected.Address(RVA = "0x2AC4440", Offset = "0x2AC3040", VA = "0x182AC4440")]
			public static extern void SetAudioVolume(IntPtr playerInstance, float volume);

			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0x2AC3FF0", Offset = "0x2AC2BF0", VA = "0x182AC3FF0")]
			public static extern void SetAudioBalance(IntPtr playerInstance, float balance);

			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0x2AC4EA0", Offset = "0x2AC3AA0", VA = "0x182AC4EA0")]
			public static extern void SetPlaybackRate(IntPtr playerInstance, float rate);

			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0x2AC43B0", Offset = "0x2AC2FB0", VA = "0x182AC43B0")]
			public static extern void SetAudioMuted(IntPtr playerInstance, bool muted);

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x2AC2E60", Offset = "0x2AC1A60", VA = "0x182AC2E60")]
			public static extern bool IsAudioMuted(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x2AC1750", Offset = "0x2AC0350", VA = "0x182AC1750")]
			public static extern float GetAudioBalance(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x2AC1E20", Offset = "0x2AC0A20", VA = "0x182AC1E20")]
			public static extern float GetPlaybackRate(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x2AC4A30", Offset = "0x2AC3630", VA = "0x182AC4A30")]
			public static extern void SetLooping(IntPtr playerInstance, bool looping);

			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x2AC1CD0", Offset = "0x2AC08D0", VA = "0x182AC1CD0")]
			public static extern int GetLastErrorCode(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0x2AC5280", Offset = "0x2AC3E80", VA = "0x182AC5280")]
			public static extern void Update(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0x2AC1AD0", Offset = "0x2AC06D0", VA = "0x182AC1AD0")]
			public static extern double GetDuration(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x2AC2160", Offset = "0x2AC0D60", VA = "0x182AC2160")]
			public static extern StereoPacking GetStereoPacking(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x2AC1850", Offset = "0x2AC0450", VA = "0x182AC1850")]
			public static extern double GetCurrentPosition(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x2AC1D50", Offset = "0x2AC0950", VA = "0x182AC1D50")]
			public static extern bool GetLatestFrame(IntPtr playerInstance, [Out] IntPtr leftEyeTexturePointer, [Out] IntPtr rightEyeTexturePointer, [Out] ulong frameTimeStamp, [Out] int width, [Out] int height);

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x2AC1EA0", Offset = "0x2AC0AA0", VA = "0x182AC1EA0")]
			public static extern PlaybackState GetPlaybackState(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x2AC16C0", Offset = "0x2AC02C0", VA = "0x182AC16C0")]
			public static extern bool GetActiveVideoTrackInfo(IntPtr playerInstance, [Out] VideoTrack videoTrack);

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x2AC4910", Offset = "0x2AC3510", VA = "0x182AC4910")]
			public static extern void SetLiveOffset(IntPtr playerInstance, double seconds);

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x2AC3F60", Offset = "0x2AC2B60", VA = "0x182AC3F60")]
			public static extern void Seek(IntPtr playerInstance, SeekParams seekParams);

			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x2AC3480", Offset = "0x2AC2080", VA = "0x182AC3480")]
			public static void JHDGLDFTOOH(IntPtr a, YUPKYYAQCXQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0x2AC4CB0", Offset = "0x2AC38B0", VA = "0x182AC4CB0")]
			private static extern void SetNextAuthData(IntPtr playerInstance, AuthData authData);

			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0x2AC24E0", Offset = "0x2AC10E0", VA = "0x182AC24E0")]
			public static extern int GetTimeRanges(IntPtr playerInstance, [Out] TimeRange[] ranges, int rangeCount, TimeRangeTypes timeRangeType);

			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x2AC2080", Offset = "0x2AC0C80", VA = "0x182AC2080")]
			public static extern IntPtr GetRenderEventFunc();

			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0x2AC10C0", Offset = "0x2ABFCC0", VA = "0x182AC10C0")]
			public static void CKADHYPISJY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0x2AC3EE0", Offset = "0x2AC2AE0", VA = "0x182AC3EE0")]
			public static void QRIUJCBNFJB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		private class XGCVKSFIYGY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000307")]
			public Texture2D OMHBPSFWQET;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000308")]
			public IntPtr EHJJTVEABGA;

			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x2AC8EE0", Offset = "0x2AC7AE0", VA = "0x182AC8EE0")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0x2AC8FD0", Offset = "0x2AC7BD0", VA = "0x182AC8FD0")]
			public XGCVKSFIYGY()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private bool MZSDVXVHUWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private bool XWQGBQGEFZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private float XGMXNCLCOOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		private bool AAJQHSSKKJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		private bool ZUTEGOBRFHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private YUPKYYAQCXQ ZLTPSWOXKXI;

		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private static bool PMNFTUTVOMG;

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private static string TDLYGZXXFBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private ulong UCLNHUUWNZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private IntPtr EUWUVUYBTZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private XGCVKSFIYGY[] JPTGTHXJQSG;

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public YUPKYYAQCXQ OKITMMBYTLC
		{
			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x2AC9B20", Offset = "0x2AC8720", VA = "0x182AC9B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x2ACBF90", Offset = "0x2ACAB90", VA = "0x182ACBF90")]
		public YFFHXAXMJPO(MediaPlayer.OptionsWindows a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x2ACBCB0", Offset = "0x2ACA8B0", VA = "0x182ACBCB0")]
		public void XONDWKOSFBQ(MediaPlayer.OptionsWindows a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x2ACA460", Offset = "0x2AC9060", VA = "0x182ACA460", Slot = "93")]
		public override bool EWICGHQDSIM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x2ACA2E0", Offset = "0x2AC8EE0", VA = "0x182ACA2E0", Slot = "149")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "151")]
		public override bool LEPQSZEQTHF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x2ACA760", Offset = "0x2AC9360", VA = "0x182ACA760", Slot = "100")]
		public override double IUPLUCAUGQY()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x2ACB9C0", Offset = "0x2ACA5C0", VA = "0x182ACB9C0", Slot = "103")]
		public override double WPGSAZQMYWY()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x2ACA8F0", Offset = "0x2AC94F0", VA = "0x182ACA8F0", Slot = "101")]
		public override float KDWTIWZJVGP()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x2ACA590", Offset = "0x2AC9190", VA = "0x182ACA590", Slot = "116")]
		public override Texture GetTexture(int index = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x2ACA500", Offset = "0x2AC9100", VA = "0x182ACA500", Slot = "115")]
		public override int GetTextureCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0xEF16A0", Offset = "0xEF02A0", VA = "0x180EF16A0", Slot = "117")]
		public override int GetTextureFrameCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x2ACA650", Offset = "0x2AC9250", VA = "0x182ACA650", Slot = "127")]
		internal override StereoPacking ILNOZEIRYRL()
		{
			return default(StereoPacking);
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x2ACAC80", Offset = "0x2AC9880", VA = "0x182ACAC80", Slot = "82")]
		public override string QMSQUHHBFHO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x2ACAA20", Offset = "0x2AC9620", VA = "0x182ACAA20", Slot = "83")]
		public override string NMTBOLZNLRK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x2ACB860", Offset = "0x2ACA460", VA = "0x182ACB860", Slot = "106")]
		public override float VGCPPHDORVY()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x2ACB230", Offset = "0x2AC9E30", VA = "0x182ACB230", Slot = "104")]
		public override int SYAAPUEQMKV()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x2ACAD80", Offset = "0x2AC9980", VA = "0x182ACAD80", Slot = "105")]
		public override int RKHMUMQPFVK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x1668DD0", Offset = "0x16679D0", VA = "0x181668DD0", Slot = "133")]
		public override float PXCIZNZZNIC()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x2ACBD00", Offset = "0x2ACA900", VA = "0x182ACBD00", Slot = "132")]
		public override void ZJJEEKCAOUU(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x2ACA480", Offset = "0x2AC9080", VA = "0x182ACA480", Slot = "134")]
		public override float GetBalance()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x2ACAAD0", Offset = "0x2AC96D0", VA = "0x182ACAAD0", Slot = "107")]
		public override bool OQHNRGFZQRQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x2ACB390", Offset = "0x2AC9F90", VA = "0x182ACB390", Slot = "92")]
		public override bool UYJGCOFVFNP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x2ACA8B0", Offset = "0x2AC94B0", VA = "0x182ACA8B0", Slot = "108")]
		public override bool KDAXMIIHXIH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x2ACAA50", Offset = "0x2AC9650", VA = "0x182ACAA50", Slot = "113")]
		public override bool ODQOTXUATLU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x2ACACD0", Offset = "0x2AC98D0", VA = "0x182ACACD0", Slot = "112")]
		public override bool RDEGVYYLYCK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xEED340", Offset = "0xEEBF40", VA = "0x180EED340", Slot = "91")]
		public override bool BOYNSEHBEIC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x2ACB300", Offset = "0x2AC9F00", VA = "0x182ACB300", Slot = "130")]
		public override bool URFJTSBQFCH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x2ACB9A0", Offset = "0x2ACA5A0", VA = "0x182ACB9A0", Slot = "111")]
		public override bool VTMTMYCZDNE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x2ACAA00", Offset = "0x2AC9600", VA = "0x182ACAA00", Slot = "110")]
		public override bool NDJOXMKLKKS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x2ACA260", Offset = "0x2AC8E60", VA = "0x182ACA260", Slot = "109")]
		public override bool DUKCFZDUNTW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x2ACB9D0", Offset = "0x2ACA5D0", VA = "0x182ACB9D0", Slot = "129")]
		public override void WYTPLNWFJFP(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x2ACBA60", Offset = "0x2ACA660", VA = "0x182ACBA60", Slot = "84")]
		public override bool XLDAPSRNICQ(string a, long b, string c, MediaHints d, int e = 0, bool f = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x2ACBD90", Offset = "0x2ACA990", VA = "0x182ACBD90", Slot = "89")]
		public override void ZRZNUGQFNZC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x2ACAB80", Offset = "0x2AC9780", VA = "0x182ACAB80", Slot = "95")]
		public override void Pause()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x2ACAC00", Offset = "0x2AC9800", VA = "0x182ACAC00", Slot = "94")]
		public override void Play()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x2AC10C0", Offset = "0x2ABFCC0", VA = "0x182AC10C0", Slot = "148")]
		public override void Render()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x2ACAE50", Offset = "0x2AC9A50", VA = "0x182ACAE50")]
		private void RQECVWKOBMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "120")]
		public override bool RequiresVerticalFlip()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x2ACA970", Offset = "0x2AC9570", VA = "0x182ACA970", Slot = "98")]
		public override void MDVTVUWZBXG(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x2ACBCE0", Offset = "0x2ACA8E0", VA = "0x182ACBCE0", Slot = "99")]
		public override void YZVIFGHFQYO(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x2ACB210", Offset = "0x2AC9E10", VA = "0x182ACB210", Slot = "90")]
		public override void SCKUIAPFPVM(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x2ACA6D0", Offset = "0x2AC92D0", VA = "0x182ACA6D0", Slot = "102")]
		public override void ISGDIXZBIUD(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x2ACA5E0", Offset = "0x2AC91E0", VA = "0x182ACA5E0", Slot = "131")]
		public override void HXJTFELGDHA(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x2AB9700", Offset = "0x2AB8300", VA = "0x182AB9700", Slot = "96")]
		public override void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x2ACAB10", Offset = "0x2AC9710", VA = "0x182ACAB10")]
		private void PZBXQNNYLYO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x2ACA7E0", Offset = "0x2AC93E0", VA = "0x182ACA7E0")]
		private void JSAOPWBPELX(TimeRange[] a, Native.TimeRangeTypes b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x2ACB3C0", Offset = "0x2AC9FC0", VA = "0x182ACB3C0", Slot = "146")]
		public override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x2ACA280", Offset = "0x2AC8E80", VA = "0x182ACA280", Slot = "144")]
		public override void DWOQUCJMMEP(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x2ACAA70", Offset = "0x2AC9670", VA = "0x182ACAA70", Slot = "145")]
		public override void OOMHGQQSFSQ(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9B60", Offset = "0x2AC8760", VA = "0x182AC9B60", Slot = "161")]
		internal override bool BXRUDEYLANN(TrackType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x2ACB910", Offset = "0x2ACA510", VA = "0x182ACB910", Slot = "162")]
		internal override int VTDTTBETUAR(TrackType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9BF0", Offset = "0x2AC87F0", VA = "0x182AC9BF0", Slot = "163")]
		internal override ODGOXWJTMPM CCFXRHXYIFY(TrackType a, int b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9F40", Offset = "0x2AC8B40", VA = "0x182AC9F40", Slot = "159")]
		internal override bool DAHAKAFQDNN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x2ACBE40", Offset = "0x2ACAA40", VA = "0x182ACBE40", Slot = "160")]
		internal override string ZTKQEBYLFBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9FD0", Offset = "0x2AC8BD0", VA = "0x182AC9FD0")]
		public static bool DOIUPDNRMOQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x2ACA600", Offset = "0x2AC9200", VA = "0x182ACA600")]
		public static void IKQUSAKATCC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class YZEIMJQGRVU
	{
		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public string BJJRERGSVPN
		{
			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2FC0", VA = "0x180CF43C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9880", VA = "0x180CFAC80")]
		internal YZEIMJQGRVU(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public enum TrackType
	{
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		Video,
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		Audio,
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		Text
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class ODGOXWJTMPM
	{
		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public int BHGPJQWKXUO
		{
			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0xCEE110", Offset = "0xCECD10", VA = "0x180CEE110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A40", Offset = "0xCF0640", VA = "0x180CF1A40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		private TrackType YAANGTQHKJV
		{
			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0xDDD820", Offset = "0xDDC420", VA = "0x180DDD820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		private string MZXYTBCYJEB
		{
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A10", Offset = "0xCF0610", VA = "0x180CF1A10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public string AZGBUIWNJKT
		{
			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003FB")]
			[Cpp2IlInjected.Address(RVA = "0xCF1770", Offset = "0xCF0370", VA = "0x180CF1770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public string AVSKTIEYFYG
		{
			[Cpp2IlInjected.Token(Token = "0x60003FC")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2F50", VA = "0x180CF4350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003FD")]
			[Cpp2IlInjected.Address(RVA = "0xCF1780", Offset = "0xCF0380", VA = "0x180CF1780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		private bool RZHWMJUKYYF
		{
			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0xD4F0D0", Offset = "0xD4DCD0", VA = "0x180D4F0D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x2AC5440", Offset = "0x2AC4040", VA = "0x182AC5440")]
		internal ODGOXWJTMPM(TrackType a, int b, string c, string d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x2AC5380", Offset = "0x2AC3F80", VA = "0x182AC5380")]
		protected string XUDZSQLKHND()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public abstract class PNDIVGTTIOT : IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public virtual TrackType YAANGTQHKJV
		{
			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0xCEE110", Offset = "0xCECD10", VA = "0x180CEE110", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(TrackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public abstract int LHDUJAQMHJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000401")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract IEnumerator GetEnumerator();

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(Slot = "8")]
		internal abstract void Clear();

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(Slot = "9")]
		internal abstract void Add(ODGOXWJTMPM track);

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(Slot = "10")]
		internal abstract void VRDTRZLKCYR(ODGOXWJTMPM a);

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		protected PNDIVGTTIOT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[DefaultMember("Item")]
	public class LSXZPSTZRUY<a> : PNDIVGTTIOT where a : ODGOXWJTMPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		internal List<a> OIVJUGLLDGF;

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		internal a BIZFQRRZPOZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A10", Offset = "0xCF0610", VA = "0x180CF1A10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public override int LHDUJAQMHJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x14E20F0", Offset = "0x14E0CF0", VA = "0x1814E20F0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x687AA70", Offset = "0x6879670", VA = "0x18687AA70")]
		internal LSXZPSTZRUY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x687A9B0", Offset = "0x68795B0", VA = "0x18687A9B0", Slot = "7")]
		public override IEnumerator GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x687A950", Offset = "0x6879550", VA = "0x18687A950", Slot = "8")]
		internal override void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x687A880", Offset = "0x6879480", VA = "0x18687A880", Slot = "9")]
		internal override void Add(ODGOXWJTMPM track)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x687AA10", Offset = "0x6879610", VA = "0x18687AA10", Slot = "10")]
		internal override void VRDTRZLKCYR(ODGOXWJTMPM a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class PHLBYEWSKZB : LSXZPSTZRUY<EAUIWBKSJDA>
	{
		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public override TrackType YAANGTQHKJV
		{
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "5")]
			get
			{
				return default(TrackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x2AC5550", Offset = "0x2AC4150", VA = "0x182AC5550")]
		public PHLBYEWSKZB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class RUKLNAXGXEK : LSXZPSTZRUY<CNXMNNGNQYR>
	{
		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public override TrackType YAANGTQHKJV
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0xD5B4A0", Offset = "0xD5A0A0", VA = "0x180D5B4A0", Slot = "5")]
			get
			{
				return default(TrackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x2AC5590", Offset = "0x2AC4190", VA = "0x182AC5590")]
		public RUKLNAXGXEK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class YKPFPIIYBZB : LSXZPSTZRUY<KSHLSWNEUDY>
	{
		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public override TrackType YAANGTQHKJV
		{
			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0xD5A2A0", Offset = "0xD58EA0", VA = "0x180D5A2A0", Slot = "5")]
			get
			{
				return default(TrackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x2ACC1B0", Offset = "0x2ACADB0", VA = "0x182ACC1B0")]
		public YKPFPIIYBZB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class EAUIWBKSJDA : ODGOXWJTMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x2ABB930", Offset = "0x2ABA530", VA = "0x182ABB930")]
		internal EAUIWBKSJDA(int a, string b, string c, bool d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class CNXMNNGNQYR : ODGOXWJTMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x2AB6C10", Offset = "0x2AB5810", VA = "0x182AB6C10")]
		internal CNXMNNGNQYR(int a, string b, string c, bool d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class KSHLSWNEUDY : ODGOXWJTMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x2AC01E0", Offset = "0x2ABEDE0", VA = "0x182AC01E0")]
		internal KSHLSWNEUDY(int a, string b, string c, bool d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public interface DFAYJFKHIBQ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public interface CQXJJYGCXEL
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public interface LUHLXMRMVIM
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public static class XPZGRJVDVLT
	{
		[Cpp2IlInjected.Token(Token = "0x200007A")]
		public enum Preset
		{
			[Cpp2IlInjected.Token(Token = "0x4000318")]
			Step,
			[Cpp2IlInjected.Token(Token = "0x4000319")]
			Linear,
			[Cpp2IlInjected.Token(Token = "0x400031A")]
			InQuad,
			[Cpp2IlInjected.Token(Token = "0x400031B")]
			OutQuad,
			[Cpp2IlInjected.Token(Token = "0x400031C")]
			InOutQuad,
			[Cpp2IlInjected.Token(Token = "0x400031D")]
			InCubic,
			[Cpp2IlInjected.Token(Token = "0x400031E")]
			OutCubic,
			[Cpp2IlInjected.Token(Token = "0x400031F")]
			InOutCubic,
			[Cpp2IlInjected.Token(Token = "0x4000320")]
			InQuint,
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			OutQuint,
			[Cpp2IlInjected.Token(Token = "0x4000322")]
			InOutQuint,
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			InQuart,
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			OutQuart,
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			InOutQuart,
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			InExpo,
			[Cpp2IlInjected.Token(Token = "0x4000327")]
			OutExpo,
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			InOutExpo,
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			Random,
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			RandomNotStep
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x2AC94D0", Offset = "0x2AC80D0", VA = "0x182AC94D0")]
		public static Func<float, float> PSFSBHYBZTK(Preset a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9420", Offset = "0x2AC8020", VA = "0x182AC9420")]
		public static float JUXHMMEFRAE(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x2AC93E0", Offset = "0x2AC7FE0", VA = "0x182AC93E0")]
		public static float IUYLFALVSZL(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9A40", Offset = "0x2AC8640", VA = "0x182AC9A40")]
		public static float TXFQUHSKXWM(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x2AC94B0", Offset = "0x2AC80B0", VA = "0x182AC94B0")]
		public static float OTNHODRRPZE(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
		public static float WCDODQNFJJD(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9A30", Offset = "0x2AC8630", VA = "0x182AC9A30")]
		public static float TUAZYECMEOE(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9470", Offset = "0x2AC8070", VA = "0x182AC9470")]
		public static float ORFQHDINPSD(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9200", Offset = "0x2AC7E00", VA = "0x182AC9200")]
		public static float DPHUIWGDRZE(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9AD0", Offset = "0x2AC86D0", VA = "0x182AC9AD0")]
		public static float ZJRQUNKBYWD(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9360", Offset = "0x2AC7F60", VA = "0x182AC9360")]
		public static float EVNWYECMGBY(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x2AC99B0", Offset = "0x2AC85B0", VA = "0x182AC99B0")]
		public static float QYKKUEIYCQZ(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9170", Offset = "0x2AC7D70", VA = "0x182AC9170")]
		public static float CKOTDOIPIJA(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x2AC93A0", Offset = "0x2AC7FA0", VA = "0x182AC93A0")]
		public static float GSPFTTTXVPJ(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x2AC90F0", Offset = "0x2AC7CF0", VA = "0x182AC90F0")]
		public static float BOXVWLNOHII(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9AC0", Offset = "0x2AC86C0", VA = "0x182AC9AC0")]
		public static float YEVXUTVSTWO(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9AE0", Offset = "0x2AC86E0", VA = "0x182AC9AE0")]
		public static float ZPIYXKMPBVB(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9180", Offset = "0x2AC7D80", VA = "0x182AC9180")]
		public static float CTDNDCHFKUY(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9430", Offset = "0x2AC8030", VA = "0x182AC9430")]
		public static float KOTDKRFPTRN(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9280", Offset = "0x2AC7E80", VA = "0x182AC9280")]
		public static float DUGZXLLYUFS(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x2AC92D0", Offset = "0x2AC7ED0", VA = "0x182AC92D0")]
		public static float ERPOXYLVAGN(float a)
		{
			return default(float);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public struct HttpHeader
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public string value;

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x2ABD3F0", Offset = "0x2ABBFF0", VA = "0x182ABD3F0")]
		public bool QCTNIDBILOH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x2ABD430", Offset = "0x2ABC030", VA = "0x182ABD430")]
		public string SDORFWODEHG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x2ABD320", Offset = "0x2ABBF20", VA = "0x182ABD320")]
		public static bool BXDMPUECVXA(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x2ABD4C0", Offset = "0x2ABC0C0", VA = "0x182ABD4C0")]
		private static bool XPCPBKHDUSH(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x2ABD2E0", Offset = "0x2ABBEE0", VA = "0x182ABD2E0")]
		private bool BXDMPUECVXA()
		{
			return default(bool);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[DefaultMember("Item")]
	public class HttpHeaderData : IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		[SerializeField]
		private List<HttpHeader> httpHeaders;

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x2ABD000", Offset = "0x2ABBC00", VA = "0x182ABD000", Slot = "4")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x2ABD080", Offset = "0x2ABBC80", VA = "0x182ABD080")]
		public string SDORFWODEHG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x2ABD260", Offset = "0x2ABBE60", VA = "0x182ABD260")]
		public HttpHeaderData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class KeyAuthData : ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		[SerializeField]
		public string keyServerToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		[SerializeField]
		[Multiline]
		public string overrideDecryptionKeyBase64;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private byte[] IRDZLIWKMFR;

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public byte[] overrideDecryptionKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0210", Offset = "0x2ABEE10", VA = "0x182AC0210", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public KeyAuthData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class IHWCXXBHRYX
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		private class QPWDCZLFFCY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			public RenderTexture OMHBPSFWQET;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			public long NMILKKWMFYM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			public bool VHRGMHDBWVT;

			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public QPWDCZLFFCY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000080")]
		public enum ResampleMode
		{
			[Cpp2IlInjected.Token(Token = "0x400034C")]
			POINT,
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			LINEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		private List<QPWDCZLFFCY[]> RNLJGBXEMLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		private MediaPlayer RAUVPTGAJSS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		private RenderTexture[] GOZOPIJEDMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		private int MAETKDMEKUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		private int CTUKISWFUOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private int TEWRZQUYJBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private long NSPLWGZZWDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		private float WLLOLIFCIFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		private Material YYRICLEQWYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private ResampleMode GAHTTWOJDQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private string NDGODUADIQW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private long XHJBUSFIYMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private int TYGBQSCABBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private long MXDRUVGIMAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private int QNZSYGJTRRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private long JLMVDTPCFEL;

		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private const string AEZUOHUBQYA = "_t";

		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private const string ZJBVWDPPSXN = "_AfterTex";

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private int KQXYIGYRPBR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private int HYOSBAXCYEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private float YHPAXVHOGUT;

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		private float BZCSUOZAKFS
		{
			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0x166F4A0", Offset = "0x166E0A0", VA = "0x18166F4A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		private long GPANKIHQCXL
		{
			[Cpp2IlInjected.Token(Token = "0x6000439")]
			[Cpp2IlInjected.Address(RVA = "0x2ABF7D0", Offset = "0x2ABE3D0", VA = "0x182ABF7D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public Texture[] ZXLZWRUEIDO
		{
			[Cpp2IlInjected.Token(Token = "0x600043C")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x2ABDAB0", Offset = "0x2ABC6B0", VA = "0x182ABDAB0")]
		public void DMJAIXZLEHS(MediaPlayer a, MediaPlayerEvent.EventType b, ErrorCode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x2ABFF10", Offset = "0x2ABEB10", VA = "0x182ABFF10")]
		public IHWCXXBHRYX(MediaPlayer a, string b, int c = 2, ResampleMode d = ResampleMode.LINEAR)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x2ABE080", Offset = "0x2ABCC80", VA = "0x182ABE080")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x2ABDFA0", Offset = "0x2ABCBA0", VA = "0x182ABDFA0")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x2ABD530", Offset = "0x2ABC130", VA = "0x182ABD530")]
		private void ASBJDAJPXMZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x2ABEE60", Offset = "0x2ABDA60", VA = "0x182ABEE60")]
		private void VQGLZKSSOWJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x2ABF420", Offset = "0x2ABE020", VA = "0x182ABF420")]
		private bool VTQJZNGOCWO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x2ABFA90", Offset = "0x2ABE690", VA = "0x182ABFA90")]
		private int YDOHGQQDCJN(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x2ABDBB0", Offset = "0x2ABC7B0", VA = "0x182ABDBB0")]
		private int IOYRBQAKMQX(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x2ABD780", Offset = "0x2ABC380", VA = "0x182ABD780")]
		private void BFYWRQRKWYX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x2ABFDB0", Offset = "0x2ABE9B0", VA = "0x182ABFDB0")]
		private void ZYVPZUIDVST(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x2ABF7E0", Offset = "0x2ABE3E0", VA = "0x182ABF7E0")]
		private void XKWTHUIIZZS(int a, int b, int c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x2ABDD70", Offset = "0x2ABC970", VA = "0x182ABDD70")]
		private void OFXRPFSAZLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x2ABFCB0", Offset = "0x2ABE8B0", VA = "0x182ABFCB0")]
		private void ZVXORXXXZNZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x2ABE0A0", Offset = "0x2ABCCA0", VA = "0x182ABE0A0")]
		private float TPKSGZXUCEE()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x2ABE340", Offset = "0x2ABCF40", VA = "0x182ABE340")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x2ABDB90", Offset = "0x2ABC790", VA = "0x182ABDB90")]
		public void IBELEYYZWUX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class GOFAKXDZPAQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public int PMHRBJOKSGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public string MUCUHUZHBNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public double DZDFMPJSWSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public double FKTLINMAYDQ;

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x2ABCFE0", Offset = "0x2ABBBE0", VA = "0x182ABCFE0")]
		public bool EZPOFNSHCJX(double a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public GOFAKXDZPAQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public class GMOBMTYIGGN
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x2ABCEA0", Offset = "0x2ABBAA0", VA = "0x182ABCEA0")]
		private static double QFAJPGTWNPO(string a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x2ABCAA0", Offset = "0x2ABB6A0", VA = "0x182ABCAA0")]
		public static List<GOFAKXDZPAQ> QCCDKVMIRHV(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public struct LazyShaderProperty
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private string _name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		private int _id;

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public int JQCTFOCWOYF
		{
			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x2AC02F0", Offset = "0x2ABEEF0", VA = "0x182AC02F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0320", Offset = "0x2ABEF20", VA = "0x182AC0320")]
		public LazyShaderProperty(string name)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class UJBEHFTDBMD
	{
		[Cpp2IlInjected.Token(Token = "0x2000085")]
		[Flags]
		public enum ResolveFlags
		{
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			Mipmaps = 1,
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			PackedAlpha = 2,
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			StereoLeft = 4,
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			StereoRight = 8,
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			ColorspaceSRGB = 0x10
		}

		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public static readonly LazyShaderProperty PETVDVUJESE;

		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public static readonly LazyShaderProperty TSKTPJVNVAY;

		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public static readonly LazyShaderProperty SGHQIRQLKCJ;

		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public static readonly LazyShaderProperty SAKSKCZJYME;

		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public static readonly LazyShaderProperty GYKLTCEBFRG;

		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public static readonly LazyShaderProperty KQZLWSTAQMB;

		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public static readonly LazyShaderProperty CLVJPANIZTQ;

		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public static readonly LazyShaderProperty NWWUKKGCQVJ;

		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public static readonly LazyShaderProperty OTLAJUWPHOF;

		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public static readonly LazyShaderProperty NDKDARDVGDL;

		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public static string NVHZQVVSTJD;

		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public static readonly LazyShaderProperty RVIJNTAYIVL;

		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public static readonly LazyShaderProperty OTXWNRCTVWF;

		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public static readonly LazyShaderProperty TXAMPFJANVJ;

		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public static readonly LazyShaderProperty PHZUVWQEATI;

		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public static readonly LazyShaderProperty VMLVPEBPWNL;

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x2AC76E0", Offset = "0x2AC62E0", VA = "0x182AC76E0")]
		public static Material YJYJZCXRGAZ(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x2AC6560", Offset = "0x2AC5160", VA = "0x182AC6560")]
		public static void OPAYBWTYXEK(Material a, VideoMapping b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x2AC6600", Offset = "0x2AC5200", VA = "0x182AC6600")]
		public static void PURPNVESHBK(Material a, StereoPacking b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x2AC6420", Offset = "0x2AC5020", VA = "0x182AC6420")]
		public static void NSXRSGPHGFU(Material a, AlphaPacking b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x2AC6B90", Offset = "0x2AC5790", VA = "0x182AC6B90")]
		public static void QQGLFALQAVV(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x2AC5C00", Offset = "0x2AC4800", VA = "0x182AC5C00")]
		public static void DQRHXYDFNHT(Material a, Matrix4x4 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x2AC5E60", Offset = "0x2AC4A60", VA = "0x182AC5E60")]
		public static void IKPITDBDYFP(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x2AC5D00", Offset = "0x2AC4900", VA = "0x182AC5D00")]
		public static Texture GetTexture(MediaPlayer mediaPlayer, int textureIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x2AC6C20", Offset = "0x2AC5820", VA = "0x182AC6C20")]
		public static void QWKGDTYXAWV(Material a, MediaPlayer b, int c = -1, [Optional] Texture d, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x2AC5F10", Offset = "0x2AC4B10", VA = "0x182AC5F10")]
		internal static void JENGELTYZDG(Material a, bool b, bool c, Matrix4x4 d, Texture e, Matrix4x4 f, VideoMapping g = VideoMapping.Normal, StereoPacking h = StereoPacking.None, AlphaPacking i = AlphaPacking.None)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x2AC68B0", Offset = "0x2AC54B0", VA = "0x182AC68B0")]
		public static void QFADCPQXWWG(Material a, VideoResolveOptions b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x2AC55D0", Offset = "0x2AC41D0", VA = "0x182AC55D0")]
		public static RenderTexture AEQAMFTMRQV(Material a, RenderTexture b, QOSOQPMLJWU c, ResolveFlags d, ScaleMode e = ScaleMode.StretchToFill)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x2AC7770", Offset = "0x2AC6370", VA = "0x182AC7770")]
		public static void ZPMNFTBUPVE(AlphaPacking a, StereoPacking b, StereoEye c, float d, Matrix4x4 e, int f, int g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x2AC71E0", Offset = "0x2AC5DE0", VA = "0x182AC71E0")]
		public static void XZLUGZHPCIV(Rect a, Texture b, ScaleMode c, AlphaPacking d, float e, Material f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public enum VideoRange
	{
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		SDR,
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		HLG,
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		PQ
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public enum CodecType : uint
	{
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		ac_3 = 1633889587u,
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		alac = 1634492771u,
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		avc1 = 1635148593u,
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		avc3 = 1635148595u,
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		dvh1 = 1685481521u,
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		dvhe = 1685481573u,
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		ec_3 = 1700998451u,
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		fLaC = 1716281667u,
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		hev1 = 1751479857u,
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		hvc1 = 1752589105u,
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		mjpg = 1835692135u,
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		mp4a = 1836069985u,
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		stpp = 1937010800u,
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		wvtt = 2004251764u,
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		unknown = 0u
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class XLVJELDUGXT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		private int YCQLCVOADOW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private int DBBAQBFJISJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private int URHWBACCNEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private int ANJCATNUJDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private int LYMCUIVMFXC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private CodecType ZLJXBLCVXNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private float HCLCLVBCJWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private VideoRange NVFRFMBUHXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private CodecType YEEAWOPISVS;

		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private static XLVJELDUGXT VRFPSTKSGKB;

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9070", Offset = "0x2AC7C70", VA = "0x182AC9070")]
		public XLVJELDUGXT(int a, int b, int c, int d, int e = 0, CodecType f = CodecType.unknown, float g = 0f, VideoRange h = VideoRange.SDR, CodecType i = CodecType.unknown)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[DefaultMember("Item")]
	public interface JAFDMGAXOYN : IEnumerable
	{
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
