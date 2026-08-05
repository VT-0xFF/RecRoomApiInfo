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
	public Material GOHKLGDEHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2A77A90", Offset = "0x2A76090", VA = "0x182A77A90")]
	private void OnWillRenderObject()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xAA8970", Offset = "0xAA6F70", VA = "0x180AA8970")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public MediaPath MediaPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAA70F0", Offset = "0xAA56F0", VA = "0x180AA70F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public MediaHints Hints
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x16B72A0", Offset = "0x16B58A0", VA = "0x1816B72A0")]
			get
			{
				return default(MediaHints);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x2A877B0", Offset = "0x2A85DB0", VA = "0x182A877B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2A87660", Offset = "0x2A85C60", VA = "0x182A87660")]
		public MediaReference LHHLNBCDGDO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2A875D0", Offset = "0x2A85BD0", VA = "0x182A875D0")]
		public MediaReference GLBNGCDADFA(MONLJLHHPDC CAHJAEKGIEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2A876D0", Offset = "0x2A85CD0", VA = "0x182A876D0")]
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
		private enum MNNEDNGDKMI
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
		private GameObject NCIPPGPDEPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool OHJPMOIPJEG;

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
		private Texture BALIJCPADFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private MPEDAGENPGA AFELFKACALC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private MPEDAGENPGA LFELLNPEAKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private Texture GCEOGCKCKPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Vector2 ENFOFBKAJJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Vector2 FCJJJMBAGNL;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Color OHCDKBNKNHP
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xF75380", Offset = "0xF73980", VA = "0x180F75380")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x2A791A0", Offset = "0x2A777A0", VA = "0x182A791A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Texture JAKHKFPCPLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAA5620", Offset = "0xAA3C20", VA = "0x180AA5620")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2A793F0", Offset = "0x2A779F0", VA = "0x182A793F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Texture APEFIKEHCKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xAA55B0", Offset = "0xAA3BB0", VA = "0x180AA55B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2A78E90", Offset = "0x2A77490", VA = "0x182A78E90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float CMMDFGEKNAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x12C9FF0", Offset = "0x12C85F0", VA = "0x1812C9FF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2A78D10", Offset = "0x2A77310", VA = "0x182A78D10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Camera AECJMHFPIKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xAA54C0", Offset = "0xAA3AC0", VA = "0x180AA54C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2A78DC0", Offset = "0x2A773C0", VA = "0x182A78DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public VideoAspectRatio BEBHJMMBMHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xD6B700", Offset = "0xD69D00", VA = "0x180D6B700")]
			get
			{
				return default(VideoAspectRatio);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x2A794B0", Offset = "0x2A77AB0", VA = "0x182A794B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Vector2 PABHKGEJAPC
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2A78CB0", Offset = "0x2A772B0", VA = "0x182A78CB0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2A790C0", Offset = "0x2A776C0", VA = "0x182A790C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Vector2 ALOKCKBMFDB
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x12CA000", Offset = "0x12C8600", VA = "0x1812CA000")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2A78F50", Offset = "0x2A77550", VA = "0x182A78F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Texture2D NOMGPMHJGDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xAB0560", Offset = "0xAAEB60", VA = "0x180AB0560")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x2A79030", Offset = "0x2A77630", VA = "0x182A79030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public string CJCBHGMFJPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xAB0450", Offset = "0xAAEA50", VA = "0x180AB0450")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2A79300", Offset = "0x2A77900", VA = "0x182A79300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Vector2 CDOMHMKBDBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2A78CD0", Offset = "0x2A772D0", VA = "0x182A78CD0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2A79260", Offset = "0x2A77860", VA = "0x182A79260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Vector2 KHGBNADOONJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2A78CF0", Offset = "0x2A772F0", VA = "0x182A78CF0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x2A792B0", Offset = "0x2A778B0", VA = "0x182A792B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private Vector2 GIOAMDLGLGP
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x2A78030", Offset = "0x2A76630", VA = "0x182A78030")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2A779A0", Offset = "0x2A75FA0", VA = "0x182A779A0")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2A782F0", Offset = "0x2A768F0", VA = "0x182A782F0", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2A782A0", Offset = "0x2A768A0", VA = "0x182A782A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2A78980", Offset = "0x2A76F80", VA = "0x182A78980")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2A77CA0", Offset = "0x2A762A0", VA = "0x182A77CA0")]
		public Mesh CreateQuadMesh()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2A77B40", Offset = "0x2A76140", VA = "0x182A77B40")]
		public void CreateMaterial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2A783C0", Offset = "0x2A769C0", VA = "0x182A783C0", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xB0A730", Offset = "0xB08D30", VA = "0x180B0A730")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2A786C0", Offset = "0x2A76CC0", VA = "0x182A786C0")]
		public void UpdateMaterialProperties(int AMMKGILEHBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2A77460", Offset = "0x2A75A60", VA = "0x182A77460", Slot = "8")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2A76D50", Offset = "0x2A75350", VA = "0x182A76D50")]
		private void AJIIBIKJMHA(Texture BDFJHOHMCFM, bool FMEDLFGOHIB, int CFOILFKCBDC = 0, MNNEDNGDKMI NOJLCOIEHFO = MNNEDNGDKMI.Left)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2A77220", Offset = "0x2A75820", VA = "0x182A77220", Slot = "6")]
		protected override void APNCBJEIMBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2A78100", Offset = "0x2A76700", VA = "0x182A78100", Slot = "7")]
		protected override void JMOFMHLIFHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2A78B30", Offset = "0x2A77130", VA = "0x182A78B30")]
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
		private enum EEBNCOAMLDI
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
		private Texture BALIJCPADFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private MPEDAGENPGA AFELFKACALC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private MPEDAGENPGA LFELLNPEAKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private Texture GCEOGCKCKPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private Vector2 ENFOFBKAJJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private Vector2 FCJJJMBAGNL;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Texture2D NOMGPMHJGDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xAA5720", Offset = "0xAA3D20", VA = "0x180AA5720")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x2A7A3B0", Offset = "0x2A789B0", VA = "0x182A7A3B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Material GOHKLGDEHHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xAA54B0", Offset = "0xAA3AB0", VA = "0x180AA54B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x2A7A430", Offset = "0x2A78A30", VA = "0x182A7A430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string CJCBHGMFJPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xAA5620", Offset = "0xAA3C20", VA = "0x180AA5620")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x2A7A550", Offset = "0x2A78B50", VA = "0x182A7A550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector2 CDOMHMKBDBB
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x2A7A370", Offset = "0x2A78970", VA = "0x182A7A370")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x2A7A4B0", Offset = "0x2A78AB0", VA = "0x182A7A4B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Vector2 KHGBNADOONJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x2A7A390", Offset = "0x2A78990", VA = "0x182A7A390")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x2A7A500", Offset = "0x2A78B00", VA = "0x182A7A500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xB0A730", Offset = "0xB08D30", VA = "0x180B0A730")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2A79B70", Offset = "0x2A78170", VA = "0x182A79B70", Slot = "8")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2A79560", Offset = "0x2A77B60", VA = "0x182A79560")]
		private void AJIIBIKJMHA(Texture BDFJHOHMCFM, bool FMEDLFGOHIB, int CFOILFKCBDC = 0, EEBNCOAMLDI NOJLCOIEHFO = EEBNCOAMLDI.Left)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2A79970", Offset = "0x2A77F70", VA = "0x182A79970", Slot = "6")]
		protected override void APNCBJEIMBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2A7A0A0", Offset = "0x2A786A0", VA = "0x182A7A0A0", Slot = "7")]
		protected override void JMOFMHLIFHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2A7A210", Offset = "0x2A78810", VA = "0x182A7A210")]
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
		private enum KLEPJCOIHPP
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
		private Texture BALIJCPADFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private MPEDAGENPGA AFELFKACALC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private MPEDAGENPGA LFELLNPEAKN;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Texture2D NOMGPMHJGDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xAA5720", Offset = "0xAA3D20", VA = "0x180AA5720")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x2A7B1B0", Offset = "0x2A797B0", VA = "0x182A7B1B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Renderer MJALDEFIJPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xAA54B0", Offset = "0xAA3AB0", VA = "0x180AA54B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x2A7B0D0", Offset = "0x2A796D0", VA = "0x182A7B0D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public int IIKKDMOLKAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xB28EF0", Offset = "0xB274F0", VA = "0x180B28EF0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xB28E50", Offset = "0xB27450", VA = "0x180B28E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public string CJCBHGMFJPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xAA55B0", Offset = "0xAA3BB0", VA = "0x180AA55B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x2A7B520", Offset = "0x2A79B20", VA = "0x182A7B520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector2 CDOMHMKBDBB
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x2A7A390", Offset = "0x2A78990", VA = "0x182A7A390")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x2A7A500", Offset = "0x2A78B00", VA = "0x182A7A500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector2 KHGBNADOONJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x2A7B4B0", Offset = "0x2A79AB0", VA = "0x182A7B4B0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x2A7B4D0", Offset = "0x2A79AD0", VA = "0x182A7B4D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2A7B1B0", Offset = "0x2A797B0", VA = "0x182A7B1B0")]
		private void GHHJMPOIKCJ(Texture2D BDFJHOHMCFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2A7B0D0", Offset = "0x2A796D0", VA = "0x182A7B0D0")]
		private void FEDKDCDHFBO(Renderer MAFJPEPPLNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xB0A730", Offset = "0xB08D30", VA = "0x180B0A730")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2A7AB50", Offset = "0x2A79150", VA = "0x182A7AB50", Slot = "8")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2A7A620", Offset = "0x2A78C20", VA = "0x182A7A620")]
		private void AJIIBIKJMHA(Texture BDFJHOHMCFM, bool FMEDLFGOHIB, int CFOILFKCBDC, KLEPJCOIHPP NOJLCOIEHFO = KLEPJCOIHPP.Left, int JJCENJEBMDL = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2A7B290", Offset = "0x2A79890", VA = "0x182A7B290", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2A7B260", Offset = "0x2A79860", VA = "0x182A7B260", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2A7AAB0", Offset = "0x2A790B0", VA = "0x182A7AAB0", Slot = "6")]
		protected override void APNCBJEIMBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2A7B3D0", Offset = "0x2A799D0", VA = "0x182A7B3D0")]
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
		private const int JDOFHKCCLEK = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[Range(0f, 1f)]
		[SerializeField]
		private float[] _channels;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float[] AMIDPEGODFM
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2A7B8A0", Offset = "0x2A79EA0", VA = "0x182A7B8A0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2A7B5F0", Offset = "0x2A79BF0", VA = "0x182A7B5F0")]
		private void GFIKNGMLDCE(int FADIKNLEEOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2A7B6F0", Offset = "0x2A79CF0", VA = "0x182A7B6F0")]
		private void OnAudioFilterRead(float[] CDDIADBJAOB, int NOJMAMBJJKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xAA8970", Offset = "0xAA6F70", VA = "0x180AA8970")]
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
		public enum JPJOAMKHIAO
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
		private JPJOAMKHIAO _audioOutputMode;

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
		private int ANNAEGGMOHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private AudioSource GABELGNIMGG;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public MediaPlayer IIKNGMIOCAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2A7C420", Offset = "0x2A7AA20", VA = "0x182A7C420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public JPJOAMKHIAO AFKOCDDDKML
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAFC970", Offset = "0xAFAF70", VA = "0x180AFC970")]
			get
			{
				return default(JPJOAMKHIAO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xAFD490", Offset = "0xAFBA90", VA = "0x180AFD490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int AHHKDNAHPGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xC582A0", Offset = "0xC568A0", VA = "0x180C582A0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x10B1C80", Offset = "0x10B0280", VA = "0x1810B1C80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2A7B990", Offset = "0x2A79F90", VA = "0x182A7B990")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2A7C290", Offset = "0x2A7A890", VA = "0x182A7C290")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2A7C080", Offset = "0x2A7A680", VA = "0x182A7C080")]
		private void NCICBGMLJMA(bool KGOLKNKEHEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2A7C1E0", Offset = "0x2A7A7E0", VA = "0x182A7C1E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2A7C320", Offset = "0x2A7A920", VA = "0x182A7C320")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xAA5720", Offset = "0xAA3D20", VA = "0x180AA5720")]
		public AudioSource GetAudioSource()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2A7C1F0", Offset = "0x2A7A7F0", VA = "0x182A7C1F0")]
		public void SetAudioSource(AudioSource NGOJMGCIOHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2A7B9E0", Offset = "0x2A79FE0", VA = "0x182A7B9E0")]
		public void ChangeMediaPlayer(MediaPlayer CLDOOJMJMLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2A7B930", Offset = "0x2A79F30", VA = "0x182A7B930")]
		private void ALLBLPBLPNI(MediaPlayer DAEDICFCADH, MediaPlayerEvent.IHGOHFKGPHI GBPOPAEJGPD, GPKOBMFDDOH AKOJIFEHEJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2A7BEC0", Offset = "0x2A7A4C0", VA = "0x182A7BEC0")]
		private static void FAMJHAPPOIO(MediaPlayer AGIMJJDFEAF, AudioSource PBLDFAKOFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2A7C160", Offset = "0x2A7A760", VA = "0x182A7C160")]
		private void OnAudioFilterRead(float[] NGAPFKFLCLD, int MNLBIBCDEJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2A7C400", Offset = "0x2A7AA00", VA = "0x182A7C400")]
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
		private static Shader LHCFKGGOAIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private Material BKMHIMIHCLB;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public MediaPlayer IIKNGMIOCAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x2A7E7E0", Offset = "0x2A7CDE0", VA = "0x182A7E7E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public ScaleMode FJNJIKHJMEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAFC970", Offset = "0xAFAF70", VA = "0x180AFC970")]
			get
			{
				return default(ScaleMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xAFD490", Offset = "0xAFBA90", VA = "0x180AFD490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Color CAPMFCMMIDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xEC0BE0", Offset = "0xEBF1E0", VA = "0x180EC0BE0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x10CD4F0", Offset = "0x10CBAF0", VA = "0x1810CD4F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool IEMAKJPODKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xF28FA0", Offset = "0xF275A0", VA = "0x180F28FA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xF3FBF0", Offset = "0xF3E1F0", VA = "0x180F3FBF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool DJNKJLKJFDI
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xF3F9E0", Offset = "0xF3DFE0", VA = "0x180F3F9E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xF3F930", Offset = "0xF3DF30", VA = "0x180F3F930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public int BJANODOBLMG
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xAC5000", Offset = "0xAC3600", VA = "0x180AC5000")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xEF6820", Offset = "0xEF4E20", VA = "0x180EF6820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool KAFALGGFDBL
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xFE10B0", Offset = "0xFDF6B0", VA = "0x180FE10B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xFE0520", Offset = "0xFDEB20", VA = "0x180FE0520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float CNPJMOCNAFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xD7C160", Offset = "0xD7A760", VA = "0x180D7C160")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xD7C810", Offset = "0xD7AE10", VA = "0x180D7C810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public float ECHNCNHPJEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xE8F460", Offset = "0xE8DA60", VA = "0x180E8F460")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x1CE2710", Offset = "0x1CE0D10", VA = "0x181CE2710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float GCHHGPIMJBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xAF7190", Offset = "0xAF5790", VA = "0x180AF7190")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x10AD940", Offset = "0x10ABF40", VA = "0x1810AD940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float IOGNNKMNLAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xF50410", Offset = "0xF4EA10", VA = "0x180F50410")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xF50420", Offset = "0xF4EA20", VA = "0x180F50420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool PMBJNLGELFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xB2DC60", Offset = "0xB2C260", VA = "0x180B2DC60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xB2DC20", Offset = "0xB2C220", VA = "0x180B2DC20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2A7E480", Offset = "0x2A7CA80", VA = "0x182A7E480")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2A7E5C0", Offset = "0x2A7CBC0", VA = "0x182A7E5C0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2A7DCF0", Offset = "0x2A7C2F0", VA = "0x182A7DCF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2A7E440", Offset = "0x2A7CA40", VA = "0x182A7E440")]
		private Shader PJDIIFPOIPG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2A7DB40", Offset = "0x2A7C140", VA = "0x182A7DB40")]
		private void NGOGNAPJBNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2A7DD90", Offset = "0x2A7C390", VA = "0x182A7DD90")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2A7DA00", Offset = "0x2A7C000", VA = "0x182A7DA00")]
		public Rect GetAreaRect()
		{
			return default(Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2A7E7B0", Offset = "0x2A7CDB0", VA = "0x182A7E7B0")]
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
		public delegate void HCDBOLOALPF(Texture2D CABOBPKPDHN);

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public class PlatformOptions
		{
			[Cpp2IlInjected.Token(Token = "0x2000011")]
			public enum FFPHIMNBEMH
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
			public enum KJIGPEOIIFI
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
			public enum JKAMCNFCGKF
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
			public enum PDONBLACOGJ
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
			[Cpp2IlInjected.Address(RVA = "0x2A87B10", Offset = "0x2A86110", VA = "0x182A87B10", Slot = "4")]
			public virtual string CBMFBJKKJLA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xFA1490", Offset = "0xF9FA90", VA = "0x180FA1490", Slot = "5")]
			public virtual byte[] OHKCAAIMJHK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "6")]
			public virtual bool DNADFOOINDE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x2A87B30", Offset = "0x2A86130", VA = "0x182A87B30")]
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
			public DFGLKIFBMJI.AHNMIKFIJLP videoApi;

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
			public DFGLKIFBMJI.EKCIMOKNKAD _audioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public PDNENPFHAGJ audio360ChannelMode;

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
			[Cpp2IlInjected.Address(RVA = "0xDB20C0", Offset = "0xDB06C0", VA = "0x180DB20C0", Slot = "6")]
			public override bool DNADFOOINDE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "7")]
			void ISerializationCallbackReceiver.OnBeforeSerialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x2A87A10", Offset = "0x2A86010", VA = "0x182A87A10", Slot = "8")]
			void ISerializationCallbackReceiver.OnAfterDeserialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x2A87A40", Offset = "0x2A86040", VA = "0x182A87A40")]
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
			public EOPMCDANOAO.LEILLDAOJFA videoApi;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public EOPMCDANOAO.KMNJNMCEGGC _audioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public PDNENPFHAGJ audio360ChannelMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public bool startWithHighestBitrate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public bool useLowLiveLatency;

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0xF28FA0", Offset = "0xF275A0", VA = "0x180F28FA0", Slot = "6")]
			public override bool DNADFOOINDE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x2A879F0", Offset = "0x2A85FF0", VA = "0x182A879F0")]
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
			public enum JCLNNLPCGMA
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
			public enum JAMBAIOIDBC
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
			private readonly FFPHIMNBEMH DefaultTextureFormat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			private readonly JCLNNLPCGMA DefaultFlags;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public FFPHIMNBEMH textureFormat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private JKAMCNFCGKF _previousAudioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			[SerializeField]
			private JKAMCNFCGKF _audioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			[SerializeField]
			private JCLNNLPCGMA _flags;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public float maximumPlaybackRate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private JAMBAIOIDBC _changed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			[SerializeField]
			private float _preferredPeakBitRate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			[SerializeField]
			private PDONBLACOGJ _preferredPeakBitRateUnits;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			[SerializeField]
			private double _preferredForwardBufferDuration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			[SerializeField]
			private KJIGPEOIIFI _preferredMaximumResolution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			[SerializeField]
			private Vector2Int _customPreferredMaximumResolution;

			[Cpp2IlInjected.Token(Token = "0x17000064")]
			public JKAMCNFCGKF audioMode
			{
				[Cpp2IlInjected.Token(Token = "0x6000144")]
				[Cpp2IlInjected.Address(RVA = "0x2A87940", Offset = "0x2A85F40", VA = "0x182A87940")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000065")]
			public JCLNNLPCGMA flags
			{
				[Cpp2IlInjected.Token(Token = "0x6000145")]
				[Cpp2IlInjected.Address(RVA = "0x2A87960", Offset = "0x2A85F60", VA = "0x182A87960")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x2A87890", Offset = "0x2A85E90", VA = "0x182A87890")]
			public OptionsApple(FFPHIMNBEMH HDPHPGNBOOM, JCLNNLPCGMA BLICILPDKMG)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public class OptionsAndroid : PlatformOptions, ISerializationCallbackReceiver
		{
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			[Flags]
			public enum OKCCFIIODAA
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
			private OKCCFIIODAA _changed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private readonly FFPHIMNBEMH DefaultTextureFormat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public FFPHIMNBEMH textureFormat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			[SerializeField]
			private bool _generateMipmaps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			private JKAMCNFCGKF _previousAudioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			[SerializeField]
			private JKAMCNFCGKF _audioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			[SerializeField]
			private KJIGPEOIIFI _preferredMaximumResolution;

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
			private PDONBLACOGJ _preferredPeakBitRateUnits;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public EIGNHODLLBB.NOLPINJKBIM videoApi;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public bool showPosterFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public PDNENPFHAGJ audio360ChannelMode;

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
			public JKAMCNFCGKF audioMode
			{
				[Cpp2IlInjected.Token(Token = "0x6000147")]
				[Cpp2IlInjected.Address(RVA = "0xAE8040", Offset = "0xAE6640", VA = "0x180AE8040")]
				get
				{
					return default(JKAMCNFCGKF);
				}
				[Cpp2IlInjected.Token(Token = "0x6000148")]
				[Cpp2IlInjected.Address(RVA = "0x2A87870", Offset = "0x2A85E70", VA = "0x182A87870")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xAA5580", Offset = "0xAA3B80", VA = "0x180AA5580", Slot = "6")]
			public override bool DNADFOOINDE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "7")]
			void ISerializationCallbackReceiver.OnBeforeSerialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x2A877C0", Offset = "0x2A85DC0", VA = "0x182A877C0", Slot = "8")]
			void ISerializationCallbackReceiver.OnAfterDeserialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x2A877F0", Offset = "0x2A85DF0", VA = "0x182A877F0")]
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
			public enum ICPHFILLLLB
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
			private ICPHFILLLLB _changed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			private readonly FFPHIMNBEMH DefaultTextureFormat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public FFPHIMNBEMH textureFormat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			[SerializeField]
			private bool _generateMipmapsOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private JKAMCNFCGKF _previousAudioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			[SerializeField]
			private JKAMCNFCGKF _audioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			[SerializeField]
			private KJIGPEOIIFI _preferredMaximumResolution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			[SerializeField]
			private Vector2Int _customPreferredMaximumResolution;

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "7")]
			void ISerializationCallbackReceiver.OnBeforeSerialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "8")]
			void ISerializationCallbackReceiver.OnAfterDeserialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x2A87990", Offset = "0x2A85F90", VA = "0x182A87990")]
			public OptionsOpenHarmony()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public class OptionsWebGL : PlatformOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			public enum DNKMNOJDPIP
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
			private DNKMNOJDPIP _changed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public NKOGCMMMHNB.FBDOIKHMHPA externalLibrary;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public bool useTextureMips;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			private JKAMCNFCGKF _previousAudioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			[SerializeField]
			private JKAMCNFCGKF _audioMode;

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "4")]
			public override string CBMFBJKKJLA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "5")]
			public override byte[] OHKCAAIMJHK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x2A879E0", Offset = "0x2A85FE0", VA = "0x182A879E0")]
			public OptionsWebGL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private enum LCDOGKMPPKK
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
		private sealed class FLBGIDHBHIM : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
			[DebuggerHidden]
			public FLBGIDHBHIM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x2A7E810", Offset = "0x2A7CE10", VA = "0x182A7E810", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x2A7E910", Offset = "0x2A7CF10", VA = "0x182A7E910", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class LMHDFIKJKCB : IEnumerator<object>, IEnumerator, IDisposable
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
			public HCDBOLOALPF callback;

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
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
			[DebuggerHidden]
			public LMHDFIKJKCB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x2A80030", Offset = "0x2A7E630", VA = "0x182A80030", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x2A80550", Offset = "0x2A7EB50", VA = "0x182A80550", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class IHFDDMFLNKK : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
			[DebuggerHidden]
			public IHFDDMFLNKK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x2A7F690", Offset = "0x2A7DC90", VA = "0x182A7F690", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x2A7F900", Offset = "0x2A7DF00", VA = "0x182A7F900", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		private HFECFPFPLMM _mediaSource;

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
		private AudioSource GABELGNIMGG;

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
		private PFNLFLFJCOF.OAJPPPIOFGI _resampleMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Range(3f, 10f)]
		[SerializeField]
		[FormerlySerializedAs("m_ResampleBufferSize")]
		private int _resampleBufferSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private PFNLFLFJCOF JEDGHOOAGBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		[FormerlySerializedAs("m_videoMapping")]
		private JKOMGEDPKMN _videoMapping;

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
		private DFHLPJABCBO _forceFileFormat;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		protected BJIOHKIAODC DOOLFFLAMKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private BJNKAGIHKLB BJHDNPEJNOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private EBMAMKKAFPB OIDIGFOOHIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private NBHFEILBFNE HPIHNCONBBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private PKIKBAGFIEA DGBNFCNLMHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private ODFAMAENFHI DCGIBGLPOBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private IFANCPIPNAJ LIHFLDLIFJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private JECNLHCDBDC NPJEMJIJABO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private AICHAOKKAMJ NNJNNIFELOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private JENMOIKKLJC GHHBOIABOJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private GLGJNKCHNJH CLDOLNOMHID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private IDisposable CKEFOBFEEEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private bool EEAJFMMCIIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x139")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private bool DMGLJAOGOCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13A")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private bool MLFKFIHJGOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private Coroutine EPCHPNLLFNK;

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private static bool JHNKENDBEPM;

		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private static bool OINKCJECBKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private MediaPath DAAMBEGPHLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private Coroutine NLNJKKFKNPN;

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static Camera PKAALLJNJMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private bool ELONHLAKCLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private bool MGGHMBHLKCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15A")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private bool BBCMBPDMLAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15B")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private bool JFEGABJGHKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private bool CDHKPFMCOEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15D")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private bool BLAOFJEPOGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15E")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private bool JHEAKPFHEJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15F")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private bool LLONGOOACIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private int DMFNFABHIJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private int IAOKMBNCOBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private int HAFPHNMGGLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private bool HJGIOKANBGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16D")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private bool APLBGPCGFPH;

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
		private LCDOGKMPPKK m_VideoLocation;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public HFECFPFPLMM KINHJCNAPCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAB04F0", Offset = "0xAAEAF0", VA = "0x180AB04F0")]
			get
			{
				return default(HFECFPFPLMM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xAB2A20", Offset = "0xAB1020", VA = "0x180AB2A20")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public MediaReference IDJICINOHMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xAA70F0", Offset = "0xAA56F0", VA = "0x180AA70F0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MediaPath BHKBOGMAOEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xAA5560", Offset = "0xAA3B60", VA = "0x180AA5560")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xAA9ED0", Offset = "0xAA84D0", VA = "0x180AA9ED0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public MediaHints PEIGPCLHHKN
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x1211040", Offset = "0x120F640", VA = "0x181211040")]
			get
			{
				return default(MediaHints);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x22AF1C0", Offset = "0x22AD7C0", VA = "0x1822AF1C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool OODBPNLCADK
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xFE10B0", Offset = "0xFDF6B0", VA = "0x180FE10B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xFE0520", Offset = "0xFDEB20", VA = "0x180FE0520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool GCAEBMMHKPI
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xFE0530", Offset = "0xFDEB30", VA = "0x180FE0530")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xFE0FF0", Offset = "0xFDF5F0", VA = "0x180FE0FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool HIDMLCKGDIA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x2A86D40", Offset = "0x2A85340", VA = "0x182A86D40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x2A87270", Offset = "0x2A85870", VA = "0x182A87270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public virtual float OKNPDINJDOI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x2A86BD0", Offset = "0x2A851D0", VA = "0x182A86BD0", Slot = "6")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x2A871F0", Offset = "0x2A857F0", VA = "0x182A871F0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float FLIBBGDKGPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x2A86B10", Offset = "0x2A85110", VA = "0x182A86B10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x2A87100", Offset = "0x2A85700", VA = "0x182A87100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public virtual bool KMJPPFKFDIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x2A86B70", Offset = "0x2A85170", VA = "0x182A86B70", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x2A87180", Offset = "0x2A85780", VA = "0x182A87180", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public AudioSource LGCOLHFAIPC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xAA5710", Offset = "0xAA3D10", VA = "0x180AA5710")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xAA5590", Offset = "0xAA3B90", VA = "0x180AA5590")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float IMEOMBLJJHF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2A86DD0", Offset = "0x2A853D0", VA = "0x182A86DD0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x2A87310", Offset = "0x2A85910", VA = "0x182A87310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool KBLPANHEFKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x1F192F0", Offset = "0x1F178F0", VA = "0x181F192F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x18D1E70", Offset = "0x18D0470", VA = "0x1818D1E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public PFNLFLFJCOF.OAJPPPIOFGI NMDCKMPIJKB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xD6B700", Offset = "0xD69D00", VA = "0x180D6B700")]
			get
			{
				return default(PFNLFLFJCOF.OAJPPPIOFGI);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x1459770", Offset = "0x1457D70", VA = "0x181459770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public int IBPOMFFPCMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x101FD40", Offset = "0x101E340", VA = "0x18101FD40")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x2A87380", Offset = "0x2A85980", VA = "0x182A87380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public PFNLFLFJCOF FDHJPMLHAPG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xAA5600", Offset = "0xAA3C00", VA = "0x180AA5600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public JKOMGEDPKMN BCNDKEGMLII
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xACE6A0", Offset = "0xACCCA0", VA = "0x180ACE6A0")]
			get
			{
				return default(JKOMGEDPKMN);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x1613980", Offset = "0x1611F80", VA = "0x181613980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public FilterMode GEBFNCNEDPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x2A86F20", Offset = "0x2A85520", VA = "0x182A86F20")]
			get
			{
				return default(FilterMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x2A87400", Offset = "0x2A85A00", VA = "0x182A87400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public TextureWrapMode DIPKMBIOKJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x2A87010", Offset = "0x2A85610", VA = "0x182A87010")]
			get
			{
				return default(TextureWrapMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x2A87470", Offset = "0x2A85A70", VA = "0x182A87470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public int OOHJJNHKLFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x2A86E30", Offset = "0x2A85430", VA = "0x182A86E30")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x2A87390", Offset = "0x2A85990", VA = "0x182A87390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool CGFCDPFILKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xD67C30", Offset = "0xD66230", VA = "0x180D67C30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xE1BC30", Offset = "0xE1A230", VA = "0x180E1BC30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public MediaPath KLBDPCBFKBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xAB0560", Offset = "0xAAEB60", VA = "0x180AB0560")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xAB0400", Offset = "0xAAEA00", VA = "0x180AB0400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public Transform EBONPGLJCDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xB2DCA0", Offset = "0xB2C2A0", VA = "0x180B2DCA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xB78DD0", Offset = "0xB773D0", VA = "0x180B78DD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool OFEEJCEIJOI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xFE0410", Offset = "0xFDEA10", VA = "0x180FE0410")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xFE0FE0", Offset = "0xFDF5E0", VA = "0x180FE0FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public Transform FOEPBJHBMPO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xB78DA0", Offset = "0xB773A0", VA = "0x180B78DA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xB78B30", Offset = "0xB77130", VA = "0x180B78B30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public float FNKODOGPNIB
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x1FF2100", Offset = "0x1FF0700", VA = "0x181FF2100")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x1FF2260", Offset = "0x1FF0860", VA = "0x181FF2260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public float JPHCMECLADE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x1DB4EC0", Offset = "0x1DB34C0", VA = "0x181DB4EC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x1FF2110", Offset = "0x1FF0710", VA = "0x181FF2110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public HttpHeaderData BODJKBGCODH
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0xB78BB0", Offset = "0xB771B0", VA = "0x180B78BB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xB78B50", Offset = "0xB77150", VA = "0x180B78B50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public KeyAuthData ABJCEELCILM
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xEDC690", Offset = "0xEDAC90", VA = "0x180EDC690")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xEDC6A0", Offset = "0xEDACA0", VA = "0x180EDC6A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public MediaPlayerEvent NCJODLKCFOA
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x2A86C30", Offset = "0x2A85230", VA = "0x182A86C30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public int DOEMNJOBABN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0xFFE310", Offset = "0xFFC910", VA = "0x180FFE310")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0xFFE320", Offset = "0xFFC920", VA = "0x180FFE320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public bool FLBKBFCBBKM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x2A86DA0", Offset = "0x2A853A0", VA = "0x182A86DA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x2A872E0", Offset = "0x2A858E0", VA = "0x182A872E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool DEELAIAIPPE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x2A86DC0", Offset = "0x2A853C0", VA = "0x182A86DC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x2A87300", Offset = "0x2A85900", VA = "0x182A87300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool BLHFFHHBIKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x2A86DB0", Offset = "0x2A853B0", VA = "0x182A86DB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x2A872F0", Offset = "0x2A858F0", VA = "0x182A872F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public DFHLPJABCBO EOBDLMHILEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0xB61F50", Offset = "0xB60550", VA = "0x180B61F50")]
			get
			{
				return default(DFHLPJABCBO);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xB61630", Offset = "0xB5FC30", VA = "0x180B61630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public virtual NBHFEILBFNE AEHBEOFBLBP
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xB34C40", Offset = "0xB33240", VA = "0x180B34C40", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public virtual BJNKAGIHKLB CBEHLHKFAOE
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xB3A1D0", Offset = "0xB387D0", VA = "0x180B3A1D0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public virtual PKIKBAGFIEA IIKNGMIOCAK
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xB42A80", Offset = "0xB41080", VA = "0x180B42A80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public virtual EBMAMKKAFPB KIDLPJEDFME
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xB3A1C0", Offset = "0xB387C0", VA = "0x180B3A1C0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual ODFAMAENFHI CIJHEDIIMGH
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xB363D0", Offset = "0xB349D0", VA = "0x180B363D0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public virtual JECNLHCDBDC NKGFKEJDBEF
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xB37FD0", Offset = "0xB365D0", VA = "0x180B37FD0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual AICHAOKKAMJ MHCMHFKAKKB
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xB0B1E0", Offset = "0xB097E0", VA = "0x180B0B1E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual JENMOIKKLJC MOLOHPFHJAD
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xC26960", Offset = "0xC24F60", VA = "0x180C26960", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual GLGJNKCHNJH DBDLBFPCDFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xB9E080", Offset = "0xB9C680", VA = "0x180B9E080", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public virtual IFANCPIPNAJ MEHPGCFPLEC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xB38120", Offset = "0xB36720", VA = "0x180B38120", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool NALDCLJAPIA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xB9DD30", Offset = "0xB9C330", VA = "0x180B9DD30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public OptionsWindows PDMNKBCHHIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0xC3A980", Offset = "0xC38F80", VA = "0x180C3A980")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public OptionsApple LBFPOBKMKBN
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xC1F3B0", Offset = "0xC1D9B0", VA = "0x180C1F3B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public OptionsApple OBHHJPHPKED
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0xC1BAC0", Offset = "0xC1A0C0", VA = "0x180C1BAC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public OptionsApple FDCMKFNFAMO
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0xC351E0", Offset = "0xC337E0", VA = "0x180C351E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public OptionsApple MDFABGNMJJK
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0xB48BD0", Offset = "0xB471D0", VA = "0x180B48BD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public OptionsAndroid GIPEMGNGNDL
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0xB80E80", Offset = "0xB7F480", VA = "0x180B80E80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public OptionsOpenHarmony AAHONEMJKFE
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0xB42CF0", Offset = "0xB412F0", VA = "0x180B42CF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public OptionsWindowsUWP HBLFAAEAKHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0xB5AB40", Offset = "0xB59140", VA = "0x180B5AB40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public OptionsWebGL NPEHJFHFNGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xB80E70", Offset = "0xB7F470", VA = "0x180B80E70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xAB2A20", Offset = "0xAB1020", VA = "0x180AB2A20")]
		public void SetMediaSource(HFECFPFPLMM NGOJMGCIOHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xAA70F0", Offset = "0xAA56F0", VA = "0x180AA70F0")]
		public void SetMediaReference(MediaReference NOCOHHHJONM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xAA9ED0", Offset = "0xAA84D0", VA = "0x180AA9ED0")]
		public void SetMediaPath(MediaPath BFHDBHOMJKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xAA5590", Offset = "0xAA3B90", VA = "0x180AA5590")]
		public void SetAudioSource(AudioSource PBLDFAKOFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2A80BD0", Offset = "0x2A7F1D0", VA = "0x182A80BD0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2A82B60", Offset = "0x2A81160", VA = "0x182A82B60")]
		protected void KBODLCEHIAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2A85F70", Offset = "0x2A84570", VA = "0x182A85F70")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2A85290", Offset = "0x2A83890", VA = "0x182A85290")]
		public bool OpenMedia(MediaPath BFHDBHOMJKM, bool PIDADEKILJI = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2A85210", Offset = "0x2A83810", VA = "0x182A85210")]
		public bool OpenMedia(NOEEEMEECJL MAJGFKALHMK, string BFHDBHOMJKM, bool PIDADEKILJI = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2A851C0", Offset = "0x2A837C0", VA = "0x182A851C0")]
		public bool OpenMedia(MediaReference KBNPCKJJNGK, bool PIDADEKILJI = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2A85190", Offset = "0x2A83790", VA = "0x182A85190")]
		public bool OpenMedia(bool PIDADEKILJI = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2A83DF0", Offset = "0x2A823F0", VA = "0x182A83DF0")]
		private bool NEPHCIMHMDL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2A846F0", Offset = "0x2A82CF0", VA = "0x182A846F0")]
		private void OEDONGCFEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2A82710", Offset = "0x2A80D10", VA = "0x182A82710")]
		private void ICBBCBJMPAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2A814F0", Offset = "0x2A7FAF0", VA = "0x182A814F0")]
		public void CloseMedia()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2A85570", Offset = "0x2A83B70", VA = "0x182A85570", Slot = "20")]
		public virtual void Play()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2A854F0", Offset = "0x2A83AF0", VA = "0x182A854F0", Slot = "21")]
		public virtual void Pause()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2A86050", Offset = "0x2A84650", VA = "0x182A86050")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2A85600", Offset = "0x2A83C00", VA = "0x182A85600")]
		public void Rewind(bool ODOIEAJCGNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2A85DA0", Offset = "0x2A843A0", VA = "0x182A85DA0")]
		public void SeekToLiveTime(double PIOCNHLFCNE = 0.0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2A861B0", Offset = "0x2A847B0", VA = "0x182A861B0", Slot = "22")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2A83CB0", Offset = "0x2A822B0", VA = "0x182A83CB0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2A82900", Offset = "0x2A80F00", VA = "0x182A82900")]
		private void JANADEMAMDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2A85050", Offset = "0x2A83650", VA = "0x182A85050")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2A84F90", Offset = "0x2A83590", VA = "0x182A84F90")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2A84E10", Offset = "0x2A83410", VA = "0x182A84E10", Slot = "23")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2A82400", Offset = "0x2A80A00", VA = "0x182A82400")]
		public void ForceDispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2A824D0", Offset = "0x2A80AD0", VA = "0x182A824D0")]
		private static void GAMINOKHDII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2A84BD0", Offset = "0x2A831D0", VA = "0x182A84BD0")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2A83BF0", Offset = "0x2A821F0", VA = "0x182A83BF0")]
		protected void LKNPDNGALJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2A852C0", Offset = "0x2A838C0", VA = "0x182A852C0")]
		private void PFEPHFGECBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2A84670", Offset = "0x2A82C70", VA = "0x182A84670")]
		[IteratorStateMachine(typeof(FLBGIDHBHIM))]
		private IEnumerator OAHFDONJKKK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990")]
		public static MONLJLHHPDC GetPlatform()
		{
			return default(MONLJLHHPDC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xC3A980", Offset = "0xC38F80", VA = "0x180C3A980")]
		public PlatformOptions GetCurrentPlatformOptions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2A81040", Offset = "0x2A7F640", VA = "0x182A81040")]
		private string BLOOODPOPDP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990")]
		private long AFMJFALGIHD()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2A81AD0", Offset = "0x2A800D0", VA = "0x182A81AD0")]
		private string ELFFNCFNMMK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2A83B80", Offset = "0x2A82180", VA = "0x182A83B80")]
		private string LGFPEOHJDEM(string FOJGLONLCLC, NOEEEMEECJL PPNDBIIEFMO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2A85310", Offset = "0x2A83910", VA = "0x182A85310")]
		private static BJIOHKIAODC PFEPICPFMOF(OptionsWindows PLMLGIGGGNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2A83970", Offset = "0x2A81F70", VA = "0x182A83970")]
		private static BJIOHKIAODC KPEBNHCHHJJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2A81660", Offset = "0x2A7FC60", VA = "0x182A81660", Slot = "24")]
		public virtual BJIOHKIAODC CreateMediaPlayer()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2A84980", Offset = "0x2A82F80", VA = "0x182A84980")]
		private void OPGDKICNCLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2A808E0", Offset = "0x2A7EEE0", VA = "0x182A808E0")]
		private void AALMHKBPFJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2A80C70", Offset = "0x2A7F270", VA = "0x182A80C70")]
		private void BJIJMIGHJJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0")]
		public bool IsUsingAndroidOESPath()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0")]
		public bool IsUsingYCbCr()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2A85AB0", Offset = "0x2A840B0", VA = "0x182A85AB0")]
		[ContextMenu("Save Frame To PNG")]
		public void SaveFrameToPng()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2A85680", Offset = "0x2A83C80", VA = "0x182A85680")]
		[ContextMenu("Save Frame To EXR")]
		public void SaveFrameToExr()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		private void OnApplicationFocus(bool KOKKPALBGFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		private void OnApplicationPause(bool AFBKNGLGAFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2A826E0", Offset = "0x2A80CE0", VA = "0x182A826E0")]
		private void HFHDHGBPEGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2A82A00", Offset = "0x2A81000", VA = "0x182A82A00")]
		private void JCEOKMKDLKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2A82AD0", Offset = "0x2A810D0", VA = "0x182A82AD0")]
		private void JJDBICMAEPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2A81B80", Offset = "0x2A80180", VA = "0x182A81B80")]
		private void EMCPIPFLIKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2A837B0", Offset = "0x2A81DB0", VA = "0x182A837B0")]
		private void KNBFPJGNLII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2A80C40", Offset = "0x2A7F240", VA = "0x182A80C40")]
		protected bool BBDPAHNOFID(MediaPlayerEvent.IHGOHFKGPHI HPKJPAHGLEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2A85460", Offset = "0x2A83A60", VA = "0x182A85460")]
		private bool PMAOJHHJOKF(MediaPlayerEvent.IHGOHFKGPHI HPKJPAHGLEF, bool DFMJKNLABLM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2A83240", Offset = "0x2A81840", VA = "0x182A83240")]
		private bool KKMFPNAMBLC(MediaPlayerEvent.IHGOHFKGPHI GBPOPAEJGPD, bool DFMJKNLABLM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2A839C0", Offset = "0x2A81FC0", VA = "0x182A839C0")]
		private bool LCHGGJJNBCI(int MHONGBDKEGB, float KOPOINOPAEI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2A80DE0", Offset = "0x2A7F3E0", VA = "0x182A80DE0")]
		private static Camera BJODMGEPHOB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2A82830", Offset = "0x2A80E30", VA = "0x182A82830")]
		[IteratorStateMachine(typeof(LMHDFIKJKCB))]
		private IEnumerator IPLBHNGIOOP(Texture2D AMMKGILEHBG, HCDBOLOALPF LAOAAOBGDLL, double DFNGNEGKPBE = -1.0, bool LJCDCCDLDLI = true, int KOPOINOPAEI = 1000, int CINPAEJNLAP = 100)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2A821A0", Offset = "0x2A807A0", VA = "0x182A821A0")]
		public void ExtractFrameAsync(Texture2D AMMKGILEHBG, HCDBOLOALPF LAOAAOBGDLL, double DFNGNEGKPBE = -1.0, bool LJCDCCDLDLI = true, int KOPOINOPAEI = 1000, int CINPAEJNLAP = 100)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2A82280", Offset = "0x2A80880", VA = "0x182A82280")]
		public Texture2D ExtractFrame(Texture2D AMMKGILEHBG, double DFNGNEGKPBE = -1.0, bool LJCDCCDLDLI = true, int KOPOINOPAEI = 1000, int CINPAEJNLAP = 100)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2A84420", Offset = "0x2A82A20", VA = "0x182A84420")]
		private Texture NOGMEGNFDAE(double DFNGNEGKPBE = -1.0, bool LJCDCCDLDLI = true, int KOPOINOPAEI = 1000, int CINPAEJNLAP = 100)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x2A850D0", Offset = "0x2A836D0", VA = "0x182A850D0")]
		public bool OpenMediaFromBuffer(byte[] DNGAEEFBGGO, bool PIDADEKILJI = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x2A85EB0", Offset = "0x2A844B0", VA = "0x182A85EB0")]
		public bool StartOpenChunkedMediaFromBuffer(ulong NODGHDHCBPE, bool PIDADEKILJI = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2A80AB0", Offset = "0x2A7F0B0", VA = "0x182A80AB0")]
		public bool AddChunkToVideoBuffer(byte[] KGGDFKHMCKC, ulong PIOCNHLFCNE, ulong FJCCBHJMPHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2A80A30", Offset = "0x2A7F030", VA = "0x182A80A30")]
		public bool EndOpenChunkedVideoFromBuffer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2A810C0", Offset = "0x2A7F6C0", VA = "0x182A810C0")]
		private bool CCHMJGHLCPO(byte[] DNGAEEFBGGO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2A812E0", Offset = "0x2A7F8E0", VA = "0x182A812E0")]
		private bool CIOEIJMGPGE(ulong NODGHDHCBPE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2A80AB0", Offset = "0x2A7F0B0", VA = "0x182A80AB0")]
		private bool OBBLAGOKAOA(byte[] KGGDFKHMCKC, ulong PIOCNHLFCNE, ulong FJCCBHJMPHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2A80A30", Offset = "0x2A7F030", VA = "0x182A80A30")]
		private bool AENKDELLJBC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2A81DC0", Offset = "0x2A803C0", VA = "0x182A81DC0")]
		public bool EnableSubtitles(MediaPath HKADBJFIDJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2A82630", Offset = "0x2A80C30", VA = "0x182A82630")]
		[IteratorStateMachine(typeof(IHFDDMFLNKK))]
		private IEnumerator HACDAKAIDPB(string INEFLACMFDG, MediaPath HKADBJFIDJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2A819F0", Offset = "0x2A7FFF0", VA = "0x182A819F0")]
		public void DisableSubtitles()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "4")]
		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2A860B0", Offset = "0x2A846B0", VA = "0x182A860B0", Slot = "5")]
		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2A865E0", Offset = "0x2A84BE0", VA = "0x182A865E0")]
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
			public enum PAOOHGFLCEG
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
			public PAOOHGFLCEG sourceType;

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
			public PlaylistMediaPlayer.KABBEJHPEKN startMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			[SerializeField]
			public PlaylistMediaPlayer.AJEIFHOLOGF progressMode;

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
			public PlaylistMediaPlayer.MDEJKCHBLNG overrideTransition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			[SerializeField]
			public float overrideTransitionDuration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			[SerializeField]
			public NPCODINJMJP.BCJNHLFNJAB overrideTransitionEasing;

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x2A805A0", Offset = "0x2A7EBA0", VA = "0x182A805A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2A874E0", Offset = "0x2A85AE0", VA = "0x182A874E0")]
		public bool MBOPFPFGKPP(int PMIGBJGNLLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2A87540", Offset = "0x2A85B40", VA = "0x182A87540")]
		public MediaPlaylist()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[AddComponentMenu("AVPro Video/Playlist Media Player", -80)]
	[HelpURL("https://www.renderheads.com/products/avpro-video/")]
	public class PlaylistMediaPlayer : MediaPlayer, EBMAMKKAFPB
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public enum MDEJKCHBLNG
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
		public enum PCMIPJELIDM
		{
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			Loop
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public enum KABBEJHPEKN
		{
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			Immediate,
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			Manual
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public enum AJEIFHOLOGF
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
		private sealed class JLFJCKCLOLB : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
			[DebuggerHidden]
			public JLFJCKCLOLB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x2A7F950", Offset = "0x2A7DF50", VA = "0x182A7F950", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x2A7FFE0", Offset = "0x2A7E5E0", VA = "0x182A7FFE0", Slot = "8")]
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
		private PCMIPJELIDM _playlistLoopMode;

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
		private MDEJKCHBLNG _defaultTransition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[SerializeField]
		private float _defaultTransitionDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[SerializeField]
		private NPCODINJMJP.BCJNHLFNJAB _defaultTransitionEasing;

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
		private static readonly MPEDAGENPGA EBGGDBIJDPB;

		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private static readonly MPEDAGENPGA FEJCANKDPHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x205")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private bool CFFOCJKECCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private int FADDHILLHGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private MediaPlayer INKPOCCMIPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private Material BKMHIMIHCLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private MDEJKCHBLNG NMFHFPIPJCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private string DGEOBNFLBHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private float IBCMGGBNGCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x234")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private NPCODINJMJP.BCJNHLFNJAB NHMLADMEHBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private float IIMEDCPNPHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private Func<float, float> IMMEMDBLGMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private RenderTexture KBKHOFIKENJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private MediaPlaylist.MediaItem NIFAEOBEFFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private MediaPlaylist.MediaItem NIHGCPPENDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private WaitForEndOfFrame DKJEPGKPEIK;

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public MediaPlayer BFEPHJDJFAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x2A8A8C0", Offset = "0x2A88EC0", VA = "0x182A8A8C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public MediaPlayer PHDMIGPHMFL
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xBD6220", Offset = "0xBD4820", VA = "0x180BD6220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public MediaPlaylist PLOKFEFPBGP
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xBD57C0", Offset = "0xBD3DC0", VA = "0x180BD57C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public int MKADIHABBKH
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x274F060", Offset = "0x274D660", VA = "0x18274F060")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public MediaPlaylist.MediaItem NHFDIJINDEI
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x2A8AA10", Offset = "0x2A89010", VA = "0x182A8AA10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public MDEJKCHBLNG JLFCCDACCBO
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xDB0610", Offset = "0xDAEC10", VA = "0x180DB0610")]
			get
			{
				return default(MDEJKCHBLNG);
			}
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x1645250", Offset = "0x1643850", VA = "0x181645250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public float GLOECOAONAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x1F68C90", Offset = "0x1F67290", VA = "0x181F68C90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x21E8540", Offset = "0x21E6B40", VA = "0x1821E8540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public NPCODINJMJP.BCJNHLFNJAB GKNODAGOAKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0xB5AD00", Offset = "0xB59300", VA = "0x180B5AD00")]
			get
			{
				return default(NPCODINJMJP.BCJNHLFNJAB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xB59030", Offset = "0xB57630", VA = "0x180B59030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public bool IKDJEIGOOHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x1654540", Offset = "0x1652B40", VA = "0x181654540")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x16571D0", Offset = "0x16557D0", VA = "0x1816571D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public PCMIPJELIDM EMGPIFJAMIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x2A8AA00", Offset = "0x2A89000", VA = "0x182A8AA00")]
			get
			{
				return default(PCMIPJELIDM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x2A8AC90", Offset = "0x2A89290", VA = "0x182A8AC90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public bool PPBHDKKAHAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xC1E4E0", Offset = "0xC1CAE0", VA = "0x180C1E4E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xC1F3A0", Offset = "0xC1D9A0", VA = "0x180C1F3A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public override NBHFEILBFNE AEHBEOFBLBP
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x2A8A960", Offset = "0x2A88F60", VA = "0x182A8A960", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public override BJNKAGIHKLB CBEHLHKFAOE
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x2A8A820", Offset = "0x2A88E20", VA = "0x182A8A820", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public override EBMAMKKAFPB KIDLPJEDFME
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xE29190", Offset = "0xE27790", VA = "0x180E29190", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public override float OKNPDINJDOI
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x21E6BB0", Offset = "0x21E51B0", VA = "0x1821E6BB0", Slot = "6")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x2A8ABA0", Offset = "0x2A891A0", VA = "0x182A8ABA0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public override bool KMJPPFKFDIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x2A8A810", Offset = "0x2A88E10", VA = "0x182A8A810", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x2A8AAD0", Offset = "0x2A890D0", VA = "0x182A8AAD0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2A89C60", Offset = "0x2A88260", VA = "0x182A89C60", Slot = "20")]
		public override void Play()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2A89B50", Offset = "0x2A88150", VA = "0x182A89B50", Slot = "21")]
		public override void Pause()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2A88D80", Offset = "0x2A87380", VA = "0x182A88D80")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2A88ED0", Offset = "0x2A874D0", VA = "0x182A88ED0")]
		[IteratorStateMachine(typeof(JLFJCKCLOLB))]
		private IEnumerator KMIBOHEFHJD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2A87D70", Offset = "0x2A86370", VA = "0x182A87D70")]
		private Texture CMFPCGBIEBN(int PMIGBJGNLLP = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2A87F50", Offset = "0x2A86550", VA = "0x182A87F50")]
		private Texture EDFIEIJENDH(int PMIGBJGNLLP = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2A87BE0", Offset = "0x2A861E0", VA = "0x182A87BE0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2A89350", Offset = "0x2A87950", VA = "0x182A89350", Slot = "23")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2A89E20", Offset = "0x2A88420", VA = "0x182A89E20")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2A895D0", Offset = "0x2A87BD0", VA = "0x182A895D0")]
		public void OnMediaPlayerEvent(MediaPlayer FICMDFJHIJB, MediaPlayerEvent.IHGOHFKGPHI HPKJPAHGLEF, GPKOBMFDDOH AKOJIFEHEJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2A89D70", Offset = "0x2A88370", VA = "0x182A89D70")]
		public bool PrevItem()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2A892D0", Offset = "0x2A878D0", VA = "0x182A892D0")]
		public bool NextItem()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2A87E80", Offset = "0x2A86480", VA = "0x182A87E80")]
		public bool CanJumpToItem(int PMIGBJGNLLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2A88D90", Offset = "0x2A87390", VA = "0x182A88D90")]
		public bool JumpToItem(int PMIGBJGNLLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2A89790", Offset = "0x2A87D90", VA = "0x182A89790")]
		public void OpenVideoFile(MediaPlaylist.MediaItem HMJHHNPJPHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2A89B30", Offset = "0x2A88130", VA = "0x182A89B30")]
		private bool PHPNEIEFNMC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2A88F50", Offset = "0x2A87550", VA = "0x182A88F50")]
		private void MEPDMHIABCO(MDEJKCHBLNG DNFEGCCONHH, float KFCMKNFBLHC, NPCODINJMJP.BCJNHLFNJAB BIHBMKBHAGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2A8A050", Offset = "0x2A88650", VA = "0x182A8A050", Slot = "22")]
		protected override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2A88B60", Offset = "0x2A87160", VA = "0x182A88B60", Slot = "26")]
		public Texture GetTexture(int PMIGBJGNLLP = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2A885D0", Offset = "0x2A86BD0", VA = "0x182A885D0", Slot = "25")]
		public int GetTextureCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x2A88670", Offset = "0x2A86C70", VA = "0x182A88670", Slot = "27")]
		public int GetTextureFrameCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2A89FB0", Offset = "0x2A885B0", VA = "0x182A89FB0", Slot = "28")]
		public bool SupportsTextureFrameCount()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2A88990", Offset = "0x2A86F90", VA = "0x182A88990", Slot = "29")]
		public long GetTextureTimeStamp()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2A88840", Offset = "0x2A86E40", VA = "0x182A88840", Slot = "30")]
		public float GetTexturePixelAspectRatio()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2A89D80", Offset = "0x2A88380", VA = "0x182A89D80", Slot = "31")]
		public bool RequiresVerticalFlip()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2A88C50", Offset = "0x2A87250", VA = "0x182A88C50", Slot = "35")]
		public Matrix4x4 GetYpCbCrTransform()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2A888F0", Offset = "0x2A86EF0", VA = "0x182A888F0", Slot = "32")]
		public MPKICFKOEJB GetTextureStereoPacking()
		{
			return default(MPKICFKOEJB);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x2A88AC0", Offset = "0x2A870C0", VA = "0x182A88AC0", Slot = "33")]
		public NIOGBCIEHEJ GetTextureTransparency()
		{
			return default(NIOGBCIEHEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x2A88530", Offset = "0x2A86B30", VA = "0x182A88530", Slot = "34")]
		public LEMCJHMHPOI GetTextureAlphaPacking()
		{
			return default(LEMCJHMHPOI);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x2A88300", Offset = "0x2A86900", VA = "0x182A88300", Slot = "36")]
		public float[] GetAffineTransform()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x2A88710", Offset = "0x2A86D10", VA = "0x182A88710", Slot = "37")]
		public Matrix4x4 GetTextureMatrix()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x2A883F0", Offset = "0x2A869F0", VA = "0x182A883F0", Slot = "38")]
		public RenderTextureFormat GetCompatibleRenderTextureFormat(NKMHPCLEFEN PLMLGIGGGNL, int CFOILFKCBDC)
		{
			return default(RenderTextureFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x2A88040", Offset = "0x2A86640", VA = "0x182A88040")]
		private static string GIOPIOMAFII(MDEJKCHBLNG DNFEGCCONHH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x2A8A660", Offset = "0x2A88C60", VA = "0x182A8A660")]
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
		private DJAMJLOMPKM.IJGAFBEEBLK _resolveFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[SerializeField]
		private RenderTexture _externalTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private Material MCMOMBGDPOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private bool KPEPLCHCBKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x69")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private bool IBHLBEKNEAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6A")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private bool HGGLCPGMKMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private RenderTexture OIDIFJLMPGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private int EBLIOONHAGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private Material COLAAOHEIHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private int JEJOJHDAMEE;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public MediaPlayer IPPOGEIDPBM
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x2A8ACA0", Offset = "0x2A892A0", VA = "0x182A8ACA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public VideoResolveOptions FMAMFLDAACI
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x2A8B7A0", Offset = "0x2A89DA0", VA = "0x182A8B7A0")]
			get
			{
				return default(VideoResolveOptions);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x2A8B7C0", Offset = "0x2A89DC0", VA = "0x182A8B7C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public RenderTexture DOIIGMLBNLD
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xAA54C0", Offset = "0xAA3AC0", VA = "0x180AA54C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xAA5570", Offset = "0xAA3B70", VA = "0x180AA5570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public RenderTexture PKDFKNCBHMH
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x2A8B720", Offset = "0x2A89D20", VA = "0x182A8B720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2A8B550", Offset = "0x2A89B50", VA = "0x182A8B550")]
		public void SetMaterialDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x2A8ACA0", Offset = "0x2A892A0", VA = "0x182A8ACA0")]
		private void ENEIPOBPBIJ(MediaPlayer FICMDFJHIJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x2A8B560", Offset = "0x2A89B60", VA = "0x182A8B560")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2A8AD40", Offset = "0x2A89340", VA = "0x182A8AD40")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x2A8AE70", Offset = "0x2A89470", VA = "0x182A8AE70")]
		public void Resolve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x2A8ADF0", Offset = "0x2A893F0", VA = "0x182A8ADF0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2A8AD50", Offset = "0x2A89350", VA = "0x182A8AD50")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2A8B6D0", Offset = "0x2A89CD0", VA = "0x182A8B6D0")]
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
		private static readonly MPEDAGENPGA OHCDFGCMOPE;

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private static readonly MPEDAGENPGA ENPJOEEJPID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private Camera NADADIBCEKC;

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Camera AECJMHFPIKD
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2A8B7E0", Offset = "0x2A89DE0", VA = "0x182A8B7E0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C0D0", Offset = "0x2A8A6D0", VA = "0x182A8C0D0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2A8BC90", Offset = "0x2A8A290", VA = "0x182A8BC90")]
		private void NBOLGJIEIKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2A8B880", Offset = "0x2A89E80", VA = "0x182A8B880")]
		private static bool HIECCDMOFJE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2A8B8B0", Offset = "0x2A89EB0", VA = "0x182A8B8B0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xAA8970", Offset = "0xAA6F70", VA = "0x180AA8970")]
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
		private MPKICFKOEJB _overrideStereoPacking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[SerializeField]
		private bool _stereoRedGreenTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		protected bool ABKHLEDOIHB;

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public MediaPlayer IIKNGMIOCAK
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x2A76D30", Offset = "0x2A75330", VA = "0x182A76D30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public bool JKCFABOBLFE
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xAA5700", Offset = "0xAA3D00", VA = "0x180AA5700")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x2A76D10", Offset = "0x2A75310", VA = "0x182A76D10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public MPKICFKOEJB CEKOFJDCKBP
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xC582A0", Offset = "0xC568A0", VA = "0x180C582A0")]
			get
			{
				return default(MPKICFKOEJB);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x2A76D20", Offset = "0x2A75320", VA = "0x182A76D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public bool DMAFFJJMCKL
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xC58290", Offset = "0xC56890", VA = "0x180C58290")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x2A76D40", Offset = "0x2A75340", VA = "0x182A76D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x2A76A70", Offset = "0x2A75070", VA = "0x182A76A70")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x2A76A80", Offset = "0x2A75080", VA = "0x182A76A80")]
		private void ENEIPOBPBIJ(MediaPlayer AGIMJJDFEAF, bool AKKFOJDOENB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x2A76A30", Offset = "0x2A75030", VA = "0x182A76A30")]
		private void ALLBLPBLPNI(MediaPlayer DAEDICFCADH, MediaPlayerEvent.IHGOHFKGPHI GBPOPAEJGPD, GPKOBMFDDOH AKOJIFEHEJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x2A76C30", Offset = "0x2A75230", VA = "0x182A76C30")]
		public void ForceUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x2A76CD0", Offset = "0x2A752D0", VA = "0x182A76CD0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x2A76C80", Offset = "0x2A75280", VA = "0x182A76C80", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x1AC7C30", Offset = "0x1AC6230", VA = "0x181AC7C30", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x2A76C70", Offset = "0x2A75270", VA = "0x182A76C70")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "6")]
		protected virtual void APNCBJEIMBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "7")]
		protected virtual void JMOFMHLIFHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void Apply();

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x189F9B0", Offset = "0x189DFB0", VA = "0x18189F9B0")]
		protected ApplyToBase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class IGFGPFDBKPC
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	protected class JEMOHLMAIFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public HashSet<AudioOutput> DLGGHOCLFNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public float[] HEAGDADNNGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public bool OENLBLBIGKG;

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public JEMOHLMAIFF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private static IGFGPFDBKPC BICCGKMJHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private Dictionary<int, JEMOHLMAIFF> IPCDKIIKHLG;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public static IGFGPFDBKPC EHBCEBDHHPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x2A7F370", Offset = "0x2A7D970", VA = "0x182A7F370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x2A7F600", Offset = "0x2A7DC00", VA = "0x182A7F600")]
	private IGFGPFDBKPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x2A7F480", Offset = "0x2A7DA80", VA = "0x182A7F480")]
	public void MNFIOBOLJHA(int HCKBOBHPCFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x2A7F580", Offset = "0x2A7DB80", VA = "0x182A7F580")]
	public void NJBAFCCBJAN(int HCKBOBHPCFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x2A7EAB0", Offset = "0x2A7D0B0", VA = "0x182A7EAB0")]
	public void FHAGDMNBGMP(AudioOutput KEOJBDBEFHF, MediaPlayer FICMDFJHIJB, int HCKBOBHPCFK, float[] NGAPFKFLCLD, int ABMODILDDHE, int CIOAFMBBFMM, AudioOutput.JPJOAMKHIAO GEEDEICBFAP, bool JPMDKDOFPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x2A7EA70", Offset = "0x2A7D070", VA = "0x182A7EA70")]
	private void CAALNHJNCOF(float[] NGAPFKFLCLD, int OHGDFLELMGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x2A7E960", Offset = "0x2A7CF60", VA = "0x182A7E960")]
	private bool AFBMEMCFEKI(MediaPlayer AGIMJJDFEAF, float[] NGAPFKFLCLD, int MNLBIBCDEJH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[DefaultMember("Item")]
public abstract class BJIOHKIAODC : PKIKBAGFIEA, BJNKAGIHKLB, NBHFEILBFNE, IFANCPIPNAJ, EBMAMKKAFPB, ODFAMAENFHI, JECNLHCDBDC, AICHAOKKAMJ, JENMOIKKLJC, GLGJNKCHNJH, IEnumerable, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	protected string JCBEBOPDICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	protected GPKOBMFDDOH JKIPFOHPICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	protected FilterMode DOBIPNFNFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	protected TextureWrapMode IILKHKPBBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	protected int IKMBEFPKAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	protected MediaHints PFEBGNFNBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	protected EBBOJFJJJBJ BMEDFJFBMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	protected EBBOJFJJJBJ PICBLFELAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private float KJHMOKOJCLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private int EEJBKCFJKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private float KNNPJMDLPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private float IJOGLLIDCME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private int BEAFIKEBHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private int FJECBCICOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	protected List<ALLBCFOHLKE> ECMDFAADGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	protected ALLBCFOHLKE PNNCOBEHMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	protected HJHBEHPKCJO PGCEKFLNAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	protected EJKFHKIHHMD LGODCFJPDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	protected HODKKHLDHDC HDOAOEPPNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	protected GDGPHFIGKJG OODHJMHPDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	protected EFLCKALDKFO MELMEEBKBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	protected GKPGACNOKDG[] FPLDABHIJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	protected List<HPOMIFCGOEO> PLFPIDIDGEP;

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D670", Offset = "0x2A7BC70", VA = "0x182A7D670")]
	public BJIOHKIAODC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "82")]
	public abstract string DBBFCOKKLMA();

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "83")]
	public abstract string OCBAJAMEPEJ();

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "84")]
	public abstract bool MGIJEMLAOMK(string BFHDBHOMJKM, long PIOCNHLFCNE, string EPGILKIPLND, MediaHints PDNBKCFAIFA, int LAEFJHLNJKG = 0, bool INKMBLFADIJ = false);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "85")]
	public virtual bool ELGHMEPJPHN(byte[] DNGAEEFBGGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "86")]
	public virtual bool NDCKBIOOBNL(ulong NODGHDHCBPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "87")]
	public virtual bool EKKFIBEBLNB(byte[] KGGDFKHMCKC, ulong PIOCNHLFCNE, ulong NODGHDHCBPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "88")]
	public virtual bool FDICDJKGBML()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D280", Offset = "0x2A7B880", VA = "0x182A7D280", Slot = "89")]
	public virtual void LLLBJLFLOEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "90")]
	public abstract void HOEIMCEDJME(bool MDKPABOIECP);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "91")]
	public abstract bool JCLAEDECLNL();

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "92")]
	public abstract bool BFMPGNCFAON();

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "93")]
	public abstract bool OADLMFHCCED();

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "94")]
	public abstract void DJEKLJKIOHB();

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "95")]
	public abstract void EEEOMJDOMAD();

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "96")]
	public abstract void MBDDDNAIIMI();

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C8F0", Offset = "0x2A7AEF0", VA = "0x182A7C8F0", Slot = "97")]
	public virtual void GPIJCEACOAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "98")]
	public abstract void EHIIACCOAEB(double HBAPMMDKJDM);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "99")]
	public abstract void LJNMPIEKFDA(double HBAPMMDKJDM);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "100")]
	public abstract double DIHNIAHJDPA();

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "101")]
	public abstract float OPGNDEBAPEB();

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "102")]
	public abstract void GFCJBNCKHJD(float NFMNHEPLOLF);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "103")]
	public abstract double JPLKDOCIDFK();

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "104")]
	public abstract int JNMJBHEIJGI();

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "105")]
	public abstract int OMBILPPCFDN();

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "106")]
	public abstract float PKOPMLGMCMN();

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "107")]
	public abstract bool IGEKNPNCDIP();

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "108")]
	public abstract bool KOOPECIKBIC();

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "109")]
	public abstract bool DILLOBIIFPB();

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "110")]
	public abstract bool FFCNCFEIINJ();

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "111")]
	public abstract bool AIHGMKGEFID();

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "112")]
	public abstract bool GIGILLFJNAL();

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "113")]
	public abstract bool CDEFPCKANCA();

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "114")]
	public virtual bool FJGHBHBEKEJ(Camera GANPHOLIACP, int NGKJFGMKGJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0xC4FA70", Offset = "0xC4E070", VA = "0x180C4FA70", Slot = "115")]
	public virtual int GetTextureCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "116")]
	public abstract Texture GetTexture(int PMIGBJGNLLP = 0);

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "117")]
	public abstract int GetTextureFrameCount();

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "118")]
	public virtual bool SupportsTextureFrameCount()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x2A7CC20", Offset = "0x2A7B220", VA = "0x182A7CC20", Slot = "119")]
	public virtual long GetTextureTimeStamp()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "120")]
	public abstract bool RequiresVerticalFlip();

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0xC58280", Offset = "0xC56880", VA = "0x180C58280", Slot = "121")]
	public virtual float GetTexturePixelAspectRatio()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x2A7CC30", Offset = "0x2A7B230", VA = "0x182A7CC30", Slot = "122")]
	public virtual Matrix4x4 GetYpCbCrTransform()
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C910", Offset = "0x2A7AF10", VA = "0x182A7C910", Slot = "123")]
	public virtual float[] GetAffineTransform()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C670", Offset = "0x2A7AC70", VA = "0x182A7C670", Slot = "124")]
	public virtual float[] CLEECEANPEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x2A7CA50", Offset = "0x2A7B050", VA = "0x182A7CA50", Slot = "125")]
	public virtual Matrix4x4 GetTextureMatrix()
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0xF4EA10", Offset = "0xF4D010", VA = "0x180F4EA10", Slot = "126")]
	public virtual RenderTextureFormat GetCompatibleRenderTextureFormat(NKMHPCLEFEN PLMLGIGGGNL, int CFOILFKCBDC)
	{
		return default(RenderTextureFormat);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x2A7CBF0", Offset = "0x2A7B1F0", VA = "0x182A7CBF0", Slot = "70")]
	public MPKICFKOEJB GetTextureStereoPacking()
	{
		return default(MPKICFKOEJB);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "127")]
	internal abstract MPKICFKOEJB CONIBFNBJAH();

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0xAA70A0", Offset = "0xAA56A0", VA = "0x180AA70A0", Slot = "128")]
	public virtual NIOGBCIEHEJ GetTextureTransparency()
	{
		return default(NIOGBCIEHEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x2A7CA10", Offset = "0x2A7B010", VA = "0x182A7CA10", Slot = "72")]
	public LEMCJHMHPOI GetTextureAlphaPacking()
	{
		return default(LEMCJHMHPOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "129")]
	public abstract void INKLCJABGBG(bool KNKJJAJKNIH);

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "130")]
	public abstract bool AGMHKENHKEL();

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "131")]
	public abstract void EEPFEBLMELE(float KCEBOMKMFCN);

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "132")]
	public virtual void HGJAAKGMMOM(float JCDNIOGJMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "133")]
	public abstract float AABCLDNCGAB();

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0xAF6BA0", Offset = "0xAF51A0", VA = "0x180AF6BA0", Slot = "134")]
	public virtual float NODDGHBBIKM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0xAF6BB0", Offset = "0xAF51B0", VA = "0x180AF6BB0", Slot = "135")]
	public virtual int KBLBAHEJFKF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "136")]
	public virtual int AFBMEMCFEKI(float[] NGAPFKFLCLD, int IJGMLMABCMI, int MNLBIBCDEJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "137")]
	public virtual void GGIFJIKCMEI(bool KGOLKNKEHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "138")]
	public virtual void FLGEOPAJHAN(Quaternion DALGMGBPEFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "139")]
	public virtual void ANIFEGHKJFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "140")]
	public virtual void INMEAECLLGG(PDNENPFHAGJ JOMJDJGNEAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "141")]
	public virtual void JAHMNNDOODF(bool KBMMNNBFAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "142")]
	public virtual void OGKPAKEBLPE(float MFKPHEAALNG, float IFJLININBML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "143")]
	public virtual void PNDBPHNJNBO(Quaternion DALGMGBPEFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "144")]
	public virtual void NNJPMDIGFFK(string INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "145")]
	public virtual void BMFGLCFJGAK(byte[] HAELBKGFDIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(Slot = "146")]
	public abstract void FPGILMIKMIA();

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "147")]
	public virtual void EMHOKHBGLJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "148")]
	public abstract void CIBAHCGIKDC();

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(Slot = "149")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "150")]
	public virtual void OOPLMPOLGIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D130", Offset = "0x2A7B730", VA = "0x182A7D130", Slot = "40")]
	public GPKOBMFDDOH KJADILHCHIN()
	{
		return default(GPKOBMFDDOH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "151")]
	public virtual bool PJKIEJMLKMG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0xAA5620", Offset = "0xAA3C20", VA = "0x180AA5620", Slot = "39")]
	public EBBOJFJJJBJ HHCECOOJKGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D110", Offset = "0x2A7B710", VA = "0x182A7D110", Slot = "42")]
	public void JNCBCDHJEAI([Out] FilterMode EKACEANNGBC, [Out] TextureWrapMode FELMOEEJFFJ, [Out] int CNGCPBMLFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C7F0", Offset = "0x2A7ADF0", VA = "0x182A7C7F0", Slot = "41")]
	public void FCMFBOPAAHK(FilterMode EKACEANNGBC = FilterMode.Bilinear, TextureWrapMode FELMOEEJFFJ = TextureWrapMode.Clamp, int CNGCPBMLFCK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x2A7CEA0", Offset = "0x2A7B4A0", VA = "0x182A7CEA0", Slot = "152")]
	protected virtual void IKAINHFGJDE(Texture BDFJHOHMCFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C690", Offset = "0x2A7AC90", VA = "0x182A7C690")]
	protected void ECEKKOMGDOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x2A7CC90", Offset = "0x2A7B290", VA = "0x182A7CC90")]
	protected bool IEGEKICDBAD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D320", Offset = "0x2A7B920", VA = "0x182A7D320", Slot = "153")]
	public virtual bool NOPFNILKPGN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x2A7CE10", Offset = "0x2A7B410", VA = "0x182A7CE10", Slot = "77")]
	public bool IFEJJACBMCF(string CDDIADBJAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D140", Offset = "0x2A7B740", VA = "0x182A7D140", Slot = "154")]
	public virtual void LBCFBABDBOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x2A7CE80", Offset = "0x2A7B480", VA = "0x182A7CE80", Slot = "155")]
	public virtual int IJHDEAGBANB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C880", Offset = "0x2A7AE80", VA = "0x182A7C880", Slot = "156")]
	public virtual string FHOHGKPDLMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "157")]
	public virtual void AAOGDOMHBGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C730", Offset = "0x2A7AD30", VA = "0x182A7C730", Slot = "158")]
	public int EOJDBBHJOAP(float AIIEDAGLKIO = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C590", Offset = "0x2A7AB90", VA = "0x182A7C590")]
	protected bool BCJAOHNAANL(bool AKKFOJDOENB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "159")]
	internal abstract bool EDFPHKKNNPO();

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "160")]
	internal abstract string JPGJJFOLKEP();

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(Slot = "161")]
	internal abstract bool GMMPBLCANFL(CFHNNHCENEB CIIOMOICJPM);

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(Slot = "162")]
	internal abstract int LPCNKCBMNKL(CFHNNHCENEB CIIOMOICJPM);

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "163")]
	internal abstract ELFPNEOGMED DMOAHNJOLAH(CFHNNHCENEB CIIOMOICJPM, int OMJDMCDKKOM, bool PADBEBKMHNG);

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C430", Offset = "0x2A7AA30", VA = "0x182A7C430")]
	private void AKAGEBMBCBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D5C0", Offset = "0x2A7BBC0", VA = "0x182A7D5C0")]
	protected void ODGALBJMDIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x2A7CF40", Offset = "0x2A7B540", VA = "0x182A7CF40")]
	private void INLNCOGNBGI(GKPGACNOKDG ADHFKKAKOCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C980", Offset = "0x2A7AF80", VA = "0x182A7C980", Slot = "164")]
	public virtual IEnumerator GetEnumerator()
	{
		return null;
	}
}
namespace RenderHeads.Media.AVProVideo
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class MediaPlayerEvent : UnityEvent<MediaPlayer, MediaPlayerEvent.IHGOHFKGPHI, GPKOBMFDDOH>
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public enum IHGOHFKGPHI
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
		private List<UnityAction<MediaPlayer, IHGOHFKGPHI, GPKOBMFDDOH>> _listeners;

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x2A80650", Offset = "0x2A7EC50", VA = "0x182A80650")]
		public bool ELHNKBAPIAL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x2A80750", Offset = "0x2A7ED50", VA = "0x182A80750")]
		public void POKJHOMPPIE(UnityAction<MediaPlayer, IHGOHFKGPHI, GPKOBMFDDOH> KEOMIGMAGOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x2A806B0", Offset = "0x2A7ECB0", VA = "0x182A806B0")]
		public void IKPLODPKMNN(UnityAction<MediaPlayer, IHGOHFKGPHI, GPKOBMFDDOH> KEOMIGMAGOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x2A80840", Offset = "0x2A7EE40", VA = "0x182A80840")]
		public MediaPlayerEvent()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class LNJBBBOAMEP
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static Matrix4x4 MMHMKPJHMMH;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static Matrix4x4 PHFPCIPOMKD;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static Matrix4x4 KFJNPADIOEI;

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x2A9DB40", Offset = "0x2A9C140", VA = "0x182A9DB40")]
	public static string IJGOLGIHFBE(NOEEEMEECJL MKJJKBDAKLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x2A9DC40", Offset = "0x2A9C240", VA = "0x182A9DC40")]
	public static string KILDHBLKNFF(string BFHDBHOMJKM, NOEEEMEECJL MKJJKBDAKLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x2A9D930", Offset = "0x2A9BF30", VA = "0x182A9D930")]
	public static string FGMJDKEHDFO(GPKOBMFDDOH JEKPMBEJDGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x2A9DE00", Offset = "0x2A9C400", VA = "0x182A9DE00")]
	public static void LFCBCHPCCGI(string GKNICJPCIJJ, [Optional] UnityEngine.Object JIFPJFGEAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x2A9D880", Offset = "0x2A9BE80", VA = "0x182A9D880")]
	public static int EBJPIKBDGLP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x2A9D7F0", Offset = "0x2A9BDF0", VA = "0x182A9D7F0")]
	public static int BGMADGNOLPA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x2A9D090", Offset = "0x2A9B690", VA = "0x182A9D090")]
	public static CCMCGBKFECM AKBNLFEDADM(float[] DHDFDKFCOJK)
	{
		return default(CCMCGBKFECM);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x2A9D8B0", Offset = "0x2A9BEB0", VA = "0x182A9D8B0")]
	public static int EGJNOKGGPPK(double OEDPOHDPEIB, float FGKHNEAFLOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x2A9DA60", Offset = "0x2A9C060", VA = "0x182A9DA60")]
	private static extern int ICGHJCCIDDJ(string MPCDFIAHHDB, StringBuilder JBEFJEDKBIL, int EBLNGKAJDLN);

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x2A9D2A0", Offset = "0x2A9B8A0", VA = "0x182A9D2A0")]
	internal static string AKFCGFIJCOP(string BFHDBHOMJKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x2A9D450", Offset = "0x2A9BA50", VA = "0x182A9D450")]
	public static Texture2D AKHOBIMGHGB(Texture KHAPIEMCDDJ, bool DIJACAABBMM, CCMCGBKFECM OILLCCCHPFN, [Optional] Texture2D KNGIANJFFMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface PKIKBAGFIEA
{
	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AAOGDOMHBGP();

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FPGILMIKMIA();

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OOPLMPOLGIB();

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EMHOKHBGLJA();

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CIBAHCGIKDC();
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface ODFAMAENFHI
{
	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IFEJJACBMCF(string CDDIADBJAOB);

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int IJHDEAGBANB();

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string FHOHGKPDLMI();
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface BJNKAGIHKLB
{
	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MGIJEMLAOMK(string BFHDBHOMJKM, long PIOCNHLFCNE, string EPGILKIPLND, MediaHints BBDABOLANII, int LAEFJHLNJKG = 0, bool INKMBLFADIJ = false);

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ELGHMEPJPHN(byte[] DNGAEEFBGGO);

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NDCKBIOOBNL(ulong NODGHDHCBPE);

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EKKFIBEBLNB(byte[] KGGDFKHMCKC, ulong PIOCNHLFCNE, ulong NODGHDHCBPE);

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FDICDJKGBML();

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LLLBJLFLOEI();

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HOEIMCEDJME(bool BANKPCJNCLC);

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool JCLAEDECLNL();

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BFMPGNCFAON();

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool OADLMFHCCED();

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool FFCNCFEIINJ();

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool DILLOBIIFPB();

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool AIHGMKGEFID();

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool GIGILLFJNAL();

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool CDEFPCKANCA();

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void DJEKLJKIOHB();

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EEEOMJDOMAD();

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MBDDDNAIIMI();

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void GPIJCEACOAA();

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void EHIIACCOAEB(double HBAPMMDKJDM);

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void LJNMPIEKFDA(double HBAPMMDKJDM);

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(Slot = "21")]
	double DIHNIAHJDPA();

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(Slot = "22")]
	float OPGNDEBAPEB();

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void GFCJBNCKHJD(float NFMNHEPLOLF);

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void INKLCJABGBG(bool PHENMKDCGDH);

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool AGMHKENHKEL();

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void EEPFEBLMELE(float KCEBOMKMFCN);

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void HGJAAKGMMOM(float JCDNIOGJMJG);

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "28")]
	float AABCLDNCGAB();

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float NODDGHBBIKM();

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(Slot = "30")]
	EBBOJFJJJBJ HHCECOOJKGO();

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(Slot = "31")]
	GPKOBMFDDOH KJADILHCHIN();

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void FCMFBOPAAHK(FilterMode EKACEANNGBC = FilterMode.Bilinear, TextureWrapMode FELMOEEJFFJ = TextureWrapMode.Clamp, int CNGCPBMLFCK = 1);

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void JNCBCDHJEAI([Out] FilterMode EKACEANNGBC, [Out] TextureWrapMode FELMOEEJFFJ, [Out] int CNGCPBMLFCK);

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(Slot = "34")]
	int AFBMEMCFEKI(float[] DNGAEEFBGGO, int BDAKDFHBKEN, int MNLBIBCDEJH);

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(Slot = "35")]
	int KBLBAHEJFKF();

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void GGIFJIKCMEI(bool KGOLKNKEHEH);

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void INMEAECLLGG(PDNENPFHAGJ JOMJDJGNEAB);

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void FLGEOPAJHAN(Quaternion DALGMGBPEFI);

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void ANIFEGHKJFJ();

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void JAHMNNDOODF(bool KBMMNNBFAAB);

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void OGKPAKEBLPE(float MFKPHEAALNG, float IFJLININBML);

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void PNDBPHNJNBO(Quaternion DALGMGBPEFI);

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(Slot = "43")]
	bool FJGHBHBEKEJ(Camera GANPHOLIACP, int NGKJFGMKGJN);

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void NNJPMDIGFFK(string INEEADCBMPK);

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(Slot = "45")]
	void BMFGLCFJGAK(byte[] HAELBKGFDIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface NBHFEILBFNE
{
	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(Slot = "0")]
	double JPLKDOCIDFK();

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int JNMJBHEIJGI();

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int OMBILPPCFDN();

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float PKOPMLGMCMN();

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KOOPECIKBIC();

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PJKIEJMLKMG();

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NOPFNILKPGN();

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float[] CLEECEANPEP();
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface IFANCPIPNAJ
{
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface EBMAMKKAFPB
{
	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int GetTextureCount();

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Texture GetTexture(int PMIGBJGNLLP = 0);

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
	MPKICFKOEJB GetTextureStereoPacking();

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(Slot = "8")]
	NIOGBCIEHEJ GetTextureTransparency();

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(Slot = "9")]
	LEMCJHMHPOI GetTextureAlphaPacking();

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
	RenderTextureFormat GetCompatibleRenderTextureFormat(NKMHPCLEFEN PLMLGIGGGNL = NKMHPCLEFEN.Default, int CFOILFKCBDC = 0);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[Flags]
public enum NKMHPCLEFEN
{
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	ForResolve = 1,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	RequiresAlpha = 2
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum MONLJLHHPDC
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
public enum HFECFPFPLMM
{
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	Reference,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	Path
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public enum NOEEEMEECJL
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
		private NOEEEMEECJL _pathType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		[SerializeField]
		private string _path;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public NOEEEMEECJL PathType
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180")]
			get
			{
				return default(NOEEEMEECJL);
			}
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0xAA7130", Offset = "0xAA5730", VA = "0x180AA7130")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public string Path
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E980", Offset = "0x2A9CF80", VA = "0x182A9E980")]
		public MediaPath()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E8F0", Offset = "0x2A9CEF0", VA = "0x182A9E8F0")]
		public MediaPath(MediaPath DNNGEDAPBOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E860", Offset = "0x2A9CE60", VA = "0x182A9E860")]
		public MediaPath(string BFHDBHOMJKM, NOEEEMEECJL MAJGFKALHMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E340", Offset = "0x2A9C940", VA = "0x182A9E340")]
		public string GFJIMJLBOPN()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E780", Offset = "0x2A9CD80", VA = "0x182A9E780")]
		public static MediaPath HNGLNPFKABH(string NPKCMCHDHHN)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E840", Offset = "0x2A9CE40", VA = "0x182A9E840")]
		public static bool MGLHCKHANFO(MediaPath JGPEJMANNEB, MediaPath PDHHCOODKIC)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E740", Offset = "0x2A9CD40", VA = "0x182A9E740")]
		public static bool HKOGMNAKMAE(MediaPath JGPEJMANNEB, MediaPath PDHHCOODKIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E240", Offset = "0x2A9C840", VA = "0x182A9E240", Slot = "0")]
		public override bool Equals(object MPIDDJPOOMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E6F0", Offset = "0x2A9CCF0", VA = "0x182A9E6F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public enum MPKICFKOEJB
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
		public NIOGBCIEHEJ transparency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public LEMCJHMHPOI alphaPacking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public MPKICFKOEJB stereoPacking;

		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private static MediaHints defaultHints;

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public static MediaHints Default
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x2A9E1F0", Offset = "0x2A9C7F0", VA = "0x182A9E1F0")]
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
		public enum HJHPJELOFLP
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
		public HJHPJELOFLP aspectRatio;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2740", Offset = "0x2AA0D40", VA = "0x182AA2740")]
		public bool MCEALPJNCOI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x2AA27A0", Offset = "0x2AA0DA0", VA = "0x182AA27A0")]
		internal void PIIDIIEBCBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x2AA26D0", Offset = "0x2AA0CD0", VA = "0x182AA26D0")]
		public static VideoResolveOptions CEAHGFMKGJD()
		{
			return default(VideoResolveOptions);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public enum NIOGBCIEHEJ
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	Opaque,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	Transparent
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public enum BPOPPJHKMKC
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	Both,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	Left,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	Right
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public enum LEMCJHMHPOI
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	TopBottom,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	LeftRight
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public enum GPKOBMFDDOH
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	LoadFailed = 100,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	DecodeFailed = 200
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public enum CCMCGBKFECM
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
public enum JKOMGEDPKMN
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
public enum DFHLPJABCBO
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
public static class DFGLKIFBMJI
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public enum AHNMIKFIJLP
	{
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		MediaFoundation,
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		DirectShow,
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		WinRT
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public enum EKCIMOKNKAD
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
public static class EOPMCDANOAO
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public enum LEILLDAOJFA
	{
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		MediaFoundation,
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		WinRT
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public enum KMNJNMCEGGC
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
public static class EIGNHODLLBB
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public enum NOLPINJKBIM
	{
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		MediaPlayer = 1,
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		ExoPlayer
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class NKOGCMMMHNB
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public enum FBDOIKHMHPA
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
public enum PDNENPFHAGJ
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
public struct KKNIPCDHLCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public double FJOIBADLBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public double KFCMKNFBLHC;
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[DefaultMember("Item")]
public class EBBOJFJJJBJ : IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	internal KKNIPCDHLCH[] DNDAEKOFLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	internal double JDJJJLFAAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	internal double GMFBKGHBAIF;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public int EEGOGBABKAE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x29A3DD0", Offset = "0x29A23D0", VA = "0x1829A3DD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public double IMMCODKILLI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x2A90800", Offset = "0x2A8EE00", VA = "0x182A90800")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public double AEFDHEFHGBI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x2A90810", Offset = "0x2A8EE10", VA = "0x182A90810")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public double DGHPNPEDKAG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x2A907F0", Offset = "0x2A8EDF0", VA = "0x182A907F0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x2A90A50", Offset = "0x2A8F050", VA = "0x182A90A50")]
	internal EBBOJFJJJBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x2A90680", Offset = "0x2A8EC80", VA = "0x182A90680", Slot = "4")]
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x2A90820", Offset = "0x2A8EE20", VA = "0x182A90820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x2A906A0", Offset = "0x2A8ECA0", VA = "0x182A906A0")]
	internal void IAMMOOJEHHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class HJHBEHPKCJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private int HDOOKLCPIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private long ILMDBJFDFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private BJIOHKIAODC BOBNFOBINAN;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public int KNPADBMOBBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xAA7130", Offset = "0xAA5730", VA = "0x180AA7130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public int NFCKEDBGOFD
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xBA16B0", Offset = "0xB9FCB0", VA = "0x180BA16B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0xBA16C0", Offset = "0xB9FCC0", VA = "0x180BA16C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public int BNBJJJKMKDN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xAB04F0", Offset = "0xAAEAF0", VA = "0x180AB04F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xAB2A20", Offset = "0xAB1020", VA = "0x180AB2A20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private float GLJKFNBMHGL
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xEDB240", Offset = "0xED9840", VA = "0x180EDB240")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private string HCBDBGKNHPC
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0xAA70F0", Offset = "0xAA56F0", VA = "0x180AA70F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private int KAKCEDDCDAA
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xAA70A0", Offset = "0xAA56A0", VA = "0x180AA70A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0xAA70B0", Offset = "0xAA56B0", VA = "0x180AA70B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private int EBFPEGACNPH
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xAF64A0", Offset = "0xAF4AA0", VA = "0x180AF64A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x16E2D50", Offset = "0x16E1350", VA = "0x1816E2D50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool PMHGAPICKIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0xAD4490", Offset = "0xAD2A90", VA = "0x180AD4490")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x2A94400", Offset = "0x2A92A00", VA = "0x182A94400")]
	public void JGIFDBJEMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x2A94450", Offset = "0x2A92A50", VA = "0x182A94450")]
	internal void PLMAAMEONBL(BJIOHKIAODC AGIMJJDFEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x2A93AB0", Offset = "0x2A920B0", VA = "0x182A93AB0")]
	internal void FPGILMIKMIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50")]
	private static bool KMHDEFLFDMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public HJHBEHPKCJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public sealed class KACDGJDFJOG : BJIOHKIAODC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private bool GEIOBDJGCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private bool CFFOCJKECCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private double NBLDGKHIFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private float BMOONDLPLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private float OJOMNMIDCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	private bool GNCEKNDHICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private int CGHFOFJHLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private int FAPCKBDOOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	private Texture2D LNGCOJLKIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	private Texture2D AMGKNNEICJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	private Texture2D BEKGIKCAGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	private float AHIOPLBPLIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	private int DHPODKGKPCG;

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x2A978C0", Offset = "0x2A95EC0", VA = "0x182A978C0", Slot = "82")]
	public override string DBBFCOKKLMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x2A97D60", Offset = "0x2A96360", VA = "0x182A97D60", Slot = "83")]
	public override string OCBAJAMEPEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x2A97B70", Offset = "0x2A96170", VA = "0x182A97B70", Slot = "84")]
	public override bool MGIJEMLAOMK(string BFHDBHOMJKM, long PIOCNHLFCNE, string GDKFPGFBDGF, MediaHints PDNBKCFAIFA, int LAEFJHLNJKG = 0, bool INKMBLFADIJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x2A97B20", Offset = "0x2A96120", VA = "0x182A97B20", Slot = "89")]
	public override void LLLBJLFLOEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0xD6E0C0", Offset = "0xD6C6C0", VA = "0x180D6E0C0", Slot = "90")]
	public override void HOEIMCEDJME(bool BANKPCJNCLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x10E1D40", Offset = "0x10E0340", VA = "0x1810E1D40", Slot = "91")]
	public override bool JCLAEDECLNL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "92")]
	public override bool BFMPGNCFAON()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "93")]
	public override bool OADLMFHCCED()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "107")]
	public override bool IGEKNPNCDIP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "108")]
	public override bool KOOPECIKBIC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x2A97900", Offset = "0x2A95F00", VA = "0x182A97900", Slot = "94")]
	public override void DJEKLJKIOHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x2A97920", Offset = "0x2A95F20", VA = "0x182A97920", Slot = "95")]
	public override void EEEOMJDOMAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x2A97B60", Offset = "0x2A96160", VA = "0x182A97B60", Slot = "96")]
	public override void MBDDDNAIIMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "109")]
	public override bool DILLOBIIFPB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0xB78BE0", Offset = "0xB771E0", VA = "0x180B78BE0", Slot = "110")]
	public override bool FFCNCFEIINJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0xB78DC0", Offset = "0xB773C0", VA = "0x180B78DC0", Slot = "111")]
	public override bool AIHGMKGEFID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x2A97AC0", Offset = "0x2A960C0", VA = "0x182A97AC0", Slot = "112")]
	public override bool GIGILLFJNAL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "113")]
	public override bool CDEFPCKANCA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x2A97B10", Offset = "0x2A96110", VA = "0x182A97B10", Slot = "103")]
	public override double JPLKDOCIDFK()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x10E1090", Offset = "0x10DF690", VA = "0x1810E1090", Slot = "104")]
	public override int JNMJBHEIJGI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0xFFE310", Offset = "0xFFC910", VA = "0x180FFE310", Slot = "105")]
	public override int OMBILPPCFDN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0xB364E0", Offset = "0xB34AE0", VA = "0x180B364E0", Slot = "116")]
	public override Texture GetTexture(int PMIGBJGNLLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x17CBE80", Offset = "0x17CA480", VA = "0x1817CBE80", Slot = "117")]
	public override int GetTextureFrameCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0xF3F670", Offset = "0xF3DC70", VA = "0x180F3F670", Slot = "127")]
	internal override MPKICFKOEJB CONIBFNBJAH()
	{
		return default(MPKICFKOEJB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "120")]
	public override bool RequiresVerticalFlip()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x2A97930", Offset = "0x2A95F30", VA = "0x182A97930", Slot = "98")]
	public override void EHIIACCOAEB(double HBAPMMDKJDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x2A97930", Offset = "0x2A95F30", VA = "0x182A97930", Slot = "99")]
	public override void LJNMPIEKFDA(double HBAPMMDKJDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x2A978F0", Offset = "0x2A95EF0", VA = "0x182A978F0", Slot = "100")]
	public override double DIHNIAHJDPA()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x16E7840", Offset = "0x16E5E40", VA = "0x1816E7840", Slot = "102")]
	public override void GFCJBNCKHJD(float NFMNHEPLOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x16E77E0", Offset = "0x16E5DE0", VA = "0x1816E77E0", Slot = "101")]
	public override float OPGNDEBAPEB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "129")]
	public override void INKLCJABGBG(bool KNKJJAJKNIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "130")]
	public override bool AGMHKENHKEL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x1D00BA0", Offset = "0x1CFF1A0", VA = "0x181D00BA0", Slot = "131")]
	public override void EEPFEBLMELE(float KCEBOMKMFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x1D02470", Offset = "0x1D00A70", VA = "0x181D02470", Slot = "133")]
	public override float AABCLDNCGAB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0xAF6BA0", Offset = "0xAF51A0", VA = "0x180AF6BA0", Slot = "106")]
	public override float PKOPMLGMCMN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x2A97940", Offset = "0x2A95F40", VA = "0x182A97940", Slot = "146")]
	public override void FPGILMIKMIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "148")]
	public override void CIBAHCGIKDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "149")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "161")]
	internal override bool GMMPBLCANFL(CFHNNHCENEB CIIOMOICJPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "162")]
	internal override int LPCNKCBMNKL(CFHNNHCENEB CIIOMOICJPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "163")]
	internal override ELFPNEOGMED DMOAHNJOLAH(CFHNNHCENEB CIIOMOICJPM, int PMIGBJGNLLP, bool PADBEBKMHNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "159")]
	internal override bool EDFPHKKNNPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "160")]
	internal override string JPGJJFOLKEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x2A97D80", Offset = "0x2A96380", VA = "0x182A97D80")]
	public KACDGJDFJOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class KIPGOPKLAHH
{
	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public string IBLMINJNBBH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xAA55F0", Offset = "0xAA3BF0", VA = "0x180AA55F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public string FMBEFCNGHJG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public byte[] AAHBBEPKIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xAA70F0", Offset = "0xAA56F0", VA = "0x180AA70F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x2A97E30", Offset = "0x2A96430", VA = "0x182A97E30")]
	public KIPGOPKLAHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x2A97DB0", Offset = "0x2A963B0", VA = "0x182A97DB0")]
	public void ELFNJAKNOMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class KLIKLJEADPD : BJIOHKIAODC
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	private struct GNHNILOPGML
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		internal enum MOIIAHAIKDA
		{
			[Cpp2IlInjected.Token(Token = "0x40002D3")]
			Seekable,
			[Cpp2IlInjected.Token(Token = "0x40002D4")]
			Buffered
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public enum EJMBBBEFHBA
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
		public struct HBNPEIADADE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002DA")]
			public string INEFLACMFDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002DB")]
			public string INEEADCBMPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002DC")]
			public IntPtr GCGJPGCLODI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			public int KJKMNLJPFBN;
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x2A92EE0", Offset = "0x2A914E0", VA = "0x182A92EE0")]
		public static extern bool KPLPKPFMLMB(IntPtr MHKMPBAHOMB, CFHNNHCENEB CIIOMOICJPM);

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x2A92F70", Offset = "0x2A91570", VA = "0x182A92F70")]
		public static extern int LADBJPMDPLI(IntPtr MHKMPBAHOMB, CFHNNHCENEB CIIOMOICJPM);

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x2A91E20", Offset = "0x2A90420", VA = "0x182A91E20")]
		public static extern bool EMCDAJLAPPI(IntPtr MHKMPBAHOMB, CFHNNHCENEB CIIOMOICJPM, int PMIGBJGNLLP, int DHCHLCGGKNB, bool MBBGCENLGFP, StringBuilder NDIENANOGEK, int EDJINIFCHDP, StringBuilder IFHOBNLCCJB, int EFEGECDPPMK);

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x2A92980", Offset = "0x2A90F80", VA = "0x182A92980")]
		public static extern bool IOGGNOFMOEL(IntPtr MHKMPBAHOMB);

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x2A91970", Offset = "0x2A8FF70", VA = "0x182A91970")]
		public static extern IntPtr EIKHLDPCEIH(IntPtr MHKMPBAHOMB);

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x2A93900", Offset = "0x2A91F00", VA = "0x182A93900")]
		public static extern int POKKGKCJNHD(IntPtr OBBEPGDGFFB, [Out] KKNIPCDHLCH[] LLKKLIEPGNP, int HIHAIILJPKA, MOIIAHAIKDA PAOGHGFOGPB);

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x2A92530", Offset = "0x2A90B30", VA = "0x182A92530")]
		public static extern bool HAKAIDJFGEI(bool JMODDBDDDDB);

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x2A92100", Offset = "0x2A90700", VA = "0x182A92100")]
		public static extern void FGPLPNIGCPF();

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x2A93000", Offset = "0x2A91600", VA = "0x182A93000")]
		public static extern IntPtr LJNPBIJMNEH();

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x2A91360", Offset = "0x2A8F960", VA = "0x182A91360")]
		public static extern IntPtr DAKKLIHFLOP(IntPtr MHKMPBAHOMB, DFGLKIFBMJI.AHNMIKFIJLP JLPJCKCLGLP, DFGLKIFBMJI.EKCIMOKNKAD AFLPPJFNONK, bool KIGJBBBIGEC, bool JMPOPIMGIDN, bool FNGGDPHAPKC, bool EOCOLFICOKH, bool HOGJKLILJNC, bool EFJDCACLNAO, string NKJDIFLBFOH, int GOOKBAGJHLH, IntPtr[] GMOFGFCCPGK, uint BIBJDJIMOCD, int OCICBPILBMM, string GDKFPGFBDGF, bool INKMBLFADIJ);

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x2A92490", Offset = "0x2A90A90", VA = "0x182A92490")]
		public static extern IntPtr HAFKAHIJHEA(IntPtr MHKMPBAHOMB, string BFHDBHOMJKM);

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x2A91030", Offset = "0x2A8F630", VA = "0x182A91030")]
		public static extern IntPtr BEKBDOMMBLC(IntPtr MHKMPBAHOMB, byte[] DNGAEEFBGGO, ulong LEKAJABICND, DFGLKIFBMJI.AHNMIKFIJLP JLPJCKCLGLP, DFGLKIFBMJI.EKCIMOKNKAD AFLPPJFNONK, bool KIGJBBBIGEC, bool JMPOPIMGIDN, bool FNGGDPHAPKC, bool EOCOLFICOKH, bool HOGJKLILJNC, bool EFJDCACLNAO, string NKJDIFLBFOH, int GOOKBAGJHLH, IntPtr[] GMOFGFCCPGK, uint BIBJDJIMOCD);

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x2A927D0", Offset = "0x2A90DD0", VA = "0x182A927D0")]
		public static extern IntPtr IFFEAHPFCFG(IntPtr MHKMPBAHOMB, DFGLKIFBMJI.AHNMIKFIJLP JLPJCKCLGLP, ulong LEKAJABICND);

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x2A90D00", Offset = "0x2A8F300", VA = "0x182A90D00")]
		public static extern bool ABPEPAGMJMH(IntPtr MHKMPBAHOMB, byte[] DNGAEEFBGGO, ulong PIOCNHLFCNE, ulong PBDGEBPHJAO);

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x2A932B0", Offset = "0x2A918B0", VA = "0x182A932B0")]
		public static extern IntPtr NOHDIDMFOIP(IntPtr MHKMPBAHOMB, DFGLKIFBMJI.EKCIMOKNKAD AFLPPJFNONK, bool KIGJBBBIGEC, bool JMPOPIMGIDN, bool FNGGDPHAPKC, bool EOCOLFICOKH, bool HOGJKLILJNC, bool EFJDCACLNAO, string NKJDIFLBFOH, int GOOKBAGJHLH, IntPtr[] GMOFGFCCPGK, uint BIBJDJIMOCD);

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x2A91F80", Offset = "0x2A90580", VA = "0x182A91F80")]
		public static extern void FABMOFIINFJ(IntPtr MHKMPBAHOMB);

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x2A93070", Offset = "0x2A91670", VA = "0x182A93070")]
		public static extern IntPtr LOHPNPGINLD(IntPtr MHKMPBAHOMB);

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x2A91740", Offset = "0x2A8FD40", VA = "0x182A91740")]
		public static extern void DMGNDCIHELK(IntPtr MHKMPBAHOMB, bool KBMMNNBFAAB);

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x2A92170", Offset = "0x2A90770", VA = "0x182A92170")]
		public static extern void FHNOGDGNIDJ(IntPtr MHKMPBAHOMB, bool KBMMNNBFAAB);

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x2A92D40", Offset = "0x2A91340", VA = "0x182A92D40")]
		public static extern void KIOPCIIHPLB(IntPtr MHKMPBAHOMB, bool KBMMNNBFAAB);

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x2A92E50", Offset = "0x2A91450", VA = "0x182A92E50")]
		public static extern void KPHBPHKLKKB(IntPtr MHKMPBAHOMB, bool KBMMNNBFAAB);

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x2A90DC0", Offset = "0x2A8F3C0", VA = "0x182A90DC0")]
		public static extern void ADMHKLJKKFF(IntPtr MHKMPBAHOMB, bool KBMMNNBFAAB, bool BFGFFCCGOPN, double DFNGNEGKPBE);

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x2A918E0", Offset = "0x2A8FEE0", VA = "0x182A918E0")]
		public static extern void EIKFCLDFEJN(IntPtr MHKMPBAHOMB, bool KBMMNNBFAAB);

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x2A92A90", Offset = "0x2A91090", VA = "0x182A92A90")]
		public static extern void JICIIHAEECB(IntPtr MHKMPBAHOMB, int EEEAGOBDKFD, int EFEJAPPCFKJ);

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x2A93720", Offset = "0x2A91D20", VA = "0x182A93720")]
		public static extern int PBBAAABLEHE(IntPtr MHKMPBAHOMB);

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x2A91620", Offset = "0x2A8FC20", VA = "0x182A91620")]
		public static extern void DJEKLJKIOHB(IntPtr MHKMPBAHOMB);

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x2A917D0", Offset = "0x2A8FDD0", VA = "0x182A917D0")]
		public static extern void EEEOMJDOMAD(IntPtr MHKMPBAHOMB);

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x2A92B30", Offset = "0x2A91130", VA = "0x182A92B30")]
		public static extern void JMAPNBOBODP(IntPtr MHKMPBAHOMB, bool AOHHJPIIFJE);

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x2A91850", Offset = "0x2A8FE50", VA = "0x182A91850")]
		public static extern void EEPFEBLMELE(IntPtr MHKMPBAHOMB, float KCEBOMKMFCN);

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x2A925B0", Offset = "0x2A90BB0", VA = "0x182A925B0")]
		public static extern void HGJAAKGMMOM(IntPtr MHKMPBAHOMB, float KCEBOMKMFCN);

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x2A926C0", Offset = "0x2A90CC0", VA = "0x182A926C0")]
		public static extern void HOEIMCEDJME(IntPtr MHKMPBAHOMB, bool MDKPABOIECP);

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x2A92DD0", Offset = "0x2A913D0", VA = "0x182A92DD0")]
		public static extern bool KOOPECIKBIC(IntPtr MHKMPBAHOMB);

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x2A92870", Offset = "0x2A90E70", VA = "0x182A92870")]
		public static extern bool IGEKNPNCDIP(IntPtr MHKMPBAHOMB);

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x2A92080", Offset = "0x2A90680", VA = "0x182A92080")]
		public static extern int FGFHGPBIFCJ(IntPtr MHKMPBAHOMB);

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x2A90FB0", Offset = "0x2A8F5B0", VA = "0x182A90FB0")]
		public static extern int APOACEGGBOB(IntPtr MHKMPBAHOMB);

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x2A92BC0", Offset = "0x2A911C0", VA = "0x182A92BC0")]
		public static extern float JOJLOLHFIJF(IntPtr MHKMPBAHOMB);

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x2A92750", Offset = "0x2A90D50", VA = "0x182A92750")]
		public static extern MPKICFKOEJB HPAKCMBIAAC(IntPtr MHKMPBAHOMB);

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x2A92C40", Offset = "0x2A91240", VA = "0x182A92C40")]
		public static extern double JPLKDOCIDFK(IntPtr MHKMPBAHOMB);

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x2A93430", Offset = "0x2A91A30", VA = "0x182A93430")]
		public static extern bool NOPFNILKPGN(IntPtr MHKMPBAHOMB);

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x2A911E0", Offset = "0x2A8F7E0", VA = "0x182A911E0")]
		public static extern bool BFMPGNCFAON(IntPtr MHKMPBAHOMB);

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x2A934B0", Offset = "0x2A91AB0", VA = "0x182A934B0")]
		public static extern bool OADLMFHCCED(IntPtr MHKMPBAHOMB);

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x2A915A0", Offset = "0x2A8FBA0", VA = "0x182A915A0")]
		public static extern bool DILLOBIIFPB(IntPtr MHKMPBAHOMB);

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x2A92000", Offset = "0x2A90600", VA = "0x182A92000")]
		public static extern bool FFCNCFEIINJ(IntPtr MHKMPBAHOMB);

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x2A92310", Offset = "0x2A90910", VA = "0x182A92310")]
		public static extern bool GIGILLFJNAL(IntPtr MHKMPBAHOMB);

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x2A912E0", Offset = "0x2A8F8E0", VA = "0x182A912E0")]
		public static extern bool CDEFPCKANCA(IntPtr MHKMPBAHOMB);

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x2A91520", Offset = "0x2A8FB20", VA = "0x182A91520")]
		public static extern double DIHNIAHJDPA(IntPtr MHKMPBAHOMB);

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x2A916A0", Offset = "0x2A8FCA0", VA = "0x182A916A0")]
		public static extern void DKNPALLCFHJ(IntPtr MHKMPBAHOMB, double HBAPMMDKJDM, bool KHGLDEMKJAO);

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x2A93630", Offset = "0x2A91C30", VA = "0x182A93630")]
		public static extern float OPGNDEBAPEB(IntPtr MHKMPBAHOMB);

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x2A92280", Offset = "0x2A90880", VA = "0x182A92280")]
		public static extern void GFCJBNCKHJD(IntPtr MHKMPBAHOMB, float NFMNHEPLOLF);

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x2A930F0", Offset = "0x2A916F0", VA = "0x182A930F0")]
		public static extern void MAEPGKLCCGB(IntPtr MHKMPBAHOMB);

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x2A93A30", Offset = "0x2A92030", VA = "0x182A93A30")]
		public static extern void POMKLEIPAAP(IntPtr MHKMPBAHOMB);

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x2A92200", Offset = "0x2A90800", VA = "0x182A92200")]
		public static extern void FPGILMIKMIA(IntPtr MHKMPBAHOMB);

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x2A935B0", Offset = "0x2A91BB0", VA = "0x182A935B0")]
		public static extern void OOPLMPOLGIB(IntPtr MHKMPBAHOMB);

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x2A90F30", Offset = "0x2A8F530", VA = "0x182A90F30")]
		public static extern IntPtr AMNMNBMDAPB(IntPtr MHKMPBAHOMB);

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x2A91260", Offset = "0x2A8F860", VA = "0x182A91260")]
		public static extern int BKANPMNMFKI(IntPtr MHKMPBAHOMB);

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x2A93230", Offset = "0x2A91830", VA = "0x182A93230")]
		public static extern bool NGLOEELFOLC(IntPtr MHKMPBAHOMB);

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x2A93530", Offset = "0x2A91B30", VA = "0x182A93530")]
		public static extern bool OJMNBLKAADL(IntPtr MHKMPBAHOMB);

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x2A92410", Offset = "0x2A90A10", VA = "0x182A92410")]
		public static extern int GPJPDIHBLKL(IntPtr MHKMPBAHOMB);

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x2A92390", Offset = "0x2A90990", VA = "0x182A92390")]
		public static extern long GJIEHOIDJCP(IntPtr MHKMPBAHOMB);

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x2A92640", Offset = "0x2A90C40", VA = "0x182A92640")]
		public static extern float HLAFDKGFNGH(IntPtr MHKMPBAHOMB);

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x2A936B0", Offset = "0x2A91CB0", VA = "0x182A936B0")]
		public static extern IntPtr PAIDGBGPGGD();

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x2A90E70", Offset = "0x2A8F470", VA = "0x182A90E70")]
		public static extern int AFBMEMCFEKI(IntPtr MHKMPBAHOMB, float[] DNGAEEFBGGO, int BDAKDFHBKEN, int MNLBIBCDEJH);

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x2A92CC0", Offset = "0x2A912C0", VA = "0x182A92CC0")]
		public static extern int KBLBAHEJFKF(IntPtr MHKMPBAHOMB);

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x2A928F0", Offset = "0x2A90EF0", VA = "0x182A928F0")]
		public static extern int INMEAECLLGG(IntPtr MHKMPBAHOMB, int OCICBPILBMM);

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x2A93170", Offset = "0x2A91770", VA = "0x182A93170")]
		public static extern void NCCDNCFJCMG(IntPtr MHKMPBAHOMB, float GBNAKFLHCOE, float ODEKEFJCIIL, float CNCKLOHMBJK, float KCJIIGKAPGH);

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x2A92A00", Offset = "0x2A91000", VA = "0x182A92A00")]
		public static extern void JAHMNNDOODF(IntPtr MHKMPBAHOMB, bool KBMMNNBFAAB);

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x2A937A0", Offset = "0x2A91DA0", VA = "0x182A937A0")]
		public static extern void PDJOFJCGDPJ(IntPtr MHKMPBAHOMB, float MFKPHEAALNG, float IFJLININBML);

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x2A93840", Offset = "0x2A91E40", VA = "0x182A93840")]
		public static extern void PNDBPHNJNBO(IntPtr MHKMPBAHOMB, float GBNAKFLHCOE, float ODEKEFJCIIL, float CNCKLOHMBJK, float KCJIIGKAPGH);

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x2A919F0", Offset = "0x2A8FFF0", VA = "0x182A919F0")]
		public static void EKECAJMDKOM(IntPtr MHKMPBAHOMB, KIPGOPKLAHH HINKALOKMCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x2A91CC0", Offset = "0x2A902C0", VA = "0x182A91CC0")]
		private static extern void EKECAJMDKOM(IntPtr MHKMPBAHOMB, HBNPEIADADE EOJLDHFDHEB);
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	private DFGLKIFBMJI.EKCIMOKNKAD OKMEIPDJAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	private string KPFDIJGMPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	private List<string> EELMDILGFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	private PDNENPFHAGJ CBCIFJFMCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	private bool DDMALLADKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC5")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	private bool FBCAHMFEOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC6")]
	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	private bool COEAFCHIPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC7")]
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	private bool LNLMNLIJLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	private bool HMABCGFIHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	private bool GABKAPPGMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	private int KHLPLGPPKEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	private int GMAGIIIOHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	private bool GEIOBDJGCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD5")]
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	private bool CFFOCJKECCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD6")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	private bool GLILPOJAHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private float BMOONDLPLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private float FFNNDKKABJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private bool KANBHLFCHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private bool EPAJBMCMBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE2")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private bool EPBECIMMINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private int MKGNILBIDJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private int FAPCKBDOOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private float CJOIGJIJHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private bool DPLMICLANKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF1")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	private bool HCOHANPAGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF2")]
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	private bool LIICHDOBFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	private IntPtr CAOFGDAHADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	private Texture2D LNGCOJLKIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	private RenderTexture NEJKAJKFEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	private IntPtr BICCGKMJHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private DFGLKIFBMJI.AHNMIKFIJLP DJBHHJIJFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private bool IGJMHJIHHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11D")]
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private bool JJCPOLBGDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11E")]
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	private bool DBJPFGHBMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11F")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	private bool CFBNPGDPLKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	private bool NBMGKLMCLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x121")]
	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	private bool GGMNLLFDHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x122")]
	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	private bool EPBLAEMNGBP;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	private static bool AFIPCFKGCFK;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	private static string AJHHABOEBCH;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	private static IntPtr FCMPDNHIMFF;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	private static int CHNNELDMINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	private KIPGOPKLAHH JEGHPBLIFBG;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public KIPGOPKLAHH NCAAIPFLNGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x2A983B0", Offset = "0x2A969B0", VA = "0x182A983B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x2A9B080", Offset = "0x2A99680", VA = "0x182A9B080")]
	public static bool HCKKMHMKFLL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x2A9B560", Offset = "0x2A99B60", VA = "0x182A9B560")]
	public static void HPLEOEHOPIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x2A9BA60", Offset = "0x2A9A060", VA = "0x182A9BA60", Slot = "135")]
	public override int KBLBAHEJFKF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x2A9CD70", Offset = "0x2A9B370", VA = "0x182A9CD70")]
	public KLIKLJEADPD(MediaPlayer.OptionsWindows PLMLGIGGGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x2A984F0", Offset = "0x2A96AF0", VA = "0x182A984F0")]
	public void CNCAHFMOABE(MediaPlayer.OptionsWindows PLMLGIGGGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x2A985A0", Offset = "0x2A96BA0", VA = "0x182A985A0")]
	public void CNCAHFMOABE(DFGLKIFBMJI.AHNMIKFIJLP JLPJCKCLGLP, DFGLKIFBMJI.EKCIMOKNKAD AFLPPJFNONK, bool KIGJBBBIGEC, bool JMPOPIMGIDN, bool BGBNGHBEPDL, bool EFJDCACLNAO, bool EOCOLFICOKH, bool HOGJKLILJNC, string ILJPHPAFJNM, List<string> EOMDFPAPDOJ, bool OPMADEIMGHC, int EEEAGOBDKFD, int EFEJAPPCFKJ, bool MKDPPGBOACE, bool BJIGJPNAGMJ, bool IODGLCJADMJ, bool PJEINDCMFNL, bool MDAGPPAHNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x2A98860", Offset = "0x2A96E60", VA = "0x182A98860", Slot = "82")]
	public override string DBBFCOKKLMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x2A9CA50", Offset = "0x2A9B050", VA = "0x182A9CA50", Slot = "83")]
	public override string OCBAJAMEPEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x2A9CCD0", Offset = "0x2A9B2D0", VA = "0x182A9CCD0")]
	private bool PPIFABNNJNI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x2A9BE80", Offset = "0x2A9A480", VA = "0x182A9BE80", Slot = "84")]
	public override bool MGIJEMLAOMK(string BFHDBHOMJKM, long PIOCNHLFCNE, string GDKFPGFBDGF, MediaHints PDNBKCFAIFA, int LAEFJHLNJKG = 0, bool INKMBLFADIJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x2A99100", Offset = "0x2A97700", VA = "0x182A99100", Slot = "85")]
	public override bool ELGHMEPJPHN(byte[] DNGAEEFBGGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x2A9C840", Offset = "0x2A9AE40", VA = "0x182A9C840", Slot = "86")]
	public override bool NDCKBIOOBNL(ulong NODGHDHCBPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x2A99040", Offset = "0x2A97640", VA = "0x182A99040", Slot = "87")]
	public override bool EKKFIBEBLNB(byte[] KGGDFKHMCKC, ulong PIOCNHLFCNE, ulong NODGHDHCBPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x2A99650", Offset = "0x2A97C50", VA = "0x182A99650", Slot = "88")]
	public override bool FDICDJKGBML()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x2A97FB0", Offset = "0x2A965B0", VA = "0x182A97FB0")]
	private void AKBOJCCMNFP(string BFHDBHOMJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x2A9BC20", Offset = "0x2A9A220", VA = "0x182A9BC20", Slot = "89")]
	public override void LLLBJLFLOEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x2A9B540", Offset = "0x2A99B40", VA = "0x182A9B540", Slot = "90")]
	public override void HOEIMCEDJME(bool MDKPABOIECP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0xB78BC0", Offset = "0xB771C0", VA = "0x180B78BC0", Slot = "91")]
	public override bool JCLAEDECLNL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0xB78B90", Offset = "0xB77190", VA = "0x180B78B90", Slot = "92")]
	public override bool BFMPGNCFAON()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x176CF50", Offset = "0x176B550", VA = "0x18176CF50", Slot = "107")]
	public override bool IGEKNPNCDIP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x268F8F0", Offset = "0x268DEF0", VA = "0x18268F8F0", Slot = "108")]
	public override bool KOOPECIKBIC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0xB78FB0", Offset = "0xB775B0", VA = "0x180B78FB0", Slot = "93")]
	public override bool OADLMFHCCED()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x2A98AA0", Offset = "0x2A970A0", VA = "0x182A98AA0", Slot = "94")]
	public override void DJEKLJKIOHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x2A98F70", Offset = "0x2A97570", VA = "0x182A98F70", Slot = "95")]
	public override void EEEOMJDOMAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x2A96C00", Offset = "0x2A95200", VA = "0x182A96C00", Slot = "96")]
	public override void MBDDDNAIIMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x2A98A10", Offset = "0x2A97010", VA = "0x182A98A10", Slot = "109")]
	public override bool DILLOBIIFPB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x2A9A060", Offset = "0x2A98660", VA = "0x182A9A060", Slot = "110")]
	public override bool FFCNCFEIINJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x2A97F70", Offset = "0x2A96570", VA = "0x182A97F70", Slot = "111")]
	public override bool AIHGMKGEFID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x2A9AD50", Offset = "0x2A99350", VA = "0x182A9AD50", Slot = "112")]
	public override bool GIGILLFJNAL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x2A98320", Offset = "0x2A96920", VA = "0x182A98320", Slot = "113")]
	public override bool CDEFPCKANCA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x2A9B9E0", Offset = "0x2A99FE0", VA = "0x182A9B9E0", Slot = "103")]
	public override double JPLKDOCIDFK()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x1F625E0", Offset = "0x1F60BE0", VA = "0x181F625E0", Slot = "104")]
	public override int JNMJBHEIJGI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0xB49E80", Offset = "0xB48480", VA = "0x180B49E80", Slot = "105")]
	public override int OMBILPPCFDN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x22A22F0", Offset = "0x22A08F0", VA = "0x1822A22F0", Slot = "106")]
	public override float PKOPMLGMCMN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x2A9AFE0", Offset = "0x2A995E0", VA = "0x182A9AFE0", Slot = "116")]
	public override Texture GetTexture(int PMIGBJGNLLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x2A9AEA0", Offset = "0x2A994A0", VA = "0x182A9AEA0", Slot = "117")]
	public override int GetTextureFrameCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x2A9AF60", Offset = "0x2A99560", VA = "0x182A9AF60", Slot = "119")]
	public override long GetTextureTimeStamp()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x2A9AEB0", Offset = "0x2A994B0", VA = "0x182A9AEB0", Slot = "121")]
	public override float GetTexturePixelAspectRatio()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x2713EB0", Offset = "0x27124B0", VA = "0x182713EB0", Slot = "120")]
	public override bool RequiresVerticalFlip()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x2A987E0", Offset = "0x2A96DE0", VA = "0x182A987E0", Slot = "127")]
	internal override MPKICFKOEJB CONIBFNBJAH()
	{
		return default(MPKICFKOEJB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x2A99020", Offset = "0x2A97620", VA = "0x182A99020", Slot = "98")]
	public override void EHIIACCOAEB(double HBAPMMDKJDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x2A9BB50", Offset = "0x2A9A150", VA = "0x182A9BB50", Slot = "99")]
	public override void LJNMPIEKFDA(double HBAPMMDKJDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x2A98990", Offset = "0x2A96F90", VA = "0x182A98990", Slot = "100")]
	public override double DIHNIAHJDPA()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x2A9ACC0", Offset = "0x2A992C0", VA = "0x182A9ACC0", Slot = "102")]
	public override void GFCJBNCKHJD(float NFMNHEPLOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x2A9CBA0", Offset = "0x2A9B1A0", VA = "0x182A9CBA0", Slot = "101")]
	public override float OPGNDEBAPEB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x2A9B610", Offset = "0x2A99C10", VA = "0x182A9B610", Slot = "129")]
	public override void INKLCJABGBG(bool KNKJJAJKNIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x2713E50", Offset = "0x2712450", VA = "0x182713E50", Slot = "130")]
	public override bool AGMHKENHKEL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x2A99000", Offset = "0x2A97600", VA = "0x182A99000", Slot = "131")]
	public override void EEPFEBLMELE(float KCEBOMKMFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0xC2EB20", Offset = "0xC2D120", VA = "0x180C2EB20", Slot = "133")]
	public override float AABCLDNCGAB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x2A9B4A0", Offset = "0x2A99AA0", VA = "0x182A9B4A0", Slot = "132")]
	public override void HGJAAKGMMOM(float JCDNIOGJMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x1FF1EF0", Offset = "0x1FF04F0", VA = "0x181FF1EF0", Slot = "134")]
	public override float NODDGHBBIKM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x2A9C9A0", Offset = "0x2A9AFA0", VA = "0x182A9C9A0", Slot = "153")]
	public override bool NOPFNILKPGN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x2A9A070", Offset = "0x2A98670", VA = "0x182A9A070", Slot = "114")]
	public override bool FJGHBHBEKEJ(Camera GANPHOLIACP, int NGKJFGMKGJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x2A9B6A0", Offset = "0x2A99CA0", VA = "0x182A9B6A0", Slot = "140")]
	public override void INMEAECLLGG(PDNENPFHAGJ JOMJDJGNEAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x2A9A240", Offset = "0x2A98840", VA = "0x182A9A240", Slot = "138")]
	public override void FLGEOPAJHAN(Quaternion DALGMGBPEFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x2A981B0", Offset = "0x2A967B0", VA = "0x182A981B0", Slot = "139")]
	public override void ANIFEGHKJFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x2A9B860", Offset = "0x2A99E60", VA = "0x182A9B860", Slot = "141")]
	public override void JAHMNNDOODF(bool KBMMNNBFAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x2A9CA80", Offset = "0x2A9B080", VA = "0x182A9CA80", Slot = "142")]
	public override void OGKPAKEBLPE(float MFKPHEAALNG, float IFJLININBML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x2A9CC20", Offset = "0x2A9B220", VA = "0x182A9CC20", Slot = "143")]
	public override void PNDBPHNJNBO(Quaternion DALGMGBPEFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x2A9A280", Offset = "0x2A98880", VA = "0x182A9A280", Slot = "146")]
	public override void FPGILMIKMIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x2A9B730", Offset = "0x2A99D30", VA = "0x182A9B730")]
	private void IOFDPKEOKPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x2A99A30", Offset = "0x2A98030", VA = "0x182A99A30")]
	private void FDPMMBJGJLP(IntPtr KKAIFMHNJAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x2A9CB20", Offset = "0x2A9B120", VA = "0x182A9CB20", Slot = "150")]
	public override void OOPLMPOLGIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
	private void NEBHOHHCKNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x2A99590", Offset = "0x2A97B90", VA = "0x182A99590", Slot = "147")]
	public override void EMHOKHBGLJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x2A983F0", Offset = "0x2A969F0", VA = "0x182A983F0", Slot = "148")]
	public override void CIBAHCGIKDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "149")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x2A97EB0", Offset = "0x2A964B0", VA = "0x182A97EB0", Slot = "136")]
	public override int AFBMEMCFEKI(float[] DNGAEEFBGGO, int BDAKDFHBKEN, int MNLBIBCDEJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x22F96A0", Offset = "0x22F7CA0", VA = "0x1822F96A0", Slot = "151")]
	public override bool PJKIEJMLKMG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x2A988B0", Offset = "0x2A96EB0", VA = "0x182A988B0")]
	private static void DBHCAFKMFGA(GNHNILOPGML.EJMBBBEFHBA NFCCDILHFDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x2A9BB70", Offset = "0x2A9A170", VA = "0x182A9BB70")]
	private static string LJNPBIJMNEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x2A98EE0", Offset = "0x2A974E0", VA = "0x182A98EE0", Slot = "159")]
	internal override bool EDFPHKKNNPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x2A9B8F0", Offset = "0x2A99EF0", VA = "0x182A9B8F0", Slot = "160")]
	internal override string JPGJJFOLKEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x2A9AE00", Offset = "0x2A99400", VA = "0x182A9AE00", Slot = "161")]
	internal override bool GMMPBLCANFL(CFHNNHCENEB CIIOMOICJPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x2A9BDE0", Offset = "0x2A9A3E0", VA = "0x182A9BDE0", Slot = "162")]
	internal override int LPCNKCBMNKL(CFHNNHCENEB CIIOMOICJPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x2A98B30", Offset = "0x2A97130", VA = "0x182A98B30", Slot = "163")]
	internal override ELFPNEOGMED DMOAHNJOLAH(CFHNNHCENEB CIIOMOICJPM, int OMJDMCDKKOM, bool PADBEBKMHNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x2A9C940", Offset = "0x2A9AF40", VA = "0x182A9C940", Slot = "144")]
	public override void NNJPMDIGFFK(string INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x2A982C0", Offset = "0x2A968C0", VA = "0x182A982C0", Slot = "145")]
	public override void BMFGLCFJGAK(byte[] HAELBKGFDIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x2A9BAE0", Offset = "0x2A9A0E0", VA = "0x182A9BAE0")]
	private void LJNEEJLPOHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x2A980E0", Offset = "0x2A966E0", VA = "0x182A980E0")]
	private void ALEKKNFHECL(KKNIPCDHLCH[] ICKFEKPLGLA, GNHNILOPGML.MOIIAHAIKDA PAOGHGFOGPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public enum LAABLLOLABO
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
public sealed class IPPJPDPNOGH : BJIOHKIAODC
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	private struct CMHPFIIJLMO
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		public enum JEEGNIKCKDH
		{
			[Cpp2IlInjected.Token(Token = "0x40002F3")]
			Fast,
			[Cpp2IlInjected.Token(Token = "0x40002F4")]
			Accurate
		}

		[StructLayout((LayoutKind)0, Pack = 1, Size = 20)]
		[Cpp2IlInjected.Token(Token = "0x2000065")]
		public struct IFKIJAENEBE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002F5")]
			public int OMJDMCDKKOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002F6")]
			public int DBEFBHPHFDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002F7")]
			public int GIGBGPHMNGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40002F8")]
			public float FGKHNEAFLOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002F9")]
			public uint PIDFMFFINKH;
		}

		[StructLayout((LayoutKind)0, Pack = 1, Size = 12)]
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		public struct JGHIJDCHKJN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002FA")]
			public double DFNGNEGKPBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002FB")]
			public JEEGNIKCKDH IBLGEJEKAPD;
		}

		[StructLayout((LayoutKind)0, Pack = 1, Size = 28)]
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		public struct IMMPKBLMAEP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002FC")]
			public string INEFLACMFDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002FD")]
			public string INEEADCBMPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002FE")]
			public IntPtr GCGJPGCLODI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002FF")]
			public int KJKMNLJPFBN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		internal enum GNMPLFKAAIF
		{
			[Cpp2IlInjected.Token(Token = "0x4000301")]
			Seekable,
			[Cpp2IlInjected.Token(Token = "0x4000302")]
			Buffered
		}

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private static IntPtr FCMPDNHIMFF;

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D1F0", Offset = "0x2A8B7F0", VA = "0x182A8D1F0")]
		public static extern bool KPLPKPFMLMB(IntPtr MHKMPBAHOMB, CFHNNHCENEB CIIOMOICJPM);

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D280", Offset = "0x2A8B880", VA = "0x182A8D280")]
		public static extern int LADBJPMDPLI(IntPtr MHKMPBAHOMB, CFHNNHCENEB CIIOMOICJPM);

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x2A8CAD0", Offset = "0x2A8B0D0", VA = "0x182A8CAD0")]
		public static extern bool EMCDAJLAPPI(IntPtr MHKMPBAHOMB, CFHNNHCENEB CIIOMOICJPM, int PMIGBJGNLLP, int DHCHLCGGKNB, bool MBBGCENLGFP, StringBuilder NDIENANOGEK, int EDJINIFCHDP, StringBuilder IFHOBNLCCJB, int EFEGECDPPMK);

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D0F0", Offset = "0x2A8B6F0", VA = "0x182A8D0F0")]
		public static extern bool IOGGNOFMOEL(IntPtr MHKMPBAHOMB);

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C620", Offset = "0x2A8AC20", VA = "0x182A8C620")]
		public static extern IntPtr EIKHLDPCEIH(IntPtr MHKMPBAHOMB);

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D310", Offset = "0x2A8B910", VA = "0x182A8D310")]
		private static extern IntPtr LBLMKKJBMME();

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D450", Offset = "0x2A8BA50", VA = "0x182A8D450")]
		public static string LJNPBIJMNEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D7C0", Offset = "0x2A8BDC0", VA = "0x182A8D7C0")]
		public static extern IntPtr NFPAAIBODHB();

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x2A8CF60", Offset = "0x2A8B560", VA = "0x182A8CF60")]
		public static extern void HENMOPCGJNB(IntPtr OBBEPGDGFFB);

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D6E0", Offset = "0x2A8BCE0", VA = "0x182A8D6E0")]
		public static extern bool MGIJEMLAOMK(IntPtr OBBEPGDGFFB, string FOJGLONLCLC, string GDKFPGFBDGF, DFHLPJABCBO PCIDIFHFFDM, bool INKMBLFADIJ, bool EFJDCACLNAO);

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D590", Offset = "0x2A8BB90", VA = "0x182A8D590")]
		public static extern void LLLBJLFLOEI(IntPtr OBBEPGDGFFB);

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C510", Offset = "0x2A8AB10", VA = "0x182A8C510")]
		public static extern void EEEOMJDOMAD(IntPtr OBBEPGDGFFB);

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C490", Offset = "0x2A8AA90", VA = "0x182A8C490")]
		public static extern void DJEKLJKIOHB(IntPtr OBBEPGDGFFB);

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x2A8CC30", Offset = "0x2A8B230", VA = "0x182A8CC30")]
		public static extern void FEHPHNACLKH(IntPtr OBBEPGDGFFB, float KCEBOMKMFCN);

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C330", Offset = "0x2A8A930", VA = "0x182A8C330")]
		public static extern void AEODKLBLKOK(IntPtr OBBEPGDGFFB, float JCDNIOGJMJG);

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x2A8CE40", Offset = "0x2A8B440", VA = "0x182A8CE40")]
		public static extern void GFCJBNCKHJD(IntPtr OBBEPGDGFFB, float NFMNHEPLOLF);

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D500", Offset = "0x2A8BB00", VA = "0x182A8D500")]
		public static extern void LLFFBCGOFNJ(IntPtr OBBEPGDGFFB, bool AOHHJPIIFJE);

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x2A8CCC0", Offset = "0x2A8B2C0", VA = "0x182A8CCC0")]
		public static extern bool FEMKOFJCPLI(IntPtr OBBEPGDGFFB);

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D830", Offset = "0x2A8BE30", VA = "0x182A8D830")]
		public static extern float NHGCLBBIAMD(IntPtr OBBEPGDGFFB);

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D940", Offset = "0x2A8BF40", VA = "0x182A8D940")]
		public static extern float OPGNDEBAPEB(IntPtr OBBEPGDGFFB);

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x2A8CFE0", Offset = "0x2A8B5E0", VA = "0x182A8CFE0")]
		public static extern void HOEIMCEDJME(IntPtr OBBEPGDGFFB, bool MDKPABOIECP);

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DA30", Offset = "0x2A8C030", VA = "0x182A8DA30")]
		public static extern int PBBAAABLEHE(IntPtr OBBEPGDGFFB);

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x2A8CD40", Offset = "0x2A8B340", VA = "0x182A8CD40")]
		public static extern void FPGILMIKMIA(IntPtr OBBEPGDGFFB);

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D170", Offset = "0x2A8B770", VA = "0x182A8D170")]
		public static extern double JPLKDOCIDFK(IntPtr OBBEPGDGFFB);

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D070", Offset = "0x2A8B670", VA = "0x182A8D070")]
		public static extern MPKICFKOEJB HPAKCMBIAAC(IntPtr OBBEPGDGFFB);

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x2A8CDC0", Offset = "0x2A8B3C0", VA = "0x182A8CDC0")]
		public static extern double FPMEJFMKNLL(IntPtr OBBEPGDGFFB);

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D380", Offset = "0x2A8B980", VA = "0x182A8D380")]
		public static extern bool LIMNHDKKKPI(IntPtr OBBEPGDGFFB, [Out] IntPtr KDFLDKDJFAD, [Out] IntPtr CKADICCKCEL, [Out] ulong NHIJAODHEHI, [Out] int EPJLFMHGDCC, [Out] int GHDHPPBLHGA);

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DAB0", Offset = "0x2A8C0B0", VA = "0x182A8DAB0")]
		public static extern LAABLLOLABO PGPCJDCOBJE(IntPtr OBBEPGDGFFB);

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D8B0", Offset = "0x2A8BEB0", VA = "0x182A8D8B0")]
		public static extern bool NKKAKMCIDMA(IntPtr OBBEPGDGFFB, [Out] IFKIJAENEBE MOAEEGOHCNH);

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x2A8CED0", Offset = "0x2A8B4D0", VA = "0x182A8CED0")]
		public static extern void GKOJKGJCBPM(IntPtr OBBEPGDGFFB, double OEDPOHDPEIB);

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C590", Offset = "0x2A8AB90", VA = "0x182A8C590")]
		public static extern void EHIIACCOAEB(IntPtr OBBEPGDGFFB, JGHIJDCHKJN OAHFABHLLCM);

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C800", Offset = "0x2A8AE00", VA = "0x182A8C800")]
		public static void EKECAJMDKOM(IntPtr OBBEPGDGFFB, KIPGOPKLAHH HINKALOKMCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C6A0", Offset = "0x2A8ACA0", VA = "0x182A8C6A0")]
		private static extern void EKECAJMDKOM(IntPtr OBBEPGDGFFB, IMMPKBLMAEP EOJLDHFDHEB);

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DB30", Offset = "0x2A8C130", VA = "0x182A8DB30")]
		public static extern int POKKGKCJNHD(IntPtr OBBEPGDGFFB, [Out] KKNIPCDHLCH[] LLKKLIEPGNP, int HIHAIILJPKA, GNMPLFKAAIF PAOGHGFOGPB);

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D9C0", Offset = "0x2A8BFC0", VA = "0x182A8D9C0")]
		public static extern IntPtr PAIDGBGPGGD();

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C3C0", Offset = "0x2A8A9C0", VA = "0x182A8C3C0")]
		public static void DDHCCKOCJPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D610", Offset = "0x2A8BC10", VA = "0x182A8D610")]
		public static void MDEICPEKFAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private class CEDGGOBJDFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public Texture2D BDFJHOHMCFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public IntPtr CJAABDNIFML;

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C200", Offset = "0x2A8A800", VA = "0x182A8C200")]
		public void ELCJDKMDHCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C2E0", Offset = "0x2A8A8E0", VA = "0x182A8C2E0")]
		public CEDGGOBJDFP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private bool DKDBFFMNOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private bool KANBHLFCHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private float BMOONDLPLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	private bool CFBNPGDPLKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	private bool LCBJPALDICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private KIPGOPKLAHH JEGHPBLIFBG;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private static bool AFIPCFKGCFK;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private static string AJHHABOEBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private ulong AJCEKBPICEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private IntPtr NOOHCBBDOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private CEDGGOBJDFP[] HGMBDIHHDFF;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public KIPGOPKLAHH NCAAIPFLNGE
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x2A950E0", Offset = "0x2A936E0", VA = "0x182A950E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x2A97690", Offset = "0x2A95C90", VA = "0x182A97690")]
	public IPPJPDPNOGH(MediaPlayer.OptionsWindows PLMLGIGGGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x2A95120", Offset = "0x2A93720", VA = "0x182A95120")]
	public void CNCAHFMOABE(MediaPlayer.OptionsWindows PLMLGIGGGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x2A973C0", Offset = "0x2A959C0", VA = "0x182A973C0", Slot = "93")]
	public override bool OADLMFHCCED()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x2A956A0", Offset = "0x2A93CA0", VA = "0x182A956A0", Slot = "149")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "151")]
	public override bool PJKIEJMLKMG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x2A95220", Offset = "0x2A93820", VA = "0x182A95220", Slot = "100")]
	public override double DIHNIAHJDPA()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x2A969E0", Offset = "0x2A94FE0", VA = "0x182A969E0", Slot = "103")]
	public override double JPLKDOCIDFK()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x2A974E0", Offset = "0x2A95AE0", VA = "0x182A974E0", Slot = "101")]
	public override float OPGNDEBAPEB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x2A96370", Offset = "0x2A94970", VA = "0x182A96370", Slot = "116")]
	public override Texture GetTexture(int PMIGBJGNLLP = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x2A962E0", Offset = "0x2A948E0", VA = "0x182A962E0", Slot = "115")]
	public override int GetTextureCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x1ED5460", Offset = "0x1ED3A60", VA = "0x181ED5460", Slot = "117")]
	public override int GetTextureFrameCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x2A95150", Offset = "0x2A93750", VA = "0x182A95150", Slot = "127")]
	internal override MPKICFKOEJB CONIBFNBJAH()
	{
		return default(MPKICFKOEJB);
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x2A951D0", Offset = "0x2A937D0", VA = "0x182A951D0", Slot = "82")]
	public override string DBBFCOKKLMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x2A973E0", Offset = "0x2A959E0", VA = "0x182A973E0", Slot = "83")]
	public override string OCBAJAMEPEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x2A97560", Offset = "0x2A95B60", VA = "0x182A97560", Slot = "106")]
	public override float PKOPMLGMCMN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x2A96820", Offset = "0x2A94E20", VA = "0x182A96820", Slot = "104")]
	public override int JNMJBHEIJGI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x2A97410", Offset = "0x2A95A10", VA = "0x182A97410", Slot = "105")]
	public override int OMBILPPCFDN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x1DB4EC0", Offset = "0x1DB34C0", VA = "0x181DB4EC0", Slot = "133")]
	public override float AABCLDNCGAB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x2A96650", Offset = "0x2A94C50", VA = "0x182A96650", Slot = "132")]
	public override void HGJAAKGMMOM(float JCDNIOGJMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x2A97340", Offset = "0x2A95940", VA = "0x182A97340", Slot = "134")]
	public override float NODDGHBBIKM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x2A96750", Offset = "0x2A94D50", VA = "0x182A96750", Slot = "107")]
	public override bool IGEKNPNCDIP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x2A95030", Offset = "0x2A93630", VA = "0x182A95030", Slot = "92")]
	public override bool BFMPGNCFAON()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x2A969F0", Offset = "0x2A94FF0", VA = "0x182A969F0", Slot = "108")]
	public override bool KOOPECIKBIC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x2A950C0", Offset = "0x2A936C0", VA = "0x182A950C0", Slot = "113")]
	public override bool CDEFPCKANCA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x2A961A0", Offset = "0x2A947A0", VA = "0x182A961A0", Slot = "112")]
	public override bool GIGILLFJNAL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0xB78DC0", Offset = "0xB773C0", VA = "0x180B78DC0", Slot = "91")]
	public override bool JCLAEDECLNL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x2A94EB0", Offset = "0x2A934B0", VA = "0x182A94EB0", Slot = "130")]
	public override bool AGMHKENHKEL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x2A94F40", Offset = "0x2A93540", VA = "0x182A94F40", Slot = "111")]
	public override bool AIHGMKGEFID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x2A95A80", Offset = "0x2A94080", VA = "0x182A95A80", Slot = "110")]
	public override bool FFCNCFEIINJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x2A952A0", Offset = "0x2A938A0", VA = "0x182A952A0", Slot = "109")]
	public override bool DILLOBIIFPB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x2A96790", Offset = "0x2A94D90", VA = "0x182A96790", Slot = "129")]
	public override void INKLCJABGBG(bool KNKJJAJKNIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x2A96C20", Offset = "0x2A95220", VA = "0x182A96C20", Slot = "84")]
	public override bool MGIJEMLAOMK(string BFHDBHOMJKM, long PIOCNHLFCNE, string GDKFPGFBDGF, MediaHints PDNBKCFAIFA, int LAEFJHLNJKG = 0, bool INKMBLFADIJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x2A96AC0", Offset = "0x2A950C0", VA = "0x182A96AC0", Slot = "89")]
	public override void LLLBJLFLOEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x2A95950", Offset = "0x2A93F50", VA = "0x182A95950", Slot = "95")]
	public override void EEEOMJDOMAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x2A952C0", Offset = "0x2A938C0", VA = "0x182A952C0", Slot = "94")]
	public override void DJEKLJKIOHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x2A8C3C0", Offset = "0x2A8A9C0", VA = "0x182A8C3C0", Slot = "148")]
	public override void CIBAHCGIKDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x2A96EC0", Offset = "0x2A954C0", VA = "0x182A96EC0")]
	private void MNHPAPNKCID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "120")]
	public override bool RequiresVerticalFlip()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x2A959F0", Offset = "0x2A93FF0", VA = "0x182A959F0", Slot = "98")]
	public override void EHIIACCOAEB(double HBAPMMDKJDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x2A96AA0", Offset = "0x2A950A0", VA = "0x182A96AA0", Slot = "99")]
	public override void LJNMPIEKFDA(double HBAPMMDKJDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x2A966E0", Offset = "0x2A94CE0", VA = "0x182A966E0", Slot = "90")]
	public override void HOEIMCEDJME(bool BANKPCJNCLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x2A96110", Offset = "0x2A94710", VA = "0x182A96110", Slot = "102")]
	public override void GFCJBNCKHJD(float NFMNHEPLOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x2A959D0", Offset = "0x2A93FD0", VA = "0x182A959D0", Slot = "131")]
	public override void EEPFEBLMELE(float KCEBOMKMFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x2A96C00", Offset = "0x2A95200", VA = "0x182A96C00", Slot = "96")]
	public override void MBDDDNAIIMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x2A96A30", Offset = "0x2A95030", VA = "0x182A96A30")]
	private void LJNEEJLPOHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x2A94F60", Offset = "0x2A93560", VA = "0x182A94F60")]
	private void ALEKKNFHECL(KKNIPCDHLCH[] ICKFEKPLGLA, CMHPFIIJLMO.GNMPLFKAAIF PAOGHGFOGPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x2A95AA0", Offset = "0x2A940A0", VA = "0x182A95AA0", Slot = "146")]
	public override void FPGILMIKMIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x2A972E0", Offset = "0x2A958E0", VA = "0x182A972E0", Slot = "144")]
	public override void NNJPMDIGFFK(string INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x2A95060", Offset = "0x2A93660", VA = "0x182A95060", Slot = "145")]
	public override void BMFGLCFJGAK(byte[] HAELBKGFDIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x2A96250", Offset = "0x2A94850", VA = "0x182A96250", Slot = "161")]
	internal override bool GMMPBLCANFL(CFHNNHCENEB CIIOMOICJPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x2A96B70", Offset = "0x2A95170", VA = "0x182A96B70", Slot = "162")]
	internal override int LPCNKCBMNKL(CFHNNHCENEB CIIOMOICJPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x2A95340", Offset = "0x2A93940", VA = "0x182A95340", Slot = "163")]
	internal override ELFPNEOGMED DMOAHNJOLAH(CFHNNHCENEB CIIOMOICJPM, int OMJDMCDKKOM, bool PADBEBKMHNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x2A958C0", Offset = "0x2A93EC0", VA = "0x182A958C0", Slot = "159")]
	internal override bool EDFPHKKNNPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x2A968F0", Offset = "0x2A94EF0", VA = "0x182A968F0", Slot = "160")]
	internal override string JPGJJFOLKEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2A963C0", Offset = "0x2A949C0", VA = "0x182A963C0")]
	public static bool HCKKMHMKFLL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x2A96700", Offset = "0x2A94D00", VA = "0x182A96700")]
	public static void HPLEOEHOPIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class EJKFHKIHHMD
{
	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public string CGMHMPMJPLA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0xAA55F0", Offset = "0xAA3BF0", VA = "0x180AA55F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0xAB22B0", Offset = "0xAB08B0", VA = "0x180AB22B0")]
	internal EJKFHKIHHMD(string MEJLBKIDBME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public enum CFHNNHCENEB
{
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	Video,
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	Audio,
	[Cpp2IlInjected.Token(Token = "0x4000309")]
	Text
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class ELFPNEOGMED
{
	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public int FKPIBAMBDFM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xAA7130", Offset = "0xAA5730", VA = "0x180AA7130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	private CFHNNHCENEB FMLNPFOEGPL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0xBA16C0", Offset = "0xB9FCC0", VA = "0x180BA16C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	private string GJBIPMKGMGD
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public string EEABAFMMHKN
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0xAA70F0", Offset = "0xAA56F0", VA = "0x180AA70F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public string DBKKJNAGCLG
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xAA5560", Offset = "0xAA3B60", VA = "0x180AA5560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xAA9ED0", Offset = "0xAA84D0", VA = "0x180AA9ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private bool PJBOAMKODHD
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xAD43F0", Offset = "0xAD29F0", VA = "0x180AD43F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x2A90BB0", Offset = "0x2A8F1B0", VA = "0x182A90BB0")]
	internal ELFPNEOGMED(CFHNNHCENEB CIIOMOICJPM, int DHCHLCGGKNB, string NDIENANOGEK, string IFHOBNLCCJB, bool KAKKPBKEMHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x2A90AF0", Offset = "0x2A8F0F0", VA = "0x182A90AF0")]
	protected string BMAJGFIMDMC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public abstract class GKPGACNOKDG : IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public virtual CFHNNHCENEB FMLNPFOEGPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(CFHNNHCENEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public abstract int EEGOGBABKAE
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
	internal abstract void ELFNJAKNOMA();

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void MEFAAGOGBHI(ELFPNEOGMED KIDEKKHGOBI);

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract void GKKAJGBDDFN(ELFPNEOGMED KIDEKKHGOBI);

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	protected GKPGACNOKDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[DefaultMember("Item")]
public class BLIOMDEDNLC<T> : GKPGACNOKDG where T : ELFPNEOGMED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	internal List<T> LFKBIKBJEMI;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	internal T IPJBOOJEINL
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public override int EEGOGBABKAE
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x6AFC600", Offset = "0x6AFAC00", VA = "0x186AFC600", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x6AFC720", Offset = "0x6AFAD20", VA = "0x186AFC720")]
	internal BLIOMDEDNLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x6AFC570", Offset = "0x6AFAB70", VA = "0x186AFC570", Slot = "7")]
	public override IEnumerator GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x6AFC430", Offset = "0x6AFAA30", VA = "0x186AFC430", Slot = "8")]
	internal override void ELFNJAKNOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x6AFC640", Offset = "0x6AFAC40", VA = "0x186AFC640", Slot = "9")]
	internal override void MEFAAGOGBHI(ELFPNEOGMED KIDEKKHGOBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x6AFC490", Offset = "0x6AFAA90", VA = "0x186AFC490", Slot = "10")]
	internal override void GKKAJGBDDFN(ELFPNEOGMED KIDEKKHGOBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class HODKKHLDHDC : BLIOMDEDNLC<JFDDMMBMLLD>
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public override CFHNNHCENEB FMLNPFOEGPL
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "5")]
		get
		{
			return default(CFHNNHCENEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x2A94800", Offset = "0x2A92E00", VA = "0x182A94800")]
	public HODKKHLDHDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class GDGPHFIGKJG : BLIOMDEDNLC<BOOLEBGNMBJ>
{
	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public override CFHNNHCENEB FMLNPFOEGPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0xC4FA70", Offset = "0xC4E070", VA = "0x180C4FA70", Slot = "5")]
		get
		{
			return default(CFHNNHCENEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x2A90CC0", Offset = "0x2A8F2C0", VA = "0x182A90CC0")]
	public GDGPHFIGKJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class EFLCKALDKFO : BLIOMDEDNLC<DJBJHFNOCEC>
{
	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public override CFHNNHCENEB FMLNPFOEGPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0xC4BAB0", Offset = "0xC4A0B0", VA = "0x180C4BAB0", Slot = "5")]
		get
		{
			return default(CFHNNHCENEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x2A90AB0", Offset = "0x2A8F0B0", VA = "0x182A90AB0")]
	public EFLCKALDKFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class JFDDMMBMLLD : ELFPNEOGMED
{
	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x2A97890", Offset = "0x2A95E90", VA = "0x182A97890")]
	internal JFDDMMBMLLD(int DHCHLCGGKNB, string NDIENANOGEK, string IFHOBNLCCJB, bool KAKKPBKEMHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class BOOLEBGNMBJ : ELFPNEOGMED
{
	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x2A8C1D0", Offset = "0x2A8A7D0", VA = "0x182A8C1D0")]
	internal BOOLEBGNMBJ(int DHCHLCGGKNB, string NDIENANOGEK, string IFHOBNLCCJB, bool KAKKPBKEMHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class DJBJHFNOCEC : ELFPNEOGMED
{
	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x2A90650", Offset = "0x2A8EC50", VA = "0x182A90650")]
	internal DJBJHFNOCEC(int DHCHLCGGKNB, string NDIENANOGEK, string IFHOBNLCCJB, bool KAKKPBKEMHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface JECNLHCDBDC
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface AICHAOKKAMJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface JENMOIKKLJC
{
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public static class NPCODINJMJP
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public enum BCJNHLFNJAB
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
	[Cpp2IlInjected.Address(RVA = "0x2A9EA50", Offset = "0x2A9D050", VA = "0x182A9EA50")]
	public static Func<float, float> BAJJHIFHKDL(BCJNHLFNJAB PKIMILACKIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F170", Offset = "0x2A9D770", VA = "0x182A9F170")]
	public static float HCJHLGCLFIL(float DHDFDKFCOJK, float AABBEGCOEFP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F2B0", Offset = "0x2A9D8B0", VA = "0x182A9F2B0")]
	public static float MFDNNPPAGBN(float DHDFDKFCOJK, float AABBEGCOEFP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F070", Offset = "0x2A9D670", VA = "0x182A9F070")]
	public static float FDJCPFGLACN(float DHDFDKFCOJK, float AABBEGCOEFP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x2A9EFD0", Offset = "0x2A9D5D0", VA = "0x182A9EFD0")]
	public static float CONEBIIJOIN(float DHDFDKFCOJK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
	public static float JCHHBDPDKPO(float DHDFDKFCOJK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x2A9EFC0", Offset = "0x2A9D5C0", VA = "0x182A9EFC0")]
	public static float BDOCFBGAFAN(float DHDFDKFCOJK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F370", Offset = "0x2A9D970", VA = "0x182A9F370")]
	public static float NELCHADEGHM(float DHDFDKFCOJK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F2F0", Offset = "0x2A9D8F0", VA = "0x182A9F2F0")]
	public static float NEDODPGHJHO(float DHDFDKFCOJK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x2A9EA40", Offset = "0x2A9D040", VA = "0x182A9EA40")]
	public static float AFINDKHBOKJ(float DHDFDKFCOJK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F480", Offset = "0x2A9DA80", VA = "0x182A9F480")]
	public static float PDLAPKENEBN(float DHDFDKFCOJK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x2A9EFF0", Offset = "0x2A9D5F0", VA = "0x182A9EFF0")]
	public static float ENAGGJIACIN(float DHDFDKFCOJK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F1E0", Offset = "0x2A9D7E0", VA = "0x182A9F1E0")]
	public static float JGAPBIJALAN(float DHDFDKFCOJK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x2A9EA00", Offset = "0x2A9D000", VA = "0x182A9EA00")]
	public static float ADHDAEDHDDF(float DHDFDKFCOJK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F230", Offset = "0x2A9D830", VA = "0x182A9F230")]
	public static float LFDDAJGPOCC(float DHDFDKFCOJK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F180", Offset = "0x2A9D780", VA = "0x182A9F180")]
	public static float HMIEBHODLLF(float DHDFDKFCOJK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F1F0", Offset = "0x2A9D7F0", VA = "0x182A9F1F0")]
	public static float KMFNAOKBKFP(float DHDFDKFCOJK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F0F0", Offset = "0x2A9D6F0", VA = "0x182A9F0F0")]
	public static float FGDNEBPAHKI(float DHDFDKFCOJK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F3B0", Offset = "0x2A9D9B0", VA = "0x182A9F3B0")]
	public static float NHIIAMHDGLO(float DHDFDKFCOJK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F190", Offset = "0x2A9D790", VA = "0x182A9F190")]
	public static float IBMDGALPDHE(float DHDFDKFCOJK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F3F0", Offset = "0x2A9D9F0", VA = "0x182A9F3F0")]
	public static float NMOFKAJKDIG(float DHDFDKFCOJK)
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
		[Cpp2IlInjected.Address(RVA = "0x2A94E70", Offset = "0x2A93470", VA = "0x182A94E70")]
		public bool PALGANKOJHG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x2A94DE0", Offset = "0x2A933E0", VA = "0x182A94DE0")]
		public string KBIFBIOCNNC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x2A94CD0", Offset = "0x2A932D0", VA = "0x182A94CD0")]
		public static bool GLJIKBGGLIL(string MEJLBKIDBME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x2A94C60", Offset = "0x2A93260", VA = "0x182A94C60")]
		private static bool BJDMFFNJDPF(string MEJLBKIDBME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x2A94DA0", Offset = "0x2A933A0", VA = "0x182A94DA0")]
		private bool GLJIKBGGLIL()
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
		[Cpp2IlInjected.Address(RVA = "0x2A94960", Offset = "0x2A92F60", VA = "0x182A94960", Slot = "4")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x2A949E0", Offset = "0x2A92FE0", VA = "0x182A949E0")]
		public string KBIFBIOCNNC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x2A94BD0", Offset = "0x2A931D0", VA = "0x182A94BD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x2A9CFB0", Offset = "0x2A9B5B0", VA = "0x182A9CFB0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public KeyAuthData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class PFNLFLFJCOF
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private class FDABINCMBLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public RenderTexture BDFJHOHMCFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public long GPIKONAAEFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public bool AGNIBNGNIOI;

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public FDABINCMBLE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public enum OAJPPPIOFGI
	{
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		POINT,
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		LINEAR
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private List<FDABINCMBLE[]> KKMIHIHHCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private MediaPlayer NFEEDJFHNMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private RenderTexture[] LJPMFICPOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private int CCCKKOFGMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private int FPOLOCKILFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private int LBKDIBACFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private long ABHIMHOEABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private float LJDBFGGIEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private Material IHLLEABBANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private OAJPPPIOFGI GLOINHACHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private string JLFIMMGPKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private long ILMDBJFDFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private int DGPILLAINJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private long AGBLIKGGHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private int GBINFFEHLPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	private long EONNPOPCJNB;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	private const string DJAACHEIDGE = "_t";

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	private const string CMMAKNKKNCJ = "_AfterTex";

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000341")]
	private int DGPEEPOKLDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000342")]
	private int JHELJEPGJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000343")]
	private float ACBHNNOEGAG;

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private float IPCNNFENNKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x16798B0", Offset = "0x1677EB0", VA = "0x1816798B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	private long GKOOCDJLHNP
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1A10", Offset = "0x2AA0010", VA = "0x182AA1A10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public Texture[] ABLFENMNPDH
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x2AA1500", Offset = "0x2A9FB00", VA = "0x182AA1500")]
	public void IHMNEGHMNBB(MediaPlayer DAEDICFCADH, MediaPlayerEvent.IHGOHFKGPHI GBPOPAEJGPD, GPKOBMFDDOH AKOJIFEHEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x2AA23E0", Offset = "0x2AA09E0", VA = "0x182AA23E0")]
	public PFNLFLFJCOF(MediaPlayer AGIMJJDFEAF, string NDIENANOGEK, int EEEHJIFCOKL = 2, OAJPPPIOFGI PNPGPNDLJKP = OAJPPPIOFGI.LINEAR)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x2AA15E0", Offset = "0x2A9FBE0", VA = "0x182AA15E0")]
	public void JGIFDBJEMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x2A9FDE0", Offset = "0x2A9E3E0", VA = "0x182A9FDE0")]
	public void AMPHLDINMDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x2A9FEA0", Offset = "0x2A9E4A0", VA = "0x182A9FEA0")]
	private void EFGEADPEGKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x2AA00F0", Offset = "0x2A9E6F0", VA = "0x182AA00F0")]
	private void FBOIMLCGBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x2AA2030", Offset = "0x2AA0630", VA = "0x182AA2030")]
	private bool PDMFEINFENA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x2AA1E10", Offset = "0x2AA0410", VA = "0x182AA1E10")]
	private int PBDIHEIHFPB(int PFGENNMLDOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x2AA1C50", Offset = "0x2AA0250", VA = "0x182AA1C50")]
	private int OPEMGJNIPPM(int PFGENNMLDOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x2AA0670", Offset = "0x2A9EC70", VA = "0x182AA0670")]
	private void FMIEANEIPKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x2AA1600", Offset = "0x2A9FC00", VA = "0x182AA1600")]
	private void KFDFMGAIGDF(int PFGENNMLDOA, int GALAMDMNIHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x2AA1760", Offset = "0x2A9FD60", VA = "0x182AA1760")]
	private void KGJACNFMFNP(int GALAMDMNIHE, int ANFNEKKPIHA, int DCEPOPMPIAN, float DHDFDKFCOJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x2AA1A20", Offset = "0x2AA0020", VA = "0x182AA1A20")]
	private void LIIBLJABLDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x2A9FA40", Offset = "0x2A9E040", VA = "0x182A9FA40")]
	private void ADPCABHDCDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x2A9FB40", Offset = "0x2A9E140", VA = "0x182A9FB40")]
	private float AECIKHIAEAF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x2AA09A0", Offset = "0x2A9EFA0", VA = "0x182AA09A0")]
	public void FPGILMIKMIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x2AA14E0", Offset = "0x2A9FAE0", VA = "0x182AA14E0")]
	public void HABEDFLDAAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class ALLBCFOHLKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public int PMIGBJGNLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public string MEJLBKIDBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public double FMKKKHAOFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public double CGCDIJEDAGI;

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x2A8C1B0", Offset = "0x2A8A7B0", VA = "0x182A8C1B0")]
	public bool KGGFMMDACEN(double HBAPMMDKJDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public ALLBCFOHLKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public class PCJFHDGLHLE
{
	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F4C0", Offset = "0x2A9DAC0", VA = "0x182A9F4C0")]
	private static double DDEOCFHDABH(string MEJLBKIDBME)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F600", Offset = "0x2A9DC00", VA = "0x182A9F600")]
	public static List<ALLBCFOHLKE> KDMEOOCMJOD(string CDDIADBJAOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct MPEDAGENPGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private string JLFIMMGPKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private int AIIIPOEACNE;

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public int HMNNHOPLICJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E1A0", Offset = "0x2A9C7A0", VA = "0x182A9E1A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x2A9E1D0", Offset = "0x2A9C7D0", VA = "0x182A9E1D0")]
	public MPEDAGENPGA(string NDIENANOGEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class DJAMJLOMPKM
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[Flags]
	public enum IJGAFBEEBLK
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
	public static readonly MPEDAGENPGA AABDCMDMINN;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly MPEDAGENPGA DMNMENFLIHC;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly MPEDAGENPGA MNMPFOGDCDH;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly MPEDAGENPGA MAHJCOICEIH;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly MPEDAGENPGA IMCBGIOBOAB;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly MPEDAGENPGA JDODCDAHCDN;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly MPEDAGENPGA OLIMLNDLAMM;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly MPEDAGENPGA BIHGIAMAHJL;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly MPEDAGENPGA BIKPGCJOFDN;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly MPEDAGENPGA LOCFGBAHIHB;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static string NEINMPNOAAD;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly MPEDAGENPGA EALNMCPNIFF;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly MPEDAGENPGA FLFJMAIBLLC;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly MPEDAGENPGA GBHBEMNAMFL;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly MPEDAGENPGA JBNCCKDKFLC;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly MPEDAGENPGA LNPHJHGNPMH;

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F8C0", Offset = "0x2A8DEC0", VA = "0x182A8F8C0")]
	public static Material MJNFGOFFFBC(bool LMGNGOJABAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F960", Offset = "0x2A8DF60", VA = "0x182A8F960")]
	public static void MNHFIMIMGAJ(Material PFHPGDKJCCC, JKOMGEDPKMN MLAFPBKKHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x2A8DD60", Offset = "0x2A8C360", VA = "0x182A8DD60")]
	public static void AKPMHGACAGA(Material PFHPGDKJCCC, MPKICFKOEJB ICKEOAABLMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F6F0", Offset = "0x2A8DCF0", VA = "0x182A8F6F0")]
	public static void JLPCHGMHMJB(Material PFHPGDKJCCC, LEMCJHMHPOI ICKEOAABLMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F830", Offset = "0x2A8DE30", VA = "0x182A8F830")]
	public static void KAEIHCGLJMF(Material PFHPGDKJCCC, bool MEFGEPEEHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x2A8DC60", Offset = "0x2A8C260", VA = "0x182A8DC60")]
	public static void ACBKOLDALHL(Material PFHPGDKJCCC, Matrix4x4 CCHLCEHOKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x2A8E010", Offset = "0x2A8C610", VA = "0x182A8E010")]
	public static void EIADDPGIDPJ(Material PFHPGDKJCCC, bool IGLMAJMABGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x2A8FF10", Offset = "0x2A8E510", VA = "0x182A8FF10")]
	public static Texture OHBBDOBNLNB(MediaPlayer FICMDFJHIJB, int OBCPINMCNPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x2A8EE50", Offset = "0x2A8D450", VA = "0x182A8EE50")]
	public static void IFLCGKNIOBD(Material PFHPGDKJCCC, MediaPlayer FICMDFJHIJB, int LCGEENADLHP = -1, [Optional] Texture HDMGEEJDFAO, bool IEFNBBAHILE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x2A8FA00", Offset = "0x2A8E000", VA = "0x182A8FA00")]
	internal static void NGOGNAPJBNH(Material PFHPGDKJCCC, bool MCJIDBBCBGF, bool MEFGEPEEHHF, Matrix4x4 DGNHDAMGPON, Texture KDAPLFEAGNL, Matrix4x4 BMODMJLPEKO, JKOMGEDPKMN MLAFPBKKHDI = JKOMGEDPKMN.Normal, MPKICFKOEJB IPBIHMNNKHP = MPKICFKOEJB.None, LEMCJHMHPOI KFHNIGKLPKB = LEMCJHMHPOI.None)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F410", Offset = "0x2A8DA10", VA = "0x182A8F410")]
	public static void IKJHPLONNBA(Material PFHPGDKJCCC, VideoResolveOptions PLMLGIGGGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x2A8E0C0", Offset = "0x2A8C6C0", VA = "0x182A8E0C0")]
	public static RenderTexture FMFCLMAMPJH(Material LAKELGLAHOC, RenderTexture KNGIANJFFMD, EBMAMKKAFPB BDFJHOHMCFM, IJGAFBEEBLK ANBGOGICGFD, ScaleMode LEDNPIJPBNI = ScaleMode.StretchToFill)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x2A8E6B0", Offset = "0x2A8CCB0", VA = "0x182A8E6B0")]
	public static void FMFPCLOONJD(LEMCJHMHPOI KFHNIGKLPKB, MPKICFKOEJB IPBIHMNNKHP, BPOPPJHKMKC LKGEFPMHEJH, float MPFIOFGIFHP, Matrix4x4 MKLDEMIABHL, int EPJLFMHGDCC, int GHDHPPBLHGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x2A8E830", Offset = "0x2A8CE30", VA = "0x182A8E830")]
	public static void HOHKALNHNEH(Rect LEBHDFDLLJO, Texture BDFJHOHMCFM, ScaleMode LEDNPIJPBNI, LEMCJHMHPOI KFHNIGKLPKB, float MPFIOFGIFHP, Material PFHPGDKJCCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public enum DPHOEJBNEFN
{
	[Cpp2IlInjected.Token(Token = "0x4000367")]
	SDR,
	[Cpp2IlInjected.Token(Token = "0x4000368")]
	HLG,
	[Cpp2IlInjected.Token(Token = "0x4000369")]
	PQ
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public enum DEIBPPJCJGO : uint
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
public class HPOMIFCGOEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400037A")]
	private int ENFNGNFPFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400037B")]
	private int COPPBPHBNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400037C")]
	private int IPKGPFDIJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400037D")]
	private int DKMDENNCEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400037E")]
	private int DGIIFMCEGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400037F")]
	private DEIBPPJCJGO PGPJKMLMCME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000380")]
	private float MOALMMBIINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000381")]
	private DPHOEJBNEFN GOEGLLPANJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000382")]
	private DEIBPPJCJGO FBDDECLFEKH;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	private static HPOMIFCGOEO CAPGLGFGGHO;

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x2A948E0", Offset = "0x2A92EE0", VA = "0x182A948E0")]
	public HPOMIFCGOEO(int LICIDNNEABA, int NDIMEFNNEFJ, int EEFNCCDFIBN, int NHDEKJHPADA, int DEKIFMFEHEF = 0, DEIBPPJCJGO KFKMEJOJCPP = DEIBPPJCJGO.unknown, float ACDFEKGMLFD = 0f, DPHOEJBNEFN EJCFPDLOBCC = DPHOEJBNEFN.SDR, DEIBPPJCJGO ANGILNAMDGE = DEIBPPJCJGO.unknown)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[DefaultMember("Item")]
public interface GLGJNKCHNJH : IEnumerable
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
