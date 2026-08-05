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
	public Material HSIUGFJSEDV
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD11C10", Offset = "0xD10610", VA = "0x180D11C10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2AD7FA0", Offset = "0x2AD69A0", VA = "0x182AD7FA0")]
	private void OnWillRenderObject()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xD11140", Offset = "0xD0FB40", VA = "0x180D11140")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xD11BB0", Offset = "0xD105B0", VA = "0x180D11BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public MediaPath MediaPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xD11C10", Offset = "0xD10610", VA = "0x180D11C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public MediaHints Hints
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xEE3340", Offset = "0xEE1D40", VA = "0x180EE3340")]
			get
			{
				return default(MediaHints);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xEE3490", Offset = "0xEE1E90", VA = "0x180EE3490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2AE6700", Offset = "0x2AE5100", VA = "0x182AE6700")]
		public MediaReference GetCurrentPlatformMediaReference()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2AE6770", Offset = "0x2AE5170", VA = "0x182AE6770")]
		public MediaReference GetPlatformMediaReference(Platform platform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2AE6800", Offset = "0x2AE5200", VA = "0x182AE6800")]
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
		private GameObject SYZRKWJHOAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool GRNSKMVIMJV;

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
		private Texture LOAEBKFDZRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private LazyShaderProperty NQCWNJSHQKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private LazyShaderProperty WWEACAICYQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private Texture JRYIINPIUBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Vector2 SDETTGPQFEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Vector2 DEQHVZYEDXJ;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Color KOSWWIZWQUO
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x16B0DC0", Offset = "0x16AF7C0", VA = "0x1816B0DC0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x2AD9DD0", Offset = "0x2AD87D0", VA = "0x182AD9DD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Texture DIFIWBLKGPT
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xD159A0", Offset = "0xD143A0", VA = "0x180D159A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2ADA020", Offset = "0x2AD8A20", VA = "0x182ADA020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Texture OYXPYFLOIIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xD141D0", Offset = "0xD12BD0", VA = "0x180D141D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2AD9AC0", Offset = "0x2AD84C0", VA = "0x182AD9AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float CSEWHEQPEOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x12EC700", Offset = "0x12EB100", VA = "0x1812EC700")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2AD9940", Offset = "0x2AD8340", VA = "0x182AD9940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Camera CSJMWMCKLDT
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xD14490", Offset = "0xD12E90", VA = "0x180D14490")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2AD99F0", Offset = "0x2AD83F0", VA = "0x182AD99F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public VideoAspectRatio TQXSSZCVXCY
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xE3D3A0", Offset = "0xE3BDA0", VA = "0x180E3D3A0")]
			get
			{
				return default(VideoAspectRatio);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x2ADA0E0", Offset = "0x2AD8AE0", VA = "0x182ADA0E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Vector2 JQSIIEQDKQL
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x12EC710", Offset = "0x12EB110", VA = "0x1812EC710")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2AD9CF0", Offset = "0x2AD86F0", VA = "0x182AD9CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Vector2 SOPHBXPLMUC
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x12E7120", Offset = "0x12E5B20", VA = "0x1812E7120")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2AD9B80", Offset = "0x2AD8580", VA = "0x182AD9B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Texture2D WJJWIGCEUJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xD40870", Offset = "0xD3F270", VA = "0x180D40870")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x2AD9C60", Offset = "0x2AD8660", VA = "0x182AD9C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public string YGJSOLHPSIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xDE9810", Offset = "0xDE8210", VA = "0x180DE9810")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2AD9F30", Offset = "0x2AD8930", VA = "0x182AD9F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Vector2 UGICJWZXTTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2AD9900", Offset = "0x2AD8300", VA = "0x182AD9900")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2AD9E90", Offset = "0x2AD8890", VA = "0x182AD9E90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Vector2 OHFXQNDZZMY
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2AD9920", Offset = "0x2AD8320", VA = "0x182AD9920")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x2AD9EE0", Offset = "0x2AD88E0", VA = "0x182AD9EE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private Vector2 SRQMLYXTPDQ
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x2AD8540", Offset = "0x2AD6F40", VA = "0x182AD8540")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2AD7EB0", Offset = "0x2AD68B0", VA = "0x182AD7EB0")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2AD8B30", Offset = "0x2AD7530", VA = "0x182AD8B30", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2AD8AE0", Offset = "0x2AD74E0", VA = "0x182AD8AE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2AD9380", Offset = "0x2AD7D80", VA = "0x182AD9380")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2AD81B0", Offset = "0x2AD6BB0", VA = "0x182AD81B0")]
		public Mesh CreateQuadMesh()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2AD8050", Offset = "0x2AD6A50", VA = "0x182AD8050")]
		public void CreateMaterial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2AD8C10", Offset = "0x2AD7610", VA = "0x182AD8C10", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xD72420", Offset = "0xD70E20", VA = "0x180D72420")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2AD90C0", Offset = "0x2AD7AC0", VA = "0x182AD90C0")]
		public void UpdateMaterialProperties(int target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2AD7980", Offset = "0x2AD6380", VA = "0x182AD7980", Slot = "8")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2AD8610", Offset = "0x2AD7010", VA = "0x182AD8610")]
		private void NAWEKPGYYLK(Texture a, bool b, int c = 0, Eye d = Eye.Left)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2AD9540", Offset = "0x2AD7F40", VA = "0x182AD9540", Slot = "6")]
		protected override void XQQGRCIFIBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2AD8F20", Offset = "0x2AD7920", VA = "0x182AD8F20", Slot = "7")]
		protected override void RYOEICSROYR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2AD9780", Offset = "0x2AD8180", VA = "0x182AD9780")]
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
		private Texture LOAEBKFDZRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private LazyShaderProperty NQCWNJSHQKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private LazyShaderProperty WWEACAICYQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private Texture JRYIINPIUBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private Vector2 SDETTGPQFEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private Vector2 DEQHVZYEDXJ;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Texture2D WJJWIGCEUJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xD161A0", Offset = "0xD14BA0", VA = "0x180D161A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x2ADAFE0", Offset = "0x2AD99E0", VA = "0x182ADAFE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Material HSIUGFJSEDV
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xD161C0", Offset = "0xD14BC0", VA = "0x180D161C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x2ADB060", Offset = "0x2AD9A60", VA = "0x182ADB060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string YGJSOLHPSIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xD159A0", Offset = "0xD143A0", VA = "0x180D159A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x2ADB180", Offset = "0x2AD9B80", VA = "0x182ADB180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector2 UGICJWZXTTX
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x2ADAFA0", Offset = "0x2AD99A0", VA = "0x182ADAFA0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x2ADB0E0", Offset = "0x2AD9AE0", VA = "0x182ADB0E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Vector2 OHFXQNDZZMY
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x2ADAFC0", Offset = "0x2AD99C0", VA = "0x182ADAFC0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x2ADB130", Offset = "0x2AD9B30", VA = "0x182ADB130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xD72420", Offset = "0xD70E20", VA = "0x180D72420")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2ADA190", Offset = "0x2AD8B90", VA = "0x182ADA190", Slot = "8")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2ADA6C0", Offset = "0x2AD90C0", VA = "0x182ADA6C0")]
		private void NAWEKPGYYLK(Texture a, bool b, int c = 0, Eye d = Eye.Left)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2ADAC40", Offset = "0x2AD9640", VA = "0x182ADAC40", Slot = "6")]
		protected override void XQQGRCIFIBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2ADAAD0", Offset = "0x2AD94D0", VA = "0x182ADAAD0", Slot = "7")]
		protected override void RYOEICSROYR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2ADAE40", Offset = "0x2AD9840", VA = "0x182ADAE40")]
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
		private Texture LOAEBKFDZRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private LazyShaderProperty NQCWNJSHQKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private LazyShaderProperty WWEACAICYQY;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Texture2D WJJWIGCEUJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xD161A0", Offset = "0xD14BA0", VA = "0x180D161A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x2ADB7D0", Offset = "0x2ADA1D0", VA = "0x182ADB7D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Renderer VKOWHGLAJDW
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xD161C0", Offset = "0xD14BC0", VA = "0x180D161C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x2ADBE90", Offset = "0x2ADA890", VA = "0x182ADBE90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public int ETOGYCMVXWJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xD88F60", Offset = "0xD87960", VA = "0x180D88F60")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xD8A750", Offset = "0xD89150", VA = "0x180D8A750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public string YGJSOLHPSIH
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xD141D0", Offset = "0xD12BD0", VA = "0x180D141D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x2ADC160", Offset = "0x2ADAB60", VA = "0x182ADC160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector2 UGICJWZXTTX
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x2ADAFC0", Offset = "0x2AD99C0", VA = "0x182ADAFC0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x2ADB130", Offset = "0x2AD9B30", VA = "0x182ADB130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector2 OHFXQNDZZMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x2ADC0F0", Offset = "0x2ADAAF0", VA = "0x182ADC0F0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x2ADC110", Offset = "0x2ADAB10", VA = "0x182ADC110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2ADB7D0", Offset = "0x2ADA1D0", VA = "0x182ADB7D0")]
		private void ILXTQIGLQKK(Texture2D a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2ADBE90", Offset = "0x2ADA890", VA = "0x182ADBE90")]
		private void VXTCVIYAMUB(Renderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xD72420", Offset = "0xD70E20", VA = "0x180D72420")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2ADB250", Offset = "0x2AD9C50", VA = "0x182ADB250", Slot = "8")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2ADB880", Offset = "0x2ADA280", VA = "0x182ADB880")]
		private void NAWEKPGYYLK(Texture a, bool b, int c, Eye d = Eye.Left, int e = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2ADBD50", Offset = "0x2ADA750", VA = "0x182ADBD50", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2ADBD20", Offset = "0x2ADA720", VA = "0x182ADBD20", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2ADBF70", Offset = "0x2ADA970", VA = "0x182ADBF70", Slot = "6")]
		protected override void XQQGRCIFIBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2ADC010", Offset = "0x2ADAA10", VA = "0x182ADC010")]
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
		private const int TNTYYTFFJZS = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[Range(0f, 1f)]
		[SerializeField]
		private float[] _channels;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float[] URPDWDYKLNL
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xD11C10", Offset = "0xD10610", VA = "0x180D11C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2ADC3F0", Offset = "0x2ADADF0", VA = "0x182ADC3F0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2ADC480", Offset = "0x2ADAE80", VA = "0x182ADC480")]
		private void YAKKPUNKSFC(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2ADC240", Offset = "0x2ADAC40", VA = "0x182ADC240")]
		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xD11140", Offset = "0xD0FB40", VA = "0x180D11140")]
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
		private int AIABJNHBFBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private AudioSource FMVRGCSQIJA;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public MediaPlayer STWIIHPYAQH
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2ADD040", Offset = "0x2ADBA40", VA = "0x182ADD040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public AudioOutputMode KGJKESQOLOY
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xD1B440", Offset = "0xD19E40", VA = "0x180D1B440")]
			get
			{
				return default(AudioOutputMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xD1BA20", Offset = "0xD1A420", VA = "0x180D1BA20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int AUNWNZFRRHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xE2D170", Offset = "0xE2BB70", VA = "0x180E2D170")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x1E28BB0", Offset = "0x1E275B0", VA = "0x181E28BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2ADC580", Offset = "0x2ADAF80", VA = "0x182ADC580")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2ADCEC0", Offset = "0x2ADB8C0", VA = "0x182ADCEC0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2ADC5D0", Offset = "0x2ADAFD0", VA = "0x182ADC5D0")]
		private void CGAJIKQBCMJ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2ADCE10", Offset = "0x2ADB810", VA = "0x182ADCE10")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2ADCF40", Offset = "0x2ADB940", VA = "0x182ADCF40")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xD161A0", Offset = "0xD14BA0", VA = "0x180D161A0")]
		public AudioSource GetAudioSource()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2ADCE20", Offset = "0x2ADB820", VA = "0x182ADCE20")]
		public void SetAudioSource(AudioSource source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2ADC6B0", Offset = "0x2ADB0B0", VA = "0x182ADC6B0")]
		public void ChangeMediaPlayer(MediaPlayer newPlayer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2ADCD30", Offset = "0x2ADB730", VA = "0x182ADCD30")]
		private void LTKNAZTPBMY(MediaPlayer a, MediaPlayerEvent.EventType b, ErrorCode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2ADCB70", Offset = "0x2ADB570", VA = "0x182ADCB70")]
		private static void KETARKRNCKZ(MediaPlayer a, AudioSource b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2ADCD90", Offset = "0x2ADB790", VA = "0x182ADCD90")]
		private void OnAudioFilterRead(float[] audioData, int channelCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2ADD020", Offset = "0x2ADBA20", VA = "0x182ADD020")]
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
		private static Shader PNXROENTUGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private Material NYFNIXNQLWC;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public MediaPlayer STWIIHPYAQH
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x2ADDF90", Offset = "0x2ADC990", VA = "0x182ADDF90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public ScaleMode YDOLHPJHMFV
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xD1B440", Offset = "0xD19E40", VA = "0x180D1B440")]
			get
			{
				return default(ScaleMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xD1BA20", Offset = "0xD1A420", VA = "0x180D1BA20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Color SBTEGNBQFBT
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2ADDF60", Offset = "0x2ADC960", VA = "0x182ADDF60")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x2ADDF80", Offset = "0x2ADC980", VA = "0x182ADDF80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool ENQOJNUJEYF
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xF30C30", Offset = "0xF2F630", VA = "0x180F30C30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xFFCEF0", Offset = "0xFFB8F0", VA = "0x180FFCEF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool VRQENZXFXPU
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xFFC8F0", Offset = "0xFFB2F0", VA = "0x180FFC8F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xFFD2E0", Offset = "0xFFBCE0", VA = "0x180FFD2E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public int FWBRRLNLPFB
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xD2ED40", Offset = "0xD2D740", VA = "0x180D2ED40")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xD83C20", Offset = "0xD82620", VA = "0x180D83C20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool RPIWSLRMLFA
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x19EF3C0", Offset = "0x19EDDC0", VA = "0x1819EF3C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x19EF5F0", Offset = "0x19EDFF0", VA = "0x1819EF5F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float OITBBIDWJDX
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x1252B50", Offset = "0x1251550", VA = "0x181252B50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2ADDF70", Offset = "0x2ADC970", VA = "0x182ADDF70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public float OINUEBJYZSO
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xF51780", Offset = "0xF50180", VA = "0x180F51780")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xF51790", Offset = "0xF50190", VA = "0x180F51790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float DAVFLHNQXOV
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xD622C0", Offset = "0xD60CC0", VA = "0x180D622C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x109C7D0", Offset = "0x109B1D0", VA = "0x18109C7D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float FOYAXNKEFVO
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x10C1360", Offset = "0x10BFD60", VA = "0x1810C1360")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x10C1380", Offset = "0x10BFD80", VA = "0x1810C1380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool PAARQWPFDFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xE211E0", Offset = "0xE1FBE0", VA = "0x180E211E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xE21440", Offset = "0xE1FE40", VA = "0x180E21440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2ADDC00", Offset = "0x2ADC600", VA = "0x182ADDC00")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2ADDD40", Offset = "0x2ADC740", VA = "0x182ADDD40")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2ADD480", Offset = "0x2ADBE80", VA = "0x182ADD480")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2ADDBC0", Offset = "0x2ADC5C0", VA = "0x182ADDBC0")]
		private Shader PJTUNCUKUTA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2ADD2E0", Offset = "0x2ADBCE0", VA = "0x182ADD2E0")]
		private void IULAXANKSLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2ADD520", Offset = "0x2ADBF20", VA = "0x182ADD520")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2ADD1B0", Offset = "0x2ADBBB0", VA = "0x182ADD1B0")]
		public Rect GetAreaRect()
		{
			return default(Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2ADDF30", Offset = "0x2ADC930", VA = "0x182ADDF30")]
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
			[Cpp2IlInjected.Address(RVA = "0x2AE6C00", Offset = "0x2AE5600", VA = "0x182AE6C00", Slot = "4")]
			public virtual string GYGGABCAGEZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xFBAA00", Offset = "0xFB9400", VA = "0x180FBAA00", Slot = "5")]
			public virtual byte[] UQTBSEFOCIK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "6")]
			public virtual bool YCQWOMRDRQH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x2AE6C20", Offset = "0x2AE5620", VA = "0x182AE6C20")]
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
			public AYALZJQMPQX.VideoApi videoApi;

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
			public AYALZJQMPQX.AudioOutput _audioMode;

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
			[Cpp2IlInjected.Address(RVA = "0xDB5E60", Offset = "0xDB4860", VA = "0x180DB5E60", Slot = "6")]
			public override bool YCQWOMRDRQH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "7")]
			private void SLBJAUDSLEI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x2AE6B10", Offset = "0x2AE5510", VA = "0x182AE6B10", Slot = "8")]
			private void KUVQDBUBXEY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x2AE6B40", Offset = "0x2AE5540", VA = "0x182AE6B40")]
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
			public WXUKQSPHMYV.VideoApi videoApi;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public WXUKQSPHMYV.AudioOutput _audioMode;

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
			[Cpp2IlInjected.Address(RVA = "0xF59E30", Offset = "0xF58830", VA = "0x180F59E30", Slot = "6")]
			public override bool YCQWOMRDRQH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x2AE6AF0", Offset = "0x2AE54F0", VA = "0x182AE6AF0")]
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
			private readonly TextureFormat VTDGUMDXOMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			private readonly Flags LXNJVKFXDTI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public TextureFormat textureFormat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private AudioMode RRJWPVNQBDR;

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
			private ChangeFlags IRZAULLUUYJ;

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
				[Cpp2IlInjected.Address(RVA = "0x2AE6A40", Offset = "0x2AE5440", VA = "0x182AE6A40")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000065")]
			public Flags flags
			{
				[Cpp2IlInjected.Token(Token = "0x6000145")]
				[Cpp2IlInjected.Address(RVA = "0x2AE6A60", Offset = "0x2AE5460", VA = "0x182AE6A60")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x2AE6990", Offset = "0x2AE5390", VA = "0x182AE6990")]
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
			private ChangeFlags IRZAULLUUYJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public VideoOutputMode videoOutputMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			private readonly TextureFormat VTDGUMDXOMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public TextureFormat textureFormat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			[SerializeField]
			private bool _generateMipmaps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			private AudioMode RRJWPVNQBDR;

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
				[Cpp2IlInjected.Address(RVA = "0xD40BE0", Offset = "0xD3F5E0", VA = "0x180D40BE0")]
				get
				{
					return default(AudioMode);
				}
				[Cpp2IlInjected.Token(Token = "0x6000148")]
				[Cpp2IlInjected.Address(RVA = "0x2AE6970", Offset = "0x2AE5370", VA = "0x182AE6970")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xD22D10", Offset = "0xD21710", VA = "0x180D22D10", Slot = "6")]
			public override bool YCQWOMRDRQH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "7")]
			private void SLBJAUDSLEI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x2AE68C0", Offset = "0x2AE52C0", VA = "0x182AE68C0", Slot = "8")]
			private void KUVQDBUBXEY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x2AE68F0", Offset = "0x2AE52F0", VA = "0x182AE68F0")]
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
			private ChangeFlags IRZAULLUUYJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private readonly TextureFormat VTDGUMDXOMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public TextureFormat textureFormat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			[SerializeField]
			private bool _generateMipmapsOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			private AudioMode RRJWPVNQBDR;

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
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "7")]
			private void SLBJAUDSLEI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "8")]
			private void KUVQDBUBXEY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x2AE6A90", Offset = "0x2AE5490", VA = "0x182AE6A90")]
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
			private ChangeFlags IRZAULLUUYJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public ZEOCAKAMOUD.ExternalLibrary externalLibrary;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public bool useTextureMips;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			private AudioMode RRJWPVNQBDR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			[SerializeField]
			private AudioMode _audioMode;

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "4")]
			public override string GYGGABCAGEZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "5")]
			public override byte[] UQTBSEFOCIK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x2AE6AE0", Offset = "0x2AE54E0", VA = "0x182AE6AE0")]
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
		private sealed class KCEPGNTASHE : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			private int EQRCVSNPEJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			private object RIDNXCOLQWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public Texture2D DNQJNRFFLRB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public MediaPlayer TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public double YJVSYDYOBSM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public int ZZCCMCJASRI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public bool AZCDIXPVQOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public ProcessExtractedFrame QPTYZMPRDZD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			private Texture2D GAZONROVYYG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			private int QMIEEJTAPMX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			private int PBQXBJPSGOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			private int NEVRYWAZGNE;

			[Cpp2IlInjected.Token(Token = "0x17000067")]
			private object RUKYTXHYLRZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000156")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			private object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x6000158")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0xD1D960", Offset = "0xD1C360", VA = "0x180D1D960")]
			[DebuggerHidden]
			public KCEPGNTASHE(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
			[DebuggerHidden]
			private void GWJQUAHXPBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x2ADF3B0", Offset = "0x2ADDDB0", VA = "0x182ADF3B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x2ADF370", Offset = "0x2ADDD70", VA = "0x182ADF370", Slot = "8")]
			[DebuggerHidden]
			private void JNSYTSSCILY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class CYMEJHEKSIG : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private int EQRCVSNPEJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private object RIDNXCOLQWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public MediaPlayer TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			private YieldInstruction XZQXZPCQCIK;

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			private object RUKYTXHYLRZ
			{
				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			private object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x600015E")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xD1D960", Offset = "0xD1C360", VA = "0x180D1D960")]
			[DebuggerHidden]
			public CYMEJHEKSIG(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
			[DebuggerHidden]
			private void GWJQUAHXPBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x2ADD090", Offset = "0x2ADBA90", VA = "0x182ADD090", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x2ADD050", Offset = "0x2ADBA50", VA = "0x182ADD050", Slot = "8")]
			[DebuggerHidden]
			private void JNSYTSSCILY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class WPAUHGNAIOO : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private int EQRCVSNPEJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private object RIDNXCOLQWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			public string HYBMTBYHLDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			public MediaPlayer TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public MediaPath FSIXLMZNRPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private UnityWebRequest BFWQPXVFCLG;

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			private object RUKYTXHYLRZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000162")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			private object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x6000164")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0xD1D960", Offset = "0xD1C360", VA = "0x180D1D960")]
			[DebuggerHidden]
			public WPAUHGNAIOO(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
			[DebuggerHidden]
			private void GWJQUAHXPBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x2AEC6F0", Offset = "0x2AEB0F0", VA = "0x182AEC6F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x2AEC6B0", Offset = "0x2AEB0B0", VA = "0x182AEC6B0", Slot = "8")]
			[DebuggerHidden]
			private void JNSYTSSCILY()
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
		private AudioSource FMVRGCSQIJA;

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
		private VSYGPHPSPCB.ResampleMode _resampleMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[FormerlySerializedAs("m_ResampleBufferSize")]
		[Range(3f, 10f)]
		[SerializeField]
		private int _resampleBufferSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private VSYGPHPSPCB QFKVHZRGYHY;

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
		protected SGKZHKMTMPS YHDGPQDGXYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private MZIHFSZZUIM ELNIOHVPAAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private KWNWISOSPDU DJARAYGIPLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private DSWBBQVJKJN BUNPVBQBOTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private WDUADRJVOGG QDCLRJBTAXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private SPMAFESFOFS WGGIUTONRDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private FTTZRJBXRLN FIVSRHFOHBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TOCQJIPOLBK UKCDGOYNHOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private KAALOWHGEPD BHEMZKYHQUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private CLHKFWMZKSW TECASAXEYYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private LXLOHRXFROH EZHNHZUOXNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private IDisposable PHALZNYLITB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private bool GMPVUXCUCYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x141")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private bool VDYSMEZTFBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x142")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private bool MRMQTESOZCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private Coroutine YXODTNUCKLT;

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private static bool QJWZPUHOUWE;

		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private static bool VLCZLBFQVLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private MediaPath XSKRTPNDCLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private Coroutine UUTQOGCSLQI;

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static Camera PIKUUEYCHGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private bool OXOPAZUVWBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x161")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private bool HCSRRJHAJVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x162")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private bool NIKHWITIWDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x163")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private bool OOKQUYLADLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private bool IALFKWDGEPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x165")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private bool AZRSQIORPXC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x166")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private bool CDEHXJLGRYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x167")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private bool ZALAWOTLECJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private int UQCZVDDEROW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private int NKKQFBYIZLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private int WTGXGVQGTRQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private bool GFRJTALZSEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x175")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private bool OOYPZPBFQEJ;

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
		public MediaSource QEUFCNGMZOT
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xD224F0", Offset = "0xD20EF0", VA = "0x180D224F0")]
			get
			{
				return default(MediaSource);
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xD67210", Offset = "0xD65C10", VA = "0x180D67210")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public MediaReference HESSJDKBENR
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xD11C00", Offset = "0xD10600", VA = "0x180D11C00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xD12070", Offset = "0xD10A70", VA = "0x180D12070")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MediaPath PBMRSQSPEXH
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xD12080", Offset = "0xD10A80", VA = "0x180D12080")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xD11BA0", Offset = "0xD105A0", VA = "0x180D11BA0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public MediaHints WIMIJOLVZHE
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x1BA5410", Offset = "0x1BA3E10", VA = "0x181BA5410")]
			get
			{
				return default(MediaHints);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x1AB9FF0", Offset = "0x1AB89F0", VA = "0x181AB9FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool FLDAACSGPGV
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x19EF3C0", Offset = "0x19EDDC0", VA = "0x1819EF3C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x19EF5F0", Offset = "0x19EDFF0", VA = "0x1819EF5F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool KKJCJAKSDLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x279CFC0", Offset = "0x279B9C0", VA = "0x18279CFC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x279D140", Offset = "0x279BB40", VA = "0x18279D140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool CEUAYDBCRFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x2AE5E70", Offset = "0x2AE4870", VA = "0x182AE5E70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x2AE63A0", Offset = "0x2AE4DA0", VA = "0x182AE63A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public virtual float LZWDWUFFYVA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x2AE5D20", Offset = "0x2AE4720", VA = "0x182AE5D20", Slot = "6")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x2AE6320", Offset = "0x2AE4D20", VA = "0x182AE6320", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float ENZISEYLRWU
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x2AE5C60", Offset = "0x2AE4660", VA = "0x182AE5C60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x2AE6230", Offset = "0x2AE4C30", VA = "0x182AE6230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public virtual bool ACDVZEIFBWH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x2AE5CC0", Offset = "0x2AE46C0", VA = "0x182AE5CC0", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x2AE62B0", Offset = "0x2AE4CB0", VA = "0x182AE62B0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public AudioSource HVOLIZPJGNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xD14480", Offset = "0xD12E80", VA = "0x180D14480")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xD141C0", Offset = "0xD12BC0", VA = "0x180D141C0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float KZKDAMZPEWN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2AE5F00", Offset = "0x2AE4900", VA = "0x182AE5F00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x2AE6440", Offset = "0x2AE4E40", VA = "0x182AE6440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool PJXPVFSGFIY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xD15980", Offset = "0xD14380", VA = "0x180D15980")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xD15A00", Offset = "0xD14400", VA = "0x180D15A00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public VSYGPHPSPCB.ResampleMode CIIJIZZACJU
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xE3D3A0", Offset = "0xE3BDA0", VA = "0x180E3D3A0")]
			get
			{
				return default(VSYGPHPSPCB.ResampleMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xF39D20", Offset = "0xF38720", VA = "0x180F39D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public int OIRXTNSWQFU
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xEF3330", Offset = "0xEF1D30", VA = "0x180EF3330")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x2AE64B0", Offset = "0x2AE4EB0", VA = "0x182AE64B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public VSYGPHPSPCB RGIBBQVFXPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xD14190", Offset = "0xD12B90", VA = "0x180D14190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public VideoMapping PEWKYLQGRKD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xD38350", Offset = "0xD36D50", VA = "0x180D38350")]
			get
			{
				return default(VideoMapping);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x164C0A0", Offset = "0x164AAA0", VA = "0x18164C0A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public FilterMode DZTVPZYQBCU
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x2AE6050", Offset = "0x2AE4A50", VA = "0x182AE6050")]
			get
			{
				return default(FilterMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x2AE6530", Offset = "0x2AE4F30", VA = "0x182AE6530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public TextureWrapMode OZQOSWVVZXE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x2AE6140", Offset = "0x2AE4B40", VA = "0x182AE6140")]
			get
			{
				return default(TextureWrapMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x2AE65B0", Offset = "0x2AE4FB0", VA = "0x182AE65B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public int RVACCWIXAKH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x2AE5F60", Offset = "0x2AE4960", VA = "0x182AE5F60")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x2AE64C0", Offset = "0x2AE4EC0", VA = "0x182AE64C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool WQUIXXZQTMG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xFCEFE0", Offset = "0xFCD9E0", VA = "0x180FCEFE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xFCEB70", Offset = "0xFCD570", VA = "0x180FCEB70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public MediaPath BETQXYVRIJH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xD40870", Offset = "0xD3F270", VA = "0x180D40870")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xFCEB50", Offset = "0xFCD550", VA = "0x180FCEB50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public Transform FGDEKTOCYQC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xD1DCA0", Offset = "0xD1C6A0", VA = "0x180D1DCA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xD1E3A0", Offset = "0xD1CDA0", VA = "0x180D1E3A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool KGEEAIJBWLD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xE0D1E0", Offset = "0xE0BBE0", VA = "0x180E0D1E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x1104A20", Offset = "0x1103420", VA = "0x181104A20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public Transform GJLMFFOOKIU
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xD20440", Offset = "0xD1EE40", VA = "0x180D20440")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xD20450", Offset = "0xD1EE50", VA = "0x180D20450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public float QVXDMTPUJMZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x10FBB70", Offset = "0x10FA570", VA = "0x1810FBB70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x10FB860", Offset = "0x10FA260", VA = "0x1810FB860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public float ACGVUGJZMGH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x10FAFF0", Offset = "0x10F99F0", VA = "0x1810FAFF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x10FBC10", Offset = "0x10FA610", VA = "0x1810FBC10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public HttpHeaderData HFDYJFZQLBG
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0xF20B40", Offset = "0xF1F540", VA = "0x180F20B40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x174C250", Offset = "0x174AC50", VA = "0x18174C250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public KeyAuthData ENDRNOVVYMP
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xF05280", Offset = "0xF03C80", VA = "0x180F05280")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xF05290", Offset = "0xF03C90", VA = "0x180F05290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public MediaPlayerEvent USEWHVWKZZN
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x2AE5D80", Offset = "0x2AE4780", VA = "0x182AE5D80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public int MKKTXBGXNKS
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x10FA780", Offset = "0x10F9180", VA = "0x1810FA780")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x10FB800", Offset = "0x10FA200", VA = "0x1810FB800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public bool ZIXROAFWDUS
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x2AE5ED0", Offset = "0x2AE48D0", VA = "0x182AE5ED0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x2AE6410", Offset = "0x2AE4E10", VA = "0x182AE6410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool AWMHSBWJQRF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x2AE5EF0", Offset = "0x2AE48F0", VA = "0x182AE5EF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x2AE6430", Offset = "0x2AE4E30", VA = "0x182AE6430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool TOFTKMHFDPR
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x2AE5EE0", Offset = "0x2AE48E0", VA = "0x182AE5EE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x2AE6420", Offset = "0x2AE4E20", VA = "0x182AE6420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public FileFormat HTDDHHSWPPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0xE0D150", Offset = "0xE0BB50", VA = "0x180E0D150")]
			get
			{
				return default(FileFormat);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x19D0E00", Offset = "0x19CF800", VA = "0x1819D0E00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public virtual DSWBBQVJKJN MUHKFDBASHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xE90C20", Offset = "0xE8F620", VA = "0x180E90C20", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public virtual MZIHFSZZUIM HYOUNAHWHRN
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xF86CD0", Offset = "0xF856D0", VA = "0x180F86CD0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public virtual WDUADRJVOGG STWIIHPYAQH
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xF1A680", Offset = "0xF19080", VA = "0x180F1A680", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public virtual KWNWISOSPDU KYAIZMMVAPV
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xF86CE0", Offset = "0xF856E0", VA = "0x180F86CE0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual SPMAFESFOFS WDWORZWOUQL
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xF86CA0", Offset = "0xF856A0", VA = "0x180F86CA0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public virtual TOCQJIPOLBK XFMFYUDHHWV
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xF86C80", Offset = "0xF85680", VA = "0x180F86C80", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual KAALOWHGEPD XVGEKFWEEWY
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xD8BD50", Offset = "0xD8A750", VA = "0x180D8BD50", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual CLHKFWMZKSW VUOJTIHPQXX
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xD8BD40", Offset = "0xD8A740", VA = "0x180D8BD40", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual LXLOHRXFROH PSAHVPDOEQE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xD8BBA0", Offset = "0xD8A5A0", VA = "0x180D8BBA0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public virtual FTTZRJBXRLN VUCMBBLGURC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xEAAED0", Offset = "0xEA98D0", VA = "0x180EAAED0", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool OLHQGBHMVUD
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x16C2350", Offset = "0x16C0D50", VA = "0x1816C2350")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public OptionsWindows CKWSIYUCFTA
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0xDD8020", Offset = "0xDD6A20", VA = "0x180DD8020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public OptionsApple YIUMZAQECKX
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xF86B50", Offset = "0xF85550", VA = "0x180F86B50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public OptionsApple MDTESORVUVF
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0xF86B40", Offset = "0xF85540", VA = "0x180F86B40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public OptionsApple SVBXHYFFQYS
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0xF86B90", Offset = "0xF85590", VA = "0x180F86B90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public OptionsApple BSTBTORWKOM
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0xF86B60", Offset = "0xF85560", VA = "0x180F86B60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public OptionsAndroid HXFUKWAKFPK
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0xE5A680", Offset = "0xE59080", VA = "0x180E5A680")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public OptionsOpenHarmony VJRDTOOUIEV
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0xF86D90", Offset = "0xF85790", VA = "0x180F86D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public OptionsWindowsUWP GRVFSDGWKFY
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0xF86DD0", Offset = "0xF857D0", VA = "0x180F86DD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public OptionsWebGL NVSOPHPSBVM
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xF86DC0", Offset = "0xF857C0", VA = "0x180F86DC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xD67210", Offset = "0xD65C10", VA = "0x180D67210")]
		public void SetMediaSource(MediaSource source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xD12070", Offset = "0xD10A70", VA = "0x180D12070")]
		public void SetMediaReference(MediaReference media)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xD11BA0", Offset = "0xD105A0", VA = "0x180D11BA0")]
		public void SetMediaPath(MediaPath path)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xD141C0", Offset = "0xD12BC0", VA = "0x180D141C0")]
		public void SetAudioSource(AudioSource audioSource)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2ADFF60", Offset = "0x2ADE960", VA = "0x182ADFF60")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2AE1E40", Offset = "0x2AE0840", VA = "0x182AE1E40")]
		protected void JBUZKLYHHZT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2AE4E10", Offset = "0x2AE3810", VA = "0x182AE4E10")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2AE3620", Offset = "0x2AE2020", VA = "0x182AE3620")]
		public bool OpenMedia(MediaPath path, bool autoPlay = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2AE3520", Offset = "0x2AE1F20", VA = "0x182AE3520")]
		public bool OpenMedia(MediaPathType pathType, string path, bool autoPlay = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2AE35D0", Offset = "0x2AE1FD0", VA = "0x182AE35D0")]
		public bool OpenMedia(MediaReference mediaReference, bool autoPlay = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2AE35A0", Offset = "0x2AE1FA0", VA = "0x182AE35A0")]
		public bool OpenMedia(bool autoPlay = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2AE0AB0", Offset = "0x2ADF4B0", VA = "0x182AE0AB0")]
		private bool EUBQVNBVMLL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2AE2CF0", Offset = "0x2AE16F0", VA = "0x182AE2CF0")]
		private void OAMUNEXHFGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2AE27E0", Offset = "0x2AE11E0", VA = "0x182AE27E0")]
		private void LIMXVUHPFNZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2AE04C0", Offset = "0x2ADEEC0", VA = "0x182AE04C0")]
		public void CloseMedia()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2AE3F70", Offset = "0x2AE2970", VA = "0x182AE3F70", Slot = "20")]
		public virtual void Play()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2AE3EF0", Offset = "0x2AE28F0", VA = "0x182AE3EF0", Slot = "21")]
		public virtual void Pause()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2AE4F20", Offset = "0x2AE3920", VA = "0x182AE4F20")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2AE4100", Offset = "0x2AE2B00", VA = "0x182AE4100")]
		public void Rewind(bool pause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2AE4C40", Offset = "0x2AE3640", VA = "0x182AE4C40")]
		public void SeekToLiveTime(double offset = 0.0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2AE5180", Offset = "0x2AE3B80", VA = "0x182AE5180", Slot = "22")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2AE2910", Offset = "0x2AE1310", VA = "0x182AE2910")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2AE4000", Offset = "0x2AE2A00", VA = "0x182AE4000")]
		private void RTZFCLTONKS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2AE33E0", Offset = "0x2AE1DE0", VA = "0x182AE33E0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2AE3320", Offset = "0x2AE1D20", VA = "0x182AE3320")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2AE31A0", Offset = "0x2AE1BA0", VA = "0x182AE31A0", Slot = "23")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2AE1910", Offset = "0x2AE0310", VA = "0x182AE1910")]
		public void ForceDispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2AE43F0", Offset = "0x2AE2DF0", VA = "0x182AE43F0")]
		private static void SEVLMQJFDPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2AE2F60", Offset = "0x2AE1960", VA = "0x182AE2F60")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2AE0400", Offset = "0x2ADEE00", VA = "0x182AE0400")]
		protected void CYGSKFZDOVS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2AE2CA0", Offset = "0x2AE16A0", VA = "0x182AE2CA0")]
		private void NIGYEYRGAME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2AE2770", Offset = "0x2AE1170", VA = "0x182AE2770")]
		[IteratorStateMachine(typeof(CYMEJHEKSIG))]
		private IEnumerator LEEZKSAEIRC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160")]
		public static Platform GetPlatform()
		{
			return default(Platform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xDD8020", Offset = "0xDD6A20", VA = "0x180DD8020")]
		public PlatformOptions GetCurrentPlatformOptions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2AE18A0", Offset = "0x2AE02A0", VA = "0x182AE18A0")]
		private string FJLGGCPHDYV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160")]
		private long ONIZFNQVKFK()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2AE4F80", Offset = "0x2AE3980", VA = "0x182AE4F80")]
		private string THQMWPZXZTG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2AE5650", Offset = "0x2AE4050", VA = "0x182AE5650")]
		private string YANCENHLRHJ(string a, MediaPathType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2AE10C0", Offset = "0x2ADFAC0", VA = "0x182AE10C0")]
		private static SGKZHKMTMPS EWXKYJWRLOT(OptionsWindows a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2AE0380", Offset = "0x2ADED80", VA = "0x182AE0380")]
		private static SGKZHKMTMPS CEUWXGORUOC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2AE0630", Offset = "0x2ADF030", VA = "0x182AE0630", Slot = "24")]
		public virtual SGKZHKMTMPS CreateMediaPlayer()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2ADFBF0", Offset = "0x2ADE5F0", VA = "0x182ADFBF0")]
		private void AXIFCQDYPQZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2AE5030", Offset = "0x2AE3A30", VA = "0x182AE5030")]
		private void UBFDDHNMKQH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2AE0210", Offset = "0x2ADEC10", VA = "0x182AE0210")]
		private void CACVVVILUDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320")]
		public bool IsUsingAndroidOESPath()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320")]
		public bool IsUsingYCbCr()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2AE4950", Offset = "0x2AE3350", VA = "0x182AE4950")]
		[ContextMenu("Save Frame To PNG")]
		public void SaveFrameToPng()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2AE4550", Offset = "0x2AE2F50", VA = "0x182AE4550")]
		[ContextMenu("Save Frame To EXR")]
		public void SaveFrameToExr()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		private void OnApplicationFocus(bool focusStatus)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2AE03D0", Offset = "0x2ADEDD0", VA = "0x182AE03D0")]
		private void CQXRQWCJXPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2AE56B0", Offset = "0x2AE40B0", VA = "0x182AE56B0")]
		private void YHMHGDENCER()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2AE55C0", Offset = "0x2AE3FC0", VA = "0x182AE55C0")]
		private void VZIOSCWECCZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2ADFFD0", Offset = "0x2ADE9D0", VA = "0x182ADFFD0")]
		private void BWMVYYGPXXI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2AE4230", Offset = "0x2AE2C30", VA = "0x182AE4230")]
		private void SEABOXOZYQK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2AE5780", Offset = "0x2AE4180", VA = "0x182AE5780")]
		protected bool YXOVNWUVZKE(MediaPlayerEvent.EventType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2AE2A50", Offset = "0x2AE1450", VA = "0x182AE2A50")]
		private bool MTRBPOQETES(MediaPlayerEvent.EventType a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2AE3720", Offset = "0x2AE2120", VA = "0x182AE3720")]
		private bool PSMBHETPKJW(MediaPlayerEvent.EventType a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2AE2AE0", Offset = "0x2AE14E0", VA = "0x182AE2AE0")]
		private bool MTXNJDRYLCU(int a, float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2AE3C90", Offset = "0x2AE2690", VA = "0x182AE3C90")]
		private static Camera PWDHOWDAMSV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2AE3650", Offset = "0x2AE2050", VA = "0x182AE3650")]
		[IteratorStateMachine(typeof(KCEPGNTASHE))]
		private IEnumerator POMSKYZZPTA(Texture2D a, ProcessExtractedFrame b, double c = -1.0, bool d = true, int e = 1000, int f = 100)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2AE1650", Offset = "0x2AE0050", VA = "0x182AE1650")]
		public void ExtractFrameAsync(Texture2D target, ProcessExtractedFrame callback, double timeSeconds = -1.0, bool accurateSeek = true, int timeoutMs = 1000, int timeThresholdMs = 100)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2AE1720", Offset = "0x2AE0120", VA = "0x182AE1720")]
		public Texture2D ExtractFrame(Texture2D target, double timeSeconds = -1.0, bool accurateSeek = true, int timeoutMs = 1000, int timeThresholdMs = 100)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2AE19E0", Offset = "0x2AE03E0", VA = "0x182AE19E0")]
		private Texture GAIARPTDWEA(double a = -1.0, bool b = true, int c = 1000, int d = 100)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x2AE3460", Offset = "0x2AE1E60", VA = "0x182AE3460")]
		public bool OpenMediaFromBuffer(byte[] buffer, bool autoPlay = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x2AE4D50", Offset = "0x2AE3750", VA = "0x182AE4D50")]
		public bool StartOpenChunkedMediaFromBuffer(ulong length, bool autoPlay = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2ADFE40", Offset = "0x2ADE840", VA = "0x182ADFE40")]
		public bool AddChunkToVideoBuffer(byte[] chunk, ulong offset, ulong chunkSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2AE15D0", Offset = "0x2ADFFD0", VA = "0x182AE15D0")]
		public bool EndOpenChunkedVideoFromBuffer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2AE2550", Offset = "0x2AE0F50", VA = "0x182AE2550")]
		private bool KVCDXSNLZPL(byte[] a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2AE1C30", Offset = "0x2AE0630", VA = "0x182AE1C30")]
		private bool GFLDNKHGTAB(ulong a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2ADFE40", Offset = "0x2ADE840", VA = "0x182ADFE40")]
		private bool ZTUQEIWFTUE(byte[] a, ulong b, ulong c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2AE15D0", Offset = "0x2ADFFD0", VA = "0x182AE15D0")]
		private bool NDLPUDTQCAW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2AE1200", Offset = "0x2ADFC00", VA = "0x182AE1200")]
		public bool EnableSubtitles(MediaPath mediaPath)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2AE4180", Offset = "0x2AE2B80", VA = "0x182AE4180")]
		[IteratorStateMachine(typeof(WPAUHGNAIOO))]
		private IEnumerator SATKCPXNCJJ(string a, MediaPath b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2AE09E0", Offset = "0x2ADF3E0", VA = "0x182AE09E0")]
		public void DisableSubtitles()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "4")]
		private void SLBJAUDSLEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2AE2450", Offset = "0x2AE0E50", VA = "0x182AE2450", Slot = "5")]
		private void KUVQDBUBXEY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2AE57B0", Offset = "0x2AE41B0", VA = "0x182AE57B0")]
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
			public BKVLAUJMDGP.Preset overrideTransitionEasing;

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x2ADF8D0", Offset = "0x2ADE2D0", VA = "0x182ADF8D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2AE6620", Offset = "0x2AE5020", VA = "0x182AE6620")]
		public bool WEVGJIUITTW(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2AE6680", Offset = "0x2AE5080", VA = "0x182AE6680")]
		public MediaPlaylist()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[AddComponentMenu("AVPro Video/Playlist Media Player", -80)]
	[HelpURL("https://www.renderheads.com/products/avpro-video/")]
	public class PlaylistMediaPlayer : MediaPlayer, KWNWISOSPDU
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
		private sealed class ESSYDBXDYXS : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			private int EQRCVSNPEJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			private object RIDNXCOLQWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public PlaylistMediaPlayer TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			private object RUKYTXHYLRZ
			{
				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			private object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xD1D960", Offset = "0xD1C360", VA = "0x180D1D960")]
			[DebuggerHidden]
			public ESSYDBXDYXS(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
			[DebuggerHidden]
			private void GWJQUAHXPBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x2ADE000", Offset = "0x2ADCA00", VA = "0x182ADE000", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x2ADDFC0", Offset = "0x2ADC9C0", VA = "0x182ADDFC0", Slot = "8")]
			[DebuggerHidden]
			private void JNSYTSSCILY()
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
		private BKVLAUJMDGP.Preset _defaultTransitionEasing;

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
		private static readonly LazyShaderProperty GWTQEYFVYZG;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private static readonly LazyShaderProperty JRPPGNJAYMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20D")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private bool ERXGPYIIHSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private int DRBGYOVOCAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private MediaPlayer AFXOHVMZXRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private Material NYFNIXNQLWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private Transition GORGUGRBZVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private string MHNWVDLXLQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private float AINKFTBKRWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23C")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private BKVLAUJMDGP.Preset LDHFFLSBBRI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private float KERAQYDMWXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private Func<float, float> FPXJLETTUFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private RenderTexture EXICXJRTVFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private MediaPlaylist.MediaItem DKBABXMRZEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private MediaPlaylist.MediaItem BIWSCDQPFDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private WaitForEndOfFrame ATQIMTANDNO;

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public MediaPlayer ZKWWAKERWVE
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x2AE99A0", Offset = "0x2AE83A0", VA = "0x182AE99A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public MediaPlayer FXHHJAMBDPY
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xF86B30", Offset = "0xF85530", VA = "0x180F86B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public MediaPlaylist UAUGUWCVOWM
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xDD7DB0", Offset = "0xDD67B0", VA = "0x180DD7DB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public int YMOJTYUIESA
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x25DA9C0", Offset = "0x25D93C0", VA = "0x1825DA9C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public MediaPlaylist.MediaItem TJBPPIVJXLF
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x2AE9AF0", Offset = "0x2AE84F0", VA = "0x182AE9AF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Transition CJRXPFYXOMU
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x168EA30", Offset = "0x168D430", VA = "0x18168EA30")]
			get
			{
				return default(Transition);
			}
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x167D5C0", Offset = "0x167BFC0", VA = "0x18167D5C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public float PPMJOQAHDBW
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x1D08E90", Offset = "0x1D07890", VA = "0x181D08E90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x1D0A7E0", Offset = "0x1D091E0", VA = "0x181D0A7E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public BKVLAUJMDGP.Preset DUZVJJIBGMZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x247BE50", Offset = "0x247A850", VA = "0x18247BE50")]
			get
			{
				return default(BKVLAUJMDGP.Preset);
			}
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x28B9FC0", Offset = "0x28B89C0", VA = "0x1828B9FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public bool DSYDEHJQBWS
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x10FB8E0", Offset = "0x10FA2E0", VA = "0x1810FB8E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x168FFD0", Offset = "0x168E9D0", VA = "0x18168FFD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public PlaylistLoopMode YAMIOYNMZDV
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x2AE9AE0", Offset = "0x2AE84E0", VA = "0x182AE9AE0")]
			get
			{
				return default(PlaylistLoopMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x23A15C0", Offset = "0x239FFC0", VA = "0x1823A15C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public bool ROTHPFEZWZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x10FA040", Offset = "0x10F8A40", VA = "0x1810FA040")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x1690340", Offset = "0x168ED40", VA = "0x181690340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public override DSWBBQVJKJN MUHKFDBASHA
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x2AE9A40", Offset = "0x2AE8440", VA = "0x182AE9A40", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public override MZIHFSZZUIM HYOUNAHWHRN
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x2AE9900", Offset = "0x2AE8300", VA = "0x182AE9900", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public override KWNWISOSPDU KYAIZMMVAPV
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xE354B0", Offset = "0xE33EB0", VA = "0x180E354B0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public override float LZWDWUFFYVA
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x1D0A250", Offset = "0x1D08C50", VA = "0x181D0A250", Slot = "6")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x2AE9C80", Offset = "0x2AE8680", VA = "0x182AE9C80", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public override bool ACDVZEIFBWH
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x10FBBF0", Offset = "0x10FA5F0", VA = "0x1810FBBF0", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x2AE9BB0", Offset = "0x2AE85B0", VA = "0x182AE9BB0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2AE8890", Offset = "0x2AE7290", VA = "0x182AE8890", Slot = "20")]
		public override void Play()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2AE8780", Offset = "0x2AE7180", VA = "0x182AE8780", Slot = "21")]
		public override void Pause()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x10F9F40", Offset = "0x10F8940", VA = "0x1810F9F40")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2AE8710", Offset = "0x2AE7110", VA = "0x182AE8710")]
		[IteratorStateMachine(typeof(ESSYDBXDYXS))]
		private IEnumerator PCEJXSYTEIN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2AE91E0", Offset = "0x2AE7BE0", VA = "0x182AE91E0")]
		private Texture VCHNQMXWCJL(int a = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2AE95B0", Offset = "0x2AE7FB0", VA = "0x182AE95B0")]
		private Texture VNJGPRVOTZA(int a = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2AE6CC0", Offset = "0x2AE56C0", VA = "0x182AE6CC0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2AE7EE0", Offset = "0x2AE68E0", VA = "0x182AE7EE0", Slot = "23")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2AE8A50", Offset = "0x2AE7450", VA = "0x182AE8A50")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2AE8180", Offset = "0x2AE6B80", VA = "0x182AE8180")]
		public void OnMediaPlayerEvent(MediaPlayer mediaPlayer, MediaPlayerEvent.EventType eventType, ErrorCode errorCode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2AE89A0", Offset = "0x2AE73A0", VA = "0x182AE89A0")]
		public bool PrevItem()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2AE7E60", Offset = "0x2AE6860", VA = "0x182AE7E60")]
		public bool NextItem()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2AE6E50", Offset = "0x2AE5850", VA = "0x182AE6E50")]
		public bool CanJumpToItem(int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2AE7990", Offset = "0x2AE6390", VA = "0x182AE7990")]
		public bool JumpToItem(int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2AE8340", Offset = "0x2AE6D40", VA = "0x182AE8340")]
		public void OpenVideoFile(MediaPlaylist.MediaItem mediaItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2AE7E40", Offset = "0x2AE6840", VA = "0x182AE7E40")]
		private bool LXITBYBNXXF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2AE7AD0", Offset = "0x2AE64D0", VA = "0x182AE7AD0")]
		private void KECGZVLTAHP(Transition a, float b, BKVLAUJMDGP.Preset c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2AE8C90", Offset = "0x2AE7690", VA = "0x182AE8C90", Slot = "22")]
		protected override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2AE7770", Offset = "0x2AE6170", VA = "0x182AE7770", Slot = "26")]
		public Texture GetTexture(int index = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2AE71F0", Offset = "0x2AE5BF0", VA = "0x182AE71F0", Slot = "25")]
		public int GetTextureCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x2AE7290", Offset = "0x2AE5C90", VA = "0x182AE7290", Slot = "27")]
		public int GetTextureFrameCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2AE8BF0", Offset = "0x2AE75F0", VA = "0x182AE8BF0", Slot = "28")]
		public bool SupportsTextureFrameCount()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2AE75B0", Offset = "0x2AE5FB0", VA = "0x182AE75B0", Slot = "29")]
		public long GetTextureTimeStamp()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2AE7460", Offset = "0x2AE5E60", VA = "0x182AE7460", Slot = "30")]
		public float GetTexturePixelAspectRatio()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2AE89B0", Offset = "0x2AE73B0", VA = "0x182AE89B0", Slot = "31")]
		public bool RequiresVerticalFlip()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2AE7860", Offset = "0x2AE6260", VA = "0x182AE7860", Slot = "35")]
		public Matrix4x4 GetYpCbCrTransform()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2AE7510", Offset = "0x2AE5F10", VA = "0x182AE7510", Slot = "32")]
		public StereoPacking GetTextureStereoPacking()
		{
			return default(StereoPacking);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x2AE76D0", Offset = "0x2AE60D0", VA = "0x182AE76D0", Slot = "33")]
		public TransparencyMode GetTextureTransparency()
		{
			return default(TransparencyMode);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x2AE7150", Offset = "0x2AE5B50", VA = "0x182AE7150", Slot = "34")]
		public AlphaPacking GetTextureAlphaPacking()
		{
			return default(AlphaPacking);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x2AE6F20", Offset = "0x2AE5920", VA = "0x182AE6F20", Slot = "36")]
		public float[] GetAffineTransform()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x2AE7330", Offset = "0x2AE5D30", VA = "0x182AE7330", Slot = "37")]
		public Matrix4x4 GetTextureMatrix()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x2AE7010", Offset = "0x2AE5A10", VA = "0x182AE7010", Slot = "38")]
		public RenderTextureFormat GetCompatibleRenderTextureFormat(GetCompatibleRenderTextureFormatOptions options, int plane)
		{
			return default(RenderTextureFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x2AE92F0", Offset = "0x2AE7CF0", VA = "0x182AE92F0")]
		private static string VCKYOETABGC(Transition a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x2AE9770", Offset = "0x2AE8170", VA = "0x182AE9770")]
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
		private WACHGYKUCXH.ResolveFlags _resolveFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[SerializeField]
		private RenderTexture _externalTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private Material DDVZSUMWLLQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private bool EQSTKVSTTAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x71")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private bool TUTIPMQZGHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x72")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private bool HNFJBTNITMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private RenderTexture FHBYBRQBKVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private int HXQWIPXNHQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private Material VOWMHARKZEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private int SDMANKEQHBL;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public MediaPlayer BWMXLFRCCAP
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x2AE9EA0", Offset = "0x2AE88A0", VA = "0x182AE9EA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public VideoResolveOptions BCFIMPKJKUH
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x2AEA860", Offset = "0x2AE9260", VA = "0x182AEA860")]
			get
			{
				return default(VideoResolveOptions);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x2AEA880", Offset = "0x2AE9280", VA = "0x182AEA880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public RenderTexture KZVUXOJHVQQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xD14490", Offset = "0xD12E90", VA = "0x180D14490")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xD141A0", Offset = "0xD12BA0", VA = "0x180D141A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public RenderTexture ABXFEOOIHOW
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x2AEA7E0", Offset = "0x2AE91E0", VA = "0x182AEA7E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2AEA620", Offset = "0x2AE9020", VA = "0x182AEA620")]
		public void SetMaterialDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x2AE9EA0", Offset = "0x2AE88A0", VA = "0x182AE9EA0")]
		private void RPAIMSHZKAD(MediaPlayer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x2AEA630", Offset = "0x2AE9030", VA = "0x182AEA630")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2AE9D70", Offset = "0x2AE8770", VA = "0x182AE9D70")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x2AE9F40", Offset = "0x2AE8940", VA = "0x182AE9F40")]
		public void Resolve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x2AE9E20", Offset = "0x2AE8820", VA = "0x182AE9E20")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2AE9D80", Offset = "0x2AE8780", VA = "0x182AE9D80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2AEA790", Offset = "0x2AE9190", VA = "0x182AEA790")]
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
		private static readonly LazyShaderProperty JRQCCMZEMXL;

		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private static readonly LazyShaderProperty IMYZLWYWJEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private Camera ERAIBAXLFLU;

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Camera CSJMWMCKLDT
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0xD11C10", Offset = "0xD10610", VA = "0x180D11C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2AEBDE0", Offset = "0x2AEA7E0", VA = "0x182AEBDE0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2AEC5D0", Offset = "0x2AEAFD0", VA = "0x182AEC5D0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2AEC290", Offset = "0x2AEAC90", VA = "0x182AEC290")]
		private void QVIWLXXYMFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2AEBE80", Offset = "0x2AEA880", VA = "0x182AEBE80")]
		private static bool KHYRHBWRVLZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2AEBEB0", Offset = "0x2AEA8B0", VA = "0x182AEBEB0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xD11140", Offset = "0xD0FB40", VA = "0x180D11140")]
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
		protected bool HMMHFUPIAMF;

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public MediaPlayer STWIIHPYAQH
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x2AD7960", Offset = "0x2AD6360", VA = "0x182AD7960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public bool DJVFQRORWRK
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xDA45D0", Offset = "0xDA2FD0", VA = "0x180DA45D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x2AD7940", Offset = "0x2AD6340", VA = "0x182AD7940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public StereoPacking UEKNQWZBGYR
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xE2D170", Offset = "0xE2BB70", VA = "0x180E2D170")]
			get
			{
				return default(StereoPacking);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x2AD7950", Offset = "0x2AD6350", VA = "0x182AD7950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public bool EJQNSEQEHLP
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xD6FAC0", Offset = "0xD6E4C0", VA = "0x180D6FAC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x2AD7970", Offset = "0x2AD6370", VA = "0x182AD7970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x2AD7660", Offset = "0x2AD6060", VA = "0x182AD7660")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x2AD7750", Offset = "0x2AD6150", VA = "0x182AD7750")]
		private void RPAIMSHZKAD(MediaPlayer a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x2AD76B0", Offset = "0x2AD60B0", VA = "0x182AD76B0")]
		private void LTKNAZTPBMY(MediaPlayer a, MediaPlayerEvent.EventType b, ErrorCode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x2AD7670", Offset = "0x2AD6070", VA = "0x182AD7670")]
		public void ForceUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x2AD7900", Offset = "0x2AD6300", VA = "0x182AD7900")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x2AD7700", Offset = "0x2AD6100", VA = "0x182AD7700", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x1B114E0", Offset = "0x1B0FEE0", VA = "0x181B114E0", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x2AD76F0", Offset = "0x2AD60F0", VA = "0x182AD76F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "6")]
		protected virtual void XQQGRCIFIBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "7")]
		protected virtual void RYOEICSROYR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void Apply();

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x18E8360", Offset = "0x18E6D60", VA = "0x1818E8360")]
		protected ApplyToBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class HWLHTRTSBDK
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		protected class WEWFMZDXEKI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public HashSet<AudioOutput> XBSYEDLWPIQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public float[] NFILJVSCMAS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public bool KGRUEAZLSKR;

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WEWFMZDXEKI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private static HWLHTRTSBDK XDUFRHRJMAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private Dictionary<int, WEWFMZDXEKI> OTXMIHVMMFH;

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public static HWLHTRTSBDK UIOXUQVVXGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x2ADF1F0", Offset = "0x2ADDBF0", VA = "0x182ADF1F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x2ADF2F0", Offset = "0x2ADDCF0", VA = "0x182ADF2F0")]
		private HWLHTRTSBDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x2ADF100", Offset = "0x2ADDB00", VA = "0x182ADF100")]
		public void VEFPWUTTPFN(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x2ADF080", Offset = "0x2ADDA80", VA = "0x182ADF080")]
		public void UEFSDKUWQMY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE7D0", Offset = "0x2ADD1D0", VA = "0x182ADE7D0")]
		public void TNEDIRLPNVR(AudioOutput a, MediaPlayer b, int c, float[] d, int e, int f, AudioOutput.AudioOutputMode g, bool h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE790", Offset = "0x2ADD190", VA = "0x182ADE790")]
		private void TJOCEICUSBU(float[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE680", Offset = "0x2ADD080", VA = "0x182ADE680")]
		private bool MIPQBTMXKWC(MediaPlayer a, float[] b, int c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[DefaultMember("Item")]
	public abstract class SGKZHKMTMPS : WDUADRJVOGG, MZIHFSZZUIM, DSWBBQVJKJN, FTTZRJBXRLN, KWNWISOSPDU, SPMAFESFOFS, TOCQJIPOLBK, KAALOWHGEPD, CLHKFWMZKSW, LXLOHRXFROH, IEnumerable, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		protected string HUGWLZBJXQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		protected ErrorCode WHWZGXQAQFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		protected FilterMode IMAIQHAEKXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		protected TextureWrapMode YNMCGGKLLLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		protected int YRJNGWLECXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		protected MediaHints ATNXOYBTCJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		protected HPMLDTVMYCZ NBFOYODMHIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		protected HPMLDTVMYCZ ZPFWAZRNRTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private float RUQUACDHLFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private int VQDDCNOFRAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private float ZDGKKYUYIER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private float WLHAAZMFIOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private int HYKZHSPDIGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private int AHJPKIBRWHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		protected List<CKBEDAAIOQC> UMWQQYGZNOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		protected CKBEDAAIOQC KWCMQHTYFGY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		protected VAWWOSBZVLZ WWTPVTMZDTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		protected UAPCGHCKLTO CANUKZKUKQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		protected XFMFYUDHHWV UEXOZURUKFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		protected XVGEKFWEEWY IMKWGQHWWXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		protected VUOJTIHPQXX TEPZQVKHLGY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		protected RNPZPZQUWAR[] GBYYKNQQGKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		protected List<HEAYNJVIRHF> FSZKAEIGRRX;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x2AEBA90", Offset = "0x2AEA490", VA = "0x182AEBA90")]
		public SGKZHKMTMPS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "82")]
		public abstract string FSSSXMEJYMG();

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "83")]
		public abstract string ZVYWGZVXDJU();

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "84")]
		public abstract bool AWFEKRYZFGW(string a, long b, string c, MediaHints d, int e = 0, bool f = false);

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "85")]
		public virtual bool PPBCBZOXNNW(byte[] a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "86")]
		public virtual bool LXXZHSMJYOQ(ulong a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "87")]
		public virtual bool QFIIBVAIROX(byte[] a, ulong b, ulong c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "88")]
		public virtual bool HGPBJVDRZJR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x2AEB930", Offset = "0x2AEA330", VA = "0x182AEB930", Slot = "89")]
		public virtual void XXGGAUQGZEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(Slot = "90")]
		public abstract void JEXCWWZMLZG(bool a);

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "91")]
		public abstract bool PDAVUHYGZFS();

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(Slot = "92")]
		public abstract bool LRWNRXYAPPZ();

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "93")]
		public abstract bool FEUWISDCJRQ();

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
		[Cpp2IlInjected.Address(RVA = "0x2AEB910", Offset = "0x2AEA310", VA = "0x182AEB910", Slot = "97")]
		public virtual void WVJMBIDFVNX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(Slot = "98")]
		public abstract void EXNBGZQLPAC(double a);

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(Slot = "99")]
		public abstract void EWABPRAFIXO(double a);

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(Slot = "100")]
		public abstract double VMIWKOCIMFA();

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(Slot = "101")]
		public abstract float ZEWMUNVYZMJ();

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(Slot = "102")]
		public abstract void BDJEFEQGJIV(float a);

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(Slot = "103")]
		public abstract double QFAVZPEEMEO();

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(Slot = "104")]
		public abstract int MSCYOPMMVIX();

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(Slot = "105")]
		public abstract int NZKQQTGZCCS();

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(Slot = "106")]
		public abstract float TPWIQHSINME();

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(Slot = "107")]
		public abstract bool VNPFPOCWOMY();

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(Slot = "108")]
		public abstract bool MCKKYXECKOJ();

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(Slot = "109")]
		public abstract bool UGYEWNLSBNQ();

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(Slot = "110")]
		public abstract bool PXIYCMBCBKE();

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(Slot = "111")]
		public abstract bool CNGRUXPQIRW();

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(Slot = "112")]
		public abstract bool NFDXWDKLYNK();

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "113")]
		public abstract bool FBHMCOQMEEU();

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "114")]
		public virtual bool FTYNUPLGDDG(Camera a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xD7D950", Offset = "0xD7C350", VA = "0x180D7D950", Slot = "115")]
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
		[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "118")]
		public virtual bool SupportsTextureFrameCount()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x2AEAEB0", Offset = "0x2AE98B0", VA = "0x182AEAEB0", Slot = "119")]
		public virtual long GetTextureTimeStamp()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(Slot = "120")]
		public abstract bool RequiresVerticalFlip();

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xDBDA60", Offset = "0xDBC460", VA = "0x180DBDA60", Slot = "121")]
		public virtual float GetTexturePixelAspectRatio()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x2AEAEC0", Offset = "0x2AE98C0", VA = "0x182AEAEC0", Slot = "122")]
		public virtual Matrix4x4 GetYpCbCrTransform()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x2AEABA0", Offset = "0x2AE95A0", VA = "0x182AEABA0", Slot = "123")]
		public virtual float[] GetAffineTransform()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x2AEBA70", Offset = "0x2AEA470", VA = "0x182AEBA70", Slot = "124")]
		public virtual float[] ZNKYLNPALNV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x2AEACE0", Offset = "0x2AE96E0", VA = "0x182AEACE0", Slot = "125")]
		public virtual Matrix4x4 GetTextureMatrix()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xF3F580", Offset = "0xF3DF80", VA = "0x180F3F580", Slot = "126")]
		public virtual RenderTextureFormat GetCompatibleRenderTextureFormat(GetCompatibleRenderTextureFormatOptions options, int plane)
		{
			return default(RenderTextureFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x2AEAE80", Offset = "0x2AE9880", VA = "0x182AEAE80", Slot = "70")]
		public StereoPacking GetTextureStereoPacking()
		{
			return default(StereoPacking);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(Slot = "127")]
		internal abstract StereoPacking OVJIMSMZSPB();

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xD1B440", Offset = "0xD19E40", VA = "0x180D1B440", Slot = "128")]
		public virtual TransparencyMode GetTextureTransparency()
		{
			return default(TransparencyMode);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x2AEACA0", Offset = "0x2AE96A0", VA = "0x182AEACA0", Slot = "72")]
		public AlphaPacking GetTextureAlphaPacking()
		{
			return default(AlphaPacking);
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(Slot = "129")]
		public abstract void YIRIJTFSMRB(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(Slot = "130")]
		public abstract bool SOLAYLQQZZH();

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "131")]
		public abstract void KVTTYIUIQLK(float a);

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "132")]
		public virtual void UFNWTIDOMZA(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(Slot = "133")]
		public abstract float AXSBUAKBEJK();

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xD62000", Offset = "0xD60A00", VA = "0x180D62000", Slot = "134")]
		public virtual float GetBalance()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xD62010", Offset = "0xD60A10", VA = "0x180D62010", Slot = "135")]
		public virtual int LPEHAJGVIXA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "136")]
		public virtual int MIPQBTMXKWC(float[] a, int b, int c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "137")]
		public virtual void HNPBTRNCMOC(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "138")]
		public virtual void ZHYRTPYNAXC(Quaternion a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "139")]
		public virtual void QXLWOXPSFVH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "140")]
		public virtual void FDONRNGNVAI(Audio360ChannelMode a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "141")]
		public virtual void XVCKTZHIKTT(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "142")]
		public virtual void JKTVYCKTCAN(float a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "143")]
		public virtual void ADJAYNPZYOK(Quaternion a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "144")]
		public virtual void SYHBCIOZRER(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "145")]
		public virtual void APHHGHZRTFY(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(Slot = "146")]
		public abstract void Update();

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "147")]
		public virtual void CIESCNMGVOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "148")]
		public abstract void Render();

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(Slot = "149")]
		public abstract void Dispose();

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "150")]
		public virtual void YPSYQOKLMHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x2AEB460", Offset = "0x2AE9E60", VA = "0x182AEB460", Slot = "40")]
		public ErrorCode OBATQXWNUYA()
		{
			return default(ErrorCode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "151")]
		public virtual bool WDWDMZXDMYJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xD161C0", Offset = "0xD14BC0", VA = "0x180D161C0", Slot = "39")]
		public HPMLDTVMYCZ JZDIHZKBPSN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x2AEA8C0", Offset = "0x2AE92C0", VA = "0x182AEA8C0", Slot = "42")]
		public void GLGFYIGVVHS([Out] FilterMode a, [Out] TextureWrapMode b, [Out] int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x2AEB880", Offset = "0x2AEA280", VA = "0x182AEB880", Slot = "41")]
		public void WTCWPYAZXDO(FilterMode a = FilterMode.Bilinear, TextureWrapMode b = TextureWrapMode.Clamp, int c = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x2AEB9D0", Offset = "0x2AEA3D0", VA = "0x182AEB9D0", Slot = "152")]
		protected virtual void YLIBETXNVKQ(Texture a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x2AEB470", Offset = "0x2AE9E70", VA = "0x182AEB470")]
		protected void RUUCGZJFMKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x2AEAA20", Offset = "0x2AE9420", VA = "0x182AEAA20")]
		protected bool GZQZGKLDFVT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x2AEB0F0", Offset = "0x2AE9AF0", VA = "0x182AEB0F0", Slot = "153")]
		public virtual bool KQDXIGZXBQO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x2AEB730", Offset = "0x2AEA130", VA = "0x182AEB730", Slot = "77")]
		public bool UMEFPTZKTCO(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x2AEA8E0", Offset = "0x2AE92E0", VA = "0x182AEA8E0", Slot = "154")]
		public virtual void GRPNLFNZXDW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x2AEA8A0", Offset = "0x2AE92A0", VA = "0x182AEA8A0", Slot = "155")]
		public virtual int CKMSUHGERQO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x2AEB420", Offset = "0x2AE9E20", VA = "0x182AEB420", Slot = "156")]
		public virtual string NDHCWBXWFAZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "157")]
		public virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x2AEB360", Offset = "0x2AE9D60", VA = "0x182AEB360", Slot = "158")]
		public int LHTMUDTHEAU(float a = 0f)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x2AEB7A0", Offset = "0x2AEA1A0", VA = "0x182AEB7A0")]
		protected bool WOSKXFCPKIT(bool a = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "159")]
		internal abstract bool TODMLDOYVKB();

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(Slot = "160")]
		internal abstract string BKEEUPELHGM();

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "161")]
		internal abstract bool LOZKZHVDITX(TrackType a);

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "162")]
		internal abstract int RBWEVCURFRF(TrackType a);

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(Slot = "163")]
		internal abstract NQRWSGCEUUY OEZYROZGULK(TrackType a, int b, bool c);

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x2AEB510", Offset = "0x2AE9F10", VA = "0x182AEB510")]
		private void RXEFADPQKZG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x2AEB680", Offset = "0x2AEA080", VA = "0x182AEB680")]
		protected void TYBQDCDYGYX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x2AEAF20", Offset = "0x2AE9920", VA = "0x182AEAF20")]
		private void JTYHHBQVUNZ(RNPZPZQUWAR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x2AEAC10", Offset = "0x2AE9610", VA = "0x182AEAC10", Slot = "164")]
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
		private List<UnityAction<MediaPlayer, EventType, ErrorCode>> CXLPKNGGGLS;

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x2ADFB00", Offset = "0x2ADE500", VA = "0x182ADFB00")]
		public bool TOTNSVIMNBF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x2ADFA10", Offset = "0x2ADE410", VA = "0x182ADFA10")]
		public void SBHXQLQYAQJ(UnityAction<MediaPlayer, EventType, ErrorCode> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x2ADF970", Offset = "0x2ADE370", VA = "0x182ADF970")]
		public void NGMIVSMJHDU(UnityAction<MediaPlayer, EventType, ErrorCode> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x2ADFB60", Offset = "0x2ADE560", VA = "0x182ADFB60")]
		public MediaPlayerEvent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class NIVMLQTCAUC
	{
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private static Matrix4x4 NQRIXGXRMTO;

		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private static Matrix4x4 WHGVIIJDOHI;

		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private static Matrix4x4 FBILPRMYXOA;

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0CA0", Offset = "0x2AEF6A0", VA = "0x182AF0CA0")]
		public static string ABTNKUXUBFT(MediaPathType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1910", Offset = "0x2AF0310", VA = "0x182AF1910")]
		public static string YDSSHEATXQH(string a, MediaPathType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0E00", Offset = "0x2AEF800", VA = "0x182AF0E00")]
		public static string BICWXJOAGZZ(ErrorCode a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x2AF13C0", Offset = "0x2AEFDC0", VA = "0x182AF13C0")]
		public static void ISNCDANPQPK(string a, [Optional] UnityEngine.Object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x2AF18E0", Offset = "0x2AF02E0", VA = "0x182AF18E0")]
		public static int QFXMZIFAOET()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x2AF17D0", Offset = "0x2AF01D0", VA = "0x182AF17D0")]
		public static int KJBJRBIYBNB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x2AF11B0", Offset = "0x2AEFBB0", VA = "0x182AF11B0")]
		public static Orientation IHNKAHMDHFW(float[] a)
		{
			return default(Orientation);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1860", Offset = "0x2AF0260", VA = "0x182AF1860")]
		public static int OCGDHFCNEFT(double a, float b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF10D0", Offset = "0x2AEFAD0", VA = "0x182AF10D0")]
		private static extern int GetShortPathName(string pathName, StringBuilder shortName, int cbShortName);

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0F20", Offset = "0x2AEF920", VA = "0x182AF0F20")]
		internal static string GYLAPSZYNWL(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF14A0", Offset = "0x2AEFEA0", VA = "0x182AF14A0")]
		public static Texture2D JCGPTCACZNT(Texture a, bool b, Orientation c, [Optional] Texture2D d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public interface WDUADRJVOGG
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnEnable();

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Update();

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void YPSYQOKLMHM();

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void CIESCNMGVOH();

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Render();
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public interface SPMAFESFOFS
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool UMEFPTZKTCO(string a);

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int CKMSUHGERQO();

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(Slot = "2")]
		string NDHCWBXWFAZ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public interface MZIHFSZZUIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool AWFEKRYZFGW(string a, long b, string c, MediaHints d, int e = 0, bool f = false);

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool PPBCBZOXNNW(byte[] a);

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool LXXZHSMJYOQ(ulong a);

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool QFIIBVAIROX(byte[] a, ulong b, ulong c);

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool HGPBJVDRZJR();

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void XXGGAUQGZEO();

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void JEXCWWZMLZG(bool a);

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool PDAVUHYGZFS();

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool LRWNRXYAPPZ();

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool FEUWISDCJRQ();

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool PXIYCMBCBKE();

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool UGYEWNLSBNQ();

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool CNGRUXPQIRW();

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(Slot = "13")]
		bool NFDXWDKLYNK();

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(Slot = "14")]
		bool FBHMCOQMEEU();

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
		void WVJMBIDFVNX();

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void EXNBGZQLPAC(double a);

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void EWABPRAFIXO(double a);

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(Slot = "21")]
		double VMIWKOCIMFA();

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(Slot = "22")]
		float ZEWMUNVYZMJ();

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void BDJEFEQGJIV(float a);

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void YIRIJTFSMRB(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(Slot = "25")]
		bool SOLAYLQQZZH();

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void KVTTYIUIQLK(float a);

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void UFNWTIDOMZA(float a);

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(Slot = "28")]
		float AXSBUAKBEJK();

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(Slot = "29")]
		float GetBalance();

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(Slot = "30")]
		HPMLDTVMYCZ JZDIHZKBPSN();

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(Slot = "31")]
		ErrorCode OBATQXWNUYA();

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(Slot = "32")]
		void WTCWPYAZXDO(FilterMode a = FilterMode.Bilinear, TextureWrapMode b = TextureWrapMode.Clamp, int c = 1);

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(Slot = "33")]
		void GLGFYIGVVHS([Out] FilterMode a, [Out] TextureWrapMode b, [Out] int c);

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(Slot = "34")]
		int MIPQBTMXKWC(float[] a, int b, int c);

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(Slot = "35")]
		int LPEHAJGVIXA();

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void HNPBTRNCMOC(bool a);

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(Slot = "37")]
		void FDONRNGNVAI(Audio360ChannelMode a);

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(Slot = "38")]
		void ZHYRTPYNAXC(Quaternion a);

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(Slot = "39")]
		void QXLWOXPSFVH();

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(Slot = "40")]
		void XVCKTZHIKTT(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(Slot = "41")]
		void JKTVYCKTCAN(float a, float b);

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(Slot = "42")]
		void ADJAYNPZYOK(Quaternion a);

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(Slot = "43")]
		bool FTYNUPLGDDG(Camera a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(Slot = "44")]
		void SYHBCIOZRER(string a);

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(Slot = "45")]
		void APHHGHZRTFY(byte[] a);
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public interface DSWBBQVJKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(Slot = "0")]
		double QFAVZPEEMEO();

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int MSCYOPMMVIX();

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int NZKQQTGZCCS();

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(Slot = "3")]
		float TPWIQHSINME();

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool MCKKYXECKOJ();

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool WDWDMZXDMYJ();

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool KQDXIGZXBQO();

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float[] ZNKYLNPALNV();
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public interface FTTZRJBXRLN
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public interface KWNWISOSPDU
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
			[Cpp2IlInjected.Address(RVA = "0xD10110", Offset = "0xD0EB10", VA = "0x180D10110")]
			get
			{
				return default(MediaPathType);
			}
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0xD1C790", Offset = "0xD1B190", VA = "0x180D1C790")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public string Path
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0xD11BB0", Offset = "0xD105B0", VA = "0x180D11BB0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0C30", Offset = "0x2AEF630", VA = "0x182AF0C30")]
		public MediaPath()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0BC0", Offset = "0x2AEF5C0", VA = "0x182AF0BC0")]
		public MediaPath(MediaPath copy)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0B50", Offset = "0x2AEF550", VA = "0x182AF0B50")]
		public MediaPath(string path, MediaPathType pathType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0910", Offset = "0x2AEF310", VA = "0x182AF0910")]
		public string ZNRXOBUDPQQ()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0880", Offset = "0x2AEF280", VA = "0x182AF0880")]
		public static MediaPath UACGLLSIADX(string a)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0860", Offset = "0x2AEF260", VA = "0x182AF0860")]
		public static bool SHHUBVCQRYC(MediaPath a, MediaPath b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x2AF06E0", Offset = "0x2AEF0E0", VA = "0x182AF06E0")]
		public static bool ENWYWLXFHXP(MediaPath a, MediaPath b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0720", Offset = "0x2AEF120", VA = "0x182AF0720", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0810", Offset = "0x2AEF210", VA = "0x182AF0810", Slot = "2")]
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
		public static MediaHints FYBGHSPAYRJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x2AF0690", Offset = "0x2AEF090", VA = "0x182AF0690")]
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
		[Cpp2IlInjected.Address(RVA = "0x2AFF020", Offset = "0x2AFDA20", VA = "0x182AFF020")]
		public bool QUIUXVEBKRT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF080", Offset = "0x2AFDA80", VA = "0x182AFF080")]
		internal void YJRFLTRPYQC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEFB0", Offset = "0x2AFD9B0", VA = "0x182AFEFB0")]
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
	public static class AYALZJQMPQX
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
	public static class WXUKQSPHMYV
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
	public static class ZEOCAKAMOUD
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
	public class HPMLDTVMYCZ : IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		internal TimeRange[] DAMVSICREVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		internal double BYCEFBEUVSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		internal double YHZTVYHIXFU;

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public int DJHUXMLNUTX
		{
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x286EF10", Offset = "0x286D910", VA = "0x18286EF10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public double EDNPXRZTHQX
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x2AEFC10", Offset = "0x2AEE610", VA = "0x182AEFC10")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public double FDPLQBIBMKN
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x2AEFC20", Offset = "0x2AEE620", VA = "0x182AEFC20")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public double EYNIIESDTNM
		{
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x2AEFBE0", Offset = "0x2AEE5E0", VA = "0x182AEFBE0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x2AEFFA0", Offset = "0x2AEE9A0", VA = "0x182AEFFA0")]
		internal HPMLDTVMYCZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x2AEFBF0", Offset = "0x2AEE5F0", VA = "0x182AEFBF0", Slot = "4")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x2AEFC30", Offset = "0x2AEE630", VA = "0x182AEFC30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x2AEFE50", Offset = "0x2AEE850", VA = "0x182AEFE50")]
		internal void ZNQDONJXEED()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class VAWWOSBZVLZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private int EOEVVWGHKOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private long QKDXERLKLCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private SGKZHKMTMPS OQQOMOENVQW;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public int VUEXUDXOQGI
		{
			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0xD10110", Offset = "0xD0EB10", VA = "0x180D10110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0xD1C790", Offset = "0xD1B190", VA = "0x180D1C790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public int VVNLYUBRVWN
		{
			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0xDF7E10", Offset = "0xDF6810", VA = "0x180DF7E10")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0xDF7E00", Offset = "0xDF6800", VA = "0x180DF7E00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public int JSQFGCEIYLH
		{
			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0xD1B420", Offset = "0xD19E20", VA = "0x180D1B420")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0xD1B430", Offset = "0xD19E30", VA = "0x180D1B430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		private float MDGUXZWGTRR
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x14224D0", Offset = "0x1420ED0", VA = "0x1814224D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		private string FJOUNPKVWTH
		{
			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0xD11C10", Offset = "0xD10610", VA = "0x180D11C10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		private int LBLMAFMCYSF
		{
			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0xD1B440", Offset = "0xD19E40", VA = "0x180D1B440")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0xD1BA20", Offset = "0xD1A420", VA = "0x180D1BA20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		private int RMWCUMKDGXU
		{
			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0xE2D170", Offset = "0xE2BB70", VA = "0x180E2D170")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x1E28BB0", Offset = "0x1E275B0", VA = "0x181E28BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public bool SRKDQVTBFYQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0xD6FAC0", Offset = "0xD6E4C0", VA = "0x180D6FAC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB7B0", Offset = "0x2AFA1B0", VA = "0x182AFB7B0")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB800", Offset = "0x2AFA200", VA = "0x182AFB800")]
		internal void Start(SGKZHKMTMPS player)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBBB0", Offset = "0x2AFA5B0", VA = "0x182AFBBB0")]
		internal void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70")]
		private static bool NZYNDICUQQH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public VAWWOSBZVLZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public sealed class WHNJAOQKLTS : SGKZHKMTMPS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private bool RJPKMPKREAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private bool ERXGPYIIHSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private double RSWIBJUZLKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private float JBBTEATMSAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private float UZFLCCLIFJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private bool FKHLCJYCLWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private int RWSZKOZZGAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private int JDHYRXLEMXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private Texture2D JWPCIKJMTHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private Texture2D SUSELJCLSSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private Texture2D EPNOWIVEHGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private float RHGUJDUIIGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private int TCYSBMKNVPF;

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B01B50", Offset = "0x2B00550", VA = "0x182B01B50", Slot = "82")]
		public override string FSSSXMEJYMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x2B01DF0", Offset = "0x2B007F0", VA = "0x182B01DF0", Slot = "83")]
		public override string ZVYWGZVXDJU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B01950", Offset = "0x2B00350", VA = "0x182B01950", Slot = "84")]
		public override bool AWFEKRYZFGW(string a, long b, string c, MediaHints d, int e = 0, bool f = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B01DB0", Offset = "0x2B007B0", VA = "0x182B01DB0", Slot = "89")]
		public override void XXGGAUQGZEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xE274D0", Offset = "0xE25ED0", VA = "0x180E274D0", Slot = "90")]
		public override void JEXCWWZMLZG(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xE271D0", Offset = "0xE25BD0", VA = "0x180E271D0", Slot = "91")]
		public override bool PDAVUHYGZFS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "92")]
		public override bool LRWNRXYAPPZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "93")]
		public override bool FEUWISDCJRQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "107")]
		public override bool VNPFPOCWOMY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "108")]
		public override bool MCKKYXECKOJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x2B01BE0", Offset = "0x2B005E0", VA = "0x182B01BE0", Slot = "94")]
		public override void Play()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B01BD0", Offset = "0x2B005D0", VA = "0x182B01BD0", Slot = "95")]
		public override void Pause()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B01C10", Offset = "0x2B00610", VA = "0x182B01C10", Slot = "96")]
		public override void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "109")]
		public override bool UGYEWNLSBNQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x1018F90", Offset = "0x1017990", VA = "0x181018F90", Slot = "110")]
		public override bool PXIYCMBCBKE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xEFE100", Offset = "0xEFCB00", VA = "0x180EFE100", Slot = "111")]
		public override bool CNGRUXPQIRW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B01B80", Offset = "0x2B00580", VA = "0x182B01B80", Slot = "112")]
		public override bool NFDXWDKLYNK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "113")]
		public override bool FBHMCOQMEEU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B01C00", Offset = "0x2B00600", VA = "0x182B01C00", Slot = "103")]
		public override double QFAVZPEEMEO()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x10FBB30", Offset = "0x10FA530", VA = "0x1810FBB30", Slot = "104")]
		public override int MSCYOPMMVIX()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x1019AB0", Offset = "0x10184B0", VA = "0x181019AB0", Slot = "105")]
		public override int NZKQQTGZCCS()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xE6E270", Offset = "0xE6CC70", VA = "0x180E6E270", Slot = "116")]
		public override Texture GetTexture(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x1EE7250", Offset = "0x1EE5C50", VA = "0x181EE7250", Slot = "117")]
		public override int GetTextureFrameCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xF3C9D0", Offset = "0xF3B3D0", VA = "0x180F3C9D0", Slot = "127")]
		internal override StereoPacking OVJIMSMZSPB()
		{
			return default(StereoPacking);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "120")]
		public override bool RequiresVerticalFlip()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x2B01B40", Offset = "0x2B00540", VA = "0x182B01B40", Slot = "98")]
		public override void EXNBGZQLPAC(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B01B40", Offset = "0x2B00540", VA = "0x182B01B40", Slot = "99")]
		public override void EWABPRAFIXO(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B01DA0", Offset = "0x2B007A0", VA = "0x182B01DA0", Slot = "100")]
		public override double VMIWKOCIMFA()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x2063210", Offset = "0x2061C10", VA = "0x182063210", Slot = "102")]
		public override void BDJEFEQGJIV(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x1FB9260", Offset = "0x1FB7C60", VA = "0x181FB9260", Slot = "101")]
		public override float ZEWMUNVYZMJ()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "129")]
		public override void YIRIJTFSMRB(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "130")]
		public override bool SOLAYLQQZZH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x1E6CFB0", Offset = "0x1E6B9B0", VA = "0x181E6CFB0", Slot = "131")]
		public override void KVTTYIUIQLK(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x1E6BDB0", Offset = "0x1E6A7B0", VA = "0x181E6BDB0", Slot = "133")]
		public override float AXSBUAKBEJK()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xD62000", Offset = "0xD60A00", VA = "0x180D62000", Slot = "106")]
		public override float TPWIQHSINME()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x2B01C20", Offset = "0x2B00620", VA = "0x182B01C20", Slot = "146")]
		public override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "148")]
		public override void Render()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "149")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "161")]
		internal override bool LOZKZHVDITX(TrackType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "162")]
		internal override int RBWEVCURFRF(TrackType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "163")]
		internal override NQRWSGCEUUY OEZYROZGULK(TrackType a, int b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "159")]
		internal override bool TODMLDOYVKB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "160")]
		internal override string BKEEUPELHGM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x2B01E10", Offset = "0x2B00810", VA = "0x182B01E10")]
		public WHNJAOQKLTS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class PLPQPZNOHLS
	{
		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public string OGQFHWFNBFB
		{
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0xD11BD0", Offset = "0xD105D0", VA = "0x180D11BD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public string SOUCDIKPLPR
		{
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xD11BB0", Offset = "0xD105B0", VA = "0x180D11BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public byte[] LPCAIQQMSEE
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0xD11C10", Offset = "0xD10610", VA = "0x180D11C10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x2AF64D0", Offset = "0x2AF4ED0", VA = "0x182AF64D0")]
		public PLPQPZNOHLS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6470", Offset = "0x2AF4E70", VA = "0x182AF6470")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class PZRGWFRVSEY : SGKZHKMTMPS
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
			[Cpp2IlInjected.Address(RVA = "0x2AF4200", Offset = "0x2AF2C00", VA = "0x182AF4200")]
			public static extern bool IsChangedTracks(IntPtr instance, TrackType trackType);

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x2AF3830", Offset = "0x2AF2230", VA = "0x182AF3830")]
			public static extern int GetTrackCount(IntPtr instance, TrackType trackType);

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x2AF3AB0", Offset = "0x2AF24B0", VA = "0x182AF3AB0")]
			public static extern bool GetTrackInfo(IntPtr instance, TrackType trackType, int index, int uid, bool isActive, StringBuilder name, int maxNameLength, StringBuilder language, int maxLanguageLength);

			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x2AF4100", Offset = "0x2AF2B00", VA = "0x182AF4100")]
			public static extern bool IsChangedTextCue(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2A40", Offset = "0x2AF1440", VA = "0x182AF2A40")]
			public static extern IntPtr GetCurrentTextCue(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x2AF3700", Offset = "0x2AF2100", VA = "0x182AF3700")]
			public static extern int GetTimeRanges(IntPtr playerInstance, [Out] TimeRange[] ranges, int rangeCount, TimeRangeTypes timeRangeType);

			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x2AF3F80", Offset = "0x2AF2980", VA = "0x182AF3F80")]
			public static extern bool Init(bool linearColorSpace);

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2420", Offset = "0x2AF0E20", VA = "0x182AF2420")]
			public static extern void Deinit();

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x2AF3100", Offset = "0x2AF1B00", VA = "0x182AF3100")]
			public static extern IntPtr GetPluginVersion();

			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2070", Offset = "0x2AF0A70", VA = "0x182AF2070")]
			public static extern IntPtr BeginOpenSource(IntPtr instance, AYALZJQMPQX.VideoApi videoApi, AYALZJQMPQX.AudioOutput audioOutput, bool useHardwareDecoding, bool useRendererSync, bool generateTextureMips, bool hintAlphaChannel, bool useLowLatency, bool use10BitTextures, string forceAudioOutputDeviceName, int unitySampleRate, IntPtr[] preferredFilter, uint numFilters, int audio360ChannelMode, string httpHeader, bool startWithHighestBitrate);

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2690", Offset = "0x2AF1090", VA = "0x182AF2690")]
			public static extern IntPtr EndOpenSource(IntPtr instance, string path);

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x2AF4C20", Offset = "0x2AF3620", VA = "0x182AF4C20")]
			public static extern IntPtr OpenSourceFromBuffer(IntPtr instance, byte[] buffer, ulong bufferLength, AYALZJQMPQX.VideoApi videoApi, AYALZJQMPQX.AudioOutput audioOutput, bool useHardwareDecoding, bool useRendererSync, bool generateTextureMips, bool hintAlphaChannel, bool useLowLatency, bool use10BitTextures, string forceAudioOutputDeviceName, int unitySampleRate, IntPtr[] preferredFilter, uint numFilters);

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x2AF61D0", Offset = "0x2AF4BD0", VA = "0x182AF61D0")]
			public static extern IntPtr StartOpenSourceFromBuffer(IntPtr instance, AYALZJQMPQX.VideoApi videoApi, ulong bufferLength);

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x2AF1FB0", Offset = "0x2AF09B0", VA = "0x182AF1FB0")]
			public static extern bool AddChunkToSourceBuffer(IntPtr instance, byte[] buffer, ulong offset, ulong chunkLength);

			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2510", Offset = "0x2AF0F10", VA = "0x182AF2510")]
			public static extern IntPtr EndOpenSourceFromBuffer(IntPtr instance, AYALZJQMPQX.AudioOutput audioOutput, bool useHardwareDecoding, bool useRendererSync, bool generateTextureMips, bool hintAlphaChannel, bool useLowLatency, bool use10BitTextures, string forceAudioOutputDeviceName, int unitySampleRate, IntPtr[] preferredFilter, uint numFilters);

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2330", Offset = "0x2AF0D30", VA = "0x182AF2330")]
			public static extern void CloseSource(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x2AF3010", Offset = "0x2AF1A10", VA = "0x182AF3010")]
			public static extern IntPtr GetPlayerDescription(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x2AF5670", Offset = "0x2AF4070", VA = "0x182AF5670")]
			public static extern void SetCustomMovParserEnabled(IntPtr instance, bool enabled);

			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x2AF5830", Offset = "0x2AF4230", VA = "0x182AF5830")]
			public static extern void SetHapNotchLCEnabled(IntPtr instance, bool enabled);

			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x2AF5FA0", Offset = "0x2AF49A0", VA = "0x182AF5FA0")]
			public static extern void SetStereoDetectEnabled(IntPtr instance, bool enabled);

			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x2AF6030", Offset = "0x2AF4A30", VA = "0x182AF6030")]
			public static extern void SetTextTrackSupportEnabled(IntPtr instance, bool enabled);

			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x2AF5180", Offset = "0x2AF3B80", VA = "0x182AF5180")]
			public static extern void SetAudioDelayEnabled(IntPtr instance, bool enabled, bool isAutomatic, double timeSeconds);

			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x2AF57A0", Offset = "0x2AF41A0", VA = "0x182AF57A0")]
			public static extern void SetFacebookAudio360SupportEnabled(IntPtr instance, bool enabled);

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x2AF5700", Offset = "0x2AF4100", VA = "0x182AF5700")]
			public static extern void SetDecoderHints(IntPtr instance, int parallelFrameCount, int prerollFrameCount);

			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2DC0", Offset = "0x2AF17C0", VA = "0x182AF2DC0")]
			public static extern int GetLastErrorCode(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x2AF4F50", Offset = "0x2AF3950", VA = "0x182AF4F50")]
			public static extern void Play(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x2AF4DD0", Offset = "0x2AF37D0", VA = "0x182AF4DD0")]
			public static extern void Pause(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x2AF5B30", Offset = "0x2AF4530", VA = "0x182AF5B30")]
			public static extern void SetMuted(IntPtr instance, bool muted);

			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x2AF60C0", Offset = "0x2AF4AC0", VA = "0x182AF60C0")]
			public static extern void SetVolume(IntPtr instance, float volume);

			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x2AF5540", Offset = "0x2AF3F40", VA = "0x182AF5540")]
			public static extern void SetBalance(IntPtr instance, float volume);

			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x2AF5AA0", Offset = "0x2AF44A0", VA = "0x182AF5AA0")]
			public static extern void SetLooping(IntPtr instance, bool looping);

			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x2AF3E50", Offset = "0x2AF2850", VA = "0x182AF3E50")]
			public static extern bool HasVideo(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x2AF3D50", Offset = "0x2AF2750", VA = "0x182AF3D50")]
			public static extern bool HasAudio(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x2AF3C10", Offset = "0x2AF2610", VA = "0x182AF3C10")]
			public static extern int GetWidth(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2CC0", Offset = "0x2AF16C0", VA = "0x182AF2CC0")]
			public static extern int GetHeight(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2C40", Offset = "0x2AF1640", VA = "0x182AF2C40")]
			public static extern float GetFrameRate(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x2AF32D0", Offset = "0x2AF1CD0", VA = "0x182AF32D0")]
			public static extern StereoPacking GetStereoPacking(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2B40", Offset = "0x2AF1540", VA = "0x182AF2B40")]
			public static extern double GetDuration(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x2AF43A0", Offset = "0x2AF2DA0", VA = "0x182AF43A0")]
			public static extern bool IsPlaybackStalled(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x2AF3DD0", Offset = "0x2AF27D0", VA = "0x182AF3DD0")]
			public static extern bool HasMetaData(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2230", Offset = "0x2AF0C30", VA = "0x182AF2230")]
			public static extern bool CanPlay(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x2AF44A0", Offset = "0x2AF2EA0", VA = "0x182AF44A0")]
			public static extern bool IsSeeking(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x2AF4420", Offset = "0x2AF2E20", VA = "0x182AF4420")]
			public static extern bool IsPlaying(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x2AF4320", Offset = "0x2AF2D20", VA = "0x182AF4320")]
			public static extern bool IsFinished(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x2AF4080", Offset = "0x2AF2A80", VA = "0x182AF4080")]
			public static extern bool IsBuffering(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2AC0", Offset = "0x2AF14C0", VA = "0x182AF2AC0")]
			public static extern double GetCurrentTime(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x2AF55D0", Offset = "0x2AF3FD0", VA = "0x182AF55D0")]
			public static extern void SetCurrentTime(IntPtr instance, double time, bool fast);

			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x2AF5E80", Offset = "0x2AF4880", VA = "0x182AF5E80")]
			public static extern void SetPlaybackRate(IntPtr instance, float rate);

			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0x2AF6150", Offset = "0x2AF4B50", VA = "0x182AF6150")]
			public static extern void StartExtractFrame(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0x2AF6370", Offset = "0x2AF4D70", VA = "0x182AF6370")]
			public static extern void WaitForExtract(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0x2AF62F0", Offset = "0x2AF4CF0", VA = "0x182AF62F0")]
			public static extern void Update(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2730", Offset = "0x2AF1130", VA = "0x182AF2730")]
			public static extern void EndUpdate(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0x2AF34D0", Offset = "0x2AF1ED0", VA = "0x182AF34D0")]
			public static extern IntPtr GetTexturePointer(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(RVA = "0x2AF3350", Offset = "0x2AF1D50", VA = "0x182AF3350")]
			public static extern int GetTextureFormat(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(RVA = "0x2AF45A0", Offset = "0x2AF2FA0", VA = "0x182AF45A0")]
			public static extern bool IsTextureTopDown(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0x2AF4520", Offset = "0x2AF2F20", VA = "0x182AF4520")]
			public static extern bool IsTextureSampleLinear(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0x2AF33D0", Offset = "0x2AF1DD0", VA = "0x182AF33D0")]
			public static extern int GetTextureFrameCount(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x2AF3550", Offset = "0x2AF1F50", VA = "0x182AF3550")]
			public static extern long GetTextureTimeStamp(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x2AF3450", Offset = "0x2AF1E50", VA = "0x182AF3450")]
			public static extern float GetTexturePixelAspectRatio(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0x2AF3170", Offset = "0x2AF1B70", VA = "0x182AF3170")]
			public static extern IntPtr GetRenderEventFunc();

			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x2AF3C90", Offset = "0x2AF2690", VA = "0x182AF3C90")]
			public static extern int GrabAudio(IntPtr instance, float[] buffer, int sampleCount, int channelCount);

			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0x2AF28C0", Offset = "0x2AF12C0", VA = "0x182AF28C0")]
			public static extern int GetAudioChannelCount(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0x2AF50F0", Offset = "0x2AF3AF0", VA = "0x182AF50F0")]
			public static extern int SetAudioChannelMode(IntPtr instance, int audio360ChannelMode);

			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x2AF58C0", Offset = "0x2AF42C0", VA = "0x182AF58C0")]
			public static extern void SetHeadOrientation(IntPtr instance, float x, float y, float z, float w);

			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x2AF5230", Offset = "0x2AF3C30", VA = "0x182AF5230")]
			public static extern void SetAudioFocusEnabled(IntPtr instance, bool enabled);

			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x2AF52C0", Offset = "0x2AF3CC0", VA = "0x182AF52C0")]
			public static extern void SetAudioFocusProps(IntPtr instance, float offFocusLevel, float widthDegrees);

			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x2AF5360", Offset = "0x2AF3D60", VA = "0x182AF5360")]
			public static extern void SetAudioFocusRotation(IntPtr instance, float x, float y, float z, float w);

			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x2AF4620", Offset = "0x2AF3020", VA = "0x182AF4620")]
			public static void JRFZXMFHZYZ(IntPtr a, PLPQPZNOHLS b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x2AF5D20", Offset = "0x2AF4720", VA = "0x182AF5D20")]
			private static extern void SetNextAuthData(IntPtr instance, AuthData authData);
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private AYALZJQMPQX.AudioOutput MLHDLSHTGMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		private string IWKAKNWRLJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private List<string> VQDTRIYWMOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private Audio360ChannelMode JHOOUXODKRY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private bool EFZKQKWFUXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC5")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private bool BBZBYKEAEXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC6")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private bool YYXCDTALITM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC7")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private bool XIIUHWKNJGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private bool RKMGFXVMDCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private bool OKPQXZRIBQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private int DDEBCAKRTVM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private int CGDSCJUWWQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private bool RJPKMPKREAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD5")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private bool ERXGPYIIHSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD6")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private bool ZGDGVVNMAVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD7")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private bool FOWVPZXVLPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private bool BUWODNOAESY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private int HUQKPHWPAPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private int JDHYRXLEMXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private float DKHIQHKFHQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private float SHCUELGULMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private bool HWLTYHEJZXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private float JBBTEATMSAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private float QVJGVWKZHMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private bool PRJBNECOLAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF9")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		private bool JWHDVDVUNCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFA")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private bool WCVLWWJMSYJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private IntPtr ZADKGFOQPPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private Texture2D JWPCIKJMTHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		private RenderTexture PYGASFIDAGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private IntPtr XDUFRHRJMAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private AYALZJQMPQX.VideoApi UHHBKRIOMEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private bool QTVILHQKPRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x125")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private bool QVZYUKPBOPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x126")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private bool SGSQGBXVOSK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x127")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private bool FADEENLAHKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private bool OREXUTRPYUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x129")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private bool NVUZTRVSJLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12A")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private bool DBZREAODOSJ;

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private static bool LAMMIFWIFYI;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private static string QMEESOYPSRD;

		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private static IntPtr GUIUTXGUIVI;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private static int WREJGRORINY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private PLPQPZNOHLS CGPGVCOIBLW;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public PLPQPZNOHLS GCBHTOZTIVI
		{
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x2AFA960", Offset = "0x2AF9360", VA = "0x182AFA960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9980", Offset = "0x2AF8380", VA = "0x182AF9980")]
		public static bool RIRJCQVXPLU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x2AFACD0", Offset = "0x2AF96D0", VA = "0x182AFACD0")]
		public static void ZBUJFVGOTNS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x2AF89C0", Offset = "0x2AF73C0", VA = "0x182AF89C0", Slot = "135")]
		public override int LPEHAJGVIXA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x2AFAFC0", Offset = "0x2AF99C0", VA = "0x182AFAFC0")]
		public PZRGWFRVSEY(MediaPlayer.OptionsWindows a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x2AF75A0", Offset = "0x2AF5FA0", VA = "0x182AF75A0")]
		public void DDNHOPCNTWI(MediaPlayer.OptionsWindows a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7360", Offset = "0x2AF5D60", VA = "0x182AF7360")]
		public void DDNHOPCNTWI(AYALZJQMPQX.VideoApi a, AYALZJQMPQX.AudioOutput b, bool c, bool d, bool e, bool f, bool g, bool h, string i, List<string> j, bool k, int l, int m, bool n, bool o, bool p, bool q, bool r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x2AF77C0", Offset = "0x2AF61C0", VA = "0x182AF77C0", Slot = "82")]
		public override string FSSSXMEJYMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x2AFAF00", Offset = "0x2AF9900", VA = "0x182AFAF00", Slot = "83")]
		public override string ZVYWGZVXDJU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x2AFAEF0", Offset = "0x2AF98F0", VA = "0x182AFAEF0")]
		private bool ZSIJYKEUQFH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6650", Offset = "0x2AF5050", VA = "0x182AF6650", Slot = "84")]
		public override bool AWFEKRYZFGW(string a, long b, string c, MediaHints d, int e = 0, bool f = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9090", Offset = "0x2AF7A90", VA = "0x182AF9090", Slot = "85")]
		public override bool PPBCBZOXNNW(byte[] a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8A40", Offset = "0x2AF7440", VA = "0x182AF8A40", Slot = "86")]
		public override bool LXXZHSMJYOQ(ulong a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9710", Offset = "0x2AF8110", VA = "0x182AF9710", Slot = "87")]
		public override bool QFIIBVAIROX(byte[] a, ulong b, ulong c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7BC0", Offset = "0x2AF65C0", VA = "0x182AF7BC0", Slot = "88")]
		public override bool HGPBJVDRZJR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x2AFADC0", Offset = "0x2AF97C0", VA = "0x182AFADC0")]
		private void ZJTUSRYJXBA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x2AFAA30", Offset = "0x2AF9430", VA = "0x182AFAA30", Slot = "89")]
		public override void XXGGAUQGZEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF85E0", Offset = "0x2AF6FE0", VA = "0x182AF85E0", Slot = "90")]
		public override void JEXCWWZMLZG(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x2AE5EE0", Offset = "0x2AE48E0", VA = "0x182AE5EE0", Slot = "91")]
		public override bool PDAVUHYGZFS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0xF28BB0", Offset = "0xF275B0", VA = "0x180F28BB0", Slot = "92")]
		public override bool LRWNRXYAPPZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x10E3DF0", Offset = "0x10E27F0", VA = "0x1810E3DF0", Slot = "107")]
		public override bool VNPFPOCWOMY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x10E4400", Offset = "0x10E2E00", VA = "0x1810E4400", Slot = "108")]
		public override bool MCKKYXECKOJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF77B0", Offset = "0x2AF61B0", VA = "0x182AF77B0", Slot = "93")]
		public override bool FEUWISDCJRQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9600", Offset = "0x2AF8000", VA = "0x182AF9600", Slot = "94")]
		public override void Play()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9570", Offset = "0x2AF7F70", VA = "0x182AF9570", Slot = "95")]
		public override void Pause()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x2AEEE40", Offset = "0x2AED840", VA = "0x182AEEE40", Slot = "96")]
		public override void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA000", Offset = "0x2AF8A00", VA = "0x182AFA000", Slot = "109")]
		public override bool UGYEWNLSBNQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9560", Offset = "0x2AF7F60", VA = "0x182AF9560", Slot = "110")]
		public override bool PXIYCMBCBKE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7320", Offset = "0x2AF5D20", VA = "0x182AF7320", Slot = "111")]
		public override bool CNGRUXPQIRW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8BD0", Offset = "0x2AF75D0", VA = "0x182AF8BD0", Slot = "112")]
		public override bool NFDXWDKLYNK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7690", Offset = "0x2AF6090", VA = "0x182AF7690", Slot = "113")]
		public override bool FBHMCOQMEEU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9690", Offset = "0x2AF8090", VA = "0x182AF9690", Slot = "103")]
		public override double QFAVZPEEMEO()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x24EC440", Offset = "0x24EAE40", VA = "0x1824EC440", Slot = "104")]
		public override int MSCYOPMMVIX()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x21DBB90", Offset = "0x21DA590", VA = "0x1821DBB90", Slot = "105")]
		public override int NZKQQTGZCCS()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x1F6C270", Offset = "0x1F6AC70", VA = "0x181F6C270", Slot = "106")]
		public override float TPWIQHSINME()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7B20", Offset = "0x2AF6520", VA = "0x182AF7B20", Slot = "116")]
		public override Texture GetTexture(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF79E0", Offset = "0x2AF63E0", VA = "0x182AF79E0", Slot = "117")]
		public override int GetTextureFrameCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7AA0", Offset = "0x2AF64A0", VA = "0x182AF7AA0", Slot = "119")]
		public override long GetTextureTimeStamp()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF79F0", Offset = "0x2AF63F0", VA = "0x182AF79F0", Slot = "121")]
		public override float GetTexturePixelAspectRatio()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x10E35C0", Offset = "0x10E1FC0", VA = "0x1810E35C0", Slot = "120")]
		public override bool RequiresVerticalFlip()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9010", Offset = "0x2AF7A10", VA = "0x182AF9010", Slot = "127")]
		internal override StereoPacking OVJIMSMZSPB()
		{
			return default(StereoPacking);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7670", Offset = "0x2AF6070", VA = "0x182AF7670", Slot = "98")]
		public override void EXNBGZQLPAC(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7650", Offset = "0x2AF6050", VA = "0x182AF7650", Slot = "99")]
		public override void EWABPRAFIXO(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA8E0", Offset = "0x2AF92E0", VA = "0x182AFA8E0", Slot = "100")]
		public override double VMIWKOCIMFA()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7060", Offset = "0x2AF5A60", VA = "0x182AF7060", Slot = "102")]
		public override void BDJEFEQGJIV(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x1809010", Offset = "0x1807A10", VA = "0x181809010", Slot = "101")]
		public override float ZEWMUNVYZMJ()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x2AFABC0", Offset = "0x2AF95C0", VA = "0x182AFABC0", Slot = "129")]
		public override void YIRIJTFSMRB(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x10FB230", Offset = "0x10F9C30", VA = "0x1810FB230", Slot = "130")]
		public override bool SOLAYLQQZZH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8820", Offset = "0x2AF7220", VA = "0x182AF8820", Slot = "131")]
		public override void KVTTYIUIQLK(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x2911430", Offset = "0x290FE30", VA = "0x182911430", Slot = "133")]
		public override float AXSBUAKBEJK()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9F60", Offset = "0x2AF8960", VA = "0x182AF9F60", Slot = "132")]
		public override void UFNWTIDOMZA(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x210DE90", Offset = "0x210C890", VA = "0x18210DE90", Slot = "134")]
		public override float GetBalance()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8770", Offset = "0x2AF7170", VA = "0x182AF8770", Slot = "153")]
		public override bool KQDXIGZXBQO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7810", Offset = "0x2AF6210", VA = "0x182AF7810", Slot = "114")]
		public override bool FTYNUPLGDDG(Camera a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7720", Offset = "0x2AF6120", VA = "0x182AF7720", Slot = "140")]
		public override void FDONRNGNVAI(Audio360ChannelMode a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x2AFAD80", Offset = "0x2AF9780", VA = "0x182AFAD80", Slot = "138")]
		public override void ZHYRTPYNAXC(Quaternion a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x2AF97D0", Offset = "0x2AF81D0", VA = "0x182AF97D0", Slot = "139")]
		public override void QXLWOXPSFVH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA9A0", Offset = "0x2AF93A0", VA = "0x182AFA9A0", Slot = "141")]
		public override void XVCKTZHIKTT(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x2AF86D0", Offset = "0x2AF70D0", VA = "0x182AF86D0", Slot = "142")]
		public override void JKTVYCKTCAN(float a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6540", Offset = "0x2AF4F40", VA = "0x182AF6540", Slot = "143")]
		public override void ADJAYNPZYOK(Quaternion a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA090", Offset = "0x2AF8A90", VA = "0x182AFA090", Slot = "146")]
		public override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7080", Offset = "0x2AF5A80", VA = "0x182AF7080")]
		private void BJCOXEPSXUS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8040", Offset = "0x2AF6A40", VA = "0x182AF8040")]
		private void JBXARALEILI(IntPtr a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x2AFAC50", Offset = "0x2AF9650", VA = "0x182AFAC50", Slot = "150")]
		public override void YPSYQOKLMHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		private void EHSSBDKQKXH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7260", Offset = "0x2AF5C60", VA = "0x182AF7260", Slot = "147")]
		public override void CIESCNMGVOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9D70", Offset = "0x2AF8770", VA = "0x182AF9D70", Slot = "148")]
		public override void Render()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "149")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8B10", Offset = "0x2AF7510", VA = "0x182AF8B10", Slot = "136")]
		public override int MIPQBTMXKWC(float[] a, int b, int c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x2378AE0", Offset = "0x23774E0", VA = "0x182378AE0", Slot = "151")]
		public override bool WDWDMZXDMYJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8840", Offset = "0x2AF7240", VA = "0x182AF8840")]
		private static void LCWSCXGZLWT(Native.RenderThreadEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7F90", Offset = "0x2AF6990", VA = "0x182AF7F90")]
		private static string IIHTMDERTTV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9ED0", Offset = "0x2AF88D0", VA = "0x182AF9ED0", Slot = "159")]
		internal override bool TODMLDOYVKB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7190", Offset = "0x2AF5B90", VA = "0x182AF7190", Slot = "160")]
		internal override string BKEEUPELHGM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8920", Offset = "0x2AF7320", VA = "0x182AF8920", Slot = "161")]
		internal override bool LOZKZHVDITX(TrackType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x2AF98E0", Offset = "0x2AF82E0", VA = "0x182AF98E0", Slot = "162")]
		internal override int RBWEVCURFRF(TrackType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8C80", Offset = "0x2AF7680", VA = "0x182AF8C80", Slot = "163")]
		internal override NQRWSGCEUUY OEZYROZGULK(TrackType a, int b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9E70", Offset = "0x2AF8870", VA = "0x182AF9E70", Slot = "144")]
		public override void SYHBCIOZRER(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x2AF65F0", Offset = "0x2AF4FF0", VA = "0x182AF65F0", Slot = "145")]
		public override void APHHGHZRTFY(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x2AF94F0", Offset = "0x2AF7EF0", VA = "0x182AF94F0")]
		private void PXHZMKSLUAY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8600", Offset = "0x2AF7000", VA = "0x182AF8600")]
		private void JIPFOMHZSFR(TimeRange[] a, Native.TimeRangeTypes b)
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
	public sealed class GEFVZBIFXUG : SGKZHKMTMPS
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
			[Cpp2IlInjected.Address(RVA = "0x2AF4290", Offset = "0x2AF2C90", VA = "0x182AF4290")]
			public static extern bool IsChangedTracks(IntPtr instance, TrackType trackType);

			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x2AF38C0", Offset = "0x2AF22C0", VA = "0x182AF38C0")]
			public static extern int GetTrackCount(IntPtr instance, TrackType trackType);

			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0x2AF3950", Offset = "0x2AF2350", VA = "0x182AF3950")]
			public static extern bool GetTrackInfo(IntPtr instance, TrackType trackType, int index, int uid, bool isActive, StringBuilder name, int maxNameLength, StringBuilder language, int maxLanguageLength);

			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0x2AF4180", Offset = "0x2AF2B80", VA = "0x182AF4180")]
			public static extern bool IsChangedTextCue(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0x2AF29C0", Offset = "0x2AF13C0", VA = "0x182AF29C0")]
			public static extern IntPtr GetCurrentTextCue(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0x2AF3090", Offset = "0x2AF1A90", VA = "0x182AF3090")]
			private static extern IntPtr GetPluginVersionStringPointer();

			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0x2AF3ED0", Offset = "0x2AF28D0", VA = "0x182AF3ED0")]
			public static string IIHTMDERTTV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0x2AF23B0", Offset = "0x2AF0DB0", VA = "0x182AF23B0")]
			public static extern IntPtr CreatePlayer();

			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2490", Offset = "0x2AF0E90", VA = "0x182AF2490")]
			public static extern void DestroyPlayer(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0x2AF4B40", Offset = "0x2AF3540", VA = "0x182AF4B40")]
			public static extern bool OpenMedia(IntPtr playerInstance, string filePath, string httpHeader, FileFormat overrideFileFormat, bool startWithHighestBitrate, bool use10BitTextures);

			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0x2AF22B0", Offset = "0x2AF0CB0", VA = "0x182AF22B0")]
			public static extern void CloseMedia(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0x2AF4E50", Offset = "0x2AF3850", VA = "0x182AF4E50")]
			public static extern void Pause(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003D7")]
			[Cpp2IlInjected.Address(RVA = "0x2AF4ED0", Offset = "0x2AF38D0", VA = "0x182AF4ED0")]
			public static extern void Play(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003D8")]
			[Cpp2IlInjected.Address(RVA = "0x2AF54B0", Offset = "0x2AF3EB0", VA = "0x182AF54B0")]
			public static extern void SetAudioVolume(IntPtr playerInstance, float volume);

			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0x2AF5060", Offset = "0x2AF3A60", VA = "0x182AF5060")]
			public static extern void SetAudioBalance(IntPtr playerInstance, float balance);

			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0x2AF5F10", Offset = "0x2AF4910", VA = "0x182AF5F10")]
			public static extern void SetPlaybackRate(IntPtr playerInstance, float rate);

			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0x2AF5420", Offset = "0x2AF3E20", VA = "0x182AF5420")]
			public static extern void SetAudioMuted(IntPtr playerInstance, bool muted);

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x2AF4000", Offset = "0x2AF2A00", VA = "0x182AF4000")]
			public static extern bool IsAudioMuted(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2840", Offset = "0x2AF1240", VA = "0x182AF2840")]
			public static extern float GetAudioBalance(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2F10", Offset = "0x2AF1910", VA = "0x182AF2F10")]
			public static extern float GetPlaybackRate(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x2AF5A10", Offset = "0x2AF4410", VA = "0x182AF5A10")]
			public static extern void SetLooping(IntPtr playerInstance, bool looping);

			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2D40", Offset = "0x2AF1740", VA = "0x182AF2D40")]
			public static extern int GetLastErrorCode(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0x2AF6270", Offset = "0x2AF4C70", VA = "0x182AF6270")]
			public static extern void Update(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2BC0", Offset = "0x2AF15C0", VA = "0x182AF2BC0")]
			public static extern double GetDuration(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x2AF3250", Offset = "0x2AF1C50", VA = "0x182AF3250")]
			public static extern StereoPacking GetStereoPacking(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2940", Offset = "0x2AF1340", VA = "0x182AF2940")]
			public static extern double GetCurrentPosition(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2E40", Offset = "0x2AF1840", VA = "0x182AF2E40")]
			public static extern bool GetLatestFrame(IntPtr playerInstance, [Out] IntPtr leftEyeTexturePointer, [Out] IntPtr rightEyeTexturePointer, [Out] ulong frameTimeStamp, [Out] int width, [Out] int height);

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2F90", Offset = "0x2AF1990", VA = "0x182AF2F90")]
			public static extern PlaybackState GetPlaybackState(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x2AF27B0", Offset = "0x2AF11B0", VA = "0x182AF27B0")]
			public static extern bool GetActiveVideoTrackInfo(IntPtr playerInstance, [Out] VideoTrack videoTrack);

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x2AF5980", Offset = "0x2AF4380", VA = "0x182AF5980")]
			public static extern void SetLiveOffset(IntPtr playerInstance, double seconds);

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x2AF4FD0", Offset = "0x2AF39D0", VA = "0x182AF4FD0")]
			public static extern void Seek(IntPtr playerInstance, SeekParams seekParams);

			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x2AF48B0", Offset = "0x2AF32B0", VA = "0x182AF48B0")]
			public static void JRFZXMFHZYZ(IntPtr a, PLPQPZNOHLS b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0x2AF5BC0", Offset = "0x2AF45C0", VA = "0x182AF5BC0")]
			private static extern void SetNextAuthData(IntPtr playerInstance, AuthData authData);

			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0x2AF35D0", Offset = "0x2AF1FD0", VA = "0x182AF35D0")]
			public static extern int GetTimeRanges(IntPtr playerInstance, [Out] TimeRange[] ranges, int rangeCount, TimeRangeTypes timeRangeType);

			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x2AF31E0", Offset = "0x2AF1BE0", VA = "0x182AF31E0")]
			public static extern IntPtr GetRenderEventFunc();

			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0x2AEECD0", Offset = "0x2AED6D0", VA = "0x182AEECD0")]
			public static void ZYUFGOPHJGM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0x2AF63F0", Offset = "0x2AF4DF0", VA = "0x182AF63F0")]
			public static void XORHECOXDTX()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		private class YARBNDIAPBQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000307")]
			public Texture2D WDAORMRDYWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000308")]
			public IntPtr ELYORSNZUQO;

			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x2B01EC0", Offset = "0x2B008C0", VA = "0x182B01EC0")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0x2B01FB0", Offset = "0x2B009B0", VA = "0x182B01FB0")]
			public YARBNDIAPBQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private bool KVGFQGZAWNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private bool ZGDGVVNMAVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private float JBBTEATMSAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		private bool FADEENLAHKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		private bool BXBQJLGJSHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private PLPQPZNOHLS CGPGVCOIBLW;

		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private static bool LAMMIFWIFYI;

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private static string QMEESOYPSRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private ulong BOUTNMLGIVW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private IntPtr UXIMWMNXCYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private YARBNDIAPBQ[] QEMZCBQSFHS;

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public PLPQPZNOHLS GCBHTOZTIVI
		{
			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x2AEF5B0", Offset = "0x2AEDFB0", VA = "0x182AEF5B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x2AEF8B0", Offset = "0x2AEE2B0", VA = "0x182AEF8B0")]
		public GEFVZBIFXUG(MediaPlayer.OptionsWindows a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x2AED7D0", Offset = "0x2AEC1D0", VA = "0x182AED7D0")]
		public void DDNHOPCNTWI(MediaPlayer.OptionsWindows a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x2AEDA50", Offset = "0x2AEC450", VA = "0x182AEDA50", Slot = "93")]
		public override bool FEUWISDCJRQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x2AED800", Offset = "0x2AEC200", VA = "0x182AED800", Slot = "149")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "151")]
		public override bool WDWDMZXDMYJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x2AEF4F0", Offset = "0x2AEDEF0", VA = "0x182AEF4F0", Slot = "100")]
		public override double VMIWKOCIMFA()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE9A0", Offset = "0x2AED3A0", VA = "0x182AEE9A0", Slot = "103")]
		public override double QFAVZPEEMEO()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x2AEF780", Offset = "0x2AEE180", VA = "0x182AEF780", Slot = "101")]
		public override float ZEWMUNVYZMJ()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x2AEDBD0", Offset = "0x2AEC5D0", VA = "0x182AEDBD0", Slot = "116")]
		public override Texture GetTexture(int index = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x2AEDB40", Offset = "0x2AEC540", VA = "0x182AEDB40", Slot = "115")]
		public override int GetTextureCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0xF28BC0", Offset = "0xF275C0", VA = "0x180F28BC0", Slot = "117")]
		public override int GetTextureFrameCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE790", Offset = "0x2AED190", VA = "0x182AEE790", Slot = "127")]
		internal override StereoPacking OVJIMSMZSPB()
		{
			return default(StereoPacking);
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x2AEDA70", Offset = "0x2AEC470", VA = "0x182AEDA70", Slot = "82")]
		public override string FSSSXMEJYMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x2AEF800", Offset = "0x2AEE200", VA = "0x182AEF800", Slot = "83")]
		public override string ZVYWGZVXDJU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x2AEEEF0", Offset = "0x2AED8F0", VA = "0x182AEEEF0", Slot = "106")]
		public override float TPWIQHSINME()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE1F0", Offset = "0x2AECBF0", VA = "0x182AEE1F0", Slot = "104")]
		public override int MSCYOPMMVIX()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE370", Offset = "0x2AECD70", VA = "0x182AEE370", Slot = "105")]
		public override int NZKQQTGZCCS()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x1697210", Offset = "0x1695C10", VA = "0x181697210", Slot = "133")]
		public override float AXSBUAKBEJK()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x2AEEFA0", Offset = "0x2AED9A0", VA = "0x182AEEFA0", Slot = "132")]
		public override void UFNWTIDOMZA(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x2AEDAC0", Offset = "0x2AEC4C0", VA = "0x182AEDAC0", Slot = "134")]
		public override float GetBalance()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x2AEF570", Offset = "0x2AEDF70", VA = "0x182AEF570", Slot = "107")]
		public override bool VNPFPOCWOMY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE180", Offset = "0x2AECB80", VA = "0x182AEE180", Slot = "92")]
		public override bool LRWNRXYAPPZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE1B0", Offset = "0x2AECBB0", VA = "0x182AEE1B0", Slot = "108")]
		public override bool MCKKYXECKOJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x2AEDA30", Offset = "0x2AEC430", VA = "0x182AEDA30", Slot = "113")]
		public override bool FBHMCOQMEEU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE2C0", Offset = "0x2AECCC0", VA = "0x182AEE2C0", Slot = "112")]
		public override bool NFDXWDKLYNK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xEFE100", Offset = "0xEFCB00", VA = "0x180EFE100", Slot = "91")]
		public override bool PDAVUHYGZFS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x2AEED50", Offset = "0x2AED750", VA = "0x182AEED50", Slot = "130")]
		public override bool SOLAYLQQZZH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x2AED7B0", Offset = "0x2AEC1B0", VA = "0x182AED7B0", Slot = "111")]
		public override bool CNGRUXPQIRW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE880", Offset = "0x2AED280", VA = "0x182AEE880", Slot = "110")]
		public override bool PXIYCMBCBKE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x2AEF030", Offset = "0x2AEDA30", VA = "0x182AEF030", Slot = "109")]
		public override bool UGYEWNLSBNQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x2AEF6A0", Offset = "0x2AEE0A0", VA = "0x182AEF6A0", Slot = "129")]
		public override void YIRIJTFSMRB(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x2AED400", Offset = "0x2AEBE00", VA = "0x182AED400", Slot = "84")]
		public override bool AWFEKRYZFGW(string a, long b, string c, MediaHints d, int e = 0, bool f = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x2AEF5F0", Offset = "0x2AEDFF0", VA = "0x182AEF5F0", Slot = "89")]
		public override void XXGGAUQGZEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE8A0", Offset = "0x2AED2A0", VA = "0x182AEE8A0", Slot = "95")]
		public override void Pause()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE920", Offset = "0x2AED320", VA = "0x182AEE920", Slot = "94")]
		public override void Play()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x2AEECD0", Offset = "0x2AED6D0", VA = "0x182AEECD0", Slot = "148")]
		public override void Render()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x2AEDD10", Offset = "0x2AEC710", VA = "0x182AEDD10")]
		private void KNPJAGARGBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "120")]
		public override bool RequiresVerticalFlip()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x2AED9A0", Offset = "0x2AEC3A0", VA = "0x182AED9A0", Slot = "98")]
		public override void EXNBGZQLPAC(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x2AED980", Offset = "0x2AEC380", VA = "0x182AED980", Slot = "99")]
		public override void EWABPRAFIXO(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x2AEDC20", Offset = "0x2AEC620", VA = "0x182AEDC20", Slot = "90")]
		public override void JEXCWWZMLZG(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x2AED650", Offset = "0x2AEC050", VA = "0x182AED650", Slot = "102")]
		public override void BDJEFEQGJIV(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE0D0", Offset = "0x2AECAD0", VA = "0x182AEE0D0", Slot = "131")]
		public override void KVTTYIUIQLK(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x2AEEE40", Offset = "0x2AED840", VA = "0x182AEEE40", Slot = "96")]
		public override void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE810", Offset = "0x2AED210", VA = "0x182AEE810")]
		private void PXHZMKSLUAY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x2AEDC40", Offset = "0x2AEC640", VA = "0x182AEDC40")]
		private void JIPFOMHZSFR(TimeRange[] a, Native.TimeRangeTypes b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x2AEF050", Offset = "0x2AEDA50", VA = "0x182AEF050", Slot = "146")]
		public override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x2AEEDE0", Offset = "0x2AED7E0", VA = "0x182AEEDE0", Slot = "144")]
		public override void SYHBCIOZRER(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x2AED3A0", Offset = "0x2AEBDA0", VA = "0x182AED3A0", Slot = "145")]
		public override void APHHGHZRTFY(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE0F0", Offset = "0x2AECAF0", VA = "0x182AEE0F0", Slot = "161")]
		internal override bool LOZKZHVDITX(TrackType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE9B0", Offset = "0x2AED3B0", VA = "0x182AEE9B0", Slot = "162")]
		internal override int RBWEVCURFRF(TrackType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE440", Offset = "0x2AECE40", VA = "0x182AEE440", Slot = "163")]
		internal override NQRWSGCEUUY OEZYROZGULK(TrackType a, int b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x2AEEE60", Offset = "0x2AED860", VA = "0x182AEEE60", Slot = "159")]
		internal override bool TODMLDOYVKB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x2AED6E0", Offset = "0x2AEC0E0", VA = "0x182AED6E0", Slot = "160")]
		internal override string BKEEUPELHGM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x2AEEA40", Offset = "0x2AED440", VA = "0x182AEEA40")]
		public static bool RIRJCQVXPLU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x2AEF730", Offset = "0x2AEE130", VA = "0x182AEF730")]
		public static void ZBUJFVGOTNS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class UAPCGHCKLTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public string QMJGZUXCXLT
		{
			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0xD11BD0", Offset = "0xD105D0", VA = "0x180D11BD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0xD1D300", Offset = "0xD1BD00", VA = "0x180D1D300")]
		internal UAPCGHCKLTO(string a)
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
	public class NQRWSGCEUUY
	{
		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public int AJOQPOCFDHK
		{
			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0xD10110", Offset = "0xD0EB10", VA = "0x180D10110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0xD1C790", Offset = "0xD1B190", VA = "0x180D1C790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		private TrackType DYDYBSAFKYV
		{
			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0xDF7E00", Offset = "0xDF6800", VA = "0x180DF7E00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		private string XFMIXFZNZZR
		{
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0xD11BB0", Offset = "0xD105B0", VA = "0x180D11BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public string EDJPGUEQTOV
		{
			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003FB")]
			[Cpp2IlInjected.Address(RVA = "0xD11C10", Offset = "0xD10610", VA = "0x180D11C10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public string OHVUZUPTNZG
		{
			[Cpp2IlInjected.Token(Token = "0x60003FC")]
			[Cpp2IlInjected.Address(RVA = "0xD11C00", Offset = "0xD10600", VA = "0x180D11C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003FD")]
			[Cpp2IlInjected.Address(RVA = "0xD12070", Offset = "0xD10A70", VA = "0x180D12070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		private bool OXQBJHWWPZZ
		{
			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0xD70630", Offset = "0xD6F030", VA = "0x180D70630")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1EA0", Offset = "0x2AF08A0", VA = "0x182AF1EA0")]
		internal NQRWSGCEUUY(TrackType a, int b, string c, string d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1DE0", Offset = "0x2AF07E0", VA = "0x182AF1DE0")]
		protected string COEDYQXEPRN()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public abstract class RNPZPZQUWAR : IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public virtual TrackType DYDYBSAFKYV
		{
			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0xD10110", Offset = "0xD0EB10", VA = "0x180D10110", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(TrackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public abstract int DJHUXMLNUTX
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
		internal abstract void Add(NQRWSGCEUUY track);

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(Slot = "10")]
		internal abstract void WVYRKHGLCBN(NQRWSGCEUUY a);

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		protected RNPZPZQUWAR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[DefaultMember("Item")]
	public class ICNXUUBYYXI<a> : RNPZPZQUWAR where a : NQRWSGCEUUY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		internal List<a> DYALJNUFXZV;

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		internal a GYKMGQKHJFR
		{
			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0xD11BB0", Offset = "0xD105B0", VA = "0x180D11BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public override int DJHUXMLNUTX
		{
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x151FC70", Offset = "0x151E670", VA = "0x18151FC70", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x65F3950", Offset = "0x65F2350", VA = "0x1865F3950")]
		internal ICNXUUBYYXI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x65F3880", Offset = "0x65F2280", VA = "0x1865F3880", Slot = "7")]
		public override IEnumerator GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x65F3820", Offset = "0x65F2220", VA = "0x1865F3820", Slot = "8")]
		internal override void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x65F3750", Offset = "0x65F2150", VA = "0x1865F3750", Slot = "9")]
		internal override void Add(NQRWSGCEUUY track)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x65F38F0", Offset = "0x65F22F0", VA = "0x1865F38F0", Slot = "10")]
		internal override void WVYRKHGLCBN(NQRWSGCEUUY a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class XFMFYUDHHWV : ICNXUUBYYXI<KYLSUEQFHQA>
	{
		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public override TrackType DYDYBSAFKYV
		{
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "5")]
			get
			{
				return default(TrackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x2B01E40", Offset = "0x2B00840", VA = "0x182B01E40")]
		public XFMFYUDHHWV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class XVGEKFWEEWY : ICNXUUBYYXI<RHFYIYEIKVV>
	{
		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public override TrackType DYDYBSAFKYV
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0xD7D950", Offset = "0xD7C350", VA = "0x180D7D950", Slot = "5")]
			get
			{
				return default(TrackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x2B01E80", Offset = "0x2B00880", VA = "0x182B01E80")]
		public XVGEKFWEEWY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class VUOJTIHPQXX : ICNXUUBYYXI<UZISYDIPFFW>
	{
		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public override TrackType DYDYBSAFKYV
		{
			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0xD7C730", Offset = "0xD7B130", VA = "0x180D7C730", Slot = "5")]
			get
			{
				return default(TrackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEF70", Offset = "0x2AFD970", VA = "0x182AFEF70")]
		public VUOJTIHPQXX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class KYLSUEQFHQA : NQRWSGCEUUY
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0530", Offset = "0x2AEEF30", VA = "0x182AF0530")]
		internal KYLSUEQFHQA(int a, string b, string c, bool d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class RHFYIYEIKVV : NQRWSGCEUUY
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB210", Offset = "0x2AF9C10", VA = "0x182AFB210")]
		internal RHFYIYEIKVV(int a, string b, string c, bool d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class UZISYDIPFFW : NQRWSGCEUUY
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB780", Offset = "0x2AFA180", VA = "0x182AFB780")]
		internal UZISYDIPFFW(int a, string b, string c, bool d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public interface TOCQJIPOLBK
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public interface KAALOWHGEPD
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public interface CLHKFWMZKSW
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public static class BKVLAUJMDGP
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
		[Cpp2IlInjected.Address(RVA = "0x2AECD40", Offset = "0x2AEB740", VA = "0x182AECD40")]
		public static Func<float, float> PJMLTWFAOYW(Preset a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x2AED370", Offset = "0x2AEBD70", VA = "0x182AED370")]
		public static float YVVLGKBLNMC(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x2AECC20", Offset = "0x2AEB620", VA = "0x182AECC20")]
		public static float MGOYUCPWMAH(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x2AECB90", Offset = "0x2AEB590", VA = "0x182AECB90")]
		public static float KZFZOHBJBZU(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x2AECD20", Offset = "0x2AEB720", VA = "0x182AECD20")]
		public static float OEYVDSELPKE(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		public static float DAMYNABBNZB(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x2AEC990", Offset = "0x2AEB390", VA = "0x182AEC990")]
		public static float CECJHLGDTGK(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x2AECA60", Offset = "0x2AEB460", VA = "0x182AECA60")]
		public static float FHFGSNOXTJT(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x2AED2F0", Offset = "0x2AEBCF0", VA = "0x182AED2F0")]
		public static float VGIMVZHFUFC(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x2AED220", Offset = "0x2AEBC20", VA = "0x182AED220")]
		public static float QLBCYFPRFAV(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x2AED230", Offset = "0x2AEBC30", VA = "0x182AED230")]
		public static float SOTESFGJHEM(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x2AECCA0", Offset = "0x2AEB6A0", VA = "0x182AECCA0")]
		public static float OBEWMAHZRVF(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x2AECAF0", Offset = "0x2AEB4F0", VA = "0x182AECAF0")]
		public static float GZTWCAVMWLO(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x2AEC9A0", Offset = "0x2AEB3A0", VA = "0x182AEC9A0")]
		public static float CFATQJMTDND(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x2AED270", Offset = "0x2AEBC70", VA = "0x182AED270")]
		public static float VBEXYDNOWLQ(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x2AECC10", Offset = "0x2AEB610", VA = "0x182AECC10")]
		public static float LBAAKYQJNHO(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x2AEC950", Offset = "0x2AEB350", VA = "0x182AEC950")]
		public static float BVGKONJDMQF(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x2AEC9E0", Offset = "0x2AEB3E0", VA = "0x182AEC9E0")]
		public static float EYFLOPPTIPU(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x2AECC60", Offset = "0x2AEB660", VA = "0x182AECC60")]
		public static float NEHFZHJCJSJ(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x2AECAA0", Offset = "0x2AEB4A0", VA = "0x182AECAA0")]
		public static float GHAIAGQCPDE(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x2AECB00", Offset = "0x2AEB500", VA = "0x182AECB00")]
		public static float JOONCFAUMIH(float a)
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
		[Cpp2IlInjected.Address(RVA = "0x2AF04F0", Offset = "0x2AEEEF0", VA = "0x182AF04F0")]
		public bool PLITPLAWNAF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF03F0", Offset = "0x2AEEDF0", VA = "0x182AF03F0")]
		public string HSNPSHEFTMC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF02E0", Offset = "0x2AEECE0", VA = "0x182AF02E0")]
		public static bool FGCJYTKVFEA(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0480", Offset = "0x2AEEE80", VA = "0x182AF0480")]
		private static bool NKTRTXUOPWR(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x2AF03B0", Offset = "0x2AEEDB0", VA = "0x182AF03B0")]
		private bool FGCJYTKVFEA()
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
		[Cpp2IlInjected.Address(RVA = "0x2AF0000", Offset = "0x2AEEA00", VA = "0x182AF0000", Slot = "4")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0080", Offset = "0x2AEEA80", VA = "0x182AF0080")]
		public string HSNPSHEFTMC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0260", Offset = "0x2AEEC60", VA = "0x182AF0260")]
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
		private byte[] JWDIOJGBMTL;

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public byte[] overrideDecryptionKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0560", Offset = "0x2AEEF60", VA = "0x182AF0560", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public KeyAuthData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class VSYGPHPSPCB
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		private class XOOGDBZTKPU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			public RenderTexture WDAORMRDYWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			public long JNQTUOKPIBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			public bool WIWEBBGIOLB;

			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public XOOGDBZTKPU()
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
		private List<XOOGDBZTKPU[]> HSKQXGNTJOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		private MediaPlayer YHWCDJUIZXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		private RenderTexture[] RUWSOSVDGTT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		private int IMXLJITPPOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		private int WJCYLKGLPCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private int SVLPPWQJYTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private long QCRJUUAIEPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		private float EDQIGQWXRQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		private Material QXJICTSXLOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private ResampleMode KRWBEYYJZMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private string WKAPEBUPXWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private long QKDXERLKLCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private int VIEVLVZJXXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private long VUZAMUDVBZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private int QMQAJCFTHNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private long KYNZTSESFYN;

		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private const string DWSEJESRAGW = "_t";

		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private const string DDZIICZPDAV = "_AfterTex";

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private int ONRIYCZGYPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private int AGZLTWFWWNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private float YZKKPNVUIHP;

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		private float PQCATCHMTSS
		{
			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0x169E840", Offset = "0x169D240", VA = "0x18169E840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		private long TXFDAOEJEDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000439")]
			[Cpp2IlInjected.Address(RVA = "0x2AFDF60", Offset = "0x2AFC960", VA = "0x182AFDF60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public Texture[] VFQWWSVZGNE
		{
			[Cpp2IlInjected.Token(Token = "0x600043C")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC570", Offset = "0x2AFAF70", VA = "0x182AFC570")]
		public void CSPRGJMTCAW(MediaPlayer a, MediaPlayerEvent.EventType b, ErrorCode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x2AFECA0", Offset = "0x2AFD6A0", VA = "0x182AFECA0")]
		public VSYGPHPSPCB(MediaPlayer a, string b, int c = 2, ResampleMode d = ResampleMode.LINEAR)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE050", Offset = "0x2AFCA50", VA = "0x182AFE050")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x2AFDF70", Offset = "0x2AFC970", VA = "0x182AFDF70")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD130", Offset = "0x2AFBB30", VA = "0x182AFD130")]
		private void IDUHNEEPMID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC650", Offset = "0x2AFB050", VA = "0x182AFC650")]
		private void DEIAKAVXSPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCD80", Offset = "0x2AFB780", VA = "0x182AFCD80")]
		private bool HUDOBUDMEOY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD540", Offset = "0x2AFBF40", VA = "0x182AFD540")]
		private int KWSKSXAXWAZ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD380", Offset = "0x2AFBD80", VA = "0x182AFD380")]
		private int IOTZIENZTIR(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x2AFDC30", Offset = "0x2AFC630", VA = "0x182AFDC30")]
		private void OSLWFFILEIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCC20", Offset = "0x2AFB620", VA = "0x182AFCC20")]
		private void DIYYIXDKPYN(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC2C0", Offset = "0x2AFACC0", VA = "0x182AFC2C0")]
		private void AVRUUEQETYC(int a, int b, int c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD760", Offset = "0x2AFC160", VA = "0x182AFD760")]
		private void LAPSXIECPTM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEBA0", Offset = "0x2AFD5A0", VA = "0x182AFEBA0")]
		private void WHDCGFCEQDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD990", Offset = "0x2AFC390", VA = "0x182AFD990")]
		private float LBUPSAZDBIW()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE070", Offset = "0x2AFCA70", VA = "0x182AFE070")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC2A0", Offset = "0x2AFACA0", VA = "0x182AFC2A0")]
		public void ABYXXZBADSV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class CKBEDAAIOQC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public int SCOEDYFFAIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public string EUCXFFQWQTP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public double PWZBQBQUXRX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public double CQTGSDHEIWI;

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x2AED380", Offset = "0x2AEBD80", VA = "0x182AED380")]
		public bool MFLKRAPQBXZ(double a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public CKBEDAAIOQC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public class SVEBJIGJQTB
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB640", Offset = "0x2AFA040", VA = "0x182AFB640")]
		private static double VURXLNQQQJE(string a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB240", Offset = "0x2AF9C40", VA = "0x182AFB240")]
		public static List<CKBEDAAIOQC> VKTVNEYWVAJ(string a)
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
		public int JQHSIUZOJPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x2AF0640", Offset = "0x2AEF040", VA = "0x182AF0640")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0670", Offset = "0x2AEF070", VA = "0x182AF0670")]
		public LazyShaderProperty(string name)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class WACHGYKUCXH
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
		public static readonly LazyShaderProperty HYLPIBWJIIO;

		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public static readonly LazyShaderProperty UGOWUYKPMOW;

		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public static readonly LazyShaderProperty ZKHTFXWBWZB;

		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public static readonly LazyShaderProperty FZWDCBZPMJM;

		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public static readonly LazyShaderProperty UFHYYDUZVCW;

		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public static readonly LazyShaderProperty KBMGAWLCFYH;

		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public static readonly LazyShaderProperty JXVIMRAHZMI;

		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public static readonly LazyShaderProperty JGHXQNDOYSR;

		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public static readonly LazyShaderProperty IXKORRTOILJ;

		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public static readonly LazyShaderProperty ZWNWOPZBKPF;

		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public static string XERFPODXQZV;

		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public static readonly LazyShaderProperty YGERWOHBNWX;

		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public static readonly LazyShaderProperty FGOOWGCGDWT;

		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public static readonly LazyShaderProperty IGMULVMLEWF;

		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public static readonly LazyShaderProperty PPDUKTUGBDC;

		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public static readonly LazyShaderProperty BXTYILDANVJ;

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x2B00BF0", Offset = "0x2AFF5F0", VA = "0x182B00BF0")]
		public static Material RZSRTCWBCXZ(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x2B012D0", Offset = "0x2AFFCD0", VA = "0x182B012D0")]
		public static void ZWJZYHQQDAA(Material a, VideoMapping b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF0B0", Offset = "0x2AFDAB0", VA = "0x182AFF0B0")]
		public static void AXFUSTMAZJQ(Material a, StereoPacking b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x2B00AB0", Offset = "0x2AFF4B0", VA = "0x182B00AB0")]
		public static void RQBYHHOXVNG(Material a, AlphaPacking b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x2B00C80", Offset = "0x2AFF680", VA = "0x182B00C80")]
		public static void VVZEMTFISXL(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF9E0", Offset = "0x2AFE3E0", VA = "0x182AFF9E0")]
		public static void DZMBZWDMGAP(Material a, Matrix4x4 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF360", Offset = "0x2AFDD60", VA = "0x182AFF360")]
		public static void CFVIFXMMWPV(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFC60", Offset = "0x2AFE660", VA = "0x182AFFC60")]
		public static Texture GetTexture(MediaPlayer mediaPlayer, int textureIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x2B00D10", Offset = "0x2AFF710", VA = "0x182B00D10")]
		public static void ZFFYTOUDYKT(Material a, MediaPlayer b, int c = -1, [Optional] Texture d, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFDC0", Offset = "0x2AFE7C0", VA = "0x182AFFDC0")]
		internal static void IULAXANKSLM(Material a, bool b, bool c, Matrix4x4 d, Texture e, Matrix4x4 f, VideoMapping g = VideoMapping.Normal, StereoPacking h = StereoPacking.None, AlphaPacking i = AlphaPacking.None)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x2B007D0", Offset = "0x2AFF1D0", VA = "0x182B007D0")]
		public static void KZJNCALIAQQ(Material a, VideoResolveOptions b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF410", Offset = "0x2AFDE10", VA = "0x182AFF410")]
		public static RenderTexture CXAMAMSECPZ(Material a, RenderTexture b, KWNWISOSPDU c, ResolveFlags d, ScaleMode e = ScaleMode.StretchToFill)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFAE0", Offset = "0x2AFE4E0", VA = "0x182AFFAE0")]
		public static void FCTMOUUHZII(AlphaPacking a, StereoPacking b, StereoEye c, float d, Matrix4x4 e, int f, int g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x2B002D0", Offset = "0x2AFECD0", VA = "0x182B002D0")]
		public static void JETDPQKFVYH(Rect a, Texture b, ScaleMode c, AlphaPacking d, float e, Material f)
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
	public class HEAYNJVIRHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		private int JAJBRRMQMWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private int IUUMVFQMASX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private int SYQYTAQCTZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private int RDCLHGYZPGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private int RYYANJOOXJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private CodecType RLGHKCEIATT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private float QPHCNAKFLVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private VideoRange VBBIRHVAUHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private CodecType RAOXAZZFEPA;

		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private static HEAYNJVIRHF QDYKZEMQGNV;

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x2AEFB60", Offset = "0x2AEE560", VA = "0x182AEFB60")]
		public HEAYNJVIRHF(int a, int b, int c, int d, int e = 0, CodecType f = CodecType.unknown, float g = 0f, VideoRange h = VideoRange.SDR, CodecType i = CodecType.unknown)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[DefaultMember("Item")]
	public interface LXLOHRXFROH : IEnumerable
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
