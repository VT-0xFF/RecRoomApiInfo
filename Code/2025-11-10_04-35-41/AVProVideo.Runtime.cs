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
	public Material UIIQDVLKWCX
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x279BEC0", Offset = "0x279B2C0", VA = "0x18279BEC0")]
	private void OnWillRenderObject()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xAA4900", Offset = "0xAA3D00", VA = "0x180AA4900")]
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
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public MediaPath MediaPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public MediaHints Hints
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xBA1A60", Offset = "0xBA0E60", VA = "0x180BA1A60")]
			get
			{
				return default(MediaHints);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xBA1BB0", Offset = "0xBA0FB0", VA = "0x180BA1BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x27A92E0", Offset = "0x27A86E0", VA = "0x1827A92E0")]
		public MediaReference GetCurrentPlatformMediaReference()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x27A9350", Offset = "0x27A8750", VA = "0x1827A9350")]
		public MediaReference GetPlatformMediaReference(Platform platform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x27A93E0", Offset = "0x27A87E0", VA = "0x1827A93E0")]
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
		private GameObject NGMRTDQAUIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool PBHKOVGZZGH;

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
		private Texture CATIVXHDZRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private LazyShaderProperty QTWLTTWQMVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private LazyShaderProperty NEHQJUESRXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private Texture HLUBQTIZRPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Vector2 KARGVCIPAEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Vector2 DZCWYRNQBQH;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Color JTVFMAYSOBE
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x134DB80", Offset = "0x134CF80", VA = "0x18134DB80")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x279D810", Offset = "0x279CC10", VA = "0x18279D810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Texture WAUEOSCTHAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x279DA60", Offset = "0x279CE60", VA = "0x18279DA60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Texture HSSHRGZLFXO
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xAA3370", Offset = "0xAA2770", VA = "0x180AA3370")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x279D500", Offset = "0x279C900", VA = "0x18279D500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float SQLCKHKAKYO
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xFB3C80", Offset = "0xFB3080", VA = "0x180FB3C80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x279D380", Offset = "0x279C780", VA = "0x18279D380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Camera SNAOOIOJQKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xAA3380", Offset = "0xAA2780", VA = "0x180AA3380")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x279D430", Offset = "0x279C830", VA = "0x18279D430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public VideoAspectRatio UHAKCQCNKRW
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xB0E8C0", Offset = "0xB0DCC0", VA = "0x180B0E8C0")]
			get
			{
				return default(VideoAspectRatio);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x279DB20", Offset = "0x279CF20", VA = "0x18279DB20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Vector2 BVAFOPRDWZR
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xFB3C90", Offset = "0xFB3090", VA = "0x180FB3C90")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x279D730", Offset = "0x279CB30", VA = "0x18279D730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Vector2 UMVQFVLAVQO
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xFAA840", Offset = "0xFA9C40", VA = "0x180FAA840")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x279D5C0", Offset = "0x279C9C0", VA = "0x18279D5C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Texture2D VHKPVCBVPHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xAD3CC0", Offset = "0xAD30C0", VA = "0x180AD3CC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x279D6A0", Offset = "0x279CAA0", VA = "0x18279D6A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public string QJTUEGFPQEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xB9E4B0", Offset = "0xB9D8B0", VA = "0x180B9E4B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x279D970", Offset = "0x279CD70", VA = "0x18279D970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Vector2 TSALMPZNIUJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x279D340", Offset = "0x279C740", VA = "0x18279D340")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x279D8D0", Offset = "0x279CCD0", VA = "0x18279D8D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Vector2 UATJXLHWCDG
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x279D360", Offset = "0x279C760", VA = "0x18279D360")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x279D920", Offset = "0x279CD20", VA = "0x18279D920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private Vector2 PXKOYRLCUVA
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x279CC80", Offset = "0x279C080", VA = "0x18279CC80")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x279B910", Offset = "0x279AD10", VA = "0x18279B910")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x279C890", Offset = "0x279BC90", VA = "0x18279C890", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x279C840", Offset = "0x279BC40", VA = "0x18279C840")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x279D010", Offset = "0x279C410", VA = "0x18279D010")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x279C0D0", Offset = "0x279B4D0", VA = "0x18279C0D0")]
		public Mesh CreateQuadMesh()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x279BF70", Offset = "0x279B370", VA = "0x18279BF70")]
		public void CreateMaterial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x279C970", Offset = "0x279BD70", VA = "0x18279C970", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xB00080", Offset = "0xAFF480", VA = "0x180B00080")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x279CD50", Offset = "0x279C150", VA = "0x18279CD50")]
		public void UpdateMaterialProperties(int target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x279B3D0", Offset = "0x279A7D0", VA = "0x18279B3D0", Slot = "8")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x279BA00", Offset = "0x279AE00", VA = "0x18279BA00")]
		private void CRMJHAQQRNC(Texture a, bool b, int c = 0, Eye d = Eye.Left)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x279C460", Offset = "0x279B860", VA = "0x18279C460", Slot = "6")]
		protected override void EYFQMPHWZMW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x279C6A0", Offset = "0x279BAA0", VA = "0x18279C6A0", Slot = "7")]
		protected override void HLOLSAEVBKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x279D1D0", Offset = "0x279C5D0", VA = "0x18279D1D0")]
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
		private Texture CATIVXHDZRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private LazyShaderProperty QTWLTTWQMVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private LazyShaderProperty NEHQJUESRXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private Texture HLUBQTIZRPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private Vector2 KARGVCIPAEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private Vector2 DZCWYRNQBQH;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Texture2D VHKPVCBVPHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x279E9F0", Offset = "0x279DDF0", VA = "0x18279E9F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Material UIIQDVLKWCX
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x279EA70", Offset = "0x279DE70", VA = "0x18279EA70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string QJTUEGFPQEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x279EB90", Offset = "0x279DF90", VA = "0x18279EB90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector2 TSALMPZNIUJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x279E9B0", Offset = "0x279DDB0", VA = "0x18279E9B0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x279EAF0", Offset = "0x279DEF0", VA = "0x18279EAF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Vector2 UATJXLHWCDG
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x279E9D0", Offset = "0x279DDD0", VA = "0x18279E9D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x279EB40", Offset = "0x279DF40", VA = "0x18279EB40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xB00080", Offset = "0xAFF480", VA = "0x180B00080")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x279DBD0", Offset = "0x279CFD0", VA = "0x18279DBD0", Slot = "8")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x279E0F0", Offset = "0x279D4F0", VA = "0x18279E0F0")]
		private void CRMJHAQQRNC(Texture a, bool b, int c = 0, Eye d = Eye.Left)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x279E4F0", Offset = "0x279D8F0", VA = "0x18279E4F0", Slot = "6")]
		protected override void EYFQMPHWZMW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x279E6F0", Offset = "0x279DAF0", VA = "0x18279E6F0", Slot = "7")]
		protected override void HLOLSAEVBKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x279E860", Offset = "0x279DC60", VA = "0x18279E860")]
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
		private Texture CATIVXHDZRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private LazyShaderProperty QTWLTTWQMVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private LazyShaderProperty NEHQJUESRXO;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Texture2D VHKPVCBVPHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x279F660", Offset = "0x279EA60", VA = "0x18279F660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Renderer EFPOQKLEMNW
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x279F7B0", Offset = "0x279EBB0", VA = "0x18279F7B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public int UXHMSUWUEAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xCDFFD0", Offset = "0xCDF3D0", VA = "0x180CDFFD0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xCE1070", Offset = "0xCE0470", VA = "0x180CE1070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public string QJTUEGFPQEH
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xAA3370", Offset = "0xAA2770", VA = "0x180AA3370")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x279FB40", Offset = "0x279EF40", VA = "0x18279FB40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector2 TSALMPZNIUJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x279E9D0", Offset = "0x279DDD0", VA = "0x18279E9D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x279EB40", Offset = "0x279DF40", VA = "0x18279EB40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector2 UATJXLHWCDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x279FAD0", Offset = "0x279EED0", VA = "0x18279FAD0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x279FAF0", Offset = "0x279EEF0", VA = "0x18279FAF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x279F660", Offset = "0x279EA60", VA = "0x18279F660")]
		private void DEHQASVZFNY(Texture2D a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x279F7B0", Offset = "0x279EBB0", VA = "0x18279F7B0")]
		private void FOUMGFZAAJP(Renderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xB00080", Offset = "0xAFF480", VA = "0x180B00080")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x279EC60", Offset = "0x279E060", VA = "0x18279EC60", Slot = "8")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x279F1E0", Offset = "0x279E5E0", VA = "0x18279F1E0")]
		private void CRMJHAQQRNC(Texture a, bool b, int c, Eye d = Eye.Left, int e = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x279F8C0", Offset = "0x279ECC0", VA = "0x18279F8C0", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x279F890", Offset = "0x279EC90", VA = "0x18279F890", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x279F710", Offset = "0x279EB10", VA = "0x18279F710", Slot = "6")]
		protected override void EYFQMPHWZMW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x279FA00", Offset = "0x279EE00", VA = "0x18279FA00")]
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
		private const int MEIVQPXRMZW = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[Range(0f, 1f)]
		[SerializeField]
		private float[] _channels;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float[] XSTKCDDKCGF
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x279FED0", Offset = "0x279F2D0", VA = "0x18279FED0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x279FC20", Offset = "0x279F020", VA = "0x18279FC20")]
		private void LTOKBBSZSCY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x279FD20", Offset = "0x279F120", VA = "0x18279FD20")]
		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xAA4900", Offset = "0xAA3D00", VA = "0x180AA4900")]
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
		private int JLUBOGPFVSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private AudioSource ESHGZKPAGZI;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public MediaPlayer OBAVPYYGRFR
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x27A0A20", Offset = "0x279FE20", VA = "0x1827A0A20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public AudioOutputMode FYUEJVTFJSA
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1A0", Offset = "0xAAA5A0", VA = "0x180AAB1A0")]
			get
			{
				return default(AudioOutputMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1B0", Offset = "0xAAA5B0", VA = "0x180AAB1B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int JCMMPQDBGZL
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xC4E8F0", Offset = "0xC4DCF0", VA = "0x180C4E8F0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x1ACB200", Offset = "0x1ACA600", VA = "0x181ACB200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x279FF60", Offset = "0x279F360", VA = "0x18279FF60")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x27A06E0", Offset = "0x279FAE0", VA = "0x1827A06E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x27A04D0", Offset = "0x279F8D0", VA = "0x1827A04D0")]
		private void FVAKDHNMYLT(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x27A0630", Offset = "0x279FA30", VA = "0x1827A0630")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x27A0920", Offset = "0x279FD20", VA = "0x1827A0920")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
		public AudioSource GetAudioSource()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x27A0640", Offset = "0x279FA40", VA = "0x1827A0640")]
		public void SetAudioSource(AudioSource source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x279FFB0", Offset = "0x279F3B0", VA = "0x18279FFB0")]
		public void ChangeMediaPlayer(MediaPlayer newPlayer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x27A0470", Offset = "0x279F870", VA = "0x1827A0470")]
		private void EKJZPGNFSEE(MediaPlayer a, MediaPlayerEvent.EventType b, ErrorCode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x27A0760", Offset = "0x279FB60", VA = "0x1827A0760")]
		private static void TGTCGTDVFYR(MediaPlayer a, AudioSource b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x27A05B0", Offset = "0x279F9B0", VA = "0x1827A05B0")]
		private void OnAudioFilterRead(float[] audioData, int channelCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x27A0A00", Offset = "0x279FE00", VA = "0x1827A0A00")]
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
		private static Shader KLCIAOHSXSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private Material VKHSCBVZZTA;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public MediaPlayer OBAVPYYGRFR
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x27A1800", Offset = "0x27A0C00", VA = "0x1827A1800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public ScaleMode ZFXOTKRLVZZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1A0", Offset = "0xAAA5A0", VA = "0x180AAB1A0")]
			get
			{
				return default(ScaleMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1B0", Offset = "0xAAA5B0", VA = "0x180AAB1B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Color BBHCWBJOSMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x27A17D0", Offset = "0x27A0BD0", VA = "0x1827A17D0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x27A17F0", Offset = "0x27A0BF0", VA = "0x1827A17F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool ISORKZKZOTP
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xBEE6C0", Offset = "0xBEDAC0", VA = "0x180BEE6C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xCDA280", Offset = "0xCD9680", VA = "0x180CDA280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool ELVHPQYYISK
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xCDA260", Offset = "0xCD9660", VA = "0x180CDA260")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xCDAEF0", Offset = "0xCDA2F0", VA = "0x180CDAEF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public int KATEVKEBUTR
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xAC1F70", Offset = "0xAC1370", VA = "0x180AC1F70")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xBDCB60", Offset = "0xBDBF60", VA = "0x180BDCB60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool HAUVENTXHSW
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x16C50A0", Offset = "0x16C44A0", VA = "0x1816C50A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x16C5090", Offset = "0x16C4490", VA = "0x1816C5090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float BSBADUSLEDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xF045C0", Offset = "0xF039C0", VA = "0x180F045C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x27A17E0", Offset = "0x27A0BE0", VA = "0x1827A17E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public float BRVTGNYNURU
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xC10CF0", Offset = "0xC100F0", VA = "0x180C10CF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xC10D00", Offset = "0xC10100", VA = "0x180C10D00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float LHSITVSVXHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xAF4150", Offset = "0xAF3550", VA = "0x180AF4150")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xD71010", Offset = "0xD70410", VA = "0x180D71010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float SRAUJEGQSXW
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xD8F1A0", Offset = "0xD8E5A0", VA = "0x180D8F1A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xD8F1B0", Offset = "0xD8E5B0", VA = "0x180D8F1B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool XLFGERNNFJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xB15270", Offset = "0xB14670", VA = "0x180B15270")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xBAA9D0", Offset = "0xBA9DD0", VA = "0x180BAA9D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x27A1480", Offset = "0x27A0880", VA = "0x1827A1480")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x27A15B0", Offset = "0x27A09B0", VA = "0x1827A15B0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x27A0D40", Offset = "0x27A0140", VA = "0x1827A0D40")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x27A0D00", Offset = "0x27A0100", VA = "0x1827A0D00")]
		private Shader JPPIBMOPKTQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x27A0A30", Offset = "0x279FE30", VA = "0x1827A0A30")]
		private void GIDBFVTJINY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x27A0DE0", Offset = "0x27A01E0", VA = "0x1827A0DE0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x27A0BD0", Offset = "0x279FFD0", VA = "0x1827A0BD0")]
		public Rect GetAreaRect()
		{
			return default(Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x27A17A0", Offset = "0x27A0BA0", VA = "0x1827A17A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x27AB4B0", Offset = "0x27AA8B0", VA = "0x1827AB4B0", Slot = "4")]
			public virtual string XPIONRMZLWZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xC76E10", Offset = "0xC76210", VA = "0x180C76E10", Slot = "5")]
			public virtual byte[] VYDOJKUHKKO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "6")]
			public virtual bool HZHTPCHUKPF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x27AB4D0", Offset = "0x27AA8D0", VA = "0x1827AB4D0")]
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
			public EHWWKWWLVKT.VideoApi videoApi;

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
			public EHWWKWWLVKT.AudioOutput _audioMode;

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
			[Cpp2IlInjected.Address(RVA = "0xB42090", Offset = "0xB41490", VA = "0x180B42090", Slot = "6")]
			public override bool HZHTPCHUKPF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "7")]
			private void VDBBOYWZWQM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x27AB130", Offset = "0x27AA530", VA = "0x1827AB130", Slot = "8")]
			private void CKCFOYYUTFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x27AB160", Offset = "0x27AA560", VA = "0x1827AB160")]
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
			public ICATGGHVRJH.VideoApi videoApi;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public ICATGGHVRJH.AudioOutput _audioMode;

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
			[Cpp2IlInjected.Address(RVA = "0xC0DEA0", Offset = "0xC0D2A0", VA = "0x180C0DEA0", Slot = "6")]
			public override bool HZHTPCHUKPF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x27AB110", Offset = "0x27AA510", VA = "0x1827AB110")]
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
			private readonly TextureFormat QXQOUMHGOXD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			private readonly Flags NTTFFSJAEKW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public TextureFormat textureFormat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private AudioMode OYZBUWDVLDR;

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
			private ChangeFlags PFAGLQJGIKF;

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
				[Cpp2IlInjected.Address(RVA = "0x27AB060", Offset = "0x27AA460", VA = "0x1827AB060")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000065")]
			public Flags flags
			{
				[Cpp2IlInjected.Token(Token = "0x6000145")]
				[Cpp2IlInjected.Address(RVA = "0x27AB080", Offset = "0x27AA480", VA = "0x1827AB080")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x27AAFB0", Offset = "0x27AA3B0", VA = "0x1827AAFB0")]
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
			private ChangeFlags PFAGLQJGIKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private readonly TextureFormat QXQOUMHGOXD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public TextureFormat textureFormat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			[SerializeField]
			private bool _generateMipmaps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			private AudioMode OYZBUWDVLDR;

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
				[Cpp2IlInjected.Address(RVA = "0xAF32A0", Offset = "0xAF26A0", VA = "0x180AF32A0")]
				get
				{
					return default(AudioMode);
				}
				[Cpp2IlInjected.Token(Token = "0x6000148")]
				[Cpp2IlInjected.Address(RVA = "0x27AAF90", Offset = "0x27AA390", VA = "0x1827AAF90")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xAA9F40", Offset = "0xAA9340", VA = "0x180AA9F40", Slot = "6")]
			public override bool HZHTPCHUKPF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "7")]
			private void VDBBOYWZWQM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x27AAEF0", Offset = "0x27AA2F0", VA = "0x1827AAEF0", Slot = "8")]
			private void CKCFOYYUTFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x27AAF20", Offset = "0x27AA320", VA = "0x1827AAF20")]
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
			private ChangeFlags PFAGLQJGIKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			private readonly TextureFormat QXQOUMHGOXD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public TextureFormat textureFormat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			[SerializeField]
			private bool _generateMipmapsOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private AudioMode OYZBUWDVLDR;

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
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "7")]
			private void VDBBOYWZWQM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "8")]
			private void CKCFOYYUTFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x27AB0B0", Offset = "0x27AA4B0", VA = "0x1827AB0B0")]
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
			private ChangeFlags PFAGLQJGIKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public MUMGWBBTGLV.ExternalLibrary externalLibrary;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public bool useTextureMips;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			private AudioMode OYZBUWDVLDR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			[SerializeField]
			private AudioMode _audioMode;

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "4")]
			public override string XPIONRMZLWZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "5")]
			public override byte[] VYDOJKUHKKO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x27AB100", Offset = "0x27AA500", VA = "0x1827AB100")]
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
		private sealed class NIZXWQTNOYC : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			private int JIPOOQUWCIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			private object JOTWNIKQVJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public Texture2D DMWBTJWODWX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public MediaPlayer MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public double YOXWDPNFCBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public int FEJGEKGAYQK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public bool SVTKKKGWSPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public ProcessExtractedFrame QCMVESDEXDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			private Texture2D LDMGXVGSBES;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			private int BJCJGZUQRIX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			private int HJTCHEPHFML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			private int CZAQIMHUURM;

			[Cpp2IlInjected.Token(Token = "0x17000067")]
			private object PNRLUNGDWHZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000156")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			private object MSIUOYXLJXG
			{
				[Cpp2IlInjected.Token(Token = "0x6000158")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0xAB07E0", Offset = "0xAAFBE0", VA = "0x180AB07E0")]
			[DebuggerHidden]
			public NIZXWQTNOYC(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "5")]
			[DebuggerHidden]
			private void AEBWHPMOWJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x27A94E0", Offset = "0x27A88E0", VA = "0x1827A94E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x27A94A0", Offset = "0x27A88A0", VA = "0x1827A94A0", Slot = "8")]
			[DebuggerHidden]
			private void MJTKPUASZVA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class VEYXDELCDZI : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			private int JIPOOQUWCIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			private object JOTWNIKQVJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public MediaPlayer MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private YieldInstruction IVNWOXWVEFY;

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			private object PNRLUNGDWHZ
			{
				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			private object MSIUOYXLJXG
			{
				[Cpp2IlInjected.Token(Token = "0x600015E")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xAB07E0", Offset = "0xAAFBE0", VA = "0x180AB07E0")]
			[DebuggerHidden]
			public VEYXDELCDZI(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "5")]
			[DebuggerHidden]
			private void AEBWHPMOWJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x27B0100", Offset = "0x27AF500", VA = "0x1827B0100", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x27B00C0", Offset = "0x27AF4C0", VA = "0x1827B00C0", Slot = "8")]
			[DebuggerHidden]
			private void MJTKPUASZVA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class PJFIMAIZWNI : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private int JIPOOQUWCIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private object JOTWNIKQVJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public string QNKVRXSBCIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			public MediaPlayer MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public MediaPath CWWWUPSNSLH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private UnityWebRequest NSNGKHSPYOQ;

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			private object PNRLUNGDWHZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000162")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			private object MSIUOYXLJXG
			{
				[Cpp2IlInjected.Token(Token = "0x6000164")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0xAB07E0", Offset = "0xAAFBE0", VA = "0x180AB07E0")]
			[DebuggerHidden]
			public PJFIMAIZWNI(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "5")]
			[DebuggerHidden]
			private void AEBWHPMOWJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x27AB250", Offset = "0x27AA650", VA = "0x1827AB250", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x27AB210", Offset = "0x27AA610", VA = "0x1827AB210", Slot = "8")]
			[DebuggerHidden]
			private void MJTKPUASZVA()
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
		private AudioSource ESHGZKPAGZI;

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
		private VKOANINGYYR.ResampleMode _resampleMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[FormerlySerializedAs("m_ResampleBufferSize")]
		[Range(3f, 10f)]
		[SerializeField]
		private int _resampleBufferSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private VKOANINGYYR GRMIKLNIDIS;

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
		protected ONEYUFGXDVK VXQJSJGGUKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private FWRODULGZYA XSQJDGOXAEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private AFEJTIYLLFY HFDDWLDZZNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private SPYDNGPLZJR KETLSSTXRPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private MSICTZPRRNU VDBFJOBOBJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private YAUINNSWCCY LMNRIPXJTRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private VFGDPVDCJXN SCQQEIFXGIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private HRVALWDMQRW THJOSIPTXEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private OEDGZIWDWIJ OGDXIZSAVFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private XRIYOSNZLQG NVIDXRCDIAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private GYOCHCOALGX UOGOKYCUSNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private IDisposable OMPUXQZVFHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private bool VEZRKJTJUYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x141")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private bool OEPSIVDOZFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x142")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private bool OZXWMEKTMNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private Coroutine UZZDGCWJHQV;

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private static bool KAIMPSKIOUA;

		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private static bool CVNKFAKMYSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private MediaPath FCZDBQVJFRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private Coroutine FRJDZRQDVQI;

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static Camera PICHVFAUXHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private bool EDKUGTFQAUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x161")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private bool RFQHNRQLQNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x162")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private bool TWJCWRHDXGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x163")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private bool IWHJJUUFEYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private bool UNMZZRKXVJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x165")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private bool RATOKUZZAAU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x166")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private bool EDTQMKQVSEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x167")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private bool VXFJJOFKAIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private int BSXNKXHTIXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private int QFPSTFUVZHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private int XIXULJPEBGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private bool BGBDCEAKQOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x175")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private bool AVTDETERTRL;

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
		public MediaSource RSCBXXFKPNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAB5660", Offset = "0xAB4A60", VA = "0x180AB5660")]
			get
			{
				return default(MediaSource);
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xB07AB0", Offset = "0xB06EB0", VA = "0x180B07AB0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public MediaReference OMBWVIHEEFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MediaPath QQFJBPOQDXT
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public MediaHints CNZLAAVJAFM
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x182DB40", Offset = "0x182CF40", VA = "0x18182DB40")]
			get
			{
				return default(MediaHints);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x1745160", Offset = "0x1744560", VA = "0x181745160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool IASWRONJEAF
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x16C50A0", Offset = "0x16C44A0", VA = "0x1816C50A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x16C5090", Offset = "0x16C4490", VA = "0x1816C5090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool INTOWAPWXFV
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x239DC70", Offset = "0x239D070", VA = "0x18239DC70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x239DDF0", Offset = "0x239D1F0", VA = "0x18239DDF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool ZERRIDQYKSI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x27A8A50", Offset = "0x27A7E50", VA = "0x1827A8A50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x27A8F80", Offset = "0x27A8380", VA = "0x1827A8F80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public virtual float EZPSYAYSRHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x27A8900", Offset = "0x27A7D00", VA = "0x1827A8900", Slot = "6")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x27A8F00", Offset = "0x27A8300", VA = "0x1827A8F00", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float JYWWQSSPDOM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x27A8840", Offset = "0x27A7C40", VA = "0x1827A8840")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x27A8E10", Offset = "0x27A8210", VA = "0x1827A8E10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public virtual bool YMSWEEQVVGH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x27A88A0", Offset = "0x27A7CA0", VA = "0x1827A88A0", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x27A8E90", Offset = "0x27A8290", VA = "0x1827A8E90", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public AudioSource AMCTEZVSTBX
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xAA33A0", Offset = "0xAA27A0", VA = "0x180AA33A0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float DBFZLNXJKQR
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x27A8AE0", Offset = "0x27A7EE0", VA = "0x1827A8AE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x27A9020", Offset = "0x27A8420", VA = "0x1827A9020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool PQFOLXCGFHC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xAA9F40", Offset = "0xAA9340", VA = "0x180AA9F40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xAAA150", Offset = "0xAA9550", VA = "0x180AAA150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public VKOANINGYYR.ResampleMode PXZIGDPXCOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xB0E8C0", Offset = "0xB0DCC0", VA = "0x180B0E8C0")]
			get
			{
				return default(VKOANINGYYR.ResampleMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xBF0970", Offset = "0xBEFD70", VA = "0x180BF0970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public int ZIMKVNEMKRU
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xBB85D0", Offset = "0xBB79D0", VA = "0x180BB85D0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x27A9090", Offset = "0x27A8490", VA = "0x1827A9090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public VKOANINGYYR RLJSDTVOHOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xAA5380", Offset = "0xAA4780", VA = "0x180AA5380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public VideoMapping INLHQBBBWUT
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xACB690", Offset = "0xACAA90", VA = "0x180ACB690")]
			get
			{
				return default(VideoMapping);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x12E4BE0", Offset = "0x12E3FE0", VA = "0x1812E4BE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public FilterMode QKKVTNOZXYI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x27A8C30", Offset = "0x27A8030", VA = "0x1827A8C30")]
			get
			{
				return default(FilterMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x27A9110", Offset = "0x27A8510", VA = "0x1827A9110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public TextureWrapMode OGXCAQTNWIG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x27A8D20", Offset = "0x27A8120", VA = "0x1827A8D20")]
			get
			{
				return default(TextureWrapMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x27A9190", Offset = "0x27A8590", VA = "0x1827A9190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public int UZOQNHBKRPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x27A8B40", Offset = "0x27A7F40", VA = "0x1827A8B40")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x27A90A0", Offset = "0x27A84A0", VA = "0x1827A90A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool WNRIZGHNRLQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xCAAC20", Offset = "0xCAA020", VA = "0x180CAAC20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xCA7990", Offset = "0xCA6D90", VA = "0x180CA7990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public MediaPath TXWZGBXJEMZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xAD3CC0", Offset = "0xAD30C0", VA = "0x180AD3CC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xCA6670", Offset = "0xCA5A70", VA = "0x180CA6670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public Transform WJZIBUYZTTA
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xAAC9C0", Offset = "0xAABDC0", VA = "0x180AAC9C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xAAC960", Offset = "0xAABD60", VA = "0x180AAC960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool NIGZMTMBOMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xDF7240", Offset = "0xDF6640", VA = "0x180DF7240")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xDF5CB0", Offset = "0xDF50B0", VA = "0x180DF5CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public Transform UBQLEFYHTIY
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A40", Offset = "0xAA5E40", VA = "0x180AA6A40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A70", Offset = "0xAA5E70", VA = "0x180AA6A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public float XHEDXHVFYPX
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xDC2DA0", Offset = "0xDC21A0", VA = "0x180DC2DA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xDC2E20", Offset = "0xDC2220", VA = "0x180DC2E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public float AXSCRVLWFIX
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xDC2CE0", Offset = "0xDC20E0", VA = "0x180DC2CE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xDC2DF0", Offset = "0xDC21F0", VA = "0x180DC2DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public HttpHeaderData OEYDSMXFUVC
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0xBDEAA0", Offset = "0xBDDEA0", VA = "0x180BDEAA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x1208F70", Offset = "0x1208370", VA = "0x181208F70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public KeyAuthData JBSTMHINCUX
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xBC4FA0", Offset = "0xBC43A0", VA = "0x180BC4FA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xBC4FB0", Offset = "0xBC43B0", VA = "0x180BC4FB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public MediaPlayerEvent DKHHOJRBOMT
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x27A8960", Offset = "0x27A7D60", VA = "0x1827A8960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public int TCTKRIOIHVU
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0xDC15E0", Offset = "0xDC09E0", VA = "0x180DC15E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0xDC2E10", Offset = "0xDC2210", VA = "0x180DC2E10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public bool PJSEDDCCJAC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x27A8AB0", Offset = "0x27A7EB0", VA = "0x1827A8AB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x27A8FF0", Offset = "0x27A83F0", VA = "0x1827A8FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool OLORKEYGIKD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x27A8AD0", Offset = "0x27A7ED0", VA = "0x1827A8AD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x27A9010", Offset = "0x27A8410", VA = "0x1827A9010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool XLFBFHMGHHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x27A8AC0", Offset = "0x27A7EC0", VA = "0x1827A8AC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x27A9000", Offset = "0x27A8400", VA = "0x1827A9000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public FileFormat XKYIPPOIXJG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0xB52040", Offset = "0xB51440", VA = "0x180B52040")]
			get
			{
				return default(FileFormat);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x1696980", Offset = "0x1695D80", VA = "0x181696980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public virtual SPYDNGPLZJR VTBWYFQFLPE
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xB688D0", Offset = "0xB67CD0", VA = "0x180B688D0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public virtual FWRODULGZYA HJVLPBUUKSX
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xC666C0", Offset = "0xC65AC0", VA = "0x180C666C0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public virtual MSICTZPRRNU OBAVPYYGRFR
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xBF1FE0", Offset = "0xBF13E0", VA = "0x180BF1FE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public virtual AFEJTIYLLFY KQFQVZSQYDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xC666D0", Offset = "0xC65AD0", VA = "0x180C666D0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual YAUINNSWCCY IJEPLYBYABR
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xC66690", Offset = "0xC65A90", VA = "0x180C66690", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public virtual HRVALWDMQRW YZRLMDRUQVT
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xC66650", Offset = "0xC65A50", VA = "0x180C66650", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual OEDGZIWDWIJ ZHXZVHGWAAE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xBBD580", Offset = "0xBBC980", VA = "0x180BBD580", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual XRIYOSNZLQG CTZRPWGCVLD
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xBBDEF0", Offset = "0xBBD2F0", VA = "0x180BBDEF0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual GYOCHCOALGX WGELKZQKDIY
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xC66660", Offset = "0xC65A60", VA = "0x180C66660", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public virtual VFGDPVDCJXN MIPWDLSVCSY
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xB80490", Offset = "0xB7F890", VA = "0x180B80490", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool PVZUEQZZJHN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x13680A0", Offset = "0x13674A0", VA = "0x1813680A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public OptionsWindows NDQHLWNAWRA
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0xBBDEC0", Offset = "0xBBD2C0", VA = "0x180BBDEC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public OptionsApple TOHQARIEFCL
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xC66520", Offset = "0xC65920", VA = "0x180C66520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public OptionsApple IOMKHVNYTZZ
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0xC66510", Offset = "0xC65910", VA = "0x180C66510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public OptionsApple XLCJBLXADXY
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0xC66560", Offset = "0xC65960", VA = "0x180C66560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public OptionsApple RHTBLJJKGPS
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0xC66530", Offset = "0xC65930", VA = "0x180C66530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public OptionsAndroid QKBANHWAJTS
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0xB29DD0", Offset = "0xB291D0", VA = "0x180B29DD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public OptionsOpenHarmony UPPNFREPUTX
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0xC667D0", Offset = "0xC65BD0", VA = "0x180C667D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public OptionsWindowsUWP HKWQCOLSHIW
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0xC66810", Offset = "0xC65C10", VA = "0x180C66810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public OptionsWebGL PYOQXYYDMTM
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xC66800", Offset = "0xC65C00", VA = "0x180C66800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xB07AB0", Offset = "0xB06EB0", VA = "0x180B07AB0")]
		public void SetMediaSource(MediaSource source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
		public void SetMediaReference(MediaReference media)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
		public void SetMediaPath(MediaPath path)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xAA33A0", Offset = "0xAA27A0", VA = "0x180AA33A0")]
		public void SetAudioSource(AudioSource audioSource)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x27A2950", Offset = "0x27A1D50", VA = "0x1827A2950")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x27A33E0", Offset = "0x27A27E0", VA = "0x1827A33E0")]
		protected void EELASTUQHFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x27A7460", Offset = "0x27A6860", VA = "0x1827A7460")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x27A6170", Offset = "0x27A5570", VA = "0x1827A6170")]
		public bool OpenMedia(MediaPath path, bool autoPlay = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x27A6070", Offset = "0x27A5470", VA = "0x1827A6070")]
		public bool OpenMedia(MediaPathType pathType, string path, bool autoPlay = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x27A6120", Offset = "0x27A5520", VA = "0x1827A6120")]
		public bool OpenMedia(MediaReference mediaReference, bool autoPlay = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x27A60F0", Offset = "0x27A54F0", VA = "0x1827A60F0")]
		public bool OpenMedia(bool autoPlay = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x27A5270", Offset = "0x27A4670", VA = "0x1827A5270")]
		private bool MCJCFRASYWV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x27A8110", Offset = "0x27A7510", VA = "0x1827A8110")]
		private void YVYFSVSHBAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x27A30A0", Offset = "0x27A24A0", VA = "0x1827A30A0")]
		private void DBSUFHJMKSL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x27A2B90", Offset = "0x27A1F90", VA = "0x1827A2B90")]
		public void CloseMedia()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x27A6650", Offset = "0x27A5A50", VA = "0x1827A6650", Slot = "20")]
		public virtual void Play()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x27A65D0", Offset = "0x27A59D0", VA = "0x1827A65D0", Slot = "21")]
		public virtual void Pause()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x27A7570", Offset = "0x27A6970", VA = "0x1827A7570")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x27A66E0", Offset = "0x27A5AE0", VA = "0x1827A66E0")]
		public void Rewind(bool pause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x27A72A0", Offset = "0x27A66A0", VA = "0x1827A72A0")]
		public void SeekToLiveTime(double offset = 0.0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x27A7AB0", Offset = "0x27A6EB0", VA = "0x1827A7AB0", Slot = "22")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x27A5130", Offset = "0x27A4530", VA = "0x1827A5130")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x27A63F0", Offset = "0x27A57F0", VA = "0x1827A63F0")]
		private void PMCCRONLDHQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x27A5F30", Offset = "0x27A5330", VA = "0x1827A5F30")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x27A5E70", Offset = "0x27A5270", VA = "0x1827A5E70")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x27A5CF0", Offset = "0x27A50F0", VA = "0x1827A5CF0", Slot = "23")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x27A4340", Offset = "0x27A3740", VA = "0x1827A4340")]
		public void ForceDispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x27A41E0", Offset = "0x27A35E0", VA = "0x1827A41E0")]
		private static void FZPSHLIPMMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x27A5AC0", Offset = "0x27A4EC0", VA = "0x1827A5AC0")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x27A4410", Offset = "0x27A3810", VA = "0x1827A4410")]
		protected void HYSSIQGDPWU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x27A80C0", Offset = "0x27A74C0", VA = "0x1827A80C0")]
		private void XMABIVAWREQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x27A8050", Offset = "0x27A7450", VA = "0x1827A8050")]
		[IteratorStateMachine(typeof(VEYXDELCDZI))]
		private IEnumerator XBPJRXNWSVC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920")]
		public static Platform GetPlatform()
		{
			return default(Platform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xBBDEC0", Offset = "0xBBD2C0", VA = "0x180BBDEC0")]
		public PlatformOptions GetCurrentPlatformOptions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x27A7FB0", Offset = "0x27A73B0", VA = "0x1827A7FB0")]
		private string WUSEXBIFQLD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920")]
		private long ZJLICNSPGGA()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x27A7F00", Offset = "0x27A7300", VA = "0x1827A7F00")]
		private string WNMIEWXXFCA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x27A5A60", Offset = "0x27A4E60", VA = "0x1827A5A60")]
		private string OLESSLWVDST(string a, MediaPathType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x27A31D0", Offset = "0x27A25D0", VA = "0x1827A31D0")]
		private static ONEYUFGXDVK DZUDDXQMJMH(OptionsWindows a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x27A4EA0", Offset = "0x27A42A0", VA = "0x1827A4EA0")]
		private static ONEYUFGXDVK KWXPPCKLJNI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x27A2D00", Offset = "0x27A2100", VA = "0x1827A2D00", Slot = "24")]
		public virtual ONEYUFGXDVK CreateMediaPlayer()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x27A4EF0", Offset = "0x27A42F0", VA = "0x1827A4EF0")]
		private void LAYIXSCRACZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x27A5910", Offset = "0x27A4D10", VA = "0x1827A5910")]
		private void NYBASGVDVLV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x27A4070", Offset = "0x27A3470", VA = "0x1827A4070")]
		private void FOEIKYXGFZO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770")]
		public bool IsUsingAndroidOESPath()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770")]
		public bool IsUsingYCbCr()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x27A6FB0", Offset = "0x27A63B0", VA = "0x1827A6FB0")]
		[ContextMenu("Save Frame To PNG")]
		public void SaveFrameToPng()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x27A6BB0", Offset = "0x27A5FB0", VA = "0x1827A6BB0")]
		[ContextMenu("Save Frame To EXR")]
		public void SaveFrameToExr()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		private void OnApplicationFocus(bool focusStatus)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x27A8020", Offset = "0x27A7420", VA = "0x1827A8020")]
		private void WWVIJEVWKBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x27A29C0", Offset = "0x27A1DC0", VA = "0x1827A29C0")]
		private void BZQTHYCWCGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x27A44D0", Offset = "0x27A38D0", VA = "0x1827A44D0")]
		private void IQOYOWSSNSN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x27A6760", Offset = "0x27A5B60", VA = "0x1827A6760")]
		private void SJNNOYBNCJY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x27A78F0", Offset = "0x27A6CF0", VA = "0x1827A78F0")]
		private void TTRWDACKCRQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x27A64F0", Offset = "0x27A58F0", VA = "0x1827A64F0")]
		protected bool PWOOKMJYDQI(MediaPlayerEvent.EventType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x27A5880", Offset = "0x27A4C80", VA = "0x1827A5880")]
		private bool NNGSBOAQNSO(MediaPlayerEvent.EventType a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x27A4930", Offset = "0x27A3D30", VA = "0x1827A4930")]
		private bool KQHRVWCJLKI(MediaPlayerEvent.EventType a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x27A4560", Offset = "0x27A3960", VA = "0x1827A4560")]
		private bool ITKYELJIMGY(int a, float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x27A61A0", Offset = "0x27A55A0", VA = "0x1827A61A0")]
		private static Camera PBOBVCZTARX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x27A7820", Offset = "0x27A6C20", VA = "0x1827A7820")]
		[IteratorStateMachine(typeof(NIZXWQTNOYC))]
		private IEnumerator TQTWRRHFFDY(Texture2D a, ProcessExtractedFrame b, double c = -1.0, bool d = true, int e = 1000, int f = 100)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x27A3E20", Offset = "0x27A3220", VA = "0x1827A3E20")]
		public void ExtractFrameAsync(Texture2D target, ProcessExtractedFrame callback, double timeSeconds = -1.0, bool accurateSeek = true, int timeoutMs = 1000, int timeThresholdMs = 100)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x27A3EF0", Offset = "0x27A32F0", VA = "0x1827A3EF0")]
		public Texture2D ExtractFrame(Texture2D target, double timeSeconds = -1.0, bool accurateSeek = true, int timeoutMs = 1000, int timeThresholdMs = 100)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x27A75D0", Offset = "0x27A69D0", VA = "0x1827A75D0")]
		private Texture TDBTPYGFQPK(double a = -1.0, bool b = true, int c = 1000, int d = 100)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x27A5FB0", Offset = "0x27A53B0", VA = "0x1827A5FB0")]
		public bool OpenMediaFromBuffer(byte[] buffer, bool autoPlay = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x27A73A0", Offset = "0x27A67A0", VA = "0x1827A73A0")]
		public bool StartOpenChunkedMediaFromBuffer(ulong length, bool autoPlay = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x27A2830", Offset = "0x27A1C30", VA = "0x1827A2830")]
		public bool AddChunkToVideoBuffer(byte[] chunk, ulong offset, ulong chunkSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x27A3DA0", Offset = "0x27A31A0", VA = "0x1827A3DA0")]
		public bool EndOpenChunkedVideoFromBuffer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x27A69A0", Offset = "0x27A5DA0", VA = "0x1827A69A0")]
		private bool SSXMTFRCCRL(byte[] a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x27A4720", Offset = "0x27A3B20", VA = "0x1827A4720")]
		private bool JSPCWHNWQMF(ulong a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x27A2830", Offset = "0x27A1C30", VA = "0x1827A2830")]
		private bool BOKRASBPBLG(byte[] a, ulong b, ulong c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x27A3DA0", Offset = "0x27A31A0", VA = "0x1827A3DA0")]
		private bool ILHCLTJOSFU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x27A39D0", Offset = "0x27A2DD0", VA = "0x1827A39D0")]
		public bool EnableSubtitles(MediaPath mediaPath)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x27A6520", Offset = "0x27A5920", VA = "0x1827A6520")]
		[IteratorStateMachine(typeof(PJFIMAIZWNI))]
		private IEnumerator PZMAKKKLOZJ(string a, MediaPath b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x27A3310", Offset = "0x27A2710", VA = "0x1827A3310")]
		public void DisableSubtitles()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "4")]
		private void VDBBOYWZWQM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x27A2A90", Offset = "0x27A1E90", VA = "0x1827A2A90", Slot = "5")]
		private void CKCFOYYUTFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x27A8390", Offset = "0x27A7790", VA = "0x1827A8390")]
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
			public IYSQKTEEQOL.Preset overrideTransitionEasing;

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x27A2510", Offset = "0x27A1910", VA = "0x1827A2510")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x27A9200", Offset = "0x27A8600", VA = "0x1827A9200")]
		public bool AXJHXAFVDOQ(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x27A9260", Offset = "0x27A8660", VA = "0x1827A9260")]
		public MediaPlaylist()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[AddComponentMenu("AVPro Video/Playlist Media Player", -80)]
	[HelpURL("https://www.renderheads.com/products/avpro-video/")]
	public class PlaylistMediaPlayer : MediaPlayer, AFEJTIYLLFY
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
		private sealed class QBWFUNNKLOI : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			private int JIPOOQUWCIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			private object JOTWNIKQVJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			public PlaylistMediaPlayer MXVWDMPVVWS;

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			private object PNRLUNGDWHZ
			{
				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			private object MSIUOYXLJXG
			{
				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xAB07E0", Offset = "0xAAFBE0", VA = "0x180AB07E0")]
			[DebuggerHidden]
			public QBWFUNNKLOI(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "5")]
			[DebuggerHidden]
			private void AEBWHPMOWJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x27AE650", Offset = "0x27ADA50", VA = "0x1827AE650", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x27AE610", Offset = "0x27ADA10", VA = "0x1827AE610", Slot = "8")]
			[DebuggerHidden]
			private void MJTKPUASZVA()
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
		private IYSQKTEEQOL.Preset _defaultTransitionEasing;

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
		private static readonly LazyShaderProperty UOFMJTHTFME;

		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private static readonly LazyShaderProperty HZRDKZWIMNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20D")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private bool APUZIWDIGXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private int LNKDAWWRMSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private MediaPlayer NNXDQRMDLIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private Material VKHSCBVZZTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private Transition EMCOVKCPOVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private string XKJQOKDYVQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private float CAGZUNYQHDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23C")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private IYSQKTEEQOL.Preset POUYECCZXZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private float FSIBJSUFNDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private Func<float, float> LRLAMEVTOBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private RenderTexture QDFMIDZZJVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private MediaPlaylist.MediaItem VKYBEAXEVWT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private MediaPlaylist.MediaItem YSPWMEUYARH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private WaitForEndOfFrame DCNWCPYFKAU;

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public MediaPlayer SWIUCWGDQIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x27AE240", Offset = "0x27AD640", VA = "0x1827AE240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public MediaPlayer VPDAZYNZTTQ
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xC66500", Offset = "0xC65900", VA = "0x180C66500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public MediaPlaylist RSTOCDTMECE
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xC66780", Offset = "0xC65B80", VA = "0x180C66780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public int TKGPROTFYSI
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x2209240", Offset = "0x2208640", VA = "0x182209240")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public MediaPlaylist.MediaItem WITUOFJRUPZ
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x27AE390", Offset = "0x27AD790", VA = "0x1827AE390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Transition PJBCTQKBPCU
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x133A270", Offset = "0x1339670", VA = "0x18133A270")]
			get
			{
				return default(Transition);
			}
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x1335640", Offset = "0x1334A40", VA = "0x181335640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public float SOIWYMHTLFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x1A8EDA0", Offset = "0x1A8E1A0", VA = "0x181A8EDA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x1A906D0", Offset = "0x1A8FAD0", VA = "0x181A906D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public IYSQKTEEQOL.Preset YIMCYDKCPIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x20B4A50", Offset = "0x20B3E50", VA = "0x1820B4A50")]
			get
			{
				return default(IYSQKTEEQOL.Preset);
			}
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x24D5B20", Offset = "0x24D4F20", VA = "0x1824D5B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public bool LHKBEKZUMNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0xDC2E90", Offset = "0xDC2290", VA = "0x180DC2E90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x133B880", Offset = "0x133AC80", VA = "0x18133B880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public PlaylistLoopMode LJMVZGJRZMT
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x27AE380", Offset = "0x27AD780", VA = "0x1827AE380")]
			get
			{
				return default(PlaylistLoopMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x1FBCDE0", Offset = "0x1FBC1E0", VA = "0x181FBCDE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public bool UALSOFQVEJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xDC19E0", Offset = "0xDC0DE0", VA = "0x180DC19E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x133BBE0", Offset = "0x133AFE0", VA = "0x18133BBE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public override SPYDNGPLZJR VTBWYFQFLPE
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x27AE2E0", Offset = "0x27AD6E0", VA = "0x1827AE2E0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public override FWRODULGZYA HJVLPBUUKSX
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x27AE1A0", Offset = "0x27AD5A0", VA = "0x1827AE1A0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public override AFEJTIYLLFY KQFQVZSQYDF
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xD01B00", Offset = "0xD00F00", VA = "0x180D01B00", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public override float EZPSYAYSRHA
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x1A90140", Offset = "0x1A8F540", VA = "0x181A90140", Slot = "6")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x27AE520", Offset = "0x27AD920", VA = "0x1827AE520", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public override bool YMSWEEQVVGH
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xDC1610", Offset = "0xDC0A10", VA = "0x180DC1610", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x27AE450", Offset = "0x27AD850", VA = "0x1827AE450", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x27ACF50", Offset = "0x27AC350", VA = "0x1827ACF50", Slot = "20")]
		public override void Play()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x27ACE40", Offset = "0x27AC240", VA = "0x1827ACE40", Slot = "21")]
		public override void Pause()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xDC2EF0", Offset = "0xDC22F0", VA = "0x180DC2EF0")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x27AD320", Offset = "0x27AC720", VA = "0x1827AD320")]
		[IteratorStateMachine(typeof(QBWFUNNKLOI))]
		private IEnumerator RDNONWPZHGF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x27AC250", Offset = "0x27AB650", VA = "0x1827AC250")]
		private Texture HMLSIOBGRFH(int a = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x27AC4A0", Offset = "0x27AB8A0", VA = "0x1827AC4A0")]
		private Texture NJQHRXMAQMO(int a = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x27AB570", Offset = "0x27AA970", VA = "0x1827AB570")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x27AC610", Offset = "0x27ABA10", VA = "0x1827AC610", Slot = "23")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x27AD450", Offset = "0x27AC850", VA = "0x1827AD450")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x27AC8B0", Offset = "0x27ABCB0", VA = "0x1827AC8B0")]
		public void OnMediaPlayerEvent(MediaPlayer mediaPlayer, MediaPlayerEvent.EventType eventType, ErrorCode errorCode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x27AD060", Offset = "0x27AC460", VA = "0x1827AD060")]
		public bool PrevItem()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x27AC590", Offset = "0x27AB990", VA = "0x1827AC590")]
		public bool NextItem()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x27AB700", Offset = "0x27AAB00", VA = "0x1827AB700")]
		public bool CanJumpToItem(int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x27AC360", Offset = "0x27AB760", VA = "0x1827AC360")]
		public bool JumpToItem(int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x27ACA70", Offset = "0x27ABE70", VA = "0x1827ACA70")]
		public void OpenVideoFile(MediaPlaylist.MediaItem mediaItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x27AD390", Offset = "0x27AC790", VA = "0x1827AD390")]
		private bool RUXOWVAYVXV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x27ADBD0", Offset = "0x27ACFD0", VA = "0x1827ADBD0")]
		private void VKBAFLHSMBT(Transition a, float b, IYSQKTEEQOL.Preset c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x27AD690", Offset = "0x27ACA90", VA = "0x1827AD690", Slot = "22")]
		protected override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x27AC030", Offset = "0x27AB430", VA = "0x1827AC030", Slot = "26")]
		public Texture GetTexture(int index = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x27ABAA0", Offset = "0x27AAEA0", VA = "0x1827ABAA0", Slot = "25")]
		public int GetTextureCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x27ABB40", Offset = "0x27AAF40", VA = "0x1827ABB40", Slot = "27")]
		public int GetTextureFrameCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x27AD5F0", Offset = "0x27AC9F0", VA = "0x1827AD5F0", Slot = "28")]
		public bool SupportsTextureFrameCount()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x27ABE60", Offset = "0x27AB260", VA = "0x1827ABE60", Slot = "29")]
		public long GetTextureTimeStamp()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x27ABD10", Offset = "0x27AB110", VA = "0x1827ABD10", Slot = "30")]
		public float GetTexturePixelAspectRatio()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x27AD3B0", Offset = "0x27AC7B0", VA = "0x1827AD3B0", Slot = "31")]
		public bool RequiresVerticalFlip()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x27AC120", Offset = "0x27AB520", VA = "0x1827AC120", Slot = "35")]
		public Matrix4x4 GetYpCbCrTransform()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x27ABDC0", Offset = "0x27AB1C0", VA = "0x1827ABDC0", Slot = "32")]
		public StereoPacking GetTextureStereoPacking()
		{
			return default(StereoPacking);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x27ABF90", Offset = "0x27AB390", VA = "0x1827ABF90", Slot = "33")]
		public TransparencyMode GetTextureTransparency()
		{
			return default(TransparencyMode);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x27ABA00", Offset = "0x27AAE00", VA = "0x1827ABA00", Slot = "34")]
		public AlphaPacking GetTextureAlphaPacking()
		{
			return default(AlphaPacking);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x27AB7D0", Offset = "0x27AABD0", VA = "0x1827AB7D0", Slot = "36")]
		public float[] GetAffineTransform()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x27ABBE0", Offset = "0x27AAFE0", VA = "0x1827ABBE0", Slot = "37")]
		public Matrix4x4 GetTextureMatrix()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x27AB8C0", Offset = "0x27AACC0", VA = "0x1827AB8C0", Slot = "38")]
		public RenderTextureFormat GetCompatibleRenderTextureFormat(GetCompatibleRenderTextureFormatOptions options, int plane)
		{
			return default(RenderTextureFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x27AD070", Offset = "0x27AC470", VA = "0x1827AD070")]
		private static string QUZLBMDXDFM(Transition a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x27AE010", Offset = "0x27AD410", VA = "0x1827AE010")]
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
		private AOUBRUWDRTL.ResolveFlags _resolveFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[SerializeField]
		private RenderTexture _externalTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private Material JESFLKIRWYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private bool HAXAMJGWVFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x71")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private bool DMNKVJDVEKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x72")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private bool XIQVOMZYVZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private RenderTexture MAMYJUUXRMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private int FKKRMWBFCKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private Material WMQJIJJVLWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private int RUHOUDFALOJ;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public MediaPlayer MZHNPZDJSNV
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x27AECC0", Offset = "0x27AE0C0", VA = "0x1827AECC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public VideoResolveOptions SMDCNUPTJAD
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x27AF7B0", Offset = "0x27AEBB0", VA = "0x1827AF7B0")]
			get
			{
				return default(VideoResolveOptions);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x27AF7D0", Offset = "0x27AEBD0", VA = "0x1827AF7D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public RenderTexture XGEYKFMBMKA
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xAA3380", Offset = "0xAA2780", VA = "0x180AA3380")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xAA3130", Offset = "0xAA2530", VA = "0x180AA3130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public RenderTexture MEBSPZYASVE
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x27AF730", Offset = "0x27AEB30", VA = "0x1827AF730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x27AF570", Offset = "0x27AE970", VA = "0x1827AF570")]
		public void SetMaterialDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x27AECC0", Offset = "0x27AE0C0", VA = "0x1827AECC0")]
		private void CTIXMMVMWMT(MediaPlayer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x27AF580", Offset = "0x27AE980", VA = "0x1827AF580")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x27AED60", Offset = "0x27AE160", VA = "0x1827AED60")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x27AEE90", Offset = "0x27AE290", VA = "0x1827AEE90")]
		public void Resolve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x27AEE10", Offset = "0x27AE210", VA = "0x1827AEE10")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x27AED70", Offset = "0x27AE170", VA = "0x1827AED70")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x27AF6E0", Offset = "0x27AEAE0", VA = "0x1827AF6E0")]
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
		private static readonly LazyShaderProperty XRRPYXYKPMN;

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private static readonly LazyShaderProperty NFXGHYJXUGY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private Camera VKBSFBODAYW;

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Camera SNAOOIOJQKB
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x27AF7F0", Offset = "0x27AEBF0", VA = "0x1827AF7F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x27AFFE0", Offset = "0x27AF3E0", VA = "0x1827AFFE0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x27AF890", Offset = "0x27AEC90", VA = "0x1827AF890")]
		private void BJBQGYLZWCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x27AFBD0", Offset = "0x27AEFD0", VA = "0x1827AFBD0")]
		private static bool LYQZXVDNNJN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x27AFC00", Offset = "0x27AF000", VA = "0x1827AFC00")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xAA4900", Offset = "0xAA3D00", VA = "0x180AA4900")]
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
		protected bool MBMYACVUZNX;

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public MediaPlayer OBAVPYYGRFR
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x279B3B0", Offset = "0x279A7B0", VA = "0x18279B3B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public bool EMJZHXCOXRO
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xC75520", Offset = "0xC74920", VA = "0x180C75520")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x279B390", Offset = "0x279A790", VA = "0x18279B390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public StereoPacking CLORMKLARWR
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xC4E8F0", Offset = "0xC4DCF0", VA = "0x180C4E8F0")]
			get
			{
				return default(StereoPacking);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x279B3A0", Offset = "0x279A7A0", VA = "0x18279B3A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public bool KUUXYTHDZLP
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xAF9F90", Offset = "0xAF9390", VA = "0x180AF9F90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x279B3C0", Offset = "0x279A7C0", VA = "0x18279B3C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x279B0B0", Offset = "0x279A4B0", VA = "0x18279B0B0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x279B0C0", Offset = "0x279A4C0", VA = "0x18279B0C0")]
		private void CTIXMMVMWMT(MediaPlayer a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x279B270", Offset = "0x279A670", VA = "0x18279B270")]
		private void EKJZPGNFSEE(MediaPlayer a, MediaPlayerEvent.EventType b, ErrorCode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x279B2B0", Offset = "0x279A6B0", VA = "0x18279B2B0")]
		public void ForceUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x279B350", Offset = "0x279A750", VA = "0x18279B350")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x279B300", Offset = "0x279A700", VA = "0x18279B300", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x17C2710", Offset = "0x17C1B10", VA = "0x1817C2710", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x279B2F0", Offset = "0x279A6F0", VA = "0x18279B2F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "6")]
		protected virtual void EYFQMPHWZMW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "7")]
		protected virtual void HLOLSAEVBKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void Apply();

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x158EA10", Offset = "0x158DE10", VA = "0x18158EA10")]
		protected ApplyToBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class FXDKZVCHNIQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		protected class OUYBQPEBGPO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public HashSet<AudioOutput> NDIVLIJZPSE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public float[] FSGELHMHJWK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public bool KJIVVRZQWZD;

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public OUYBQPEBGPO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private static FXDKZVCHNIQ XATEFYIHAUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private Dictionary<int, OUYBQPEBGPO> QGFFQAJBHIV;

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public static FXDKZVCHNIQ LVYKDVFRYUJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x27A1980", Offset = "0x27A0D80", VA = "0x1827A1980")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x27A2490", Offset = "0x27A1890", VA = "0x1827A2490")]
		private FXDKZVCHNIQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x27A1A70", Offset = "0x27A0E70", VA = "0x1827A1A70")]
		public void TTIWKQREQTF(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x27A1B60", Offset = "0x27A0F60", VA = "0x1827A1B60")]
		public void YHOPYJELXKY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x27A1BE0", Offset = "0x27A0FE0", VA = "0x1827A1BE0")]
		public void YOJPIBZNQYX(AudioOutput a, MediaPlayer b, int c, float[] d, int e, int f, AudioOutput.AudioOutputMode g, bool h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x27A1940", Offset = "0x27A0D40", VA = "0x1827A1940")]
		private void DHAQMOBVOTI(float[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x27A1830", Offset = "0x27A0C30", VA = "0x1827A1830")]
		private bool AHSNXXYMFKW(MediaPlayer a, float[] b, int c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[DefaultMember("Item")]
	public abstract class ONEYUFGXDVK : MSICTZPRRNU, FWRODULGZYA, SPYDNGPLZJR, VFGDPVDCJXN, AFEJTIYLLFY, YAUINNSWCCY, HRVALWDMQRW, OEDGZIWDWIJ, XRIYOSNZLQG, GYOCHCOALGX, IEnumerable, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		protected string AVAREJSWQNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		protected ErrorCode GEUEINNPFMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		protected FilterMode JCEPHEDDPYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		protected TextureWrapMode HXPVTJFRDSI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		protected int ZWSGGFAZYHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		protected MediaHints QOWKFJLBPHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		protected DTKLJWOQPJH IDETOURFZQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		protected DTKLJWOQPJH ZAGCOHNNWOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private float NYZHMVIZGLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private int LNVLYLGWPIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private float JDEGGCENPOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private float LAWWRCHMABN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private int TENAZJJALCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private int JRFROSIDBXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		protected List<OCLWTVKEBXQ> XCCMJELMUCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		protected OCLWTVKEBXQ NADUEMRQERO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		protected YADOXKFGPAX SITEJHDKEKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		protected YVFCFRRGGFO ASNHWCJDQWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		protected YZRLMDRUQVT AKIPIYDGNZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		protected ZHXZVHGWAAE TQAMSCQJZZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		protected CTZRPWGCVLD ZNCOAZMFTWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		protected VHTSOTEKTBD[] KFVLUYRGNDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		protected List<WQRZHXKEVMT> SCCVMNAECJD;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x27AABB0", Offset = "0x27A9FB0", VA = "0x1827AABB0")]
		public ONEYUFGXDVK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "82")]
		public abstract string MBCXYFGRZEC();

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "83")]
		public abstract string YGUCWLXALHQ();

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "84")]
		public abstract bool LDWDUNPVTOO(string a, long b, string c, MediaHints d, int e = 0, bool f = false);

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "85")]
		public virtual bool EPTSMVMPNQY(byte[] a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "86")]
		public virtual bool KUKJRNMVNNG(ulong a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "87")]
		public virtual bool FXWTHWAFQLR(byte[] a, ulong b, ulong c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "88")]
		public virtual bool IQQBYGVEDED()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x27AA600", Offset = "0x27A9A00", VA = "0x1827AA600", Slot = "89")]
		public virtual void PRWFYUQQWYS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(Slot = "90")]
		public abstract void JSQKIXLDVMI(bool a);

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "91")]
		public abstract bool OUFBYNAVPKQ();

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(Slot = "92")]
		public abstract bool CQRKDBDYOLF();

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "93")]
		public abstract bool UBJFWTXKBYK();

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
		[Cpp2IlInjected.Address(RVA = "0x27AAAD0", Offset = "0x27A9ED0", VA = "0x1827AAAD0", Slot = "97")]
		public virtual void ZSJVGIJEJYB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(Slot = "98")]
		public abstract void KQWCTKPVVHE(double a);

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(Slot = "99")]
		public abstract void VGCDESBPAVS(double a);

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(Slot = "100")]
		public abstract double UWEFRXYRRYG();

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(Slot = "101")]
		public abstract float SWRUYARRZHT();

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(Slot = "102")]
		public abstract void XXPPQZQEEVX(float a);

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(Slot = "103")]
		public abstract double JPBUKFSTBYK();

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(Slot = "104")]
		public abstract int IXIQRDMBARJ();

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(Slot = "105")]
		public abstract int JKVUMMABIBE();

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(Slot = "106")]
		public abstract float IKNKSIXFUNG();

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(Slot = "107")]
		public abstract bool WZQKNBGCNOY();

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(Slot = "108")]
		public abstract bool LSWCHWSRDEB();

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(Slot = "109")]
		public abstract bool ATTDLPJBZCG();

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(Slot = "110")]
		public abstract bool PBTOMSREBCU();

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(Slot = "111")]
		public abstract bool TZACJECSAZW();

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(Slot = "112")]
		public abstract bool FTPXYDLPPYQ();

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "113")]
		public abstract bool QYPJLCQVMMM();

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "114")]
		public virtual bool ENGZSIJLKGE(Camera a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xB4FBD0", Offset = "0xB4EFD0", VA = "0x180B4FBD0", Slot = "115")]
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
		[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "118")]
		public virtual bool SupportsTextureFrameCount()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x27AA380", Offset = "0x27A9780", VA = "0x1827AA380", Slot = "119")]
		public virtual long GetTextureTimeStamp()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(Slot = "120")]
		public abstract bool RequiresVerticalFlip();

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xB4CC90", Offset = "0xB4C090", VA = "0x180B4CC90", Slot = "121")]
		public virtual float GetTexturePixelAspectRatio()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x27AA390", Offset = "0x27A9790", VA = "0x1827AA390", Slot = "122")]
		public virtual Matrix4x4 GetYpCbCrTransform()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x27AA080", Offset = "0x27A9480", VA = "0x1827AA080", Slot = "123")]
		public virtual float[] GetAffineTransform()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x27AA930", Offset = "0x27A9D30", VA = "0x1827AA930", Slot = "124")]
		public virtual float[] RSDYCMQQWZR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x27AA1C0", Offset = "0x27A95C0", VA = "0x1827AA1C0", Slot = "125")]
		public virtual Matrix4x4 GetTextureMatrix()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xC0FD00", Offset = "0xC0F100", VA = "0x180C0FD00", Slot = "126")]
		public virtual RenderTextureFormat GetCompatibleRenderTextureFormat(GetCompatibleRenderTextureFormatOptions options, int plane)
		{
			return default(RenderTextureFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x27AA350", Offset = "0x27A9750", VA = "0x1827AA350", Slot = "70")]
		public StereoPacking GetTextureStereoPacking()
		{
			return default(StereoPacking);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(Slot = "127")]
		internal abstract StereoPacking KIEGSKTTUEH();

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xAAB1A0", Offset = "0xAAA5A0", VA = "0x180AAB1A0", Slot = "128")]
		public virtual TransparencyMode GetTextureTransparency()
		{
			return default(TransparencyMode);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x27AA180", Offset = "0x27A9580", VA = "0x1827AA180", Slot = "72")]
		public AlphaPacking GetTextureAlphaPacking()
		{
			return default(AlphaPacking);
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(Slot = "129")]
		public abstract void GBOXXEBBYZZ(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(Slot = "130")]
		public abstract bool FBTTYFUEXFH();

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "131")]
		public abstract void ZNABKYPKGCM(float a);

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "132")]
		public virtual void BKBCPTAAPVM(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(Slot = "133")]
		public abstract float OODGIYRXVAA();

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xAF3EA0", Offset = "0xAF32A0", VA = "0x180AF3EA0", Slot = "134")]
		public virtual float GetBalance()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xAF3EB0", Offset = "0xAF32B0", VA = "0x180AF3EB0", Slot = "135")]
		public virtual int ZIKDUPOHLGO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "136")]
		public virtual int AHSNXXYMFKW(float[] a, int b, int c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "137")]
		public virtual void UJDRXLZKTSO(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "138")]
		public virtual void IDZCAJAONBS(Quaternion a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "139")]
		public virtual void SVNVFCUUOZL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "140")]
		public virtual void PEJUSXNYDHC(Audio360ChannelMode a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "141")]
		public virtual void UOMOSRCQTOR(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "142")]
		public virtual void WYWCQDCTPIZ(float a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "143")]
		public virtual void SWGEJVRZZBI(Quaternion a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "144")]
		public virtual void HMDAAZQJNER(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "145")]
		public virtual void VUCQPYXXXJA(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(Slot = "146")]
		public abstract void Update();

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "147")]
		public virtual void YQLXBAUULJR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "148")]
		public abstract void Render();

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(Slot = "149")]
		public abstract void Dispose();

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "150")]
		public virtual void LPNOFDYNEGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x27A99F0", Offset = "0x27A8DF0", VA = "0x1827A99F0", Slot = "40")]
		public ErrorCode BQZMOCNIEJO()
		{
			return default(ErrorCode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "151")]
		public virtual bool NWSKXJGKJBT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810", Slot = "39")]
		public DTKLJWOQPJH JZKGNYBWYJL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x27AA540", Offset = "0x27A9940", VA = "0x1827AA540", Slot = "42")]
		public void PDYMSUZEGLO([Out] FilterMode a, [Out] TextureWrapMode b, [Out] int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x27A9B40", Offset = "0x27A8F40", VA = "0x1827A9B40", Slot = "41")]
		public void CNGNSACMJSY(FilterMode a = FilterMode.Bilinear, TextureWrapMode b = TextureWrapMode.Clamp, int c = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x27AA560", Offset = "0x27A9960", VA = "0x1827AA560", Slot = "152")]
		protected virtual void PFWLPFVUXVC(Texture a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x27AAA30", Offset = "0x27A9E30", VA = "0x1827AAA30")]
		protected void TDDVOHDZTMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x27A9DA0", Offset = "0x27A91A0", VA = "0x1827A9DA0")]
		protected bool EKGOAFNPLXX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x27AA6A0", Offset = "0x27A9AA0", VA = "0x1827AA6A0", Slot = "153")]
		public virtual bool RLCBRZBNEYS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x27AA4D0", Offset = "0x27A98D0", VA = "0x1827AA4D0", Slot = "77")]
		public bool OMHBAIBGXRI(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x27A9A00", Offset = "0x27A8E00", VA = "0x1827A9A00", Slot = "154")]
		public virtual void CKWVQKLORVC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x27AA910", Offset = "0x27A9D10", VA = "0x1827AA910", Slot = "155")]
		public virtual int RNJGLZOSSEC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x27AA3F0", Offset = "0x27A97F0", VA = "0x1827AA3F0", Slot = "156")]
		public virtual string ITVGCIZYAXX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "157")]
		public virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x27AAAF0", Offset = "0x27A9EF0", VA = "0x1827AAAF0", Slot = "158")]
		public int ZYMIDRSAZVW(float a = 0f)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x27AA950", Offset = "0x27A9D50", VA = "0x1827AA950")]
		protected bool SKZJETRYFDB(bool a = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "159")]
		internal abstract bool KRMLTRSPRSZ();

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(Slot = "160")]
		internal abstract string BALTGVOWSAU();

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "161")]
		internal abstract bool OBHCVFXUDXL(TrackType a);

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "162")]
		internal abstract int LTXAVEZJUXN(TrackType a);

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(Slot = "163")]
		internal abstract VXENMAJCWHS JFEOXYRXMIA(TrackType a, int b, bool c);

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x27A9F20", Offset = "0x27A9320", VA = "0x1827A9F20")]
		private void FYAPMEGEUUA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x27AA420", Offset = "0x27A9820", VA = "0x1827AA420")]
		protected void JEKSIEIBZEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x27A9BD0", Offset = "0x27A8FD0", VA = "0x1827A9BD0")]
		private void CNNNRWHRITN(VHTSOTEKTBD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x27AA0F0", Offset = "0x27A94F0", VA = "0x1827AA0F0", Slot = "164")]
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
		private List<UnityAction<MediaPlayer, EventType, ErrorCode>> GVUSHYSNOMQ;

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x27A25B0", Offset = "0x27A19B0", VA = "0x1827A25B0")]
		public bool IGNQRNRPWAD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x27A2610", Offset = "0x27A1A10", VA = "0x1827A2610")]
		public void NIMMDZFPEWF(UnityAction<MediaPlayer, EventType, ErrorCode> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x27A2700", Offset = "0x27A1B00", VA = "0x1827A2700")]
		public void YTLKYMQDPDU(UnityAction<MediaPlayer, EventType, ErrorCode> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x27A27A0", Offset = "0x27A1BA0", VA = "0x1827A27A0")]
		public MediaPlayerEvent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public static class UAXUYMXKKLU
	{
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private static Matrix4x4 TXZFPKIZDEY;

		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private static Matrix4x4 ESYEZDLVBQS;

		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private static Matrix4x4 KBOSNKYYUSU;

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x27C1530", Offset = "0x27C0930", VA = "0x1827C1530")]
		public static string UGLFETQWFND(MediaPathType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x27C1320", Offset = "0x27C0720", VA = "0x1827C1320")]
		public static string RAUZVAPMEWP(string a, MediaPathType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x27C1200", Offset = "0x27C0600", VA = "0x1827C1200")]
		public static string JSEFIBAJPMP(ErrorCode a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x27C0DF0", Offset = "0x27C01F0", VA = "0x1827C0DF0")]
		public static void IUPSMACTODK(string a, [Optional] UnityEngine.Object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x27C1710", Offset = "0x27C0B10", VA = "0x1827C1710")]
		public static int WEWYCHHQEQT()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x27C1680", Offset = "0x27C0A80", VA = "0x1827C1680")]
		public static int VRHTGQRRSFF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x27C0BE0", Offset = "0x27BFFE0", VA = "0x1827C0BE0")]
		public static Orientation IMWTZFRZTYI(float[] a)
		{
			return default(Orientation);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x27C0A80", Offset = "0x27BFE80", VA = "0x1827C0A80")]
		public static int GNKJSMKOVKV(double a, float b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x27C0B00", Offset = "0x27BFF00", VA = "0x1827C0B00")]
		private static extern int GetShortPathName(string pathName, StringBuilder shortName, int cbShortName);

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x27C1740", Offset = "0x27C0B40", VA = "0x1827C1740")]
		internal static string WGLXVWOHNHZ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x27C0ED0", Offset = "0x27C02D0", VA = "0x1827C0ED0")]
		public static Texture2D JBKKKOZTRJT(Texture a, bool b, Orientation c, [Optional] Texture2D d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public interface MSICTZPRRNU
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnEnable();

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Update();

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LPNOFDYNEGG();

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void YQLXBAUULJR();

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Render();
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public interface YAUINNSWCCY
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool OMHBAIBGXRI(string a);

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int RNJGLZOSSEC();

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(Slot = "2")]
		string ITVGCIZYAXX();
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public interface FWRODULGZYA
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool LDWDUNPVTOO(string a, long b, string c, MediaHints d, int e = 0, bool f = false);

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool EPTSMVMPNQY(byte[] a);

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool KUKJRNMVNNG(ulong a);

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool FXWTHWAFQLR(byte[] a, ulong b, ulong c);

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool IQQBYGVEDED();

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void PRWFYUQQWYS();

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void JSQKIXLDVMI(bool a);

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool OUFBYNAVPKQ();

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool CQRKDBDYOLF();

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool UBJFWTXKBYK();

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool PBTOMSREBCU();

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool ATTDLPJBZCG();

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool TZACJECSAZW();

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(Slot = "13")]
		bool FTPXYDLPPYQ();

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(Slot = "14")]
		bool QYPJLCQVMMM();

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
		void ZSJVGIJEJYB();

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void KQWCTKPVVHE(double a);

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void VGCDESBPAVS(double a);

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(Slot = "21")]
		double UWEFRXYRRYG();

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(Slot = "22")]
		float SWRUYARRZHT();

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void XXPPQZQEEVX(float a);

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void GBOXXEBBYZZ(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(Slot = "25")]
		bool FBTTYFUEXFH();

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void ZNABKYPKGCM(float a);

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void BKBCPTAAPVM(float a);

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(Slot = "28")]
		float OODGIYRXVAA();

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(Slot = "29")]
		float GetBalance();

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(Slot = "30")]
		DTKLJWOQPJH JZKGNYBWYJL();

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(Slot = "31")]
		ErrorCode BQZMOCNIEJO();

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(Slot = "32")]
		void CNGNSACMJSY(FilterMode a = FilterMode.Bilinear, TextureWrapMode b = TextureWrapMode.Clamp, int c = 1);

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(Slot = "33")]
		void PDYMSUZEGLO([Out] FilterMode a, [Out] TextureWrapMode b, [Out] int c);

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(Slot = "34")]
		int AHSNXXYMFKW(float[] a, int b, int c);

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(Slot = "35")]
		int ZIKDUPOHLGO();

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void UJDRXLZKTSO(bool a);

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(Slot = "37")]
		void PEJUSXNYDHC(Audio360ChannelMode a);

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(Slot = "38")]
		void IDZCAJAONBS(Quaternion a);

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(Slot = "39")]
		void SVNVFCUUOZL();

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(Slot = "40")]
		void UOMOSRCQTOR(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(Slot = "41")]
		void WYWCQDCTPIZ(float a, float b);

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(Slot = "42")]
		void SWGEJVRZZBI(Quaternion a);

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(Slot = "43")]
		bool ENGZSIJLKGE(Camera a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(Slot = "44")]
		void HMDAAZQJNER(string a);

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(Slot = "45")]
		void VUCQPYXXXJA(byte[] a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public interface SPYDNGPLZJR
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(Slot = "0")]
		double JPBUKFSTBYK();

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int IXIQRDMBARJ();

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int JKVUMMABIBE();

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(Slot = "3")]
		float IKNKSIXFUNG();

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool LSWCHWSRDEB();

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool NWSKXJGKJBT();

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool RLCBRZBNEYS();

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float[] RSDYCMQQWZR();
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public interface VFGDPVDCJXN
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public interface AFEJTIYLLFY
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
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			get
			{
				return default(MediaPathType);
			}
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public string Path
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x27BC370", Offset = "0x27BB770", VA = "0x1827BC370")]
		public MediaPath()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x27BC300", Offset = "0x27BB700", VA = "0x1827BC300")]
		public MediaPath(MediaPath copy)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x27BC290", Offset = "0x27BB690", VA = "0x1827BC290")]
		public MediaPath(string path, MediaPathType pathType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x27BBFF0", Offset = "0x27BB3F0", VA = "0x1827BBFF0")]
		public string VIKKSEGQZRW()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x27BBF60", Offset = "0x27BB360", VA = "0x1827BBF60")]
		public static MediaPath JPYCDDHQRIR(string a)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x27BC270", Offset = "0x27BB670", VA = "0x1827BC270")]
		public static bool ZWISVWGZSLY(MediaPath a, MediaPath b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x27BC230", Offset = "0x27BB630", VA = "0x1827BC230")]
		public static bool ZPGHGHNXRJT(MediaPath a, MediaPath b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x27BBE20", Offset = "0x27BB220", VA = "0x1827BBE20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x27BBF10", Offset = "0x27BB310", VA = "0x1827BBF10", Slot = "2")]
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
		public static MediaHints VDDQACCVTOD
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x27BBDD0", Offset = "0x27BB1D0", VA = "0x1827BBDD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x27C4B00", Offset = "0x27C3F00", VA = "0x1827C4B00")]
		public bool ICCJRYORJHL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x27C4A60", Offset = "0x27C3E60", VA = "0x1827C4A60")]
		internal void CDJGFKLBKTM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x27C4A90", Offset = "0x27C3E90", VA = "0x1827C4A90")]
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
	public static class EHWWKWWLVKT
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
	public static class ICATGGHVRJH
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
	public static class MUMGWBBTGLV
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
	public class DTKLJWOQPJH : IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		internal TimeRange[] NBSBWTJGKIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		internal double YOHEXUVUNLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		internal double HVDTKBVFZLY;

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public int ULFDSOUXGUF
		{
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x2488E20", Offset = "0x2488220", VA = "0x182488E20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public double XLOLCDXDDTJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x27B3350", Offset = "0x27B2750", VA = "0x1827B3350")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public double IRJNEBUMULL
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x27B2FB0", Offset = "0x27B23B0", VA = "0x1827B2FB0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public double EDEYOXZHUES
		{
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x27B2FC0", Offset = "0x27B23C0", VA = "0x1827B2FC0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x27B3360", Offset = "0x27B2760", VA = "0x1827B3360")]
		internal DTKLJWOQPJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x27B2FD0", Offset = "0x27B23D0", VA = "0x1827B2FD0", Slot = "4")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x27B3140", Offset = "0x27B2540", VA = "0x1827B3140", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x27B2FF0", Offset = "0x27B23F0", VA = "0x1827B2FF0")]
		internal void QBPJMFVFDWT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class YADOXKFGPAX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private int RCMAZLRKQVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private long ZYNAMHRLFYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private ONEYUFGXDVK TFVAFMOPFOK;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public int PEZLFFKJZRO
		{
			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public int CGMMTALZRFH
		{
			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0xC4E2B0", Offset = "0xC4D6B0", VA = "0x180C4E2B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0xCDF260", Offset = "0xCDE660", VA = "0x180CDF260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public int MYSRNGXOZTD
		{
			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0xAAC980", Offset = "0xAABD80", VA = "0x180AAC980")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0xAB2F40", Offset = "0xAB2340", VA = "0x180AB2F40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		private float EMIRZOOIEMP
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x10D4A90", Offset = "0x10D3E90", VA = "0x1810D4A90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		private string ITREHWMAQRL
		{
			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		private int ZJALMUVNLZL
		{
			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1A0", Offset = "0xAAA5A0", VA = "0x180AAB1A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1B0", Offset = "0xAAA5B0", VA = "0x180AAB1B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		private int KZNQFDEJUEK
		{
			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0xC4E8F0", Offset = "0xC4DCF0", VA = "0x180C4E8F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x1ACB200", Offset = "0x1ACA600", VA = "0x181ACB200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public bool WVLLAOLLISA
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0xAF9F90", Offset = "0xAF9390", VA = "0x180AF9F90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x27C4C70", Offset = "0x27C4070", VA = "0x1827C4C70")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x27C4CC0", Offset = "0x27C40C0", VA = "0x1827C4CC0")]
		internal void Start(ONEYUFGXDVK player)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x27C5070", Offset = "0x27C4470", VA = "0x1827C5070")]
		internal void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0")]
		private static bool VMKOCOLNKIH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public YADOXKFGPAX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public sealed class JANYPKLEVRO : ONEYUFGXDVK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private bool QJXUMZUCTJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private bool APUZIWDIGXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private double JOQPRTFNEEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private float WLQPNPOWVPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private float EKRAGFBDDIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private bool WDOGVXMMUOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private int OEOSLJVIDSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private int SFFEZJDTAYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private Texture2D QQGYJROHEHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private Texture2D OQWGFYFCYVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private Texture2D LHKANCPMUTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private float RJDIDUQEVLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private int NQRAWECKMEP;

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x27BB940", Offset = "0x27BAD40", VA = "0x1827BB940", Slot = "82")]
		public override string MBCXYFGRZEC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x27BBB90", Offset = "0x27BAF90", VA = "0x1827BBB90", Slot = "83")]
		public override string YGUCWLXALHQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x27BB750", Offset = "0x27BAB50", VA = "0x1827BB750", Slot = "84")]
		public override bool LDWDUNPVTOO(string a, long b, string c, MediaHints d, int e = 0, bool f = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x27BB970", Offset = "0x27BAD70", VA = "0x1827BB970", Slot = "89")]
		public override void PRWFYUQQWYS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xB13EF0", Offset = "0xB132F0", VA = "0x180B13EF0", Slot = "90")]
		public override void JSQKIXLDVMI(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xB13BD0", Offset = "0xB12FD0", VA = "0x180B13BD0", Slot = "91")]
		public override bool OUFBYNAVPKQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "92")]
		public override bool CQRKDBDYOLF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "93")]
		public override bool UBJFWTXKBYK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "107")]
		public override bool WZQKNBGCNOY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "108")]
		public override bool LSWCHWSRDEB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x27BB9C0", Offset = "0x27BADC0", VA = "0x1827BB9C0", Slot = "94")]
		public override void Play()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x27BB9B0", Offset = "0x27BADB0", VA = "0x1827BB9B0", Slot = "95")]
		public override void Pause()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x27BB9E0", Offset = "0x27BADE0", VA = "0x1827BB9E0", Slot = "96")]
		public override void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "109")]
		public override bool ATTDLPJBZCG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xCF4B00", Offset = "0xCF3F00", VA = "0x180CF4B00", Slot = "110")]
		public override bool PBTOMSREBCU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xBBDC80", Offset = "0xBBD080", VA = "0x180BBDC80", Slot = "111")]
		public override bool TZACJECSAZW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x27BB6E0", Offset = "0x27BAAE0", VA = "0x1827BB6E0", Slot = "112")]
		public override bool FTPXYDLPPYQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "113")]
		public override bool QYPJLCQVMMM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x27BB730", Offset = "0x27BAB30", VA = "0x1827BB730", Slot = "103")]
		public override double JPBUKFSTBYK()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xDC2C60", Offset = "0xDC2060", VA = "0x180DC2C60", Slot = "104")]
		public override int IXIQRDMBARJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xCF4EE0", Offset = "0xCF42E0", VA = "0x180CF4EE0", Slot = "105")]
		public override int JKVUMMABIBE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xB52030", Offset = "0xB51430", VA = "0x180B52030", Slot = "116")]
		public override Texture GetTexture(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x1C533A0", Offset = "0x1C527A0", VA = "0x181C533A0", Slot = "117")]
		public override int GetTextureFrameCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xC11440", Offset = "0xC10840", VA = "0x180C11440", Slot = "127")]
		internal override StereoPacking KIEGSKTTUEH()
		{
			return default(StereoPacking);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "120")]
		public override bool RequiresVerticalFlip()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x27BB740", Offset = "0x27BAB40", VA = "0x1827BB740", Slot = "98")]
		public override void KQWCTKPVVHE(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x27BB740", Offset = "0x27BAB40", VA = "0x1827BB740", Slot = "99")]
		public override void VGCDESBPAVS(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x27BB9F0", Offset = "0x27BADF0", VA = "0x1827BB9F0", Slot = "100")]
		public override double UWEFRXYRRYG()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x27BBB80", Offset = "0x27BAF80", VA = "0x1827BBB80", Slot = "102")]
		public override void XXPPQZQEEVX(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x1BDDF80", Offset = "0x1BDD380", VA = "0x181BDDF80", Slot = "101")]
		public override float SWRUYARRZHT()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "129")]
		public override void GBOXXEBBYZZ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "130")]
		public override bool FBTTYFUEXFH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x1BE80E0", Offset = "0x1BE74E0", VA = "0x181BE80E0", Slot = "131")]
		public override void ZNABKYPKGCM(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x1BDDF90", Offset = "0x1BDD390", VA = "0x181BDDF90", Slot = "133")]
		public override float OODGIYRXVAA()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xAF3EA0", Offset = "0xAF32A0", VA = "0x180AF3EA0", Slot = "106")]
		public override float IKNKSIXFUNG()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x27BBA00", Offset = "0x27BAE00", VA = "0x1827BBA00", Slot = "146")]
		public override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "148")]
		public override void Render()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "149")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "161")]
		internal override bool OBHCVFXUDXL(TrackType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "162")]
		internal override int LTXAVEZJUXN(TrackType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "163")]
		internal override VXENMAJCWHS JFEOXYRXMIA(TrackType a, int b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "159")]
		internal override bool KRMLTRSPRSZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "160")]
		internal override string BALTGVOWSAU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x27BBBB0", Offset = "0x27BAFB0", VA = "0x1827BBBB0")]
		public JANYPKLEVRO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class KJSKGOQCUBC
	{
		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public string WVZOGRZGSKD
		{
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public string SPHJVOAGGSP
		{
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public byte[] FCAHOXMXOQU
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x27BBC40", Offset = "0x27BB040", VA = "0x1827BBC40")]
		public KJSKGOQCUBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x27BBBE0", Offset = "0x27BAFE0", VA = "0x1827BBBE0")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class HTMYTUNLCMI : ONEYUFGXDVK
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
			[Cpp2IlInjected.Address(RVA = "0x27BE760", Offset = "0x27BDB60", VA = "0x1827BE760")]
			public static extern bool IsChangedTracks(IntPtr instance, TrackType trackType);

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x27BDD00", Offset = "0x27BD100", VA = "0x1827BDD00")]
			public static extern int GetTrackCount(IntPtr instance, TrackType trackType);

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x27BDE20", Offset = "0x27BD220", VA = "0x1827BDE20")]
			public static extern bool GetTrackInfo(IntPtr instance, TrackType trackType, int index, int uid, bool isActive, StringBuilder name, int maxNameLength, StringBuilder language, int maxLanguageLength);

			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x27BE650", Offset = "0x27BDA50", VA = "0x1827BE650")]
			public static extern bool IsChangedTextCue(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x27BCE90", Offset = "0x27BC290", VA = "0x1827BCE90")]
			public static extern IntPtr GetCurrentTextCue(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x27BDBD0", Offset = "0x27BCFD0", VA = "0x1827BDBD0")]
			public static extern int GetTimeRanges(IntPtr playerInstance, [Out] TimeRange[] ranges, int rangeCount, TimeRangeTypes timeRangeType);

			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x27BE450", Offset = "0x27BD850", VA = "0x1827BE450")]
			public static extern bool Init(bool linearColorSpace);

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x27BC870", Offset = "0x27BBC70", VA = "0x1827BC870")]
			public static extern void Deinit();

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x27BD5D0", Offset = "0x27BC9D0", VA = "0x1827BD5D0")]
			public static extern IntPtr GetPluginVersion();

			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x27BC4C0", Offset = "0x27BB8C0", VA = "0x1827BC4C0")]
			public static extern IntPtr BeginOpenSource(IntPtr instance, EHWWKWWLVKT.VideoApi videoApi, EHWWKWWLVKT.AudioOutput audioOutput, bool useHardwareDecoding, bool useRendererSync, bool generateTextureMips, bool hintAlphaChannel, bool useLowLatency, bool use10BitTextures, string forceAudioOutputDeviceName, int unitySampleRate, IntPtr[] preferredFilter, uint numFilters, int audio360ChannelMode, string httpHeader, bool startWithHighestBitrate);

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x27BCAE0", Offset = "0x27BBEE0", VA = "0x1827BCAE0")]
			public static extern IntPtr EndOpenSource(IntPtr instance, string path);

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x27BF0F0", Offset = "0x27BE4F0", VA = "0x1827BF0F0")]
			public static extern IntPtr OpenSourceFromBuffer(IntPtr instance, byte[] buffer, ulong bufferLength, EHWWKWWLVKT.VideoApi videoApi, EHWWKWWLVKT.AudioOutput audioOutput, bool useHardwareDecoding, bool useRendererSync, bool generateTextureMips, bool hintAlphaChannel, bool useLowLatency, bool use10BitTextures, string forceAudioOutputDeviceName, int unitySampleRate, IntPtr[] preferredFilter, uint numFilters);

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x27C06A0", Offset = "0x27BFAA0", VA = "0x1827C06A0")]
			public static extern IntPtr StartOpenSourceFromBuffer(IntPtr instance, EHWWKWWLVKT.VideoApi videoApi, ulong bufferLength);

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x27BC400", Offset = "0x27BB800", VA = "0x1827BC400")]
			public static extern bool AddChunkToSourceBuffer(IntPtr instance, byte[] buffer, ulong offset, ulong chunkLength);

			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x27BC960", Offset = "0x27BBD60", VA = "0x1827BC960")]
			public static extern IntPtr EndOpenSourceFromBuffer(IntPtr instance, EHWWKWWLVKT.AudioOutput audioOutput, bool useHardwareDecoding, bool useRendererSync, bool generateTextureMips, bool hintAlphaChannel, bool useLowLatency, bool use10BitTextures, string forceAudioOutputDeviceName, int unitySampleRate, IntPtr[] preferredFilter, uint numFilters);

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x27BC780", Offset = "0x27BBB80", VA = "0x1827BC780")]
			public static extern void CloseSource(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x27BD4E0", Offset = "0x27BC8E0", VA = "0x1827BD4E0")]
			public static extern IntPtr GetPlayerDescription(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x27BFB40", Offset = "0x27BEF40", VA = "0x1827BFB40")]
			public static extern void SetCustomMovParserEnabled(IntPtr instance, bool enabled);

			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x27BFD00", Offset = "0x27BF100", VA = "0x1827BFD00")]
			public static extern void SetHapNotchLCEnabled(IntPtr instance, bool enabled);

			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x27C0470", Offset = "0x27BF870", VA = "0x1827C0470")]
			public static extern void SetStereoDetectEnabled(IntPtr instance, bool enabled);

			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x27C0500", Offset = "0x27BF900", VA = "0x1827C0500")]
			public static extern void SetTextTrackSupportEnabled(IntPtr instance, bool enabled);

			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x27BF650", Offset = "0x27BEA50", VA = "0x1827BF650")]
			public static extern void SetAudioDelayEnabled(IntPtr instance, bool enabled, bool isAutomatic, double timeSeconds);

			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x27BFC70", Offset = "0x27BF070", VA = "0x1827BFC70")]
			public static extern void SetFacebookAudio360SupportEnabled(IntPtr instance, bool enabled);

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x27BFBD0", Offset = "0x27BEFD0", VA = "0x1827BFBD0")]
			public static extern void SetDecoderHints(IntPtr instance, int parallelFrameCount, int prerollFrameCount);

			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x27BD210", Offset = "0x27BC610", VA = "0x1827BD210")]
			public static extern int GetLastErrorCode(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x27BF3A0", Offset = "0x27BE7A0", VA = "0x1827BF3A0")]
			public static extern void Play(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x27BF320", Offset = "0x27BE720", VA = "0x1827BF320")]
			public static extern void Pause(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x27C0000", Offset = "0x27BF400", VA = "0x1827C0000")]
			public static extern void SetMuted(IntPtr instance, bool muted);

			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x27C0590", Offset = "0x27BF990", VA = "0x1827C0590")]
			public static extern void SetVolume(IntPtr instance, float volume);

			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x27BFA10", Offset = "0x27BEE10", VA = "0x1827BFA10")]
			public static extern void SetBalance(IntPtr instance, float volume);

			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x27BFF70", Offset = "0x27BF370", VA = "0x1827BFF70")]
			public static extern void SetLooping(IntPtr instance, bool looping);

			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x27BE3D0", Offset = "0x27BD7D0", VA = "0x1827BE3D0")]
			public static extern bool HasVideo(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x27BE2D0", Offset = "0x27BD6D0", VA = "0x1827BE2D0")]
			public static extern bool HasAudio(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x27BE0E0", Offset = "0x27BD4E0", VA = "0x1827BE0E0")]
			public static extern int GetWidth(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x27BD110", Offset = "0x27BC510", VA = "0x1827BD110")]
			public static extern int GetHeight(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x27BD090", Offset = "0x27BC490", VA = "0x1827BD090")]
			public static extern float GetFrameRate(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x27BD720", Offset = "0x27BCB20", VA = "0x1827BD720")]
			public static extern StereoPacking GetStereoPacking(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x27BCF90", Offset = "0x27BC390", VA = "0x1827BCF90")]
			public static extern double GetDuration(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x27BE870", Offset = "0x27BDC70", VA = "0x1827BE870")]
			public static extern bool IsPlaybackStalled(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x27BE350", Offset = "0x27BD750", VA = "0x1827BE350")]
			public static extern bool HasMetaData(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x27BC680", Offset = "0x27BBA80", VA = "0x1827BC680")]
			public static extern bool CanPlay(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x27BE970", Offset = "0x27BDD70", VA = "0x1827BE970")]
			public static extern bool IsSeeking(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x27BE8F0", Offset = "0x27BDCF0", VA = "0x1827BE8F0")]
			public static extern bool IsPlaying(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x27BE7F0", Offset = "0x27BDBF0", VA = "0x1827BE7F0")]
			public static extern bool IsFinished(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x27BE550", Offset = "0x27BD950", VA = "0x1827BE550")]
			public static extern bool IsBuffering(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x27BCF10", Offset = "0x27BC310", VA = "0x1827BCF10")]
			public static extern double GetCurrentTime(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x27BFAA0", Offset = "0x27BEEA0", VA = "0x1827BFAA0")]
			public static extern void SetCurrentTime(IntPtr instance, double time, bool fast);

			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x27BD3E0", Offset = "0x27BC7E0", VA = "0x1827BD3E0")]
			public static extern float GetPlaybackRate(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0x27C0350", Offset = "0x27BF750", VA = "0x1827C0350")]
			public static extern void SetPlaybackRate(IntPtr instance, float rate);

			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0x27C0620", Offset = "0x27BFA20", VA = "0x1827C0620")]
			public static extern void StartExtractFrame(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0x27C08B0", Offset = "0x27BFCB0", VA = "0x1827C08B0")]
			public static extern void WaitForExtract(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0x27C0830", Offset = "0x27BFC30", VA = "0x1827C0830")]
			public static extern void Update(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0x27BCB80", Offset = "0x27BBF80", VA = "0x1827BCB80")]
			public static extern void EndUpdate(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(RVA = "0x27BD9A0", Offset = "0x27BCDA0", VA = "0x1827BD9A0")]
			public static extern IntPtr GetTexturePointer(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(RVA = "0x27BD820", Offset = "0x27BCC20", VA = "0x1827BD820")]
			public static extern int GetTextureFormat(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0x27BEA70", Offset = "0x27BDE70", VA = "0x1827BEA70")]
			public static extern bool IsTextureTopDown(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0x27BE9F0", Offset = "0x27BDDF0", VA = "0x1827BE9F0")]
			public static extern bool IsTextureSampleLinear(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x27BD8A0", Offset = "0x27BCCA0", VA = "0x1827BD8A0")]
			public static extern int GetTextureFrameCount(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x27BDA20", Offset = "0x27BCE20", VA = "0x1827BDA20")]
			public static extern long GetTextureTimeStamp(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0x27BD920", Offset = "0x27BCD20", VA = "0x1827BD920")]
			public static extern float GetTexturePixelAspectRatio(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x27BD640", Offset = "0x27BCA40", VA = "0x1827BD640")]
			public static extern IntPtr GetRenderEventFunc();

			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0x27BE160", Offset = "0x27BD560", VA = "0x1827BE160")]
			public static extern int GrabAudio(IntPtr instance, float[] buffer, int sampleCount, int channelCount);

			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0x27BCD10", Offset = "0x27BC110", VA = "0x1827BCD10")]
			public static extern int GetAudioChannelCount(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x27BF5C0", Offset = "0x27BE9C0", VA = "0x1827BF5C0")]
			public static extern int SetAudioChannelMode(IntPtr instance, int audio360ChannelMode);

			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x27BFD90", Offset = "0x27BF190", VA = "0x1827BFD90")]
			public static extern void SetHeadOrientation(IntPtr instance, float x, float y, float z, float w);

			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x27BF700", Offset = "0x27BEB00", VA = "0x1827BF700")]
			public static extern void SetAudioFocusEnabled(IntPtr instance, bool enabled);

			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x27BF790", Offset = "0x27BEB90", VA = "0x1827BF790")]
			public static extern void SetAudioFocusProps(IntPtr instance, float offFocusLevel, float widthDegrees);

			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x27BF830", Offset = "0x27BEC30", VA = "0x1827BF830")]
			public static extern void SetAudioFocusRotation(IntPtr instance, float x, float y, float z, float w);

			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x27BEAF0", Offset = "0x27BDEF0", VA = "0x1827BEAF0")]
			public static void KEDLZCXLSZL(IntPtr a, KJSKGOQCUBC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x27C0090", Offset = "0x27BF490", VA = "0x1827C0090")]
			private static extern void SetNextAuthData(IntPtr instance, AuthData authData);
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private EHWWKWWLVKT.AudioOutput LUJYVZEIWTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private string UTDTBKFMNVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private List<string> SCWZJTPAYFZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private Audio360ChannelMode RSYCYYKJPEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		private bool UBNBNKKQUWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC5")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private bool HMSFWGAFAXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC6")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private bool EBUWNUAEBZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC7")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private bool LHWKHBDCGTB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private bool EKHZJKAPGNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private bool QHEQCCEAIMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private int UFGSIOHXGTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private int UAOVYRTXBKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private bool QJXUMZUCTJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD5")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private bool APUZIWDIGXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD6")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private bool SBYBZCCIRAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private float WLQPNPOWVPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private float NIXDYFGIIUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private bool RRRKQAKCQHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private bool RYDQEDHIMNT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE2")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private bool DGBNAWFOEJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private int QFNZVFSQBAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private int SFFEZJDTAYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private float VHEBEIAYNVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private bool TZQBDGSNNYR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF1")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private bool QBEMPPOQPSI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF2")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private bool SDKFBOCGKSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private IntPtr LHKEGKHEKKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private Texture2D QQGYJROHEHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		private RenderTexture DVIMPMWNSYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private IntPtr XATEFYIHAUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private EHWWKWWLVKT.VideoApi OPOZNDETJUW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private bool SNIKSVWKNFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11D")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		private bool JNGJTFOQKPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11E")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private bool FOMNBEQVSAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11F")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private bool ZSCHREBWPJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private bool MIDPFDBPHKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x121")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private bool QOLRKZZELSK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x122")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private bool VWJNERQCAXX;

		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private static bool CRHSAQVZIIU;

		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private static string ILYBGMJNWHH;

		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private static IntPtr ZEDRKNIGCYS;

		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private static int LMDPIJQVIYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private KJSKGOQCUBC OWFOMLZQGSM;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public KJSKGOQCUBC TGGDMVLUMIS
		{
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x27BA470", Offset = "0x27B9870", VA = "0x1827BA470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x27B6050", Offset = "0x27B5450", VA = "0x1827B6050")]
		public static bool CEXCOZBWFIC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x27BA260", Offset = "0x27B9660", VA = "0x1827BA260")]
		public static void YMBBWKAHIZO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x27BA3D0", Offset = "0x27B97D0", VA = "0x1827BA3D0", Slot = "135")]
		public override int ZIKDUPOHLGO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x27BA540", Offset = "0x27B9940", VA = "0x1827BA540")]
		public HTMYTUNLCMI(MediaPlayer.OptionsWindows a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x27B5D60", Offset = "0x27B5160", VA = "0x1827B5D60")]
		public void CEPOBSMXDIU(MediaPlayer.OptionsWindows a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x27B5E10", Offset = "0x27B5210", VA = "0x1827B5E10")]
		public void CEPOBSMXDIU(EHWWKWWLVKT.VideoApi a, EHWWKWWLVKT.AudioOutput b, bool c, bool d, bool e, bool f, bool g, bool h, string i, List<string> j, bool k, int l, int m, bool n, bool o, bool p, bool q, bool r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x27B8CA0", Offset = "0x27B80A0", VA = "0x1827B8CA0", Slot = "82")]
		public override string MBCXYFGRZEC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x27BA230", Offset = "0x27B9630", VA = "0x1827BA230", Slot = "83")]
		public override string YGUCWLXALHQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x150D3C0", Offset = "0x150C7C0", VA = "0x18150D3C0")]
		private bool HMKKJYDWNXP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x27B8110", Offset = "0x27B7510", VA = "0x1827B8110", Slot = "84")]
		public override bool LDWDUNPVTOO(string a, long b, string c, MediaHints d, int e = 0, bool f = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x27B6710", Offset = "0x27B5B10", VA = "0x1827B6710", Slot = "85")]
		public override bool EPTSMVMPNQY(byte[] a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x27B8040", Offset = "0x27B7440", VA = "0x1827B8040", Slot = "86")]
		public override bool KUKJRNMVNNG(ulong a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x27B6CF0", Offset = "0x27B60F0", VA = "0x1827B6CF0", Slot = "87")]
		public override bool FXWTHWAFQLR(byte[] a, ulong b, ulong c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x27B7170", Offset = "0x27B6570", VA = "0x1827B7170", Slot = "88")]
		public override bool IQQBYGVEDED()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x27B95B0", Offset = "0x27B89B0", VA = "0x1827B95B0")]
		private void TWKPCUXPUVU(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x27B8EA0", Offset = "0x27B82A0", VA = "0x1827B8EA0", Slot = "89")]
		public override void PRWFYUQQWYS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x27B7EF0", Offset = "0x27B72F0", VA = "0x1827B7EF0", Slot = "90")]
		public override void JSQKIXLDVMI(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0xAD1510", Offset = "0xAD0910", VA = "0x180AD1510", Slot = "91")]
		public override bool OUFBYNAVPKQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x24EA050", Offset = "0x24E9450", VA = "0x1824EA050", Slot = "92")]
		public override bool CQRKDBDYOLF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x12F06F0", Offset = "0x12EFAF0", VA = "0x1812F06F0", Slot = "107")]
		public override bool WZQKNBGCNOY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x1D9E880", Offset = "0x1D9DC80", VA = "0x181D9E880", Slot = "108")]
		public override bool LSWCHWSRDEB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x1240400", Offset = "0x123F800", VA = "0x181240400", Slot = "93")]
		public override bool UBJFWTXKBYK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x27B90B0", Offset = "0x27B84B0", VA = "0x1827B90B0", Slot = "94")]
		public override void Play()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x27B9020", Offset = "0x27B8420", VA = "0x1827B9020", Slot = "95")]
		public override void Pause()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x27B4CB0", Offset = "0x27B40B0", VA = "0x1827B4CB0", Slot = "96")]
		public override void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x27B5B60", Offset = "0x27B4F60", VA = "0x1827B5B60", Slot = "109")]
		public override bool ATTDLPJBZCG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x27B8D90", Offset = "0x27B8190", VA = "0x1827B8D90", Slot = "110")]
		public override bool PBTOMSREBCU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x27B96E0", Offset = "0x27B8AE0", VA = "0x1827B96E0", Slot = "111")]
		public override bool TZACJECSAZW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x27B6C40", Offset = "0x27B6040", VA = "0x1827B6C40", Slot = "112")]
		public override bool FTPXYDLPPYQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x27B9140", Offset = "0x27B8540", VA = "0x1827B9140", Slot = "113")]
		public override bool QYPJLCQVMMM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x27B78D0", Offset = "0x27B6CD0", VA = "0x1827B78D0", Slot = "103")]
		public override double JPBUKFSTBYK()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x11F3F10", Offset = "0x11F3310", VA = "0x1811F3F10", Slot = "104")]
		public override int IXIQRDMBARJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0xDEBE60", Offset = "0xDEB260", VA = "0x180DEBE60", Slot = "105")]
		public override int JKVUMMABIBE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x1DED920", Offset = "0x1DECD20", VA = "0x181DED920", Slot = "106")]
		public override float IKNKSIXFUNG()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x27B6F80", Offset = "0x27B6380", VA = "0x1827B6F80", Slot = "116")]
		public override Texture GetTexture(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x27B6E40", Offset = "0x27B6240", VA = "0x1827B6E40", Slot = "117")]
		public override int GetTextureFrameCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x27B6F00", Offset = "0x27B6300", VA = "0x1827B6F00", Slot = "119")]
		public override long GetTextureTimeStamp()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x27B6E50", Offset = "0x27B6250", VA = "0x1827B6E50", Slot = "121")]
		public override float GetTexturePixelAspectRatio()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x20F30F0", Offset = "0x20F24F0", VA = "0x1820F30F0", Slot = "120")]
		public override bool RequiresVerticalFlip()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x27B7F10", Offset = "0x27B7310", VA = "0x1827B7F10", Slot = "127")]
		internal override StereoPacking KIEGSKTTUEH()
		{
			return default(StereoPacking);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x27B7F90", Offset = "0x27B7390", VA = "0x1827B7F90", Slot = "98")]
		public override void KQWCTKPVVHE(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x27BA080", Offset = "0x27B9480", VA = "0x1827BA080", Slot = "99")]
		public override void VGCDESBPAVS(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x27B97B0", Offset = "0x27B8BB0", VA = "0x1827B97B0", Slot = "100")]
		public override double UWEFRXYRRYG()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x27BA1A0", Offset = "0x27B95A0", VA = "0x1827BA1A0", Slot = "102")]
		public override void XXPPQZQEEVX(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x27B9530", Offset = "0x27B8930", VA = "0x1827B9530", Slot = "101")]
		public override float SWRUYARRZHT()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x27B6DB0", Offset = "0x27B61B0", VA = "0x1827B6DB0", Slot = "129")]
		public override void GBOXXEBBYZZ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x27A8AC0", Offset = "0x27A7EC0", VA = "0x1827A8AC0", Slot = "130")]
		public override bool FBTTYFUEXFH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x27BA450", Offset = "0x27B9850", VA = "0x1827BA450", Slot = "131")]
		public override void ZNABKYPKGCM(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x1258170", Offset = "0x1257570", VA = "0x181258170", Slot = "133")]
		public override float OODGIYRXVAA()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x27B5CC0", Offset = "0x27B50C0", VA = "0x1827B5CC0", Slot = "132")]
		public override void BKBCPTAAPVM(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x1CFD2E0", Offset = "0x1CFC6E0", VA = "0x181CFD2E0", Slot = "134")]
		public override float GetBalance()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x27B91D0", Offset = "0x27B85D0", VA = "0x1827B91D0", Slot = "153")]
		public override bool RLCBRZBNEYS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x27B6540", Offset = "0x27B5940", VA = "0x1827B6540", Slot = "114")]
		public override bool ENGZSIJLKGE(Camera a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x27B8DA0", Offset = "0x27B81A0", VA = "0x1827B8DA0", Slot = "140")]
		public override void PEJUSXNYDHC(Audio360ChannelMode a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x27B7130", Offset = "0x27B6530", VA = "0x1827B7130", Slot = "138")]
		public override void IDZCAJAONBS(Quaternion a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x27B9380", Offset = "0x27B8780", VA = "0x1827B9380", Slot = "139")]
		public override void SVNVFCUUOZL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x27B9720", Offset = "0x27B8B20", VA = "0x1827B9720", Slot = "141")]
		public override void UOMOSRCQTOR(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x27BA100", Offset = "0x27B9500", VA = "0x1827BA100", Slot = "142")]
		public override void WYWCQDCTPIZ(float a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x27B9480", Offset = "0x27B8880", VA = "0x1827B9480", Slot = "143")]
		public override void SWGEJVRZZBI(Quaternion a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x27B9830", Offset = "0x27B8C30", VA = "0x1827B9830", Slot = "146")]
		public override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x27B6430", Offset = "0x27B5830", VA = "0x1827B6430")]
		private void CPJBILKNFRQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x27B7950", Offset = "0x27B6D50", VA = "0x1827B7950")]
		private void JSNNSBCNIZU(IntPtr a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x27B8AB0", Offset = "0x27B7EB0", VA = "0x1827B8AB0", Slot = "150")]
		public override void LPNOFDYNEGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		private void SXNURWVKLWN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x27BA310", Offset = "0x27B9710", VA = "0x1827BA310", Slot = "147")]
		public override void YQLXBAUULJR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x27B9280", Offset = "0x27B8680", VA = "0x1827B9280", Slot = "148")]
		public override void Render()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "149")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x27B5AA0", Offset = "0x27B4EA0", VA = "0x1827B5AA0", Slot = "136")]
		public override int AHSNXXYMFKW(float[] a, int b, int c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x14D7A70", Offset = "0x14D6E70", VA = "0x1814D7A70", Slot = "151")]
		public override bool NWSKXJGKJBT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x27B8BD0", Offset = "0x27B7FD0", VA = "0x1827B8BD0")]
		private static void LTYJRFLPVSD(Native.RenderThreadEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x27B7020", Offset = "0x27B6420", VA = "0x1827B7020")]
		private static string HJRFRTPXVJB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x27B7FB0", Offset = "0x27B73B0", VA = "0x1827B7FB0", Slot = "159")]
		internal override bool KRMLTRSPRSZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x27B5BF0", Offset = "0x27B4FF0", VA = "0x1827B5BF0", Slot = "160")]
		internal override string BALTGVOWSAU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x27B8CF0", Offset = "0x27B80F0", VA = "0x1827B8CF0", Slot = "161")]
		internal override bool OBHCVFXUDXL(TrackType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x27B8B30", Offset = "0x27B7F30", VA = "0x1827B8B30", Slot = "162")]
		internal override int LTXAVEZJUXN(TrackType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x27B7540", Offset = "0x27B6940", VA = "0x1827B7540", Slot = "163")]
		internal override VXENMAJCWHS JFEOXYRXMIA(TrackType a, int b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x27B70D0", Offset = "0x27B64D0", VA = "0x1827B70D0", Slot = "144")]
		public override void HMDAAZQJNER(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x27BA0A0", Offset = "0x27B94A0", VA = "0x1827BA0A0", Slot = "145")]
		public override void VUCQPYXXXJA(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x27B8E30", Offset = "0x27B8230", VA = "0x1827B8E30")]
		private void PJKOMLKMXTG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x27B6B70", Offset = "0x27B5F70", VA = "0x1827B6B70")]
		private void FIWCGCUEPPB(TimeRange[] a, Native.TimeRangeTypes b)
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
	public sealed class FDEXHZNKOZA : ONEYUFGXDVK
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
			[Cpp2IlInjected.Address(RVA = "0x27BE6D0", Offset = "0x27BDAD0", VA = "0x1827BE6D0")]
			public static extern bool IsChangedTracks(IntPtr instance, TrackType trackType);

			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0x27BDD90", Offset = "0x27BD190", VA = "0x1827BDD90")]
			public static extern int GetTrackCount(IntPtr instance, TrackType trackType);

			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0x27BDF80", Offset = "0x27BD380", VA = "0x1827BDF80")]
			public static extern bool GetTrackInfo(IntPtr instance, TrackType trackType, int index, int uid, bool isActive, StringBuilder name, int maxNameLength, StringBuilder language, int maxLanguageLength);

			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0x27BE5D0", Offset = "0x27BD9D0", VA = "0x1827BE5D0")]
			public static extern bool IsChangedTextCue(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0x27BCE10", Offset = "0x27BC210", VA = "0x1827BCE10")]
			public static extern IntPtr GetCurrentTextCue(IntPtr instance);

			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0x27BD560", Offset = "0x27BC960", VA = "0x1827BD560")]
			private static extern IntPtr GetPluginVersionStringPointer();

			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0x27BE220", Offset = "0x27BD620", VA = "0x1827BE220")]
			public static string HJRFRTPXVJB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x27BC800", Offset = "0x27BBC00", VA = "0x1827BC800")]
			public static extern IntPtr CreatePlayer();

			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0x27BC8E0", Offset = "0x27BBCE0", VA = "0x1827BC8E0")]
			public static extern void DestroyPlayer(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0x27BF010", Offset = "0x27BE410", VA = "0x1827BF010")]
			public static extern bool OpenMedia(IntPtr playerInstance, string filePath, string httpHeader, FileFormat overrideFileFormat, bool startWithHighestBitrate, bool use10BitTextures);

			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0x27BC700", Offset = "0x27BBB00", VA = "0x1827BC700")]
			public static extern void CloseMedia(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003D7")]
			[Cpp2IlInjected.Address(RVA = "0x27BF2A0", Offset = "0x27BE6A0", VA = "0x1827BF2A0")]
			public static extern void Pause(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003D8")]
			[Cpp2IlInjected.Address(RVA = "0x27BF420", Offset = "0x27BE820", VA = "0x1827BF420")]
			public static extern void Play(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0x27BF980", Offset = "0x27BED80", VA = "0x1827BF980")]
			public static extern void SetAudioVolume(IntPtr playerInstance, float volume);

			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0x27BF530", Offset = "0x27BE930", VA = "0x1827BF530")]
			public static extern void SetAudioBalance(IntPtr playerInstance, float balance);

			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0x27C03E0", Offset = "0x27BF7E0", VA = "0x1827C03E0")]
			public static extern void SetPlaybackRate(IntPtr playerInstance, float rate);

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x27BF8F0", Offset = "0x27BECF0", VA = "0x1827BF8F0")]
			public static extern void SetAudioMuted(IntPtr playerInstance, bool muted);

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x27BE4D0", Offset = "0x27BD8D0", VA = "0x1827BE4D0")]
			public static extern bool IsAudioMuted(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x27BCC90", Offset = "0x27BC090", VA = "0x1827BCC90")]
			public static extern float GetAudioBalance(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x27BD360", Offset = "0x27BC760", VA = "0x1827BD360")]
			public static extern float GetPlaybackRate(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x27BFEE0", Offset = "0x27BF2E0", VA = "0x1827BFEE0")]
			public static extern void SetLooping(IntPtr playerInstance, bool looping);

			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0x27BD190", Offset = "0x27BC590", VA = "0x1827BD190")]
			public static extern int GetLastErrorCode(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0x27C07B0", Offset = "0x27BFBB0", VA = "0x1827C07B0")]
			public static extern void Update(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x27BD010", Offset = "0x27BC410", VA = "0x1827BD010")]
			public static extern double GetDuration(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x27BD7A0", Offset = "0x27BCBA0", VA = "0x1827BD7A0")]
			public static extern StereoPacking GetStereoPacking(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x27BCD90", Offset = "0x27BC190", VA = "0x1827BCD90")]
			public static extern double GetCurrentPosition(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x27BD290", Offset = "0x27BC690", VA = "0x1827BD290")]
			public static extern bool GetLatestFrame(IntPtr playerInstance, [Out] IntPtr leftEyeTexturePointer, [Out] IntPtr rightEyeTexturePointer, [Out] ulong frameTimeStamp, [Out] int width, [Out] int height);

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x27BD460", Offset = "0x27BC860", VA = "0x1827BD460")]
			public static extern PlaybackState GetPlaybackState(IntPtr playerInstance);

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x27BCC00", Offset = "0x27BC000", VA = "0x1827BCC00")]
			public static extern bool GetActiveVideoTrackInfo(IntPtr playerInstance, [Out] VideoTrack videoTrack);

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x27BFE50", Offset = "0x27BF250", VA = "0x1827BFE50")]
			public static extern void SetLiveOffset(IntPtr playerInstance, double seconds);

			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x27BF4A0", Offset = "0x27BE8A0", VA = "0x1827BF4A0")]
			public static extern void Seek(IntPtr playerInstance, SeekParams seekParams);

			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0x27BED80", Offset = "0x27BE180", VA = "0x1827BED80")]
			public static void KEDLZCXLSZL(IntPtr a, KJSKGOQCUBC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0x27C01F0", Offset = "0x27BF5F0", VA = "0x1827C01F0")]
			private static extern void SetNextAuthData(IntPtr playerInstance, AuthData authData);

			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x27BDAA0", Offset = "0x27BCEA0", VA = "0x1827BDAA0")]
			public static extern int GetTimeRanges(IntPtr playerInstance, [Out] TimeRange[] ranges, int rangeCount, TimeRangeTypes timeRangeType);

			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0x27BD6B0", Offset = "0x27BCAB0", VA = "0x1827BD6B0")]
			public static extern IntPtr GetRenderEventFunc();

			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0x27B4BC0", Offset = "0x27B3FC0", VA = "0x1827B4BC0")]
			public static void MAKVLQBLNAI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x27C0740", Offset = "0x27BFB40", VA = "0x1827C0740")]
			public static void TWLHGSMKGTD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		private class QCHWAELDRBQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000303")]
			public Texture2D BPSMVHLUYGV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000304")]
			public IntPtr GVZSJNNDFJA;

			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0x27C0950", Offset = "0x27BFD50", VA = "0x1827C0950")]
			public void GNIYJHEQVWX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0x27C0A40", Offset = "0x27BFE40", VA = "0x1827C0A40")]
			public QCHWAELDRBQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private bool ZJQYTKSNXCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private bool RRRKQAKCQHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		private float WLQPNPOWVPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private bool ZSCHREBWPJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private bool DMMTOSBBNCY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private KJSKGOQCUBC OWFOMLZQGSM;

		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private static bool CRHSAQVZIIU;

		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		private static string ILYBGMJNWHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		private ulong XJFMPTOTKMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private IntPtr NQGNRKUZFAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private QCHWAELDRBQ[] JXXAOPCDPGM;

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public KJSKGOQCUBC TGGDMVLUMIS
		{
			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x27B57E0", Offset = "0x27B4BE0", VA = "0x1827B57E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x27B5890", Offset = "0x27B4C90", VA = "0x1827B5890")]
		public FDEXHZNKOZA(MediaPlayer.OptionsWindows a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x27B3540", Offset = "0x27B2940", VA = "0x1827B3540")]
		public void CEPOBSMXDIU(MediaPlayer.OptionsWindows a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x27B4CF0", Offset = "0x27B40F0", VA = "0x1827B4CF0", Slot = "93")]
		public override bool UBJFWTXKBYK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x27B3820", Offset = "0x27B2C20", VA = "0x1827B3820", Slot = "149")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "151")]
		public override bool NWSKXJGKJBT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x27B50D0", Offset = "0x27B44D0", VA = "0x1827B50D0", Slot = "100")]
		public override double UWEFRXYRRYG()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x27B4390", Offset = "0x27B3790", VA = "0x1827B4390", Slot = "103")]
		public override double JPBUKFSTBYK()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x27B4C30", Offset = "0x27B4030", VA = "0x1827B4C30", Slot = "101")]
		public override float SWRUYARRZHT()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x27B3D40", Offset = "0x27B3140", VA = "0x1827B3D40", Slot = "116")]
		public override Texture GetTexture(int index = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x27B3CB0", Offset = "0x27B30B0", VA = "0x1827B3CB0", Slot = "115")]
		public override int GetTextureCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xBE6770", Offset = "0xBE5B70", VA = "0x180BE6770", Slot = "117")]
		public override int GetTextureFrameCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x27B43C0", Offset = "0x27B37C0", VA = "0x1827B43C0", Slot = "127")]
		internal override StereoPacking KIEGSKTTUEH()
		{
			return default(StereoPacking);
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x27B4880", Offset = "0x27B3C80", VA = "0x1827B4880", Slot = "82")]
		public override string MBCXYFGRZEC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x27B5740", Offset = "0x27B4B40", VA = "0x1827B5740", Slot = "83")]
		public override string YGUCWLXALHQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x27B3DF0", Offset = "0x27B31F0", VA = "0x1827B3DF0", Slot = "106")]
		public override float IKNKSIXFUNG()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x27B3EA0", Offset = "0x27B32A0", VA = "0x1827B3EA0", Slot = "104")]
		public override int IXIQRDMBARJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x27B42C0", Offset = "0x27B36C0", VA = "0x1827B42C0", Slot = "105")]
		public override int JKVUMMABIBE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x133D1E0", Offset = "0x133C5E0", VA = "0x18133D1E0", Slot = "133")]
		public override float OODGIYRXVAA()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x27B34B0", Offset = "0x27B28B0", VA = "0x1827B34B0", Slot = "132")]
		public override void BKBCPTAAPVM(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x27B3C30", Offset = "0x27B3030", VA = "0x1827B3C30", Slot = "134")]
		public override float GetBalance()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x27B5670", Offset = "0x27B4A70", VA = "0x1827B5670", Slot = "107")]
		public override bool WZQKNBGCNOY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x27B37F0", Offset = "0x27B2BF0", VA = "0x1827B37F0", Slot = "92")]
		public override bool CQRKDBDYOLF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x27B47B0", Offset = "0x27B3BB0", VA = "0x1827B47B0", Slot = "108")]
		public override bool LSWCHWSRDEB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x27B4BA0", Offset = "0x27B3FA0", VA = "0x1827B4BA0", Slot = "113")]
		public override bool QYPJLCQVMMM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x27B3AF0", Offset = "0x27B2EF0", VA = "0x1827B3AF0", Slot = "112")]
		public override bool FTPXYDLPPYQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0xBBDC80", Offset = "0xBBD080", VA = "0x180BBDC80", Slot = "91")]
		public override bool OUFBYNAVPKQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x27B3990", Offset = "0x27B2D90", VA = "0x1827B3990", Slot = "130")]
		public override bool FBTTYFUEXFH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x27B4CD0", Offset = "0x27B40D0", VA = "0x1827B4CD0", Slot = "111")]
		public override bool TZACJECSAZW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x27B4960", Offset = "0x27B3D60", VA = "0x1827B4960", Slot = "110")]
		public override bool PBTOMSREBCU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x27B33C0", Offset = "0x27B27C0", VA = "0x1827B33C0", Slot = "109")]
		public override bool ATTDLPJBZCG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x27B3BA0", Offset = "0x27B2FA0", VA = "0x1827B3BA0", Slot = "129")]
		public override void GBOXXEBBYZZ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x27B4560", Offset = "0x27B3960", VA = "0x1827B4560", Slot = "84")]
		public override bool LDWDUNPVTOO(string a, long b, string c, MediaHints d, int e = 0, bool f = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x27B49F0", Offset = "0x27B3DF0", VA = "0x1827B49F0", Slot = "89")]
		public override void PRWFYUQQWYS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x27B4AA0", Offset = "0x27B3EA0", VA = "0x1827B4AA0", Slot = "95")]
		public override void Pause()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x27B4B20", Offset = "0x27B3F20", VA = "0x1827B4B20", Slot = "94")]
		public override void Play()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x27B4BC0", Offset = "0x27B3FC0", VA = "0x1827B4BC0", Slot = "148")]
		public override void Render()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x27B4D10", Offset = "0x27B4110", VA = "0x1827B4D10")]
		private void UOGPIQSGDAU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "120")]
		public override bool RequiresVerticalFlip()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x27B4440", Offset = "0x27B3840", VA = "0x1827B4440", Slot = "98")]
		public override void KQWCTKPVVHE(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x27B55F0", Offset = "0x27B49F0", VA = "0x1827B55F0", Slot = "99")]
		public override void VGCDESBPAVS(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x27B43A0", Offset = "0x27B37A0", VA = "0x1827B43A0", Slot = "90")]
		public override void JSQKIXLDVMI(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x27B56B0", Offset = "0x27B4AB0", VA = "0x1827B56B0", Slot = "102")]
		public override void XXPPQZQEEVX(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x27B57C0", Offset = "0x27B4BC0", VA = "0x1827B57C0", Slot = "131")]
		public override void ZNABKYPKGCM(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x27B4CB0", Offset = "0x27B40B0", VA = "0x1827B4CB0", Slot = "96")]
		public override void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x27B4980", Offset = "0x27B3D80", VA = "0x1827B4980")]
		private void PJKOMLKMXTG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x27B3A20", Offset = "0x27B2E20", VA = "0x1827B3A20")]
		private void FIWCGCUEPPB(TimeRange[] a, Native.TimeRangeTypes b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x27B5150", Offset = "0x27B4550", VA = "0x1827B5150", Slot = "146")]
		public override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x27B3D90", Offset = "0x27B3190", VA = "0x1827B3D90", Slot = "144")]
		public override void HMDAAZQJNER(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x27B5610", Offset = "0x27B4A10", VA = "0x1827B5610", Slot = "145")]
		public override void VUCQPYXXXJA(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x27B48D0", Offset = "0x27B3CD0", VA = "0x1827B48D0", Slot = "161")]
		internal override bool OBHCVFXUDXL(TrackType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x27B47F0", Offset = "0x27B3BF0", VA = "0x1827B47F0", Slot = "162")]
		internal override int LTXAVEZJUXN(TrackType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x27B3F70", Offset = "0x27B3370", VA = "0x1827B3F70", Slot = "163")]
		internal override VXENMAJCWHS JFEOXYRXMIA(TrackType a, int b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x27B44D0", Offset = "0x27B38D0", VA = "0x1827B44D0", Slot = "159")]
		internal override bool KRMLTRSPRSZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x27B33E0", Offset = "0x27B27E0", VA = "0x1827B33E0", Slot = "160")]
		internal override string BALTGVOWSAU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x27B3570", Offset = "0x27B2970", VA = "0x1827B3570")]
		public static bool CEXCOZBWFIC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x27B5770", Offset = "0x27B4B70", VA = "0x1827B5770")]
		public static void YMBBWKAHIZO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class YVFCFRRGGFO
	{
		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public string NDLHNVCRWBD
		{
			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
		internal YVFCFRRGGFO(string a)
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
	public class VXENMAJCWHS
	{
		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public int RUSNWMDAMFC
		{
			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		private TrackType ARKQIXRJBFH
		{
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0xCDF260", Offset = "0xCDE660", VA = "0x180CDF260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		private string DRFCVJECLED
		{
			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public string NSNROSXPJBX
		{
			[Cpp2IlInjected.Token(Token = "0x60003FB")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003FC")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public string YFSZBQTPKCY
		{
			[Cpp2IlInjected.Token(Token = "0x60003FD")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		private bool FSIOGHERBID
		{
			[Cpp2IlInjected.Token(Token = "0x60003FF")]
			[Cpp2IlInjected.Address(RVA = "0xAF9170", Offset = "0xAF8570", VA = "0x180AF9170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x27C4950", Offset = "0x27C3D50", VA = "0x1827C4950")]
		internal VXENMAJCWHS(TrackType a, int b, string c, string d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x27C4890", Offset = "0x27C3C90", VA = "0x1827C4890")]
		protected string ZNYXWJIIQSP()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public abstract class VHTSOTEKTBD : IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public virtual TrackType ARKQIXRJBFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000401")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(TrackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public abstract int ULFDSOUXGUF
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
		internal abstract void Add(VXENMAJCWHS track);

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(Slot = "10")]
		internal abstract void BCDSAYHDXZJ(VXENMAJCWHS a);

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		protected VHTSOTEKTBD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[DefaultMember("Item")]
	public class IRKDLIXQXRY<a> : VHTSOTEKTBD where a : VXENMAJCWHS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		internal List<a> KHPOPTPLOBZ;

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		internal a ONULLSHXLED
		{
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public override int ULFDSOUXGUF
		{
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0x11C60F0", Offset = "0x11C54F0", VA = "0x1811C60F0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x5026370", Offset = "0x5025770", VA = "0x185026370")]
		internal IRKDLIXQXRY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x5026310", Offset = "0x5025710", VA = "0x185026310", Slot = "7")]
		public override IEnumerator GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x50262B0", Offset = "0x50256B0", VA = "0x1850262B0", Slot = "8")]
		internal override void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x5026180", Offset = "0x5025580", VA = "0x185026180", Slot = "9")]
		internal override void Add(VXENMAJCWHS track)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x5026250", Offset = "0x5025650", VA = "0x185026250", Slot = "10")]
		internal override void BCDSAYHDXZJ(VXENMAJCWHS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class YZRLMDRUQVT : IRKDLIXQXRY<VEKVLNQSMCA>
	{
		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public override TrackType ARKQIXRJBFH
		{
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "5")]
			get
			{
				return default(TrackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x27C5760", Offset = "0x27C4B60", VA = "0x1827C5760")]
		public YZRLMDRUQVT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class ZHXZVHGWAAE : IRKDLIXQXRY<SZKZLYCDZJJ>
	{
		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public override TrackType ARKQIXRJBFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0xB4FBD0", Offset = "0xB4EFD0", VA = "0x180B4FBD0", Slot = "5")]
			get
			{
				return default(TrackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x27C57A0", Offset = "0x27C4BA0", VA = "0x1827C57A0")]
		public ZHXZVHGWAAE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class CTZRPWGCVLD : IRKDLIXQXRY<NWBYSLOFEME>
	{
		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public override TrackType ARKQIXRJBFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0xAFEDD0", Offset = "0xAFE1D0", VA = "0x180AFEDD0", Slot = "5")]
			get
			{
				return default(TrackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x27B2F70", Offset = "0x27B2370", VA = "0x1827B2F70")]
		public CTZRPWGCVLD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class VEKVLNQSMCA : VXENMAJCWHS
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x27C1BA0", Offset = "0x27C0FA0", VA = "0x1827C1BA0")]
		internal VEKVLNQSMCA(int a, string b, string c, bool d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class SZKZLYCDZJJ : VXENMAJCWHS
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x27C0A50", Offset = "0x27BFE50", VA = "0x1827C0A50")]
		internal SZKZLYCDZJJ(int a, string b, string c, bool d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class NWBYSLOFEME : VXENMAJCWHS
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x27BC3D0", Offset = "0x27BB7D0", VA = "0x1827BC3D0")]
		internal NWBYSLOFEME(int a, string b, string c, bool d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public interface HRVALWDMQRW
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public interface OEDGZIWDWIJ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public interface XRIYOSNZLQG
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public static class IYSQKTEEQOL
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
		[Cpp2IlInjected.Address(RVA = "0x27BAEC0", Offset = "0x27BA2C0", VA = "0x1827BAEC0")]
		public static Func<float, float> LMLQVQRUKYW(Preset a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x27BB510", Offset = "0x27BA910", VA = "0x1827BB510")]
		public static float WPMXQNGNYXI(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x27BB660", Offset = "0x27BAA60", VA = "0x1827BB660")]
		public static float ZOKUMWAWOYP(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x27BB5E0", Offset = "0x27BA9E0", VA = "0x1827BB5E0")]
		public static float ZALNSVRMKGW(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x27BAD00", Offset = "0x27BA100", VA = "0x1827BAD00")]
		public static float BJZDKIOVUPO(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static float XYHQBPGSVCP(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x27BAE60", Offset = "0x27BA260", VA = "0x1827BAE60")]
		public static float JAUKATXQGJI(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x27BAD20", Offset = "0x27BA120", VA = "0x1827BAD20")]
		public static float BOBRVWFQOBP(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x27BADE0", Offset = "0x27BA1E0", VA = "0x1827BADE0")]
		public static float FOZLNZEGBGM(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x27BB3F0", Offset = "0x27BA7F0", VA = "0x1827BB3F0")]
		public static float SKCHYAARAXT(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x27BB6A0", Offset = "0x27BAAA0", VA = "0x1827BB6A0")]
		public static float ZVMCDOABOEA(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x27BAD60", Offset = "0x27BA160", VA = "0x1827BAD60")]
		public static float CIIJGYSPUFJ(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x27BB3A0", Offset = "0x27BA7A0", VA = "0x1827BB3A0")]
		public static float NRZRTRLDCDG(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x27BB3B0", Offset = "0x27BA7B0", VA = "0x1827BB3B0")]
		public static float RUGZBZHTPFD(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x27BB520", Offset = "0x27BA920", VA = "0x1827BB520")]
		public static float YIPPSPHNHVA(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x27BAE70", Offset = "0x27BA270", VA = "0x1827BAE70")]
		public static float KKIFOLXLTBC(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x27BAE80", Offset = "0x27BA280", VA = "0x1827BAE80")]
		public static float KYTPNQYUOAV(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x27BB490", Offset = "0x27BA890", VA = "0x1827BB490")]
		public static float VZWCSBBXIZA(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x27BB5A0", Offset = "0x27BA9A0", VA = "0x1827BB5A0")]
		public static float YNAKCQOGMOF(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x27BACB0", Offset = "0x27BA0B0", VA = "0x1827BACB0")]
		public static float ASEFNPYAXDE(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x27BB400", Offset = "0x27BA800", VA = "0x1827BB400")]
		public static float UGFDCWRAKRF(float a)
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
		[Cpp2IlInjected.Address(RVA = "0x27BAAF0", Offset = "0x27B9EF0", VA = "0x1827BAAF0")]
		public bool QFDTENETOAJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x27BAA60", Offset = "0x27B9E60", VA = "0x1827BAA60")]
		public string ALBXOFPAGXA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x27BABE0", Offset = "0x27B9FE0", VA = "0x1827BABE0")]
		public static bool TJTYNZBKWRC(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x27BAB30", Offset = "0x27B9F30", VA = "0x1827BAB30")]
		private static bool SWBAPLHGNIF(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x27BABA0", Offset = "0x27B9FA0", VA = "0x1827BABA0")]
		private bool TJTYNZBKWRC()
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
		[Cpp2IlInjected.Address(RVA = "0x27BA960", Offset = "0x27B9D60", VA = "0x1827BA960", Slot = "4")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x27BA780", Offset = "0x27B9B80", VA = "0x1827BA780")]
		public string ALBXOFPAGXA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x27BA9E0", Offset = "0x27B9DE0", VA = "0x1827BA9E0")]
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
		private byte[] XCWDESBVXXX;

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public byte[] overrideDecryptionKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x27BBCA0", Offset = "0x27BB0A0", VA = "0x1827BBCA0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public KeyAuthData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class VKOANINGYYR
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		private class UUNFUTKOYRQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			public RenderTexture BPSMVHLUYGV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			public long KNGASNVNQGS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			public bool GUUABVQAXFJ;

			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public UUNFUTKOYRQ()
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
		private List<UUNFUTKOYRQ[]> IIIBOADOUUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private MediaPlayer KNSYIJCURDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private RenderTexture[] QDZRBJEGQWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private int OOUFGGMHABP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		private int TIWAXCPZIGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		private int SKEYVHNEOAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		private long PBONTGEDRWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		private float NORJAWCHUXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		private Material FODROPFIYOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private ResampleMode TAMKVBHARTJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private string ZMKIMTJCSMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		private long ZYNAMHRLFYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		private int CWODKLNGXIZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private long OUNJCWVNBUW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private int UIYTHITJSOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private long KJOAWAYYEAB;

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private const string DWUTQYLMIHE = "_t";

		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private const string EMZPPJAQSQR = "_AfterTex";

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private int HCRYJWWKGSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private int DILCGHTCDKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private float ATDTVKZOFWV;

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		private float MKALLMAMFLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000439")]
			[Cpp2IlInjected.Address(RVA = "0x13592D0", Offset = "0x13586D0", VA = "0x1813592D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		private long GQLDPPYLMYH
		{
			[Cpp2IlInjected.Token(Token = "0x600043A")]
			[Cpp2IlInjected.Address(RVA = "0x27C2640", Offset = "0x27C1A40", VA = "0x1827C2640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public Texture[] KUWKIHWINJY
		{
			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x27C3430", Offset = "0x27C2830", VA = "0x1827C3430")]
		public void QNZJRMQQKHI(MediaPlayer a, MediaPlayerEvent.EventType b, ErrorCode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x27C45C0", Offset = "0x27C39C0", VA = "0x1827C45C0")]
		public VKOANINGYYR(MediaPlayer a, string b, int c = 2, ResampleMode d = ResampleMode.LINEAR)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x27C35F0", Offset = "0x27C29F0", VA = "0x1827C35F0")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x27C3510", Offset = "0x27C2910", VA = "0x1827C3510")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x27C2040", Offset = "0x27C1440", VA = "0x1827C2040")]
		private void DQFWEUJFSJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x27C28F0", Offset = "0x27C1CF0", VA = "0x1827C28F0")]
		private void IGBZDUBXMGX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x27C2290", Offset = "0x27C1690", VA = "0x1827C2290")]
		private bool DVHSDEPWKZC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x27C43A0", Offset = "0x27C37A0", VA = "0x1827C43A0")]
		private int ZXUYJWMWIHT(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x27C1BD0", Offset = "0x27C0FD0", VA = "0x1827C1BD0")]
		private int BAAPKEPZCTH(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x27C30E0", Offset = "0x27C24E0", VA = "0x1827C30E0")]
		private void LUNWPOTBMFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x27C3610", Offset = "0x27C2A10", VA = "0x1827C3610")]
		private void TGQWKBGFFMV(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x27C1D90", Offset = "0x27C1190", VA = "0x1827C1D90")]
		private void CTBWOKTDXJA(int a, int b, int c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x27C2EB0", Offset = "0x27C22B0", VA = "0x1827C2EB0")]
		private void KKIJWUSRDWG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x27C3770", Offset = "0x27C2B70", VA = "0x1827C3770")]
		private void ULJYKANICXX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x27C2650", Offset = "0x27C1A50", VA = "0x1827C2650")]
		private float EKQEKRIQNXY()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x27C3870", Offset = "0x27C2C70", VA = "0x1827C3870")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x27C3410", Offset = "0x27C2810", VA = "0x1827C3410")]
		public void MJJYLRLXGFT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class OCLWTVKEBXQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public int LJHVHRDBFNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public string BLEXTFWLPIZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public double ETBAXCJLCCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public double RPUJHMSFVPC;

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x27C0930", Offset = "0x27BFD30", VA = "0x1827C0930")]
		public bool KHCTTCSSKRB(double a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public OCLWTVKEBXQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class BGEIFARVLDV
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x27B2E30", Offset = "0x27B2230", VA = "0x1827B2E30")]
		private static double YNUONYQPMLY(string a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x27B2A30", Offset = "0x27B1E30", VA = "0x1827B2A30")]
		public static List<OCLWTVKEBXQ> NGZJKKTKHMJ(string a)
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
		public int OQGVUCEGDTZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0x27BBD80", Offset = "0x27BB180", VA = "0x1827BBD80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x27BBDB0", Offset = "0x27BB1B0", VA = "0x1827BBDB0")]
		public LazyShaderProperty(string name)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public class AOUBRUWDRTL
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
		public static readonly LazyShaderProperty HZKHCOQSHHU;

		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public static readonly LazyShaderProperty JNINZRAGWZI;

		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public static readonly LazyShaderProperty BPIRDFVYZYX;

		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public static readonly LazyShaderProperty RJSUQVZNIDY;

		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public static readonly LazyShaderProperty TGBGGCCEGMG;

		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public static readonly LazyShaderProperty UUHZFYVSEZB;

		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public static readonly LazyShaderProperty FBRATFIJTKU;

		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public static readonly LazyShaderProperty RHZTODBREJD;

		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public static readonly LazyShaderProperty PKNYYGYDUHZ;

		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public static readonly LazyShaderProperty QPUFJAJDIYD;

		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public static string BMUEFNEBLGH;

		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public static readonly LazyShaderProperty BLKWIDUFSJV;

		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public static readonly LazyShaderProperty UIRXFQGCUXF;

		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public static readonly LazyShaderProperty CNQUBYCVWNH;

		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public static readonly LazyShaderProperty TGCEXSJEKBC;

		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public static readonly LazyShaderProperty ZRAJNAVIIJF;

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x27B1C70", Offset = "0x27B1070", VA = "0x1827B1C70")]
		public static Material QUBCMJGILTV(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x27B2410", Offset = "0x27B1810", VA = "0x1827B2410")]
		public static void WWHVXVNQFVW(Material a, VideoMapping b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x27B1190", Offset = "0x27B0590", VA = "0x1827B1190")]
		public static void JLJKGLZQELQ(Material a, StereoPacking b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x27B22D0", Offset = "0x27B16D0", VA = "0x1827B22D0")]
		public static void RMBLRYVLIFK(Material a, AlphaPacking b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x27B0FA0", Offset = "0x27B03A0", VA = "0x1827B0FA0")]
		public static void GQSTBZPDZGB(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x27B1B70", Offset = "0x27B0F70", VA = "0x1827B1B70")]
		public static void QBHKNXPAMRN(Material a, Matrix4x4 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x27B1AC0", Offset = "0x27B0EC0", VA = "0x1827B1AC0")]
		public static void PTOEBHHFTNN(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x27B1030", Offset = "0x27B0430", VA = "0x1827B1030")]
		public static Texture GetTexture(MediaPlayer mediaPlayer, int textureIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x27B04F0", Offset = "0x27AF8F0", VA = "0x1827B04F0")]
		public static void CCADCKESFYL(Material a, MediaPlayer b, int c = -1, [Optional] Texture d, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x27B0AA0", Offset = "0x27AFEA0", VA = "0x1827B0AA0")]
		internal static void GIDBFVTJINY(Material a, bool b, bool c, Matrix4x4 d, Texture e, Matrix4x4 f, VideoMapping g = VideoMapping.Normal, StereoPacking h = StereoPacking.None, AlphaPacking i = AlphaPacking.None)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x27B0220", Offset = "0x27AF620", VA = "0x1827B0220")]
		public static void ADJOPENBSMY(Material a, VideoResolveOptions b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x27B1D00", Offset = "0x27B1100", VA = "0x1827B1D00")]
		public static RenderTexture RCEAIBKDXNR(Material a, RenderTexture b, AFEJTIYLLFY c, ResolveFlags d, ScaleMode e = ScaleMode.StretchToFill)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x27B1440", Offset = "0x27B0840", VA = "0x1827B1440")]
		public static void KIBRKENKXGM(AlphaPacking a, StereoPacking b, StereoEye c, float d, Matrix4x4 e, int f, int g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x27B15C0", Offset = "0x27B09C0", VA = "0x1827B15C0")]
		public static void NEIADZDELST(Rect a, Texture b, ScaleMode c, AlphaPacking d, float e, Material f)
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
	public class WQRZHXKEVMT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private int FYVVGSXEHPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private int WVGERWHDTTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private int NGGITNHRAYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		private int QUXGPHVYAFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		private int JKIARPCKLNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private CodecType GQWSKHWQYMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private float TONIUOLCZQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private VideoRange QSQCERBWQOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private CodecType CAGRGHHUWOK;

		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private static WQRZHXKEVMT EORDGLWBYWL;

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x27C4BF0", Offset = "0x27C3FF0", VA = "0x1827C4BF0")]
		public WQRZHXKEVMT(int a, int b, int c, int d, int e = 0, CodecType f = CodecType.unknown, float g = 0f, VideoRange h = VideoRange.SDR, CodecType i = CodecType.unknown)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[DefaultMember("Item")]
	public interface GYOCHCOALGX : IEnumerable
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
