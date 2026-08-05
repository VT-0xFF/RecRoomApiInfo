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
	public Material PRMMTXGXHIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAA7770", Offset = "0xAA5D70", VA = "0x180AA7770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2A2A1F0", Offset = "0x2A287F0", VA = "0x182A2A1F0")]
	private void OnWillRenderObject()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xAA6840", Offset = "0xAA4E40", VA = "0x180AA6840")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAA7A70", Offset = "0xAA6070", VA = "0x180AA7A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public MediaPath MediaPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAA7770", Offset = "0xAA5D70", VA = "0x180AA7770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public MediaHints Hints
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xF29EE0", Offset = "0xF284E0", VA = "0x180F29EE0")]
			get
			{
				return default(MediaHints);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xF2A030", Offset = "0xF28630", VA = "0x180F2A030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2A382F0", Offset = "0x2A368F0", VA = "0x182A382F0")]
		public MediaReference GetCurrentPlatformMediaReference()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2A38360", Offset = "0x2A36960", VA = "0x182A38360")]
		public MediaReference GetPlatformMediaReference(Platform platform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2A383F0", Offset = "0x2A369F0", VA = "0x182A383F0")]
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
		private GameObject LSHZWYTWIEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool IYNHYWKHCCV;

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
		private Texture WYHFRXAQLKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private LazyShaderProperty BAYEQINPVNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private LazyShaderProperty LKZJAUAAFEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private Texture IXGLFWQAKMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Vector2 HBCWDLQCJYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Vector2 YSSTQYQRPTT;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Color AWVOQAJPWYI
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x16AA050", Offset = "0x16A8650", VA = "0x1816AA050")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x2A2C000", Offset = "0x2A2A600", VA = "0x182A2C000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Texture GSRNUFNSHIX
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAB0EE0", Offset = "0xAAF4E0", VA = "0x180AB0EE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2A2C250", Offset = "0x2A2A850", VA = "0x182A2C250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Texture DHSUZEOTYXI
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xAACD40", Offset = "0xAAB340", VA = "0x180AACD40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2A2BCF0", Offset = "0x2A2A2F0", VA = "0x182A2BCF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float GYLNXRPNCMU
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x1317930", Offset = "0x1315F30", VA = "0x181317930")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2A2BB70", Offset = "0x2A2A170", VA = "0x182A2BB70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Camera CQYZCUMLRHV
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xAACD50", Offset = "0xAAB350", VA = "0x180AACD50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2A2BC20", Offset = "0x2A2A220", VA = "0x182A2BC20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public VideoAspectRatio YEGCFMIPZOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xE77270", Offset = "0xE75870", VA = "0x180E77270")]
			get
			{
				return default(VideoAspectRatio);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x2A2C310", Offset = "0x2A2A910", VA = "0x182A2C310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Vector2 RLUNYUZNVLT
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x1317940", Offset = "0x1315F40", VA = "0x181317940")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2A2BF20", Offset = "0x2A2A520", VA = "0x182A2BF20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Vector2 RZLWHQCJDFG
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x1317290", Offset = "0x1315890", VA = "0x181317290")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2A2BDB0", Offset = "0x2A2A3B0", VA = "0x182A2BDB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Texture2D FAEFBMKNMZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xAD5EB0", Offset = "0xAD44B0", VA = "0x180AD5EB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x2A2BE90", Offset = "0x2A2A490", VA = "0x182A2BE90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public string TGNJFEUTXBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xBD1370", Offset = "0xBCF970", VA = "0x180BD1370")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2A2C160", Offset = "0x2A2A760", VA = "0x182A2C160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Vector2 YKTGULEOTLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2A2BB30", Offset = "0x2A2A130", VA = "0x182A2BB30")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2A2C0C0", Offset = "0x2A2A6C0", VA = "0x182A2C0C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Vector2 ZZGGBTRPGMS
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2A2BB50", Offset = "0x2A2A150", VA = "0x182A2BB50")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x2A2C110", Offset = "0x2A2A710", VA = "0x182A2C110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private Vector2 YLRSJKZRPOM
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x2A2A790", Offset = "0x2A28D90", VA = "0x182A2A790")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2A2A100", Offset = "0x2A28700", VA = "0x182A2A100")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2A2AC90", Offset = "0x2A29290", VA = "0x182A2AC90", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2A2AC40", Offset = "0x2A29240", VA = "0x182A2AC40")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2A2B340", Offset = "0x2A29940", VA = "0x182A2B340")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2A2A400", Offset = "0x2A28A00", VA = "0x182A2A400")]
		public Mesh CreateQuadMesh()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2A2A2A0", Offset = "0x2A288A0", VA = "0x182A2A2A0")]
		public void CreateMaterial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2A2AD70", Offset = "0x2A29370", VA = "0x182A2AD70", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xB03500", Offset = "0xB01B00", VA = "0x180B03500")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2A2B080", Offset = "0x2A29680", VA = "0x182A2B080")]
		public void UpdateMaterialProperties(int target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2A29BC0", Offset = "0x2A281C0", VA = "0x182A29BC0", Slot = "8")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2A2B500", Offset = "0x2A29B00", VA = "0x182A2B500")]
		private void VYFBJTOBUOG(Texture a, bool b, int c = 0, Eye d = Eye.Left)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2A2AA00", Offset = "0x2A29000", VA = "0x182A2AA00", Slot = "6")]
		protected override void MWJNUKLRGHW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2A2A860", Offset = "0x2A28E60", VA = "0x182A2A860", Slot = "7")]
		protected override void HRGRRAKJDSP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2A2B9C0", Offset = "0x2A29FC0", VA = "0x182A2B9C0")]
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
		private Texture WYHFRXAQLKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private LazyShaderProperty BAYEQINPVNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private LazyShaderProperty LKZJAUAAFEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private Texture IXGLFWQAKMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private Vector2 HBCWDLQCJYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private Vector2 YSSTQYQRPTT;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Texture2D FAEFBMKNMZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xAAFEF0", Offset = "0xAAE4F0", VA = "0x180AAFEF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x2A2D1E0", Offset = "0x2A2B7E0", VA = "0x182A2D1E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Material PRMMTXGXHIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xAAFEE0", Offset = "0xAAE4E0", VA = "0x180AAFEE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x2A2D260", Offset = "0x2A2B860", VA = "0x182A2D260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string TGNJFEUTXBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xAB0EE0", Offset = "0xAAF4E0", VA = "0x180AB0EE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x2A2D380", Offset = "0x2A2B980", VA = "0x182A2D380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector2 YKTGULEOTLB
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x2A2D1A0", Offset = "0x2A2B7A0", VA = "0x182A2D1A0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x2A2D2E0", Offset = "0x2A2B8E0", VA = "0x182A2D2E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Vector2 ZZGGBTRPGMS
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x2A2D1C0", Offset = "0x2A2B7C0", VA = "0x182A2D1C0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x2A2D330", Offset = "0x2A2B930", VA = "0x182A2D330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xB03500", Offset = "0xB01B00", VA = "0x180B03500")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2A2C3C0", Offset = "0x2A2A9C0", VA = "0x182A2C3C0", Slot = "8")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2A2CC50", Offset = "0x2A2B250", VA = "0x182A2CC50")]
		private void VYFBJTOBUOG(Texture a, bool b, int c = 0, Eye d = Eye.Left)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2A2CA50", Offset = "0x2A2B050", VA = "0x182A2CA50", Slot = "6")]
		protected override void MWJNUKLRGHW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2A2C8E0", Offset = "0x2A2AEE0", VA = "0x182A2C8E0", Slot = "7")]
		protected override void HRGRRAKJDSP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2A2D050", Offset = "0x2A2B650", VA = "0x182A2D050")]
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
		private Texture WYHFRXAQLKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private LazyShaderProperty BAYEQINPVNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private LazyShaderProperty LKZJAUAAFEW;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Texture2D FAEFBMKNMZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xAAFEF0", Offset = "0xAAE4F0", VA = "0x180AAFEF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x2A2D9D0", Offset = "0x2A2BFD0", VA = "0x182A2D9D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Renderer KNYBYCYWKZE
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xAAFEE0", Offset = "0xAAE4E0", VA = "0x180AAFEE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x2A2DA80", Offset = "0x2A2C080", VA = "0x182A2DA80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public int ZHOZJDNQAIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xB9A680", Offset = "0xB98C80", VA = "0x180B9A680")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x1071FA0", Offset = "0x10705A0", VA = "0x181071FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public string TGNJFEUTXBD
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xAACD40", Offset = "0xAAB340", VA = "0x180AACD40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x2A2E330", Offset = "0x2A2C930", VA = "0x182A2E330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector2 YKTGULEOTLB
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x2A2D1C0", Offset = "0x2A2B7C0", VA = "0x182A2D1C0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x2A2D330", Offset = "0x2A2B930", VA = "0x182A2D330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector2 ZZGGBTRPGMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x2A2E2C0", Offset = "0x2A2C8C0", VA = "0x182A2E2C0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x2A2E2E0", Offset = "0x2A2C8E0", VA = "0x182A2E2E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2A2D9D0", Offset = "0x2A2BFD0", VA = "0x182A2D9D0")]
		private void CWQVXRUGZMA(Texture2D a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2A2DA80", Offset = "0x2A2C080", VA = "0x182A2DA80")]
		private void HNWZUZXQITJ(Renderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xB03500", Offset = "0xB01B00", VA = "0x180B03500")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2A2D450", Offset = "0x2A2BA50", VA = "0x182A2D450", Slot = "8")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2A2DD70", Offset = "0x2A2C370", VA = "0x182A2DD70")]
		private void VYFBJTOBUOG(Texture a, bool b, int c, Eye d = Eye.Left, int e = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2A2DC30", Offset = "0x2A2C230", VA = "0x182A2DC30", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2A2DC00", Offset = "0x2A2C200", VA = "0x182A2DC00", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2A2DB60", Offset = "0x2A2C160", VA = "0x182A2DB60", Slot = "6")]
		protected override void MWJNUKLRGHW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2A2E1F0", Offset = "0x2A2C7F0", VA = "0x182A2E1F0")]
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
		private const int GQVMQIZYTHE = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[Range(0f, 1f)]
		[SerializeField]
		private float[] _channels;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float[] ICXEEOASQPN
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xAA7770", Offset = "0xAA5D70", VA = "0x180AA7770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2A2E6C0", Offset = "0x2A2CCC0", VA = "0x182A2E6C0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2A2E410", Offset = "0x2A2CA10", VA = "0x182A2E410")]
		private void JLWZIOQYUZA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2A2E510", Offset = "0x2A2CB10", VA = "0x182A2E510")]
		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xAA6840", Offset = "0xAA4E40", VA = "0x180AA6840")]
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
		private int JBDCOOKMUMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private AudioSource HSIAYJLAZCM;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public MediaPlayer EIEFMZKSIFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2A2F210", Offset = "0x2A2D810", VA = "0x182A2F210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public AudioOutputMode XAXLCEITQBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAA7700", Offset = "0xAA5D00", VA = "0x180AA7700")]
			get
			{
				return default(AudioOutputMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xAA7780", Offset = "0xAA5D80", VA = "0x180AA7780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int WQEFVZQHJDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xC531C0", Offset = "0xC517C0", VA = "0x180C531C0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x1DF76B0", Offset = "0x1DF5CB0", VA = "0x181DF76B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2A2E750", Offset = "0x2A2CD50", VA = "0x182A2E750")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2A2EED0", Offset = "0x2A2D4D0", VA = "0x182A2EED0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2A2ECC0", Offset = "0x2A2D2C0", VA = "0x182A2ECC0")]
		private void NHBQVYAXJBB(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2A2EE20", Offset = "0x2A2D420", VA = "0x182A2EE20")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2A2EF50", Offset = "0x2A2D550", VA = "0x182A2EF50")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xAAFEF0", Offset = "0xAAE4F0", VA = "0x180AAFEF0")]
		public AudioSource GetAudioSource()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2A2EE30", Offset = "0x2A2D430", VA = "0x182A2EE30")]
		public void SetAudioSource(AudioSource source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2A2E7A0", Offset = "0x2A2CDA0", VA = "0x182A2E7A0")]
		public void ChangeMediaPlayer(MediaPlayer newPlayer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2A2EC60", Offset = "0x2A2D260", VA = "0x182A2EC60")]
		private void DFYFTAWCHGC(MediaPlayer a, MediaPlayerEvent.EventType b, ErrorCode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2A2F030", Offset = "0x2A2D630", VA = "0x182A2F030")]
		private static void WGGSPVXVWLV(MediaPlayer a, AudioSource b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2A2EDA0", Offset = "0x2A2D3A0", VA = "0x182A2EDA0")]
		private void OnAudioFilterRead(float[] audioData, int channelCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2A2F1F0", Offset = "0x2A2D7F0", VA = "0x182A2F1F0")]
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
		private static Shader ZVSBJTWOXPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private Material VUDPHIHDOTC;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public MediaPlayer EIEFMZKSIFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x2A2FFF0", Offset = "0x2A2E5F0", VA = "0x182A2FFF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public ScaleMode ABZZRRVDMHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAA7700", Offset = "0xAA5D00", VA = "0x180AA7700")]
			get
			{
				return default(ScaleMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xAA7780", Offset = "0xAA5D80", VA = "0x180AA7780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Color HHPEXJZUJFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2A2FFC0", Offset = "0x2A2E5C0", VA = "0x182A2FFC0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x2A2FFE0", Offset = "0x2A2E5E0", VA = "0x182A2FFE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool NJJZVXEKCXV
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xF75580", Offset = "0xF73B80", VA = "0x180F75580")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x102BCC0", Offset = "0x102A2C0", VA = "0x18102BCC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool RCOCXHGBMUE
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x102B970", Offset = "0x1029F70", VA = "0x18102B970")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x102B2C0", Offset = "0x10298C0", VA = "0x18102B2C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public int TSGYNPVUBJP
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xAC4500", Offset = "0xAC2B00", VA = "0x180AC4500")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xB89800", Offset = "0xB87E00", VA = "0x180B89800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool XKLRUHXKUDG
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x1A25B40", Offset = "0x1A24140", VA = "0x181A25B40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x1A25C80", Offset = "0x1A24280", VA = "0x181A25C80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float POCBVAFDIRZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x127C380", Offset = "0x127A980", VA = "0x18127C380")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2A2FFD0", Offset = "0x2A2E5D0", VA = "0x182A2FFD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public float PNWUXTLFZGQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xF99200", Offset = "0xF97800", VA = "0x180F99200")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xF99210", Offset = "0xF97810", VA = "0x180F99210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float HQCKUZAPQKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xAF57E0", Offset = "0xAF3DE0", VA = "0x180AF57E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x10ED200", Offset = "0x10EB800", VA = "0x1810ED200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float ANXAGDZBWLY
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x10FACA0", Offset = "0x10F92A0", VA = "0x1810FACA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x10FAC80", Offset = "0x10F9280", VA = "0x1810FAC80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool HZHWEOPZJVM
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xE57650", Offset = "0xE55C50", VA = "0x180E57650")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xE57840", Offset = "0xE55E40", VA = "0x180E57840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2A2FC70", Offset = "0x2A2E270", VA = "0x182A2FC70")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2A2FDA0", Offset = "0x2A2E3A0", VA = "0x182A2FDA0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2A2F530", Offset = "0x2A2DB30", VA = "0x182A2F530")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2A2F4F0", Offset = "0x2A2DAF0", VA = "0x182A2F4F0")]
		private Shader MFIFIQLJSFO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2A2F220", Offset = "0x2A2D820", VA = "0x182A2F220")]
		private void EEIMRISYTCQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2A2F5D0", Offset = "0x2A2DBD0", VA = "0x182A2F5D0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2A2F3C0", Offset = "0x2A2D9C0", VA = "0x182A2F3C0")]
		public Rect GetAreaRect()
		{
			return default(Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2A2FF90", Offset = "0x2A2E590", VA = "0x182A2FF90")]
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
			[Cpp2IlInjected.Address(RVA = "0x2A387D0", Offset = "0x2A36DD0", VA = "0x182A387D0", Slot = "4")]
			public virtual string ZPVNKXNCYUD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xFDE8C0", Offset = "0xFDCEC0", VA = "0x180FDE8C0", Slot = "5")]
			public virtual byte[] MJCPAWSNXVG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "6")]
			public virtual bool HOPFBFFZKMZ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x2A387F0", Offset = "0x2A36DF0", VA = "0x182A387F0")]
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
			public CJHFJWBAPDL.VideoApi videoApi;

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
			public CJHFJWBAPDL.AudioOutput _audioMode;

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
			[Cpp2IlInjected.Address(RVA = "0xE0B300", Offset = "0xE09900", VA = "0x180E0B300", Slot = "6")]
			public override bool HOPFBFFZKMZ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "7")]
			private void PSCOJVPHXVA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x2A386F0", Offset = "0x2A36CF0", VA = "0x182A386F0", Slot = "8")]
			private void ZGWJOOHMTOK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x2A38720", Offset = "0x2A36D20", VA = "0x182A38720")]
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
			public LYTNTHMEUIP.VideoApi videoApi;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public LYTNTHMEUIP.AudioOutput _audioMode;

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
			[Cpp2IlInjected.Address(RVA = "0xF83F40", Offset = "0xF82540", VA = "0x180F83F40", Slot = "6")]
			public override bool HOPFBFFZKMZ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x2A386D0", Offset = "0x2A36CD0", VA = "0x182A386D0")]
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
			private readonly TextureFormat NGQHKZLJGOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			private readonly Flags SHTAZKYGQEU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public TextureFormat textureFormat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private AudioMode MSANBHZRJOB;

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
			private ChangeFlags OEROPWPNGVZ;

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
				[Cpp2IlInjected.Address(RVA = "0x2A38620", Offset = "0x2A36C20", VA = "0x182A38620")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000065")]
			public Flags flags
			{
				[Cpp2IlInjected.Token(Token = "0x6000145")]
				[Cpp2IlInjected.Address(RVA = "0x2A38640", Offset = "0x2A36C40", VA = "0x182A38640")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x2A38570", Offset = "0x2A36B70", VA = "0x182A38570")]
			public OptionsApple(TextureFormat defaultTextureFormat, Flags defaultFlags)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public class OptionsAndroid : PlatformOptions, ISerializationCallbackReceiver
		{
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			[Flags]
			public enum ChangeFlags
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
			private ChangeFlags OEROPWPNGVZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private readonly TextureFormat NGQHKZLJGOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public TextureFormat textureFormat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			[SerializeField]
			private bool _generateMipmaps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			private AudioMode MSANBHZRJOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			[SerializeField]
			private AudioMode _audioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			[SerializeField]
			private Resolution _preferredMaximumResolution;

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
			private BitRateUnits _preferredPeakBitRateUnits;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public Android.VideoApi videoApi;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public bool showPosterFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public Audio360ChannelMode audio360ChannelMode;

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
			[SerializeField]
			[HideInInspector]
			private bool enableAudio360;

			[Cpp2IlInjected.Token(Token = "0x17000066")]
			public AudioMode audioMode
			{
				[Cpp2IlInjected.Token(Token = "0x6000147")]
				[Cpp2IlInjected.Address(RVA = "0xAF4D30", Offset = "0xAF3330", VA = "0x180AF4D30")]
				get
				{
					return default(AudioMode);
				}
				[Cpp2IlInjected.Token(Token = "0x6000148")]
				[Cpp2IlInjected.Address(RVA = "0x2A38550", Offset = "0x2A36B50", VA = "0x182A38550")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xAB2910", Offset = "0xAB0F10", VA = "0x180AB2910", Slot = "6")]
			public override bool HOPFBFFZKMZ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "7")]
			private void PSCOJVPHXVA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x2A384B0", Offset = "0x2A36AB0", VA = "0x182A384B0", Slot = "8")]
			private void ZGWJOOHMTOK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x2A384E0", Offset = "0x2A36AE0", VA = "0x182A384E0")]
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
			public enum ChangeFlags
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
			private ChangeFlags OEROPWPNGVZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			private readonly TextureFormat NGQHKZLJGOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public TextureFormat textureFormat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			[SerializeField]
			private bool _generateMipmapsOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private AudioMode MSANBHZRJOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			[SerializeField]
			private AudioMode _audioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			[SerializeField]
			private Resolution _preferredMaximumResolution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			[SerializeField]
			private Vector2Int _customPreferredMaximumResolution;

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "7")]
			private void PSCOJVPHXVA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "8")]
			private void ZGWJOOHMTOK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x2A38670", Offset = "0x2A36C70", VA = "0x182A38670")]
			public OptionsOpenHarmony()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public class OptionsWebGL : PlatformOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			public enum ChangeFlags
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
			private ChangeFlags OEROPWPNGVZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public ZYUIMLQIOPH.ExternalLibrary externalLibrary;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public bool useTextureMips;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			private AudioMode MSANBHZRJOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			[SerializeField]
			private AudioMode _audioMode;

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "4")]
			public override string ZPVNKXNCYUD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "5")]
			public override byte[] MJCPAWSNXVG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x2A386C0", Offset = "0x2A36CC0", VA = "0x182A386C0")]
			public OptionsWebGL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private enum FileLocation
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
		private sealed class VNXWLMUADEI : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			private object MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public Texture2D RVVMCDZALOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public MediaPlayer CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public double DAMCEFSBOMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public int PCTDWMQOWLS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public bool VUMVLLQMRWW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public ProcessExtractedFrame CXPPTSBKHFV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			private Texture2D AXYIYYGHGTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			private int NYBKNPBGXNT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			private int XJBCAZHZDOV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			private int FSKVVDNZQWU;

			[Cpp2IlInjected.Token(Token = "0x17000067")]
			private object ENGTUJRFGYV
			{
				[Cpp2IlInjected.Token(Token = "0x6000156")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x6000158")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0xAA9B40", Offset = "0xAA8140", VA = "0x180AA9B40")]
			[DebuggerHidden]
			public VNXWLMUADEI(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x2A3CD20", Offset = "0x2A3B320", VA = "0x182A3CD20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x2A3D230", Offset = "0x2A3B830", VA = "0x182A3D230", Slot = "8")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class FKSWOHMUHGA : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			private object MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public MediaPlayer CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private YieldInstruction IDCQBKUFDVC;

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			private object ENGTUJRFGYV
			{
				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x600015E")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xAA9B40", Offset = "0xAA8140", VA = "0x180AA9B40")]
			[DebuggerHidden]
			public FKSWOHMUHGA(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x2A30020", Offset = "0x2A2E620", VA = "0x182A30020", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x2A30140", Offset = "0x2A2E740", VA = "0x182A30140", Slot = "8")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class YITGSISALHS : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private object MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public string JGOQMHFWDFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			public MediaPlayer CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public MediaPath OKNQYNGSQMT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private UnityWebRequest MANODADWFHU;

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			private object ENGTUJRFGYV
			{
				[Cpp2IlInjected.Token(Token = "0x6000162")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x6000164")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0xAA9B40", Offset = "0xAA8140", VA = "0x180AA9B40")]
			[DebuggerHidden]
			public YITGSISALHS(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x2A3D270", Offset = "0x2A3B870", VA = "0x182A3D270", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x2A3D4D0", Offset = "0x2A3BAD0", VA = "0x182A3D4D0", Slot = "8")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
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
		private AudioSource HSIAYJLAZCM;

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
		private IPMJYMMWIHF.ResampleMode _resampleMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[FormerlySerializedAs("m_ResampleBufferSize")]
		[Range(3f, 10f)]
		[SerializeField]
		private int _resampleBufferSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private IPMJYMMWIHF PIGATODMSKU;

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
		protected ZRCJHFWYBKC IPJNSZEUYDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private IILUKYABAEO MPFFNQWLTTT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private RPDJCBIELFW PAOYYFCXNWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private EECQGSYCGYN GHLXFPFMETS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private NAENQYJIMZW PIMRGFGOTKT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private DVKTIHIMJHE UTKZTVFRTYR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private FYZZTPJCZUZ PLHXFPCJHKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private FTURTUKZXFE ZZHPTYLUECP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private WCMCARWXVVZ XALAVOWLSVC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private VZCLVKGQUTK GKSWPMSIRGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private IQUJBWYXMLP XWQDDDPYEBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private IDisposable OAJOCPWLSYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private bool OPPFDVRHFZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x141")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private bool FGLBXMJYGJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x142")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private bool CJTDOQWDZUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private Coroutine MYTDUWIUICH;

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private static bool FGAHWOSANUO;

		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private static bool XVNDTFZLCSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private MediaPath KTMVUHSCEGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private Coroutine CJYVMWXSPGS;

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static Camera NFXWCBGQSSA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private bool JUSUQSSEELM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x161")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private bool DISDFVHOMLQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x162")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private bool VAJQNWYLGST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x163")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private bool DKZIEHQDGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private bool LAIXHMDDUUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x165")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private bool MEACYDULNKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x166")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private bool CMZPQSFWVEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x167")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private bool QMQDUGSLJXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private int QPQQFJMCBBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private int GQGFOHADFWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private int PHLTLVIXXGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private bool VWSRSXETQXK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x175")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private bool BFIQFVLTGVR;

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
		public MediaSource QXWUFCFHZJT
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAB7670", Offset = "0xAB5C70", VA = "0x180AB7670")]
			get
			{
				return default(MediaSource);
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xAFA730", Offset = "0xAF8D30", VA = "0x180AFA730")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public MediaReference UGKNFXFPDDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAAFED0", Offset = "0xAAE4D0", VA = "0x180AAFED0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xAA8690", Offset = "0xAA6C90", VA = "0x180AA8690")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MediaPath XDVCAKFQVLZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6C0", Offset = "0xAA9CC0", VA = "0x180AAB6C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9B0", Offset = "0xAA8FB0", VA = "0x180AAA9B0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public MediaHints XESNJRFVUBW
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x1B846D0", Offset = "0x1B82CD0", VA = "0x181B846D0")]
			get
			{
				return default(MediaHints);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x1AC5830", Offset = "0x1AC3E30", VA = "0x181AC5830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool AALMCVAAAWH
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x1A25B40", Offset = "0x1A24140", VA = "0x181A25B40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x1A25C80", Offset = "0x1A24280", VA = "0x181A25C80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool ZEKGCUGJLGF
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2A37960", Offset = "0x2A35F60", VA = "0x182A37960")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x2A37F80", Offset = "0x2A36580", VA = "0x182A37F80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool CTLVXSOCZNQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x2A37A60", Offset = "0x2A36060", VA = "0x182A37A60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x2A37F90", Offset = "0x2A36590", VA = "0x182A37F90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public virtual float GIFERMEGKRC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x2A37900", Offset = "0x2A35F00", VA = "0x182A37900", Slot = "6")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x2A37F00", Offset = "0x2A36500", VA = "0x182A37F00", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float IZFMBUBKEHQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x2A37840", Offset = "0x2A35E40", VA = "0x182A37840")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x2A37E10", Offset = "0x2A36410", VA = "0x182A37E10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public virtual bool WGTUOCCVVSV
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x2A378A0", Offset = "0x2A35EA0", VA = "0x182A378A0", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x2A37E90", Offset = "0x2A36490", VA = "0x182A37E90", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public AudioSource GDQASOAGJVZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xAACA80", Offset = "0xAAB080", VA = "0x180AACA80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xAACAA0", Offset = "0xAAB0A0", VA = "0x180AACAA0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float QWEVWHOBYIT
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2A37AF0", Offset = "0x2A360F0", VA = "0x182A37AF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x2A38030", Offset = "0x2A36630", VA = "0x182A38030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool WTTIRRYMOJU
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xAB2910", Offset = "0xAB0F10", VA = "0x180AB2910")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xAB2950", Offset = "0xAB0F50", VA = "0x180AB2950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public IPMJYMMWIHF.ResampleMode IUNPEUIZGMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xE77270", Offset = "0xE75870", VA = "0x180E77270")]
			get
			{
				return default(IPMJYMMWIHF.ResampleMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xF6D7D0", Offset = "0xF6BDD0", VA = "0x180F6D7D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public int VWVWXIAIVZC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xF33200", Offset = "0xF31800", VA = "0x180F33200")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x2A380A0", Offset = "0x2A366A0", VA = "0x182A380A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public IPMJYMMWIHF RYDSLHXLPZC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xAACA90", Offset = "0xAAB090", VA = "0x180AACA90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public VideoMapping WPQTOSDITUN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xACDC30", Offset = "0xACC230", VA = "0x180ACDC30")]
			get
			{
				return default(VideoMapping);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x164CEA0", Offset = "0x164B4A0", VA = "0x18164CEA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public FilterMode TQTOVCWYMQK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x2A37C40", Offset = "0x2A36240", VA = "0x182A37C40")]
			get
			{
				return default(FilterMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x2A38120", Offset = "0x2A36720", VA = "0x182A38120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public TextureWrapMode MQHYFQJBMCA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x2A37D20", Offset = "0x2A36320", VA = "0x182A37D20")]
			get
			{
				return default(TextureWrapMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x2A381A0", Offset = "0x2A367A0", VA = "0x182A381A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public int VBXHPDBLAPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x2A37B50", Offset = "0x2A36150", VA = "0x182A37B50")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x2A380B0", Offset = "0x2A366B0", VA = "0x182A380B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool RYJXMYEVZKE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xB8E3C0", Offset = "0xB8C9C0", VA = "0x180B8E3C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xB8E340", Offset = "0xB8C940", VA = "0x180B8E340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public MediaPath DBYFEEPZSBR
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xAD5EB0", Offset = "0xAD44B0", VA = "0x180AD5EB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xBD1340", Offset = "0xBCF940", VA = "0x180BD1340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public Transform DEKIZWHOQVG
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xAB4A30", Offset = "0xAB3030", VA = "0x180AB4A30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xAB4A50", Offset = "0xAB3050", VA = "0x180AB4A50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool NLREWVYEHUP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xB9A640", Offset = "0xB98C40", VA = "0x180B9A640")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xB9A6B0", Offset = "0xB98CB0", VA = "0x180B9A6B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public Transform DOKDLZCVIDI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xAA9E40", Offset = "0xAA8440", VA = "0x180AA9E40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xAAA150", Offset = "0xAA8750", VA = "0x180AAA150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public float QITVKHOSVKD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x1125F20", Offset = "0x1124520", VA = "0x181125F20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x1126340", Offset = "0x1124940", VA = "0x181126340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public float NRAAFVKQCAN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x11261E0", Offset = "0x11247E0", VA = "0x1811261E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x1126480", Offset = "0x1124A80", VA = "0x181126480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public HttpHeaderData PDXQUGMDCHU
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0xF66510", Offset = "0xF64B10", VA = "0x180F66510")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xCB9290", Offset = "0xCB7890", VA = "0x180CB9290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public KeyAuthData ANWCLYNZARP
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xBD1240", Offset = "0xBCF840", VA = "0x180BD1240")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xF4C980", Offset = "0xF4AF80", VA = "0x180F4C980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public MediaPlayerEvent SGABYGXHOTL
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x2A37970", Offset = "0x2A35F70", VA = "0x182A37970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public int PCALCZMSOHK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x1126A50", Offset = "0x1125050", VA = "0x181126A50")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x1125520", Offset = "0x1123B20", VA = "0x181125520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public bool BCPKXAVKXVS
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x2A37AC0", Offset = "0x2A360C0", VA = "0x182A37AC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x2A38000", Offset = "0x2A36600", VA = "0x182A38000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool OBCNEWVTLQZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x2A37AE0", Offset = "0x2A360E0", VA = "0x182A37AE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x2A38020", Offset = "0x2A36620", VA = "0x182A38020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool FFPKQUXIJAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x2A37AD0", Offset = "0x2A360D0", VA = "0x182A37AD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x2A38010", Offset = "0x2A36610", VA = "0x182A38010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public FileFormat JZEHINIAGGO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0xB10A60", Offset = "0xB0F060", VA = "0x180B10A60")]
			get
			{
				return default(FileFormat);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xB109C0", Offset = "0xB0EFC0", VA = "0x180B109C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public virtual EECQGSYCGYN WCIGPDCOHYY
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xB95B50", Offset = "0xB94150", VA = "0x180B95B50", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public virtual IILUKYABAEO ISOVNFCRTUB
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xB10300", Offset = "0xB0E900", VA = "0x180B10300", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public virtual NAENQYJIMZW EIEFMZKSIFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xB14AC0", Offset = "0xB130C0", VA = "0x180B14AC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public virtual RPDJCBIELFW JNQNLCFDCWR
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xB0E9A0", Offset = "0xB0CFA0", VA = "0x180B0E9A0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual DVKTIHIMJHE JBYHTSJFMBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xB102F0", Offset = "0xB0E8F0", VA = "0x180B102F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public virtual FTURTUKZXFE LENFRTKEOYD
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xB10260", Offset = "0xB0E860", VA = "0x180B10260", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual WCMCARWXVVZ GSWJQVUGIDY
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xB97E60", Offset = "0xB96460", VA = "0x180B97E60", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual VZCLVKGQUTK MVTJOZOFDXN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xC35AE0", Offset = "0xC340E0", VA = "0x180C35AE0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual IQUJBWYXMLP LPMAMHXQZNI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xCB11E0", Offset = "0xCAF7E0", VA = "0x180CB11E0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public virtual FYZZTPJCZUZ QILDRDLSBRE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xB97D70", Offset = "0xB96370", VA = "0x180B97D70", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool HDFQWNHDJMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xC36280", Offset = "0xC34880", VA = "0x180C36280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public OptionsWindows OBMWOLVBYFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0xCAFE90", Offset = "0xCAE490", VA = "0x180CAFE90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public OptionsApple MKZEOAJGGKR
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xCAFE80", Offset = "0xCAE480", VA = "0x180CAFE80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public OptionsApple LTOICQFKOXH
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0xCAFF10", Offset = "0xCAE510", VA = "0x180CAFF10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public OptionsApple LHGBJVZRELS
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0xCAAB30", Offset = "0xCA9130", VA = "0x180CAAB30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public OptionsApple YTAIEPXPZHI
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0xBAA9F0", Offset = "0xBA8FF0", VA = "0x180BAA9F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public OptionsAndroid CTPRBOHVMKK
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0xB24700", Offset = "0xB22D00", VA = "0x180B24700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public OptionsOpenHarmony XSBWAPZRRXF
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0xBA2950", Offset = "0xBA0F50", VA = "0x180BA2950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public OptionsWindowsUWP AJDOLOGYOUM
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0xBB79F0", Offset = "0xBB5FF0", VA = "0x180BB79F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public OptionsWebGL RCJQZBFKRQA
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xBDDB80", Offset = "0xBDC180", VA = "0x180BDDB80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xAFA730", Offset = "0xAF8D30", VA = "0x180AFA730")]
		public void SetMediaSource(MediaSource source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xAA8690", Offset = "0xAA6C90", VA = "0x180AA8690")]
		public void SetMediaReference(MediaReference media)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xAAA9B0", Offset = "0xAA8FB0", VA = "0x180AAA9B0")]
		public void SetMediaPath(MediaPath path)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xAACAA0", Offset = "0xAAB0A0", VA = "0x180AACAA0")]
		public void SetAudioSource(AudioSource audioSource)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2A31DA0", Offset = "0x2A303A0", VA = "0x182A31DA0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2A31E10", Offset = "0x2A30410", VA = "0x182A31E10")]
		protected void BKMOQAJLSTF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2A36440", Offset = "0x2A34A40", VA = "0x182A36440")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2A353E0", Offset = "0x2A339E0", VA = "0x182A353E0")]
		public bool OpenMedia(MediaPath path, bool autoPlay = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2A352E0", Offset = "0x2A338E0", VA = "0x182A352E0")]
		public bool OpenMedia(MediaPathType pathType, string path, bool autoPlay = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2A35390", Offset = "0x2A33990", VA = "0x182A35390")]
		public bool OpenMedia(MediaReference mediaReference, bool autoPlay = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2A35360", Offset = "0x2A33960", VA = "0x182A35360")]
		public bool OpenMedia(bool autoPlay = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2A34030", Offset = "0x2A32630", VA = "0x182A34030")]
		private bool JZMLGBSGQZZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2A36680", Offset = "0x2A34C80", VA = "0x182A36680")]
		private void UWKRNOWRHNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2A32930", Offset = "0x2A30F30", VA = "0x182A32930")]
		private void DEUJSANDJSB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2A32410", Offset = "0x2A30A10", VA = "0x182A32410")]
		public void CloseMedia()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2A35670", Offset = "0x2A33C70", VA = "0x182A35670", Slot = "20")]
		public virtual void Play()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2A355F0", Offset = "0x2A33BF0", VA = "0x182A355F0", Slot = "21")]
		public virtual void Pause()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2A36550", Offset = "0x2A34B50", VA = "0x182A36550")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2A35B10", Offset = "0x2A34110", VA = "0x182A35B10")]
		public void Rewind(bool pause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2A36280", Offset = "0x2A34880", VA = "0x182A36280")]
		public void SeekToLiveTime(double offset = 0.0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2A368F0", Offset = "0x2A34EF0", VA = "0x182A368F0", Slot = "22")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2A34640", Offset = "0x2A32C40", VA = "0x182A34640")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2A357D0", Offset = "0x2A33DD0", VA = "0x182A357D0")]
		private void QWELZUFACFS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2A351A0", Offset = "0x2A337A0", VA = "0x182A351A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2A350E0", Offset = "0x2A336E0", VA = "0x182A350E0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2A34F60", Offset = "0x2A33560", VA = "0x182A34F60", Slot = "23")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2A33550", Offset = "0x2A31B50", VA = "0x182A33550")]
		public void ForceDispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2A34B20", Offset = "0x2A33120", VA = "0x182A34B20")]
		private static void OTNVGHYXOCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2A34D30", Offset = "0x2A33330", VA = "0x182A34D30")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2A33C90", Offset = "0x2A32290", VA = "0x182A33C90")]
		protected void HZGJBTGOCMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2A36FB0", Offset = "0x2A355B0", VA = "0x182A36FB0")]
		private void YNGXNYUOGBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2A34AB0", Offset = "0x2A330B0", VA = "0x182A34AB0")]
		[IteratorStateMachine(typeof(FKSWOHMUHGA))]
		private IEnumerator ODUYLJJECRQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860")]
		public static Platform GetPlatform()
		{
			return default(Platform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xCAFE90", Offset = "0xCAE490", VA = "0x180CAFE90")]
		public PlatformOptions GetCurrentPlatformOptions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2A35760", Offset = "0x2A33D60", VA = "0x182A35760")]
		private string QTLOSOILNJZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860")]
		private long WMDCJIKEPBQ()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2A33620", Offset = "0x2A31C20", VA = "0x182A33620")]
		private string GFRNWLOBQMW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2A35700", Offset = "0x2A33D00", VA = "0x182A35700")]
		private string QMOIHRXOSYR(string a, MediaPathType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2A32A60", Offset = "0x2A31060", VA = "0x182A32A60")]
		private static ZRCJHFWYBKC DFHJVNMCNOF(OptionsWindows a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2A33C40", Offset = "0x2A32240", VA = "0x182A33C40")]
		private static ZRCJHFWYBKC HFBLQILHFYI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2A32580", Offset = "0x2A30B80", VA = "0x182A32580", Slot = "24")]
		public virtual ZRCJHFWYBKC CreateMediaPlayer()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2A358D0", Offset = "0x2A33ED0", VA = "0x182A358D0")]
		private void RIAGJPUJYGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2A354A0", Offset = "0x2A33AA0", VA = "0x182A354A0")]
		private void PMFZNNDJPRP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2A34940", Offset = "0x2A32F40", VA = "0x182A34940")]
		private void NJDQIZKHAWG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0")]
		public bool IsUsingAndroidOESPath()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0")]
		public bool IsUsingYCbCr()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2A35F90", Offset = "0x2A34590", VA = "0x182A35F90")]
		[ContextMenu("Save Frame To PNG")]
		public void SaveFrameToPng()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2A35B90", Offset = "0x2A34190", VA = "0x182A35B90")]
		[ContextMenu("Save Frame To EXR")]
		public void SaveFrameToExr()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		private void OnApplicationFocus(bool focusStatus)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2A33520", Offset = "0x2A31B20", VA = "0x182A33520")]
		private void FRNGWJPGCNY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2A365B0", Offset = "0x2A34BB0", VA = "0x182A365B0")]
		private void UTAEAQACONZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2A33D50", Offset = "0x2A32350", VA = "0x182A33D50")]
		private void JCWIGMMQOGX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2A31830", Offset = "0x2A2FE30", VA = "0x182A31830")]
		private void APKMCVMVMBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2A371D0", Offset = "0x2A357D0", VA = "0x182A371D0")]
		private void ZUXCSLDLIQI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2A36D30", Offset = "0x2A35330", VA = "0x182A36D30")]
		protected bool VSYVMOPXCCO(MediaPlayerEvent.EventType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2A35410", Offset = "0x2A33A10", VA = "0x182A35410")]
		private bool PDLLOUICQSM(MediaPlayerEvent.EventType a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2A336D0", Offset = "0x2A31CD0", VA = "0x182A336D0")]
		private bool GWXVKFGRNXY(MediaPlayerEvent.EventType a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2A34780", Offset = "0x2A32D80", VA = "0x182A34780")]
		private bool MCGAODJEYLQ(int a, float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2A36D60", Offset = "0x2A35360", VA = "0x182A36D60")]
		private static Camera XQZYFLZDCYH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2A37000", Offset = "0x2A35600", VA = "0x182A37000")]
		[IteratorStateMachine(typeof(VNXWLMUADEI))]
		private IEnumerator YSGGRJXBRZW(Texture2D a, ProcessExtractedFrame b, double c = -1.0, bool d = true, int e = 1000, int f = 100)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2A330C0", Offset = "0x2A316C0", VA = "0x182A330C0")]
		public void ExtractFrameAsync(Texture2D target, ProcessExtractedFrame callback, double timeSeconds = -1.0, bool accurateSeek = true, int timeoutMs = 1000, int timeThresholdMs = 100)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2A33190", Offset = "0x2A31790", VA = "0x182A33190")]
		public Texture2D ExtractFrame(Texture2D target, double timeSeconds = -1.0, bool accurateSeek = true, int timeoutMs = 1000, int timeThresholdMs = 100)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2A33DE0", Offset = "0x2A323E0", VA = "0x182A33DE0")]
		private Texture JRGNPIXNBVM(double a = -1.0, bool b = true, int c = 1000, int d = 100)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x2A35220", Offset = "0x2A33820", VA = "0x182A35220")]
		public bool OpenMediaFromBuffer(byte[] buffer, bool autoPlay = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x2A36380", Offset = "0x2A34980", VA = "0x182A36380")]
		public bool StartOpenChunkedMediaFromBuffer(ulong length, bool autoPlay = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2A31C80", Offset = "0x2A30280", VA = "0x182A31C80")]
		public bool AddChunkToVideoBuffer(byte[] chunk, ulong offset, ulong chunkSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2A33040", Offset = "0x2A31640", VA = "0x182A33040")]
		public bool EndOpenChunkedVideoFromBuffer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2A33310", Offset = "0x2A31910", VA = "0x182A33310")]
		private bool FDARWLQSZTJ(byte[] a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2A31A70", Offset = "0x2A30070", VA = "0x182A31A70")]
		private bool ATRDGZNTQHR(ulong a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2A31C80", Offset = "0x2A30280", VA = "0x182A31C80")]
		private bool DJFXMAMCUGS(byte[] a, ulong b, ulong c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2A33040", Offset = "0x2A31640", VA = "0x182A33040")]
		private bool TMTSBQLQLQQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2A32C70", Offset = "0x2A31270", VA = "0x182A32C70")]
		public bool EnableSubtitles(MediaPath mediaPath)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2A34C80", Offset = "0x2A33280", VA = "0x182A34C80")]
		[IteratorStateMachine(typeof(YITGSISALHS))]
		private IEnumerator OUXGXNOBLHX(string a, MediaPath b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2A32BA0", Offset = "0x2A311A0", VA = "0x182A32BA0")]
		public void DisableSubtitles()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "4")]
		private void PSCOJVPHXVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2A370D0", Offset = "0x2A356D0", VA = "0x182A370D0", Slot = "5")]
		private void ZGWJOOHMTOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2A37390", Offset = "0x2A35990", VA = "0x182A37390")]
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
			public enum SourceType
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
			public SourceType sourceType;

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
			public PlaylistMediaPlayer.StartMode startMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			[SerializeField]
			public PlaylistMediaPlayer.ProgressMode progressMode;

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
			public PlaylistMediaPlayer.Transition overrideTransition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			[SerializeField]
			public float overrideTransitionDuration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			[SerializeField]
			public SKZTDPXQOXX.Preset overrideTransitionEasing;

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x2A31510", Offset = "0x2A2FB10", VA = "0x182A31510")]
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
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2A38210", Offset = "0x2A36810", VA = "0x182A38210")]
		public bool ZCEMXHGVHAW(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2A38270", Offset = "0x2A36870", VA = "0x182A38270")]
		public MediaPlaylist()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[AddComponentMenu("AVPro Video/Playlist Media Player", -80)]
	[HelpURL("https://www.renderheads.com/products/avpro-video/")]
	public class PlaylistMediaPlayer : MediaPlayer, RPDJCBIELFW
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public enum Transition
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
		public enum PlaylistLoopMode
		{
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			Loop
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public enum StartMode
		{
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			Immediate,
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			Manual
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public enum ProgressMode
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
		private sealed class KCMDJSLEHLU : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			private object MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			public PlaylistMediaPlayer CDTALOACOKM;

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			private object ENGTUJRFGYV
			{
				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xAA9B40", Offset = "0xAA8140", VA = "0x180AA9B40")]
			[DebuggerHidden]
			public KCMDJSLEHLU(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x2A30180", Offset = "0x2A2E780", VA = "0x182A30180", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x2A307F0", Offset = "0x2A2EDF0", VA = "0x182A307F0", Slot = "8")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[SerializeField]
		private Shader _transitionShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		[SerializeField]
		private MediaPlayer _playerA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[SerializeField]
		private MediaPlayer _playerB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[SerializeField]
		private bool _playlistAutoProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E9")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[Tooltip("Close the video on the other MediaPlayer when it is not visible any more. This is useful for freeing up memory and GPU decoding resources.")]
		[SerializeField]
		private bool _autoCloseVideo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		[SerializeField]
		private PlaylistLoopMode _playlistLoopMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		[SerializeField]
		private MediaPlaylist _playlist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		[Tooltip("Pause the previously playing video. This is useful for systems that will struggle to play 2 videos at once")]
		[SerializeField]
		private bool _pausePreviousOnTransition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		[SerializeField]
		private Transition _defaultTransition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[SerializeField]
		private float _defaultTransitionDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[SerializeField]
		private SKZTDPXQOXX.Preset _defaultTransitionEasing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _playlistAudioVolume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[SerializeField]
		private bool _playlistAudioMuted;

		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private static readonly LazyShaderProperty QNCJSZFXBHA;

		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private static readonly LazyShaderProperty PCVILTJXYZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20D")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private bool DLEARIMKGLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private int OWZIGPGSNVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private MediaPlayer KYWICNBTJCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private Material VUDPHIHDOTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private Transition DVKHYALCZFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private string ELFHJBLEFNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private float RHNZWIPDRRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23C")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private SKZTDPXQOXX.Preset GHLYDBHUVFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private float NVLZEKDAQNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private Func<float, float> RHNLKZXECUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private RenderTexture LMDFWUDYVUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private MediaPlaylist.MediaItem NEBQTYEUTWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private MediaPlaylist.MediaItem OYLSQOLXZIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private WaitForEndOfFrame PHUVAIBUERU;

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public MediaPlayer PHNLKGCWZLW
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x2A3B550", Offset = "0x2A39B50", VA = "0x182A3B550")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public MediaPlayer OAYCEVBNJQI
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xB24000", Offset = "0xB22600", VA = "0x180B24000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public MediaPlaylist CZUKLEDXETA
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xBF70C0", Offset = "0xBF56C0", VA = "0x180BF70C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public int YPDZZJYROVI
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x275AFB0", Offset = "0x27595B0", VA = "0x18275AFB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public MediaPlaylist.MediaItem VUJNKGUEEVT
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x2A3B6A0", Offset = "0x2A39CA0", VA = "0x182A3B6A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Transition JUBSZDKZEUC
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x16A16C0", Offset = "0x169FCC0", VA = "0x1816A16C0")]
			get
			{
				return default(Transition);
			}
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x168ADC0", Offset = "0x16893C0", VA = "0x18168ADC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public float UECUKHVYQMW
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x1F89A10", Offset = "0x1F88010", VA = "0x181F89A10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x2201620", Offset = "0x21FFC20", VA = "0x182201620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public SKZTDPXQOXX.Preset IXVHWOBJFRN
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0xBB7BA0", Offset = "0xBB61A0", VA = "0x180BB7BA0")]
			get
			{
				return default(SKZTDPXQOXX.Preset);
			}
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xBB61A0", Offset = "0xBB47A0", VA = "0x180BB61A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public bool QERACWZFXJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x1125BE0", Offset = "0x11241E0", VA = "0x181125BE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x16A2C90", Offset = "0x16A1290", VA = "0x1816A2C90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public PlaylistLoopMode HUOHMFZCAYN
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x2A3B690", Offset = "0x2A39C90", VA = "0x182A3B690")]
			get
			{
				return default(PlaylistLoopMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x2531A80", Offset = "0x2530080", VA = "0x182531A80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public bool WWUDJJDQEZW
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xEF8120", Offset = "0xEF6720", VA = "0x180EF8120")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xEF9810", Offset = "0xEF7E10", VA = "0x180EF9810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public override EECQGSYCGYN WCIGPDCOHYY
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x2A3B5F0", Offset = "0x2A39BF0", VA = "0x182A3B5F0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public override IILUKYABAEO ISOVNFCRTUB
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x2A3B4B0", Offset = "0x2A39AB0", VA = "0x182A3B4B0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public override RPDJCBIELFW JNQNLCFDCWR
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xE6A110", Offset = "0xE68710", VA = "0x180E6A110", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public override float GIFERMEGKRC
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x21FFD30", Offset = "0x21FE330", VA = "0x1821FFD30", Slot = "6")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x2A3B830", Offset = "0x2A39E30", VA = "0x182A3B830", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public override bool WGTUOCCVVSV
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x1124700", Offset = "0x1122D00", VA = "0x181124700", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x2A3B760", Offset = "0x2A39D60", VA = "0x182A3B760", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2A3A170", Offset = "0x2A38770", VA = "0x182A3A170", Slot = "20")]
		public override void Play()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2A3A060", Offset = "0x2A38660", VA = "0x182A3A060", Slot = "21")]
		public override void Pause()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x1125BD0", Offset = "0x11241D0", VA = "0x181125BD0")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2A3AE70", Offset = "0x2A39470", VA = "0x182A3AE70")]
		[IteratorStateMachine(typeof(KCMDJSLEHLU))]
		private IEnumerator WGWKLOQOSTF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2A39560", Offset = "0x2A37B60", VA = "0x182A39560")]
		private Texture IXQJWCFETUT(int a = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2A3A330", Offset = "0x2A38930", VA = "0x182A3A330")]
		private Texture SEZSWWGSAEE(int a = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2A38890", Offset = "0x2A36E90", VA = "0x182A38890")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2A39830", Offset = "0x2A37E30", VA = "0x182A39830", Slot = "23")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2A3A6D0", Offset = "0x2A38CD0", VA = "0x182A3A6D0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2A39AD0", Offset = "0x2A380D0", VA = "0x182A39AD0")]
		public void OnMediaPlayerEvent(MediaPlayer mediaPlayer, MediaPlayerEvent.EventType eventType, ErrorCode errorCode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2A3A280", Offset = "0x2A38880", VA = "0x182A3A280")]
		public bool PrevItem()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2A397B0", Offset = "0x2A37DB0", VA = "0x182A397B0")]
		public bool NextItem()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2A38A20", Offset = "0x2A37020", VA = "0x182A38A20")]
		public bool CanJumpToItem(int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2A39670", Offset = "0x2A37C70", VA = "0x182A39670")]
		public bool JumpToItem(int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2A39C90", Offset = "0x2A38290", VA = "0x182A39C90")]
		public void OpenVideoFile(MediaPlaylist.MediaItem mediaItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2A3A910", Offset = "0x2A38F10", VA = "0x182A3A910")]
		private bool TLNFZWMYAND()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2A3AEE0", Offset = "0x2A394E0", VA = "0x182A3AEE0")]
		private void WHITPRSDGJB(Transition a, float b, SKZTDPXQOXX.Preset c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2A3A930", Offset = "0x2A38F30", VA = "0x182A3A930", Slot = "22")]
		protected override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2A39340", Offset = "0x2A37940", VA = "0x182A39340", Slot = "26")]
		public Texture GetTexture(int index = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2A38DC0", Offset = "0x2A373C0", VA = "0x182A38DC0", Slot = "25")]
		public int GetTextureCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x2A38E60", Offset = "0x2A37460", VA = "0x182A38E60", Slot = "27")]
		public int GetTextureFrameCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2A3A870", Offset = "0x2A38E70", VA = "0x182A3A870", Slot = "28")]
		public bool SupportsTextureFrameCount()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2A39180", Offset = "0x2A37780", VA = "0x182A39180", Slot = "29")]
		public long GetTextureTimeStamp()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2A39030", Offset = "0x2A37630", VA = "0x182A39030", Slot = "30")]
		public float GetTexturePixelAspectRatio()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2A3A290", Offset = "0x2A38890", VA = "0x182A3A290", Slot = "31")]
		public bool RequiresVerticalFlip()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2A39430", Offset = "0x2A37A30", VA = "0x182A39430", Slot = "35")]
		public Matrix4x4 GetYpCbCrTransform()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2A390E0", Offset = "0x2A376E0", VA = "0x182A390E0", Slot = "32")]
		public StereoPacking GetTextureStereoPacking()
		{
			return default(StereoPacking);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x2A392A0", Offset = "0x2A378A0", VA = "0x182A392A0", Slot = "33")]
		public TransparencyMode GetTextureTransparency()
		{
			return default(TransparencyMode);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x2A38D20", Offset = "0x2A37320", VA = "0x182A38D20", Slot = "34")]
		public AlphaPacking GetTextureAlphaPacking()
		{
			return default(AlphaPacking);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x2A38AF0", Offset = "0x2A370F0", VA = "0x182A38AF0", Slot = "36")]
		public float[] GetAffineTransform()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x2A38F00", Offset = "0x2A37500", VA = "0x182A38F00", Slot = "37")]
		public Matrix4x4 GetTextureMatrix()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x2A38BE0", Offset = "0x2A371E0", VA = "0x182A38BE0", Slot = "38")]
		public RenderTextureFormat GetCompatibleRenderTextureFormat(GetCompatibleRenderTextureFormatOptions options, int plane)
		{
			return default(RenderTextureFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x2A3A420", Offset = "0x2A38A20", VA = "0x182A3A420")]
		private static string STRNHWIBXQI(Transition a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x2A3B320", Offset = "0x2A39920", VA = "0x182A3B320")]
		public PlaylistMediaPlayer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[AddComponentMenu("AVPro Video/Resolve To RenderTexture", 330)]
	[HelpURL("https://www.renderheads.com/products/avpro-video/")]
	public class ResolveToRenderTexture : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[SerializeField]
		private MediaPlayer _mediaPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[SerializeField]
		private VideoResolveOptions _options;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[SerializeField]
		private DAVICEKJIXR.ResolveFlags _resolveFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[SerializeField]
		private RenderTexture _externalTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private Material YANNGIGTARK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private bool UUBLWFWFNOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x71")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private bool CTSUPHXJWKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x72")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private bool VEKOPFHSDOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private RenderTexture TCZHBQOQPJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private int VDBKCLRSNWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private Material WKYMVGEHFJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private int KPUWMZUSQTJ;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public MediaPlayer NUROUKBVSWV
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x2A3C2A0", Offset = "0x2A3A8A0", VA = "0x182A3C2A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public VideoResolveOptions MTQVUVRHOND
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x2A3C410", Offset = "0x2A3AA10", VA = "0x182A3C410")]
			get
			{
				return default(VideoResolveOptions);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x2A3C430", Offset = "0x2A3AA30", VA = "0x182A3C430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public RenderTexture RTBHECGLJJY
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xAACD50", Offset = "0xAAB350", VA = "0x180AACD50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB070", VA = "0x180AACA70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public RenderTexture VUTBZNEDDUU
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x2A3C390", Offset = "0x2A3A990", VA = "0x182A3C390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2A3C130", Offset = "0x2A3A730", VA = "0x182A3C130")]
		public void SetMaterialDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x2A3C2A0", Offset = "0x2A3A8A0", VA = "0x182A3C2A0")]
		private void ZBZIHGIYIPT(MediaPlayer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x2A3C140", Offset = "0x2A3A740", VA = "0x182A3C140")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2A3B920", Offset = "0x2A39F20", VA = "0x182A3B920")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x2A3BA50", Offset = "0x2A3A050", VA = "0x182A3BA50")]
		public void Resolve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x2A3B9D0", Offset = "0x2A39FD0", VA = "0x182A3B9D0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2A3B930", Offset = "0x2A39F30", VA = "0x182A3B930")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2A3C340", Offset = "0x2A3A940", VA = "0x182A3C340")]
		public ResolveToRenderTexture()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[AddComponentMenu("AVPro Video/Update Multi-Pass Stereo", 320)]
	[HelpURL("https://www.renderheads.com/products/avpro-video/")]
	public class UpdateMultiPassStereo : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[Header("Stereo camera")]
		[SerializeField]
		private Camera _camera;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private static readonly LazyShaderProperty WEXNGJKABVN;

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private static readonly LazyShaderProperty UXQHKOZOTXQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private Camera KBPTNDPISMQ;

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Camera CQYZCUMLRHV
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0xAA7770", Offset = "0xAA5D70", VA = "0x180AA7770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2A3C450", Offset = "0x2A3AA50", VA = "0x182A3C450")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2A3CC40", Offset = "0x2A3B240", VA = "0x182A3CC40")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2A3C4F0", Offset = "0x2A3AAF0", VA = "0x182A3C4F0")]
		private void DDFRASRFRWU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2A3C830", Offset = "0x2A3AE30", VA = "0x182A3C830")]
		private static bool LUZVNEEWVTX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2A3C860", Offset = "0x2A3AE60", VA = "0x182A3C860")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xAA6840", Offset = "0xAA4E40", VA = "0x180AA6840")]
		public UpdateMultiPassStereo()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public abstract class ApplyToBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[Header("Media Source")]
		[SerializeField]
		protected MediaPlayer _media;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[Space(8f)]
		[Header("Display")]
		[SerializeField]
		private bool _automaticStereoPacking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[SerializeField]
		private StereoPacking _overrideStereoPacking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[SerializeField]
		private bool _stereoRedGreenTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		protected bool NRHWOUEPLHB;

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public MediaPlayer EIEFMZKSIFL
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x2A29BA0", Offset = "0x2A281A0", VA = "0x182A29BA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public bool XZYAJHCXOAS
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xCB5800", Offset = "0xCB3E00", VA = "0x180CB5800")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x2A29B80", Offset = "0x2A28180", VA = "0x182A29B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public StereoPacking ZWYGZFQMQPV
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xC531C0", Offset = "0xC517C0", VA = "0x180C531C0")]
			get
			{
				return default(StereoPacking);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x2A29B90", Offset = "0x2A28190", VA = "0x182A29B90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public bool NLBGKZOASNB
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xAFD4E0", Offset = "0xAFBAE0", VA = "0x180AFD4E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x2A29BB0", Offset = "0x2A281B0", VA = "0x182A29BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x2A298A0", Offset = "0x2A27EA0", VA = "0x182A298A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x2A299D0", Offset = "0x2A27FD0", VA = "0x182A299D0")]
		private void ZBZIHGIYIPT(MediaPlayer a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x2A298B0", Offset = "0x2A27EB0", VA = "0x182A298B0")]
		private void DFYFTAWCHGC(MediaPlayer a, MediaPlayerEvent.EventType b, ErrorCode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x2A298F0", Offset = "0x2A27EF0", VA = "0x182A298F0")]
		public void ForceUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x2A29990", Offset = "0x2A27F90", VA = "0x182A29990")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x2A29940", Offset = "0x2A27F40", VA = "0x182A29940", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x1AE8170", Offset = "0x1AE6770", VA = "0x181AE8170", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x2A29930", Offset = "0x2A27F30", VA = "0x182A29930")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "6")]
		protected virtual void MWJNUKLRGHW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "7")]
		protected virtual void HRGRRAKJDSP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void Apply();

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x18FFE30", Offset = "0x18FE430", VA = "0x1818FFE30")]
		protected ApplyToBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class LALBOEMTIVI
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		protected class QYDMRASVCCW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public HashSet<AudioOutput> YTPJLLANCIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public float[] CLAXOQKFWPW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public bool DUPSDAYQMZJ;

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public QYDMRASVCCW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private static LALBOEMTIVI EOTFGNPJDZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private Dictionary<int, QYDMRASVCCW> IMISNRHYKAL;

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public static LALBOEMTIVI ZQTZABWNUIL
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x2A30940", Offset = "0x2A2EF40", VA = "0x182A30940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x2A31490", Offset = "0x2A2FA90", VA = "0x182A31490")]
		private LALBOEMTIVI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x2A30A70", Offset = "0x2A2F070", VA = "0x182A30A70")]
		public void LIUDCLLBAGB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x2A31410", Offset = "0x2A2FA10", VA = "0x182A31410")]
		public void QEHZFOLNADM(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x2A30B60", Offset = "0x2A2F160", VA = "0x182A30B60")]
		public void LMMYPTKDCZD(AudioOutput a, MediaPlayer b, int c, float[] d, int e, int f, AudioOutput.AudioOutputMode g, bool h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x2A30A30", Offset = "0x2A2F030", VA = "0x182A30A30")]
		private void EWBUEHDYERK(float[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x2A30830", Offset = "0x2A2EE30", VA = "0x182A30830")]
		private bool BIREPVHQSSA(MediaPlayer a, float[] b, int c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[DefaultMember("Item")]
	public abstract class ZRCJHFWYBKC : NAENQYJIMZW, IILUKYABAEO, EECQGSYCGYN, FYZZTPJCZUZ, RPDJCBIELFW, DVKTIHIMJHE, FTURTUKZXFE, WCMCARWXVVZ, VZCLVKGQUTK, IQUJBWYXMLP, IEnumerable, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		protected string ECZAXOVCSAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		protected ErrorCode HEESDDGPURL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		protected FilterMode TGSTVTWTZEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		protected TextureWrapMode UVXCQEDRYPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		protected int XFPBIPCBXUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		protected MediaHints SZRULCFRRQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		protected XNCUMSEBRSH KTOFFJJFXUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		protected XNCUMSEBRSH JJPHYWIUWZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private float ZWAVEBQPFXK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private int EGXDZMXLRVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private float ZYEACITRFHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private float QTGGGSUJMEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private int DHEBECSNHTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private int PMXUZRHFMCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		protected List<IKCLARWRMPO> MZFKIAMXWBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		protected IKCLARWRMPO VAHAWUXBYIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		protected WMSGPJGMOZH NQLKZWJISGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		protected CVUPBOXMPMO TNZGQTIXEHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		protected LENFRTKEOYD COQVJQOLFNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		protected GSWJQVUGIDY SUDNMAXRCSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		protected MVTJOZOFDXN HRKLWQMRVAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		protected MUSTFVAONXV[] QNPEJAFSYAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		protected List<JEHSLRIOOIR> AKWGYMNABNZ;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x2A3E6E0", Offset = "0x2A3CCE0", VA = "0x182A3E6E0")]
		public ZRCJHFWYBKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "82")]
		public abstract string DVIWDFHMVFC();

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "83")]
		public abstract string LYONIRKAIIA();

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "84")]
		public abstract bool TVOORQKINDS(string a, long b, string c, MediaHints d, int e = 0, bool f = false);

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "85")]
		public virtual bool CZAJPKUQUXQ(byte[] a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "86")]
		public virtual bool AFPOEJNPJHA(ulong a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "87")]
		public virtual bool USLUORWEACR(byte[] a, ulong b, ulong c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "88")]
		public virtual bool YWQNQQPUJZL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x2A3DF90", Offset = "0x2A3C590", VA = "0x182A3DF90", Slot = "89")]
		public virtual void LQDKTOOIDTW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(Slot = "90")]
		public abstract void CGJIFDIEHIO(bool a);

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "91")]
		public abstract bool TSUAXKTVXSK();

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(Slot = "92")]
		public abstract bool EFKXJCDGOEF();

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "93")]
		public abstract bool WDLWRYGDSXO();

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
		[Cpp2IlInjected.Address(RVA = "0x2A3E030", Offset = "0x2A3C630", VA = "0x182A3E030", Slot = "97")]
		public virtual void NJBTIBFADNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(Slot = "98")]
		public abstract void CGVCDQJITYU(double a);

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(Slot = "99")]
		public abstract void KHYAZZAAHLU(double a);

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(Slot = "100")]
		public abstract double JMGDHRGKJDG();

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(Slot = "101")]
		public abstract float NWKOBZWTBML();

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(Slot = "102")]
		public abstract void NSDQCTPANIX(float a);

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(Slot = "103")]
		public abstract double AXCBEQYPKWA();

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(Slot = "104")]
		public abstract int FATSOONCKSF();

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(Slot = "105")]
		public abstract int QXTYIMTLAAI();

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(Slot = "106")]
		public abstract float RPRLIYJYBLU();

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(Slot = "107")]
		public abstract bool SCJIKEJHENQ();

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(Slot = "108")]
		public abstract bool PYVNHVICAZJ();

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(Slot = "109")]
		public abstract bool YPCRBXGYCUQ();

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(Slot = "110")]
		public abstract bool LWJRMPTXATI();

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(Slot = "111")]
		public abstract bool FQJUNEUTCBI();

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(Slot = "112")]
		public abstract bool YKTIIVFLCHI();

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "113")]
		public abstract bool PRYTYOGNNAK();

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "114")]
		public virtual bool IVYTWKXGFIS(Camera a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xC4A0B0", Offset = "0xC486B0", VA = "0x180C4A0B0", Slot = "115")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "118")]
		public virtual bool SupportsTextureFrameCount()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x2A3D9D0", Offset = "0x2A3BFD0", VA = "0x182A3D9D0", Slot = "119")]
		public virtual long GetTextureTimeStamp()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(Slot = "120")]
		public abstract bool RequiresVerticalFlip();

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xC531B0", Offset = "0xC517B0", VA = "0x180C531B0", Slot = "121")]
		public virtual float GetTexturePixelAspectRatio()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x2A3D9E0", Offset = "0x2A3BFE0", VA = "0x182A3D9E0", Slot = "122")]
		public virtual Matrix4x4 GetYpCbCrTransform()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x2A3D6D0", Offset = "0x2A3BCD0", VA = "0x182A3D6D0", Slot = "123")]
		public virtual float[] GetAffineTransform()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x2A3E5E0", Offset = "0x2A3CBE0", VA = "0x182A3E5E0", Slot = "124")]
		public virtual float[] TYKTHDPUVQN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x2A3D810", Offset = "0x2A3BE10", VA = "0x182A3D810", Slot = "125")]
		public virtual Matrix4x4 GetTextureMatrix()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xF9EE30", Offset = "0xF9D430", VA = "0x180F9EE30", Slot = "126")]
		public virtual RenderTextureFormat GetCompatibleRenderTextureFormat(GetCompatibleRenderTextureFormatOptions options, int plane)
		{
			return default(RenderTextureFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x2A3D9A0", Offset = "0x2A3BFA0", VA = "0x182A3D9A0", Slot = "70")]
		public StereoPacking GetTextureStereoPacking()
		{
			return default(StereoPacking);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(Slot = "127")]
		internal abstract StereoPacking QNRJKRQNYJD();

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xAA7700", Offset = "0xAA5D00", VA = "0x180AA7700", Slot = "128")]
		public virtual TransparencyMode GetTextureTransparency()
		{
			return default(TransparencyMode);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x2A3D7D0", Offset = "0x2A3BDD0", VA = "0x182A3D7D0", Slot = "72")]
		public AlphaPacking GetTextureAlphaPacking()
		{
			return default(AlphaPacking);
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(Slot = "129")]
		public abstract void BAYMRGAIDFX(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(Slot = "130")]
		public abstract bool LDXAZWSSMFV();

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "131")]
		public abstract void PAOZKUSPJXY(float a);

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "132")]
		public virtual void VYVCXLJICQE(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(Slot = "133")]
		public abstract float IQZBZBKUEAW();

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xAF5360", Offset = "0xAF3960", VA = "0x180AF5360", Slot = "134")]
		public virtual float GetBalance()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xAF5370", Offset = "0xAF3970", VA = "0x180AF5370", Slot = "135")]
		public virtual int QWNTFJROBXG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "136")]
		public virtual int BIREPVHQSSA(float[] a, int b, int c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "137")]
		public virtual void DENZRNCISSI(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "138")]
		public virtual void MGPIAXUGHHY(Quaternion a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "139")]
		public virtual void WAQZRPKPPHR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "140")]
		public virtual void VJEDPMFSWFI(Audio360ChannelMode a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "141")]
		public virtual void NGXGQKNMBDR(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "142")]
		public virtual void ICGNOBHKCAL(float a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "143")]
		public virtual void ZLEUQMKXLVG(Quaternion a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "144")]
		public virtual void QTVPZWVJDXV(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "145")]
		public virtual void CRJANHVAJNK(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(Slot = "146")]
		public abstract void Update();

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "147")]
		public virtual void SXZXUUTCMQF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "148")]
		public abstract void Render();

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(Slot = "149")]
		public abstract void Dispose();

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "150")]
		public virtual void TTMWGBYQANK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x2A3D6C0", Offset = "0x2A3BCC0", VA = "0x182A3D6C0", Slot = "40")]
		public ErrorCode GGNUZOLXRTI()
		{
			return default(ErrorCode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "151")]
		public virtual bool ITVSYWAUMFN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xAAFEE0", Offset = "0xAAE4E0", VA = "0x180AAFEE0", Slot = "39")]
		public XNCUMSEBRSH ZRGIHOONGPR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x2A3DF70", Offset = "0x2A3C570", VA = "0x182A3DF70", Slot = "42")]
		public void IQZQKQSUDOO([Out] FilterMode a, [Out] TextureWrapMode b, [Out] int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x2A3E050", Offset = "0x2A3C650", VA = "0x182A3E050", Slot = "41")]
		public void OAQXERIJKHU(FilterMode a = FilterMode.Bilinear, TextureWrapMode b = TextureWrapMode.Clamp, int c = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x2A3D5B0", Offset = "0x2A3BBB0", VA = "0x182A3D5B0", Slot = "152")]
		protected virtual void DEHCLXYLTDM(Texture a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x2A3D510", Offset = "0x2A3BB10", VA = "0x182A3D510")]
		protected void BRIBQGNHJKQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x2A3DA40", Offset = "0x2A3C040", VA = "0x182A3DA40")]
		protected bool HIOAPFYNBFN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x2A3DD00", Offset = "0x2A3C300", VA = "0x182A3DD00", Slot = "153")]
		public virtual bool ILXQDIZHJIQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x2A3D650", Offset = "0x2A3BC50", VA = "0x182A3D650", Slot = "77")]
		public bool FBLAHRNLLTO(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x2A3DBC0", Offset = "0x2A3C1C0", VA = "0x182A3DBC0", Slot = "154")]
		public virtual void HMXUTOEQRQO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x2A3E6C0", Offset = "0x2A3CCC0", VA = "0x182A3E6C0", Slot = "155")]
		public virtual int XOJLAHDJJGE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x2A3E440", Offset = "0x2A3CA40", VA = "0x182A3E440", Slot = "156")]
		public virtual string TPYFCPIIVHN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "157")]
		public virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x2A3E600", Offset = "0x2A3CC00", VA = "0x182A3E600", Slot = "158")]
		public int WPFOKRIFFTU(float a = 0f)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x2A3E360", Offset = "0x2A3C960", VA = "0x182A3E360")]
		protected bool QWGDZPUTVAB(bool a = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "159")]
		internal abstract bool MWOPIWPKXLJ();

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(Slot = "160")]
		internal abstract string ZQGDEHUEBOO();

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "161")]
		internal abstract bool UTZCMSRDQWL(TrackType a);

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "162")]
		internal abstract int EMAXBWGEBPX(TrackType a);

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(Slot = "163")]
		internal abstract IDQZUJPPMFY WNNYSDZLMSG(TrackType a, int b, bool c);

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x2A3E470", Offset = "0x2A3CA70", VA = "0x182A3E470")]
		private void TWAZCQSDNWG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x2A3E2B0", Offset = "0x2A3C8B0", VA = "0x182A3E2B0")]
		protected void PEXRFWUVSFX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x2A3E0E0", Offset = "0x2A3C6E0", VA = "0x182A3E0E0")]
		private void PBDGEMBIRIR(MUSTFVAONXV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x2A3D740", Offset = "0x2A3BD40", VA = "0x182A3D740", Slot = "164")]
		public virtual IEnumerator GetEnumerator()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class MediaPlayerEvent : UnityEvent<MediaPlayer, MediaPlayerEvent.EventType, ErrorCode>
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public enum EventType
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
		private List<UnityAction<MediaPlayer, EventType, ErrorCode>> OTLGTMKZGJM;

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x2A315B0", Offset = "0x2A2FBB0", VA = "0x182A315B0")]
		public bool LAUDZZPZRKR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x2A31610", Offset = "0x2A2FC10", VA = "0x182A31610")]
		public void TWRZLGTUWBB(UnityAction<MediaPlayer, EventType, ErrorCode> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x2A31700", Offset = "0x2A2FD00", VA = "0x182A31700")]
		public void VTWFYHKETPW(UnityAction<MediaPlayer, EventType, ErrorCode> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x2A317A0", Offset = "0x2A2FDA0", VA = "0x182A317A0")]
		public MediaPlayerEvent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public static class PZAZWMIILMU
	{
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private static Matrix4x4 KJRNAVLFGTQ;

		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private static Matrix4x4 JJZSRZMXIMA;

		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private static Matrix4x4 DHTHXRKHAMO;

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x2A4CBC0", Offset = "0x2A4B1C0", VA = "0x182A4CBC0")]
		public static string QUALMZDCBLB(MediaPathType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x2A4CE50", Offset = "0x2A4B450", VA = "0x182A4CE50")]
		public static string ZAMHQRMWKFH(string a, MediaPathType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x2A4C770", Offset = "0x2A4AD70", VA = "0x182A4C770")]
		public static string MZDTNSFVXQV(ErrorCode a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x2A4C3A0", Offset = "0x2A4A9A0", VA = "0x182A4C3A0")]
		public static void FZZSIHJTLRU(string a, [Optional] UnityEngine.Object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x2A4CDA0", Offset = "0x2A4B3A0", VA = "0x182A4CDA0")]
		public static int WBVGFZNCJJH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x2A4CD10", Offset = "0x2A4B310", VA = "0x182A4CD10")]
		public static int TBNUSJEPWAR()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x2A4C560", Offset = "0x2A4AB60", VA = "0x182A4C560")]
		public static Orientation IRAAEDYGQZE(float[] a)
		{
			return default(Orientation);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x2A4CDD0", Offset = "0x2A4B3D0", VA = "0x182A4CDD0")]
		public static int YBIFEAJDXKX(double a, float b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x2A4C480", Offset = "0x2A4AA80", VA = "0x182A4C480")]
		private static extern int GetShortPathName(string pathName, StringBuilder shortName, int cbShortName);

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x2A4C1F0", Offset = "0x2A4A7F0", VA = "0x182A4C1F0")]
		internal static string DSXSZROVFUJ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x2A4C890", Offset = "0x2A4AE90", VA = "0x182A4C890")]
		public static Texture2D QELPKWJNKIL(Texture a, bool b, Orientation c, [Optional] Texture2D d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public interface NAENQYJIMZW
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnEnable();

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Update();

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void TTMWGBYQANK();

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SXZXUUTCMQF();

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Render();
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public interface DVKTIHIMJHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool FBLAHRNLLTO(string a);

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int XOJLAHDJJGE();

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(Slot = "2")]
		string TPYFCPIIVHN();
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public interface IILUKYABAEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TVOORQKINDS(string a, long b, string c, MediaHints d, int e = 0, bool f = false);

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool CZAJPKUQUXQ(byte[] a);

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool AFPOEJNPJHA(ulong a);

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool USLUORWEACR(byte[] a, ulong b, ulong c);

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool YWQNQQPUJZL();

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void LQDKTOOIDTW();

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void CGJIFDIEHIO(bool a);

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool TSUAXKTVXSK();

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool EFKXJCDGOEF();

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool WDLWRYGDSXO();

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool LWJRMPTXATI();

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool YPCRBXGYCUQ();

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool FQJUNEUTCBI();

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(Slot = "13")]
		bool YKTIIVFLCHI();

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(Slot = "14")]
		bool PRYTYOGNNAK();

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
		void NJBTIBFADNN();

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void CGVCDQJITYU(double a);

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void KHYAZZAAHLU(double a);

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(Slot = "21")]
		double JMGDHRGKJDG();

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(Slot = "22")]
		float NWKOBZWTBML();

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void NSDQCTPANIX(float a);

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void BAYMRGAIDFX(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(Slot = "25")]
		bool LDXAZWSSMFV();

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void PAOZKUSPJXY(float a);

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void VYVCXLJICQE(float a);

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(Slot = "28")]
		float IQZBZBKUEAW();

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(Slot = "29")]
		float GetBalance();

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(Slot = "30")]
		XNCUMSEBRSH ZRGIHOONGPR();

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(Slot = "31")]
		ErrorCode GGNUZOLXRTI();

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(Slot = "32")]
		void OAQXERIJKHU(FilterMode a = FilterMode.Bilinear, TextureWrapMode b = TextureWrapMode.Clamp, int c = 1);

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(Slot = "33")]
		void IQZQKQSUDOO([Out] FilterMode a, [Out] TextureWrapMode b, [Out] int c);

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(Slot = "34")]
		int BIREPVHQSSA(float[] a, int b, int c);

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(Slot = "35")]
		int QWNTFJROBXG();

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void DENZRNCISSI(bool a);

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(Slot = "37")]
		void VJEDPMFSWFI(Audio360ChannelMode a);

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(Slot = "38")]
		void MGPIAXUGHHY(Quaternion a);

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(Slot = "39")]
		void WAQZRPKPPHR();

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(Slot = "40")]
		void NGXGQKNMBDR(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(Slot = "41")]
		void ICGNOBHKCAL(float a, float b);

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(Slot = "42")]
		void ZLEUQMKXLVG(Quaternion a);

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(Slot = "43")]
		bool IVYTWKXGFIS(Camera a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(Slot = "44")]
		void QTVPZWVJDXV(string a);

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(Slot = "45")]
		void CRJANHVAJNK(byte[] a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public interface EECQGSYCGYN
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(Slot = "0")]
		double AXCBEQYPKWA();

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int FATSOONCKSF();

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int QXTYIMTLAAI();

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(Slot = "3")]
		float RPRLIYJYBLU();

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool PYVNHVICAZJ();

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool ITVSYWAUMFN();

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool ILXQDIZHJIQ();

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float[] TYKTHDPUVQN();
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public interface FYZZTPJCZUZ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public interface RPDJCBIELFW
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
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[Flags]
	public enum GetCompatibleRenderTextureFormatOptions
	{
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		ForResolve = 1,
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		RequiresAlpha = 2
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public enum Platform
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
	public enum MediaSource
	{
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		Reference,
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		Path
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public enum MediaPathType
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
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class MediaPath
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		[SerializeField]
		private MediaPathType _pathType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		[SerializeField]
		private string _path;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public MediaPathType PathType
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0xAA5110", Offset = "0xAA3710", VA = "0x180AA5110")]
			get
			{
				return default(MediaPathType);
			}
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0xAA7720", Offset = "0xAA5D20", VA = "0x180AA7720")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public string Path
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0xAA7A70", Offset = "0xAA6070", VA = "0x180AA7A70")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x2A47720", Offset = "0x2A45D20", VA = "0x182A47720")]
		public MediaPath()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x2A476B0", Offset = "0x2A45CB0", VA = "0x182A476B0")]
		public MediaPath(MediaPath copy)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x2A47640", Offset = "0x2A45C40", VA = "0x182A47640")]
		public MediaPath(string path, MediaPathType pathType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x2A47330", Offset = "0x2A45930", VA = "0x182A47330")]
		public string QLCGAHATVZU()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x2A47570", Offset = "0x2A45B70", VA = "0x182A47570")]
		public static MediaPath RLNHVWDCVHF(string a)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x2A47310", Offset = "0x2A45910", VA = "0x182A47310")]
		public static bool HCJGUXGANNO(MediaPath a, MediaPath b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x2A47600", Offset = "0x2A45C00", VA = "0x182A47600")]
		public static bool VSCIXNKBWNJ(MediaPath a, MediaPath b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x2A471D0", Offset = "0x2A457D0", VA = "0x182A471D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x2A472C0", Offset = "0x2A458C0", VA = "0x182A472C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public enum StereoPacking
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
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct MediaHints
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public TransparencyMode transparency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public AlphaPacking alphaPacking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public StereoPacking stereoPacking;

		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private static MediaHints defaultHints;

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public static MediaHints AMLVLGFTEOB
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x2A47180", Offset = "0x2A45780", VA = "0x182A47180")]
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
		public enum AspectRatio
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
		[SerializeField]
		[Range(0f, 1f)]
		public float hue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		[SerializeField]
		[Range(0f, 1f)]
		public float saturation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		[SerializeField]
		[Range(0f, 1f)]
		public float brightness;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		[SerializeField]
		[Range(0f, 1f)]
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
		public AspectRatio aspectRatio;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x2A530C0", Offset = "0x2A516C0", VA = "0x182A530C0")]
		public bool FNOBBBGVNNN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x2A53120", Offset = "0x2A51720", VA = "0x182A53120")]
		internal void XAHJSQTHOXC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x2A53050", Offset = "0x2A51650", VA = "0x182A53050")]
		public static VideoResolveOptions Create()
		{
			return default(VideoResolveOptions);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public enum TransparencyMode
	{
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		Opaque,
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		Transparent
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum StereoEye
	{
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		Both,
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		Left,
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		Right
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public enum AlphaPacking
	{
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		TopBottom,
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		LeftRight
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public enum ErrorCode
	{
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		LoadFailed = 100,
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		DecodeFailed = 200
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public enum Orientation
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
	public enum VideoMapping
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
	public enum FileFormat
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
	public static class CJHFJWBAPDL
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public enum VideoApi
		{
			[Cpp2IlInjected.Token(Token = "0x400024F")]
			MediaFoundation,
			[Cpp2IlInjected.Token(Token = "0x4000250")]
			DirectShow,
			[Cpp2IlInjected.Token(Token = "0x4000251")]
			WinRT
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public enum AudioOutput
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
	public static class LYTNTHMEUIP
	{
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public enum VideoApi
		{
			[Cpp2IlInjected.Token(Token = "0x4000258")]
			MediaFoundation,
			[Cpp2IlInjected.Token(Token = "0x4000259")]
			WinRT
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		public enum AudioOutput
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
	public static class Android
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public enum VideoApi
		{
			[Cpp2IlInjected.Token(Token = "0x4000260")]
			MediaPlayer = 1,
			[Cpp2IlInjected.Token(Token = "0x4000261")]
			ExoPlayer
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public static class ZYUIMLQIOPH
	{
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public enum ExternalLibrary
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
	public enum Audio360ChannelMode
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
	public struct TimeRange
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public double startTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public double duration;
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[DefaultMember("Item")]
	public class XNCUMSEBRSH : IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		internal TimeRange[] TMNNFAQPPXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		internal double VRXAVVNTEWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		internal double UXOAHSGZPYM;

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public int MAXRYHRIEQH
		{
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0xB5D700", Offset = "0xB5BD00", VA = "0x180B5D700")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public double PVQPVGTYBEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x2A53C40", Offset = "0x2A52240", VA = "0x182A53C40")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public double AFVMZLANSQP
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x2A53FF0", Offset = "0x2A525F0", VA = "0x182A53FF0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public double URCAKTIPEVO
		{
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x2A53C70", Offset = "0x2A52270", VA = "0x182A53C70")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x2A54000", Offset = "0x2A52600", VA = "0x182A54000")]
		internal XNCUMSEBRSH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x2A53C50", Offset = "0x2A52250", VA = "0x182A53C50", Slot = "4")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x2A53DD0", Offset = "0x2A523D0", VA = "0x182A53DD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x2A53C80", Offset = "0x2A52280", VA = "0x182A53C80")]
		internal void TLKJNGUYRZT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class WMSGPJGMOZH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private int YECSQQLNZBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private long PQJFAAMVTUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private ZRCJHFWYBKC MKSMLTGPVWI;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public int AVWCBELSQNE
		{
			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0xAA5110", Offset = "0xAA3710", VA = "0x180AA5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0xAA7720", Offset = "0xAA5D20", VA = "0x180AA7720")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public int KMJNUJUMKPN
		{
			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0xC071B0", Offset = "0xC057B0", VA = "0x180C071B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0xC071A0", Offset = "0xC057A0", VA = "0x180C071A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public int SXYCEHFIITZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9D0", Offset = "0xAA8FD0", VA = "0x180AAA9D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6A0", Offset = "0xAA9CA0", VA = "0x180AAB6A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		private float KSJEXWKLSIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x1441FA0", Offset = "0x14405A0", VA = "0x181441FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		private string QXCBWSPXPJF
		{
			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0xAA7770", Offset = "0xAA5D70", VA = "0x180AA7770")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		private int IHXYAXYKIBN
		{
			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0xAA7700", Offset = "0xAA5D00", VA = "0x180AA7700")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0xAA7780", Offset = "0xAA5D80", VA = "0x180AA7780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		private int XVCSRBXYMPK
		{
			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0xC531C0", Offset = "0xC517C0", VA = "0x180C531C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x1DF76B0", Offset = "0x1DF5CB0", VA = "0x181DF76B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public bool FDTHLZMXYJM
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0xAFD4E0", Offset = "0xAFBAE0", VA = "0x180AFD4E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x2A53150", Offset = "0x2A51750", VA = "0x182A53150")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x2A531A0", Offset = "0x2A517A0", VA = "0x182A531A0")]
		internal void Start(ZRCJHFWYBKC player)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x2A53550", Offset = "0x2A51B50", VA = "0x182A53550")]
		internal void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350")]
		private static bool EWTMQOHWWXT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public WMSGPJGMOZH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public sealed class TWWCXVPHOQS : ZRCJHFWYBKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private bool RSWNCLAAFQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private bool DLEARIMKGLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private double RTIGOIXIJTJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private float SOVWXCLSDAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private float VGNJBTMQUBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private bool MFGZUOUVMJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private int KLZCZXNZWYP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private int HWAWLFFMXIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private Texture2D QZACQETPURS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private Texture2D KBEDBNEKMZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private Texture2D PRQGMWRWYMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private float NQBRYSYJYBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private int XDFATDYIEWZ;

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x2A52AA0", Offset = "0x2A510A0", VA = "0x182A52AA0", Slot = "82")]
		public override string DVIWDFHMVFC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x2A52B20", Offset = "0x2A51120", VA = "0x182A52B20", Slot = "83")]
		public override string LYONIRKAIIA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x2A52BA0", Offset = "0x2A511A0", VA = "0x182A52BA0", Slot = "84")]
		public override bool TVOORQKINDS(string a, long b, string c, MediaHints d, int e = 0, bool f = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x2A52AE0", Offset = "0x2A510E0", VA = "0x182A52AE0", Slot = "89")]
		public override void LQDKTOOIDTW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xE7CBD0", Offset = "0xE7B1D0", VA = "0x180E7CBD0", Slot = "90")]
		public override void CGJIFDIEHIO(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xE7C8E0", Offset = "0xE7AEE0", VA = "0x180E7C8E0", Slot = "91")]
		public override bool TSUAXKTVXSK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "92")]
		public override bool EFKXJCDGOEF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "93")]
		public override bool WDLWRYGDSXO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "107")]
		public override bool SCJIKEJHENQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "108")]
		public override bool PYVNHVICAZJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x2A52B70", Offset = "0x2A51170", VA = "0x182A52B70", Slot = "94")]
		public override void Play()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x2A52B60", Offset = "0x2A51160", VA = "0x182A52B60", Slot = "95")]
		public override void Pause()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x2A52B90", Offset = "0x2A51190", VA = "0x182A52B90", Slot = "96")]
		public override void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "109")]
		public override bool YPCRBXGYCUQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xBD1380", Offset = "0xBCF980", VA = "0x180BD1380", Slot = "110")]
		public override bool LWJRMPTXATI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xBD12C0", Offset = "0xBCF8C0", VA = "0x180BD12C0", Slot = "111")]
		public override bool FQJUNEUTCBI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x2A52F10", Offset = "0x2A51510", VA = "0x182A52F10", Slot = "112")]
		public override bool YKTIIVFLCHI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "113")]
		public override bool PRYTYOGNNAK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x2A52A80", Offset = "0x2A51080", VA = "0x182A52A80", Slot = "103")]
		public override double AXCBEQYPKWA()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x1125C10", Offset = "0x1124210", VA = "0x181125C10", Slot = "104")]
		public override int FATSOONCKSF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x105B8B0", Offset = "0x1059EB0", VA = "0x18105B8B0", Slot = "105")]
		public override int QXTYIMTLAAI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xBD1360", Offset = "0xBCF960", VA = "0x180BD1360", Slot = "116")]
		public override Texture GetTexture(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x1F640B0", Offset = "0x1F626B0", VA = "0x181F640B0", Slot = "117")]
		public override int GetTextureFrameCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xF87B30", Offset = "0xF86130", VA = "0x180F87B30", Slot = "127")]
		internal override StereoPacking QNRJKRQNYJD()
		{
			return default(StereoPacking);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "120")]
		public override bool RequiresVerticalFlip()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x2A52A90", Offset = "0x2A51090", VA = "0x182A52A90", Slot = "98")]
		public override void CGVCDQJITYU(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x2A52A90", Offset = "0x2A51090", VA = "0x182A52A90", Slot = "99")]
		public override void KHYAZZAAHLU(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x2A52AD0", Offset = "0x2A510D0", VA = "0x182A52AD0", Slot = "100")]
		public override double JMGDHRGKJDG()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x2A52B40", Offset = "0x2A51140", VA = "0x182A52B40", Slot = "102")]
		public override void NSDQCTPANIX(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x2231B60", Offset = "0x2230160", VA = "0x182231B60", Slot = "101")]
		public override float NWKOBZWTBML()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "129")]
		public override void BAYMRGAIDFX(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "130")]
		public override bool LDXAZWSSMFV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x2A52B50", Offset = "0x2A51150", VA = "0x182A52B50", Slot = "131")]
		public override void PAOZKUSPJXY(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x2231B70", Offset = "0x2230170", VA = "0x182231B70", Slot = "133")]
		public override float IQZBZBKUEAW()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xAF5360", Offset = "0xAF3960", VA = "0x180AF5360", Slot = "106")]
		public override float RPRLIYJYBLU()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x2A52D90", Offset = "0x2A51390", VA = "0x182A52D90", Slot = "146")]
		public override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "148")]
		public override void Render()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "149")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "161")]
		internal override bool UTZCMSRDQWL(TrackType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "162")]
		internal override int EMAXBWGEBPX(TrackType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "163")]
		internal override IDQZUJPPMFY WNNYSDZLMSG(TrackType a, int b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "159")]
		internal override bool MWOPIWPKXLJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "160")]
		internal override string ZQGDEHUEBOO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x2A52F60", Offset = "0x2A51560", VA = "0x182A52F60")]
		public TWWCXVPHOQS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class UXGCXHXEJUK
	{
		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public string JJIGSJIICFP
		{
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9C0", Offset = "0xAA8FC0", VA = "0x180AAA9C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public string XYYIWYZAGLX
		{
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xAA7A70", Offset = "0xAA6070", VA = "0x180AA7A70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public byte[] VWJKAFSUPVE
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0xAA7770", Offset = "0xAA5D70", VA = "0x180AA7770")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x2A52FF0", Offset = "0x2A515F0", VA = "0x182A52FF0")]
		public UXGCXHXEJUK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x2A52F90", Offset = "0x2A51590", VA = "0x182A52F90")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class TNEMELNNSDE : ZRCJHFWYBKC
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		private struct Native
		{
			[Cpp2IlInjected.Token(Token = "0x200005E")]
			internal enum TimeRangeTypes
			{
				[Cpp2IlInjected.Token(Token = "0x40002D3")]
				Seekable,
				[Cpp2IlInjected.Token(Token = "0x40002D4")]
				Buffered
			}

			[Cpp2IlInjected.Token(Token = "0x200005F")]
			public enum RenderThreadEvent
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
			public struct AuthData
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002DA")]
				public string url;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40002DB")]
				public string token;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002DC")]
				public IntPtr keyBytes;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002DD")]
				public int keyBytesLength;
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x2A49AC0", Offset = "0x2A480C0", VA = "0x182A49AC0")]
			public static extern bool IsChangedTracks(IntPtr instance, TrackType trackType);

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x2A49130", Offset = "0x2A47730", VA = "0x182A49130")]
			public static extern int GetTrackCount(IntPtr instance, TrackType trackType);

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x2A493B0", Offset = "0x2A479B0", VA = "0x182A493B0")]
			public static extern bool GetTrackInfo(IntPtr instance, TrackType trackType, int index, int uid, bool isActive, StringBuilder name, int maxNameLength, StringBuilder language, int maxLanguageLength);

			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x2A49A40", Offset = "0x2A48040", VA = "0x182A49A40")]
			public static extern bool IsChangedTextCue(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x2A48240", Offset = "0x2A46840", VA = "0x182A48240")]
			public static extern IntPtr GetCurrentTextCue(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x2A48ED0", Offset = "0x2A474D0", VA = "0x182A48ED0")]
			public static extern int GetTimeRanges(IntPtr playerInstance, [Out] TimeRange[] ranges, int rangeCount, TimeRangeTypes timeRangeType);

			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x2A49840", Offset = "0x2A47E40", VA = "0x182A49840")]
			public static extern bool Init(bool linearColorSpace);

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x2A47BF0", Offset = "0x2A461F0", VA = "0x182A47BF0")]
			public static extern void Deinit();

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x2A48A00", Offset = "0x2A47000", VA = "0x182A48A00")]
			public static extern IntPtr GetPluginVersion();

			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x2A47840", Offset = "0x2A45E40", VA = "0x182A47840")]
			public static extern IntPtr BeginOpenSource(IntPtr instance, CJHFJWBAPDL.VideoApi videoApi, CJHFJWBAPDL.AudioOutput audioOutput, bool useHardwareDecoding, bool useRendererSync, bool generateTextureMips, bool hintAlphaChannel, bool useLowLatency, bool use10BitTextures, string forceAudioOutputDeviceName, int unitySampleRate, IntPtr[] preferredFilter, uint numFilters, int audio360ChannelMode, string httpHeader, bool startWithHighestBitrate);

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x2A47F10", Offset = "0x2A46510", VA = "0x182A47F10")]
			public static extern IntPtr EndOpenSource(IntPtr instance, string path);

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x2A4A4E0", Offset = "0x2A48AE0", VA = "0x182A4A4E0")]
			public static extern IntPtr OpenSourceFromBuffer(IntPtr instance, byte[] buffer, ulong bufferLength, CJHFJWBAPDL.VideoApi videoApi, CJHFJWBAPDL.AudioOutput audioOutput, bool useHardwareDecoding, bool useRendererSync, bool generateTextureMips, bool hintAlphaChannel, bool useLowLatency, bool use10BitTextures, string forceAudioOutputDeviceName, int unitySampleRate, IntPtr[] preferredFilter, uint numFilters);

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x2A4BA90", Offset = "0x2A4A090", VA = "0x182A4BA90")]
			public static extern IntPtr StartOpenSourceFromBuffer(IntPtr instance, CJHFJWBAPDL.VideoApi videoApi, ulong bufferLength);

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x2A47780", Offset = "0x2A45D80", VA = "0x182A47780")]
			public static extern bool AddChunkToSourceBuffer(IntPtr instance, byte[] buffer, ulong offset, ulong chunkLength);

			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x2A47D90", Offset = "0x2A46390", VA = "0x182A47D90")]
			public static extern IntPtr EndOpenSourceFromBuffer(IntPtr instance, CJHFJWBAPDL.AudioOutput audioOutput, bool useHardwareDecoding, bool useRendererSync, bool generateTextureMips, bool hintAlphaChannel, bool useLowLatency, bool use10BitTextures, string forceAudioOutputDeviceName, int unitySampleRate, IntPtr[] preferredFilter, uint numFilters);

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x2A47B00", Offset = "0x2A46100", VA = "0x182A47B00")]
			public static extern void CloseSource(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x2A48910", Offset = "0x2A46F10", VA = "0x182A48910")]
			public static extern IntPtr GetPlayerDescription(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x2A4AF30", Offset = "0x2A49530", VA = "0x182A4AF30")]
			public static extern void SetCustomMovParserEnabled(IntPtr instance, bool enabled);

			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x2A4B0F0", Offset = "0x2A496F0", VA = "0x182A4B0F0")]
			public static extern void SetHapNotchLCEnabled(IntPtr instance, bool enabled);

			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x2A4B860", Offset = "0x2A49E60", VA = "0x182A4B860")]
			public static extern void SetStereoDetectEnabled(IntPtr instance, bool enabled);

			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x2A4B8F0", Offset = "0x2A49EF0", VA = "0x182A4B8F0")]
			public static extern void SetTextTrackSupportEnabled(IntPtr instance, bool enabled);

			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x2A4AA40", Offset = "0x2A49040", VA = "0x182A4AA40")]
			public static extern void SetAudioDelayEnabled(IntPtr instance, bool enabled, bool isAutomatic, double timeSeconds);

			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x2A4B060", Offset = "0x2A49660", VA = "0x182A4B060")]
			public static extern void SetFacebookAudio360SupportEnabled(IntPtr instance, bool enabled);

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x2A4AFC0", Offset = "0x2A495C0", VA = "0x182A4AFC0")]
			public static extern void SetDecoderHints(IntPtr instance, int parallelFrameCount, int prerollFrameCount);

			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x2A48640", Offset = "0x2A46C40", VA = "0x182A48640")]
			public static extern int GetLastErrorCode(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x2A4A810", Offset = "0x2A48E10", VA = "0x182A4A810")]
			public static extern void Play(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x2A4A690", Offset = "0x2A48C90", VA = "0x182A4A690")]
			public static extern void Pause(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x2A4B3F0", Offset = "0x2A499F0", VA = "0x182A4B3F0")]
			public static extern void SetMuted(IntPtr instance, bool muted);

			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x2A4B980", Offset = "0x2A49F80", VA = "0x182A4B980")]
			public static extern void SetVolume(IntPtr instance, float volume);

			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x2A4AE00", Offset = "0x2A49400", VA = "0x182A4AE00")]
			public static extern void SetBalance(IntPtr instance, float volume);

			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x2A4B2D0", Offset = "0x2A498D0", VA = "0x182A4B2D0")]
			public static extern void SetLooping(IntPtr instance, bool looping);

			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x2A497C0", Offset = "0x2A47DC0", VA = "0x182A497C0")]
			public static extern bool HasVideo(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x2A496C0", Offset = "0x2A47CC0", VA = "0x182A496C0")]
			public static extern bool HasAudio(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x2A49510", Offset = "0x2A47B10", VA = "0x182A49510")]
			public static extern int GetWidth(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x2A48540", Offset = "0x2A46B40", VA = "0x182A48540")]
			public static extern int GetHeight(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x2A484C0", Offset = "0x2A46AC0", VA = "0x182A484C0")]
			public static extern float GetFrameRate(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x2A48B50", Offset = "0x2A47150", VA = "0x182A48B50")]
			public static extern StereoPacking GetStereoPacking(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x2A48440", Offset = "0x2A46A40", VA = "0x182A48440")]
			public static extern double GetDuration(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x2A49C60", Offset = "0x2A48260", VA = "0x182A49C60")]
			public static extern bool IsPlaybackStalled(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x2A49740", Offset = "0x2A47D40", VA = "0x182A49740")]
			public static extern bool HasMetaData(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x2A47A00", Offset = "0x2A46000", VA = "0x182A47A00")]
			public static extern bool CanPlay(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x2A49D60", Offset = "0x2A48360", VA = "0x182A49D60")]
			public static extern bool IsSeeking(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x2A49CE0", Offset = "0x2A482E0", VA = "0x182A49CE0")]
			public static extern bool IsPlaying(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x2A49BE0", Offset = "0x2A481E0", VA = "0x182A49BE0")]
			public static extern bool IsFinished(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x2A49940", Offset = "0x2A47F40", VA = "0x182A49940")]
			public static extern bool IsBuffering(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x2A48340", Offset = "0x2A46940", VA = "0x182A48340")]
			public static extern double GetCurrentTime(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x2A4AE90", Offset = "0x2A49490", VA = "0x182A4AE90")]
			public static extern void SetCurrentTime(IntPtr instance, double time, bool fast);

			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x2A48790", Offset = "0x2A46D90", VA = "0x182A48790")]
			public static extern float GetPlaybackRate(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0x2A4B740", Offset = "0x2A49D40", VA = "0x182A4B740")]
			public static extern void SetPlaybackRate(IntPtr instance, float rate);

			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0x2A4BA10", Offset = "0x2A4A010", VA = "0x182A4BA10")]
			public static extern void StartExtractFrame(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0x2A4BC30", Offset = "0x2A4A230", VA = "0x182A4BC30")]
			public static extern void WaitForExtract(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0x2A4BBB0", Offset = "0x2A4A1B0", VA = "0x182A4BBB0")]
			public static extern void Update(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0x2A47FB0", Offset = "0x2A465B0", VA = "0x182A47FB0")]
			public static extern void EndUpdate(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(RVA = "0x2A48DD0", Offset = "0x2A473D0", VA = "0x182A48DD0")]
			public static extern IntPtr GetTexturePointer(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(RVA = "0x2A48C50", Offset = "0x2A47250", VA = "0x182A48C50")]
			public static extern int GetTextureFormat(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0x2A49E60", Offset = "0x2A48460", VA = "0x182A49E60")]
			public static extern bool IsTextureTopDown(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0x2A49DE0", Offset = "0x2A483E0", VA = "0x182A49DE0")]
			public static extern bool IsTextureSampleLinear(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x2A48CD0", Offset = "0x2A472D0", VA = "0x182A48CD0")]
			public static extern int GetTextureFrameCount(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x2A48E50", Offset = "0x2A47450", VA = "0x182A48E50")]
			public static extern long GetTextureTimeStamp(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0x2A48D50", Offset = "0x2A47350", VA = "0x182A48D50")]
			public static extern float GetTexturePixelAspectRatio(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x2A48AE0", Offset = "0x2A470E0", VA = "0x182A48AE0")]
			public static extern IntPtr GetRenderEventFunc();

			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0x2A49590", Offset = "0x2A47B90", VA = "0x182A49590")]
			public static extern int GrabAudio(IntPtr instance, float[] buffer, int sampleCount, int channelCount);

			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0x2A48140", Offset = "0x2A46740", VA = "0x182A48140")]
			public static extern int GetAudioChannelCount(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x2A4A9B0", Offset = "0x2A48FB0", VA = "0x182A4A9B0")]
			public static extern int SetAudioChannelMode(IntPtr instance, int audio360ChannelMode);

			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x2A4B180", Offset = "0x2A49780", VA = "0x182A4B180")]
			public static extern void SetHeadOrientation(IntPtr instance, float x, float y, float z, float w);

			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x2A4AAF0", Offset = "0x2A490F0", VA = "0x182A4AAF0")]
			public static extern void SetAudioFocusEnabled(IntPtr instance, bool enabled);

			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x2A4AB80", Offset = "0x2A49180", VA = "0x182A4AB80")]
			public static extern void SetAudioFocusProps(IntPtr instance, float offFocusLevel, float widthDegrees);

			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x2A4AC20", Offset = "0x2A49220", VA = "0x182A4AC20")]
			public static extern void SetAudioFocusRotation(IntPtr instance, float x, float y, float z, float w);

			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x2A4A170", Offset = "0x2A48770", VA = "0x182A4A170")]
			public static void LWJHAQANEAD(IntPtr a, UXGCXHXEJUK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x2A4B480", Offset = "0x2A49A80", VA = "0x182A4B480")]
			private static extern void SetNextAuthData(IntPtr instance, AuthData authData);
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private CJHFJWBAPDL.AudioOutput QPTQAGMTYEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private string UILTWGNUPHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private List<string> UBBKDRUKXIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private Audio360ChannelMode RGKCWKGAHQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		private bool XYXYLJTWEMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC5")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private bool ZUTJDFHKOKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC6")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private bool QLCSVYXMYCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC7")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private bool NWJGPCPTMCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private bool WFDLKNIDWJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private bool PNOUGVIEFCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private int QOFOSDMEBSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private int OBANTHUQNLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private bool RSWNCLAAFQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD5")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private bool DLEARIMKGLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD6")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private bool CYAWIAWAZRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private float SOVWXCLSDAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private float VIZXKGMIWML;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private bool YYMYKKIWVAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private bool XXVCFSBWIUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE2")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private bool CBYVYGIWRXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private int XMWBCJJKEEX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private int HWAWLFFMXIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private float LDBEKTOIBZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private bool INGKGETKMXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF1")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private bool LOWHESPHHGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF2")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private bool MNVQKFXIJUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private IntPtr DWMTWFUEQWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private Texture2D QZACQETPURS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		private RenderTexture ECXYQPFXQGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private IntPtr EOTFGNPJDZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private CJHFJWBAPDL.VideoApi VNEKTJLJNLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private bool YQROHAEREDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11D")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		private bool QGBIIKQDTEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11E")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private bool IOIGQUQRYAU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11F")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private bool SRCGYOGXTSI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private bool LNSKUGDZJID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x121")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private bool NJZMHHGJYUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x122")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private bool VWBFWHJVQVN;

		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private static bool SPRGIKOKIWK;

		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private static string ADPUPUXWHUD;

		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private static IntPtr FPEKMIYAFTW;

		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private static int FJRUATKGCDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private UXGCXHXEJUK SXAPZQTSJGW;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public UXGCXHXEJUK ZXYGUSXLPIQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x2A4E830", Offset = "0x2A4CE30", VA = "0x182A4E830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x2A4E8B0", Offset = "0x2A4CEB0", VA = "0x182A4E8B0")]
		public static bool GAIYLEJMSXO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x2A4FD10", Offset = "0x2A4E310", VA = "0x182A4FD10")]
		public static void LUQGHGUNJBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x2A50450", Offset = "0x2A4EA50", VA = "0x182A50450", Slot = "135")]
		public override int QWNTFJROBXG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x2A52810", Offset = "0x2A50E10", VA = "0x182A52810")]
		public TNEMELNNSDE(MediaPlayer.OptionsWindows a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x2A4EC90", Offset = "0x2A4D290", VA = "0x182A4EC90")]
		public void GNEIQHJTUEW(MediaPlayer.OptionsWindows a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x2A4ED40", Offset = "0x2A4D340", VA = "0x182A4ED40")]
		public void GNEIQHJTUEW(CJHFJWBAPDL.VideoApi a, CJHFJWBAPDL.AudioOutput b, bool c, bool d, bool e, bool f, bool g, bool h, string i, List<string> j, bool k, int l, int m, bool n, bool o, bool p, bool q, bool r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x2A4E580", Offset = "0x2A4CB80", VA = "0x182A4E580", Slot = "82")]
		public override string DVIWDFHMVFC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x2A4FDD0", Offset = "0x2A4E3D0", VA = "0x182A4FDD0", Slot = "83")]
		public override string LYONIRKAIIA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x184BDB0", Offset = "0x184A3B0", VA = "0x18184BDB0")]
		private bool OJJQYODLTDN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x2A50710", Offset = "0x2A4ED10", VA = "0x182A50710", Slot = "84")]
		public override bool TVOORQKINDS(string a, long b, string c, MediaHints d, int e = 0, bool f = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x2A4E120", Offset = "0x2A4C720", VA = "0x182A4E120", Slot = "85")]
		public override bool CZAJPKUQUXQ(byte[] a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x2A4DD70", Offset = "0x2A4C370", VA = "0x182A4DD70", Slot = "86")]
		public override bool AFPOEJNPJHA(ulong a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x2A510B0", Offset = "0x2A4F6B0", VA = "0x182A510B0", Slot = "87")]
		public override bool USLUORWEACR(byte[] a, ulong b, ulong c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x2A52160", Offset = "0x2A50760", VA = "0x182A52160", Slot = "88")]
		public override bool YWQNQQPUJZL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x2A4FFF0", Offset = "0x2A4E5F0", VA = "0x182A4FFF0")]
		private void NTYYAYBJPGY(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x2A4FB90", Offset = "0x2A4E190", VA = "0x182A4FB90", Slot = "89")]
		public override void LQDKTOOIDTW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x2A4E010", Offset = "0x2A4C610", VA = "0x182A4E010", Slot = "90")]
		public override void CGJIFDIEHIO(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0xAD3630", Offset = "0xAD1C30", VA = "0x180AD3630", Slot = "91")]
		public override bool TSUAXKTVXSK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0xBD12F0", Offset = "0xBCF8F0", VA = "0x180BD12F0", Slot = "92")]
		public override bool EFKXJCDGOEF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0xC0D980", Offset = "0xC0BF80", VA = "0x180C0D980", Slot = "107")]
		public override bool SCJIKEJHENQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xC0D960", Offset = "0xC0BF60", VA = "0x180C0D960", Slot = "108")]
		public override bool PYVNHVICAZJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xBD1300", Offset = "0xBCF900", VA = "0x180BD1300", Slot = "93")]
		public override bool WDLWRYGDSXO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x2A502E0", Offset = "0x2A4E8E0", VA = "0x182A502E0", Slot = "94")]
		public override void Play()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x2A50250", Offset = "0x2A4E850", VA = "0x182A50250", Slot = "95")]
		public override void Pause()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x2A429F0", Offset = "0x2A40FF0", VA = "0x182A429F0", Slot = "96")]
		public override void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x2A520D0", Offset = "0x2A506D0", VA = "0x182A520D0", Slot = "109")]
		public override bool YPCRBXGYCUQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x2A4FDC0", Offset = "0x2A4E3C0", VA = "0x182A4FDC0", Slot = "110")]
		public override bool LWJRMPTXATI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x2A4E870", Offset = "0x2A4CE70", VA = "0x182A4E870", Slot = "111")]
		public override bool FQJUNEUTCBI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x2A52020", Offset = "0x2A50620", VA = "0x182A52020", Slot = "112")]
		public override bool YKTIIVFLCHI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x2A501C0", Offset = "0x2A4E7C0", VA = "0x182A501C0", Slot = "113")]
		public override bool PRYTYOGNNAK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x2A4DE40", Offset = "0x2A4C440", VA = "0x182A4DE40", Slot = "103")]
		public override double AXCBEQYPKWA()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xB13300", Offset = "0xB11900", VA = "0x180B13300", Slot = "104")]
		public override int FATSOONCKSF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0xCAD5A0", Offset = "0xCABBA0", VA = "0x180CAD5A0", Slot = "105")]
		public override int QXTYIMTLAAI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x2353970", Offset = "0x2351F70", VA = "0x182353970", Slot = "106")]
		public override float RPRLIYJYBLU()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x2A4F0C0", Offset = "0x2A4D6C0", VA = "0x182A4F0C0", Slot = "116")]
		public override Texture GetTexture(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x2A4EF80", Offset = "0x2A4D580", VA = "0x182A4EF80", Slot = "117")]
		public override int GetTextureFrameCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x2A4F040", Offset = "0x2A4D640", VA = "0x182A4F040", Slot = "119")]
		public override long GetTextureTimeStamp()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x2A4EF90", Offset = "0x2A4D590", VA = "0x182A4EF90", Slot = "121")]
		public override float GetTexturePixelAspectRatio()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x26C99C0", Offset = "0x26C7FC0", VA = "0x1826C99C0", Slot = "120")]
		public override bool RequiresVerticalFlip()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x2A50370", Offset = "0x2A4E970", VA = "0x182A50370", Slot = "127")]
		internal override StereoPacking QNRJKRQNYJD()
		{
			return default(StereoPacking);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x2A4E030", Offset = "0x2A4C630", VA = "0x182A4E030", Slot = "98")]
		public override void CGVCDQJITYU(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x2A4FB70", Offset = "0x2A4E170", VA = "0x182A4FB70", Slot = "99")]
		public override void KHYAZZAAHLU(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x2A4FA20", Offset = "0x2A4E020", VA = "0x182A4FA20", Slot = "100")]
		public override double JMGDHRGKJDG()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x2A4FF60", Offset = "0x2A4E560", VA = "0x182A4FF60", Slot = "102")]
		public override void NSDQCTPANIX(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x2A50120", Offset = "0x2A4E720", VA = "0x182A50120", Slot = "101")]
		public override float NWKOBZWTBML()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x2A4DEC0", Offset = "0x2A4C4C0", VA = "0x182A4DEC0", Slot = "129")]
		public override void BAYMRGAIDFX(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x2A37AD0", Offset = "0x2A360D0", VA = "0x182A37AD0", Slot = "130")]
		public override bool LDXAZWSSMFV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x2A501A0", Offset = "0x2A4E7A0", VA = "0x182A501A0", Slot = "131")]
		public override void PAOZKUSPJXY(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x15AB7D0", Offset = "0x15A9DD0", VA = "0x1815AB7D0", Slot = "133")]
		public override float IQZBZBKUEAW()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x2A51AF0", Offset = "0x2A500F0", VA = "0x182A51AF0", Slot = "132")]
		public override void VYVCXLJICQE(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x226D630", Offset = "0x226BC30", VA = "0x18226D630", Slot = "134")]
		public override float GetBalance()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x2A4F7A0", Offset = "0x2A4DDA0", VA = "0x182A4F7A0", Slot = "153")]
		public override bool ILXQDIZHJIQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x2A4F850", Offset = "0x2A4DE50", VA = "0x182A4F850", Slot = "114")]
		public override bool IVYTWKXGFIS(Camera a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x2A51A60", Offset = "0x2A50060", VA = "0x182A51A60", Slot = "140")]
		public override void VJEDPMFSWFI(Audio360ChannelMode a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x2A4FE00", Offset = "0x2A4E400", VA = "0x182A4FE00", Slot = "138")]
		public override void MGPIAXUGHHY(Quaternion a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x2A51B90", Offset = "0x2A50190", VA = "0x182A51B90", Slot = "139")]
		public override void WAQZRPKPPHR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x2A4FED0", Offset = "0x2A4E4D0", VA = "0x182A4FED0", Slot = "141")]
		public override void NGXGQKNMBDR(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x2A4F700", Offset = "0x2A4DD00", VA = "0x182A4F700", Slot = "142")]
		public override void ICGNOBHKCAL(float a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x2A52600", Offset = "0x2A50C00", VA = "0x182A52600", Slot = "143")]
		public override void ZLEUQMKXLVG(Quaternion a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x2A51210", Offset = "0x2A4F810", VA = "0x182A51210", Slot = "146")]
		public override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x2A4E5D0", Offset = "0x2A4CBD0", VA = "0x182A4E5D0")]
		private void DYRQDJLIKYM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x2A4F160", Offset = "0x2A4D760", VA = "0x182A4F160")]
		private void HMRSUYXLUWE(IntPtr a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x2A50690", Offset = "0x2A4EC90", VA = "0x182A50690", Slot = "150")]
		public override void TTMWGBYQANK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		private void QRTZZBUHCOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x2A505D0", Offset = "0x2A4EBD0", VA = "0x182A505D0", Slot = "147")]
		public override void SXZXUUTCMQF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x2A504D0", Offset = "0x2A4EAD0", VA = "0x182A504D0", Slot = "148")]
		public override void Render()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "149")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x2A4DF50", Offset = "0x2A4C550", VA = "0x182A4DF50", Slot = "136")]
		public override int BIREPVHQSSA(float[] a, int b, int c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x1833F20", Offset = "0x1832520", VA = "0x181833F20", Slot = "151")]
		public override bool ITVSYWAUMFN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x2A4FAA0", Offset = "0x2A4E0A0", VA = "0x182A4FAA0")]
		private static void JNIQWCWLZLL(Native.RenderThreadEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x2A4E780", Offset = "0x2A4CD80", VA = "0x182A4E780")]
		private static string EXVTHUCWWIB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x2A4FE40", Offset = "0x2A4E440", VA = "0x182A4FE40", Slot = "159")]
		internal override bool MWOPIWPKXLJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x2A526B0", Offset = "0x2A50CB0", VA = "0x182A526B0", Slot = "160")]
		internal override string ZQGDEHUEBOO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x2A51170", Offset = "0x2A4F770", VA = "0x182A51170", Slot = "161")]
		internal override bool UTZCMSRDQWL(TrackType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x2A4E6E0", Offset = "0x2A4CCE0", VA = "0x182A4E6E0", Slot = "162")]
		internal override int EMAXBWGEBPX(TrackType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x2A51C90", Offset = "0x2A50290", VA = "0x182A51C90", Slot = "163")]
		internal override IDQZUJPPMFY WNNYSDZLMSG(TrackType a, int b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x2A503F0", Offset = "0x2A4E9F0", VA = "0x182A503F0", Slot = "144")]
		public override void QTVPZWVJDXV(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x2A4E0C0", Offset = "0x2A4C6C0", VA = "0x182A4E0C0", Slot = "145")]
		public override void CRJANHVAJNK(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x2A4E050", Offset = "0x2A4C650", VA = "0x182A4E050")]
		private void CKXUAVDNBTI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x2A52530", Offset = "0x2A50B30", VA = "0x182A52530")]
		private void ZJLSEJEJASZ(TimeRange[] a, Native.TimeRangeTypes b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public enum PlaybackState
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
	public sealed class DPHHZWFLPXG : ZRCJHFWYBKC
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		private struct Native
		{
			[Cpp2IlInjected.Token(Token = "0x2000064")]
			public enum SeekMode
			{
				[Cpp2IlInjected.Token(Token = "0x40002F3")]
				Fast,
				[Cpp2IlInjected.Token(Token = "0x40002F4")]
				Accurate
			}

			[StructLayout((LayoutKind)0, Pack = 1, Size = 20)]
			[Cpp2IlInjected.Token(Token = "0x2000065")]
			public struct VideoTrack
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F5")]
				public int trackIndex;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40002F6")]
				public int frameWidth;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40002F7")]
				public int frameHeight;

				[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
				[Cpp2IlInjected.Token(Token = "0x40002F8")]
				public float frameRate;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002F9")]
				public uint averageBitRate;
			}

			[StructLayout((LayoutKind)0, Pack = 1, Size = 12)]
			[Cpp2IlInjected.Token(Token = "0x2000066")]
			public struct SeekParams
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002FA")]
				public double timeSeconds;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40002FB")]
				public SeekMode mode;
			}

			[StructLayout((LayoutKind)0, Pack = 1, Size = 28)]
			[Cpp2IlInjected.Token(Token = "0x2000067")]
			public struct AuthData
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002FC")]
				public string url;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40002FD")]
				public string token;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002FE")]
				public IntPtr keyBytes;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002FF")]
				public int keyBytesLength;
			}

			[Cpp2IlInjected.Token(Token = "0x2000068")]
			internal enum TimeRangeTypes
			{
				[Cpp2IlInjected.Token(Token = "0x4000301")]
				Seekable,
				[Cpp2IlInjected.Token(Token = "0x4000302")]
				Buffered
			}

			[Cpp2IlInjected.Token(Token = "0x40002F1")]
			private static IntPtr _nativeFunction_UnityRenderEvent;

			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x2A49B50", Offset = "0x2A48150", VA = "0x182A49B50")]
			public static extern bool IsChangedTracks(IntPtr instance, TrackType trackType);

			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0x2A491C0", Offset = "0x2A477C0", VA = "0x182A491C0")]
			public static extern int GetTrackCount(IntPtr instance, TrackType trackType);

			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0x2A49250", Offset = "0x2A47850", VA = "0x182A49250")]
			public static extern bool GetTrackInfo(IntPtr instance, TrackType trackType, int index, int uid, bool isActive, StringBuilder name, int maxNameLength, StringBuilder language, int maxLanguageLength);

			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0x2A499C0", Offset = "0x2A47FC0", VA = "0x182A499C0")]
			public static extern bool IsChangedTextCue(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0x2A482C0", Offset = "0x2A468C0", VA = "0x182A482C0")]
			public static extern IntPtr GetCurrentTextCue(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0x2A48990", Offset = "0x2A46F90", VA = "0x182A48990")]
			private static extern IntPtr GetPluginVersionStringPointer();

			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0x2A47CE0", Offset = "0x2A462E0", VA = "0x182A47CE0")]
			public static string EXVTHUCWWIB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x2A47B80", Offset = "0x2A46180", VA = "0x182A47B80")]
			public static extern IntPtr CreatePlayer();

			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0x2A47C60", Offset = "0x2A46260", VA = "0x182A47C60")]
			public static extern void DestroyPlayer(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0x2A4A400", Offset = "0x2A48A00", VA = "0x182A4A400")]
			public static extern bool OpenMedia(IntPtr playerInstance, string filePath, string httpHeader, FileFormat overrideFileFormat, bool startWithHighestBitrate, bool use10BitTextures);

			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0x2A47A80", Offset = "0x2A46080", VA = "0x182A47A80")]
			public static extern void CloseMedia(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003D7")]
			[Cpp2IlInjected.Address(RVA = "0x2A4A710", Offset = "0x2A48D10", VA = "0x182A4A710")]
			public static extern void Pause(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003D8")]
			[Cpp2IlInjected.Address(RVA = "0x2A4A790", Offset = "0x2A48D90", VA = "0x182A4A790")]
			public static extern void Play(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0x2A4AD70", Offset = "0x2A49370", VA = "0x182A4AD70")]
			public static extern void SetAudioVolume(IntPtr playerInstance, float volume);

			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0x2A4A920", Offset = "0x2A48F20", VA = "0x182A4A920")]
			public static extern void SetAudioBalance(IntPtr playerInstance, float balance);

			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0x2A4B7D0", Offset = "0x2A49DD0", VA = "0x182A4B7D0")]
			public static extern void SetPlaybackRate(IntPtr playerInstance, float rate);

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x2A4ACE0", Offset = "0x2A492E0", VA = "0x182A4ACE0")]
			public static extern void SetAudioMuted(IntPtr playerInstance, bool muted);

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x2A498C0", Offset = "0x2A47EC0", VA = "0x182A498C0")]
			public static extern bool IsAudioMuted(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x2A480C0", Offset = "0x2A466C0", VA = "0x182A480C0")]
			public static extern float GetAudioBalance(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x2A48810", Offset = "0x2A46E10", VA = "0x182A48810")]
			public static extern float GetPlaybackRate(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x2A4B360", Offset = "0x2A49960", VA = "0x182A4B360")]
			public static extern void SetLooping(IntPtr playerInstance, bool looping);

			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0x2A485C0", Offset = "0x2A46BC0", VA = "0x182A485C0")]
			public static extern int GetLastErrorCode(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0x2A4BB30", Offset = "0x2A4A130", VA = "0x182A4BB30")]
			public static extern void Update(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x2A483C0", Offset = "0x2A469C0", VA = "0x182A483C0")]
			public static extern double GetDuration(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x2A48BD0", Offset = "0x2A471D0", VA = "0x182A48BD0")]
			public static extern StereoPacking GetStereoPacking(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x2A481C0", Offset = "0x2A467C0", VA = "0x182A481C0")]
			public static extern double GetCurrentPosition(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x2A486C0", Offset = "0x2A46CC0", VA = "0x182A486C0")]
			public static extern bool GetLatestFrame(IntPtr playerInstance, [Out] IntPtr leftEyeTexturePointer, [Out] IntPtr rightEyeTexturePointer, [Out] ulong frameTimeStamp, [Out] int width, [Out] int height);

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x2A48890", Offset = "0x2A46E90", VA = "0x182A48890")]
			public static extern PlaybackState GetPlaybackState(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x2A48030", Offset = "0x2A46630", VA = "0x182A48030")]
			public static extern bool GetActiveVideoTrackInfo(IntPtr playerInstance, [Out] VideoTrack videoTrack);

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x2A4B240", Offset = "0x2A49840", VA = "0x182A4B240")]
			public static extern void SetLiveOffset(IntPtr playerInstance, double seconds);

			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x2A4A890", Offset = "0x2A48E90", VA = "0x182A4A890")]
			public static extern void Seek(IntPtr playerInstance, SeekParams seekParams);

			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0x2A49EE0", Offset = "0x2A484E0", VA = "0x182A49EE0")]
			public static void LWJHAQANEAD(IntPtr a, UXGCXHXEJUK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0x2A4B5E0", Offset = "0x2A49BE0", VA = "0x182A4B5E0")]
			private static extern void SetNextAuthData(IntPtr playerInstance, AuthData authData);

			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x2A49000", Offset = "0x2A47600", VA = "0x182A49000")]
			public static extern int GetTimeRanges(IntPtr playerInstance, [Out] TimeRange[] ranges, int rangeCount, TimeRangeTypes timeRangeType);

			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0x2A48A70", Offset = "0x2A47070", VA = "0x182A48A70")]
			public static extern IntPtr GetRenderEventFunc();

			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0x2A42940", Offset = "0x2A40F40", VA = "0x182A42940")]
			public static void WVBABRHQZWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x2A49650", Offset = "0x2A47C50", VA = "0x182A49650")]
			public static void HASXXKWYHML()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		private class DDSQAHMOYME
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000303")]
			public Texture2D PZRMIEMHSQD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000304")]
			public IntPtr TOZXAVSPQMY;

			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0x2A412A0", Offset = "0x2A3F8A0", VA = "0x182A412A0")]
			public void BBUPLYUGUMR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0x2A41390", Offset = "0x2A3F990", VA = "0x182A41390")]
			public DDSQAHMOYME()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private bool AKGZBIDVTDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private bool YYMYKKIWVAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		private float SOVWXCLSDAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private bool SRCGYOGXTSI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private bool PLGIFITWIJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private UXGCXHXEJUK SXAPZQTSJGW;

		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private static bool SPRGIKOKIWK;

		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		private static string ADPUPUXWHUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		private ulong EDBTQITCVXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private IntPtr ZSEFSCXYVBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private DDSQAHMOYME[] LMNBAEPPQIS;

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public UXGCXHXEJUK ZXYGUSXLPIQ
		{
			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x2A41910", Offset = "0x2A3FF10", VA = "0x182A41910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x2A43870", Offset = "0x2A41E70", VA = "0x182A43870")]
		public DPHHZWFLPXG(MediaPlayer.OptionsWindows a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x2A41BF0", Offset = "0x2A401F0", VA = "0x182A41BF0")]
		public void GNEIQHJTUEW(MediaPlayer.OptionsWindows a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x2A43220", Offset = "0x2A41820", VA = "0x182A43220", Slot = "93")]
		public override bool WDLWRYGDSXO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x2A41610", Offset = "0x2A3FC10", VA = "0x182A41610", Slot = "149")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "151")]
		public override bool ITVSYWAUMFN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x2A41D80", Offset = "0x2A40380", VA = "0x182A41D80", Slot = "100")]
		public override double JMGDHRGKJDG()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x2A413A0", Offset = "0x2A3F9A0", VA = "0x182A413A0", Slot = "103")]
		public override double AXCBEQYPKWA()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x2A42120", Offset = "0x2A40720", VA = "0x182A42120", Slot = "101")]
		public override float NWKOBZWTBML()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x2A41D30", Offset = "0x2A40330", VA = "0x182A41D30", Slot = "116")]
		public override Texture GetTexture(int index = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x2A41CA0", Offset = "0x2A402A0", VA = "0x182A41CA0", Slot = "115")]
		public override int GetTextureCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xF6EA60", Offset = "0xF6D060", VA = "0x180F6EA60", Slot = "117")]
		public override int GetTextureFrameCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x2A42320", Offset = "0x2A40920", VA = "0x182A42320", Slot = "127")]
		internal override StereoPacking QNRJKRQNYJD()
		{
			return default(StereoPacking);
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x2A415C0", Offset = "0x2A3FBC0", VA = "0x182A415C0", Slot = "82")]
		public override string DVIWDFHMVFC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x2A41FD0", Offset = "0x2A405D0", VA = "0x182A41FD0", Slot = "83")]
		public override string LYONIRKAIIA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x2A42890", Offset = "0x2A40E90", VA = "0x182A42890", Slot = "106")]
		public override float RPRLIYJYBLU()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x2A41840", Offset = "0x2A3FE40", VA = "0x182A41840", Slot = "104")]
		public override int FATSOONCKSF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x2A42400", Offset = "0x2A40A00", VA = "0x182A42400", Slot = "105")]
		public override int QXTYIMTLAAI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x16802D0", Offset = "0x167E8D0", VA = "0x1816802D0", Slot = "133")]
		public override float IQZBZBKUEAW()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x2A43190", Offset = "0x2A41790", VA = "0x182A43190", Slot = "132")]
		public override void VYVCXLJICQE(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x2A41C20", Offset = "0x2A40220", VA = "0x182A41C20", Slot = "134")]
		public override float GetBalance()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x2A429B0", Offset = "0x2A40FB0", VA = "0x182A429B0", Slot = "107")]
		public override bool SCJIKEJHENQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x2A41780", Offset = "0x2A3FD80", VA = "0x182A41780", Slot = "92")]
		public override bool EFKXJCDGOEF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x2A421E0", Offset = "0x2A407E0", VA = "0x182A421E0", Slot = "108")]
		public override bool PYVNHVICAZJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x2A421C0", Offset = "0x2A407C0", VA = "0x182A421C0", Slot = "113")]
		public override bool PRYTYOGNNAK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x2A43590", Offset = "0x2A41B90", VA = "0x182A43590", Slot = "112")]
		public override bool YKTIIVFLCHI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0xBD12C0", Offset = "0xBCF8C0", VA = "0x180BD12C0", Slot = "91")]
		public override bool TSUAXKTVXSK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x2A41E20", Offset = "0x2A40420", VA = "0x182A41E20", Slot = "130")]
		public override bool LDXAZWSSMFV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x2A41950", Offset = "0x2A3FF50", VA = "0x182A41950", Slot = "111")]
		public override bool FQJUNEUTCBI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x2A41FB0", Offset = "0x2A405B0", VA = "0x182A41FB0", Slot = "110")]
		public override bool LWJRMPTXATI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x2A43640", Offset = "0x2A41C40", VA = "0x182A43640", Slot = "109")]
		public override bool YPCRBXGYCUQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x2A413B0", Offset = "0x2A3F9B0", VA = "0x182A413B0", Slot = "129")]
		public override void BAYMRGAIDFX(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x2A42A10", Offset = "0x2A41010", VA = "0x182A42A10", Slot = "84")]
		public override bool TVOORQKINDS(string a, long b, string c, MediaHints d, int e = 0, bool f = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x2A41EB0", Offset = "0x2A404B0", VA = "0x182A41EB0", Slot = "89")]
		public override void LQDKTOOIDTW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x2A42220", Offset = "0x2A40820", VA = "0x182A42220", Slot = "95")]
		public override void Pause()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x2A422A0", Offset = "0x2A408A0", VA = "0x182A422A0", Slot = "94")]
		public override void Play()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x2A42940", Offset = "0x2A40F40", VA = "0x182A42940", Slot = "148")]
		public override void Render()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x2A424D0", Offset = "0x2A40AD0", VA = "0x182A424D0")]
		private void QYWJYCJXSTU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "120")]
		public override bool RequiresVerticalFlip()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x2A41460", Offset = "0x2A3FA60", VA = "0x182A41460", Slot = "98")]
		public override void CGVCDQJITYU(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x2A41E00", Offset = "0x2A40400", VA = "0x182A41E00", Slot = "99")]
		public override void KHYAZZAAHLU(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x2A41440", Offset = "0x2A3FA40", VA = "0x182A41440", Slot = "90")]
		public override void CGJIFDIEHIO(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x2A42090", Offset = "0x2A40690", VA = "0x182A42090", Slot = "102")]
		public override void NSDQCTPANIX(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x2A421A0", Offset = "0x2A407A0", VA = "0x182A421A0", Slot = "131")]
		public override void PAOZKUSPJXY(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x2A429F0", Offset = "0x2A40FF0", VA = "0x182A429F0", Slot = "96")]
		public override void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x2A414F0", Offset = "0x2A3FAF0", VA = "0x182A414F0")]
		private void CKXUAVDNBTI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x2A43660", Offset = "0x2A41C60", VA = "0x182A43660")]
		private void ZJLSEJEJASZ(TimeRange[] a, Native.TimeRangeTypes b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x2A42CF0", Offset = "0x2A412F0", VA = "0x182A42CF0", Slot = "146")]
		public override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x2A423A0", Offset = "0x2A409A0", VA = "0x182A423A0", Slot = "144")]
		public override void QTVPZWVJDXV(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x2A41560", Offset = "0x2A3FB60", VA = "0x182A41560", Slot = "145")]
		public override void CRJANHVAJNK(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x2A42C60", Offset = "0x2A41260", VA = "0x182A42C60", Slot = "161")]
		internal override bool UTZCMSRDQWL(TrackType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x2A417B0", Offset = "0x2A3FDB0", VA = "0x182A417B0", Slot = "162")]
		internal override int EMAXBWGEBPX(TrackType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x2A43240", Offset = "0x2A41840", VA = "0x182A43240", Slot = "163")]
		internal override IDQZUJPPMFY WNNYSDZLMSG(TrackType a, int b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x2A42000", Offset = "0x2A40600", VA = "0x182A42000", Slot = "159")]
		internal override bool MWOPIWPKXLJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x2A43730", Offset = "0x2A41D30", VA = "0x182A43730", Slot = "160")]
		internal override string ZQGDEHUEBOO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x2A41970", Offset = "0x2A3FF70", VA = "0x182A41970")]
		public static bool GAIYLEJMSXO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x2A41F60", Offset = "0x2A40560", VA = "0x182A41F60")]
		public static void LUQGHGUNJBE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class CVUPBOXMPMO
	{
		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public string NYDKNPIFIRN
		{
			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9C0", Offset = "0xAA8FC0", VA = "0x180AAA9C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
		internal CVUPBOXMPMO(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public enum TrackType
	{
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		Video,
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		Audio,
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		Text
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class IDQZUJPPMFY
	{
		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public int WQPQLQPPATU
		{
			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0xAA5110", Offset = "0xAA3710", VA = "0x180AA5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0xAA7720", Offset = "0xAA5D20", VA = "0x180AA7720")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		private TrackType CHGYOXEVWLZ
		{
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0xC071A0", Offset = "0xC057A0", VA = "0x180C071A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		private string RNVGACKCYSR
		{
			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0xAA7A70", Offset = "0xAA6070", VA = "0x180AA7A70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public string UDAZODDRFXJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003FB")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003FC")]
			[Cpp2IlInjected.Address(RVA = "0xAA7770", Offset = "0xAA5D70", VA = "0x180AA7770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public string OUWXHVEYJPI
		{
			[Cpp2IlInjected.Token(Token = "0x60003FD")]
			[Cpp2IlInjected.Address(RVA = "0xAAFED0", Offset = "0xAAE4D0", VA = "0x180AAFED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0xAA8690", Offset = "0xAA6C90", VA = "0x180AA8690")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		private bool UNKOQHSQIXH
		{
			[Cpp2IlInjected.Token(Token = "0x60003FF")]
			[Cpp2IlInjected.Address(RVA = "0xAFD1B0", Offset = "0xAFB7B0", VA = "0x180AFD1B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x2A440B0", Offset = "0x2A426B0", VA = "0x182A440B0")]
		internal IDQZUJPPMFY(TrackType a, int b, string c, string d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x2A43FF0", Offset = "0x2A425F0", VA = "0x182A43FF0")]
		protected string TCOQBLCXOPD()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public abstract class MUSTFVAONXV : IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public virtual TrackType CHGYOXEVWLZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000401")]
			[Cpp2IlInjected.Address(RVA = "0xAA5110", Offset = "0xAA3710", VA = "0x180AA5110", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(TrackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public abstract int MAXRYHRIEQH
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
		internal abstract void Clear();

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(Slot = "9")]
		internal abstract void Add(IDQZUJPPMFY track);

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(Slot = "10")]
		internal abstract void NZTHTGSDNTX(IDQZUJPPMFY a);

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		protected MUSTFVAONXV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[DefaultMember("Item")]
	public class SVJMKFCVXWE<a> : MUSTFVAONXV where a : IDQZUJPPMFY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		internal List<a> ICCVCANNACB;

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		internal a OTNZEIZGQWV
		{
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0xAA7A70", Offset = "0xAA6070", VA = "0x180AA7A70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public override int MAXRYHRIEQH
		{
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0x1542BC0", Offset = "0x15411C0", VA = "0x181542BC0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x5F9D800", Offset = "0x5F9BE00", VA = "0x185F9D800")]
		internal SVJMKFCVXWE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x5F9D740", Offset = "0x5F9BD40", VA = "0x185F9D740", Slot = "7")]
		public override IEnumerator GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x5F9D6E0", Offset = "0x5F9BCE0", VA = "0x185F9D6E0", Slot = "8")]
		internal override void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x5F9D610", Offset = "0x5F9BC10", VA = "0x185F9D610", Slot = "9")]
		internal override void Add(IDQZUJPPMFY track)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x5F9D7A0", Offset = "0x5F9BDA0", VA = "0x185F9D7A0", Slot = "10")]
		internal override void NZTHTGSDNTX(IDQZUJPPMFY a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class LENFRTKEOYD : SVJMKFCVXWE<ILTDAJHDJBU>
	{
		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public override TrackType CHGYOXEVWLZ
		{
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "5")]
			get
			{
				return default(TrackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x2A470B0", Offset = "0x2A456B0", VA = "0x182A470B0")]
		public LENFRTKEOYD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class GSWJQVUGIDY : SVJMKFCVXWE<TUNXMAHNQEB>
	{
		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public override TrackType CHGYOXEVWLZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0xC4A0B0", Offset = "0xC486B0", VA = "0x180C4A0B0", Slot = "5")]
			get
			{
				return default(TrackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x2A43A80", Offset = "0x2A42080", VA = "0x182A43A80")]
		public GSWJQVUGIDY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class MVTJOZOFDXN : SVJMKFCVXWE<THEULWKRZBY>
	{
		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public override TrackType CHGYOXEVWLZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0xB02440", Offset = "0xB00A40", VA = "0x180B02440", Slot = "5")]
			get
			{
				return default(TrackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x2A47140", Offset = "0x2A45740", VA = "0x182A47140")]
		public MVTJOZOFDXN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class ILTDAJHDJBU : IDQZUJPPMFY
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x2A441E0", Offset = "0x2A427E0", VA = "0x182A441E0")]
		internal ILTDAJHDJBU(int a, string b, string c, bool d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class TUNXMAHNQEB : IDQZUJPPMFY
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x2A52A50", Offset = "0x2A51050", VA = "0x182A52A50")]
		internal TUNXMAHNQEB(int a, string b, string c, bool d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class THEULWKRZBY : IDQZUJPPMFY
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x2A4DD40", Offset = "0x2A4C340", VA = "0x182A4DD40")]
		internal THEULWKRZBY(int a, string b, string c, bool d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public interface FTURTUKZXFE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public interface WCMCARWXVVZ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public interface VZCLVKGQUTK
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public static class SKZTDPXQOXX
	{
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		public enum Preset
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
		[Cpp2IlInjected.Address(RVA = "0x2A4D660", Offset = "0x2A4BC60", VA = "0x182A4D660")]
		public static Func<float, float> MEOLGONAEIM(Preset a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x2A4D5C0", Offset = "0x2A4BBC0", VA = "0x182A4D5C0")]
		public static float GWSASVONCXS(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x2A4D310", Offset = "0x2A4B910", VA = "0x182A4D310")]
		public static float ABEYETOOJRP(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x2A4DB60", Offset = "0x2A4C160", VA = "0x182A4DB60")]
		public static float NUNQMECACYE(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x2A4D5A0", Offset = "0x2A4BBA0", VA = "0x182A4D5A0")]
		public static float FGFIULXESZI(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		public static float ZYWRPMHCVXX(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x2A4D650", Offset = "0x2A4BC50", VA = "0x182A4D650")]
		public static float KZFHWPEZJDO(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x2A4D490", Offset = "0x2A4BA90", VA = "0x182A4D490")]
		public static float CZMKWELJBAH(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x2A4D350", Offset = "0x2A4B950", VA = "0x182A4D350")]
		public static float APDKXDOXMNY(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x2A4DD30", Offset = "0x2A4C330", VA = "0x182A4DD30")]
		public static float WGISDWCRXXV(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x2A4DCF0", Offset = "0x2A4C2F0", VA = "0x182A4DCF0")]
		public static float TPMSMNVEKXE(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x2A4D3D0", Offset = "0x2A4B9D0", VA = "0x182A4D3D0")]
		public static float AVOGDLRXGPD(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x2A4DB50", Offset = "0x2A4C150", VA = "0x182A4DB50")]
		public static float MVIZAGRNKES(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x2A4D4D0", Offset = "0x2A4BAD0", VA = "0x182A4D4D0")]
		public static float FCZDLRNLVST(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x2A4D5D0", Offset = "0x2A4BBD0", VA = "0x182A4D5D0")]
		public static float JPHMKHXFLNW(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x2A4DB40", Offset = "0x2A4C140", VA = "0x182A4DB40")]
		public static float MIIJQGHNYIG(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x2A4D450", Offset = "0x2A4BA50", VA = "0x182A4D450")]
		public static float BBSZCTSPEWT(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x2A4DC70", Offset = "0x2A4C270", VA = "0x182A4DC70")]
		public static float RPSJIIHSUYY(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x2A4DC30", Offset = "0x2A4C230", VA = "0x182A4DC30")]
		public static float PTETHSUJJHB(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x2A4DBE0", Offset = "0x2A4C1E0", VA = "0x182A4DBE0")]
		public static float PJZYKCFOPUY(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x2A4D510", Offset = "0x2A4BB10", VA = "0x182A4D510")]
		public static float FFPCSZHGLBD(float a)
		{
			return default(float);
		}
	}
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
		[Cpp2IlInjected.Address(RVA = "0x2A43F20", Offset = "0x2A42520", VA = "0x182A43F20")]
		public bool YSRRIISRPBZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x2A43F60", Offset = "0x2A42560", VA = "0x182A43F60")]
		public string ZXACWICEVDK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x2A43E50", Offset = "0x2A42450", VA = "0x182A43E50")]
		public static bool HFYUEIOIRYO(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x2A43DA0", Offset = "0x2A423A0", VA = "0x182A43DA0")]
		private static bool ALOEKBLXPHB(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x2A43E10", Offset = "0x2A42410", VA = "0x182A43E10")]
		private bool HFYUEIOIRYO()
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
		[Cpp2IlInjected.Address(RVA = "0x2A43AC0", Offset = "0x2A420C0", VA = "0x182A43AC0", Slot = "4")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x2A43B40", Offset = "0x2A42140", VA = "0x182A43B40")]
		public string ZXACWICEVDK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x2A43D20", Offset = "0x2A42320", VA = "0x182A43D20")]
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
		private byte[] GSCLCGYGNTZ;

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public byte[] overrideDecryptionKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x2A46FD0", Offset = "0x2A455D0", VA = "0x182A46FD0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public KeyAuthData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class IPMJYMMWIHF
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		private class PTLITFAFOYA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			public RenderTexture PZRMIEMHSQD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			public long ZMTRWVKKRYU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			public bool RQETNBGMHDD;

			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public PTLITFAFOYA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007F")]
		public enum ResampleMode
		{
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			POINT,
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			LINEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private List<PTLITFAFOYA[]> QOMDZYFBDCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private MediaPlayer ZELCDQBHOBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private RenderTexture[] TTGYQIGKUHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private int RNBUXGYAYMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		private int CWHHVQIGHGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		private int EUCXMYRSFUO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		private long WTUJHRWABCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		private float TONETNTCYMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		private Material OSBODIDCRXQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private ResampleMode BERTMIVJPPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private string XXGCTXHYPPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		private long PQJFAAMVTUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		private int RLCOQUOHCSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private long FTAFVDJWRKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private int KGXKMRHSSEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private long NEVKLLTZMPB;

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private const string CWIRTZBXNOI = "_t";

		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private const string QRIRFKKCYVZ = "_AfterTex";

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private int ABBFNRCEAIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private int ZYJZXLNCRDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private float FTDMXMVXEVR;

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		private float HMPUNJTRJHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000439")]
			[Cpp2IlInjected.Address(RVA = "0x16A7010", Offset = "0x16A5610", VA = "0x1816A7010")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		private long OZZGLGXZGBX
		{
			[Cpp2IlInjected.Token(Token = "0x600043A")]
			[Cpp2IlInjected.Address(RVA = "0x2A46BE0", Offset = "0x2A451E0", VA = "0x182A46BE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public Texture[] MYISOZNLZXS
		{
			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x2A450F0", Offset = "0x2A436F0", VA = "0x182A450F0")]
		public void NFFZAJGYQQY(MediaPlayer a, MediaPlayerEvent.EventType b, ErrorCode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x2A46BF0", Offset = "0x2A451F0", VA = "0x182A46BF0")]
		public IPMJYMMWIHF(MediaPlayer a, string b, int c = 2, ResampleMode d = ResampleMode.LINEAR)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x2A45690", Offset = "0x2A43C90", VA = "0x182A45690")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x2A455B0", Offset = "0x2A43BB0", VA = "0x182A455B0")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x2A444D0", Offset = "0x2A42AD0", VA = "0x182A444D0")]
		private void DHDZTFWTTKV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x2A44720", Offset = "0x2A42D20", VA = "0x182A44720")]
		private void HYHCUBAYZBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x2A46730", Offset = "0x2A44D30", VA = "0x182A46730")]
		private bool WJMLTGVXYFA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x2A451D0", Offset = "0x2A437D0", VA = "0x182A451D0")]
		private int PBPXDSGGSIH(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x2A453F0", Offset = "0x2A439F0", VA = "0x182A453F0")]
		private int PVNPXOUTRUL(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x2A458E0", Offset = "0x2A43EE0", VA = "0x182A458E0")]
		private void SUGAECJKCXJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x2A44F90", Offset = "0x2A43590", VA = "0x182A44F90")]
		private void LSBKFXCZPQX(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x2A44CE0", Offset = "0x2A432E0", VA = "0x182A44CE0")]
		private void KBWLCEFVNQM(int a, int b, int c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x2A456B0", Offset = "0x2A43CB0", VA = "0x182A456B0")]
		private void SBCZEZXPNOY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x2A46AE0", Offset = "0x2A450E0", VA = "0x182A46AE0")]
		private void YQILEWCEIZV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x2A44210", Offset = "0x2A42810", VA = "0x182A44210")]
		private float CASAIZMERZO()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x2A45C10", Offset = "0x2A44210", VA = "0x182A45C10")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x2A444B0", Offset = "0x2A42AB0", VA = "0x182A444B0")]
		public void CBKPAFDKGUH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class IKCLARWRMPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public int RQNIDISRYME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public string UDDUQLLLICT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public double VBRXTPTSFBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public double MHPNYWWZFUC;

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x2A441C0", Offset = "0x2A427C0", VA = "0x182A441C0")]
		public bool XSCBZTMBXKR(double a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public IKCLARWRMPO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class OIHRLEFDNIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x2A4BCB0", Offset = "0x2A4A2B0", VA = "0x182A4BCB0")]
		private static double CYFOTODHICE(string a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x2A4BDF0", Offset = "0x2A4A3F0", VA = "0x182A4BDF0")]
		public static List<IKCLARWRMPO> YTQFLIGDTOX(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public struct LazyShaderProperty
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private string _name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private int _id;

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public int SNTOXKRGJFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0x2A470F0", Offset = "0x2A456F0", VA = "0x182A470F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x2A47120", Offset = "0x2A45720", VA = "0x182A47120")]
		public LazyShaderProperty(string name)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public class DAVICEKJIXR
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		[Flags]
		public enum ResolveFlags
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
		public static readonly LazyShaderProperty VGLWLLWADQM;

		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public static readonly LazyShaderProperty FERMXNYMLUI;

		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public static readonly LazyShaderProperty KTXGRAYPDQR;

		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public static readonly LazyShaderProperty QLEOLOMYFKU;

		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public static readonly LazyShaderProperty JALBIDDHUEU;

		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public static readonly LazyShaderProperty JSPQOXDOGNH;

		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public static readonly LazyShaderProperty SRKRRTBOXVM;

		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public static readonly LazyShaderProperty QAMGPNFCFHZ;

		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public static readonly LazyShaderProperty HUYSLQGZYAV;

		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public static readonly LazyShaderProperty MGALMGTGLHP;

		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public static string EFJFHNCMCZP;

		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public static readonly LazyShaderProperty JTLVSLKULFX;

		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public static readonly LazyShaderProperty RJXJDNVKPCF;

		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public static readonly LazyShaderProperty LVDYDVTYYCD;

		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public static readonly LazyShaderProperty OJSKOEKTGBU;

		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public static readonly LazyShaderProperty IOWGIABWZJH;

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x2A400F0", Offset = "0x2A3E6F0", VA = "0x182A400F0")]
		public static Material QTMGRGMJAXT(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x2A40BF0", Offset = "0x2A3F1F0", VA = "0x182A40BF0")]
		public static void YUGFVAXFAMG(Material a, VideoMapping b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x2A40180", Offset = "0x2A3E780", VA = "0x182A40180")]
		public static void SKEKWJNKHZC(Material a, StereoPacking b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x2A40430", Offset = "0x2A3EA30", VA = "0x182A40430")]
		public static void TIWQNJHICHQ(Material a, AlphaPacking b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x2A40C90", Offset = "0x2A3F290", VA = "0x182A40C90")]
		public static void ZGEFXYZIHFR(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x2A3FBC0", Offset = "0x2A3E1C0", VA = "0x182A3FBC0")]
		public static void FXSWBVIPCZT(Material a, Matrix4x4 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x2A3FB10", Offset = "0x2A3E110", VA = "0x182A3FB10")]
		public static void FDWESRUDHZD(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x2A3FCC0", Offset = "0x2A3E2C0", VA = "0x182A3FCC0")]
		public static Texture GetTexture(MediaPlayer mediaPlayer, int textureIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x2A3F060", Offset = "0x2A3D660", VA = "0x182A3F060")]
		public static void CYBHGCHESVH(Material a, MediaPlayer b, int c = -1, [Optional] Texture d, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x2A3F610", Offset = "0x2A3DC10", VA = "0x182A3F610")]
		internal static void EEIMRISYTCQ(Material a, bool b, bool c, Matrix4x4 d, Texture e, Matrix4x4 f, VideoMapping g = VideoMapping.Normal, StereoPacking h = StereoPacking.None, AlphaPacking i = AlphaPacking.None)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x2A3FE20", Offset = "0x2A3E420", VA = "0x182A3FE20")]
		public static void OBMGYNKSFGK(Material a, VideoResolveOptions b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x2A3EA30", Offset = "0x2A3D030", VA = "0x182A3EA30")]
		public static RenderTexture BHSVWRYGIBH(Material a, RenderTexture b, RPDJCBIELFW c, ResolveFlags d, ScaleMode e = ScaleMode.StretchToFill)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x2A40570", Offset = "0x2A3EB70", VA = "0x182A40570")]
		public static void TUNPBHDOWYS(AlphaPacking a, StereoPacking b, StereoEye c, float d, Matrix4x4 e, int f, int g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x2A406F0", Offset = "0x2A3ECF0", VA = "0x182A406F0")]
		public static void URMYQJWJILX(Rect a, Texture b, ScaleMode c, AlphaPacking d, float e, Material f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public enum VideoRange
	{
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		SDR,
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		HLG,
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		PQ
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public enum CodecType : uint
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
	public class JEHSLRIOOIR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private int ZVQKMQVBFFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private int LZODFEXIRJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private int GFCODGLIIAU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		private int CLLOZOTHFYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		private int USISKPBGFWE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private CodecType UXFBKUMXUIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private float MEHAKWBNIZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private VideoRange PFSSHYFCSYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private CodecType HHDFYOOUJFO;

		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private static JEHSLRIOOIR EHQMEGJKHHD;

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x2A46F50", Offset = "0x2A45550", VA = "0x182A46F50")]
		public JEHSLRIOOIR(int a, int b, int c, int d, int e = 0, CodecType f = CodecType.unknown, float g = 0f, VideoRange h = VideoRange.SDR, CodecType i = CodecType.unknown)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[DefaultMember("Item")]
	public interface IQUJBWYXMLP : IEnumerable
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
