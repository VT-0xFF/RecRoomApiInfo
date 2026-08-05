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
	public Material DMNWOMXIVEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xCD27D0", Offset = "0xCD11D0", VA = "0x180CD27D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2AA0020", Offset = "0x2A9EA20", VA = "0x182AA0020")]
	private void OnWillRenderObject()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xCD14B0", Offset = "0xCCFEB0", VA = "0x180CD14B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xCD8E10", Offset = "0xCD7810", VA = "0x180CD8E10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public MediaPath MediaPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xCD27D0", Offset = "0xCD11D0", VA = "0x180CD27D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public MediaHints Hints
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xEA5C90", Offset = "0xEA4690", VA = "0x180EA5C90")]
			get
			{
				return default(MediaHints);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xEA5DE0", Offset = "0xEA47E0", VA = "0x180EA5DE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE040", Offset = "0x2AACA40", VA = "0x182AAE040")]
		public MediaReference GetCurrentPlatformMediaReference()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE0B0", Offset = "0x2AACAB0", VA = "0x182AAE0B0")]
		public MediaReference GetPlatformMediaReference(Platform platform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE140", Offset = "0x2AACB40", VA = "0x182AAE140")]
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
		private GameObject NRLHUXCLNET;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool HCWASVQWTQJ;

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
		private Texture VHDEAREGZHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private LazyShaderProperty ATWSGHKKZBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private LazyShaderProperty IRBIYOWUKTI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private Texture VMJYEPAVPEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Vector2 PNDLUTUXBFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Vector2 WJWHQXMZWFX;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Color EVQEJIZTHZW
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x1670350", Offset = "0x166ED50", VA = "0x181670350")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x2AA1E50", Offset = "0x2AA0850", VA = "0x182AA1E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Texture TUGQGVVPCTB
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xCD7CF0", Offset = "0xCD66F0", VA = "0x180CD7CF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2AA20A0", Offset = "0x2AA0AA0", VA = "0x182AA20A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Texture UBYOVRPFTTA
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xCD5930", Offset = "0xCD4330", VA = "0x180CD5930")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2AA1B40", Offset = "0x2AA0540", VA = "0x182AA1B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float IZPGZGQYLWQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x12AFDA0", Offset = "0x12AE7A0", VA = "0x1812AFDA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2AA19C0", Offset = "0x2AA03C0", VA = "0x182AA19C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Camera HMSWJTAYWFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xCD5900", Offset = "0xCD4300", VA = "0x180CD5900")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2AA1A70", Offset = "0x2AA0470", VA = "0x182AA1A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public VideoAspectRatio QOMGLRBKZCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xDF8DC0", Offset = "0xDF77C0", VA = "0x180DF8DC0")]
			get
			{
				return default(VideoAspectRatio);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x2AA2160", Offset = "0x2AA0B60", VA = "0x182AA2160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Vector2 KFMRSYXSUFP
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x12AFDB0", Offset = "0x12AE7B0", VA = "0x1812AFDB0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2AA1D70", Offset = "0x2AA0770", VA = "0x182AA1D70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Vector2 JSBSYVLAZFS
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x12AA810", Offset = "0x12A9210", VA = "0x1812AA810")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2AA1C00", Offset = "0x2AA0600", VA = "0x182AA1C00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Texture2D MLHIAQBQTGQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xD00DE0", Offset = "0xCFF7E0", VA = "0x180D00DE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x2AA1CE0", Offset = "0x2AA06E0", VA = "0x182AA1CE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public string GDXTFREMIGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xDA8860", Offset = "0xDA7260", VA = "0x180DA8860")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2AA1FB0", Offset = "0x2AA09B0", VA = "0x182AA1FB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Vector2 KJUGRAXUWPR
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2AA1980", Offset = "0x2AA0380", VA = "0x182AA1980")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2AA1F10", Offset = "0x2AA0910", VA = "0x182AA1F10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Vector2 ZGYOETDZTFY
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2AA19A0", Offset = "0x2AA03A0", VA = "0x182AA19A0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x2AA1F60", Offset = "0x2AA0960", VA = "0x182AA1F60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private Vector2 OPEFLUODRMM
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x2AA14F0", Offset = "0x2A9FEF0", VA = "0x182AA14F0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2A9FF30", Offset = "0x2A9E930", VA = "0x182A9FF30")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2AA0C80", Offset = "0x2A9F680", VA = "0x182AA0C80", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2AA0C30", Offset = "0x2A9F630", VA = "0x182AA0C30")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1330", Offset = "0x2A9FD30", VA = "0x182AA1330")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2AA0230", Offset = "0x2A9EC30", VA = "0x182AA0230")]
		public Mesh CreateQuadMesh()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2AA00D0", Offset = "0x2A9EAD0", VA = "0x182AA00D0")]
		public void CreateMaterial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2AA0D60", Offset = "0x2A9F760", VA = "0x182AA0D60", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xD31DC0", Offset = "0xD307C0", VA = "0x180D31DC0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1070", Offset = "0x2A9FA70", VA = "0x182AA1070")]
		public void UpdateMaterialProperties(int target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2A9F9F0", Offset = "0x2A9E3F0", VA = "0x182A9F9F0", Slot = "8")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2AA0760", Offset = "0x2A9F160", VA = "0x182AA0760")]
		private void KBJSVUSPMXY(Texture a, bool b, int c = 0, Eye d = Eye.Left)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2AA15C0", Offset = "0x2A9FFC0", VA = "0x182AA15C0", Slot = "6")]
		protected override void WJYLXYQDCBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2AA05C0", Offset = "0x2A9EFC0", VA = "0x182AA05C0", Slot = "7")]
		protected override void ISXGXMXWZPR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1800", Offset = "0x2AA0200", VA = "0x182AA1800")]
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
		private Texture VHDEAREGZHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private LazyShaderProperty ATWSGHKKZBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private LazyShaderProperty IRBIYOWUKTI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private Texture VMJYEPAVPEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private Vector2 PNDLUTUXBFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private Vector2 WJWHQXMZWFX;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Texture2D MLHIAQBQTGQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xCDB330", Offset = "0xCD9D30", VA = "0x180CDB330")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x2AA3050", Offset = "0x2AA1A50", VA = "0x182AA3050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Material DMNWOMXIVEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xCDB260", Offset = "0xCD9C60", VA = "0x180CDB260")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x2AA30D0", Offset = "0x2AA1AD0", VA = "0x182AA30D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string GDXTFREMIGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xCD7CF0", Offset = "0xCD66F0", VA = "0x180CD7CF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x2AA31F0", Offset = "0x2AA1BF0", VA = "0x182AA31F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector2 KJUGRAXUWPR
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x2AA3010", Offset = "0x2AA1A10", VA = "0x182AA3010")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x2AA3150", Offset = "0x2AA1B50", VA = "0x182AA3150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Vector2 ZGYOETDZTFY
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x2AA3030", Offset = "0x2AA1A30", VA = "0x182AA3030")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x2AA31A0", Offset = "0x2AA1BA0", VA = "0x182AA31A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xD31DC0", Offset = "0xD307C0", VA = "0x180D31DC0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2210", Offset = "0x2AA0C10", VA = "0x182AA2210", Slot = "8")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2AA28A0", Offset = "0x2AA12A0", VA = "0x182AA28A0")]
		private void KBJSVUSPMXY(Texture a, bool b, int c = 0, Eye d = Eye.Left)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2CB0", Offset = "0x2AA16B0", VA = "0x182AA2CB0", Slot = "6")]
		protected override void WJYLXYQDCBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2730", Offset = "0x2AA1130", VA = "0x182AA2730", Slot = "7")]
		protected override void ISXGXMXWZPR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2EB0", Offset = "0x2AA18B0", VA = "0x182AA2EB0")]
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
		private Texture VHDEAREGZHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private LazyShaderProperty ATWSGHKKZBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private LazyShaderProperty IRBIYOWUKTI;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Texture2D MLHIAQBQTGQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xCDB330", Offset = "0xCD9D30", VA = "0x180CDB330")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x2AA32C0", Offset = "0x2AA1CC0", VA = "0x182AA32C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Renderer OYMTTZRDPYW
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xCDB260", Offset = "0xCD9C60", VA = "0x180CDB260")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x2AA3D90", Offset = "0x2AA2790", VA = "0x182AA3D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public int ELAOUIBLCIT
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xD49670", Offset = "0xD48070", VA = "0x180D49670")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xD4AB40", Offset = "0xD49540", VA = "0x180D4AB40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public string GDXTFREMIGR
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xCD5930", Offset = "0xCD4330", VA = "0x180CD5930")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x2AA41D0", Offset = "0x2AA2BD0", VA = "0x182AA41D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector2 KJUGRAXUWPR
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x2AA3030", Offset = "0x2AA1A30", VA = "0x182AA3030")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x2AA31A0", Offset = "0x2AA1BA0", VA = "0x182AA31A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector2 ZGYOETDZTFY
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x2AA4160", Offset = "0x2AA2B60", VA = "0x182AA4160")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x2AA4180", Offset = "0x2AA2B80", VA = "0x182AA4180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2AA32C0", Offset = "0x2AA1CC0", VA = "0x182AA32C0")]
		private void ALMZLTUBVKY(Texture2D a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3D90", Offset = "0x2AA2790", VA = "0x182AA3D90")]
		private void MHHNCCTWCCH(Renderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xD31DC0", Offset = "0xD307C0", VA = "0x180D31DC0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3370", Offset = "0x2AA1D70", VA = "0x182AA3370", Slot = "8")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2AA38F0", Offset = "0x2AA22F0", VA = "0x182AA38F0")]
		private void KBJSVUSPMXY(Texture a, bool b, int c, Eye d = Eye.Left, int e = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3EA0", Offset = "0x2AA28A0", VA = "0x182AA3EA0", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3E70", Offset = "0x2AA2870", VA = "0x182AA3E70", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3FE0", Offset = "0x2AA29E0", VA = "0x182AA3FE0", Slot = "6")]
		protected override void WJYLXYQDCBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4080", Offset = "0x2AA2A80", VA = "0x182AA4080")]
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
		private const int OMQELXGOLUO = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[Range(0f, 1f)]
		[SerializeField]
		private float[] _channels;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float[] ONWMHYZEDZR
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xCD27D0", Offset = "0xCD11D0", VA = "0x180CD27D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4560", Offset = "0x2AA2F60", VA = "0x182AA4560")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2AA42B0", Offset = "0x2AA2CB0", VA = "0x182AA42B0")]
		private void DOVDAGJXNQC(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2AA43B0", Offset = "0x2AA2DB0", VA = "0x182AA43B0")]
		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xCD14B0", Offset = "0xCCFEB0", VA = "0x180CD14B0")]
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
		private int GAZOWREGNOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private AudioSource LHTMLZQUJDG;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public MediaPlayer DLCLDTZXVDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2AA50B0", Offset = "0x2AA3AB0", VA = "0x182AA50B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public AudioOutputMode NYVJAEUONFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xCD36C0", Offset = "0xCD20C0", VA = "0x180CD36C0")]
			get
			{
				return default(AudioOutputMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xCD36E0", Offset = "0xCD20E0", VA = "0x180CD36E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int PDNLHLDICNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xDF6DB0", Offset = "0xDF57B0", VA = "0x180DF6DB0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x1DEA530", Offset = "0x1DE8F30", VA = "0x181DEA530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2AA45F0", Offset = "0x2AA2FF0", VA = "0x182AA45F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4D70", Offset = "0x2AA3770", VA = "0x182AA4D70")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4BF0", Offset = "0x2AA35F0", VA = "0x182AA4BF0")]
		private void SKOKTSKDXCL(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4BE0", Offset = "0x2AA35E0", VA = "0x182AA4BE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4DF0", Offset = "0x2AA37F0", VA = "0x182AA4DF0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xCDB330", Offset = "0xCD9D30", VA = "0x180CDB330")]
		public AudioSource GetAudioSource()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4CD0", Offset = "0x2AA36D0", VA = "0x182AA4CD0")]
		public void SetAudioSource(AudioSource source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4640", Offset = "0x2AA3040", VA = "0x182AA4640")]
		public void ChangeMediaPlayer(MediaPlayer newPlayer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4B00", Offset = "0x2AA3500", VA = "0x182AA4B00")]
		private void MNIDTEEIANU(MediaPlayer a, MediaPlayerEvent.EventType b, ErrorCode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4ED0", Offset = "0x2AA38D0", VA = "0x182AA4ED0")]
		private static void VWGUBGROMBN(MediaPlayer a, AudioSource b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4B60", Offset = "0x2AA3560", VA = "0x182AA4B60")]
		private void OnAudioFilterRead(float[] audioData, int channelCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5090", Offset = "0x2AA3A90", VA = "0x182AA5090")]
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
		private static Shader MWOZQMYUWUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private Material OSUPYFALTBO;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public MediaPlayer DLCLDTZXVDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x2AA5EA0", Offset = "0x2AA48A0", VA = "0x182AA5EA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public ScaleMode CDZCBTABPMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xCD36C0", Offset = "0xCD20C0", VA = "0x180CD36C0")]
			get
			{
				return default(ScaleMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xCD36E0", Offset = "0xCD20E0", VA = "0x180CD36E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Color SEPYTNPFUCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2AA5E70", Offset = "0x2AA4870", VA = "0x182AA5E70")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x2AA5E90", Offset = "0x2AA4890", VA = "0x182AA5E90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool HYUQECXKMMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xEF1CF0", Offset = "0xEF06F0", VA = "0x180EF1CF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xFA48E0", Offset = "0xFA32E0", VA = "0x180FA48E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool GLWIDZAIAWM
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xFA4550", Offset = "0xFA2F50", VA = "0x180FA4550")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xFA4B60", Offset = "0xFA3560", VA = "0x180FA4B60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public int SMYZWUDBVAN
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xCEED60", Offset = "0xCED760", VA = "0x180CEED60")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xD38DA0", Offset = "0xD377A0", VA = "0x180D38DA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool DWKRBLMXFKQ
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x19AE0A0", Offset = "0x19ACAA0", VA = "0x1819AE0A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x19AE120", Offset = "0x19ACB20", VA = "0x1819AE120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float ROMESNRWSLR
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x1214E40", Offset = "0x1213840", VA = "0x181214E40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2AA5E80", Offset = "0x2AA4880", VA = "0x182AA5E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public float ROGXVGXZJAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xF19550", Offset = "0xF17F50", VA = "0x180F19550")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xF19560", Offset = "0xF17F60", VA = "0x180F19560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float ZJGNDMSUHTF
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xD221A0", Offset = "0xD20BA0", VA = "0x180D221A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x1060140", Offset = "0x105EB40", VA = "0x181060140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float JFEHOTRNLDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x107D3A0", Offset = "0x107BDA0", VA = "0x18107D3A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x107D4F0", Offset = "0x107BEF0", VA = "0x18107D4F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool XCDQCTOTQCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xDE0730", Offset = "0xDDF130", VA = "0x180DE0730")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xDE6AE0", Offset = "0xDE54E0", VA = "0x180DE6AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5B10", Offset = "0x2AA4510", VA = "0x182AA5B10")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5C50", Offset = "0x2AA4650", VA = "0x182AA5C50")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5230", Offset = "0x2AA3C30", VA = "0x182AA5230")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2AA51F0", Offset = "0x2AA3BF0", VA = "0x182AA51F0")]
		private Shader MBUXJVLXPRO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5970", Offset = "0x2AA4370", VA = "0x182AA5970")]
		private void RBJJIEVREDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2AA52D0", Offset = "0x2AA3CD0", VA = "0x182AA52D0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2AA50C0", Offset = "0x2AA3AC0", VA = "0x182AA50C0")]
		public Rect GetAreaRect()
		{
			return default(Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5E40", Offset = "0x2AA4840", VA = "0x182AA5E40")]
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
			[Cpp2IlInjected.Address(RVA = "0x2AAEC00", Offset = "0x2AAD600", VA = "0x182AAEC00", Slot = "4")]
			public virtual string HOFNFTSXSYX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xF74D10", Offset = "0xF73710", VA = "0x180F74D10", Slot = "5")]
			public virtual byte[] XADCAYHSLUE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850", Slot = "6")]
			public virtual bool OEUZFOFHIAN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x2AAEC20", Offset = "0x2AAD620", VA = "0x182AAEC20")]
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
			public QEZWGDGYWQZ.VideoApi videoApi;

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
			public QEZWGDGYWQZ.AudioOutput _audioMode;

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
			[Cpp2IlInjected.Address(RVA = "0xD75C80", Offset = "0xD74680", VA = "0x180D75C80", Slot = "6")]
			public override bool OEUZFOFHIAN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "7")]
			private void DWLXMSUPOAS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x2AAE450", Offset = "0x2AACE50", VA = "0x182AAE450", Slot = "8")]
			private void AVRWMOOOKQW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x2AAE480", Offset = "0x2AACE80", VA = "0x182AAE480")]
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
			public TVPKWQXVAFJ.VideoApi videoApi;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public TVPKWQXVAFJ.AudioOutput _audioMode;

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
			[Cpp2IlInjected.Address(RVA = "0xF1D8E0", Offset = "0xF1C2E0", VA = "0x180F1D8E0", Slot = "6")]
			public override bool OEUZFOFHIAN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x2AAE430", Offset = "0x2AACE30", VA = "0x182AAE430")]
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
			private readonly TextureFormat KNZAOCJRLXR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			private readonly Flags YEEENHVBRNC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public TextureFormat textureFormat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private AudioMode SQBMMHYUNAR;

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
			private ChangeFlags LYMNCXPQJPF;

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
				[Cpp2IlInjected.Address(RVA = "0x2AAE380", Offset = "0x2AACD80", VA = "0x182AAE380")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000065")]
			public Flags flags
			{
				[Cpp2IlInjected.Token(Token = "0x6000145")]
				[Cpp2IlInjected.Address(RVA = "0x2AAE3A0", Offset = "0x2AACDA0", VA = "0x182AAE3A0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x2AAE2D0", Offset = "0x2AACCD0", VA = "0x182AAE2D0")]
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
			private ChangeFlags LYMNCXPQJPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public VideoOutputMode videoOutputMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			private readonly TextureFormat KNZAOCJRLXR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public TextureFormat textureFormat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			[SerializeField]
			private bool _generateMipmaps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			private AudioMode SQBMMHYUNAR;

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
				[Cpp2IlInjected.Address(RVA = "0xD01150", Offset = "0xCFFB50", VA = "0x180D01150")]
				get
				{
					return default(AudioMode);
				}
				[Cpp2IlInjected.Token(Token = "0x6000148")]
				[Cpp2IlInjected.Address(RVA = "0x2AAE2B0", Offset = "0x2AACCB0", VA = "0x182AAE2B0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xCE2D70", Offset = "0xCE1770", VA = "0x180CE2D70", Slot = "6")]
			public override bool OEUZFOFHIAN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "7")]
			private void DWLXMSUPOAS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x2AAE200", Offset = "0x2AACC00", VA = "0x182AAE200", Slot = "8")]
			private void AVRWMOOOKQW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x2AAE230", Offset = "0x2AACC30", VA = "0x182AAE230")]
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
			private ChangeFlags LYMNCXPQJPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private readonly TextureFormat KNZAOCJRLXR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public TextureFormat textureFormat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			[SerializeField]
			private bool _generateMipmapsOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			private AudioMode SQBMMHYUNAR;

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
			[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "7")]
			private void DWLXMSUPOAS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "8")]
			private void AVRWMOOOKQW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x2AAE3D0", Offset = "0x2AACDD0", VA = "0x182AAE3D0")]
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
			private ChangeFlags LYMNCXPQJPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public IFMAUMDSSBX.ExternalLibrary externalLibrary;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public bool useTextureMips;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			private AudioMode SQBMMHYUNAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			[SerializeField]
			private AudioMode _audioMode;

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "4")]
			public override string HOFNFTSXSYX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "5")]
			public override byte[] XADCAYHSLUE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x2AAE420", Offset = "0x2AACE20", VA = "0x182AAE420")]
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
		private sealed class LPZILYJNLQU : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			private int KPYKIUTJAWU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			private object AGGTFEUSTML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public Texture2D GQSPRKBSOJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public MediaPlayer AFKVCRAYCVS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public double OWJRXYOPERI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public int CUITWNXRYZS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public bool OYQJAVHIHOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public ProcessExtractedFrame OTLTFWAVXED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			private Texture2D GOSUHBRMDNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			private int LCYRNBOSQLH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			private int LRFKYNIVFVL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			private int CAFOVCDFMWI;

			[Cpp2IlInjected.Token(Token = "0x17000067")]
			private object ODDPXBAQQIJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000156")]
				[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			private object KXFWSOWDLDQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000158")]
				[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0xCD8B10", Offset = "0xCD7510", VA = "0x180CD8B10")]
			[DebuggerHidden]
			public LPZILYJNLQU(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "5")]
			[DebuggerHidden]
			private void EAMCGMHRBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x2AA6D20", Offset = "0x2AA5720", VA = "0x182AA6D20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x2AA7230", Offset = "0x2AA5C30", VA = "0x182AA7230", Slot = "8")]
			[DebuggerHidden]
			private void VVBIBJOVTIU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class KCCGTWKSRII : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private int KPYKIUTJAWU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private object AGGTFEUSTML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public MediaPlayer AFKVCRAYCVS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			private YieldInstruction XCLLIDVBEWY;

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			private object ODDPXBAQQIJ
			{
				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			private object KXFWSOWDLDQ
			{
				[Cpp2IlInjected.Token(Token = "0x600015E")]
				[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xCD8B10", Offset = "0xCD7510", VA = "0x180CD8B10")]
			[DebuggerHidden]
			public KCCGTWKSRII(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "5")]
			[DebuggerHidden]
			private void EAMCGMHRBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x2AA6BC0", Offset = "0x2AA55C0", VA = "0x182AA6BC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x2AA6CE0", Offset = "0x2AA56E0", VA = "0x182AA6CE0", Slot = "8")]
			[DebuggerHidden]
			private void VVBIBJOVTIU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class ZFNJHVWXKLK : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private int KPYKIUTJAWU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private object AGGTFEUSTML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			public string SCSZOGXKGTX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			public MediaPlayer AFKVCRAYCVS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public MediaPath ZQLXUONPWBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private UnityWebRequest UQSDKKYXNJM;

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			private object ODDPXBAQQIJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000162")]
				[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			private object KXFWSOWDLDQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000164")]
				[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0xCD8B10", Offset = "0xCD7510", VA = "0x180CD8B10")]
			[DebuggerHidden]
			public ZFNJHVWXKLK(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "5")]
			[DebuggerHidden]
			private void EAMCGMHRBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x2AB46A0", Offset = "0x2AB30A0", VA = "0x182AB46A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x2AB4900", Offset = "0x2AB3300", VA = "0x182AB4900", Slot = "8")]
			[DebuggerHidden]
			private void VVBIBJOVTIU()
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
		private AudioSource LHTMLZQUJDG;

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
		private RFOHFWFSOOL.ResampleMode _resampleMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[FormerlySerializedAs("m_ResampleBufferSize")]
		[Range(3f, 10f)]
		[SerializeField]
		private int _resampleBufferSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private RFOHFWFSOOL RFKHWWPSWIM;

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
		protected VXNPJDLEFTM HZEXMNXSMLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private BIUTRNRAOES ZHIBWIEHRAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private BITCXTOTJGQ PIQPEWOJCNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private GGUKCJCFQIZ XCTFFZNZSIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private OEZSXQMPXIQ EVICYZWUBCX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private OSMPAZMAKGO UETCTRHOYWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private OBCJVSDOTLP BDQRNUSUYWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private ZSJSVIZVINU BVKVILYUGRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private JXWEBSUSMXN GYPCAOAHPWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private EPGAHLMGQGA QSXECLWHVRX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private CHWAOZKUFJT ZBOMCCPTFTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private IDisposable HUKKRPCOVAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private bool SJSSRTOJKVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x141")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private bool VEADRRTWGRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x142")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private bool VFFNPDCDDQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private Coroutine HHWBASJHIYP;

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private static bool QXWKSKNYCQG;

		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private static bool HOTBKCZCHJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private MediaPath ESWPSDUBIQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private Coroutine UIOUVYJFWJU;

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static Camera YAISYTADCYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private bool RRJHVSXARLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x161")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private bool PSBRXZQXFZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x162")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private bool EMUYKCRTADV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x163")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private bool IHFPYWOXRBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private bool WASKFIKSSFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x165")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private bool JZXHBBTLGEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x166")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private bool ADFCWYFHPSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x167")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private bool USXUOKJRTVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private int LTKJVVCXKFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private int NLWNBTCINSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private int JMXMBOBZEXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private bool WWKUNVKGCRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x175")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private bool KBCHDETCRVB;

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
		public MediaSource NTMCACGDQXP
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xCE2550", Offset = "0xCE0F50", VA = "0x180CE2550")]
			get
			{
				return default(MediaSource);
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xD251B0", Offset = "0xD23BB0", VA = "0x180D251B0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public MediaReference WAIGFBYUTIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xCD8E20", Offset = "0xCD7820", VA = "0x180CD8E20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xCD27E0", Offset = "0xCD11E0", VA = "0x180CD27E0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MediaPath WCSFXXZJEDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CD0", Offset = "0xCD26D0", VA = "0x180CD3CD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CE0", Offset = "0xCD26E0", VA = "0x180CD3CE0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public MediaHints EHXWETKGHYY
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x1B768A0", Offset = "0x1B752A0", VA = "0x181B768A0")]
			get
			{
				return default(MediaHints);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x1A76880", Offset = "0x1A75280", VA = "0x181A76880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool CRGXKDTQVWP
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x19AE0A0", Offset = "0x19ACAA0", VA = "0x1819AE0A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x19AE120", Offset = "0x19ACB20", VA = "0x1819AE120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool GYXDRFMCBTP
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2763FD0", Offset = "0x27629D0", VA = "0x182763FD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x2764150", Offset = "0x2762B50", VA = "0x182764150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool JVIZZXWUABA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x2AAD7C0", Offset = "0x2AAC1C0", VA = "0x182AAD7C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x2AADCE0", Offset = "0x2AAC6E0", VA = "0x182AADCE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public virtual float NWAKQMPAFDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x2AAD670", Offset = "0x2AAC070", VA = "0x182AAD670", Slot = "6")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x2AADC60", Offset = "0x2AAC660", VA = "0x182AADC60", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float RLMZZPZEICO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x2AAD5B0", Offset = "0x2AABFB0", VA = "0x182AAD5B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x2AADB70", Offset = "0x2AAC570", VA = "0x182AADB70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public virtual bool XMSKVMDKEMZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x2AAD610", Offset = "0x2AAC010", VA = "0x182AAD610", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x2AADBF0", Offset = "0x2AAC5F0", VA = "0x182AADBF0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public AudioSource SOCFBJRAACP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xCD58F0", Offset = "0xCD42F0", VA = "0x180CD58F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xCD5B00", Offset = "0xCD4500", VA = "0x180CD5B00")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float SHBXBAVJOTR
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2AAD850", Offset = "0x2AAC250", VA = "0x182AAD850")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x2AADD80", Offset = "0x2AAC780", VA = "0x182AADD80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool FCXDANHHAVI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xCDB2A0", Offset = "0xCD9CA0", VA = "0x180CDB2A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xCDB350", Offset = "0xCD9D50", VA = "0x180CDB350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public RFOHFWFSOOL.ResampleMode NMCXWGNGRKY
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xDF8DC0", Offset = "0xDF77C0", VA = "0x180DF8DC0")]
			get
			{
				return default(RFOHFWFSOOL.ResampleMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xEEC970", Offset = "0xEEB370", VA = "0x180EEC970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public int CVDACZSQHZO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xEAEDE0", Offset = "0xEAD7E0", VA = "0x180EAEDE0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x2AADDF0", Offset = "0x2AAC7F0", VA = "0x182AADDF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public RFOHFWFSOOL UIQQCIRLNDK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xCDB1B0", Offset = "0xCD9BB0", VA = "0x180CDB1B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public VideoMapping TNVQNZNFGWZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xCF8340", Offset = "0xCF6D40", VA = "0x180CF8340")]
			get
			{
				return default(VideoMapping);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x1610360", Offset = "0x160ED60", VA = "0x181610360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public FilterMode ALHGGKEDOBM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x2AAD9A0", Offset = "0x2AAC3A0", VA = "0x182AAD9A0")]
			get
			{
				return default(FilterMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x2AADE70", Offset = "0x2AAC870", VA = "0x182AADE70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public TextureWrapMode LEBHKSKMKUQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x2AADA80", Offset = "0x2AAC480", VA = "0x182AADA80")]
			get
			{
				return default(TextureWrapMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x2AADEF0", Offset = "0x2AAC8F0", VA = "0x182AADEF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public int EWLWDHJHXHP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x2AAD8B0", Offset = "0x2AAC2B0", VA = "0x182AAD8B0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x2AADE00", Offset = "0x2AAC800", VA = "0x182AADE00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool LNBHUTFVPJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xF91FF0", Offset = "0xF909F0", VA = "0x180F91FF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xF8CE60", Offset = "0xF8B860", VA = "0x180F8CE60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public MediaPath IMETOHUYRDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xD00DE0", Offset = "0xCFF7E0", VA = "0x180D00DE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xF8F1C0", Offset = "0xF8DBC0", VA = "0x180F8F1C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public Transform RUBOVHGXOVS
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xCD76F0", Offset = "0xCD60F0", VA = "0x180CD76F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xCD7630", Offset = "0xCD6030", VA = "0x180CD7630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool EHZQATGRXPF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xDCD6E0", Offset = "0xDCC0E0", VA = "0x180DCD6E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x10CD450", Offset = "0x10CBE50", VA = "0x1810CD450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public Transform TRPAZAIVJGC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xCDA8F0", Offset = "0xCD92F0", VA = "0x180CDA8F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xCDA8D0", Offset = "0xCD92D0", VA = "0x180CDA8D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public float IFOUBRIWEHB
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x10C0570", Offset = "0x10BEF70", VA = "0x1810C0570")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x10C1380", Offset = "0x10BFD80", VA = "0x1810C1380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public float LQSSRFPPWZP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x10BEF50", Offset = "0x10BD950", VA = "0x1810BEF50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x10BEF70", Offset = "0x10BD970", VA = "0x1810BEF70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public HttpHeaderData HPGJIMREZAS
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0xEE3430", Offset = "0xEE1E30", VA = "0x180EE3430")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x17135C0", Offset = "0x1711FC0", VA = "0x1817135C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public KeyAuthData SOGNKDGHWUF
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xEC9840", Offset = "0xEC8240", VA = "0x180EC9840")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xEC9850", Offset = "0xEC8250", VA = "0x180EC9850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public MediaPlayerEvent TPTWEBAKSQF
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x2AAD6D0", Offset = "0x2AAC0D0", VA = "0x182AAD6D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public int HEQQCLAJIGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x10BFC20", Offset = "0x10BE620", VA = "0x1810BFC20")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x10C0430", Offset = "0x10BEE30", VA = "0x1810C0430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public bool XZJKFSGRQOQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x2AAD820", Offset = "0x2AAC220", VA = "0x182AAD820")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x2AADD50", Offset = "0x2AAC750", VA = "0x182AADD50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool KAJSXYSMSPD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x2AAD840", Offset = "0x2AAC240", VA = "0x182AAD840")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x2AADD70", Offset = "0x2AAC770", VA = "0x182AADD70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool ZFQXKWPQBQN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x2AAD830", Offset = "0x2AAC230", VA = "0x182AAD830")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x2AADD60", Offset = "0x2AAC760", VA = "0x182AADD60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public FileFormat FOYYOWLBQZE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0xDCD650", Offset = "0xDCC050", VA = "0x180DCD650")]
			get
			{
				return default(FileFormat);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x1992620", Offset = "0x1991020", VA = "0x181992620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public virtual GGUKCJCFQIZ TJDMWTSHMUI
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xE4FC60", Offset = "0xE4E660", VA = "0x180E4FC60", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public virtual BIUTRNRAOES NOSESECANRL
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xF4A640", Offset = "0xF49040", VA = "0x180F4A640", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public virtual OEZSXQMPXIQ DLCLDTZXVDP
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xEF5240", Offset = "0xEF3C40", VA = "0x180EF5240", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public virtual BITCXTOTJGQ RFYGYZJPGON
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xF4A650", Offset = "0xF49050", VA = "0x180F4A650", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual OSMPAZMAKGO DIERPRIZBOB
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xF4A610", Offset = "0xF49010", VA = "0x180F4A610", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public virtual ZSJSVIZVINU YBBXHBHQDWP
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xF4A5F0", Offset = "0xF48FF0", VA = "0x180F4A5F0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual JXWEBSUSMXN UOKWCXCWIVI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xD4C370", Offset = "0xD4AD70", VA = "0x180D4C370", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual EPGAHLMGQGA BFDPXUXXOWX
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xD4C360", Offset = "0xD4AD60", VA = "0x180D4C360", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual CHWAOZKUFJT DZYZSDAPTOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xD4C1C0", Offset = "0xD4ABC0", VA = "0x180D4C1C0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public virtual OBCJVSDOTLP XLNMELFWCOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xE66AE0", Offset = "0xE654E0", VA = "0x180E66AE0", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool DKEEISUQUGF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x1685980", Offset = "0x1684380", VA = "0x181685980")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public OptionsWindows MYGADBXZQLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0xD97C40", Offset = "0xD96640", VA = "0x180D97C40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public OptionsApple MEKCHTJLBAV
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xF4A4C0", Offset = "0xF48EC0", VA = "0x180F4A4C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public OptionsApple MCIWZBFYEQR
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0xF4A4B0", Offset = "0xF48EB0", VA = "0x180F4A4B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public OptionsApple GCUGDHMIMWA
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0xF4A500", Offset = "0xF48F00", VA = "0x180F4A500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public OptionsApple CWXTFFGFODY
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0xF4A4D0", Offset = "0xF48ED0", VA = "0x180F4A4D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public OptionsAndroid HIGPAQXOMNI
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0xE1A9C0", Offset = "0xE193C0", VA = "0x180E1A9C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public OptionsOpenHarmony FRUPOPBZJCL
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0xF4A700", Offset = "0xF49100", VA = "0x180F4A700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public OptionsWindowsUWP QWVQTYKZJXO
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0xF4A740", Offset = "0xF49140", VA = "0x180F4A740")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public OptionsWebGL IUMSAFJKKBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xF4A730", Offset = "0xF49130", VA = "0x180F4A730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xD251B0", Offset = "0xD23BB0", VA = "0x180D251B0")]
		public void SetMediaSource(MediaSource source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xCD27E0", Offset = "0xCD11E0", VA = "0x180CD27E0")]
		public void SetMediaReference(MediaReference media)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xCD3CE0", Offset = "0xCD26E0", VA = "0x180CD3CE0")]
		public void SetMediaPath(MediaPath path)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xCD5B00", Offset = "0xCD4500", VA = "0x180CD5B00")]
		public void SetAudioSource(AudioSource audioSource)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7A10", Offset = "0x2AA6410", VA = "0x182AA7A10")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2AABBA0", Offset = "0x2AAA5A0", VA = "0x182AABBA0")]
		protected void TQMTECAGLGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2AABA30", Offset = "0x2AAA430", VA = "0x182AABA30")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA950", Offset = "0x2AA9350", VA = "0x182AAA950")]
		public bool OpenMedia(MediaPath path, bool autoPlay = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA850", Offset = "0x2AA9250", VA = "0x182AAA850")]
		public bool OpenMedia(MediaPathType pathType, string path, bool autoPlay = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA900", Offset = "0x2AA9300", VA = "0x182AAA900")]
		public bool OpenMedia(MediaReference mediaReference, bool autoPlay = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA8D0", Offset = "0x2AA92D0", VA = "0x182AAA8D0")]
		public bool OpenMedia(bool autoPlay = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9990", Offset = "0x2AA8390", VA = "0x182AA9990")]
		private bool LIXAMYTBOBV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2AAAD00", Offset = "0x2AA9700", VA = "0x182AAAD00")]
		private void SESKLFYMMMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8C60", Offset = "0x2AA7660", VA = "0x182AA8C60")]
		private void FTWLTEVKFYB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7C90", Offset = "0x2AA6690", VA = "0x182AA7C90")]
		public void CloseMedia()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2AAAAD0", Offset = "0x2AA94D0", VA = "0x182AAAAD0", Slot = "20")]
		public virtual void Play()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2AAAA50", Offset = "0x2AA9450", VA = "0x182AAAA50", Slot = "21")]
		public virtual void Pause()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2AABB40", Offset = "0x2AAA540", VA = "0x182AABB40")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2AAAC80", Offset = "0x2AA9680", VA = "0x182AAAC80")]
		public void Rewind(bool pause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB870", Offset = "0x2AAA270", VA = "0x182AAB870")]
		public void SeekToLiveTime(double offset = 0.0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2AAC710", Offset = "0x2AAB110", VA = "0x182AAC710", Slot = "22")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA000", Offset = "0x2AA8A00", VA = "0x182AAA000")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9380", Offset = "0x2AA7D80", VA = "0x182AA9380")]
		private void IKPHGVXJRSQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA710", Offset = "0x2AA9110", VA = "0x182AAA710")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA650", Offset = "0x2AA9050", VA = "0x182AAA650")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA4D0", Offset = "0x2AA8ED0", VA = "0x182AAA4D0", Slot = "23")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8D90", Offset = "0x2AA7790", VA = "0x182AA8D90")]
		public void ForceDispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9770", Offset = "0x2AA8170", VA = "0x182AA9770")]
		private static void JNJASFSIDIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA290", Offset = "0x2AA8C90", VA = "0x182AAA290")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8BA0", Offset = "0x2AA75A0", VA = "0x182AA8BA0")]
		protected void FNIWSDTCFZE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB130", Offset = "0x2AA9B30", VA = "0x182AAB130")]
		private void SSOKAKKJVKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2AACB50", Offset = "0x2AAB550", VA = "0x182AACB50")]
		[IteratorStateMachine(typeof(KCCGTWKSRII))]
		private IEnumerator WZZPWHENNNQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0")]
		public static Platform GetPlatform()
		{
			return default(Platform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xD97C40", Offset = "0xD96640", VA = "0x180D97C40")]
		public PlatformOptions GetCurrentPlatformOptions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2AAAC10", Offset = "0x2AA9610", VA = "0x182AAAC10")]
		private string QERWZIEFTNV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0")]
		private long WOCYKNPAWYS()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9480", Offset = "0x2AA7E80", VA = "0x182AA9480")]
		private string IUAERJCRGYC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9FA0", Offset = "0x2AA89A0", VA = "0x182AA9FA0")]
		private string LQSMFEUXKYV(string a, MediaPathType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2AACFC0", Offset = "0x2AAB9C0", VA = "0x182AACFC0")]
		private static VXNPJDLEFTM ZQUQYAJZTXP(OptionsWindows a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7590", Offset = "0x2AA5F90", VA = "0x182AA7590")]
		private static VXNPJDLEFTM ABLQMUYTMRG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7E00", Offset = "0x2AA6800", VA = "0x182AA7E00", Slot = "24")]
		public virtual VXNPJDLEFTM CreateMediaPlayer()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9530", Offset = "0x2AA7F30", VA = "0x182AA9530")]
		private void IWUWPVZSHHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA140", Offset = "0x2AA8B40", VA = "0x182AAA140")]
		private void OPBGWRKXFRT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2AACE50", Offset = "0x2AAB850", VA = "0x182AACE50")]
		private void ZQGNTVGYXHU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850")]
		public bool IsUsingAndroidOESPath()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850")]
		public bool IsUsingYCbCr()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB580", Offset = "0x2AA9F80", VA = "0x182AAB580")]
		[ContextMenu("Save Frame To PNG")]
		public void SaveFrameToPng()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB180", Offset = "0x2AA9B80", VA = "0x182AAB180")]
		[ContextMenu("Save Frame To EXR")]
		public void SaveFrameToExr()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		private void OnApplicationFocus(bool focusStatus)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2AA81A0", Offset = "0x2AA6BA0", VA = "0x182AA81A0")]
		private void DPIHLSCOTMS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA980", Offset = "0x2AA9380", VA = "0x182AAA980")]
		private void PPHJGVWMXUT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2AA92F0", Offset = "0x2AA7CF0", VA = "0x182AA92F0")]
		private void GWUOIBENAIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8E60", Offset = "0x2AA7860", VA = "0x182AA8E60")]
		private void GIEGIJHUKKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2AACBC0", Offset = "0x2AAB5C0", VA = "0x182AACBC0")]
		private void XBBWJIOYGLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9960", Offset = "0x2AA8360", VA = "0x182AA9960")]
		protected bool KSLIZJCRWDQ(MediaPlayerEvent.EventType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2AA98D0", Offset = "0x2AA82D0", VA = "0x182AA98D0")]
		private bool KKLFFFPMMFK(MediaPlayerEvent.EventType a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2AAC1A0", Offset = "0x2AAABA0", VA = "0x182AAC1A0")]
		private bool UMYNUPXWAUO(MediaPlayerEvent.EventType a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2AAAF70", Offset = "0x2AA9970", VA = "0x182AAAF70")]
		private bool SGWAIVYBRJM(int a, float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2AA82A0", Offset = "0x2AA6CA0", VA = "0x182AA82A0")]
		private static Camera EHBFUANTQKP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2AACD80", Offset = "0x2AAB780", VA = "0x182AACD80")]
		[IteratorStateMachine(typeof(LPZILYJNLQU))]
		private IEnumerator YXTRLJAMGOM(Texture2D a, ProcessExtractedFrame b, double c = -1.0, bool d = true, int e = 1000, int f = 100)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8950", Offset = "0x2AA7350", VA = "0x182AA8950")]
		public void ExtractFrameAsync(Texture2D target, ProcessExtractedFrame callback, double timeSeconds = -1.0, bool accurateSeek = true, int timeoutMs = 1000, int timeThresholdMs = 100)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8A20", Offset = "0x2AA7420", VA = "0x182AA8A20")]
		public Texture2D ExtractFrame(Texture2D target, double timeSeconds = -1.0, bool accurateSeek = true, int timeoutMs = 1000, int timeThresholdMs = 100)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2AA90A0", Offset = "0x2AA7AA0", VA = "0x182AA90A0")]
		private Texture GWEQOYSDSPA(double a = -1.0, bool b = true, int c = 1000, int d = 100)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA790", Offset = "0x2AA9190", VA = "0x182AAA790")]
		public bool OpenMediaFromBuffer(byte[] buffer, bool autoPlay = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB970", Offset = "0x2AAA370", VA = "0x182AAB970")]
		public bool StartOpenChunkedMediaFromBuffer(ulong length, bool autoPlay = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2AA78F0", Offset = "0x2AA62F0", VA = "0x182AA78F0")]
		public bool AddChunkToVideoBuffer(byte[] chunk, ulong offset, ulong chunkSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2AA88D0", Offset = "0x2AA72D0", VA = "0x182AA88D0")]
		public bool EndOpenChunkedVideoFromBuffer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7A80", Offset = "0x2AA6480", VA = "0x182AA7A80")]
		private bool CYLRJLFBPCX(byte[] a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2AA76E0", Offset = "0x2AA60E0", VA = "0x182AA76E0")]
		private bool AYNFZXGOFBN(ulong a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2AA78F0", Offset = "0x2AA62F0", VA = "0x182AA78F0")]
		private bool PXWKSLHGSGO(byte[] a, ulong b, ulong c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2AA88D0", Offset = "0x2AA72D0", VA = "0x182AA88D0")]
		private bool SXKRBWHJGCM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8500", Offset = "0x2AA6F00", VA = "0x182AA8500")]
		public bool EnableSubtitles(MediaPath mediaPath)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2AAAB60", Offset = "0x2AA9560", VA = "0x182AAAB60")]
		[IteratorStateMachine(typeof(ZFNJHVWXKLK))]
		private IEnumerator QBSTBWSRAEN(string a, MediaPath b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2AA81D0", Offset = "0x2AA6BD0", VA = "0x182AA81D0")]
		public void DisableSubtitles()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "4")]
		private void DWLXMSUPOAS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2AA75E0", Offset = "0x2AA5FE0", VA = "0x182AA75E0", Slot = "5")]
		private void AVRWMOOOKQW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2AAD100", Offset = "0x2AABB00", VA = "0x182AAD100")]
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
			public HIUUMHNYSHL.Preset overrideTransitionEasing;

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x2AA7270", Offset = "0x2AA5C70", VA = "0x182AA7270")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2AADF60", Offset = "0x2AAC960", VA = "0x182AADF60")]
		public bool VMWANMLPJHM(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2AADFC0", Offset = "0x2AAC9C0", VA = "0x182AADFC0")]
		public MediaPlaylist()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[AddComponentMenu("AVPro Video/Playlist Media Player", -80)]
	[HelpURL("https://www.renderheads.com/products/avpro-video/")]
	public class PlaylistMediaPlayer : MediaPlayer, BITCXTOTJGQ
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
		private sealed class PUEGIEOGMPU : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			private int KPYKIUTJAWU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			private object AGGTFEUSTML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public PlaylistMediaPlayer AFKVCRAYCVS;

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			private object ODDPXBAQQIJ
			{
				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			private object KXFWSOWDLDQ
			{
				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xCD8B10", Offset = "0xCD7510", VA = "0x180CD8B10")]
			[DebuggerHidden]
			public PUEGIEOGMPU(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "5")]
			[DebuggerHidden]
			private void EAMCGMHRBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x2AAE540", Offset = "0x2AACF40", VA = "0x182AAE540", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x2AAEBC0", Offset = "0x2AAD5C0", VA = "0x182AAEBC0", Slot = "8")]
			[DebuggerHidden]
			private void VVBIBJOVTIU()
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
		private HIUUMHNYSHL.Preset _defaultTransitionEasing;

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
		private static readonly LazyShaderProperty ONTVJWWKHVY;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private static readonly LazyShaderProperty IPTWKHJPVMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20D")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private bool DKUYHFSSPRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private int XQKDMRTVKAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private MediaPlayer NJBXHHAHYRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private Material OSUPYFALTBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private Transition WGXGFAPJNYJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private string DOTLCTHFDGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private float HWTSUHMIFZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23C")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private HIUUMHNYSHL.Preset DUXRYDVUNXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private float IKEFAICVNHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private Func<float, float> MILSTKPZLGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private RenderTexture SMYIYAPLZHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private MediaPlaylist.MediaItem ZQWUOJVCMRT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private MediaPlaylist.MediaItem WERGVNGQNGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private WaitForEndOfFrame SKZOPNFJMES;

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public MediaPlayer CQGRLMFHZQA
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x2AB19A0", Offset = "0x2AB03A0", VA = "0x182AB19A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public MediaPlayer LADOGWCZBUE
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xF4A4A0", Offset = "0xF48EA0", VA = "0x180F4A4A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public MediaPlaylist MWYSFMQJDPA
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xD979D0", Offset = "0xD963D0", VA = "0x180D979D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public int IMWONPRVZKO
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x259EEE0", Offset = "0x259D8E0", VA = "0x18259EEE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public MediaPlaylist.MediaItem NZHOFMJLIUB
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1AF0", Offset = "0x2AB04F0", VA = "0x182AB1AF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Transition DFINXCYNFOW
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x1651CF0", Offset = "0x16506F0", VA = "0x181651CF0")]
			get
			{
				return default(Transition);
			}
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x163B3B0", Offset = "0x1639DB0", VA = "0x18163B3B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public float PXMVVXRDJLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x1CCCA20", Offset = "0x1CCB420", VA = "0x181CCCA20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x1CCE370", Offset = "0x1CCCD70", VA = "0x181CCE370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public HIUUMHNYSHL.Preset UZIJCNMVLJZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x243F820", Offset = "0x243E220", VA = "0x18243F820")]
			get
			{
				return default(HIUUMHNYSHL.Preset);
			}
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x2881500", Offset = "0x287FF00", VA = "0x182881500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public bool FLGWAYFTLCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x10C0AF0", Offset = "0x10BF4F0", VA = "0x1810C0AF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x1653290", Offset = "0x1651C90", VA = "0x181653290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public PlaylistLoopMode XUTUULWNPJT
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1AE0", Offset = "0x2AB04E0", VA = "0x182AB1AE0")]
			get
			{
				return default(PlaylistLoopMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x237A6B0", Offset = "0x23790B0", VA = "0x18237A6B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public bool GYZZUVHEASY
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x10BFEF0", Offset = "0x10BE8F0", VA = "0x1810BFEF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x1653600", Offset = "0x1652000", VA = "0x181653600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public override GGUKCJCFQIZ TJDMWTSHMUI
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1A40", Offset = "0x2AB0440", VA = "0x182AB1A40", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public override BIUTRNRAOES NOSESECANRL
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1900", Offset = "0x2AB0300", VA = "0x182AB1900", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public override BITCXTOTJGQ RFYGYZJPGON
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xDF4FD0", Offset = "0xDF39D0", VA = "0x180DF4FD0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public override float NWAKQMPAFDO
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x1CCDDE0", Offset = "0x1CCC7E0", VA = "0x181CCDDE0", Slot = "6")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1C80", Offset = "0x2AB0680", VA = "0x182AB1C80", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public override bool XMSKVMDKEMZ
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x10C1370", Offset = "0x10BFD70", VA = "0x1810C1370", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1BB0", Offset = "0x2AB05B0", VA = "0x182AB1BB0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2AB0CE0", Offset = "0x2AAF6E0", VA = "0x182AB0CE0", Slot = "20")]
		public override void Play()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2AB0BD0", Offset = "0x2AAF5D0", VA = "0x182AB0BD0", Slot = "21")]
		public override void Pause()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x10C0B00", Offset = "0x10BF500", VA = "0x1810C0B00")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2AB1630", Offset = "0x2AB0030", VA = "0x182AB1630")]
		[IteratorStateMachine(typeof(PUEGIEOGMPU))]
		private IEnumerator YTUIAPWFQOT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2AAEE50", Offset = "0x2AAD850", VA = "0x182AAEE50")]
		private Texture BGTBBLUOIUD(int a = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2AAFE30", Offset = "0x2AAE830", VA = "0x182AAFE30")]
		private Texture IMULUHOZSLS(int a = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2AAECC0", Offset = "0x2AAD6C0", VA = "0x182AAECC0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2AB03A0", Offset = "0x2AAEDA0", VA = "0x182AB03A0", Slot = "23")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2AB0EA0", Offset = "0x2AAF8A0", VA = "0x182AB0EA0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2AB0640", Offset = "0x2AAF040", VA = "0x182AB0640")]
		public void OnMediaPlayerEvent(MediaPlayer mediaPlayer, MediaPlayerEvent.EventType eventType, ErrorCode errorCode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2AB0DF0", Offset = "0x2AAF7F0", VA = "0x182AB0DF0")]
		public bool PrevItem()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2AB0320", Offset = "0x2AAED20", VA = "0x182AB0320")]
		public bool NextItem()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2AAEF60", Offset = "0x2AAD960", VA = "0x182AAEF60")]
		public bool CanJumpToItem(int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2AB01E0", Offset = "0x2AAEBE0", VA = "0x182AB01E0")]
		public bool JumpToItem(int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2AB0800", Offset = "0x2AAF200", VA = "0x182AB0800")]
		public void OpenVideoFile(MediaPlaylist.MediaItem mediaItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF030", Offset = "0x2AADA30", VA = "0x182AAF030")]
		private bool GUJIZTXEQOF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2AAFAC0", Offset = "0x2AAE4C0", VA = "0x182AAFAC0")]
		private void HKREOTTPWCD(Transition a, float b, HIUUMHNYSHL.Preset c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2AB10E0", Offset = "0x2AAFAE0", VA = "0x182AB10E0", Slot = "22")]
		protected override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF8A0", Offset = "0x2AAE2A0", VA = "0x182AAF8A0", Slot = "26")]
		public Texture GetTexture(int index = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF320", Offset = "0x2AADD20", VA = "0x182AAF320", Slot = "25")]
		public int GetTextureCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF3C0", Offset = "0x2AADDC0", VA = "0x182AAF3C0", Slot = "27")]
		public int GetTextureFrameCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2AB1040", Offset = "0x2AAFA40", VA = "0x182AB1040", Slot = "28")]
		public bool SupportsTextureFrameCount()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF6E0", Offset = "0x2AAE0E0", VA = "0x182AAF6E0", Slot = "29")]
		public long GetTextureTimeStamp()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF590", Offset = "0x2AADF90", VA = "0x182AAF590", Slot = "30")]
		public float GetTexturePixelAspectRatio()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2AB0E00", Offset = "0x2AAF800", VA = "0x182AB0E00", Slot = "31")]
		public bool RequiresVerticalFlip()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF990", Offset = "0x2AAE390", VA = "0x182AAF990", Slot = "35")]
		public Matrix4x4 GetYpCbCrTransform()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF640", Offset = "0x2AAE040", VA = "0x182AAF640", Slot = "32")]
		public StereoPacking GetTextureStereoPacking()
		{
			return default(StereoPacking);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF800", Offset = "0x2AAE200", VA = "0x182AAF800", Slot = "33")]
		public TransparencyMode GetTextureTransparency()
		{
			return default(TransparencyMode);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF280", Offset = "0x2AADC80", VA = "0x182AAF280", Slot = "34")]
		public AlphaPacking GetTextureAlphaPacking()
		{
			return default(AlphaPacking);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF050", Offset = "0x2AADA50", VA = "0x182AAF050", Slot = "36")]
		public float[] GetAffineTransform()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF460", Offset = "0x2AADE60", VA = "0x182AAF460", Slot = "37")]
		public Matrix4x4 GetTextureMatrix()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF140", Offset = "0x2AADB40", VA = "0x182AAF140", Slot = "38")]
		public RenderTextureFormat GetCompatibleRenderTextureFormat(GetCompatibleRenderTextureFormatOptions options, int plane)
		{
			return default(RenderTextureFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x2AAFF20", Offset = "0x2AAE920", VA = "0x182AAFF20")]
		private static string JBJQCAWVYYQ(Transition a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x2AB1770", Offset = "0x2AB0170", VA = "0x182AB1770")]
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
		private ZNNBKSPQQBJ.ResolveFlags _resolveFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[SerializeField]
		private RenderTexture _externalTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private Material HTKZXNJOGAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private bool SRSHUIKZQEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x71")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private bool NHHMOTZDMME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x72")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private bool IWBGQLXJRVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private RenderTexture FELYGNVFLVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private int JPKJSSHOSEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private Material MBDSAOPBOUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private int ZMCSMNRGXKL;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public MediaPlayer ZMOMMVCLZCN
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x2AB26F0", Offset = "0x2AB10F0", VA = "0x182AB26F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public VideoResolveOptions ISNZXIGRPCJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x2AB2860", Offset = "0x2AB1260", VA = "0x182AB2860")]
			get
			{
				return default(VideoResolveOptions);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x2AB2880", Offset = "0x2AB1280", VA = "0x182AB2880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public RenderTexture OODZFXZUSDM
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xCD5900", Offset = "0xCD4300", VA = "0x180CD5900")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xCD5920", Offset = "0xCD4320", VA = "0x180CD5920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public RenderTexture JYEPPVNKABC
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x2AB27E0", Offset = "0x2AB11E0", VA = "0x182AB27E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2580", Offset = "0x2AB0F80", VA = "0x182AB2580")]
		public void SetMaterialDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x2AB26F0", Offset = "0x2AB10F0", VA = "0x182AB26F0")]
		private void ZOLLVEBXTTL(MediaPlayer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2590", Offset = "0x2AB0F90", VA = "0x182AB2590")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2AB1D70", Offset = "0x2AB0770", VA = "0x182AB1D70")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x2AB1EA0", Offset = "0x2AB08A0", VA = "0x182AB1EA0")]
		public void Resolve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x2AB1E20", Offset = "0x2AB0820", VA = "0x182AB1E20")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2AB1D80", Offset = "0x2AB0780", VA = "0x182AB1D80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2790", Offset = "0x2AB1190", VA = "0x182AB2790")]
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
		private static readonly LazyShaderProperty UKKDXYWCAUX;

		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private static readonly LazyShaderProperty OXBKMEVFPXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private Camera RGHAHGOQUCY;

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Camera HMSWJTAYWFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0xCD27D0", Offset = "0xCD11D0", VA = "0x180CD27D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2AB28A0", Offset = "0x2AB12A0", VA = "0x182AB28A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2D20", Offset = "0x2AB1720", VA = "0x182AB2D20")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2D30", Offset = "0x2AB1730", VA = "0x182AB2D30")]
		private void TJQJUSJHYAY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2AB3070", Offset = "0x2AB1A70", VA = "0x182AB3070")]
		private static bool VVTEILZNDOF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2940", Offset = "0x2AB1340", VA = "0x182AB2940")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xCD14B0", Offset = "0xCCFEB0", VA = "0x180CD14B0")]
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
		protected bool YBECMKVLTSX;

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public MediaPlayer DLCLDTZXVDP
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x2A9F9D0", Offset = "0x2A9E3D0", VA = "0x182A9F9D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public bool KWPXCCEZPHM
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xD67E50", Offset = "0xD66850", VA = "0x180D67E50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x2A9F9B0", Offset = "0x2A9E3B0", VA = "0x182A9F9B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public StereoPacking FPZOXKRBTXN
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xDF6DB0", Offset = "0xDF57B0", VA = "0x180DF6DB0")]
			get
			{
				return default(StereoPacking);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x2A9F9C0", Offset = "0x2A9E3C0", VA = "0x182A9F9C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public bool GXDITIIDOWT
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xD2E420", Offset = "0xD2CE20", VA = "0x180D2E420")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x2A9F9E0", Offset = "0x2A9E3E0", VA = "0x182A9F9E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x2A9F6D0", Offset = "0x2A9E0D0", VA = "0x182A9F6D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x2A9F800", Offset = "0x2A9E200", VA = "0x182A9F800")]
		private void ZOLLVEBXTTL(MediaPlayer a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x2A9F720", Offset = "0x2A9E120", VA = "0x182A9F720")]
		private void MNIDTEEIANU(MediaPlayer a, MediaPlayerEvent.EventType b, ErrorCode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x2A9F6E0", Offset = "0x2A9E0E0", VA = "0x182A9F6E0")]
		public void ForceUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x2A9F7C0", Offset = "0x2A9E1C0", VA = "0x182A9F7C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x2A9F770", Offset = "0x2A9E170", VA = "0x182A9F770", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x1AD6DC0", Offset = "0x1AD57C0", VA = "0x181AD6DC0", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x2A9F760", Offset = "0x2A9E160", VA = "0x182A9F760")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "6")]
		protected virtual void WJYLXYQDCBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "7")]
		protected virtual void ISXGXMXWZPR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void Apply();

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x18AB7F0", Offset = "0x18AA1F0", VA = "0x1818AB7F0")]
		protected ApplyToBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class EMZKSNLWEOC
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		protected class PWDWUCCVSQW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public HashSet<AudioOutput> MXZFAIJEBFY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public float[] QEVFESIATDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public bool NRSSRSXBETR;

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public PWDWUCCVSQW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private static EMZKSNLWEOC YAMBAODJEJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private Dictionary<int, PWDWUCCVSQW> LPCRDRGCQBN;

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public static EMZKSNLWEOC IWMDTGRRYAH
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x2AA6000", Offset = "0x2AA4A00", VA = "0x182AA6000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x2AA6B40", Offset = "0x2AA5540", VA = "0x182AA6B40")]
		private EMZKSNLWEOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5F10", Offset = "0x2AA4910", VA = "0x182AA5F10")]
		public void HIRIMJPGIBP(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x2AA6210", Offset = "0x2AA4C10", VA = "0x182AA6210")]
		public void UCRJITOXDYC(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x2AA6290", Offset = "0x2AA4C90", VA = "0x182AA6290")]
		public void UJJLZNCGDFD(AudioOutput a, MediaPlayer b, int c, float[] d, int e, int f, AudioOutput.AudioOutputMode g, bool h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5ED0", Offset = "0x2AA48D0", VA = "0x182AA5ED0")]
		private void BJUWMUICUAA(float[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x2AA6100", Offset = "0x2AA4B00", VA = "0x182AA6100")]
		private bool SZIEHYNENVK(MediaPlayer a, float[] b, int c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[DefaultMember("Item")]
	public abstract class VXNPJDLEFTM : OEZSXQMPXIQ, BIUTRNRAOES, GGUKCJCFQIZ, OBCJVSDOTLP, BITCXTOTJGQ, OSMPAZMAKGO, ZSJSVIZVINU, JXWEBSUSMXN, EPGAHLMGQGA, CHWAOZKUFJT, IEnumerable, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		protected string PWHWHLRLRXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		protected ErrorCode BVFPHNAYFKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		protected FilterMode QBQYSJSQPVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		protected TextureWrapMode SOAEDTJYRTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		protected int XNYIJLZTYZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		protected MediaHints QHTMPIJIIMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		protected KMZFOCKIWSH SBIIOUEURER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		protected KMZFOCKIWSH QUIOAXEBVDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private float UXCIPIIKYXK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private int HMNAMKYEMDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private float QZIIMJJHETF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private float BJAVKLXAWSR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private int AOZUODUYBGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private int AFJNGGJNAAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		protected List<QCGBEZDDIHS> KUCAJHNOBVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		protected QCGBEZDDIHS LEZEOTUERYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		protected EOSYWBONIEF OSZPFTRIJRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		protected OJJINBFNGPY YNYTKBYLMRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		protected YBBXHBHQDWP ZXHHUOAUSTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		protected UOKWCXCWIVI KJGLJDBWIXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		protected BFDPXUXXOWX AFWGTUAUCLQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		protected ZJOEQNGJUJR[] EOPGVDJQSRT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		protected List<OSDBZHPXMWB> RZEADFULLUH;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4350", Offset = "0x2AB2D50", VA = "0x182AB4350")]
		public VXNPJDLEFTM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "82")]
		public abstract string AHETNTWHPFW();

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "83")]
		public abstract string UFAPALQYUKY();

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "84")]
		public abstract bool JKZKLSNRQOE(string a, long b, string c, MediaHints d, int e = 0, bool f = false);

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850", Slot = "85")]
		public virtual bool FEJERNCEUVA(byte[] a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850", Slot = "86")]
		public virtual bool FRAHOUFBPYS(ulong a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850", Slot = "87")]
		public virtual bool RTQYTAWXWEZ(byte[] a, ulong b, ulong c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850", Slot = "88")]
		public virtual bool KLNDWCALZVX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x2AB35E0", Offset = "0x2AB1FE0", VA = "0x182AB35E0", Slot = "89")]
		public virtual void GDKWKQUFVIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(Slot = "90")]
		public abstract void YXMFDJSLGTQ(bool a);

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "91")]
		public abstract bool GRYZVKKGWVE();

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(Slot = "92")]
		public abstract bool IMTROIUPSJH();

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "93")]
		public abstract bool ADPQVRDGJQU();

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
		[Cpp2IlInjected.Address(RVA = "0x2AB3BD0", Offset = "0x2AB25D0", VA = "0x182AB3BD0", Slot = "97")]
		public virtual void MBSYENUJZMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(Slot = "98")]
		public abstract void WGCAAYXZUAE(double a);

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(Slot = "99")]
		public abstract void SCYJILLDPPA(double a);

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(Slot = "100")]
		public abstract double OLZCDPPWKKY();

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(Slot = "101")]
		public abstract float ISQHRDOFHWT();

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(Slot = "102")]
		public abstract void HQPFIZSADBB(float a);

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(Slot = "103")]
		public abstract double GYHKTZCHFKQ();

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(Slot = "104")]
		public abstract int CQRSOKMXLKN();

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(Slot = "105")]
		public abstract int TZOQMCELHFW();

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(Slot = "106")]
		public abstract float FWVXCBKZMRY();

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(Slot = "107")]
		public abstract bool KOZAAVRJTPU();

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(Slot = "108")]
		public abstract bool ZKKGWPYCQRV();

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(Slot = "109")]
		public abstract bool WEUMNGHOJVO();

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(Slot = "110")]
		public abstract bool YUKOKWQIFHQ();

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(Slot = "111")]
		public abstract bool HREZGJAHUTQ();

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(Slot = "112")]
		public abstract bool YKMQSEKXIHM();

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "113")]
		public abstract bool WNDHHRHVNUW();

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850", Slot = "114")]
		public virtual bool WHKXDRAVKVQ(Camera a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xD3D590", Offset = "0xD3BF90", VA = "0x180D3D590", Slot = "115")]
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
		[Cpp2IlInjected.Address(RVA = "0xCEBB90", Offset = "0xCEA590", VA = "0x180CEBB90", Slot = "118")]
		public virtual bool SupportsTextureFrameCount()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x2AB3AF0", Offset = "0x2AB24F0", VA = "0x182AB3AF0", Slot = "119")]
		public virtual long GetTextureTimeStamp()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(Slot = "120")]
		public abstract bool RequiresVerticalFlip();

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xD7DCD0", Offset = "0xD7C6D0", VA = "0x180D7DCD0", Slot = "121")]
		public virtual float GetTexturePixelAspectRatio()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x2AB3B00", Offset = "0x2AB2500", VA = "0x182AB3B00", Slot = "122")]
		public virtual Matrix4x4 GetYpCbCrTransform()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x2AB37E0", Offset = "0x2AB21E0", VA = "0x182AB37E0", Slot = "123")]
		public virtual float[] GetAffineTransform()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4230", Offset = "0x2AB2C30", VA = "0x182AB4230", Slot = "124")]
		public virtual float[] WDYOWTKIABT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x2AB3920", Offset = "0x2AB2320", VA = "0x182AB3920", Slot = "125")]
		public virtual Matrix4x4 GetTextureMatrix()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xF19AA0", Offset = "0xF184A0", VA = "0x180F19AA0", Slot = "126")]
		public virtual RenderTextureFormat GetCompatibleRenderTextureFormat(GetCompatibleRenderTextureFormatOptions options, int plane)
		{
			return default(RenderTextureFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x2AB3AC0", Offset = "0x2AB24C0", VA = "0x182AB3AC0", Slot = "70")]
		public StereoPacking GetTextureStereoPacking()
		{
			return default(StereoPacking);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(Slot = "127")]
		internal abstract StereoPacking HKCWZWTTTMF();

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xCD36C0", Offset = "0xCD20C0", VA = "0x180CD36C0", Slot = "128")]
		public virtual TransparencyMode GetTextureTransparency()
		{
			return default(TransparencyMode);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x2AB38E0", Offset = "0x2AB22E0", VA = "0x182AB38E0", Slot = "72")]
		public AlphaPacking GetTextureAlphaPacking()
		{
			return default(AlphaPacking);
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(Slot = "129")]
		public abstract void BZJMHTYTJTX(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(Slot = "130")]
		public abstract bool WYQANZWZIPV();

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "131")]
		public abstract void GYAGXFEBLNI(float a);

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "132")]
		public virtual void FPQYRFJLKJW(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(Slot = "133")]
		public abstract float IFJHRBUIUDU();

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xD21EE0", Offset = "0xD208E0", VA = "0x180D21EE0", Slot = "134")]
		public virtual float GetBalance()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xD21EF0", Offset = "0xD208F0", VA = "0x180D21EF0", Slot = "135")]
		public virtual int JDCFANPKNJO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "136")]
		public virtual int SZIEHYNENVK(float[] a, int b, int c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "137")]
		public virtual void YFXAUKUOEOU(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "138")]
		public virtual void ISQOQMDHPXM(Quaternion a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "139")]
		public virtual void GVJMIYOAAUH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "140")]
		public virtual void LWJLLTGBCGC(Audio360ChannelMode a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "141")]
		public virtual void NQIVGEAMKUH(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "142")]
		public virtual void ZLHZVQANXZZ(float a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "143")]
		public virtual void DQONTRRSSRG(Quaternion a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "144")]
		public virtual void OKJXNRUVGDV(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "145")]
		public virtual void IKQOCTUUFMI(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(Slot = "146")]
		public abstract void Update();

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "147")]
		public virtual void GOJBHYWYJNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "148")]
		public abstract void Render();

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(Slot = "149")]
		public abstract void Dispose();

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "150")]
		public virtual void HMWHLTGBQZG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x2AB3B60", Offset = "0x2AB2560", VA = "0x182AB3B60", Slot = "40")]
		public ErrorCode IYUPGCGHXOW()
		{
			return default(ErrorCode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xCEBB90", Offset = "0xCEA590", VA = "0x180CEBB90", Slot = "151")]
		public virtual bool YPIHZGERPQX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xCDB260", Offset = "0xCD9C60", VA = "0x180CDB260", Slot = "39")]
		public KMZFOCKIWSH RKVZSJPVBKD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4330", Offset = "0x2AB2D30", VA = "0x182AB4330", Slot = "42")]
		public void ZTFWLNLYJEW([Out] FilterMode a, [Out] TextureWrapMode b, [Out] int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x2AB3E70", Offset = "0x2AB2870", VA = "0x182AB3E70", Slot = "41")]
		public void TGLDNWWLUHA(FilterMode a = FilterMode.Bilinear, TextureWrapMode b = TextureWrapMode.Clamp, int c = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4080", Offset = "0x2AB2A80", VA = "0x182AB4080", Slot = "152")]
		protected virtual void TRJNZOCYWHM(Texture a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4120", Offset = "0x2AB2B20", VA = "0x182AB4120")]
		protected void UGKEWIAXASI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x2AB3F00", Offset = "0x2AB2900", VA = "0x182AB3F00")]
		protected bool TLCYPUTXIPR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x2AB3170", Offset = "0x2AB1B70", VA = "0x182AB3170", Slot = "153")]
		public virtual bool CMESUQRFWXK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x2AB41C0", Offset = "0x2AB2BC0", VA = "0x182AB41C0", Slot = "77")]
		public bool VNCWMREQSYM(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x2AB34A0", Offset = "0x2AB1EA0", VA = "0x182AB34A0", Slot = "154")]
		public virtual void FQFSYWLTIHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x2AB3BB0", Offset = "0x2AB25B0", VA = "0x182AB3BB0", Slot = "155")]
		public virtual int LMRCKGLBXBS()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x2AB3B70", Offset = "0x2AB2570", VA = "0x182AB3B70", Slot = "156")]
		public virtual string KKFRQWLQXQH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "157")]
		public virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x2AB33E0", Offset = "0x2AB1DE0", VA = "0x182AB33E0", Slot = "158")]
		public int DSSWRLBDVZU(float a = 0f)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4250", Offset = "0x2AB2C50", VA = "0x182AB4250")]
		protected bool ZAMZOIMGTJD(bool a = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "159")]
		internal abstract bool TWDVTXUVRYD();

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(Slot = "160")]
		internal abstract string RLRSFEPGDWC();

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "161")]
		internal abstract bool ZUVLBKJVUGP(TrackType a);

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "162")]
		internal abstract int YHRSWXBFHSV(TrackType a);

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(Slot = "163")]
		internal abstract PRDHYFHPOCS MIOSCMSBREK(TrackType a, int b, bool c);

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x2AB3680", Offset = "0x2AB2080", VA = "0x182AB3680")]
		private void GUCFKRHQJTQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x2AB3BF0", Offset = "0x2AB25F0", VA = "0x182AB3BF0")]
		protected void NTXFIUDEWQV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x2AB3CA0", Offset = "0x2AB26A0", VA = "0x182AB3CA0")]
		private void OATXMORBYQJ(ZJOEQNGJUJR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x2AB3850", Offset = "0x2AB2250", VA = "0x182AB3850", Slot = "164")]
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
		private List<UnityAction<MediaPlayer, EventType, ErrorCode>> SKIGGCBMJTQ;

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7310", Offset = "0x2AA5D10", VA = "0x182AA7310")]
		public bool EWDOJEKJXOV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7370", Offset = "0x2AA5D70", VA = "0x182AA7370")]
		public void OPCPQKVPOGT(UnityAction<MediaPlayer, EventType, ErrorCode> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7460", Offset = "0x2AA5E60", VA = "0x182AA7460")]
		public void VEFDSSGBHRG(UnityAction<MediaPlayer, EventType, ErrorCode> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7500", Offset = "0x2AA5F00", VA = "0x182AA7500")]
		public MediaPlayerEvent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class WHOPBJBHPOM
	{
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private static Matrix4x4 SGCKUSJZAPU;

		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private static Matrix4x4 DPFWDPIQGBK;

		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private static Matrix4x4 WHEHXMLKHJE;

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x2AC6680", Offset = "0x2AC5080", VA = "0x182AC6680")]
		public static string GKKABFGOQCD(MediaPathType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x2AC68F0", Offset = "0x2AC52F0", VA = "0x182AC68F0")]
		public static string OTBEWWZJMVT(string a, MediaPathType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x2AC7070", Offset = "0x2AC5A70", VA = "0x182AC7070")]
		public static string WQRJTJAJRIJ(ErrorCode a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x2AC6520", Offset = "0x2AC4F20", VA = "0x182AC6520")]
		public static void DPMSSQUUFGW(string a, [Optional] UnityEngine.Object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x2AC68C0", Offset = "0x2AC52C0", VA = "0x182AC68C0")]
		public static int LPOAWACNWAZ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x2AC6CB0", Offset = "0x2AC56B0", VA = "0x182AC6CB0")]
		public static int ULQYHMCPLHT()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x2AC7190", Offset = "0x2AC5B90", VA = "0x182AC7190")]
		public static Orientation ZZZZCXMUWTE(float[] a)
		{
			return default(Orientation);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x2AC6600", Offset = "0x2AC5000", VA = "0x182AC6600")]
		public static int GEQXYYINHZN(double a, float b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x2AC67E0", Offset = "0x2AC51E0", VA = "0x182AC67E0")]
		private static extern int GetShortPathName(string pathName, StringBuilder shortName, int cbShortName);

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x2AC6B00", Offset = "0x2AC5500", VA = "0x182AC6B00")]
		internal static string TNTNXRRFWCF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x2AC6D40", Offset = "0x2AC5740", VA = "0x182AC6D40")]
		public static Texture2D VLUAATVJOXB(Texture a, bool b, Orientation c, [Optional] Texture2D d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public interface OEZSXQMPXIQ
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnEnable();

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Update();

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void HMWHLTGBQZG();

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void GOJBHYWYJNL();

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Render();
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public interface OSMPAZMAKGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool VNCWMREQSYM(string a);

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int LMRCKGLBXBS();

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(Slot = "2")]
		string KKFRQWLQXQH();
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public interface BIUTRNRAOES
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool JKZKLSNRQOE(string a, long b, string c, MediaHints d, int e = 0, bool f = false);

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool FEJERNCEUVA(byte[] a);

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool FRAHOUFBPYS(ulong a);

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool RTQYTAWXWEZ(byte[] a, ulong b, ulong c);

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool KLNDWCALZVX();

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void GDKWKQUFVIA();

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void YXMFDJSLGTQ(bool a);

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool GRYZVKKGWVE();

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool IMTROIUPSJH();

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool ADPQVRDGJQU();

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool YUKOKWQIFHQ();

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool WEUMNGHOJVO();

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool HREZGJAHUTQ();

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(Slot = "13")]
		bool YKMQSEKXIHM();

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(Slot = "14")]
		bool WNDHHRHVNUW();

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
		void MBSYENUJZMD();

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void WGCAAYXZUAE(double a);

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void SCYJILLDPPA(double a);

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(Slot = "21")]
		double OLZCDPPWKKY();

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(Slot = "22")]
		float ISQHRDOFHWT();

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void HQPFIZSADBB(float a);

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void BZJMHTYTJTX(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(Slot = "25")]
		bool WYQANZWZIPV();

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void GYAGXFEBLNI(float a);

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void FPQYRFJLKJW(float a);

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(Slot = "28")]
		float IFJHRBUIUDU();

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(Slot = "29")]
		float GetBalance();

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(Slot = "30")]
		KMZFOCKIWSH RKVZSJPVBKD();

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(Slot = "31")]
		ErrorCode IYUPGCGHXOW();

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(Slot = "32")]
		void TGLDNWWLUHA(FilterMode a = FilterMode.Bilinear, TextureWrapMode b = TextureWrapMode.Clamp, int c = 1);

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(Slot = "33")]
		void ZTFWLNLYJEW([Out] FilterMode a, [Out] TextureWrapMode b, [Out] int c);

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(Slot = "34")]
		int SZIEHYNENVK(float[] a, int b, int c);

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(Slot = "35")]
		int JDCFANPKNJO();

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void YFXAUKUOEOU(bool a);

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(Slot = "37")]
		void LWJLLTGBCGC(Audio360ChannelMode a);

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(Slot = "38")]
		void ISQOQMDHPXM(Quaternion a);

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(Slot = "39")]
		void GVJMIYOAAUH();

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(Slot = "40")]
		void NQIVGEAMKUH(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(Slot = "41")]
		void ZLHZVQANXZZ(float a, float b);

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(Slot = "42")]
		void DQONTRRSSRG(Quaternion a);

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(Slot = "43")]
		bool WHKXDRAVKVQ(Camera a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(Slot = "44")]
		void OKJXNRUVGDV(string a);

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(Slot = "45")]
		void IKQOCTUUFMI(byte[] a);
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public interface GGUKCJCFQIZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(Slot = "0")]
		double GYHKTZCHFKQ();

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int CQRSOKMXLKN();

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int TZOQMCELHFW();

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(Slot = "3")]
		float FWVXCBKZMRY();

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool ZKKGWPYCQRV();

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool YPIHZGERPQX();

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool CMESUQRFWXK();

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float[] WDYOWTKIABT();
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public interface OBCJVSDOTLP
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public interface BITCXTOTJGQ
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
			[Cpp2IlInjected.Address(RVA = "0xCD0110", Offset = "0xCCEB10", VA = "0x180CD0110")]
			get
			{
				return default(MediaPathType);
			}
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0xCDFF30", Offset = "0xCDE930", VA = "0x180CDFF30")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public string Path
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0xCD8E10", Offset = "0xCD7810", VA = "0x180CD8E10")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x2AB74D0", Offset = "0x2AB5ED0", VA = "0x182AB74D0")]
		public MediaPath()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x2AB7460", Offset = "0x2AB5E60", VA = "0x182AB7460")]
		public MediaPath(MediaPath copy)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x2AB73F0", Offset = "0x2AB5DF0", VA = "0x182AB73F0")]
		public MediaPath(string path, MediaPathType pathType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x2AB6F80", Offset = "0x2AB5980", VA = "0x182AB6F80")]
		public string BTHMHCPEWYG()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x2AB7360", Offset = "0x2AB5D60", VA = "0x182AB7360")]
		public static MediaPath VFJBORFPFZV(string a)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x2AB7340", Offset = "0x2AB5D40", VA = "0x182AB7340")]
		public static bool OTUOIXXRZSY(MediaPath a, MediaPath b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x2AB7300", Offset = "0x2AB5D00", VA = "0x182AB7300")]
		public static bool JSGIPYLAFHN(MediaPath a, MediaPath b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x2AB71C0", Offset = "0x2AB5BC0", VA = "0x182AB71C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x2AB72B0", Offset = "0x2AB5CB0", VA = "0x182AB72B0", Slot = "2")]
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
		public static MediaHints KLCPKUHGTRT
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x2AB6F30", Offset = "0x2AB5930", VA = "0x182AB6F30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2AC64C0", Offset = "0x2AC4EC0", VA = "0x182AC64C0")]
		public bool KBXMAWZTSLB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x2AC6420", Offset = "0x2AC4E20", VA = "0x182AC6420")]
		internal void AASXBXNHUDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x2AC6450", Offset = "0x2AC4E50", VA = "0x182AC6450")]
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
	public static class QEZWGDGYWQZ
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
	public static class TVPKWQXVAFJ
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
	public static class IFMAUMDSSBX
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
	public class KMZFOCKIWSH : IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		internal TimeRange[] FJSHYZAGBKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		internal double LIDKCPYJMHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		internal double BTVJBMZZPPK;

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public int KQOHZIVUHAP
		{
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x2836230", Offset = "0x2834C30", VA = "0x182836230")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public double DFKTDTSAEIR
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x2AB69C0", Offset = "0x2AB53C0", VA = "0x182AB69C0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public double NLUSYEXGXDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x2AB6A00", Offset = "0x2AB5400", VA = "0x182AB6A00")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public double USSTVRVIIKY
		{
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x2AB69F0", Offset = "0x2AB53F0", VA = "0x182AB69F0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x2AB6D70", Offset = "0x2AB5770", VA = "0x182AB6D70")]
		internal KMZFOCKIWSH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x2AB69D0", Offset = "0x2AB53D0", VA = "0x182AB69D0", Slot = "4")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x2AB6B60", Offset = "0x2AB5560", VA = "0x182AB6B60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x2AB6A10", Offset = "0x2AB5410", VA = "0x182AB6A10")]
		internal void TXBAGFTUAKJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class EOSYWBONIEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private int TYOXCINFGRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private long NKTZKUNBCYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private VXNPJDLEFTM MWVJIADAFYY;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public int JESFOTRTXPI
		{
			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0xCD0110", Offset = "0xCCEB10", VA = "0x180CD0110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0xCDFF30", Offset = "0xCDE930", VA = "0x180CDFF30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public int UEMBQTDXAXR
		{
			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0xDF0AD0", Offset = "0xDEF4D0", VA = "0x180DF0AD0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0xDF0A00", Offset = "0xDEF400", VA = "0x180DF0A00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public int ZBXDUQSABHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0xCD36A0", Offset = "0xCD20A0", VA = "0x180CD36A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0xCD36B0", Offset = "0xCD20B0", VA = "0x180CD36B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		private float WOTYHEJOREZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x13E5FF0", Offset = "0x13E49F0", VA = "0x1813E5FF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		private string FGEZZHDBDSH
		{
			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0xCD27D0", Offset = "0xCD11D0", VA = "0x180CD27D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		private int BWMVYQQYYBZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0xCD36C0", Offset = "0xCD20C0", VA = "0x180CD36C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0xCD36E0", Offset = "0xCD20E0", VA = "0x180CD36E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		private int SKGZHFUIHQQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0xDF6DB0", Offset = "0xDF57B0", VA = "0x180DF6DB0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x1DEA530", Offset = "0x1DE8F30", VA = "0x181DEA530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public bool IRTTEHAIDAO
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0xD2E420", Offset = "0xD2CE20", VA = "0x180D2E420")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4980", Offset = "0x2AB3380", VA = "0x182AB4980")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x2AB49D0", Offset = "0x2AB33D0", VA = "0x182AB49D0")]
		internal void Start(VXNPJDLEFTM player)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4D80", Offset = "0x2AB3780", VA = "0x182AB4D80")]
		internal void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xCEBB90", Offset = "0xCEA590", VA = "0x180CEBB90")]
		private static bool GGHEFQHFBPD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public EOSYWBONIEF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public sealed class HIZUNKFFQFE : VXNPJDLEFTM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private bool RCGFUKLYVOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private bool DKUYHFSSPRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private double GFSDMIZKPCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private float BOKCGNWDNSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private float NINKKYUMWSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private bool ORSCCQEIZTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private int LRKZXVLIWFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private int SWLXEPKSONM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private Texture2D FZGGZIXXWOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private Texture2D AAWSIICOLKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private Texture2D HJSYGUWHWMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private float EPFVBCJGVSK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private int VVUGCCFIEKV;

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5FA0", Offset = "0x2AB49A0", VA = "0x182AB5FA0", Slot = "82")]
		public override string AHETNTWHPFW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x2AB6270", Offset = "0x2AB4C70", VA = "0x182AB6270", Slot = "83")]
		public override string UFAPALQYUKY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x2AB6020", Offset = "0x2AB4A20", VA = "0x182AB6020", Slot = "84")]
		public override bool JKZKLSNRQOE(string a, long b, string c, MediaHints d, int e = 0, bool f = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5FD0", Offset = "0x2AB49D0", VA = "0x182AB5FD0", Slot = "89")]
		public override void GDKWKQUFVIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xDEBAD0", Offset = "0xDEA4D0", VA = "0x180DEBAD0", Slot = "90")]
		public override void YXMFDJSLGTQ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xDEB7D0", Offset = "0xDEA1D0", VA = "0x180DEB7D0", Slot = "91")]
		public override bool GRYZVKKGWVE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xCEBB90", Offset = "0xCEA590", VA = "0x180CEBB90", Slot = "92")]
		public override bool IMTROIUPSJH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xCEBB90", Offset = "0xCEA590", VA = "0x180CEBB90", Slot = "93")]
		public override bool ADPQVRDGJQU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850", Slot = "107")]
		public override bool KOZAAVRJTPU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850", Slot = "108")]
		public override bool ZKKGWPYCQRV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x2AB6230", Offset = "0x2AB4C30", VA = "0x182AB6230", Slot = "94")]
		public override void Play()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x2AB6220", Offset = "0x2AB4C20", VA = "0x182AB6220", Slot = "95")]
		public override void Pause()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x2AB6260", Offset = "0x2AB4C60", VA = "0x182AB6260", Slot = "96")]
		public override void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850", Slot = "109")]
		public override bool WEUMNGHOJVO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xFF2CA0", Offset = "0xFF16A0", VA = "0x180FF2CA0", Slot = "110")]
		public override bool YUKOKWQIFHQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xEC1540", Offset = "0xEBFF40", VA = "0x180EC1540", Slot = "111")]
		public override bool HREZGJAHUTQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x2AB6410", Offset = "0x2AB4E10", VA = "0x182AB6410", Slot = "112")]
		public override bool YKMQSEKXIHM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850", Slot = "113")]
		public override bool WNDHHRHVNUW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x2AB6010", Offset = "0x2AB4A10", VA = "0x182AB6010", Slot = "103")]
		public override double GYHKTZCHFKQ()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x10C04A0", Offset = "0x10BEEA0", VA = "0x1810C04A0", Slot = "104")]
		public override int CQRSOKMXLKN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xFD91E0", Offset = "0xFD7BE0", VA = "0x180FD91E0", Slot = "105")]
		public override int TZOQMCELHFW()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xE38990", Offset = "0xE37390", VA = "0x180E38990", Slot = "116")]
		public override Texture GetTexture(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x1EADE00", Offset = "0x1EAC800", VA = "0x181EADE00", Slot = "117")]
		public override int GetTextureFrameCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xF04200", Offset = "0xF02C00", VA = "0x180F04200", Slot = "127")]
		internal override StereoPacking HKCWZWTTTMF()
		{
			return default(StereoPacking);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850", Slot = "120")]
		public override bool RequiresVerticalFlip()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x2AB6250", Offset = "0x2AB4C50", VA = "0x182AB6250", Slot = "98")]
		public override void WGCAAYXZUAE(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x2AB6250", Offset = "0x2AB4C50", VA = "0x182AB6250", Slot = "99")]
		public override void SCYJILLDPPA(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x2AB6210", Offset = "0x2AB4C10", VA = "0x182AB6210", Slot = "100")]
		public override double OLZCDPPWKKY()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x20263B0", Offset = "0x2024DB0", VA = "0x1820263B0", Slot = "102")]
		public override void HQPFIZSADBB(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x1F7CBD0", Offset = "0x1F7B5D0", VA = "0x181F7CBD0", Slot = "101")]
		public override float ISQHRDOFHWT()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "129")]
		public override void BZJMHTYTJTX(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xCEBB90", Offset = "0xCEA590", VA = "0x180CEBB90", Slot = "130")]
		public override bool WYQANZWZIPV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x1E16D50", Offset = "0x1E15750", VA = "0x181E16D50", Slot = "131")]
		public override void GYAGXFEBLNI(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x1E17A60", Offset = "0x1E16460", VA = "0x181E17A60", Slot = "133")]
		public override float IFJHRBUIUDU()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xD21EE0", Offset = "0xD208E0", VA = "0x180D21EE0", Slot = "106")]
		public override float FWVXCBKZMRY()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x2AB6290", Offset = "0x2AB4C90", VA = "0x182AB6290", Slot = "146")]
		public override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "148")]
		public override void Render()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "149")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850", Slot = "161")]
		internal override bool ZUVLBKJVUGP(TrackType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "162")]
		internal override int YHRSWXBFHSV(TrackType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "163")]
		internal override PRDHYFHPOCS MIOSCMSBREK(TrackType a, int b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850", Slot = "159")]
		internal override bool TWDVTXUVRYD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "160")]
		internal override string RLRSFEPGDWC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x2AB6460", Offset = "0x2AB4E60", VA = "0x182AB6460")]
		public HIZUNKFFQFE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class QCVUQWXWGDM
	{
		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public string LHFHSVQRKUF
		{
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0xCD36D0", Offset = "0xCD20D0", VA = "0x180CD36D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public string RKVLDHKLRBL
		{
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xCD8E10", Offset = "0xCD7810", VA = "0x180CD8E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public byte[] UQGPLBIRVPU
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0xCD27D0", Offset = "0xCD11D0", VA = "0x180CD27D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0AD0", Offset = "0x2ABF4D0", VA = "0x182AC0AD0")]
		public QCVUQWXWGDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0A70", Offset = "0x2ABF470", VA = "0x182AC0A70")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class ODGNFROPUHA : VXNPJDLEFTM
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
			[Cpp2IlInjected.Address(RVA = "0x2AB96E0", Offset = "0x2AB80E0", VA = "0x182AB96E0")]
			public static extern bool IsChangedTracks(IntPtr instance, TrackType trackType);

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x2AB8DC0", Offset = "0x2AB77C0", VA = "0x182AB8DC0")]
			public static extern int GetTrackCount(IntPtr instance, TrackType trackType);

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x2AB8EE0", Offset = "0x2AB78E0", VA = "0x182AB8EE0")]
			public static extern bool GetTrackInfo(IntPtr instance, TrackType trackType, int index, int uid, bool isActive, StringBuilder name, int maxNameLength, StringBuilder language, int maxLanguageLength);

			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x2AB95E0", Offset = "0x2AB7FE0", VA = "0x182AB95E0")]
			public static extern bool IsChangedTextCue(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x2AB7FD0", Offset = "0x2AB69D0", VA = "0x182AB7FD0")]
			public static extern IntPtr GetCurrentTextCue(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x2AB8B60", Offset = "0x2AB7560", VA = "0x182AB8B60")]
			public static extern int GetTimeRanges(IntPtr playerInstance, [Out] TimeRange[] ranges, int rangeCount, TimeRangeTypes timeRangeType);

			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x2AB9460", Offset = "0x2AB7E60", VA = "0x182AB9460")]
			public static extern bool Init(bool linearColorSpace);

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x2AB79B0", Offset = "0x2AB63B0", VA = "0x182AB79B0")]
			public static extern void Deinit();

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x2AB8690", Offset = "0x2AB7090", VA = "0x182AB8690")]
			public static extern IntPtr GetPluginVersion();

			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x2AB7600", Offset = "0x2AB6000", VA = "0x182AB7600")]
			public static extern IntPtr BeginOpenSource(IntPtr instance, QEZWGDGYWQZ.VideoApi videoApi, QEZWGDGYWQZ.AudioOutput audioOutput, bool useHardwareDecoding, bool useRendererSync, bool generateTextureMips, bool hintAlphaChannel, bool useLowLatency, bool use10BitTextures, string forceAudioOutputDeviceName, int unitySampleRate, IntPtr[] preferredFilter, uint numFilters, int audio360ChannelMode, string httpHeader, bool startWithHighestBitrate);

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x2AB7C20", Offset = "0x2AB6620", VA = "0x182AB7C20")]
			public static extern IntPtr EndOpenSource(IntPtr instance, string path);

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x2ABA230", Offset = "0x2AB8C30", VA = "0x182ABA230")]
			public static extern IntPtr OpenSourceFromBuffer(IntPtr instance, byte[] buffer, ulong bufferLength, QEZWGDGYWQZ.VideoApi videoApi, QEZWGDGYWQZ.AudioOutput audioOutput, bool useHardwareDecoding, bool useRendererSync, bool generateTextureMips, bool hintAlphaChannel, bool useLowLatency, bool use10BitTextures, string forceAudioOutputDeviceName, int unitySampleRate, IntPtr[] preferredFilter, uint numFilters);

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x2ABB860", Offset = "0x2ABA260", VA = "0x182ABB860")]
			public static extern IntPtr StartOpenSourceFromBuffer(IntPtr instance, QEZWGDGYWQZ.VideoApi videoApi, ulong bufferLength);

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x2AB7540", Offset = "0x2AB5F40", VA = "0x182AB7540")]
			public static extern bool AddChunkToSourceBuffer(IntPtr instance, byte[] buffer, ulong offset, ulong chunkLength);

			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x2AB7AA0", Offset = "0x2AB64A0", VA = "0x182AB7AA0")]
			public static extern IntPtr EndOpenSourceFromBuffer(IntPtr instance, QEZWGDGYWQZ.AudioOutput audioOutput, bool useHardwareDecoding, bool useRendererSync, bool generateTextureMips, bool hintAlphaChannel, bool useLowLatency, bool use10BitTextures, string forceAudioOutputDeviceName, int unitySampleRate, IntPtr[] preferredFilter, uint numFilters);

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x2AB78C0", Offset = "0x2AB62C0", VA = "0x182AB78C0")]
			public static extern void CloseSource(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x2AB85A0", Offset = "0x2AB6FA0", VA = "0x182AB85A0")]
			public static extern IntPtr GetPlayerDescription(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x2ABAD00", Offset = "0x2AB9700", VA = "0x182ABAD00")]
			public static extern void SetCustomMovParserEnabled(IntPtr instance, bool enabled);

			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x2ABAEC0", Offset = "0x2AB98C0", VA = "0x182ABAEC0")]
			public static extern void SetHapNotchLCEnabled(IntPtr instance, bool enabled);

			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x2ABB630", Offset = "0x2ABA030", VA = "0x182ABB630")]
			public static extern void SetStereoDetectEnabled(IntPtr instance, bool enabled);

			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x2ABB6C0", Offset = "0x2ABA0C0", VA = "0x182ABB6C0")]
			public static extern void SetTextTrackSupportEnabled(IntPtr instance, bool enabled);

			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x2ABA810", Offset = "0x2AB9210", VA = "0x182ABA810")]
			public static extern void SetAudioDelayEnabled(IntPtr instance, bool enabled, bool isAutomatic, double timeSeconds);

			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x2ABAE30", Offset = "0x2AB9830", VA = "0x182ABAE30")]
			public static extern void SetFacebookAudio360SupportEnabled(IntPtr instance, bool enabled);

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x2ABAD90", Offset = "0x2AB9790", VA = "0x182ABAD90")]
			public static extern void SetDecoderHints(IntPtr instance, int parallelFrameCount, int prerollFrameCount);

			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x2AB8350", Offset = "0x2AB6D50", VA = "0x182AB8350")]
			public static extern int GetLastErrorCode(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x2ABA4E0", Offset = "0x2AB8EE0", VA = "0x182ABA4E0")]
			public static extern void Play(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x2ABA460", Offset = "0x2AB8E60", VA = "0x182ABA460")]
			public static extern void Pause(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x2ABB1C0", Offset = "0x2AB9BC0", VA = "0x182ABB1C0")]
			public static extern void SetMuted(IntPtr instance, bool muted);

			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x2ABB750", Offset = "0x2ABA150", VA = "0x182ABB750")]
			public static extern void SetVolume(IntPtr instance, float volume);

			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x2ABABD0", Offset = "0x2AB95D0", VA = "0x182ABABD0")]
			public static extern void SetBalance(IntPtr instance, float volume);

			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x2ABB130", Offset = "0x2AB9B30", VA = "0x182ABB130")]
			public static extern void SetLooping(IntPtr instance, bool looping);

			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x2AB93E0", Offset = "0x2AB7DE0", VA = "0x182AB93E0")]
			public static extern bool HasVideo(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x2AB92E0", Offset = "0x2AB7CE0", VA = "0x182AB92E0")]
			public static extern bool HasAudio(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x2AB91A0", Offset = "0x2AB7BA0", VA = "0x182AB91A0")]
			public static extern int GetWidth(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x2AB8250", Offset = "0x2AB6C50", VA = "0x182AB8250")]
			public static extern int GetHeight(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x2AB81D0", Offset = "0x2AB6BD0", VA = "0x182AB81D0")]
			public static extern float GetFrameRate(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x2AB87E0", Offset = "0x2AB71E0", VA = "0x182AB87E0")]
			public static extern StereoPacking GetStereoPacking(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x2AB80D0", Offset = "0x2AB6AD0", VA = "0x182AB80D0")]
			public static extern double GetDuration(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x2AB9880", Offset = "0x2AB8280", VA = "0x182AB9880")]
			public static extern bool IsPlaybackStalled(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x2AB9360", Offset = "0x2AB7D60", VA = "0x182AB9360")]
			public static extern bool HasMetaData(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x2AB77C0", Offset = "0x2AB61C0", VA = "0x182AB77C0")]
			public static extern bool CanPlay(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x2AB9980", Offset = "0x2AB8380", VA = "0x182AB9980")]
			public static extern bool IsSeeking(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x2AB9900", Offset = "0x2AB8300", VA = "0x182AB9900")]
			public static extern bool IsPlaying(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x2AB9800", Offset = "0x2AB8200", VA = "0x182AB9800")]
			public static extern bool IsFinished(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x2AB9560", Offset = "0x2AB7F60", VA = "0x182AB9560")]
			public static extern bool IsBuffering(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x2AB8050", Offset = "0x2AB6A50", VA = "0x182AB8050")]
			public static extern double GetCurrentTime(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x2ABAC60", Offset = "0x2AB9660", VA = "0x182ABAC60")]
			public static extern void SetCurrentTime(IntPtr instance, double time, bool fast);

			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x2ABB510", Offset = "0x2AB9F10", VA = "0x182ABB510")]
			public static extern void SetPlaybackRate(IntPtr instance, float rate);

			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0x2ABB7E0", Offset = "0x2ABA1E0", VA = "0x182ABB7E0")]
			public static extern void StartExtractFrame(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0x2ABBA00", Offset = "0x2ABA400", VA = "0x182ABBA00")]
			public static extern void WaitForExtract(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0x2ABB900", Offset = "0x2ABA300", VA = "0x182ABB900")]
			public static extern void Update(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0x2AB7CC0", Offset = "0x2AB66C0", VA = "0x182AB7CC0")]
			public static extern void EndUpdate(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0x2AB8A60", Offset = "0x2AB7460", VA = "0x182AB8A60")]
			public static extern IntPtr GetTexturePointer(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(RVA = "0x2AB88E0", Offset = "0x2AB72E0", VA = "0x182AB88E0")]
			public static extern int GetTextureFormat(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(RVA = "0x2AB9A80", Offset = "0x2AB8480", VA = "0x182AB9A80")]
			public static extern bool IsTextureTopDown(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0x2AB9A00", Offset = "0x2AB8400", VA = "0x182AB9A00")]
			public static extern bool IsTextureSampleLinear(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0x2AB8960", Offset = "0x2AB7360", VA = "0x182AB8960")]
			public static extern int GetTextureFrameCount(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x2AB8AE0", Offset = "0x2AB74E0", VA = "0x182AB8AE0")]
			public static extern long GetTextureTimeStamp(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x2AB89E0", Offset = "0x2AB73E0", VA = "0x182AB89E0")]
			public static extern float GetTexturePixelAspectRatio(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0x2AB8700", Offset = "0x2AB7100", VA = "0x182AB8700")]
			public static extern IntPtr GetRenderEventFunc();

			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x2AB9220", Offset = "0x2AB7C20", VA = "0x182AB9220")]
			public static extern int GrabAudio(IntPtr instance, float[] buffer, int sampleCount, int channelCount);

			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0x2AB7E50", Offset = "0x2AB6850", VA = "0x182AB7E50")]
			public static extern int GetAudioChannelCount(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0x2ABA780", Offset = "0x2AB9180", VA = "0x182ABA780")]
			public static extern int SetAudioChannelMode(IntPtr instance, int audio360ChannelMode);

			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x2ABAF50", Offset = "0x2AB9950", VA = "0x182ABAF50")]
			public static extern void SetHeadOrientation(IntPtr instance, float x, float y, float z, float w);

			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x2ABA8C0", Offset = "0x2AB92C0", VA = "0x182ABA8C0")]
			public static extern void SetAudioFocusEnabled(IntPtr instance, bool enabled);

			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x2ABA950", Offset = "0x2AB9350", VA = "0x182ABA950")]
			public static extern void SetAudioFocusProps(IntPtr instance, float offFocusLevel, float widthDegrees);

			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x2ABA9F0", Offset = "0x2AB93F0", VA = "0x182ABA9F0")]
			public static extern void SetAudioFocusRotation(IntPtr instance, float x, float y, float z, float w);

			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x2AB9E40", Offset = "0x2AB8840", VA = "0x182AB9E40")]
			public static void NZQNCWSUXSH(IntPtr a, QCVUQWXWGDM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x2ABB3B0", Offset = "0x2AB9DB0", VA = "0x182ABB3B0")]
			private static extern void SetNextAuthData(IntPtr instance, AuthData authData);
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private QEZWGDGYWQZ.AudioOutput KQCQVJZWRZW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		private string DGZZHIBFLLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private List<string> QIRJHPAWJLT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private Audio360ChannelMode FMUGIYGTXTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private bool GKGMDCSKXUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC5")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private bool MNLCQYMKMZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC6")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private bool TAVFCPAREEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC7")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private bool BZKGBTMUENL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private bool LEZFJAGLHAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private bool QABIECSXMWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private int SHPKFSSLIPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private int ZOCJGDUHTFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private bool RCGFUKLYVOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD5")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private bool DKUYHFSSPRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD6")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private bool KGWERANGEIZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD7")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private bool SWKQJCVPXWH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private bool CYTWIHOLROC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private int VTNOTCOTBPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private int SWLXEPKSONM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private float OEAOMONLYYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private float FRCAEWESCVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private bool GHSWTJRAQUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private float BOKCGNWDNSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private float PZIIZKXIOUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private bool CPYGXLEMPMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF9")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		private bool KKAXINLVANA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFA")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private bool FUCNEICCTZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private IntPtr TKOUUYINRIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private Texture2D FZGGZIXXWOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		private RenderTexture YMSXNCSZDZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private IntPtr YAMBAODJEJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private QEZWGDGYWQZ.VideoApi OCLHURRJCEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private bool IRPZPXZMUTX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x125")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private bool QSDYNVTTWNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x126")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private bool GAZKZMJNEGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x127")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private bool ABQQFJQOQOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private bool XCKCLPKXCNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x129")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private bool OKXJDJKRSEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12A")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private bool JCWVTJBMENB;

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private static bool EVESRVKVHZU;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private static string HIVMTEQRNFN;

		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private static IntPtr CQCEUAIRIEE;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private static int WSJWGBBBVOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private QCVUQWXWGDM BUCZQBLLDKS;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public QCVUQWXWGDM MKWXIUKWADS
		{
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x2ABBC20", Offset = "0x2ABA620", VA = "0x182ABBC20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x2ABCB60", Offset = "0x2ABB560", VA = "0x182ABCB60")]
		public static bool HPFGBGNGPYU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x2ABE9E0", Offset = "0x2ABD3E0", VA = "0x182ABE9E0")]
		public static void RLEBFMWWZTM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x2ABD050", Offset = "0x2ABBA50", VA = "0x182ABD050", Slot = "135")]
		public override int JDCFANPKNJO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0520", Offset = "0x2ABEF20", VA = "0x182AC0520")]
		public ODGNFROPUHA(MediaPlayer.OptionsWindows a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x2ABD0D0", Offset = "0x2ABBAD0", VA = "0x182ABD0D0")]
		public void JDJNHXAVCWG(MediaPlayer.OptionsWindows a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x2ABD180", Offset = "0x2ABBB80", VA = "0x182ABD180")]
		public void JDJNHXAVCWG(QEZWGDGYWQZ.VideoApi a, QEZWGDGYWQZ.AudioOutput b, bool c, bool d, bool e, bool f, bool g, bool h, string i, List<string> j, bool k, int l, int m, bool n, bool o, bool p, bool q, bool r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x2ABBA90", Offset = "0x2ABA490", VA = "0x182ABBA90", Slot = "82")]
		public override string AHETNTWHPFW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x2ABF460", Offset = "0x2ABDE60", VA = "0x182ABF460", Slot = "83")]
		public override string UFAPALQYUKY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x2ABEE20", Offset = "0x2ABD820", VA = "0x182ABEE20")]
		private bool TBNUCTHUXRV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x2ABD3C0", Offset = "0x2ABBDC0", VA = "0x182ABD3C0", Slot = "84")]
		public override bool JKZKLSNRQOE(string a, long b, string c, MediaHints d, int e = 0, bool f = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x2ABBEB0", Offset = "0x2ABA8B0", VA = "0x182ABBEB0", Slot = "85")]
		public override bool FEJERNCEUVA(byte[] a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC3B0", Offset = "0x2ABADB0", VA = "0x182ABC3B0", Slot = "86")]
		public override bool FRAHOUFBPYS(ulong a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x2ABEB60", Offset = "0x2ABD560", VA = "0x182ABEB60", Slot = "87")]
		public override bool RTQYTAWXWEZ(byte[] a, ulong b, ulong c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x2ABDDD0", Offset = "0x2ABC7D0", VA = "0x182ABDDD0", Slot = "88")]
		public override bool KLNDWCALZVX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x2ABBD80", Offset = "0x2ABA780", VA = "0x182ABBD80")]
		private void EWXWABTZXEY(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC480", Offset = "0x2ABAE80", VA = "0x182ABC480", Slot = "89")]
		public override void GDKWKQUFVIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0220", Offset = "0x2ABEC20", VA = "0x182AC0220", Slot = "90")]
		public override void YXMFDJSLGTQ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x2AAD830", Offset = "0x2AAC230", VA = "0x182AAD830", Slot = "91")]
		public override bool GRYZVKKGWVE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0xEEA6E0", Offset = "0xEE90E0", VA = "0x180EEA6E0", Slot = "92")]
		public override bool IMTROIUPSJH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x10901C0", Offset = "0x108EBC0", VA = "0x1810901C0", Slot = "107")]
		public override bool KOZAAVRJTPU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x1091CF0", Offset = "0x10906F0", VA = "0x181091CF0", Slot = "108")]
		public override bool ZKKGWPYCQRV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x2ABBA80", Offset = "0x2ABA480", VA = "0x182ABBA80", Slot = "93")]
		public override bool ADPQVRDGJQU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x2ABE870", Offset = "0x2ABD270", VA = "0x182ABE870", Slot = "94")]
		public override void Play()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x2ABE7E0", Offset = "0x2ABD1E0", VA = "0x182ABE7E0", Slot = "95")]
		public override void Pause()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x2ABEE00", Offset = "0x2ABD800", VA = "0x182ABEE00", Slot = "96")]
		public override void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x2ABFDB0", Offset = "0x2ABE7B0", VA = "0x182ABFDB0", Slot = "109")]
		public override bool WEUMNGHOJVO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0210", Offset = "0x2ABEC10", VA = "0x182AC0210", Slot = "110")]
		public override bool YUKOKWQIFHQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x2ABCF70", Offset = "0x2ABB970", VA = "0x182ABCF70", Slot = "111")]
		public override bool HREZGJAHUTQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0160", Offset = "0x2ABEB60", VA = "0x182AC0160", Slot = "112")]
		public override bool YKMQSEKXIHM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0030", Offset = "0x2ABEA30", VA = "0x182AC0030", Slot = "113")]
		public override bool WNDHHRHVNUW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC800", Offset = "0x2ABB200", VA = "0x182ABC800", Slot = "103")]
		public override double GYHKTZCHFKQ()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x24B0030", Offset = "0x24AEA30", VA = "0x1824B0030", Slot = "104")]
		public override int CQRSOKMXLKN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x219DB90", Offset = "0x219C590", VA = "0x18219DB90", Slot = "105")]
		public override int TZOQMCELHFW()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x1F30DB0", Offset = "0x1F2F7B0", VA = "0x181F30DB0", Slot = "106")]
		public override float FWVXCBKZMRY()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC9C0", Offset = "0x2ABB3C0", VA = "0x182ABC9C0", Slot = "116")]
		public override Texture GetTexture(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC880", Offset = "0x2ABB280", VA = "0x182ABC880", Slot = "117")]
		public override int GetTextureFrameCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC940", Offset = "0x2ABB340", VA = "0x182ABC940", Slot = "119")]
		public override long GetTextureTimeStamp()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC890", Offset = "0x2ABB290", VA = "0x182ABC890", Slot = "121")]
		public override float GetTexturePixelAspectRatio()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x1091180", Offset = "0x108FB80", VA = "0x181091180", Slot = "120")]
		public override bool RequiresVerticalFlip()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x2ABCA60", Offset = "0x2ABB460", VA = "0x182ABCA60", Slot = "127")]
		internal override StereoPacking HKCWZWTTTMF()
		{
			return default(StereoPacking);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x2ABFE40", Offset = "0x2ABE840", VA = "0x182ABFE40", Slot = "98")]
		public override void WGCAAYXZUAE(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x2ABED20", Offset = "0x2ABD720", VA = "0x182ABED20", Slot = "99")]
		public override void SCYJILLDPPA(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x2ABE760", Offset = "0x2ABD160", VA = "0x182ABE760", Slot = "100")]
		public override double OLZCDPPWKKY()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x2ABCF50", Offset = "0x2ABB950", VA = "0x182ABCF50", Slot = "102")]
		public override void HQPFIZSADBB(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x17CC980", Offset = "0x17CB380", VA = "0x1817CC980", Slot = "101")]
		public override float ISQHRDOFHWT()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x2ABBAE0", Offset = "0x2ABA4E0", VA = "0x182ABBAE0", Slot = "129")]
		public override void BZJMHTYTJTX(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x10BF1E0", Offset = "0x10BDBE0", VA = "0x1810BF1E0", Slot = "130")]
		public override bool WYQANZWZIPV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC7E0", Offset = "0x2ABB1E0", VA = "0x182ABC7E0", Slot = "131")]
		public override void GYAGXFEBLNI(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x28D87C0", Offset = "0x28D71C0", VA = "0x1828D87C0", Slot = "133")]
		public override float IFJHRBUIUDU()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC310", Offset = "0x2ABAD10", VA = "0x182ABC310", Slot = "132")]
		public override void FPQYRFJLKJW(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x20CFEE0", Offset = "0x20CE8E0", VA = "0x1820CFEE0", Slot = "134")]
		public override float GetBalance()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x2ABBB70", Offset = "0x2ABA570", VA = "0x182ABBB70", Slot = "153")]
		public override bool CMESUQRFWXK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x2ABFE60", Offset = "0x2ABE860", VA = "0x182ABFE60", Slot = "114")]
		public override bool WHKXDRAVKVQ(Camera a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x2ABE1A0", Offset = "0x2ABCBA0", VA = "0x182ABE1A0", Slot = "140")]
		public override void LWJLLTGBCGC(Audio360ChannelMode a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x2ABD010", Offset = "0x2ABBA10", VA = "0x182ABD010", Slot = "138")]
		public override void ISQOQMDHPXM(Quaternion a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC6D0", Offset = "0x2ABB0D0", VA = "0x182ABC6D0", Slot = "139")]
		public override void GVJMIYOAAUH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x2ABE670", Offset = "0x2ABD070", VA = "0x182ABE670", Slot = "141")]
		public override void NQIVGEAMKUH(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0240", Offset = "0x2ABEC40", VA = "0x182AC0240", Slot = "142")]
		public override void ZLHZVQANXZZ(float a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x2ABBC60", Offset = "0x2ABA660", VA = "0x182ABBC60", Slot = "143")]
		public override void DQONTRRSSRG(Quaternion a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x2ABF490", Offset = "0x2ABDE90", VA = "0x182ABF490", Slot = "146")]
		public override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x2AC02E0", Offset = "0x2ABECE0", VA = "0x182AC02E0")]
		private void ZSBHIHUQPGQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x2ABEE30", Offset = "0x2ABD830", VA = "0x182ABEE30")]
		private void TKHBDBXGDLK(IntPtr a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x2ABCAE0", Offset = "0x2ABB4E0", VA = "0x182ABCAE0", Slot = "150")]
		public override void HMWHLTGBQZG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		private void OZEWCBJFTKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC610", Offset = "0x2ABB010", VA = "0x182ABC610", Slot = "147")]
		public override void GOJBHYWYJNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x2ABEC20", Offset = "0x2ABD620", VA = "0x182ABEC20", Slot = "148")]
		public override void Render()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "149")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x2ABED40", Offset = "0x2ABD740", VA = "0x182ABED40", Slot = "136")]
		public override int SZIEHYNENVK(float[] a, int b, int c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x233B840", Offset = "0x233A240", VA = "0x18233B840", Slot = "151")]
		public override bool YPIHZGERPQX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x2ABE900", Offset = "0x2ABD300", VA = "0x182ABE900")]
		private static void QPQJQICHKUZ(Native.RenderThreadEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x2ABE230", Offset = "0x2ABCC30", VA = "0x182ABE230")]
		private static string MGGRQGXTAVD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x2ABF3D0", Offset = "0x2ABDDD0", VA = "0x182ABF3D0", Slot = "159")]
		internal override bool TWDVTXUVRYD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x2ABEA90", Offset = "0x2ABD490", VA = "0x182ABEA90", Slot = "160")]
		internal override string RLRSFEPGDWC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x2AC03F0", Offset = "0x2ABEDF0", VA = "0x182AC03F0", Slot = "161")]
		internal override bool ZUVLBKJVUGP(TrackType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x2AC00C0", Offset = "0x2ABEAC0", VA = "0x182AC00C0", Slot = "162")]
		internal override int YHRSWXBFHSV(TrackType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x2ABE2E0", Offset = "0x2ABCCE0", VA = "0x182ABE2E0", Slot = "163")]
		internal override PRDHYFHPOCS MIOSCMSBREK(TrackType a, int b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x2ABE700", Offset = "0x2ABD100", VA = "0x182ABE700", Slot = "144")]
		public override void OKJXNRUVGDV(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x2ABCFB0", Offset = "0x2ABB9B0", VA = "0x182ABCFB0", Slot = "145")]
		public override void IKQOCTUUFMI(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x2ABBD10", Offset = "0x2ABA710", VA = "0x182ABBD10")]
		private void EUPYLIVATKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x2ABFCE0", Offset = "0x2ABE6E0", VA = "0x182ABFCE0")]
		private void VZASKFYQLDP(TimeRange[] a, Native.TimeRangeTypes b)
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
	public sealed class RUCOSKPVCPO : VXNPJDLEFTM
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
			[Cpp2IlInjected.Address(RVA = "0x2AB9770", Offset = "0x2AB8170", VA = "0x182AB9770")]
			public static extern bool IsChangedTracks(IntPtr instance, TrackType trackType);

			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x2AB8E50", Offset = "0x2AB7850", VA = "0x182AB8E50")]
			public static extern int GetTrackCount(IntPtr instance, TrackType trackType);

			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0x2AB9040", Offset = "0x2AB7A40", VA = "0x182AB9040")]
			public static extern bool GetTrackInfo(IntPtr instance, TrackType trackType, int index, int uid, bool isActive, StringBuilder name, int maxNameLength, StringBuilder language, int maxLanguageLength);

			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0x2AB9660", Offset = "0x2AB8060", VA = "0x182AB9660")]
			public static extern bool IsChangedTextCue(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0x2AB7F50", Offset = "0x2AB6950", VA = "0x182AB7F50")]
			public static extern IntPtr GetCurrentTextCue(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0x2AB8620", Offset = "0x2AB7020", VA = "0x182AB8620")]
			private static extern IntPtr GetPluginVersionStringPointer();

			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0x2AB9B00", Offset = "0x2AB8500", VA = "0x182AB9B00")]
			public static string MGGRQGXTAVD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0x2AB7940", Offset = "0x2AB6340", VA = "0x182AB7940")]
			public static extern IntPtr CreatePlayer();

			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x2AB7A20", Offset = "0x2AB6420", VA = "0x182AB7A20")]
			public static extern void DestroyPlayer(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0x2ABA150", Offset = "0x2AB8B50", VA = "0x182ABA150")]
			public static extern bool OpenMedia(IntPtr playerInstance, string filePath, string httpHeader, FileFormat overrideFileFormat, bool startWithHighestBitrate, bool use10BitTextures);

			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0x2AB7840", Offset = "0x2AB6240", VA = "0x182AB7840")]
			public static extern void CloseMedia(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0x2ABA3E0", Offset = "0x2AB8DE0", VA = "0x182ABA3E0")]
			public static extern void Pause(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003D7")]
			[Cpp2IlInjected.Address(RVA = "0x2ABA560", Offset = "0x2AB8F60", VA = "0x182ABA560")]
			public static extern void Play(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003D8")]
			[Cpp2IlInjected.Address(RVA = "0x2ABAB40", Offset = "0x2AB9540", VA = "0x182ABAB40")]
			public static extern void SetAudioVolume(IntPtr playerInstance, float volume);

			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0x2ABA6F0", Offset = "0x2AB90F0", VA = "0x182ABA6F0")]
			public static extern void SetAudioBalance(IntPtr playerInstance, float balance);

			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0x2ABB5A0", Offset = "0x2AB9FA0", VA = "0x182ABB5A0")]
			public static extern void SetPlaybackRate(IntPtr playerInstance, float rate);

			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0x2ABAAB0", Offset = "0x2AB94B0", VA = "0x182ABAAB0")]
			public static extern void SetAudioMuted(IntPtr playerInstance, bool muted);

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x2AB94E0", Offset = "0x2AB7EE0", VA = "0x182AB94E0")]
			public static extern bool IsAudioMuted(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x2AB7DD0", Offset = "0x2AB67D0", VA = "0x182AB7DD0")]
			public static extern float GetAudioBalance(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x2AB84A0", Offset = "0x2AB6EA0", VA = "0x182AB84A0")]
			public static extern float GetPlaybackRate(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x2ABB0A0", Offset = "0x2AB9AA0", VA = "0x182ABB0A0")]
			public static extern void SetLooping(IntPtr playerInstance, bool looping);

			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x2AB82D0", Offset = "0x2AB6CD0", VA = "0x182AB82D0")]
			public static extern int GetLastErrorCode(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0x2ABB980", Offset = "0x2ABA380", VA = "0x182ABB980")]
			public static extern void Update(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0x2AB8150", Offset = "0x2AB6B50", VA = "0x182AB8150")]
			public static extern double GetDuration(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x2AB8860", Offset = "0x2AB7260", VA = "0x182AB8860")]
			public static extern StereoPacking GetStereoPacking(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x2AB7ED0", Offset = "0x2AB68D0", VA = "0x182AB7ED0")]
			public static extern double GetCurrentPosition(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x2AB83D0", Offset = "0x2AB6DD0", VA = "0x182AB83D0")]
			public static extern bool GetLatestFrame(IntPtr playerInstance, [Out] IntPtr leftEyeTexturePointer, [Out] IntPtr rightEyeTexturePointer, [Out] ulong frameTimeStamp, [Out] int width, [Out] int height);

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x2AB8520", Offset = "0x2AB6F20", VA = "0x182AB8520")]
			public static extern PlaybackState GetPlaybackState(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x2AB7D40", Offset = "0x2AB6740", VA = "0x182AB7D40")]
			public static extern bool GetActiveVideoTrackInfo(IntPtr playerInstance, [Out] VideoTrack videoTrack);

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x2ABB010", Offset = "0x2AB9A10", VA = "0x182ABB010")]
			public static extern void SetLiveOffset(IntPtr playerInstance, double seconds);

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x2ABA660", Offset = "0x2AB9060", VA = "0x182ABA660")]
			public static extern void Seek(IntPtr playerInstance, SeekParams seekParams);

			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x2AB9BB0", Offset = "0x2AB85B0", VA = "0x182AB9BB0")]
			public static void NZQNCWSUXSH(IntPtr a, QCVUQWXWGDM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0x2ABB250", Offset = "0x2AB9C50", VA = "0x182ABB250")]
			private static extern void SetNextAuthData(IntPtr playerInstance, AuthData authData);

			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0x2AB8C90", Offset = "0x2AB7690", VA = "0x182AB8C90")]
			public static extern int GetTimeRanges(IntPtr playerInstance, [Out] TimeRange[] ranges, int rangeCount, TimeRangeTypes timeRangeType);

			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x2AB8770", Offset = "0x2AB7170", VA = "0x182AB8770")]
			public static extern IntPtr GetRenderEventFunc();

			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0x2ABA0D0", Offset = "0x2AB8AD0", VA = "0x182ABA0D0")]
			public static void OTPCFDUGWDY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0x2ABA5E0", Offset = "0x2AB8FE0", VA = "0x182ABA5E0")]
			public static void QCGVMEOROUL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		private class GGEVXGQXJFS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000307")]
			public Texture2D YCKXJDOPXCX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000308")]
			public IntPtr RPPOGGMSVYY;

			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x2AB5470", Offset = "0x2AB3E70", VA = "0x182AB5470")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0x2AB5560", Offset = "0x2AB3F60", VA = "0x182AB5560")]
			public GGEVXGQXJFS()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private bool MNZVDMZEGAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private bool KGWERANGEIZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private float BOKCGNWDNSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		private bool ABQQFJQOQOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		private bool IIIIHXAXRDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private QCVUQWXWGDM BUCZQBLLDKS;

		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private static bool EVESRVKVHZU;

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private static string HIVMTEQRNFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private ulong HOJYSVDFEWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private IntPtr IMFFKBORLSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private GGEVXGQXJFS[] JNBEAMXSATI;

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public QCVUQWXWGDM MKWXIUKWADS
		{
			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x2AC42C0", Offset = "0x2AC2CC0", VA = "0x182AC42C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x2AC61A0", Offset = "0x2AC4BA0", VA = "0x182AC61A0")]
		public RUCOSKPVCPO(MediaPlayer.OptionsWindows a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x2AC4D40", Offset = "0x2AC3740", VA = "0x182AC4D40")]
		public void JDJNHXAVCWG(MediaPlayer.OptionsWindows a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x2AC3D30", Offset = "0x2AC2730", VA = "0x182AC3D30", Slot = "93")]
		public override bool ADPQVRDGJQU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x2AC4300", Offset = "0x2AC2D00", VA = "0x182AC4300", Slot = "149")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850", Slot = "151")]
		public override bool YPIHZGERPQX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x2AC53B0", Offset = "0x2AC3DB0", VA = "0x182AC53B0", Slot = "100")]
		public override double OLZCDPPWKKY()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x2AC4700", Offset = "0x2AC3100", VA = "0x182AC4700", Slot = "103")]
		public override double GYHKTZCHFKQ()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x2AC4CC0", Offset = "0x2AC36C0", VA = "0x182AC4CC0", Slot = "101")]
		public override float ISQHRDOFHWT()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x2AC4820", Offset = "0x2AC3220", VA = "0x182AC4820", Slot = "116")]
		public override Texture GetTexture(int index = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x2AC4790", Offset = "0x2AC3190", VA = "0x182AC4790", Slot = "115")]
		public override int GetTextureCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0xEEA6F0", Offset = "0xEE90F0", VA = "0x180EEA6F0", Slot = "117")]
		public override int GetTextureFrameCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x2AC4870", Offset = "0x2AC3270", VA = "0x182AC4870", Slot = "127")]
		internal override StereoPacking HKCWZWTTTMF()
		{
			return default(StereoPacking);
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x2AC3D50", Offset = "0x2AC2750", VA = "0x182AC3D50", Slot = "82")]
		public override string AHETNTWHPFW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x2AC57D0", Offset = "0x2AC41D0", VA = "0x182AC57D0", Slot = "83")]
		public override string UFAPALQYUKY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x2AC4580", Offset = "0x2AC2F80", VA = "0x182AC4580", Slot = "106")]
		public override float FWVXCBKZMRY()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x2AC41F0", Offset = "0x2AC2BF0", VA = "0x182AC41F0", Slot = "104")]
		public override int CQRSOKMXLKN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x2AC5700", Offset = "0x2AC4100", VA = "0x182AC5700", Slot = "105")]
		public override int TZOQMCELHFW()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x165ACC0", Offset = "0x16596C0", VA = "0x18165ACC0", Slot = "133")]
		public override float IFJHRBUIUDU()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x2AC44F0", Offset = "0x2AC2EF0", VA = "0x182AC44F0", Slot = "132")]
		public override void FPQYRFJLKJW(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x2AC4710", Offset = "0x2AC3110", VA = "0x182AC4710", Slot = "134")]
		public override float GetBalance()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x2AC4FC0", Offset = "0x2AC39C0", VA = "0x182AC4FC0", Slot = "107")]
		public override bool KOZAAVRJTPU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x2AC4C90", Offset = "0x2AC3690", VA = "0x182AC4C90", Slot = "92")]
		public override bool IMTROIUPSJH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x2AC6050", Offset = "0x2AC4A50", VA = "0x182AC6050", Slot = "108")]
		public override bool ZKKGWPYCQRV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x2AC5E20", Offset = "0x2AC4820", VA = "0x182AC5E20", Slot = "113")]
		public override bool WNDHHRHVNUW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x2AC5F60", Offset = "0x2AC4960", VA = "0x182AC5F60", Slot = "112")]
		public override bool YKMQSEKXIHM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xEC1540", Offset = "0xEBFF40", VA = "0x180EC1540", Slot = "91")]
		public override bool GRYZVKKGWVE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x2AC5E40", Offset = "0x2AC4840", VA = "0x182AC5E40", Slot = "130")]
		public override bool WYQANZWZIPV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x2AC4C10", Offset = "0x2AC3610", VA = "0x182AC4C10", Slot = "111")]
		public override bool HREZGJAHUTQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x2AC6010", Offset = "0x2AC4A10", VA = "0x182AC6010", Slot = "110")]
		public override bool YUKOKWQIFHQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x2AC5D70", Offset = "0x2AC4770", VA = "0x182AC5D70", Slot = "109")]
		public override bool WEUMNGHOJVO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x2AC4160", Offset = "0x2AC2B60", VA = "0x182AC4160", Slot = "129")]
		public override void BZJMHTYTJTX(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x2AC4D70", Offset = "0x2AC3770", VA = "0x182AC4D70", Slot = "84")]
		public override bool JKZKLSNRQOE(string a, long b, string c, MediaHints d, int e = 0, bool f = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x2AC4630", Offset = "0x2AC3030", VA = "0x182AC4630", Slot = "89")]
		public override void GDKWKQUFVIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x2AC5430", Offset = "0x2AC3E30", VA = "0x182AC5430", Slot = "95")]
		public override void Pause()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x2AC54B0", Offset = "0x2AC3EB0", VA = "0x182AC54B0", Slot = "94")]
		public override void Play()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x2ABA0D0", Offset = "0x2AB8AD0", VA = "0x182ABA0D0", Slot = "148")]
		public override void Render()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x2AC3DA0", Offset = "0x2AC27A0", VA = "0x182AC3DA0")]
		private void ATOVMAJYLAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xCEBB90", Offset = "0xCEA590", VA = "0x180CEBB90", Slot = "120")]
		public override bool RequiresVerticalFlip()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x2AC5D90", Offset = "0x2AC4790", VA = "0x182AC5D90", Slot = "98")]
		public override void WGCAAYXZUAE(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x2AC5650", Offset = "0x2AC4050", VA = "0x182AC5650", Slot = "99")]
		public override void SCYJILLDPPA(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x2AC6030", Offset = "0x2AC4A30", VA = "0x182AC6030", Slot = "90")]
		public override void YXMFDJSLGTQ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x2AC4B80", Offset = "0x2AC3580", VA = "0x182AC4B80", Slot = "102")]
		public override void HQPFIZSADBB(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x2AC46E0", Offset = "0x2AC30E0", VA = "0x182AC46E0", Slot = "131")]
		public override void GYAGXFEBLNI(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x2ABEE00", Offset = "0x2ABD800", VA = "0x182ABEE00", Slot = "96")]
		public override void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x2AC4480", Offset = "0x2AC2E80", VA = "0x182AC4480")]
		private void EUPYLIVATKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x2AC5CA0", Offset = "0x2AC46A0", VA = "0x182AC5CA0")]
		private void VZASKFYQLDP(TimeRange[] a, Native.TimeRangeTypes b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x2AC5800", Offset = "0x2AC4200", VA = "0x182AC5800", Slot = "146")]
		public override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x2AC5350", Offset = "0x2AC3D50", VA = "0x182AC5350", Slot = "144")]
		public override void OKJXNRUVGDV(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x2AC4C30", Offset = "0x2AC3630", VA = "0x182AC4C30", Slot = "145")]
		public override void IKQOCTUUFMI(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x2AC6090", Offset = "0x2AC4A90", VA = "0x182AC6090", Slot = "161")]
		internal override bool ZUVLBKJVUGP(TrackType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x2AC5ED0", Offset = "0x2AC48D0", VA = "0x182AC5ED0", Slot = "162")]
		internal override int YHRSWXBFHSV(TrackType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x2AC5000", Offset = "0x2AC3A00", VA = "0x182AC5000", Slot = "163")]
		internal override PRDHYFHPOCS MIOSCMSBREK(TrackType a, int b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x2AC5670", Offset = "0x2AC4070", VA = "0x182AC5670", Slot = "159")]
		internal override bool TWDVTXUVRYD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x2AC5580", Offset = "0x2AC3F80", VA = "0x182AC5580", Slot = "160")]
		internal override string RLRSFEPGDWC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x2AC48F0", Offset = "0x2AC32F0", VA = "0x182AC48F0")]
		public static bool HPFGBGNGPYU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x2AC5530", Offset = "0x2AC3F30", VA = "0x182AC5530")]
		public static void RLEBFMWWZTM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class OJJINBFNGPY
	{
		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public string TBADZHMKSFZ
		{
			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0xCD36D0", Offset = "0xCD20D0", VA = "0x180CD36D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0xCDA870", Offset = "0xCD9270", VA = "0x180CDA870")]
		internal OJJINBFNGPY(string a)
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
	public class PRDHYFHPOCS
	{
		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public int GQLCFPXBJYC
		{
			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0xCD0110", Offset = "0xCCEB10", VA = "0x180CD0110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0xCDFF30", Offset = "0xCDE930", VA = "0x180CDFF30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		private TrackType JFHGCKMOUJZ
		{
			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0xDF0A00", Offset = "0xDEF400", VA = "0x180DF0A00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		private string LGOBPKKBLKZ
		{
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0xCD8E10", Offset = "0xCD7810", VA = "0x180CD8E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public string KPIDBUYRLLN
		{
			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003FB")]
			[Cpp2IlInjected.Address(RVA = "0xCD27D0", Offset = "0xCD11D0", VA = "0x180CD27D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public string RZHWADDZFDU
		{
			[Cpp2IlInjected.Token(Token = "0x60003FC")]
			[Cpp2IlInjected.Address(RVA = "0xCD8E20", Offset = "0xCD7820", VA = "0x180CD8E20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003FD")]
			[Cpp2IlInjected.Address(RVA = "0xCD27E0", Offset = "0xCD11E0", VA = "0x180CD27E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		private bool TQQPWNDYKMR
		{
			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0xD2EE60", Offset = "0xD2D860", VA = "0x180D2EE60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0940", Offset = "0x2ABF340", VA = "0x182AC0940")]
		internal PRDHYFHPOCS(TrackType a, int b, string c, string d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0880", Offset = "0x2ABF280", VA = "0x182AC0880")]
		protected string NWAYNBYDHVH()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public abstract class ZJOEQNGJUJR : IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public virtual TrackType JFHGCKMOUJZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0xCD0110", Offset = "0xCCEB10", VA = "0x180CD0110", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(TrackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public abstract int KQOHZIVUHAP
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
		internal abstract void Add(PRDHYFHPOCS track);

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(Slot = "10")]
		internal abstract void ETMXLEEDXKV(PRDHYFHPOCS a);

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		protected ZJOEQNGJUJR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[DefaultMember("Item")]
	public class XYSOSAGNJJS<a> : ZJOEQNGJUJR where a : PRDHYFHPOCS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		internal List<a> PVGAZPBNSBX;

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		internal a GKRHOFHYRQB
		{
			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0xCD8E10", Offset = "0xCD7810", VA = "0x180CD8E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public override int KQOHZIVUHAP
		{
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x14E47D0", Offset = "0x14E31D0", VA = "0x1814E47D0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x50A6830", Offset = "0x50A5230", VA = "0x1850A6830")]
		internal XYSOSAGNJJS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x50A67D0", Offset = "0x50A51D0", VA = "0x1850A67D0", Slot = "7")]
		public override IEnumerator GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x50A6710", Offset = "0x50A5110", VA = "0x1850A6710", Slot = "8")]
		internal override void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x50A6640", Offset = "0x50A5040", VA = "0x1850A6640", Slot = "9")]
		internal override void Add(PRDHYFHPOCS track)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x50A6770", Offset = "0x50A5170", VA = "0x1850A6770", Slot = "10")]
		internal override void ETMXLEEDXKV(PRDHYFHPOCS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class YBBXHBHQDWP : XYSOSAGNJJS<LMMRVMRDBWG>
	{
		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public override TrackType JFHGCKMOUJZ
		{
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "5")]
			get
			{
				return default(TrackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x2AC7660", Offset = "0x2AC6060", VA = "0x182AC7660")]
		public YBBXHBHQDWP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class UOKWCXCWIVI : XYSOSAGNJJS<SOHGEHFTEYF>
	{
		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public override TrackType JFHGCKMOUJZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0xD3D590", Offset = "0xD3BF90", VA = "0x180D3D590", Slot = "5")]
			get
			{
				return default(TrackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x2AC63E0", Offset = "0x2AC4DE0", VA = "0x182AC63E0")]
		public UOKWCXCWIVI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class BFDPXUXXOWX : XYSOSAGNJJS<YSQBYIKFLDQ>
	{
		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public override TrackType JFHGCKMOUJZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0xD3C390", Offset = "0xD3AD90", VA = "0x180D3C390", Slot = "5")]
			get
			{
				return default(TrackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4940", Offset = "0x2AB3340", VA = "0x182AB4940")]
		public BFDPXUXXOWX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class LMMRVMRDBWG : PRDHYFHPOCS
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x2AB6EB0", Offset = "0x2AB58B0", VA = "0x182AB6EB0")]
		internal LMMRVMRDBWG(int a, string b, string c, bool d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class SOHGEHFTEYF : PRDHYFHPOCS
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x2AC63B0", Offset = "0x2AC4DB0", VA = "0x182AC63B0")]
		internal SOHGEHFTEYF(int a, string b, string c, bool d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class YSQBYIKFLDQ : PRDHYFHPOCS
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x2AC76A0", Offset = "0x2AC60A0", VA = "0x182AC76A0")]
		internal YSQBYIKFLDQ(int a, string b, string c, bool d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public interface ZSJSVIZVINU
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public interface JXWEBSUSMXN
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public interface EPGAHLMGQGA
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public static class HIUUMHNYSHL
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
		[Cpp2IlInjected.Address(RVA = "0x2AB5720", Offset = "0x2AB4120", VA = "0x182AB5720")]
		public static Func<float, float> KJQLKVKVQJW(Preset a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5ED0", Offset = "0x2AB48D0", VA = "0x182AB5ED0")]
		public static float YGRDLDLCQMU(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5640", Offset = "0x2AB4040", VA = "0x182AB5640")]
		public static float HOGIRTUBROB(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5F20", Offset = "0x2AB4920", VA = "0x182AB5F20")]
		public static float ZVLGJMZNGRG(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5C00", Offset = "0x2AB4600", VA = "0x182AB5C00")]
		public static float LBAYIFWOXCW(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static float FIYQUQJZUXH(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5710", Offset = "0x2AB4110", VA = "0x182AB5710")]
		public static float JPTLNIYZGTO(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5570", Offset = "0x2AB3F70", VA = "0x182AB5570")]
		public static float DXVVHMTNFRJ(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5C70", Offset = "0x2AB4670", VA = "0x182AB5C70")]
		public static float PLTEXOBEJXM(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5C20", Offset = "0x2AB4620", VA = "0x182AB5C20")]
		public static float LPRVXYXDCFB(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5D70", Offset = "0x2AB4770", VA = "0x182AB5D70")]
		public static float TKSWTOJAGFE(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x2AB55C0", Offset = "0x2AB3FC0", VA = "0x182AB55C0")]
		public static float GZNWPAGFCNL(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x2AB55B0", Offset = "0x2AB3FB0", VA = "0x182AB55B0")]
		public static float ESYPHIKVCLI(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5680", Offset = "0x2AB4080", VA = "0x182AB5680")]
		public static float INOCYWYSUUP(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5E50", Offset = "0x2AB4850", VA = "0x182AB5E50")]
		public static float XDJKPRXCMPS(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5DB0", Offset = "0x2AB47B0", VA = "0x182AB5DB0")]
		public static float VCNMTMJSPIG(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5C30", Offset = "0x2AB4630", VA = "0x182AB5C30")]
		public static float PJBMNFHRVYX(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5CF0", Offset = "0x2AB46F0", VA = "0x182AB5CF0")]
		public static float QVUWPVRLICA(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5EE0", Offset = "0x2AB48E0", VA = "0x182AB5EE0")]
		public static float YGZDCGLTQEH(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x2AB56C0", Offset = "0x2AB40C0", VA = "0x182AB56C0")]
		public static float JLGESPMMPUE(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5DC0", Offset = "0x2AB47C0", VA = "0x182AB5DC0")]
		public static float VMIEXTHDASR(float a)
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
		[Cpp2IlInjected.Address(RVA = "0x2AB6770", Offset = "0x2AB5170", VA = "0x182AB6770")]
		public bool AMYJMIBEMML()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x2AB67B0", Offset = "0x2AB51B0", VA = "0x182AB67B0")]
		public string IYBKHNJDPNS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x2AB68B0", Offset = "0x2AB52B0", VA = "0x182AB68B0")]
		public static bool SFWGMFEBQCS(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x2AB6840", Offset = "0x2AB5240", VA = "0x182AB6840")]
		private static bool MXKYSFBQITR(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x2AB6980", Offset = "0x2AB5380", VA = "0x182AB6980")]
		private bool SFWGMFEBQCS()
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
		[Cpp2IlInjected.Address(RVA = "0x2AB6490", Offset = "0x2AB4E90", VA = "0x182AB6490", Slot = "4")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x2AB6510", Offset = "0x2AB4F10", VA = "0x182AB6510")]
		public string IYBKHNJDPNS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x2AB66F0", Offset = "0x2AB50F0", VA = "0x182AB66F0")]
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
		private byte[] DMHLKYQPGDZ;

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public byte[] overrideDecryptionKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x2AB6DD0", Offset = "0x2AB57D0", VA = "0x182AB6DD0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public KeyAuthData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class RFOHFWFSOOL
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		private class MBEPLXIGKLW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			public RenderTexture YCKXJDOPXCX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			public long QEZLNAPXNRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			public bool EFGZHVSHPUV;

			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public MBEPLXIGKLW()
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
		private List<MBEPLXIGKLW[]> JFUMSAITXSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		private MediaPlayer XCUHWHTFBFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		private RenderTexture[] TNBWGIBUNPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		private int CKPMXZUHUQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		private int OXKRXZJCIVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private int YMHSMMQXVRI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private long TEWFQNGVJQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		private float CLXOFIHTVYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		private Material OWZNXRWKKSK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private ResampleMode SLIGLNDSRQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private string PCTMNEAHMDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private long NKTZKUNBCYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private int SVJJRHBUYZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private long QJWTEPRXPCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private int VXNBQKXHHHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private long ZWONNQFGZJN;

		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private const string KLSLUPFLZIY = "_t";

		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private const string SXUBIJTMBSP = "_AfterTex";

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private int XHGCPHXXPTB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private int ADJICCOCARO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private float DEDBPVZHESD;

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		private float QCFBQZKUVME
		{
			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0x165F950", Offset = "0x165E350", VA = "0x18165F950")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		private long MHJMNHKQGSB
		{
			[Cpp2IlInjected.Token(Token = "0x6000439")]
			[Cpp2IlInjected.Address(RVA = "0x2AC3A50", Offset = "0x2AC2450", VA = "0x182AC3A50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public Texture[] VZKTFBDNOWM
		{
			[Cpp2IlInjected.Token(Token = "0x600043C")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x2AC1AA0", Offset = "0x2AC04A0", VA = "0x182AC1AA0")]
		public void KSBAEIENMBK(MediaPlayer a, MediaPlayerEvent.EventType b, ErrorCode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x2AC3A60", Offset = "0x2AC2460", VA = "0x182AC3A60")]
		public RFOHFWFSOOL(MediaPlayer a, string b, int c = 2, ResampleMode d = ResampleMode.LINEAR)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x2AC29C0", Offset = "0x2AC13C0", VA = "0x182AC29C0")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x2AC28E0", Offset = "0x2AC12E0", VA = "0x182AC28E0")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x2AC16F0", Offset = "0x2AC00F0", VA = "0x182AC16F0")]
		private void GLPNEXFBSDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x2AC1B80", Offset = "0x2AC0580", VA = "0x182AC1B80")]
		private void KXCGHQHYGCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x2AC1080", Offset = "0x2ABFA80", VA = "0x182AC1080")]
		private bool FICYVJZBRJI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x2AC2470", Offset = "0x2AC0E70", VA = "0x182AC2470")]
		private int PACZHNORJNF(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x2AC1530", Offset = "0x2ABFF30", VA = "0x182AC1530")]
		private int FZJAUQBXLTZ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x2AC2140", Offset = "0x2AC0B40", VA = "0x182AC2140")]
		private void LOKIKHNNRYH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x2AC1940", Offset = "0x2AC0340", VA = "0x182AC1940")]
		private void HBQBXUHZFZJ(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x2AC37A0", Offset = "0x2AC21A0", VA = "0x182AC37A0")]
		private void VYFNLWWMMSA(int a, int b, int c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x2AC2690", Offset = "0x2AC1090", VA = "0x182AC2690")]
		private void QHQPXQWERKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x2AC1430", Offset = "0x2ABFE30", VA = "0x182AC1430")]
		private void FSFZUNWIVOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x2AC29E0", Offset = "0x2AC13E0", VA = "0x182AC29E0")]
		private float TNSNHRQVZWA()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x2AC2C80", Offset = "0x2AC1680", VA = "0x182AC2C80")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x2AC28C0", Offset = "0x2AC12C0", VA = "0x182AC28C0")]
		public void RCTEIYHFMTN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class QCGBEZDDIHS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public int OYCHLVRRQHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public string HQHAWDTWMHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public double NXNPCFPNSCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public double TISPDQTZOES;

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0A50", Offset = "0x2ABF450", VA = "0x182AC0A50")]
		public bool EPGIZQHQDWV(double a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public QCGBEZDDIHS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public class QDWOFGLBSXX
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0F40", Offset = "0x2ABF940", VA = "0x182AC0F40")]
		private static double KXLCFRLRRNO(string a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0B40", Offset = "0x2ABF540", VA = "0x182AC0B40")]
		public static List<QCGBEZDDIHS> IIFEGZELRIH(string a)
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
		public int LVYPECRPQWF
		{
			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x2AB6EE0", Offset = "0x2AB58E0", VA = "0x182AB6EE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x2AB6F10", Offset = "0x2AB5910", VA = "0x182AB6F10")]
		public LazyShaderProperty(string name)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class ZNNBKSPQQBJ
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
		public static readonly LazyShaderProperty YQETBMWDEJC;

		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public static readonly LazyShaderProperty QDTKKECJMMA;

		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public static readonly LazyShaderProperty RUNOGXKRJAN;

		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public static readonly LazyShaderProperty VFIMCXTZOXK;

		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public static readonly LazyShaderProperty UVMTJSNQOOU;

		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public static readonly LazyShaderProperty XKECSZNUPGN;

		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public static readonly LazyShaderProperty TFVDUFNWLNQ;

		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public static readonly LazyShaderProperty SLLAXSUGJBZ;

		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public static readonly LazyShaderProperty OUOWIFGXLZL;

		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public static readonly LazyShaderProperty CACYFFUXBDL;

		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public static string SQAYFCZUHYB;

		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public static readonly LazyShaderProperty JURDWPVGYEJ;

		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public static readonly LazyShaderProperty HPOGWGZNWHL;

		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public static readonly LazyShaderProperty LGLXTQIVTOL;

		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public static readonly LazyShaderProperty ZWLGIFDCWDM;

		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public static readonly LazyShaderProperty AXAASASNTPH;

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x2AC8D70", Offset = "0x2AC7770", VA = "0x182AC8D70")]
		public static Material KIPKJLDUDYJ(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9950", Offset = "0x2AC8350", VA = "0x182AC9950")]
		public static void YKWXRTANJNU(Material a, VideoMapping b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x2AC76D0", Offset = "0x2AC60D0", VA = "0x182AC76D0")]
		public static void ADPRCWNZXSM(Material a, StereoPacking b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x2AC7D60", Offset = "0x2AC6760", VA = "0x182AC7D60")]
		public static void GNBBADPUOJY(Material a, AlphaPacking b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x2AC93C0", Offset = "0x2AC7DC0", VA = "0x182AC93C0")]
		public static void UIDPTPKTXBN(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x2AC7980", Offset = "0x2AC6380", VA = "0x182AC7980")]
		public static void FYIBGMZNLUN(Material a, Matrix4x4 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9310", Offset = "0x2AC7D10", VA = "0x182AC9310")]
		public static void RMKJIAHLPKF(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x2AC7EA0", Offset = "0x2AC68A0", VA = "0x182AC7EA0")]
		public static Texture GetTexture(MediaPlayer mediaPlayer, int textureIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x2AC8630", Offset = "0x2AC7030", VA = "0x182AC8630")]
		public static void JQCRZQUKWYN(Material a, MediaPlayer b, int c = -1, [Optional] Texture d, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x2AC8E00", Offset = "0x2AC7800", VA = "0x182AC8E00")]
		internal static void RBJJIEVREDG(Material a, bool b, bool c, Matrix4x4 d, Texture e, Matrix4x4 f, VideoMapping g = VideoMapping.Normal, StereoPacking h = StereoPacking.None, AlphaPacking i = AlphaPacking.None)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x2AC7A80", Offset = "0x2AC6480", VA = "0x182AC7A80")]
		public static void GLRCRTENMFM(Material a, VideoResolveOptions b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x2AC8000", Offset = "0x2AC6A00", VA = "0x182AC8000")]
		public static RenderTexture IQIXRHHDJZP(Material a, RenderTexture b, BITCXTOTJGQ c, ResolveFlags d, ScaleMode e = ScaleMode.StretchToFill)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x2AC8BF0", Offset = "0x2AC75F0", VA = "0x182AC8BF0")]
		public static void JUGWFSZXNJY(AlphaPacking a, StereoPacking b, StereoEye c, float d, Matrix4x4 e, int f, int g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9450", Offset = "0x2AC7E50", VA = "0x182AC9450")]
		public static void WSSGFYQSCFP(Rect a, Texture b, ScaleMode c, AlphaPacking d, float e, Material f)
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
	public class OSDBZHPXMWB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		private int VAIKEOETLDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private int BGRTXNTGYWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private int PTFQQYEDTUE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private int KWAPAKPQOPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private int WMASPCMBVRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private CodecType PWWTIYJBVYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private float DXXYZEALGDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private VideoRange QNXUEERTAJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private CodecType EFVNOQHDSPK;

		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private static OSDBZHPXMWB VXYZKTSUCER;

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0800", Offset = "0x2ABF200", VA = "0x182AC0800")]
		public OSDBZHPXMWB(int a, int b, int c, int d, int e = 0, CodecType f = CodecType.unknown, float g = 0f, VideoRange h = VideoRange.SDR, CodecType i = CodecType.unknown)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[DefaultMember("Item")]
	public interface CHWAOZKUFJT : IEnumerable
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
