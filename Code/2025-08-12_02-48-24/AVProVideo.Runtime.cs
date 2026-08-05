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
	public Material OHJGNAFEKGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2A0C770", Offset = "0x2A0AD70", VA = "0x182A0C770")]
	private void OnWillRenderObject()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xA97AB0", Offset = "0xA960B0", VA = "0x180A97AB0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public MediaPath MediaPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public MediaHints Hints
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x167C630", Offset = "0x167AC30", VA = "0x18167C630")]
			get
			{
				return default(MediaHints);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x2A1BE60", Offset = "0x2A1A460", VA = "0x182A1BE60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2A1BC80", Offset = "0x2A1A280", VA = "0x182A1BC80")]
		public MediaReference FFABCEGHBGI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2A1BCF0", Offset = "0x2A1A2F0", VA = "0x182A1BCF0")]
		public MediaReference NFPHGEKEJBK(BGCNMKKBMDO PJKNLKPIIFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2A1BD80", Offset = "0x2A1A380", VA = "0x182A1BD80")]
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
		private enum ELHMONGOMDG
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
		private GameObject EONBDIJIDAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool PILHHFFGAFH;

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
		private Texture AJEPPICPLGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private FHBFMADDBJI LMKJABNAGJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private FHBFMADDBJI IBCHBGBNPOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private Texture ICDKEBFGCOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Vector2 FLDCPGFEFAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Vector2 HLJAJLKNALB;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Color EOGMCNJFMDC
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xF61520", Offset = "0xF5FB20", VA = "0x180F61520")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x2A0E590", Offset = "0x2A0CB90", VA = "0x182A0E590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Texture AAAGBJBCHGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA99310", Offset = "0xA97910", VA = "0x180A99310")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2A0E7E0", Offset = "0x2A0CDE0", VA = "0x182A0E7E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Texture ICMPKDGFDGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xA95000", Offset = "0xA93600", VA = "0x180A95000")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2A0E280", Offset = "0x2A0C880", VA = "0x182A0E280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float GODBBJNNCAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x128CCA0", Offset = "0x128B2A0", VA = "0x18128CCA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2A0E100", Offset = "0x2A0C700", VA = "0x182A0E100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Camera DAAEDMEDGBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA962B0", Offset = "0xA948B0", VA = "0x180A962B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2A0E1B0", Offset = "0x2A0C7B0", VA = "0x182A0E1B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public VideoAspectRatio LLPAGFOICLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xD4F030", Offset = "0xD4D630", VA = "0x180D4F030")]
			get
			{
				return default(VideoAspectRatio);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x2A0E8A0", Offset = "0x2A0CEA0", VA = "0x182A0E8A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Vector2 DGICPAMHNMC
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2A0E0A0", Offset = "0x2A0C6A0", VA = "0x182A0E0A0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2A0E4B0", Offset = "0x2A0CAB0", VA = "0x182A0E4B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Vector2 DMODHJKFFJD
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x128CCB0", Offset = "0x128B2B0", VA = "0x18128CCB0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2A0E340", Offset = "0x2A0C940", VA = "0x182A0E340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Texture2D NGDAJLINDNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xA9D770", Offset = "0xA9BD70", VA = "0x180A9D770")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x2A0E420", Offset = "0x2A0CA20", VA = "0x182A0E420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public string MGNLENPIKFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xA9D630", Offset = "0xA9BC30", VA = "0x180A9D630")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2A0E6F0", Offset = "0x2A0CCF0", VA = "0x182A0E6F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Vector2 IDBKJPJKELN
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2A0E0C0", Offset = "0x2A0C6C0", VA = "0x182A0E0C0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2A0E650", Offset = "0x2A0CC50", VA = "0x182A0E650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Vector2 PFMPFEHANLN
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2A0E0E0", Offset = "0x2A0C6E0", VA = "0x182A0E0E0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x2A0E6A0", Offset = "0x2A0CCA0", VA = "0x182A0E6A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private Vector2 OFCEEFMMBPM
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x2A0D0F0", Offset = "0x2A0B6F0", VA = "0x182A0D0F0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2A0C680", Offset = "0x2A0AC80", VA = "0x182A0C680")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2A0D6E0", Offset = "0x2A0BCE0", VA = "0x182A0D6E0", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2A0D690", Offset = "0x2A0BC90", VA = "0x182A0D690")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2A0DD70", Offset = "0x2A0C370", VA = "0x182A0DD70")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2A0C980", Offset = "0x2A0AF80", VA = "0x182A0C980")]
		public Mesh CreateQuadMesh()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2A0C820", Offset = "0x2A0AE20", VA = "0x182A0C820")]
		public void CreateMaterial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2A0D7B0", Offset = "0x2A0BDB0", VA = "0x182A0D7B0", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xAFA8E0", Offset = "0xAF8EE0", VA = "0x180AFA8E0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2A0DAB0", Offset = "0x2A0C0B0", VA = "0x182A0DAB0")]
		public void UpdateMaterialProperties(int LKEAKCADNOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2A0C140", Offset = "0x2A0A740", VA = "0x182A0C140", Slot = "8")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2A0D1C0", Offset = "0x2A0B7C0", VA = "0x182A0D1C0")]
		private void OCMANCCPDKP(Texture BHNOPLHICEP, bool HEEPDDMDKFM, int HCAIIGECACJ = 0, ELHMONGOMDG HCDCOEAOGJI = ELHMONGOMDG.Left)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2A0CEB0", Offset = "0x2A0B4B0", VA = "0x182A0CEB0", Slot = "6")]
		protected override void JABHJLIECMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2A0CD10", Offset = "0x2A0B310", VA = "0x182A0CD10", Slot = "7")]
		protected override void GFGCABLMDLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2A0DF20", Offset = "0x2A0C520", VA = "0x182A0DF20")]
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
		private enum GBIGIAOELOM
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
		private Texture AJEPPICPLGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private FHBFMADDBJI LMKJABNAGJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private FHBFMADDBJI IBCHBGBNPOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private Texture ICDKEBFGCOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private Vector2 FLDCPGFEFAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private Vector2 HLJAJLKNALB;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Texture2D NGDAJLINDNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x2A0F790", Offset = "0x2A0DD90", VA = "0x182A0F790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Material OHJGNAFEKGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x2A0F810", Offset = "0x2A0DE10", VA = "0x182A0F810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string MGNLENPIKFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA99310", Offset = "0xA97910", VA = "0x180A99310")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x2A0F930", Offset = "0x2A0DF30", VA = "0x182A0F930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector2 IDBKJPJKELN
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x2A0F750", Offset = "0x2A0DD50", VA = "0x182A0F750")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x2A0F890", Offset = "0x2A0DE90", VA = "0x182A0F890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Vector2 PFMPFEHANLN
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x2A0F770", Offset = "0x2A0DD70", VA = "0x182A0F770")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x2A0F8E0", Offset = "0x2A0DEE0", VA = "0x182A0F8E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xAFA8E0", Offset = "0xAF8EE0", VA = "0x180AFA8E0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2A0E950", Offset = "0x2A0CF50", VA = "0x182A0E950", Slot = "8")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2A0F1E0", Offset = "0x2A0D7E0", VA = "0x182A0F1E0")]
		private void OCMANCCPDKP(Texture BHNOPLHICEP, bool HEEPDDMDKFM, int HCAIIGECACJ = 0, GBIGIAOELOM HCDCOEAOGJI = GBIGIAOELOM.Left)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2A0EFE0", Offset = "0x2A0D5E0", VA = "0x182A0EFE0", Slot = "6")]
		protected override void JABHJLIECMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2A0EE70", Offset = "0x2A0D470", VA = "0x182A0EE70", Slot = "7")]
		protected override void GFGCABLMDLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2A0F5F0", Offset = "0x2A0DBF0", VA = "0x182A0F5F0")]
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
		private enum JNJMMPBCLKE
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
		private Texture AJEPPICPLGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private FHBFMADDBJI LMKJABNAGJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private FHBFMADDBJI IBCHBGBNPOH;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Texture2D NGDAJLINDNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x2A10020", Offset = "0x2A0E620", VA = "0x182A10020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Renderer KPOPHIAJCEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x2A100D0", Offset = "0x2A0E6D0", VA = "0x182A100D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public int AFDDEHMGGBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xB17F80", Offset = "0xB16580", VA = "0x180B17F80")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xB18030", Offset = "0xB16630", VA = "0x180B18030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public string MGNLENPIKFA
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA95000", Offset = "0xA93600", VA = "0x180A95000")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x2A10900", Offset = "0x2A0EF00", VA = "0x182A10900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector2 IDBKJPJKELN
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x2A0F770", Offset = "0x2A0DD70", VA = "0x182A0F770")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x2A0F8E0", Offset = "0x2A0DEE0", VA = "0x182A0F8E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector2 PFMPFEHANLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x2A10890", Offset = "0x2A0EE90", VA = "0x182A10890")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x2A108B0", Offset = "0x2A0EEB0", VA = "0x182A108B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2A10020", Offset = "0x2A0E620", VA = "0x182A10020")]
		private void LBNGJJFADON(Texture2D BHNOPLHICEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2A100D0", Offset = "0x2A0E6D0", VA = "0x182A100D0")]
		private void NPPIOKHAIJI(Renderer PHHDHBAFNEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xAFA8E0", Offset = "0xAF8EE0", VA = "0x180AFA8E0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2A0FA00", Offset = "0x2A0E000", VA = "0x182A0FA00", Slot = "8")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2A101B0", Offset = "0x2A0E7B0", VA = "0x182A101B0")]
		private void OCMANCCPDKP(Texture BHNOPLHICEP, bool HEEPDDMDKFM, int HCAIIGECACJ, JNJMMPBCLKE HCDCOEAOGJI = JNJMMPBCLKE.Left, int LIJMKKBPIGG = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2A10670", Offset = "0x2A0EC70", VA = "0x182A10670", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2A10640", Offset = "0x2A0EC40", VA = "0x182A10640", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2A0FF80", Offset = "0x2A0E580", VA = "0x182A0FF80", Slot = "6")]
		protected override void JABHJLIECMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2A107B0", Offset = "0x2A0EDB0", VA = "0x182A107B0")]
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
		private const int APGOANLMNOC = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[Range(0f, 1f)]
		[SerializeField]
		private float[] _channels;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float[] GCGMJPBDABM
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2A10C80", Offset = "0x2A0F280", VA = "0x182A10C80")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2A109D0", Offset = "0x2A0EFD0", VA = "0x182A109D0")]
		private void EDOIIBFPNFL(int OCMOBGPMCFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2A10AD0", Offset = "0x2A0F0D0", VA = "0x182A10AD0")]
		private void OnAudioFilterRead(float[] DAJAOHIJHHL, int FPJPLDGHLOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA97AB0", Offset = "0xA960B0", VA = "0x180A97AB0")]
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
		public enum DJDHGDCIBPC
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
		private DJDHGDCIBPC _audioOutputMode;

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
		private int ABKLGGJMJCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private AudioSource EGGNBKCLBAB;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public MediaPlayer DGHFBNKMICB
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2A11800", Offset = "0x2A0FE00", VA = "0x182A11800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public DJDHGDCIBPC BHKAMBABLJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAEE830", Offset = "0xAECE30", VA = "0x180AEE830")]
			get
			{
				return default(DJDHGDCIBPC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xAEDFA0", Offset = "0xAEC5A0", VA = "0x180AEDFA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int IEOFJENONOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xC3A7A0", Offset = "0xC38DA0", VA = "0x180C3A7A0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x1093000", Offset = "0x1091600", VA = "0x181093000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2A10D10", Offset = "0x2A0F310", VA = "0x182A10D10")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2A11670", Offset = "0x2A0FC70", VA = "0x182A11670")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2A11240", Offset = "0x2A0F840", VA = "0x182A11240")]
		private void GLKDKHGMBAC(bool HLFMNDHEGGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2A115C0", Offset = "0x2A0FBC0", VA = "0x182A115C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2A11700", Offset = "0x2A0FD00", VA = "0x182A11700")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		public AudioSource GetAudioSource()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2A115D0", Offset = "0x2A0FBD0", VA = "0x182A115D0")]
		public void SetAudioSource(AudioSource LBHNPIBFMBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2A10D60", Offset = "0x2A0F360", VA = "0x182A10D60")]
		public void ChangeMediaPlayer(MediaPlayer HDOIACKLNCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2A11320", Offset = "0x2A0F920", VA = "0x182A11320")]
		private void GPPBDHGJLHE(MediaPlayer DPAFDJOAOAE, MediaPlayerEvent.BHFBPEFIMHM HBCMLPDPBCA, HIICDHDBEHA DCHHIMINIKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2A11380", Offset = "0x2A0F980", VA = "0x182A11380")]
		private static void IMDJBPHFAJL(MediaPlayer LIOICDJHFAF, AudioSource FDHHMJDPGCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2A11540", Offset = "0x2A0FB40", VA = "0x182A11540")]
		private void OnAudioFilterRead(float[] CGFMINAMLCP, int FPNDCHNJFNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2A117E0", Offset = "0x2A0FDE0", VA = "0x182A117E0")]
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
		private static Shader DGOOJJKIDJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private Material ELKLMLDDAHG;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public MediaPlayer DGHFBNKMICB
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x2A128B0", Offset = "0x2A10EB0", VA = "0x182A128B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public ScaleMode CNNHDLELPJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAEE830", Offset = "0xAECE30", VA = "0x180AEE830")]
			get
			{
				return default(ScaleMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xAEDFA0", Offset = "0xAEC5A0", VA = "0x180AEDFA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Color JIIKHGGPGBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xEA1DE0", Offset = "0xEA03E0", VA = "0x180EA1DE0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x10A58A0", Offset = "0x10A3EA0", VA = "0x1810A58A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool CHICHHGONIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xF07180", Offset = "0xF05780", VA = "0x180F07180")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xF191C0", Offset = "0xF177C0", VA = "0x180F191C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool KBNLJGHPPFO
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xF18D00", Offset = "0xF17300", VA = "0x180F18D00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xF18DE0", Offset = "0xF173E0", VA = "0x180F18DE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public int HNAPCPDGEOB
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xAB3880", Offset = "0xAB1E80", VA = "0x180AB3880")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xED8000", Offset = "0xED6600", VA = "0x180ED8000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool LHAJFFPAHAO
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xFC0810", Offset = "0xFBEE10", VA = "0x180FC0810")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xFC0910", Offset = "0xFBEF10", VA = "0x180FC0910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float BPJNDBOKDKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xD5D9C0", Offset = "0xD5BFC0", VA = "0x180D5D9C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xD5D620", Offset = "0xD5BC20", VA = "0x180D5D620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public float OGLIGPKEKFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xE71F20", Offset = "0xE70520", VA = "0x180E71F20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x1C87D90", Offset = "0x1C86390", VA = "0x181C87D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float AEFDOLNHMBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xAE7030", Offset = "0xAE5630", VA = "0x180AE7030")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x1082450", Offset = "0x1080A50", VA = "0x181082450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float OPMDHGAHMEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xF2EA00", Offset = "0xF2D000", VA = "0x180F2EA00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xF2EA10", Offset = "0xF2D010", VA = "0x180F2EA10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool LKAHLKHKJNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xB19EF0", Offset = "0xB184F0", VA = "0x180B19EF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xB19E60", Offset = "0xB18460", VA = "0x180B19E60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2A12550", Offset = "0x2A10B50", VA = "0x182A12550")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2A12690", Offset = "0x2A10C90", VA = "0x182A12690")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2A11E00", Offset = "0x2A10400", VA = "0x182A11E00")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2A11AD0", Offset = "0x2A100D0", VA = "0x182A11AD0")]
		private Shader FDICDJBNMCM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2A11C50", Offset = "0x2A10250", VA = "0x182A11C50")]
		private void JNGCCKBBDNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2A11EA0", Offset = "0x2A104A0", VA = "0x182A11EA0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2A11B10", Offset = "0x2A10110", VA = "0x182A11B10")]
		public Rect GetAreaRect()
		{
			return default(Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2A12880", Offset = "0x2A10E80", VA = "0x182A12880")]
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
		public delegate void ODODOJFGIOL(Texture2D CLCJMHKGEDJ);

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public class PlatformOptions
		{
			[Cpp2IlInjected.Token(Token = "0x2000011")]
			public enum KGLCFBAOAMO
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
			public enum PFADOKBFCDM
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
			public enum AKDMOOIJKMH
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
			public enum MLHCPEEMNLJ
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
			[Cpp2IlInjected.Address(RVA = "0x2A1CEE0", Offset = "0x2A1B4E0", VA = "0x182A1CEE0", Slot = "4")]
			public virtual string BMOHLFNIEIM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xF7B290", Offset = "0xF79890", VA = "0x180F7B290", Slot = "5")]
			public virtual byte[] CFNCGLBOGAO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "6")]
			public virtual bool CJOEONDBLHO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x2A1CF00", Offset = "0x2A1B500", VA = "0x182A1CF00")]
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
			public KAGEMDBCDLK.DMODLHHKIDF videoApi;

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
			public KAGEMDBCDLK.NHCFHDABMDF _audioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public PKHJIOPINGD audio360ChannelMode;

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
			[Cpp2IlInjected.Address(RVA = "0xD94690", Offset = "0xD92C90", VA = "0x180D94690", Slot = "6")]
			public override bool CJOEONDBLHO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "7")]
			void ISerializationCallbackReceiver.OnBeforeSerialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x2A1CDE0", Offset = "0x2A1B3E0", VA = "0x182A1CDE0", Slot = "8")]
			void ISerializationCallbackReceiver.OnAfterDeserialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x2A1CE10", Offset = "0x2A1B410", VA = "0x182A1CE10")]
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
			public ONMPELHFCBA.DLJGFGPPPFI videoApi;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public ONMPELHFCBA.NHIJJGJBGFJ _audioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public PKHJIOPINGD audio360ChannelMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public bool startWithHighestBitrate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public bool useLowLiveLatency;

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0xF07180", Offset = "0xF05780", VA = "0x180F07180", Slot = "6")]
			public override bool CJOEONDBLHO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x2A1CDC0", Offset = "0x2A1B3C0", VA = "0x182A1CDC0")]
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
			public enum FKLFNJBINFA
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
			public enum NAJCJFGMPLJ
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
			private readonly KGLCFBAOAMO DefaultTextureFormat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			private readonly FKLFNJBINFA DefaultFlags;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public KGLCFBAOAMO textureFormat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private AKDMOOIJKMH _previousAudioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			[SerializeField]
			private AKDMOOIJKMH _audioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			[SerializeField]
			private FKLFNJBINFA _flags;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public float maximumPlaybackRate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private NAJCJFGMPLJ _changed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			[SerializeField]
			private float _preferredPeakBitRate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			[SerializeField]
			private MLHCPEEMNLJ _preferredPeakBitRateUnits;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			[SerializeField]
			private double _preferredForwardBufferDuration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			[SerializeField]
			private PFADOKBFCDM _preferredMaximumResolution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			[SerializeField]
			private Vector2Int _customPreferredMaximumResolution;

			[Cpp2IlInjected.Token(Token = "0x17000064")]
			public AKDMOOIJKMH audioMode
			{
				[Cpp2IlInjected.Token(Token = "0x6000144")]
				[Cpp2IlInjected.Address(RVA = "0x2A1CD10", Offset = "0x2A1B310", VA = "0x182A1CD10")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000065")]
			public FKLFNJBINFA flags
			{
				[Cpp2IlInjected.Token(Token = "0x6000145")]
				[Cpp2IlInjected.Address(RVA = "0x2A1CD30", Offset = "0x2A1B330", VA = "0x182A1CD30")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x2A1CC60", Offset = "0x2A1B260", VA = "0x182A1CC60")]
			public OptionsApple(KGLCFBAOAMO JHDNAMPLLPC, FKLFNJBINFA KBIPKEKAJLF)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public class OptionsAndroid : PlatformOptions, ISerializationCallbackReceiver
		{
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			[Flags]
			public enum JEFMFNNDPBF
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
			private JEFMFNNDPBF _changed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private readonly KGLCFBAOAMO DefaultTextureFormat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public KGLCFBAOAMO textureFormat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			[SerializeField]
			private bool _generateMipmaps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			private AKDMOOIJKMH _previousAudioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			[SerializeField]
			private AKDMOOIJKMH _audioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			[SerializeField]
			private PFADOKBFCDM _preferredMaximumResolution;

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
			private MLHCPEEMNLJ _preferredPeakBitRateUnits;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public OBIJGGNAFIF.JPEAPPPMBCN videoApi;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public bool showPosterFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public PKHJIOPINGD audio360ChannelMode;

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
			public AKDMOOIJKMH audioMode
			{
				[Cpp2IlInjected.Token(Token = "0x6000147")]
				[Cpp2IlInjected.Address(RVA = "0xAD6F80", Offset = "0xAD5580", VA = "0x180AD6F80")]
				get
				{
					return default(AKDMOOIJKMH);
				}
				[Cpp2IlInjected.Token(Token = "0x6000148")]
				[Cpp2IlInjected.Address(RVA = "0x2A1CC40", Offset = "0x2A1B240", VA = "0x182A1CC40")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xA99440", Offset = "0xA97A40", VA = "0x180A99440", Slot = "6")]
			public override bool CJOEONDBLHO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "7")]
			void ISerializationCallbackReceiver.OnBeforeSerialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x2A1CB90", Offset = "0x2A1B190", VA = "0x182A1CB90", Slot = "8")]
			void ISerializationCallbackReceiver.OnAfterDeserialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x2A1CBC0", Offset = "0x2A1B1C0", VA = "0x182A1CBC0")]
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
			public enum HBFDFLIJGEE
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
			private HBFDFLIJGEE _changed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			private readonly KGLCFBAOAMO DefaultTextureFormat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public KGLCFBAOAMO textureFormat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			[SerializeField]
			private bool _generateMipmapsOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private AKDMOOIJKMH _previousAudioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			[SerializeField]
			private AKDMOOIJKMH _audioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			[SerializeField]
			private PFADOKBFCDM _preferredMaximumResolution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			[SerializeField]
			private Vector2Int _customPreferredMaximumResolution;

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "7")]
			void ISerializationCallbackReceiver.OnBeforeSerialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "8")]
			void ISerializationCallbackReceiver.OnAfterDeserialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x2A1CD60", Offset = "0x2A1B360", VA = "0x182A1CD60")]
			public OptionsOpenHarmony()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public class OptionsWebGL : PlatformOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			public enum GIMEDAKIJNJ
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
			private GIMEDAKIJNJ _changed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public AMAMFGINNPN.IIAOHKALPIG externalLibrary;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public bool useTextureMips;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			private AKDMOOIJKMH _previousAudioMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			[SerializeField]
			private AKDMOOIJKMH _audioMode;

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "4")]
			public override string BMOHLFNIEIM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "5")]
			public override byte[] CFNCGLBOGAO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x2A1CDB0", Offset = "0x2A1B3B0", VA = "0x182A1CDB0")]
			public OptionsWebGL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private enum EADGANEGPDE
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
		private sealed class HEONHLCPCFE : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
			[DebuggerHidden]
			public HEONHLCPCFE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x2A145B0", Offset = "0x2A12BB0", VA = "0x182A145B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x2A146B0", Offset = "0x2A12CB0", VA = "0x182A146B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class IPGOOAJAIIN : IEnumerator<object>, IEnumerator, IDisposable
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
			public ODODOJFGIOL callback;

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
				[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
			[DebuggerHidden]
			public IPGOOAJAIIN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x2A14700", Offset = "0x2A12D00", VA = "0x182A14700", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x2A14C10", Offset = "0x2A13210", VA = "0x182A14C10", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class DNMIPKNNAPM : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
			[DebuggerHidden]
			public DNMIPKNNAPM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x2A11810", Offset = "0x2A0FE10", VA = "0x182A11810", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x2A11A80", Offset = "0x2A10080", VA = "0x182A11A80", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		private AKIEGCEBGBJ _mediaSource;

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
		private AudioSource EGGNBKCLBAB;

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
		private IPPOMOLKIEN.DJBNKFGJPDJ _resampleMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Range(3f, 10f)]
		[SerializeField]
		[FormerlySerializedAs("m_ResampleBufferSize")]
		private int _resampleBufferSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private IPPOMOLKIEN MJNOMHBFDEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		[FormerlySerializedAs("m_videoMapping")]
		private NOPENGNBHNN _videoMapping;

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
		private HNDKMJFIAHI _forceFileFormat;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		protected FNFNDCAKGLJ HPNFOOFFABN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private JEFJECMOAKC IPGIGCDBCAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private LOLDIHPFCMA OEJDHJMPMOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private DBEBEMAOJDA AMNMEDMCLDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private CGOGFGECEJE FOMADKAGAMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private LGMFOKKNKLI EKOAKNDCPIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private CNKFNPDBCCO DMKFKAMMJDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private MAELJHAOCHO MGLOOADABMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private GDONPFBIJEC AEGFJLJKENN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private ADANFEFBKAN HMAPMMABHJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private BIPHNHHBPBH HDMMPIEHJFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private IDisposable HBEDAEEDNHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private bool BPLFLEGJFIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x139")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private bool NOPOBAADHPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13A")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private bool AHKJJENBFAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private Coroutine ANFNCJKHIJC;

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private static bool CPPEPLNALPB;

		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private static bool JBINGBJCMCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private MediaPath BFEPMGBOMPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private Coroutine EPMNIFNLLME;

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static Camera EJNFHLNNMMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private bool IPEEEPFCEOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private bool FEJLBPCEOKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15A")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private bool KBMCHBIBGDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15B")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private bool CNDGAPMILDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private bool EHOBFOPPMII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15D")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private bool EFKBHAFFEDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15E")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private bool FMGFOKGEMON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15F")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private bool DBENBDAOHLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private int MPENBLIFGLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private int ENOAJJHBNCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private int DIPJKJNOGCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private bool LKGMCEJJMEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16D")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private bool BIJFOCBNPGG;

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
		private EADGANEGPDE m_VideoLocation;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public AKIEGCEBGBJ MJCGAPGEIDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xA9D650", Offset = "0xA9BC50", VA = "0x180A9D650")]
			get
			{
				return default(AKIEGCEBGBJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xAA1220", Offset = "0xA9F820", VA = "0x180AA1220")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public MediaReference BJCLPJLLFKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MediaPath MLJECPBCICJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public MediaHints AFKGGJLAEFC
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x11E1560", Offset = "0x11DFB60", VA = "0x1811E1560")]
			get
			{
				return default(MediaHints);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2253CF0", Offset = "0x22522F0", VA = "0x182253CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool FDFKBIDFPDA
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xFC0810", Offset = "0xFBEE10", VA = "0x180FC0810")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xFC0910", Offset = "0xFBEF10", VA = "0x180FC0910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool JNADKFCKNIF
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xFC0ED0", Offset = "0xFBF4D0", VA = "0x180FC0ED0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xFC0E70", Offset = "0xFBF470", VA = "0x180FC0E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool KDJKPKBMAAM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x2A1B3F0", Offset = "0x2A199F0", VA = "0x182A1B3F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x2A1B920", Offset = "0x2A19F20", VA = "0x182A1B920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public virtual float IIPAKAAHGEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x2A1B280", Offset = "0x2A19880", VA = "0x182A1B280", Slot = "6")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x2A1B8A0", Offset = "0x2A19EA0", VA = "0x182A1B8A0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float OCBDHGPPBMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x2A1B1C0", Offset = "0x2A197C0", VA = "0x182A1B1C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x2A1B7B0", Offset = "0x2A19DB0", VA = "0x182A1B7B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public virtual bool ALADPLDKLHD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x2A1B220", Offset = "0x2A19820", VA = "0x182A1B220", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x2A1B830", Offset = "0x2A19E30", VA = "0x182A1B830", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public AudioSource OFGDBLGCHGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xA962C0", Offset = "0xA948C0", VA = "0x180A962C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA96310", Offset = "0xA94910", VA = "0x180A96310")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float ADNBBOOMEFK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2A1B480", Offset = "0x2A19A80", VA = "0x182A1B480")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x2A1B9C0", Offset = "0x2A19FC0", VA = "0x182A1B9C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool PFCHLPKNILB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x1068160", Offset = "0x1066760", VA = "0x181068160")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x1065430", Offset = "0x1063A30", VA = "0x181065430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public IPPOMOLKIEN.DJBNKFGJPDJ NIPNGJHCFEH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xD4F030", Offset = "0xD4D630", VA = "0x180D4F030")]
			get
			{
				return default(IPPOMOLKIEN.DJBNKFGJPDJ);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xF0AB90", Offset = "0xF09190", VA = "0x180F0AB90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public int DOOHMHECDBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xFF8E60", Offset = "0xFF7460", VA = "0x180FF8E60")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x2A1BA30", Offset = "0x2A1A030", VA = "0x182A1BA30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public IPPOMOLKIEN NGMBKICNDPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xA962A0", Offset = "0xA948A0", VA = "0x180A962A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public NOPENGNBHNN CBGOOOPDDJI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xABCF40", Offset = "0xABB540", VA = "0x180ABCF40")]
			get
			{
				return default(NOPENGNBHNN);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x15C6170", Offset = "0x15C4770", VA = "0x1815C6170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public FilterMode LLMDFAMOHNG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x2A1B5D0", Offset = "0x2A19BD0", VA = "0x182A1B5D0")]
			get
			{
				return default(FilterMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x2A1BAB0", Offset = "0x2A1A0B0", VA = "0x182A1BAB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public TextureWrapMode OOJLMENHCMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x2A1B6C0", Offset = "0x2A19CC0", VA = "0x182A1B6C0")]
			get
			{
				return default(TextureWrapMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x2A1BB20", Offset = "0x2A1A120", VA = "0x182A1BB20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public int IBLGCOBHPJH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x2A1B4E0", Offset = "0x2A19AE0", VA = "0x182A1B4E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x2A1BA40", Offset = "0x2A1A040", VA = "0x182A1BA40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool KALEIFMCNIP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xD41F90", Offset = "0xD40590", VA = "0x180D41F90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xDFA630", Offset = "0xDF8C30", VA = "0x180DFA630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public MediaPath PFKLGJCLFGK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xA9D770", Offset = "0xA9BD70", VA = "0x180A9D770")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xA9D7C0", Offset = "0xA9BDC0", VA = "0x180A9D7C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public Transform FPHKICKLEIG
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xB19E20", Offset = "0xB18420", VA = "0x180B19E20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xB65E80", Offset = "0xB64480", VA = "0x180B65E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool AOIMDEFIGLF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xFC0E30", Offset = "0xFBF430", VA = "0x180FC0E30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xFC0E50", Offset = "0xFBF450", VA = "0x180FC0E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public Transform LBLDFMICFIA
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xB65DA0", Offset = "0xB643A0", VA = "0x180B65DA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xB65E50", Offset = "0xB64450", VA = "0x180B65E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public float CODOABHPEHE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x1F7EED0", Offset = "0x1F7D4D0", VA = "0x181F7EED0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x1F7F030", Offset = "0x1F7D630", VA = "0x181F7F030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public float DBNONFFBOGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x1D3DDE0", Offset = "0x1D3C3E0", VA = "0x181D3DDE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x1F7EEE0", Offset = "0x1F7D4E0", VA = "0x181F7EEE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public HttpHeaderData FENMNKKIMBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0xB66230", Offset = "0xB64830", VA = "0x180B66230")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xB66210", Offset = "0xB64810", VA = "0x180B66210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public KeyAuthData OHDMCBMIGLF
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xEBE400", Offset = "0xEBCA00", VA = "0x180EBE400")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xEBE410", Offset = "0xEBCA10", VA = "0x180EBE410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public MediaPlayerEvent BDDIMPKCHKB
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x2A1B2E0", Offset = "0x2A198E0", VA = "0x182A1B2E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public int EPIHKJAKOMP
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0xFD6BE0", Offset = "0xFD51E0", VA = "0x180FD6BE0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0xFD6CD0", Offset = "0xFD52D0", VA = "0x180FD6CD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public bool OPAHEFCJKFH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x2A1B450", Offset = "0x2A19A50", VA = "0x182A1B450")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x2A1B990", Offset = "0x2A19F90", VA = "0x182A1B990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool IDPLDJDDKFD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x2A1B470", Offset = "0x2A19A70", VA = "0x182A1B470")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x2A1B9B0", Offset = "0x2A19FB0", VA = "0x182A1B9B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool MCEHKCKJOPL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x2A1B460", Offset = "0x2A19A60", VA = "0x182A1B460")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x2A1B9A0", Offset = "0x2A19FA0", VA = "0x182A1B9A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public HNDKMJFIAHI PIIBCJPABNG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0xB4F190", Offset = "0xB4D790", VA = "0x180B4F190")]
			get
			{
				return default(HNDKMJFIAHI);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xB4E860", Offset = "0xB4CE60", VA = "0x180B4E860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public virtual DBEBEMAOJDA CFJCFGIBOEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xB229F0", Offset = "0xB20FF0", VA = "0x180B229F0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public virtual JEFJECMOAKC NAINHIFFJMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xB28700", Offset = "0xB26D00", VA = "0x180B28700", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public virtual CGOGFGECEJE DGHFBNKMICB
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xB30CF0", Offset = "0xB2F2F0", VA = "0x180B30CF0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public virtual LOLDIHPFCMA PDJKLBBEBLF
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xB286F0", Offset = "0xB26CF0", VA = "0x180B286F0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual LGMFOKKNKLI LPNEEOANCLP
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xB24920", Offset = "0xB22F20", VA = "0x180B24920", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public virtual MAELJHAOCHO EPJAFLCHNLP
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xB26510", Offset = "0xB24B10", VA = "0x180B26510", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual GDONPFBIJEC IGODDICMJDE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xAFB5F0", Offset = "0xAF9BF0", VA = "0x180AFB5F0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual ADANFEFBKAN LMDHAFDIOGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xC010F0", Offset = "0xBFF6F0", VA = "0x180C010F0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual BIPHNHHBPBH EFADPFGBKFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xB8ABF0", Offset = "0xB891F0", VA = "0x180B8ABF0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public virtual CNKFNPDBCCO ADCJFNKGAGL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xB26660", Offset = "0xB24C60", VA = "0x180B26660", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool ENPBJJCKOHI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x2232060", Offset = "0x2230660", VA = "0x182232060")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public OptionsWindows GCEALHPABPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0xC1EF60", Offset = "0xC1D560", VA = "0x180C1EF60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public OptionsApple CDDIMEBEEGH
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xC045E0", Offset = "0xC02BE0", VA = "0x180C045E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public OptionsApple MKBBDFGBGID
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0xC04000", Offset = "0xC02600", VA = "0x180C04000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public OptionsApple DHOLOLKHMHB
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0xC197D0", Offset = "0xC17DD0", VA = "0x180C197D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public OptionsApple BGMJCIOIMAC
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0xB37690", Offset = "0xB35C90", VA = "0x180B37690")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public OptionsAndroid LKKCPJNCHBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0xC02680", Offset = "0xC00C80", VA = "0x180C02680")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public OptionsOpenHarmony GPKOKGFICLF
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0xB30F60", Offset = "0xB2F560", VA = "0x180B30F60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public OptionsWindowsUWP AABFPLOBDDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0xB47D70", Offset = "0xB46370", VA = "0x180B47D70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public OptionsWebGL AJFFPFFFOCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xB6DDF0", Offset = "0xB6C3F0", VA = "0x180B6DDF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xAA1220", Offset = "0xA9F820", VA = "0x180AA1220")]
		public void SetMediaSource(AKIEGCEBGBJ LBHNPIBFMBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		public void SetMediaReference(MediaReference CCJJAPDHIDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		public void SetMediaPath(MediaPath JKCPEHCGLIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xA96310", Offset = "0xA94910", VA = "0x180A96310")]
		public void SetAudioSource(AudioSource FDHHMJDPGCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2A151C0", Offset = "0x2A137C0", VA = "0x182A151C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2A16C50", Offset = "0x2A15250", VA = "0x182A16C50")]
		protected void IKBFNOBJECD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2A1A620", Offset = "0x2A18C20", VA = "0x182A1A620")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2A19A30", Offset = "0x2A18030", VA = "0x182A19A30")]
		public bool OpenMedia(MediaPath JKCPEHCGLIK, bool KHIDOCNGOBO = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2A19A60", Offset = "0x2A18060", VA = "0x182A19A60")]
		public bool OpenMedia(OAAOAEKHHNH EOHHONHGKPA, string JKCPEHCGLIK, bool KHIDOCNGOBO = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2A199E0", Offset = "0x2A17FE0", VA = "0x182A199E0")]
		public bool OpenMedia(MediaReference BJIGDLAPALI, bool KHIDOCNGOBO = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2A199B0", Offset = "0x2A17FB0", VA = "0x182A199B0")]
		public bool OpenMedia(bool KHIDOCNGOBO = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2A18820", Offset = "0x2A16E20", VA = "0x182A18820")]
		private bool NLFEAJKKNJM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2A18390", Offset = "0x2A16990", VA = "0x182A18390")]
		private void MOJIONFOKFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2A18E50", Offset = "0x2A17450", VA = "0x182A18E50")]
		private void NNOJKFEDLDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2A155C0", Offset = "0x2A13BC0", VA = "0x182A155C0")]
		public void CloseMedia()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2A19C30", Offset = "0x2A18230", VA = "0x182A19C30", Slot = "20")]
		public virtual void Play()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2A19BB0", Offset = "0x2A181B0", VA = "0x182A19BB0", Slot = "21")]
		public virtual void Pause()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2A1A700", Offset = "0x2A18D00", VA = "0x182A1A700")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2A19CC0", Offset = "0x2A182C0", VA = "0x182A19CC0")]
		public void Rewind(bool FEJJHIGJOPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2A1A460", Offset = "0x2A18A60", VA = "0x182A1A460")]
		public void SeekToLiveTime(double EFCGAKGCCGN = 0.0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2A1A860", Offset = "0x2A18E60", VA = "0x182A1A860", Slot = "22")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2A18030", Offset = "0x2A16630", VA = "0x182A18030")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2A14FA0", Offset = "0x2A135A0", VA = "0x182A14FA0")]
		private void ABEOMDJEIOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2A19870", Offset = "0x2A17E70", VA = "0x182A19870")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2A197B0", Offset = "0x2A17DB0", VA = "0x182A197B0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2A19630", Offset = "0x2A17C30", VA = "0x182A19630", Slot = "23")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2A16900", Offset = "0x2A14F00", VA = "0x182A16900")]
		public void ForceDispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2A15B90", Offset = "0x2A14190", VA = "0x182A15B90")]
		private static void DHLHENGFBEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2A193F0", Offset = "0x2A179F0", VA = "0x182A193F0")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2A169D0", Offset = "0x2A14FD0", VA = "0x182A169D0")]
		protected void GMHGGJCDHIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2A15E40", Offset = "0x2A14440", VA = "0x182A15E40")]
		private void EHFPFOICCBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2A19130", Offset = "0x2A17730", VA = "0x182A19130")]
		[IteratorStateMachine(typeof(HEONHLCPCFE))]
		private IEnumerator OEDOHHKGIDM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0")]
		public static BGCNMKKBMDO GetPlatform()
		{
			return default(BGCNMKKBMDO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xC1EF60", Offset = "0xC1D560", VA = "0x180C1EF60")]
		public PlatformOptions GetCurrentPlatformOptions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2A15540", Offset = "0x2A13B40", VA = "0x182A15540")]
		private string CBDDLGNBFCI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0")]
		private long GMGKLGFBMHP()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2A15230", Offset = "0x2A13830", VA = "0x182A15230")]
		private string BDMGELJHAIO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2A15CF0", Offset = "0x2A142F0", VA = "0x182A15CF0")]
		private string DKMBPADEFDB(string FJDLJPAACPO, OAAOAEKHHNH EJIDMGLHNKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2A18240", Offset = "0x2A16840", VA = "0x182A18240")]
		private static FNFNDCAKGLJ MNGDMKMBBCB(OptionsWindows EEPOAHLOJPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2A17B80", Offset = "0x2A16180", VA = "0x182A17B80")]
		private static FNFNDCAKGLJ KEPNOBNLEGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2A15730", Offset = "0x2A13D30", VA = "0x182A15730", Slot = "24")]
		public virtual FNFNDCAKGLJ CreateMediaPlayer()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2A191B0", Offset = "0x2A177B0", VA = "0x182A191B0")]
		private void OGNHFCPMFBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2A17EE0", Offset = "0x2A164E0", VA = "0x182A17EE0")]
		private void LLPALMLFMEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2A15E90", Offset = "0x2A14490", VA = "0x182A15E90")]
		private void EHGMIINADEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0")]
		public bool IsUsingAndroidOESPath()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0")]
		public bool IsUsingYCbCr()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2A1A170", Offset = "0x2A18770", VA = "0x182A1A170")]
		[ContextMenu("Save Frame To PNG")]
		public void SaveFrameToPng()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2A19D40", Offset = "0x2A18340", VA = "0x182A19D40")]
		[ContextMenu("Save Frame To EXR")]
		public void SaveFrameToExr()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		private void OnApplicationFocus(bool PGIBFLHGFKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		private void OnApplicationPause(bool JAEHKGKDNHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2A17BD0", Offset = "0x2A161D0", VA = "0x182A17BD0")]
		private void LGCACPECMAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2A19AE0", Offset = "0x2A180E0", VA = "0x182A19AE0")]
		private void PCAPOCKOEEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2A17E50", Offset = "0x2A16450", VA = "0x182A17E50")]
		private void LHKKOOIACAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2A166C0", Offset = "0x2A14CC0", VA = "0x182A166C0")]
		private void FABDCOAIPPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2A16A90", Offset = "0x2A15090", VA = "0x182A16A90")]
		private void GOILNFMOCBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2A15AD0", Offset = "0x2A140D0", VA = "0x182A15AD0")]
		protected bool DFGAABILKMH(MediaPlayerEvent.BHFBPEFIMHM IADNLFHPMLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2A15B00", Offset = "0x2A14100", VA = "0x182A15B00")]
		private bool DGOHIIKJGFF(MediaPlayerEvent.BHFBPEFIMHM IADNLFHPMLP, bool MLEHOIGOLDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2A17400", Offset = "0x2A15A00", VA = "0x182A17400")]
		private bool JNBBFEGHNNK(MediaPlayerEvent.BHFBPEFIMHM HBCMLPDPBCA, bool MLEHOIGOLDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2A18F70", Offset = "0x2A17570", VA = "0x182A18F70")]
		private bool NOFBLBPMMML(int GKNICGGCAME, float EEAHNJCHECH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2A152E0", Offset = "0x2A138E0", VA = "0x182A152E0")]
		private static Camera BOPBMDHADLM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2A18170", Offset = "0x2A16770", VA = "0x182A18170")]
		[IteratorStateMachine(typeof(IPGOOAJAIIN))]
		private IEnumerator MJLKAMNJOBC(Texture2D LKEAKCADNOO, ODODOJFGIOL GDMDDGECOJI, double LLMILILJNFF = -1.0, bool DPEPEDKOLOJ = true, int EEAHNJCHECH = 1000, int NMJCHFJPMIE = 100)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2A16460", Offset = "0x2A14A60", VA = "0x182A16460")]
		public void ExtractFrameAsync(Texture2D LKEAKCADNOO, ODODOJFGIOL GDMDDGECOJI, double LLMILILJNFF = -1.0, bool DPEPEDKOLOJ = true, int EEAHNJCHECH = 1000, int NMJCHFJPMIE = 100)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2A16540", Offset = "0x2A14B40", VA = "0x182A16540")]
		public Texture2D ExtractFrame(Texture2D LKEAKCADNOO, double LLMILILJNFF = -1.0, bool DPEPEDKOLOJ = true, int EEAHNJCHECH = 1000, int NMJCHFJPMIE = 100)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2A17C00", Offset = "0x2A16200", VA = "0x182A17C00")]
		private Texture LHEILBKEDAJ(double LLMILILJNFF = -1.0, bool DPEPEDKOLOJ = true, int EEAHNJCHECH = 1000, int NMJCHFJPMIE = 100)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x2A198F0", Offset = "0x2A17EF0", VA = "0x182A198F0")]
		public bool OpenMediaFromBuffer(byte[] COEFMBJKIKA, bool KHIDOCNGOBO = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x2A1A560", Offset = "0x2A18B60", VA = "0x182A1A560")]
		public bool StartOpenChunkedMediaFromBuffer(ulong FODNOPLPBPI, bool KHIDOCNGOBO = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2A150A0", Offset = "0x2A136A0", VA = "0x182A150A0")]
		public bool AddChunkToVideoBuffer(byte[] MHJLEDKHHBE, ulong EFCGAKGCCGN, ulong MOFDPKCAJHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2A163E0", Offset = "0x2A149E0", VA = "0x182A163E0")]
		public bool EndOpenChunkedVideoFromBuffer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2A17970", Offset = "0x2A15F70", VA = "0x182A17970")]
		private bool JOLDHABNCBN(byte[] COEFMBJKIKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2A18610", Offset = "0x2A16C10", VA = "0x182A18610")]
		private bool NJFDOHBPACA(ulong FODNOPLPBPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2A150A0", Offset = "0x2A136A0", VA = "0x182A150A0")]
		private bool PKLHAKIKPPO(byte[] MHJLEDKHHBE, ulong EFCGAKGCCGN, ulong MOFDPKCAJHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2A163E0", Offset = "0x2A149E0", VA = "0x182A163E0")]
		private bool NMLHAHIFJHE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2A16000", Offset = "0x2A14600", VA = "0x182A16000")]
		public bool EnableSubtitles(MediaPath HJEOKCLCJJD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2A17350", Offset = "0x2A15950", VA = "0x182A17350")]
		[IteratorStateMachine(typeof(DNMIPKNNAPM))]
		private IEnumerator JDGBOOILFPP(string KDMMFJGANAK, MediaPath HJEOKCLCJJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2A15D60", Offset = "0x2A14360", VA = "0x182A15D60")]
		public void DisableSubtitles()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2A1A760", Offset = "0x2A18D60", VA = "0x182A1A760", Slot = "5")]
		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2A1AC90", Offset = "0x2A19290", VA = "0x182A1AC90")]
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
			public enum CCBBCOHAPFM
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
			public CCBBCOHAPFM sourceType;

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
			public PlaylistMediaPlayer.FIFHCKJLOEH startMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			[SerializeField]
			public PlaylistMediaPlayer.AIGGJDKDICH progressMode;

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
			public PlaylistMediaPlayer.LLKGLGJIPCK overrideTransition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			[SerializeField]
			public float overrideTransitionDuration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			[SerializeField]
			public EPOGJEAMGEK.JNOKELABMAB overrideTransitionEasing;

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x2A14C60", Offset = "0x2A13260", VA = "0x182A14C60")]
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
			[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2A1BB90", Offset = "0x2A1A190", VA = "0x182A1BB90")]
		public bool FLDMMDPMANF(int LEPAEEGOBDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2A1BBF0", Offset = "0x2A1A1F0", VA = "0x182A1BBF0")]
		public MediaPlaylist()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[AddComponentMenu("AVPro Video/Playlist Media Player", -80)]
	[HelpURL("https://www.renderheads.com/products/avpro-video/")]
	public class PlaylistMediaPlayer : MediaPlayer, LOLDIHPFCMA
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public enum LLKGLGJIPCK
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
		public enum KDGDBLEHDOF
		{
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			Loop
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public enum FIFHCKJLOEH
		{
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			Immediate,
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			Manual
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public enum AIGGJDKDICH
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
		private sealed class GFIAHAIIILJ : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
			[DebuggerHidden]
			public GFIAHAIIILJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x2A13ED0", Offset = "0x2A124D0", VA = "0x182A13ED0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x2A14560", Offset = "0x2A12B60", VA = "0x182A14560", Slot = "8")]
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
		private KDGDBLEHDOF _playlistLoopMode;

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
		private LLKGLGJIPCK _defaultTransition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[SerializeField]
		private float _defaultTransitionDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[SerializeField]
		private EPOGJEAMGEK.JNOKELABMAB _defaultTransitionEasing;

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
		private static readonly FHBFMADDBJI FFJHKMHGGCB;

		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private static readonly FHBFMADDBJI KBKJPHEAAFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x205")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private bool NMCMCLAELLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private int AJIPLNFOLBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private MediaPlayer GGJAOJJDKEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private Material ELKLMLDDAHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private LLKGLGJIPCK PHOIGIGDLMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private string LIEPECEBJEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private float HHFBLMOHEPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x234")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private EPOGJEAMGEK.JNOKELABMAB JBGCIPAFANE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private float ELNPKFIMEOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private Func<float, float> LIHKMGFPGDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private RenderTexture PPDIDEAEDJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private MediaPlaylist.MediaItem GFFCEMJDCOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private MediaPlaylist.MediaItem GGFAFOHIOIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private WaitForEndOfFrame JFJINILIFEE;

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public MediaPlayer OKEPDJLONHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x2A1FC90", Offset = "0x2A1E290", VA = "0x182A1FC90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public MediaPlayer MJDNAONFDOO
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xBC28B0", Offset = "0xBC0EB0", VA = "0x180BC28B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public MediaPlaylist IOIDLFBDANF
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xB8ABE0", Offset = "0xB891E0", VA = "0x180B8ABE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public int LEGIGGPBJKA
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x26E8EE0", Offset = "0x26E74E0", VA = "0x1826E8EE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public MediaPlaylist.MediaItem FMPHBEBAEKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x2A1FDE0", Offset = "0x2A1E3E0", VA = "0x182A1FDE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public LLKGLGJIPCK PNAKMLJMOJF
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xD92BF0", Offset = "0xD911F0", VA = "0x180D92BF0")]
			get
			{
				return default(LLKGLGJIPCK);
			}
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x15F4180", Offset = "0x15F2780", VA = "0x1815F4180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public float ACDOCBHOECG
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x1F17AB0", Offset = "0x1F160B0", VA = "0x181F17AB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x2191560", Offset = "0x218FB60", VA = "0x182191560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public EPOGJEAMGEK.JNOKELABMAB LFIAAHMOALK
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0xB47F30", Offset = "0xB46530", VA = "0x180B47F30")]
			get
			{
				return default(EPOGJEAMGEK.JNOKELABMAB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xB46320", Offset = "0xB44920", VA = "0x180B46320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public bool EHAEKFHOENP
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x16070F0", Offset = "0x16056F0", VA = "0x1816070F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x1609CE0", Offset = "0x16082E0", VA = "0x181609CE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public KDGDBLEHDOF HCNKGAHCAPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x2A1FDD0", Offset = "0x2A1E3D0", VA = "0x182A1FDD0")]
			get
			{
				return default(KDGDBLEHDOF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x2A20060", Offset = "0x2A1E660", VA = "0x182A20060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public bool KFCFGBGEIMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xC03C00", Offset = "0xC02200", VA = "0x180C03C00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xC0F7F0", Offset = "0xC0DDF0", VA = "0x180C0F7F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public override DBEBEMAOJDA CFJCFGIBOEO
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x2A1FD30", Offset = "0x2A1E330", VA = "0x182A1FD30", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public override JEFJECMOAKC NAINHIFFJMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x2A1FBF0", Offset = "0x2A1E1F0", VA = "0x182A1FBF0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public override LOLDIHPFCMA PDJKLBBEBLF
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xE0C5B0", Offset = "0xE0ABB0", VA = "0x180E0C5B0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public override float IIPAKAAHGEM
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x2190F80", Offset = "0x218F580", VA = "0x182190F80", Slot = "6")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x2A1FF70", Offset = "0x2A1E570", VA = "0x182A1FF70", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public override bool ALADPLDKLHD
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x2A1FBE0", Offset = "0x2A1E1E0", VA = "0x182A1FBE0", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x2A1FEA0", Offset = "0x2A1E4A0", VA = "0x182A1FEA0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2A1F030", Offset = "0x2A1D630", VA = "0x182A1F030", Slot = "20")]
		public override void Play()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2A1EF20", Offset = "0x2A1D520", VA = "0x182A1EF20", Slot = "21")]
		public override void Pause()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2A1E170", Offset = "0x2A1C770", VA = "0x182A1E170")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2A1E6C0", Offset = "0x2A1CCC0", VA = "0x182A1E6C0")]
		[IteratorStateMachine(typeof(GFIAHAIIILJ))]
		private IEnumerator OOIIIABJPMJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2A1D5E0", Offset = "0x2A1BBE0", VA = "0x182A1D5E0")]
		private Texture EAPFMDJAAHP(int LEPAEEGOBDO = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2A1D4F0", Offset = "0x2A1BAF0", VA = "0x182A1D4F0")]
		private Texture DJNNIKKOBDP(int LEPAEEGOBDO = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2A1CFD0", Offset = "0x2A1B5D0", VA = "0x182A1CFD0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2A1E740", Offset = "0x2A1CD40", VA = "0x182A1E740", Slot = "23")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2A1F1F0", Offset = "0x2A1D7F0", VA = "0x182A1F1F0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2A1E9C0", Offset = "0x2A1CFC0", VA = "0x182A1E9C0")]
		public void OnMediaPlayerEvent(MediaPlayer DDGBEDKCOOJ, MediaPlayerEvent.BHFBPEFIMHM IADNLFHPMLP, HIICDHDBEHA DCHHIMINIKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2A1F140", Offset = "0x2A1D740", VA = "0x182A1F140")]
		public bool PrevItem()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2A1E640", Offset = "0x2A1CC40", VA = "0x182A1E640")]
		public bool NextItem()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2A1D420", Offset = "0x2A1BA20", VA = "0x182A1D420")]
		public bool CanJumpToItem(int LEPAEEGOBDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2A1E180", Offset = "0x2A1C780", VA = "0x182A1E180")]
		public bool JumpToItem(int LEPAEEGOBDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2A1EB80", Offset = "0x2A1D180", VA = "0x182A1EB80")]
		public void OpenVideoFile(MediaPlaylist.MediaItem CLDMNNOIMHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2A1CFB0", Offset = "0x2A1B5B0", VA = "0x182A1CFB0")]
		private bool AJJCMFEHNDJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2A1E2C0", Offset = "0x2A1C8C0", VA = "0x182A1E2C0")]
		private void KAOIKBBIOKL(LLKGLGJIPCK DGPNCOJKBKD, float ECPJMMFGCIP, EPOGJEAMGEK.JNOKELABMAB EEPAOLBLDDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2A1F420", Offset = "0x2A1DA20", VA = "0x182A1F420", Slot = "22")]
		protected override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2A1DF50", Offset = "0x2A1C550", VA = "0x182A1DF50", Slot = "26")]
		public Texture GetTexture(int LEPAEEGOBDO = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2A1D9C0", Offset = "0x2A1BFC0", VA = "0x182A1D9C0", Slot = "25")]
		public int GetTextureCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x2A1DA60", Offset = "0x2A1C060", VA = "0x182A1DA60", Slot = "27")]
		public int GetTextureFrameCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2A1F380", Offset = "0x2A1D980", VA = "0x182A1F380", Slot = "28")]
		public bool SupportsTextureFrameCount()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2A1DD80", Offset = "0x2A1C380", VA = "0x182A1DD80", Slot = "29")]
		public long GetTextureTimeStamp()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2A1DC30", Offset = "0x2A1C230", VA = "0x182A1DC30", Slot = "30")]
		public float GetTexturePixelAspectRatio()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2A1F150", Offset = "0x2A1D750", VA = "0x182A1F150", Slot = "31")]
		public bool RequiresVerticalFlip()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2A1E040", Offset = "0x2A1C640", VA = "0x182A1E040", Slot = "35")]
		public Matrix4x4 GetYpCbCrTransform()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2A1DCE0", Offset = "0x2A1C2E0", VA = "0x182A1DCE0", Slot = "32")]
		public OICPENEHCJE GetTextureStereoPacking()
		{
			return default(OICPENEHCJE);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x2A1DEB0", Offset = "0x2A1C4B0", VA = "0x182A1DEB0", Slot = "33")]
		public MEALJBMNFBD GetTextureTransparency()
		{
			return default(MEALJBMNFBD);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x2A1D920", Offset = "0x2A1BF20", VA = "0x182A1D920", Slot = "34")]
		public ALDPFJHPMEB GetTextureAlphaPacking()
		{
			return default(ALDPFJHPMEB);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x2A1D6F0", Offset = "0x2A1BCF0", VA = "0x182A1D6F0", Slot = "36")]
		public float[] GetAffineTransform()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x2A1DB00", Offset = "0x2A1C100", VA = "0x182A1DB00", Slot = "37")]
		public Matrix4x4 GetTextureMatrix()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x2A1D7E0", Offset = "0x2A1BDE0", VA = "0x182A1D7E0", Slot = "38")]
		public RenderTextureFormat GetCompatibleRenderTextureFormat(KEPCOKOKENL EEPOAHLOJPI, int HCAIIGECACJ)
		{
			return default(RenderTextureFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x2A1D160", Offset = "0x2A1B760", VA = "0x182A1D160")]
		private static string BJBFPNMLHCA(LLKGLGJIPCK DGPNCOJKBKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x2A1FA30", Offset = "0x2A1E030", VA = "0x182A1FA30")]
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
		private OLAGHBFDJKJ.MLBFNEMIFCF _resolveFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[SerializeField]
		private RenderTexture _externalTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private Material HBNEPDIFKAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private bool NOOFNLFMIEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x69")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private bool AIKGKNDKGMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6A")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private bool BCPIDAEOFAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private RenderTexture BKAJCAOAKCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private int LAKAAHGDGOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private Material EDMBMFFGIEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private int MDEPANOKCPP;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public MediaPlayer OAKPGKECJGB
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x2A20070", Offset = "0x2A1E670", VA = "0x182A20070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public VideoResolveOptions PNKICAMPBME
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x2A20B70", Offset = "0x2A1F170", VA = "0x182A20B70")]
			get
			{
				return default(VideoResolveOptions);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x2A20B90", Offset = "0x2A1F190", VA = "0x182A20B90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public RenderTexture LCNKFAJNDME
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xA962B0", Offset = "0xA948B0", VA = "0x180A962B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xA96300", Offset = "0xA94900", VA = "0x180A96300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public RenderTexture PFBMFHGIJIF
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x2A20AF0", Offset = "0x2A1F0F0", VA = "0x182A20AF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2A20920", Offset = "0x2A1EF20", VA = "0x182A20920")]
		public void SetMaterialDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x2A20070", Offset = "0x2A1E670", VA = "0x182A20070")]
		private void DDDPNNDOJFL(MediaPlayer DDGBEDKCOOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x2A20930", Offset = "0x2A1EF30", VA = "0x182A20930")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2A20110", Offset = "0x2A1E710", VA = "0x182A20110")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x2A20240", Offset = "0x2A1E840", VA = "0x182A20240")]
		public void Resolve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x2A201C0", Offset = "0x2A1E7C0", VA = "0x182A201C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2A20120", Offset = "0x2A1E720", VA = "0x182A20120")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2A20AA0", Offset = "0x2A1F0A0", VA = "0x182A20AA0")]
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
		private static readonly FHBFMADDBJI EAELNJLPBPH;

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private static readonly FHBFMADDBJI NFOCFFDIOAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private Camera PEGCCBECBJE;

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Camera DAAEDMEDGBG
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2A20BB0", Offset = "0x2A1F1B0", VA = "0x182A20BB0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2A214B0", Offset = "0x2A1FAB0", VA = "0x182A214B0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2A20C50", Offset = "0x2A1F250", VA = "0x182A20C50")]
		private void BEABEOJBOAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2A21480", Offset = "0x2A1FA80", VA = "0x182A21480")]
		private static bool NOEJELIDNEF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2A210A0", Offset = "0x2A1F6A0", VA = "0x182A210A0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA97AB0", Offset = "0xA960B0", VA = "0x180A97AB0")]
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
		private OICPENEHCJE _overrideStereoPacking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[SerializeField]
		private bool _stereoRedGreenTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		protected bool MIFDGBBCOBA;

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public MediaPlayer DGHFBNKMICB
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x2A0C120", Offset = "0x2A0A720", VA = "0x182A0C120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public bool NNODMBNGJEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xA95030", Offset = "0xA93630", VA = "0x180A95030")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x2A0C100", Offset = "0x2A0A700", VA = "0x182A0C100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public OICPENEHCJE LFCGLJMMOBP
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xC3A7A0", Offset = "0xC38DA0", VA = "0x180C3A7A0")]
			get
			{
				return default(OICPENEHCJE);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x2A0C110", Offset = "0x2A0A710", VA = "0x182A0C110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public bool OCJOPKLAGPC
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xC3A790", Offset = "0xC38D90", VA = "0x180C3A790")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x2A0C130", Offset = "0x2A0A730", VA = "0x182A0C130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x2A0BE20", Offset = "0x2A0A420", VA = "0x182A0BE20")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x2A0BE30", Offset = "0x2A0A430", VA = "0x182A0BE30")]
		private void DDDPNNDOJFL(MediaPlayer LIOICDJHFAF, bool MKJGBAFLMBJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x2A0C020", Offset = "0x2A0A620", VA = "0x182A0C020")]
		private void GPPBDHGJLHE(MediaPlayer DPAFDJOAOAE, MediaPlayerEvent.BHFBPEFIMHM HBCMLPDPBCA, HIICDHDBEHA DCHHIMINIKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x2A0BFE0", Offset = "0x2A0A5E0", VA = "0x182A0BFE0")]
		public void ForceUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x2A0C0C0", Offset = "0x2A0A6C0", VA = "0x182A0C0C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x2A0C070", Offset = "0x2A0A670", VA = "0x182A0C070", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x1A76FE0", Offset = "0x1A755E0", VA = "0x181A76FE0", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x2A0C060", Offset = "0x2A0A660", VA = "0x182A0C060")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "6")]
		protected virtual void JABHJLIECMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "7")]
		protected virtual void GFGCABLMDLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void Apply();

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x1852A60", Offset = "0x1851060", VA = "0x181852A60")]
		protected ApplyToBase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class NIPONGOFANG
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	protected class ENCBLABMEDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public HashSet<AudioOutput> ODMHBALFOGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public float[] JEDONKNEIFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public bool AFEBALJECOO;

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public ENCBLABMEDN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private static NIPONGOFANG MDCEPNGNCGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private Dictionary<int, ENCBLABMEDN> BJEKGDPOFEP;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public static NIPONGOFANG DOBPPELCKJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x2A1BE70", Offset = "0x2A1A470", VA = "0x182A1BE70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x2A1CB00", Offset = "0x2A1B100", VA = "0x182A1CB00")]
	private NIPONGOFANG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x2A1CA00", Offset = "0x2A1B000", VA = "0x182A1CA00")]
	public void OIGFKHHAFMP(int FOIPJBPEOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x2A1C980", Offset = "0x2A1AF80", VA = "0x182A1C980")]
	public void NKJGKHBLEFD(int FOIPJBPEOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x2A1C0D0", Offset = "0x2A1A6D0", VA = "0x182A1C0D0")]
	public void MMOLIFPBEGJ(AudioOutput LGAGPCBPAPG, MediaPlayer DDGBEDKCOOJ, int FOIPJBPEOEE, float[] CGFMINAMLCP, int PDJAKLOEBHK, int IEIMJJPBJHN, AudioOutput.DJDHGDCIBPC OMHCOKFDDDK, bool CIEJDBLGCMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x2A1BF80", Offset = "0x2A1A580", VA = "0x182A1BF80")]
	private void IOHEPCGLLGM(float[] CGFMINAMLCP, int KLCMFLNNGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x2A1BFC0", Offset = "0x2A1A5C0", VA = "0x182A1BFC0")]
	private bool JGINEHBAPJG(MediaPlayer LIOICDJHFAF, float[] CGFMINAMLCP, int FPNDCHNJFNF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[DefaultMember("Item")]
public abstract class FNFNDCAKGLJ : CGOGFGECEJE, JEFJECMOAKC, DBEBEMAOJDA, CNKFNPDBCCO, LOLDIHPFCMA, LGMFOKKNKLI, MAELJHAOCHO, GDONPFBIJEC, ADANFEFBKAN, BIPHNHHBPBH, IEnumerable, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	protected string IAJBNEFFGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	protected HIICDHDBEHA CCCNGBMFBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	protected FilterMode NBGBKFGOPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	protected TextureWrapMode BIOJENEAMGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	protected int PKODHILHNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	protected MediaHints DPJIKEOCIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	protected ANLEIFHOLEO HFMMBEBAFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	protected ANLEIFHOLEO PEIPJDBPPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private float PGHEPJMBFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private int OODBEMEAEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private float EKAHGFDLGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private float LLJKMJBAKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private int AEMNOMAMFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private int GPODKDILEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	protected List<LAHNBAHGNCC> JFLGPMOMLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	protected LAHNBAHGNCC MPFIPMKEOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	protected FCFMJFKHOII KDLDMEOCLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	protected ECIIDPNJKMN PKJODMLENKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	protected EIMHDLAFEHN HPOHCDIMJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	protected DMJMMEMPCDE NILLEPCBNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	protected PCLKAFLDHBE KFOCOGIEJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	protected EPJEJMEILJM[] ECIOMEDPNNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	protected List<LACOBJPJJJA> AKPKNNMPADC;

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x2A13B30", Offset = "0x2A12130", VA = "0x182A13B30")]
	public FNFNDCAKGLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "82")]
	public abstract string AJEICOJDHIG();

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "83")]
	public abstract string BOAKMJDFIFO();

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "84")]
	public abstract bool POJPJOMDDPI(string JKCPEHCGLIK, long EFCGAKGCCGN, string BKMDMCCIPGI, MediaHints PGHDGGOCHNA, int ALELCIDKPJD = 0, bool BGCEEPLOFEB = false);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "85")]
	public virtual bool KPGIFLMONKK(byte[] COEFMBJKIKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "86")]
	public virtual bool KEBGKOFIOLP(ulong FODNOPLPBPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "87")]
	public virtual bool GONEBHNCGMI(byte[] MHJLEDKHHBE, ulong EFCGAKGCCGN, ulong FODNOPLPBPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "88")]
	public virtual bool JOEJCHHOJON()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x2A12BE0", Offset = "0x2A111E0", VA = "0x182A12BE0", Slot = "89")]
	public virtual void GBPEDHFLCHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "90")]
	public abstract void MBKFCKLHLNI(bool EHDGMIFDJFF);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "91")]
	public abstract bool LGGCDCOGBMP();

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "92")]
	public abstract bool LEIBNOPKOFP();

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "93")]
	public abstract bool AJCHFCJENLP();

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "94")]
	public abstract void JFNOLEJOLGK();

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "95")]
	public abstract void PCEOJEMCNIE();

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "96")]
	public abstract void MNEFMGBPPHF();

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x2A12990", Offset = "0x2A10F90", VA = "0x182A12990", Slot = "97")]
	public virtual void CADABNLNHKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "98")]
	public abstract void DAFCDADJIEH(double FLCAFPMKFLE);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "99")]
	public abstract void BHPIBAEEPCF(double FLCAFPMKFLE);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "100")]
	public abstract double AIIKFDHPEAF();

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "101")]
	public abstract float ENBJODBDBIM();

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "102")]
	public abstract void MCFAOOMNGPD(float EMACLCMJPPD);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "103")]
	public abstract double MFGNDFEKCPP();

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "104")]
	public abstract int GHDEINPKEBK();

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "105")]
	public abstract int MLCGAFDMLBF();

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "106")]
	public abstract float GFLOLEOKKEH();

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "107")]
	public abstract bool CLIHPMHNFND();

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "108")]
	public abstract bool JFHEEGBIJAB();

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "109")]
	public abstract bool KNKMBDAKGNM();

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "110")]
	public abstract bool EHFAJNLFEII();

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "111")]
	public abstract bool HENGHMBIENC();

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "112")]
	public abstract bool OMEGOIEKINN();

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "113")]
	public abstract bool GDBDPDDJOAK();

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "114")]
	public virtual bool BJNNFEHDFHK(Camera ONKIDIPKLEC, int MOADIOMDCBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0xC21180", Offset = "0xC1F780", VA = "0x180C21180", Slot = "115")]
	public virtual int GetTextureCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "116")]
	public abstract Texture GetTexture(int LEPAEEGOBDO = 0);

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "117")]
	public abstract int GetTextureFrameCount();

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0", Slot = "118")]
	public virtual bool SupportsTextureFrameCount()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x2A12F90", Offset = "0x2A11590", VA = "0x182A12F90", Slot = "119")]
	public virtual long GetTextureTimeStamp()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "120")]
	public abstract bool RequiresVerticalFlip();

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0xC3A780", Offset = "0xC38D80", VA = "0x180C3A780", Slot = "121")]
	public virtual float GetTexturePixelAspectRatio()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x2A12FA0", Offset = "0x2A115A0", VA = "0x182A12FA0", Slot = "122")]
	public virtual Matrix4x4 GetYpCbCrTransform()
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x2A12C80", Offset = "0x2A11280", VA = "0x182A12C80", Slot = "123")]
	public virtual float[] GetAffineTransform()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x2A132D0", Offset = "0x2A118D0", VA = "0x182A132D0", Slot = "124")]
	public virtual float[] JADCKKIIFMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x2A12DC0", Offset = "0x2A113C0", VA = "0x182A12DC0", Slot = "125")]
	public virtual Matrix4x4 GetTextureMatrix()
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0xF12EF0", Offset = "0xF114F0", VA = "0x180F12EF0", Slot = "126")]
	public virtual RenderTextureFormat GetCompatibleRenderTextureFormat(KEPCOKOKENL EEPOAHLOJPI, int HCAIIGECACJ)
	{
		return default(RenderTextureFormat);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x2A12F60", Offset = "0x2A11560", VA = "0x182A12F60", Slot = "70")]
	public OICPENEHCJE GetTextureStereoPacking()
	{
		return default(OICPENEHCJE);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "127")]
	internal abstract OICPENEHCJE KAGKELHMDLG();

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0xA9FA90", Offset = "0xA9E090", VA = "0x180A9FA90", Slot = "128")]
	public virtual MEALJBMNFBD GetTextureTransparency()
	{
		return default(MEALJBMNFBD);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x2A12D80", Offset = "0x2A11380", VA = "0x182A12D80", Slot = "72")]
	public ALDPFJHPMEB GetTextureAlphaPacking()
	{
		return default(ALDPFJHPMEB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "129")]
	public abstract void JDEJIGDCPJJ(bool EJBGKFHMCHK);

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "130")]
	public abstract bool CIKDANALLPE();

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "131")]
	public abstract void HFHMAGGLDBH(float FGHGJFNAJIH);

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "132")]
	public virtual void GINEFLLDDNH(float FHHCADNOHDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "133")]
	public abstract float DGDPNIIHFAH();

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0xAE6850", Offset = "0xAE4E50", VA = "0x180AE6850", Slot = "134")]
	public virtual float EFHEOAAIAAA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0xAE6860", Offset = "0xAE4E60", VA = "0x180AE6860", Slot = "135")]
	public virtual int CIHCFJPNCPN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "136")]
	public virtual int JGINEHBAPJG(float[] CGFMINAMLCP, int MEBINNCEBNJ, int FPNDCHNJFNF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "137")]
	public virtual void EJNGGCAMCEA(bool HLFMNDHEGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "138")]
	public virtual void JEHEJLAHMBI(Quaternion EKPPOBOIFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "139")]
	public virtual void GLLLBJEDKMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "140")]
	public virtual void GPLJNLACLBL(PKHJIOPINGD IAFKLPLOCCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "141")]
	public virtual void FKCJPEDLFGE(bool ANBCINBEIHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "142")]
	public virtual void KKACMGIBLFD(float ANBIGHNEOOL, float IBLKNHIHNMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "143")]
	public virtual void CKKMKONOHJE(Quaternion EKPPOBOIFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "144")]
	public virtual void PDPJPMEEKOO(string HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "145")]
	public virtual void LEDICGOIJNN(byte[] HFLDIIIPBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(Slot = "146")]
	public abstract void FLHPFKIPOFF();

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "147")]
	public virtual void MHKKCKEAAKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "148")]
	public abstract void DJALLKHDNEM();

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(Slot = "149")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "150")]
	public virtual void JEJGLKBFKJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x2A12980", Offset = "0x2A10F80", VA = "0x182A12980", Slot = "40")]
	public HIICDHDBEHA BCMBMPACGEE()
	{
		return default(HIICDHDBEHA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0", Slot = "151")]
	public virtual bool DPEFFCHACFE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0xA99310", Offset = "0xA97910", VA = "0x180A99310", Slot = "39")]
	public ANLEIFHOLEO OBHNINFHGJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x2A132B0", Offset = "0x2A118B0", VA = "0x182A132B0", Slot = "42")]
	public void IKMPEFMMDLO([Out] FilterMode ODAEJFIKMEL, [Out] TextureWrapMode JKICGHKHIMN, [Out] int KANKGDJGFOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x2A13000", Offset = "0x2A11600", VA = "0x182A13000", Slot = "41")]
	public void HBOEKHICPLP(FilterMode ODAEJFIKMEL = FilterMode.Bilinear, TextureWrapMode JKICGHKHIMN = TextureWrapMode.Clamp, int KANKGDJGFOF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x2A13210", Offset = "0x2A11810", VA = "0x182A13210", Slot = "152")]
	protected virtual void IGLHDFMBDEG(Texture BHNOPLHICEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x2A128E0", Offset = "0x2A10EE0", VA = "0x182A128E0")]
	protected void AJGKGMPMIBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x2A13090", Offset = "0x2A11690", VA = "0x182A13090")]
	protected bool HNKDOBMBAHE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x2A13800", Offset = "0x2A11E00", VA = "0x182A13800", Slot = "153")]
	public virtual bool OALKFAOGLAH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x2A13430", Offset = "0x2A11A30", VA = "0x182A13430", Slot = "77")]
	public bool KCOMEFIMLCG(string DAJAOHIJHHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x2A132F0", Offset = "0x2A118F0", VA = "0x182A132F0", Slot = "154")]
	public virtual void JGPIDCNIGGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x2A13AA0", Offset = "0x2A120A0", VA = "0x182A13AA0", Slot = "155")]
	public virtual int OBMHBPBAJKD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x2A13AC0", Offset = "0x2A120C0", VA = "0x182A13AC0", Slot = "156")]
	public virtual string PLHODOIELDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "157")]
	public virtual void GMBGDNHKJIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x2A129B0", Offset = "0x2A10FB0", VA = "0x182A129B0", Slot = "158")]
	public int ECLCPFGJBHH(float OBDICDIBLHC = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x2A13550", Offset = "0x2A11B50", VA = "0x182A13550")]
	protected bool KHGCBHINGOF(bool MKJGBAFLMBJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "159")]
	internal abstract bool BLJHIPGBGEP();

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "160")]
	internal abstract string MKJODHNJEKM();

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(Slot = "161")]
	internal abstract bool IAINHDHNKPM(EGPMBGNKJOC MLFHHDFGEFM);

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(Slot = "162")]
	internal abstract int HOPDMACDOCN(EGPMBGNKJOC MLFHHDFGEFM);

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "163")]
	internal abstract KNLMCFLAKBL CFLKBCDOFAA(EGPMBGNKJOC MLFHHDFGEFM, int KOOPHJIGKIK, bool HGFCKBPDCCC);

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x2A12A70", Offset = "0x2A11070", VA = "0x182A12A70")]
	private void GALGOLNDPDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x2A134A0", Offset = "0x2A11AA0", VA = "0x182A134A0")]
	protected void KGCCECPNNMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x2A13630", Offset = "0x2A11C30", VA = "0x182A13630")]
	private void LABHKALLENF(EPJEJMEILJM KJALALPGBHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x2A12CF0", Offset = "0x2A112F0", VA = "0x182A12CF0", Slot = "164")]
	public virtual IEnumerator GetEnumerator()
	{
		return null;
	}
}
namespace RenderHeads.Media.AVProVideo
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class MediaPlayerEvent : UnityEvent<MediaPlayer, MediaPlayerEvent.BHFBPEFIMHM, HIICDHDBEHA>
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public enum BHFBPEFIMHM
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
		private List<UnityAction<MediaPlayer, BHFBPEFIMHM, HIICDHDBEHA>> _listeners;

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x2A14EA0", Offset = "0x2A134A0", VA = "0x182A14EA0")]
		public bool OGLGAEAGMGB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x2A14D10", Offset = "0x2A13310", VA = "0x182A14D10")]
		public void IBJFJBBCEIC(UnityAction<MediaPlayer, BHFBPEFIMHM, HIICDHDBEHA> IADPGIFLPOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x2A14E00", Offset = "0x2A13400", VA = "0x182A14E00")]
		public void OAJEMMGFPLJ(UnityAction<MediaPlayer, BHFBPEFIMHM, HIICDHDBEHA> IADPGIFLPOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x2A14F00", Offset = "0x2A13500", VA = "0x182A14F00")]
		public MediaPlayerEvent()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class JGELOANAKGD
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static Matrix4x4 LJGIMDNMCLJ;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static Matrix4x4 BHNKLIDLDCD;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static Matrix4x4 HHMGHMEBJON;

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x2A2B790", Offset = "0x2A29D90", VA = "0x182A2B790")]
	public static string FHEINBDJLLI(OAAOAEKHHNH MEOIPJDHEIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x2A2BFA0", Offset = "0x2A2A5A0", VA = "0x182A2BFA0")]
	public static string PBKLIFCKIJO(string JKCPEHCGLIK, OAAOAEKHHNH MEOIPJDHEIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x2A2BD90", Offset = "0x2A2A390", VA = "0x182A2BD90")]
	public static string NGFFCJKLDKC(HIICDHDBEHA KBFPIDKMNOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x2A2BEC0", Offset = "0x2A2A4C0", VA = "0x182A2BEC0")]
	public static void OKOBKBGNGKB(string IFEHDCDCFPK, [Optional] UnityEngine.Object HHPFOCCGJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x2A2BD60", Offset = "0x2A2A360", VA = "0x182A2BD60")]
	public static int MNHFANFBLPC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x2A2BAA0", Offset = "0x2A2A0A0", VA = "0x182A2BAA0")]
	public static int ILKEJPEKNJO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x2A2B890", Offset = "0x2A29E90", VA = "0x182A2B890")]
	public static ILEPBEOHMBE ICLDCEFNAPI(float[] IHNLGGEEIFC)
	{
		return default(ILEPBEOHMBE);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x2A2BCE0", Offset = "0x2A2A2E0", VA = "0x182A2BCE0")]
	public static int LIIOOLEKFLP(double AEKHJIAHDFD, float AIEKFOBKHNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x2A2B6B0", Offset = "0x2A29CB0", VA = "0x182A2B6B0")]
	private static extern int AOAFOKGLFKC(string OAMJIGHEHHO, StringBuilder OAPDGJMFPBE, int AHKJDAIHMMG);

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x2A2BB30", Offset = "0x2A2A130", VA = "0x182A2BB30")]
	internal static string KLLFMABLEGJ(string JKCPEHCGLIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x2A2B310", Offset = "0x2A29910", VA = "0x182A2B310")]
	public static Texture2D AFHDEPOOLIB(Texture OODPMJIAGCM, bool FNLJNJLCFLC, ILEPBEOHMBE JMFCJAGDBGK, [Optional] Texture2D EAOABPCKLJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface CGOGFGECEJE
{
	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GMBGDNHKJIP();

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FLHPFKIPOFF();

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JEJGLKBFKJG();

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MHKKCKEAAKN();

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DJALLKHDNEM();
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface LGMFOKKNKLI
{
	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KCOMEFIMLCG(string DAJAOHIJHHL);

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int OBMHBPBAJKD();

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string PLHODOIELDE();
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface JEFJECMOAKC
{
	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool POJPJOMDDPI(string JKCPEHCGLIK, long EFCGAKGCCGN, string BKMDMCCIPGI, MediaHints CGBBLFBDJDD, int ALELCIDKPJD = 0, bool BGCEEPLOFEB = false);

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KPGIFLMONKK(byte[] COEFMBJKIKA);

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KEBGKOFIOLP(ulong FODNOPLPBPI);

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GONEBHNCGMI(byte[] MHJLEDKHHBE, ulong EFCGAKGCCGN, ulong FODNOPLPBPI);

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JOEJCHHOJON();

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GBPEDHFLCHD();

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MBKFCKLHLNI(bool KEEHLJNBNEO);

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool LGGCDCOGBMP();

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool LEIBNOPKOFP();

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool AJCHFCJENLP();

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool EHFAJNLFEII();

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool KNKMBDAKGNM();

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool HENGHMBIENC();

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool OMEGOIEKINN();

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool GDBDPDDJOAK();

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JFNOLEJOLGK();

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void PCEOJEMCNIE();

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MNEFMGBPPHF();

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void CADABNLNHKM();

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void DAFCDADJIEH(double FLCAFPMKFLE);

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void BHPIBAEEPCF(double FLCAFPMKFLE);

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(Slot = "21")]
	double AIIKFDHPEAF();

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(Slot = "22")]
	float ENBJODBDBIM();

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void MCFAOOMNGPD(float EMACLCMJPPD);

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void JDEJIGDCPJJ(bool HOIPKCKPKHJ);

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool CIKDANALLPE();

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void HFHMAGGLDBH(float FGHGJFNAJIH);

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void GINEFLLDDNH(float FHHCADNOHDD);

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "28")]
	float DGDPNIIHFAH();

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float EFHEOAAIAAA();

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(Slot = "30")]
	ANLEIFHOLEO OBHNINFHGJM();

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(Slot = "31")]
	HIICDHDBEHA BCMBMPACGEE();

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void HBOEKHICPLP(FilterMode ODAEJFIKMEL = FilterMode.Bilinear, TextureWrapMode JKICGHKHIMN = TextureWrapMode.Clamp, int KANKGDJGFOF = 1);

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void IKMPEFMMDLO([Out] FilterMode ODAEJFIKMEL, [Out] TextureWrapMode JKICGHKHIMN, [Out] int KANKGDJGFOF);

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(Slot = "34")]
	int JGINEHBAPJG(float[] COEFMBJKIKA, int HDOPDCPGECL, int FPNDCHNJFNF);

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(Slot = "35")]
	int CIHCFJPNCPN();

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void EJNGGCAMCEA(bool HLFMNDHEGGB);

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void GPLJNLACLBL(PKHJIOPINGD IAFKLPLOCCL);

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void JEHEJLAHMBI(Quaternion EKPPOBOIFCF);

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void GLLLBJEDKMG();

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void FKCJPEDLFGE(bool ANBCINBEIHB);

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void KKACMGIBLFD(float ANBIGHNEOOL, float IBLKNHIHNMH);

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void CKKMKONOHJE(Quaternion EKPPOBOIFCF);

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(Slot = "43")]
	bool BJNNFEHDFHK(Camera ONKIDIPKLEC, int MOADIOMDCBB);

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void PDPJPMEEKOO(string HNGIMMGBLII);

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(Slot = "45")]
	void LEDICGOIJNN(byte[] HFLDIIIPBCG);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface DBEBEMAOJDA
{
	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(Slot = "0")]
	double MFGNDFEKCPP();

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int GHDEINPKEBK();

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int MLCGAFDMLBF();

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float GFLOLEOKKEH();

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JFHEEGBIJAB();

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DPEFFCHACFE();

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool OALKFAOGLAH();

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float[] JADCKKIIFMA();
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface CNKFNPDBCCO
{
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface LOLDIHPFCMA
{
	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int GetTextureCount();

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Texture GetTexture(int LEPAEEGOBDO = 0);

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
	OICPENEHCJE GetTextureStereoPacking();

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(Slot = "8")]
	MEALJBMNFBD GetTextureTransparency();

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ALDPFJHPMEB GetTextureAlphaPacking();

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
	RenderTextureFormat GetCompatibleRenderTextureFormat(KEPCOKOKENL EEPOAHLOJPI = KEPCOKOKENL.Default, int HCAIIGECACJ = 0);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[Flags]
public enum KEPCOKOKENL
{
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	ForResolve = 1,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	RequiresAlpha = 2
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum BGCNMKKBMDO
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
public enum AKIEGCEBGBJ
{
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	Reference,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	Path
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public enum OAAOAEKHHNH
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
		private OAAOAEKHHNH _pathType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		[SerializeField]
		private string _path;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public OAAOAEKHHNH PathType
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
			get
			{
				return default(OAAOAEKHHNH);
			}
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public string Path
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x2A34AD0", Offset = "0x2A330D0", VA = "0x182A34AD0")]
		public MediaPath()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x2A34A40", Offset = "0x2A33040", VA = "0x182A34A40")]
		public MediaPath(MediaPath ACPNDPFPCDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x2A349B0", Offset = "0x2A32FB0", VA = "0x182A349B0")]
		public MediaPath(string JKCPEHCGLIK, OAAOAEKHHNH EOHHONHGKPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x2A34390", Offset = "0x2A32990", VA = "0x182A34390")]
		public string CHACHOHKAJG()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x2A34890", Offset = "0x2A32E90", VA = "0x182A34890")]
		public static MediaPath HPNBGLLBBBG(string BOKKEFJOAFD)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x2A34950", Offset = "0x2A32F50", VA = "0x182A34950")]
		public static bool LMIMJGGKHMP(MediaPath IAFDMJDNHDH, MediaPath DFKKOPOBCBA)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x2A34970", Offset = "0x2A32F70", VA = "0x182A34970")]
		public static bool PACMOMIAEBP(MediaPath IAFDMJDNHDH, MediaPath DFKKOPOBCBA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x2A34740", Offset = "0x2A32D40", VA = "0x182A34740", Slot = "0")]
		public override bool Equals(object NDBJJGOPOFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x2A34840", Offset = "0x2A32E40", VA = "0x182A34840", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public enum OICPENEHCJE
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
		public MEALJBMNFBD transparency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public ALDPFJHPMEB alphaPacking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public OICPENEHCJE stereoPacking;

		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private static MediaHints defaultHints;

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public static MediaHints Default
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x2A34340", Offset = "0x2A32940", VA = "0x182A34340")]
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
		public enum HALAIPANKIH
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
		public HALAIPANKIH aspectRatio;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x2A37BE0", Offset = "0x2A361E0", VA = "0x182A37BE0")]
		public bool OOONAGNLCBP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x2A37BB0", Offset = "0x2A361B0", VA = "0x182A37BB0")]
		internal void HCLIHJHLBEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x2A37B40", Offset = "0x2A36140", VA = "0x182A37B40")]
		public static VideoResolveOptions EEPJBIPIECL()
		{
			return default(VideoResolveOptions);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public enum MEALJBMNFBD
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	Opaque,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	Transparent
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public enum BOABNNLGPJF
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	Both,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	Left,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	Right
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public enum ALDPFJHPMEB
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	TopBottom,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	LeftRight
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public enum HIICDHDBEHA
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	LoadFailed = 100,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	DecodeFailed = 200
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public enum ILEPBEOHMBE
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
public enum NOPENGNBHNN
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
public enum HNDKMJFIAHI
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
public static class KAGEMDBCDLK
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public enum DMODLHHKIDF
	{
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		MediaFoundation,
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		DirectShow,
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		WinRT
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public enum NHCFHDABMDF
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
public static class ONMPELHFCBA
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public enum DLJGFGPPPFI
	{
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		MediaFoundation,
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		WinRT
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public enum NHIJJGJBGFJ
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
public static class OBIJGGNAFIF
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public enum JPEAPPPMBCN
	{
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		MediaPlayer = 1,
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		ExoPlayer
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class AMAMFGINNPN
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public enum IIAOHKALPIG
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
public enum PKHJIOPINGD
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
public struct HGHNPOACEMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public double AJOEJHMGHBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public double ECPJMMFGCIP;
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[DefaultMember("Item")]
public class ANLEIFHOLEO : IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	internal HGHNPOACEMA[] IADEMFOBJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	internal double DLGMLENFHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	internal double FLFCHDDMLEI;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public int DGBEIHMBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x292D5F0", Offset = "0x292BBF0", VA = "0x18292D5F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public double CJFFIEHDEMO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x2A21700", Offset = "0x2A1FD00", VA = "0x182A21700")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public double BDOHDDFGAKC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x2A216E0", Offset = "0x2A1FCE0", VA = "0x182A216E0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public double GDCIOCLCKKG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x2A216F0", Offset = "0x2A1FCF0", VA = "0x182A216F0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x2A21970", Offset = "0x2A1FF70", VA = "0x182A21970")]
	internal ANLEIFHOLEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x2A21710", Offset = "0x2A1FD10", VA = "0x182A21710", Slot = "4")]
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x2A21730", Offset = "0x2A1FD30", VA = "0x182A21730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x2A21590", Offset = "0x2A1FB90", VA = "0x182A21590")]
	internal void BCIEGPFNAJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class FCFMJFKHOII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private int NJINNJFFMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private long OKMFJLGHLNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private FNFNDCAKGLJ LGIICADEDHH;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public int GOPNHAPADBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public int LLMDFMCKEBN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xAEAAE0", Offset = "0xAE90E0", VA = "0x180AEAAE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0xB91EF0", Offset = "0xB904F0", VA = "0x180B91EF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public int ABDOFGHKMJG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xA9D650", Offset = "0xA9BC50", VA = "0x180A9D650")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xAA1220", Offset = "0xA9F820", VA = "0x180AA1220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private float LMEPEAMCLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xEBD6A0", Offset = "0xEBBCA0", VA = "0x180EBD6A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private string HMIDGKFJNJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private int CAMDHNHNNLB
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA90", Offset = "0xA9E090", VA = "0x180A9FA90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA30", Offset = "0xA9E030", VA = "0x180A9FA30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private int KLDLLPOPAPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xAE5560", Offset = "0xAE3B60", VA = "0x180AE5560")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x1696150", Offset = "0x1694750", VA = "0x181696150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool AGGBMFBAANN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0xAC3630", Offset = "0xAC1C30", VA = "0x180AC3630")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x2A24F10", Offset = "0x2A23510", VA = "0x182A24F10")]
	public void IMGLACMMFNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x2A24F60", Offset = "0x2A23560", VA = "0x182A24F60")]
	internal void JKGHENBEODP(FNFNDCAKGLJ LIOICDJHFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x2A24590", Offset = "0x2A22B90", VA = "0x182A24590")]
	internal void FLHPFKIPOFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0")]
	private static bool CFIMMDCMMHF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public FCFMJFKHOII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public sealed class BFKAHJPNAMO : FNFNDCAKGLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private bool IFMMLODLELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private bool NMCMCLAELLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private double AKEHPMKGPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private float JAHHFJGMGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private float CJHEPGLKOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	private bool GJLGDLPFBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private int JHOAAIMMGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private int ODKAGNEAOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	private Texture2D CLBCKCBCLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	private Texture2D EKEDAPAEOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	private Texture2D INKEFEOBFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	private float BIEOGEHJHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	private int DHBELJFMFBA;

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x2A219E0", Offset = "0x2A1FFE0", VA = "0x182A219E0", Slot = "82")]
	public override string AJEICOJDHIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x2A21A20", Offset = "0x2A20020", VA = "0x182A21A20", Slot = "83")]
	public override string BOAKMJDFIFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x2A21CA0", Offset = "0x2A202A0", VA = "0x182A21CA0", Slot = "84")]
	public override bool POJPJOMDDPI(string JKCPEHCGLIK, long EFCGAKGCCGN, string HEEJDIGBDBK, MediaHints PGHDGGOCHNA, int ALELCIDKPJD = 0, bool BGCEEPLOFEB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x2A21BC0", Offset = "0x2A201C0", VA = "0x182A21BC0", Slot = "89")]
	public override void GBPEDHFLCHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0xD517C0", Offset = "0xD4FDC0", VA = "0x180D517C0", Slot = "90")]
	public override void MBKFCKLHLNI(bool KEEHLJNBNEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x10B7D80", Offset = "0x10B6380", VA = "0x1810B7D80", Slot = "91")]
	public override bool LGGCDCOGBMP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0", Slot = "92")]
	public override bool LEIBNOPKOFP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0", Slot = "93")]
	public override bool AJCHFCJENLP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "107")]
	public override bool CLIHPMHNFND()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "108")]
	public override bool JFHEEGBIJAB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x2A21C00", Offset = "0x2A20200", VA = "0x182A21C00", Slot = "94")]
	public override void JFNOLEJOLGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x2A21C90", Offset = "0x2A20290", VA = "0x182A21C90", Slot = "95")]
	public override void PCEOJEMCNIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x2A21C30", Offset = "0x2A20230", VA = "0x182A21C30", Slot = "96")]
	public override void MNEFMGBPPHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "109")]
	public override bool KNKMBDAKGNM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0xB65DE0", Offset = "0xB643E0", VA = "0x180B65DE0", Slot = "110")]
	public override bool EHFAJNLFEII()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0xB66050", Offset = "0xB64650", VA = "0x180B66050", Slot = "111")]
	public override bool HENGHMBIENC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x2A21C40", Offset = "0x2A20240", VA = "0x182A21C40", Slot = "112")]
	public override bool OMEGOIEKINN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "113")]
	public override bool GDBDPDDJOAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x2A21C20", Offset = "0x2A20220", VA = "0x182A21C20", Slot = "103")]
	public override double MFGNDFEKCPP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x10B9680", Offset = "0x10B7C80", VA = "0x1810B9680", Slot = "104")]
	public override int GHDEINPKEBK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0xFD6BE0", Offset = "0xFD51E0", VA = "0x180FD6BE0", Slot = "105")]
	public override int MLCGAFDMLBF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0xB24A30", Offset = "0xB23030", VA = "0x180B24A30", Slot = "116")]
	public override Texture GetTexture(int LEPAEEGOBDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x17608F0", Offset = "0x175EEF0", VA = "0x1817608F0", Slot = "117")]
	public override int GetTextureFrameCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0xF12F90", Offset = "0xF11590", VA = "0x180F12F90", Slot = "127")]
	internal override OICPENEHCJE KAGKELHMDLG()
	{
		return default(OICPENEHCJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "120")]
	public override bool RequiresVerticalFlip()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x2A21A10", Offset = "0x2A20010", VA = "0x182A21A10", Slot = "98")]
	public override void DAFCDADJIEH(double FLCAFPMKFLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x2A21A10", Offset = "0x2A20010", VA = "0x182A21A10", Slot = "99")]
	public override void BHPIBAEEPCF(double FLCAFPMKFLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x2A219D0", Offset = "0x2A1FFD0", VA = "0x182A219D0", Slot = "100")]
	public override double AIIKFDHPEAF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x169A9B0", Offset = "0x1698FB0", VA = "0x18169A9B0", Slot = "102")]
	public override void MCFAOOMNGPD(float EMACLCMJPPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x169A950", Offset = "0x1698F50", VA = "0x18169A950", Slot = "101")]
	public override float ENBJODBDBIM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "129")]
	public override void JDEJIGDCPJJ(bool EJBGKFHMCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0", Slot = "130")]
	public override bool CIKDANALLPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x1CAEB10", Offset = "0x1CAD110", VA = "0x181CAEB10", Slot = "131")]
	public override void HFHMAGGLDBH(float FGHGJFNAJIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x1CAFDA0", Offset = "0x1CAE3A0", VA = "0x181CAFDA0", Slot = "133")]
	public override float DGDPNIIHFAH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0xAE6850", Offset = "0xAE4E50", VA = "0x180AE6850", Slot = "106")]
	public override float GFLOLEOKKEH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x2A21A40", Offset = "0x2A20040", VA = "0x182A21A40", Slot = "146")]
	public override void FLHPFKIPOFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "148")]
	public override void DJALLKHDNEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "149")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "161")]
	internal override bool IAINHDHNKPM(EGPMBGNKJOC MLFHHDFGEFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "162")]
	internal override int HOPDMACDOCN(EGPMBGNKJOC MLFHHDFGEFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "163")]
	internal override KNLMCFLAKBL CFLKBCDOFAA(EGPMBGNKJOC MLFHHDFGEFM, int LEPAEEGOBDO, bool HGFCKBPDCCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "159")]
	internal override bool BLJHIPGBGEP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "160")]
	internal override string MKJODHNJEKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x2A21E90", Offset = "0x2A20490", VA = "0x182A21E90")]
	public BFKAHJPNAMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class EBIEKKAMDOF
{
	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public string MKLKGBBNBPF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public string CBGNCAEJLOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public byte[] EGLIGPMAOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x2A220E0", Offset = "0x2A206E0", VA = "0x182A220E0")]
	public EBIEKKAMDOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x2A22060", Offset = "0x2A20660", VA = "0x182A22060")]
	public void OOIGDCNPPFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class MDIGNEHFCFA : FNFNDCAKGLJ
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	private struct FFHJKBNHMPC
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		internal enum JNMHLNJGNJD
		{
			[Cpp2IlInjected.Token(Token = "0x40002D3")]
			Seekable,
			[Cpp2IlInjected.Token(Token = "0x40002D4")]
			Buffered
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public enum HJMNOAOLINB
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
		public struct KAGLIMIKFEJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002DA")]
			public string KDMMFJGANAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002DB")]
			public string HNGIMMGBLII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002DC")]
			public IntPtr HLPOPEOCDLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			public int BLCHFHLAMDJ;
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x2A25B70", Offset = "0x2A24170", VA = "0x182A25B70")]
		public static extern bool DFFNENGMLIH(IntPtr PLKOLLOCKHK, EGPMBGNKJOC MLFHHDFGEFM);

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x2A26E00", Offset = "0x2A25400", VA = "0x182A26E00")]
		public static extern int JLMMEGEOOLD(IntPtr PLKOLLOCKHK, EGPMBGNKJOC MLFHHDFGEFM);

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x2A26740", Offset = "0x2A24D40", VA = "0x182A26740")]
		public static extern bool IENFJFHBDAJ(IntPtr PLKOLLOCKHK, EGPMBGNKJOC MLFHHDFGEFM, int LEPAEEGOBDO, int IIJDDLOGCCA, bool OFAKGAKKFIK, StringBuilder DJFMCHMDHGK, int FCDKEBNDGLC, StringBuilder IONHIMIACFO, int MDKILEHDPFP);

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x2A27FC0", Offset = "0x2A265C0", VA = "0x182A27FC0")]
		public static extern bool PHPFDBMLNOL(IntPtr PLKOLLOCKHK);

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x2A27250", Offset = "0x2A25850", VA = "0x182A27250")]
		public static extern IntPtr LGDBGKNJILA(IntPtr PLKOLLOCKHK);

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x2A27E90", Offset = "0x2A26490", VA = "0x182A27E90")]
		public static extern int PDNDOLCMKIL(IntPtr GKLDOAAOMEI, [Out] HGHNPOACEMA[] CNBOJLFBFDP, int DJAACGNFHLC, JNMHLNJGNJD IDKPALJFCGO);

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x2A28040", Offset = "0x2A26640", VA = "0x182A28040")]
		public static extern bool PNHKIAJGEDI(bool CFCFNDPHFHM);

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x2A25C00", Offset = "0x2A24200", VA = "0x182A25C00")]
		public static extern void DLIHAMJBKBP();

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x2A25680", Offset = "0x2A23C80", VA = "0x182A25680")]
		public static extern IntPtr BAHAONCCFFJ();

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x2A26E90", Offset = "0x2A25490", VA = "0x182A26E90")]
		public static extern IntPtr KBBAKCKOIJE(IntPtr PLKOLLOCKHK, KAGEMDBCDLK.DMODLHHKIDF OKCDPNGBNDA, KAGEMDBCDLK.NHCFHDABMDF CNDIBIEDAHA, bool BGKGCGONCDB, bool DKIFPOAPNKJ, bool OCMGOJECGPE, bool OGNPKNKLJKO, bool BEFJIDCODIC, bool NOGBCAPOEDF, string FNAOALJFOEM, int DJDAEHIPLGI, IntPtr[] ELKDNEEGBAP, uint GACLIMDLHOA, int ONKGEDBDBEI, string HEEJDIGBDBK, bool BGCEEPLOFEB);

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x2A27CF0", Offset = "0x2A262F0", VA = "0x182A27CF0")]
		public static extern IntPtr OLKNLFIOHJP(IntPtr PLKOLLOCKHK, string JKCPEHCGLIK);

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x2A26220", Offset = "0x2A24820", VA = "0x182A26220")]
		public static extern IntPtr GJMAMOOLMLI(IntPtr PLKOLLOCKHK, byte[] COEFMBJKIKA, ulong LANOADAKJOG, KAGEMDBCDLK.DMODLHHKIDF OKCDPNGBNDA, KAGEMDBCDLK.NHCFHDABMDF CNDIBIEDAHA, bool BGKGCGONCDB, bool DKIFPOAPNKJ, bool OCMGOJECGPE, bool OGNPKNKLJKO, bool BEFJIDCODIC, bool NOGBCAPOEDF, string FNAOALJFOEM, int DJDAEHIPLGI, IntPtr[] ELKDNEEGBAP, uint GACLIMDLHOA);

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x2A25EE0", Offset = "0x2A244E0", VA = "0x182A25EE0")]
		public static extern IntPtr FJPMMCPCKDF(IntPtr PLKOLLOCKHK, KAGEMDBCDLK.DMODLHHKIDF OKCDPNGBNDA, ulong LANOADAKJOG);

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x2A27580", Offset = "0x2A25B80", VA = "0x182A27580")]
		public static extern bool NBLCEBEHBAL(IntPtr PLKOLLOCKHK, byte[] COEFMBJKIKA, ulong EFCGAKGCCGN, ulong OPNCINILDAG);

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x2A27740", Offset = "0x2A25D40", VA = "0x182A27740")]
		public static extern IntPtr ODHKKBCAGLP(IntPtr PLKOLLOCKHK, KAGEMDBCDLK.NHCFHDABMDF CNDIBIEDAHA, bool BGKGCGONCDB, bool DKIFPOAPNKJ, bool OCMGOJECGPE, bool OGNPKNKLJKO, bool BEFJIDCODIC, bool NOGBCAPOEDF, string FNAOALJFOEM, int DJDAEHIPLGI, IntPtr[] ELKDNEEGBAP, uint GACLIMDLHOA);

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x2A26630", Offset = "0x2A24C30", VA = "0x182A26630")]
		public static extern void HJANPECPBCJ(IntPtr PLKOLLOCKHK);

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x2A25310", Offset = "0x2A23910", VA = "0x182A25310")]
		public static extern IntPtr AALDGAKEEPN(IntPtr PLKOLLOCKHK);

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x2A25A60", Offset = "0x2A24060", VA = "0x182A25A60")]
		public static extern void CLEJFKAALEE(IntPtr PLKOLLOCKHK, bool ANBCINBEIHB);

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x2A274F0", Offset = "0x2A25AF0", VA = "0x182A274F0")]
		public static extern void MHBNIPKAPMC(IntPtr PLKOLLOCKHK, bool ANBCINBEIHB);

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x2A266B0", Offset = "0x2A24CB0", VA = "0x182A266B0")]
		public static extern void HPGJIJJAMDP(IntPtr PLKOLLOCKHK, bool ANBCINBEIHB);

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x2A26D70", Offset = "0x2A25370", VA = "0x182A26D70")]
		public static extern void JLCMBDAJJID(IntPtr PLKOLLOCKHK, bool ANBCINBEIHB);

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x2A25490", Offset = "0x2A23A90", VA = "0x182A25490")]
		public static extern void AKEKEBAPGGL(IntPtr PLKOLLOCKHK, bool ANBCINBEIHB, bool IGMDOHJHMEO, double LLMILILJNFF);

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x2A25890", Offset = "0x2A23E90", VA = "0x182A25890")]
		public static extern void CBCOGKJAEEK(IntPtr PLKOLLOCKHK, bool ANBCINBEIHB);

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x2A255E0", Offset = "0x2A23BE0", VA = "0x182A255E0")]
		public static extern void AMLHKPOHGAK(IntPtr PLKOLLOCKHK, int NCFCLGKMGAO, int AKBCONKCIDP);

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x2A26CF0", Offset = "0x2A252F0", VA = "0x182A26CF0")]
		public static extern int JKNCJMDPAIE(IntPtr PLKOLLOCKHK);

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x2A26B20", Offset = "0x2A25120", VA = "0x182A26B20")]
		public static extern void JFNOLEJOLGK(IntPtr PLKOLLOCKHK);

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x2A27E10", Offset = "0x2A26410", VA = "0x182A27E10")]
		public static extern void PCEOJEMCNIE(IntPtr PLKOLLOCKHK);

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x2A26BA0", Offset = "0x2A251A0", VA = "0x182A26BA0")]
		public static extern void JGBAFGBHDNG(IntPtr PLKOLLOCKHK, bool JFCKMGLJGDD);

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x2A26520", Offset = "0x2A24B20", VA = "0x182A26520")]
		public static extern void HFHMAGGLDBH(IntPtr PLKOLLOCKHK, float FGHGJFNAJIH);

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x2A26190", Offset = "0x2A24790", VA = "0x182A26190")]
		public static extern void GINEFLLDDNH(IntPtr PLKOLLOCKHK, float FGHGJFNAJIH);

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x2A27350", Offset = "0x2A25950", VA = "0x182A27350")]
		public static extern void MBKFCKLHLNI(IntPtr PLKOLLOCKHK, bool EHDGMIFDJFF);

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x2A26AA0", Offset = "0x2A250A0", VA = "0x182A26AA0")]
		public static extern bool JFHEEGBIJAB(IntPtr PLKOLLOCKHK);

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x2A25AF0", Offset = "0x2A240F0", VA = "0x182A25AF0")]
		public static extern bool CLIHPMHNFND(IntPtr PLKOLLOCKHK);

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x2A269A0", Offset = "0x2A24FA0", VA = "0x182A269A0")]
		public static extern int IPIDLOGBLCD(IntPtr PLKOLLOCKHK);

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x2A25C70", Offset = "0x2A24270", VA = "0x182A25C70")]
		public static extern int DPHLJHGNHCF(IntPtr PLKOLLOCKHK);

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x2A25770", Offset = "0x2A23D70", VA = "0x182A25770")]
		public static extern float BMNAJHMCGFB(IntPtr PLKOLLOCKHK);

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x2A26920", Offset = "0x2A24F20", VA = "0x182A26920")]
		public static extern OICPENEHCJE IOPKJPEEDHO(IntPtr PLKOLLOCKHK);

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x2A27470", Offset = "0x2A25A70", VA = "0x182A27470")]
		public static extern double MFGNDFEKCPP(IntPtr PLKOLLOCKHK);

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x2A276C0", Offset = "0x2A25CC0", VA = "0x182A276C0")]
		public static extern bool OALKFAOGLAH(IntPtr PLKOLLOCKHK);

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x2A271D0", Offset = "0x2A257D0", VA = "0x182A271D0")]
		public static extern bool LEIBNOPKOFP(IntPtr PLKOLLOCKHK);

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x2A25410", Offset = "0x2A23A10", VA = "0x182A25410")]
		public static extern bool AJCHFCJENLP(IntPtr PLKOLLOCKHK);

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x2A27150", Offset = "0x2A25750", VA = "0x182A27150")]
		public static extern bool KNKMBDAKGNM(IntPtr PLKOLLOCKHK);

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x2A25CF0", Offset = "0x2A242F0", VA = "0x182A25CF0")]
		public static extern bool EHFAJNLFEII(IntPtr PLKOLLOCKHK);

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x2A27D90", Offset = "0x2A26390", VA = "0x182A27D90")]
		public static extern bool OMEGOIEKINN(IntPtr PLKOLLOCKHK);

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x2A26090", Offset = "0x2A24690", VA = "0x182A26090")]
		public static extern bool GDBDPDDJOAK(IntPtr PLKOLLOCKHK);

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x2A25390", Offset = "0x2A23990", VA = "0x182A25390")]
		public static extern double AIIKFDHPEAF(IntPtr PLKOLLOCKHK);

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x2A25540", Offset = "0x2A23B40", VA = "0x182A25540")]
		public static extern void AKNIHEOOMAC(IntPtr PLKOLLOCKHK, double FLCAFPMKFLE, bool EGFLMCCNLHH);

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x2A25D70", Offset = "0x2A24370", VA = "0x182A25D70")]
		public static extern float ENBJODBDBIM(IntPtr PLKOLLOCKHK);

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x2A273E0", Offset = "0x2A259E0", VA = "0x182A273E0")]
		public static extern void MCFAOOMNGPD(IntPtr PLKOLLOCKHK, float EMACLCMJPPD);

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x2A26110", Offset = "0x2A24710", VA = "0x182A26110")]
		public static extern void GFDELIBICKM(IntPtr PLKOLLOCKHK);

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x2A272D0", Offset = "0x2A258D0", VA = "0x182A272D0")]
		public static extern void LGPBJBHAHIC(IntPtr PLKOLLOCKHK);

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x2A26010", Offset = "0x2A24610", VA = "0x182A26010")]
		public static extern void FLHPFKIPOFF(IntPtr PLKOLLOCKHK);

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x2A26A20", Offset = "0x2A25020", VA = "0x182A26A20")]
		public static extern void JEJGLKBFKJG(IntPtr PLKOLLOCKHK);

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x2A265B0", Offset = "0x2A24BB0", VA = "0x182A265B0")]
		public static extern IntPtr HGCHMGHNALL(IntPtr PLKOLLOCKHK);

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x2A27640", Offset = "0x2A25C40", VA = "0x182A27640")]
		public static extern int NLPFFIGMCNP(IntPtr PLKOLLOCKHK);

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x2A25DF0", Offset = "0x2A243F0", VA = "0x182A25DF0")]
		public static extern bool FACCAJJJABP(IntPtr PLKOLLOCKHK);

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x2A27050", Offset = "0x2A25650", VA = "0x182A27050")]
		public static extern bool KCCEHHFBEKM(IntPtr PLKOLLOCKHK);

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x2A268A0", Offset = "0x2A24EA0", VA = "0x182A268A0")]
		public static extern int ILNJDJHAGKJ(IntPtr PLKOLLOCKHK);

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x2A270D0", Offset = "0x2A256D0", VA = "0x182A270D0")]
		public static extern long KGCFDEKPBHH(IntPtr PLKOLLOCKHK);

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x2A256F0", Offset = "0x2A23CF0", VA = "0x182A256F0")]
		public static extern float BCGDGAHBKFL(IntPtr PLKOLLOCKHK);

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x2A25E70", Offset = "0x2A24470", VA = "0x182A25E70")]
		public static extern IntPtr FBNPAGDKNBJ();

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x2A26C30", Offset = "0x2A25230", VA = "0x182A26C30")]
		public static extern int JGINEHBAPJG(IntPtr PLKOLLOCKHK, float[] COEFMBJKIKA, int HDOPDCPGECL, int FPNDCHNJFNF);

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x2A25920", Offset = "0x2A23F20", VA = "0x182A25920")]
		public static extern int CIHCFJPNCPN(IntPtr PLKOLLOCKHK);

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x2A26490", Offset = "0x2A24A90", VA = "0x182A26490")]
		public static extern int GPLJNLACLBL(IntPtr PLKOLLOCKHK, int ONKGEDBDBEI);

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x2A263D0", Offset = "0x2A249D0", VA = "0x182A263D0")]
		public static extern void GNCPAOIKNPN(IntPtr PLKOLLOCKHK, float POMPNNDHCKO, float JLAHKMCOIFF, float GFIJDJGEMLL, float EDHBJBGECMO);

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x2A25F80", Offset = "0x2A24580", VA = "0x182A25F80")]
		public static extern void FKCJPEDLFGE(IntPtr PLKOLLOCKHK, bool ANBCINBEIHB);

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x2A257F0", Offset = "0x2A23DF0", VA = "0x182A257F0")]
		public static extern void CANDHKCFIOF(IntPtr PLKOLLOCKHK, float ANBIGHNEOOL, float IBLKNHIHNMH);

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x2A259A0", Offset = "0x2A23FA0", VA = "0x182A259A0")]
		public static extern void CKKMKONOHJE(IntPtr PLKOLLOCKHK, float POMPNNDHCKO, float JLAHKMCOIFF, float GFIJDJGEMLL, float EDHBJBGECMO);

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x2A278C0", Offset = "0x2A25EC0", VA = "0x182A278C0")]
		public static void OEBBGGBNGMN(IntPtr PLKOLLOCKHK, EBIEKKAMDOF MCDBJKIGJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x2A27B90", Offset = "0x2A26190", VA = "0x182A27B90")]
		private static extern void OEBBGGBNGMN(IntPtr PLKOLLOCKHK, KAGLIMIKFEJ GNPBKJCIJPK);
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	private KAGEMDBCDLK.NHCFHDABMDF OJHDDJNENIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	private string BFPDEJGIFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	private List<string> OBMCNBIHKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	private PKHJIOPINGD GGBMBCKENJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	private bool PCFPPPAMOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC5")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	private bool KNBMNCFOOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC6")]
	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	private bool MHJKDHCPFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC7")]
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	private bool ACLIABIGPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	private bool FLJEMBHBDKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	private bool BOMMNMAJGDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	private int JCMKOHJGLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	private int HHDEGFFLBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	private bool IFMMLODLELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD5")]
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	private bool NMCMCLAELLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD6")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	private bool NPFAJHJEHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private float JAHHFJGMGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private float GOHCPJJLOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private bool AANHPNOLPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private bool MDLODHAICFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE2")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private bool ILACMHOLEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private int HPJMDLHNAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private int ODKAGNEAOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private float DNLIJMNGHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private bool PBCHPGOIANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF1")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	private bool KDAFKIPHOCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF2")]
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	private bool NPPNPLMCHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	private IntPtr KGHENDCMACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	private Texture2D CLBCKCBCLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	private RenderTexture KAHDDDLNMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	private IntPtr MDCEPNGNCGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private KAGEMDBCDLK.DMODLHHKIDF KBELFKALNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private bool GAJONJKOBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11D")]
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private bool OMKIMDBABIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11E")]
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	private bool NKLPGALJPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11F")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	private bool GMOAMLCNOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	private bool NIKLCFGHEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x121")]
	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	private bool OBDOJOFAKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x122")]
	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	private bool GPILFAFGADA;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	private static bool IFDBEPECFLF;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	private static string KEBBCDIELGA;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	private static IntPtr EANEBBHIIMO;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	private static int CMMLCOKPDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	private EBIEKKAMDOF OIHKEHEIAHA;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public EBIEKKAMDOF JNDLBOEOPMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x2A318E0", Offset = "0x2A2FEE0", VA = "0x182A318E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x2A2FF00", Offset = "0x2A2E500", VA = "0x182A2FF00")]
	public static bool CKMKKCJKAGH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x2A30450", Offset = "0x2A2EA50", VA = "0x182A30450")]
	public static void EKCJEHPEFMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x2A2FDD0", Offset = "0x2A2E3D0", VA = "0x182A2FDD0", Slot = "135")]
	public override int CIHCFJPNCPN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x2A34100", Offset = "0x2A32700", VA = "0x182A34100")]
	public MDIGNEHFCFA(MediaPlayer.OptionsWindows EEPOAHLOJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x2A2F6C0", Offset = "0x2A2DCC0", VA = "0x182A2F6C0")]
	public void BEIJOMNLNDB(MediaPlayer.OptionsWindows EEPOAHLOJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x2A2F480", Offset = "0x2A2DA80", VA = "0x182A2F480")]
	public void BEIJOMNLNDB(KAGEMDBCDLK.DMODLHHKIDF OKCDPNGBNDA, KAGEMDBCDLK.NHCFHDABMDF CNDIBIEDAHA, bool BGKGCGONCDB, bool DKIFPOAPNKJ, bool MMGPJKBMOFA, bool NOGBCAPOEDF, bool OGNPKNKLJKO, bool BEFJIDCODIC, string MBGLJLJMLBI, List<string> MJGBFNCGFBK, bool NGEFJKIMOIG, int NCFCLGKMGAO, int AKBCONKCIDP, bool LNCGKEPJAPC, bool EBBIGJLEEGI, bool PHLLLOBLHGJ, bool CCLOIDBMIMJ, bool NOFLKLKCNKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x2A2F380", Offset = "0x2A2D980", VA = "0x182A2F380", Slot = "82")]
	public override string AJEICOJDHIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x2A2F9F0", Offset = "0x2A2DFF0", VA = "0x182A2F9F0", Slot = "83")]
	public override string BOAKMJDFIFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x2A318D0", Offset = "0x2A2FED0", VA = "0x182A318D0")]
	private bool HGAKGNFDEEP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x2A336B0", Offset = "0x2A31CB0", VA = "0x182A336B0", Slot = "84")]
	public override bool POJPJOMDDPI(string JKCPEHCGLIK, long EFCGAKGCCGN, string HEEJDIGBDBK, MediaHints PGHDGGOCHNA, int ALELCIDKPJD = 0, bool BGCEEPLOFEB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x2A32530", Offset = "0x2A30B30", VA = "0x182A32530", Slot = "85")]
	public override bool KPGIFLMONKK(byte[] COEFMBJKIKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x2A32300", Offset = "0x2A30900", VA = "0x182A32300", Slot = "86")]
	public override bool KEBGKOFIOLP(ulong FODNOPLPBPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x2A31540", Offset = "0x2A2FB40", VA = "0x182A31540", Slot = "87")]
	public override bool GONEBHNCGMI(byte[] MHJLEDKHHBE, ulong EFCGAKGCCGN, ulong FODNOPLPBPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x2A31EA0", Offset = "0x2A304A0", VA = "0x182A31EA0", Slot = "88")]
	public override bool JOEJCHHOJON()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x2A31A60", Offset = "0x2A30060", VA = "0x182A31A60")]
	private void IBHLBMJIMII(string JKCPEHCGLIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x2A31070", Offset = "0x2A2F670", VA = "0x182A31070", Slot = "89")]
	public override void GBPEDHFLCHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x2A32A20", Offset = "0x2A31020", VA = "0x182A32A20", Slot = "90")]
	public override void MBKFCKLHLNI(bool EHDGMIFDJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0xB66250", Offset = "0xB64850", VA = "0x180B66250", Slot = "91")]
	public override bool LGGCDCOGBMP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0xB65E10", Offset = "0xB64410", VA = "0x180B65E10", Slot = "92")]
	public override bool LEIBNOPKOFP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x1723EC0", Offset = "0x17224C0", VA = "0x181723EC0", Slot = "107")]
	public override bool CLIHPMHNFND()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x262F620", Offset = "0x262DC20", VA = "0x18262F620", Slot = "108")]
	public override bool JFHEEGBIJAB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0xB65E20", Offset = "0xB64420", VA = "0x180B65E20", Slot = "93")]
	public override bool AJCHFCJENLP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x2A31D50", Offset = "0x2A30350", VA = "0x182A31D50", Slot = "94")]
	public override void JFNOLEJOLGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x2A335C0", Offset = "0x2A31BC0", VA = "0x182A335C0", Slot = "95")]
	public override void PCEOJEMCNIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x2A2EB40", Offset = "0x2A2D140", VA = "0x182A2EB40", Slot = "96")]
	public override void MNEFMGBPPHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x2A324A0", Offset = "0x2A30AA0", VA = "0x182A324A0", Slot = "109")]
	public override bool KNKMBDAKGNM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x2A30440", Offset = "0x2A2EA40", VA = "0x182A30440", Slot = "110")]
	public override bool EHFAJNLFEII()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x2A31870", Offset = "0x2A2FE70", VA = "0x182A31870", Slot = "111")]
	public override bool HENGHMBIENC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x2A33510", Offset = "0x2A31B10", VA = "0x182A33510", Slot = "112")]
	public override bool OMEGOIEKINN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x2A31230", Offset = "0x2A2F830", VA = "0x182A31230", Slot = "113")]
	public override bool GDBDPDDJOAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x2A32AD0", Offset = "0x2A310D0", VA = "0x182A32AD0", Slot = "103")]
	public override double MFGNDFEKCPP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x1F106E0", Offset = "0x1F0ECE0", VA = "0x181F106E0", Slot = "104")]
	public override int GHDEINPKEBK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0xB38A40", Offset = "0xB37040", VA = "0x180B38A40", Slot = "105")]
	public override int MLCGAFDMLBF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x224D9B0", Offset = "0x224BFB0", VA = "0x18224D9B0", Slot = "106")]
	public override float GFLOLEOKKEH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x2A317D0", Offset = "0x2A2FDD0", VA = "0x182A317D0", Slot = "116")]
	public override Texture GetTexture(int LEPAEEGOBDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x2A31690", Offset = "0x2A2FC90", VA = "0x182A31690", Slot = "117")]
	public override int GetTextureFrameCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x2A31750", Offset = "0x2A2FD50", VA = "0x182A31750", Slot = "119")]
	public override long GetTextureTimeStamp()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x2A316A0", Offset = "0x2A2FCA0", VA = "0x182A316A0", Slot = "121")]
	public override float GetTexturePixelAspectRatio()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x26AD820", Offset = "0x26ABE20", VA = "0x1826AD820", Slot = "120")]
	public override bool RequiresVerticalFlip()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x2A32280", Offset = "0x2A30880", VA = "0x182A32280", Slot = "127")]
	internal override OICPENEHCJE KAGKELHMDLG()
	{
		return default(OICPENEHCJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x2A30320", Offset = "0x2A2E920", VA = "0x182A30320", Slot = "98")]
	public override void DAFCDADJIEH(double FLCAFPMKFLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x2A2F770", Offset = "0x2A2DD70", VA = "0x182A2F770", Slot = "99")]
	public override void BHPIBAEEPCF(double FLCAFPMKFLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x2A2F300", Offset = "0x2A2D900", VA = "0x182A2F300", Slot = "100")]
	public override double AIIKFDHPEAF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x2A32A40", Offset = "0x2A31040", VA = "0x182A32A40", Slot = "102")]
	public override void MCFAOOMNGPD(float EMACLCMJPPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x2A30500", Offset = "0x2A2EB00", VA = "0x182A30500", Slot = "101")]
	public override float ENBJODBDBIM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x2A31C00", Offset = "0x2A30200", VA = "0x182A31C00", Slot = "129")]
	public override void JDEJIGDCPJJ(bool EJBGKFHMCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x26AD7C0", Offset = "0x26ABDC0", VA = "0x1826AD7C0", Slot = "130")]
	public override bool CIKDANALLPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x2A318B0", Offset = "0x2A2FEB0", VA = "0x182A318B0", Slot = "131")]
	public override void HFHMAGGLDBH(float FGHGJFNAJIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0xC13000", Offset = "0xC11600", VA = "0x180C13000", Slot = "133")]
	public override float DGDPNIIHFAH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x2A31390", Offset = "0x2A2F990", VA = "0x182A31390", Slot = "132")]
	public override void GINEFLLDDNH(float FHHCADNOHDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x1F7ECC0", Offset = "0x1F7D2C0", VA = "0x181F7ECC0", Slot = "134")]
	public override float EFHEOAAIAAA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x2A32E30", Offset = "0x2A31430", VA = "0x182A32E30", Slot = "153")]
	public override bool OALKFAOGLAH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x2A2F790", Offset = "0x2A2DD90", VA = "0x182A2F790", Slot = "114")]
	public override bool BJNNFEHDFHK(Camera ONKIDIPKLEC, int MOADIOMDCBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x2A31600", Offset = "0x2A2FC00", VA = "0x182A31600", Slot = "140")]
	public override void GPLJNLACLBL(PKHJIOPINGD IAFKLPLOCCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x2A31C90", Offset = "0x2A30290", VA = "0x182A31C90", Slot = "138")]
	public override void JEHEJLAHMBI(Quaternion EKPPOBOIFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x2A31430", Offset = "0x2A2FA30", VA = "0x182A31430", Slot = "139")]
	public override void GLLLBJEDKMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x2A30580", Offset = "0x2A2EB80", VA = "0x182A30580", Slot = "141")]
	public override void FKCJPEDLFGE(bool ANBCINBEIHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x2A32400", Offset = "0x2A30A00", VA = "0x182A32400", Slot = "142")]
	public override void KKACMGIBLFD(float ANBIGHNEOOL, float IBLKNHIHNMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x2A2FE50", Offset = "0x2A2E450", VA = "0x182A2FE50", Slot = "143")]
	public override void CKKMKONOHJE(Quaternion EKPPOBOIFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x2A30610", Offset = "0x2A2EC10", VA = "0x182A30610", Slot = "146")]
	public override void FLHPFKIPOFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x2A32D00", Offset = "0x2A31300", VA = "0x182A32D00")]
	private void MMJPECHKLMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x2A32EE0", Offset = "0x2A314E0", VA = "0x182A32EE0")]
	private void OGAABBNOPAP(IntPtr IKHPBDGJBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x2A31CD0", Offset = "0x2A302D0", VA = "0x182A31CD0", Slot = "150")]
	public override void JEJGLKBFKJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
	private void PIKMMMPNDKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x2A32B50", Offset = "0x2A31150", VA = "0x182A32B50", Slot = "147")]
	public override void MHKKCKEAAKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x2A30340", Offset = "0x2A2E940", VA = "0x182A30340", Slot = "148")]
	public override void DJALLKHDNEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "149")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x2A31DE0", Offset = "0x2A303E0", VA = "0x182A31DE0", Slot = "136")]
	public override int JGINEHBAPJG(float[] COEFMBJKIKA, int HDOPDCPGECL, int FPNDCHNJFNF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x214C600", Offset = "0x214AC00", VA = "0x18214C600", Slot = "151")]
	public override bool DPEFFCHACFE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x2A2F220", Offset = "0x2A2D820", VA = "0x182A2F220")]
	private static void ADCKAIOJIPC(FFHJKBNHMPC.HJMNOAOLINB MHKDGGILNGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x2A2F3D0", Offset = "0x2A2D9D0", VA = "0x182A2F3D0")]
	private static string BAHAONCCFFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x2A2F960", Offset = "0x2A2DF60", VA = "0x182A2F960", Slot = "159")]
	internal override bool BLJHIPGBGEP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x2A32C10", Offset = "0x2A31210", VA = "0x182A32C10", Slot = "160")]
	internal override string MKJODHNJEKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x2A319C0", Offset = "0x2A2FFC0", VA = "0x182A319C0", Slot = "161")]
	internal override bool IAINHDHNKPM(EGPMBGNKJOC MLFHHDFGEFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x2A31920", Offset = "0x2A2FF20", VA = "0x182A31920", Slot = "162")]
	internal override int HOPDMACDOCN(EGPMBGNKJOC MLFHHDFGEFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x2A2FA20", Offset = "0x2A2E020", VA = "0x182A2FA20", Slot = "163")]
	internal override KNLMCFLAKBL CFLKBCDOFAA(EGPMBGNKJOC MLFHHDFGEFM, int KOOPHJIGKIK, bool HGFCKBPDCCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x2A33650", Offset = "0x2A31C50", VA = "0x182A33650", Slot = "144")]
	public override void PDPJPMEEKOO(string HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x2A329C0", Offset = "0x2A30FC0", VA = "0x182A329C0", Slot = "145")]
	public override void LEDICGOIJNN(byte[] HFLDIIIPBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x2A31B90", Offset = "0x2A30190", VA = "0x182A31B90")]
	private void IMBIOBKMHJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x2A312C0", Offset = "0x2A2F8C0", VA = "0x182A312C0")]
	private void GEFALHNNMMJ(HGHNPOACEMA[] KNPJHKKMLOF, FFHJKBNHMPC.JNMHLNJGNJD IDKPALJFCGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public enum DNDLKLDIKBB
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
public sealed class MCGDGFNKHDN : FNFNDCAKGLJ
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	private struct EKGKCEFNKIP
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		public enum JCPLMKIGEGM
		{
			[Cpp2IlInjected.Token(Token = "0x40002F3")]
			Fast,
			[Cpp2IlInjected.Token(Token = "0x40002F4")]
			Accurate
		}

		[StructLayout((LayoutKind)0, Pack = 1, Size = 20)]
		[Cpp2IlInjected.Token(Token = "0x2000065")]
		public struct NBMELDHHNMK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002F5")]
			public int KOOPHJIGKIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002F6")]
			public int JFDKAFBJDGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002F7")]
			public int JPFDAGENGFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40002F8")]
			public float AIEKFOBKHNC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002F9")]
			public uint NCHCMDFINAG;
		}

		[StructLayout((LayoutKind)0, Pack = 1, Size = 12)]
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		public struct HJKICEBIFFE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002FA")]
			public double LLMILILJNFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002FB")]
			public JCPLMKIGEGM JDJJDFOGKAI;
		}

		[StructLayout((LayoutKind)0, Pack = 1, Size = 28)]
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		public struct DPDDFMPFNNA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002FC")]
			public string KDMMFJGANAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002FD")]
			public string HNGIMMGBLII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002FE")]
			public IntPtr HLPOPEOCDLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002FF")]
			public int BLCHFHLAMDJ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		internal enum DFPHNOHILNI
		{
			[Cpp2IlInjected.Token(Token = "0x4000301")]
			Seekable,
			[Cpp2IlInjected.Token(Token = "0x4000302")]
			Buffered
		}

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private static IntPtr EANEBBHIIMO;

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x2A22440", Offset = "0x2A20A40", VA = "0x182A22440")]
		public static extern bool DFFNENGMLIH(IntPtr PLKOLLOCKHK, EGPMBGNKJOC MLFHHDFGEFM);

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x2A22D00", Offset = "0x2A21300", VA = "0x182A22D00")]
		public static extern int JLMMEGEOOLD(IntPtr PLKOLLOCKHK, EGPMBGNKJOC MLFHHDFGEFM);

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x2A229A0", Offset = "0x2A20FA0", VA = "0x182A229A0")]
		public static extern bool IENFJFHBDAJ(IntPtr PLKOLLOCKHK, EGPMBGNKJOC MLFHHDFGEFM, int LEPAEEGOBDO, int IIJDDLOGCCA, bool OFAKGAKKFIK, StringBuilder DJFMCHMDHGK, int FCDKEBNDGLC, StringBuilder IONHIMIACFO, int MDKILEHDPFP);

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x2A23970", Offset = "0x2A21F70", VA = "0x182A23970")]
		public static extern bool PHPFDBMLNOL(IntPtr PLKOLLOCKHK);

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x2A22E10", Offset = "0x2A21410", VA = "0x182A22E10")]
		public static extern IntPtr LGDBGKNJILA(IntPtr PLKOLLOCKHK);

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x2A22720", Offset = "0x2A20D20", VA = "0x182A22720")]
		private static extern IntPtr FHOFHNFFPEI();

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x2A22230", Offset = "0x2A20830", VA = "0x182A22230")]
		public static string BAHAONCCFFJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x2A236D0", Offset = "0x2A21CD0", VA = "0x182A236D0")]
		public static extern IntPtr OGIIEGOAOKF();

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x2A22E90", Offset = "0x2A21490", VA = "0x182A22E90")]
		public static extern void MBJEALCCDBH(IntPtr GKLDOAAOMEI);

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x2A239F0", Offset = "0x2A21FF0", VA = "0x182A239F0")]
		public static extern bool POJPJOMDDPI(IntPtr GKLDOAAOMEI, string FJDLJPAACPO, string HEEJDIGBDBK, HNDKMJFIAHI KBDPNCDBPMO, bool BGCEEPLOFEB, bool NOGBCAPOEDF);

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x2A228A0", Offset = "0x2A20EA0", VA = "0x182A228A0")]
		public static extern void GBPEDHFLCHD(IntPtr GKLDOAAOMEI);

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x2A23740", Offset = "0x2A21D40", VA = "0x182A23740")]
		public static extern void PCEOJEMCNIE(IntPtr GKLDOAAOMEI);

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x2A22C00", Offset = "0x2A21200", VA = "0x182A22C00")]
		public static extern void JFNOLEJOLGK(IntPtr GKLDOAAOMEI);

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x2A221A0", Offset = "0x2A207A0", VA = "0x182A221A0")]
		public static extern void AHINICKMECH(IntPtr GKLDOAAOMEI, float FGHGJFNAJIH);

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x2A23140", Offset = "0x2A21740", VA = "0x182A23140")]
		public static extern void NFFFHHAANPA(IntPtr GKLDOAAOMEI, float FHHCADNOHDD);

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x2A22FA0", Offset = "0x2A215A0", VA = "0x182A22FA0")]
		public static extern void MCFAOOMNGPD(IntPtr GKLDOAAOMEI, float EMACLCMJPPD);

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x2A22810", Offset = "0x2A20E10", VA = "0x182A22810")]
		public static extern void FPCDLHFLLDM(IntPtr GKLDOAAOMEI, bool JFCKMGLJGDD);

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x2A238F0", Offset = "0x2A21EF0", VA = "0x182A238F0")]
		public static extern bool PEBHGKCODBI(IntPtr GKLDOAAOMEI);

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x2A22920", Offset = "0x2A20F20", VA = "0x182A22920")]
		public static extern float GDPEOBHEHPH(IntPtr GKLDOAAOMEI);

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x2A22630", Offset = "0x2A20C30", VA = "0x182A22630")]
		public static extern float ENBJODBDBIM(IntPtr GKLDOAAOMEI);

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x2A22F10", Offset = "0x2A21510", VA = "0x182A22F10")]
		public static extern void MBKFCKLHLNI(IntPtr GKLDOAAOMEI, bool EHDGMIFDJFF);

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x2A22C80", Offset = "0x2A21280", VA = "0x182A22C80")]
		public static extern int JKNCJMDPAIE(IntPtr GKLDOAAOMEI);

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x2A22790", Offset = "0x2A20D90", VA = "0x182A22790")]
		public static extern void FLHPFKIPOFF(IntPtr GKLDOAAOMEI);

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x2A23030", Offset = "0x2A21630", VA = "0x182A23030")]
		public static extern double MFGNDFEKCPP(IntPtr GKLDOAAOMEI);

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x2A22B00", Offset = "0x2A21100", VA = "0x182A22B00")]
		public static extern OICPENEHCJE IOPKJPEEDHO(IntPtr GKLDOAAOMEI);

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x2A22B80", Offset = "0x2A21180", VA = "0x182A22B80")]
		public static extern double JFCFBBPJLGP(IntPtr GKLDOAAOMEI);

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x2A224D0", Offset = "0x2A20AD0", VA = "0x182A224D0")]
		public static extern bool EHEINMANFOO(IntPtr GKLDOAAOMEI, [Out] IntPtr DMJHKAJMKKH, [Out] IntPtr BHHMEDDEENO, [Out] ulong KIHMAEIJDJH, [Out] int JCJCKGHEDMK, [Out] int PDKDGENFDGI);

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x2A22D90", Offset = "0x2A21390", VA = "0x182A22D90")]
		public static extern DNDLKLDIKBB LDKDAHLEKNI(IntPtr GKLDOAAOMEI);

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x2A225A0", Offset = "0x2A20BA0", VA = "0x182A225A0")]
		public static extern bool EKPFELOBLII(IntPtr GKLDOAAOMEI, [Out] NBMELDHHNMK BKAPBLMPKJJ);

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x2A230B0", Offset = "0x2A216B0", VA = "0x182A230B0")]
		public static extern void MKCCNHJEFMI(IntPtr GKLDOAAOMEI, double AEKHJIAHDFD);

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x2A223B0", Offset = "0x2A209B0", VA = "0x182A223B0")]
		public static extern void DAFCDADJIEH(IntPtr GKLDOAAOMEI, HJKICEBIFFE NHDKLMGFDFD);

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x2A23400", Offset = "0x2A21A00", VA = "0x182A23400")]
		public static void OEBBGGBNGMN(IntPtr GKLDOAAOMEI, EBIEKKAMDOF MCDBJKIGJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x2A232A0", Offset = "0x2A218A0", VA = "0x182A232A0")]
		private static extern void OEBBGGBNGMN(IntPtr GKLDOAAOMEI, DPDDFMPFNNA GNPBKJCIJPK);

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x2A237C0", Offset = "0x2A21DC0", VA = "0x182A237C0")]
		public static extern int PDNDOLCMKIL(IntPtr GKLDOAAOMEI, [Out] HGHNPOACEMA[] CNBOJLFBFDP, int DJAACGNFHLC, DFPHNOHILNI IDKPALJFCGO);

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x2A226B0", Offset = "0x2A20CB0", VA = "0x182A226B0")]
		public static extern IntPtr FBNPAGDKNBJ();

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x2A222E0", Offset = "0x2A208E0", VA = "0x182A222E0")]
		public static void BKOOIAIPHPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x2A231D0", Offset = "0x2A217D0", VA = "0x182A231D0")]
		public static void NLDGBNOFDPN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private class DKIPAOFDOHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public Texture2D BHNOPLHICEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public IntPtr MCKPPFFFPCG;

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x2A21EF0", Offset = "0x2A204F0", VA = "0x182A21EF0")]
		public void CKBKAMMKCLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x2A21FD0", Offset = "0x2A205D0", VA = "0x182A21FD0")]
		public DKIPAOFDOHC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private bool AMDEFNILEHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private bool AANHPNOLPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private float JAHHFJGMGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	private bool GMOAMLCNOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	private bool DFLHIMKLLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private EBIEKKAMDOF OIHKEHEIAHA;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private static bool IFDBEPECFLF;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private static string KEBBCDIELGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private ulong DIGHHAFMJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private IntPtr NAEOIBMAKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private DKIPAOFDOHC[] IMDJBLKACGF;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public EBIEKKAMDOF JNDLBOEOPMH
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x2A2E050", Offset = "0x2A2C650", VA = "0x182A2E050")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x2A2F010", Offset = "0x2A2D610", VA = "0x182A2F010")]
	public MCGDGFNKHDN(MediaPlayer.OptionsWindows EEPOAHLOJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x2A2C900", Offset = "0x2A2AF00", VA = "0x182A2C900")]
	public void BEIJOMNLNDB(MediaPlayer.OptionsWindows EEPOAHLOJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x2A2C890", Offset = "0x2A2AE90", VA = "0x182A2C890", Slot = "93")]
	public override bool AJCHFCJENLP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x2A2D160", Offset = "0x2A2B760", VA = "0x182A2D160", Slot = "149")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "151")]
	public override bool DPEFFCHACFE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x2A2C810", Offset = "0x2A2AE10", VA = "0x182A2C810", Slot = "100")]
	public override double AIIKFDHPEAF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x2A2E970", Offset = "0x2A2CF70", VA = "0x182A2E970", Slot = "103")]
	public override double MFGNDFEKCPP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x2A2D470", Offset = "0x2A2BA70", VA = "0x182A2D470", Slot = "101")]
	public override float ENBJODBDBIM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x2A2DFC0", Offset = "0x2A2C5C0", VA = "0x182A2DFC0", Slot = "116")]
	public override Texture GetTexture(int LEPAEEGOBDO = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x2A2DF30", Offset = "0x2A2C530", VA = "0x182A2DF30", Slot = "115")]
	public override int GetTextureCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x1E85AA0", Offset = "0x1E840A0", VA = "0x181E85AA0", Slot = "117")]
	public override int GetTextureFrameCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x2A2E790", Offset = "0x2A2CD90", VA = "0x182A2E790", Slot = "127")]
	internal override OICPENEHCJE KAGKELHMDLG()
	{
		return default(OICPENEHCJE);
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x2A2C8B0", Offset = "0x2A2AEB0", VA = "0x182A2C8B0", Slot = "82")]
	public override string AJEICOJDHIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x2A2C9E0", Offset = "0x2A2AFE0", VA = "0x182A2C9E0", Slot = "83")]
	public override string BOAKMJDFIFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x2A2DD20", Offset = "0x2A2C320", VA = "0x182A2DD20", Slot = "106")]
	public override float GFLOLEOKKEH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x2A2DDD0", Offset = "0x2A2C3D0", VA = "0x182A2DDD0", Slot = "104")]
	public override int GHDEINPKEBK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x2A2EA70", Offset = "0x2A2D070", VA = "0x182A2EA70", Slot = "105")]
	public override int MLCGAFDMLBF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x1D3DDE0", Offset = "0x1D3C3E0", VA = "0x181D3DDE0", Slot = "133")]
	public override float DGDPNIIHFAH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x2A2DEA0", Offset = "0x2A2C4A0", VA = "0x182A2DEA0", Slot = "132")]
	public override void GINEFLLDDNH(float FHHCADNOHDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x2A2D380", Offset = "0x2A2B980", VA = "0x182A2D380", Slot = "134")]
	public override float EFHEOAAIAAA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x2A2D090", Offset = "0x2A2B690", VA = "0x182A2D090", Slot = "107")]
	public override bool CLIHPMHNFND()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x2A2E890", Offset = "0x2A2CE90", VA = "0x182A2E890", Slot = "92")]
	public override bool LEIBNOPKOFP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x2A2E6D0", Offset = "0x2A2CCD0", VA = "0x182A2E6D0", Slot = "108")]
	public override bool JFHEEGBIJAB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x2A2DC30", Offset = "0x2A2C230", VA = "0x182A2DC30", Slot = "113")]
	public override bool GDBDPDDJOAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x2A2EB60", Offset = "0x2A2D160", VA = "0x182A2EB60", Slot = "112")]
	public override bool OMEGOIEKINN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0xB66050", Offset = "0xB64650", VA = "0x180B66050", Slot = "91")]
	public override bool LGGCDCOGBMP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x2A2CD70", Offset = "0x2A2B370", VA = "0x182A2CD70", Slot = "130")]
	public override bool CIKDANALLPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x2A2E010", Offset = "0x2A2C610", VA = "0x182A2E010", Slot = "111")]
	public override bool HENGHMBIENC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x2A2D400", Offset = "0x2A2BA00", VA = "0x182A2D400", Slot = "110")]
	public override bool EHFAJNLFEII()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x2A2E810", Offset = "0x2A2CE10", VA = "0x182A2E810", Slot = "109")]
	public override bool KNKMBDAKGNM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x2A2E640", Offset = "0x2A2CC40", VA = "0x182A2E640", Slot = "129")]
	public override void JDEJIGDCPJJ(bool EJBGKFHMCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x2A2ECF0", Offset = "0x2A2D2F0", VA = "0x182A2ECF0", Slot = "84")]
	public override bool POJPJOMDDPI(string JKCPEHCGLIK, long EFCGAKGCCGN, string HEEJDIGBDBK, MediaHints PGHDGGOCHNA, int ALELCIDKPJD = 0, bool BGCEEPLOFEB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x2A2DB80", Offset = "0x2A2C180", VA = "0x182A2DB80", Slot = "89")]
	public override void GBPEDHFLCHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x2A2EC10", Offset = "0x2A2D210", VA = "0x182A2EC10", Slot = "95")]
	public override void PCEOJEMCNIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x2A2E710", Offset = "0x2A2CD10", VA = "0x182A2E710", Slot = "94")]
	public override void JFNOLEJOLGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x2A222E0", Offset = "0x2A208E0", VA = "0x182A222E0", Slot = "148")]
	public override void DJALLKHDNEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x2A2E1B0", Offset = "0x2A2C7B0", VA = "0x182A2E1B0")]
	private void IKILFNHJCHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0", Slot = "120")]
	public override bool RequiresVerticalFlip()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x2A2D0D0", Offset = "0x2A2B6D0", VA = "0x182A2D0D0", Slot = "98")]
	public override void DAFCDADJIEH(double FLCAFPMKFLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x2A2C930", Offset = "0x2A2AF30", VA = "0x182A2C930", Slot = "99")]
	public override void BHPIBAEEPCF(double FLCAFPMKFLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x2A2E8C0", Offset = "0x2A2CEC0", VA = "0x182A2E8C0", Slot = "90")]
	public override void MBKFCKLHLNI(bool KEEHLJNBNEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x2A2E8E0", Offset = "0x2A2CEE0", VA = "0x182A2E8E0", Slot = "102")]
	public override void MCFAOOMNGPD(float EMACLCMJPPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x2A2E030", Offset = "0x2A2C630", VA = "0x182A2E030", Slot = "131")]
	public override void HFHMAGGLDBH(float FGHGJFNAJIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x2A2EB40", Offset = "0x2A2D140", VA = "0x182A2EB40", Slot = "96")]
	public override void MNEFMGBPPHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x2A2E5D0", Offset = "0x2A2CBD0", VA = "0x182A2E5D0")]
	private void IMBIOBKMHJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x2A2DC50", Offset = "0x2A2C250", VA = "0x182A2DC50")]
	private void GEFALHNNMMJ(HGHNPOACEMA[] KNPJHKKMLOF, EKGKCEFNKIP.DFPHNOHILNI IDKPALJFCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x2A2D4F0", Offset = "0x2A2BAF0", VA = "0x182A2D4F0", Slot = "146")]
	public override void FLHPFKIPOFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x2A2EC90", Offset = "0x2A2D290", VA = "0x182A2EC90", Slot = "144")]
	public override void PDPJPMEEKOO(string HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x2A2E830", Offset = "0x2A2CE30", VA = "0x182A2E830", Slot = "145")]
	public override void LEDICGOIJNN(byte[] HFLDIIIPBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x2A2E120", Offset = "0x2A2C720", VA = "0x182A2E120", Slot = "161")]
	internal override bool IAINHDHNKPM(EGPMBGNKJOC MLFHHDFGEFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x2A2E090", Offset = "0x2A2C690", VA = "0x182A2E090", Slot = "162")]
	internal override int HOPDMACDOCN(EGPMBGNKJOC MLFHHDFGEFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x2A2CA10", Offset = "0x2A2B010", VA = "0x182A2CA10", Slot = "163")]
	internal override KNLMCFLAKBL CFLKBCDOFAA(EGPMBGNKJOC MLFHHDFGEFM, int KOOPHJIGKIK, bool HGFCKBPDCCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x2A2C950", Offset = "0x2A2AF50", VA = "0x182A2C950", Slot = "159")]
	internal override bool BLJHIPGBGEP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x2A2E980", Offset = "0x2A2CF80", VA = "0x182A2E980", Slot = "160")]
	internal override string MKJODHNJEKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2A2CE00", Offset = "0x2A2B400", VA = "0x182A2CE00")]
	public static bool CKMKKCJKAGH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x2A2D420", Offset = "0x2A2BA20", VA = "0x182A2D420")]
	public static void EKCJEHPEFMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class ECIIDPNJKMN
{
	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public string FDJBGNNLJAG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0xA9AB40", Offset = "0xA99140", VA = "0x180A9AB40")]
	internal ECIIDPNJKMN(string DMGMBCGCHOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public enum EGPMBGNKJOC
{
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	Video,
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	Audio,
	[Cpp2IlInjected.Token(Token = "0x4000309")]
	Text
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class KNLMCFLAKBL
{
	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public int JBGLKHKFPKA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	private EGPMBGNKJOC LPEIOEMLEEK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0xB91EF0", Offset = "0xB904F0", VA = "0x180B91EF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	private string KEAFAIGDFEM
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public string GBEIFPAEHEI
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private bool BGHOPJKLNOC
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xAC33B0", Offset = "0xAC19B0", VA = "0x180AC33B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x2A2C4E0", Offset = "0x2A2AAE0", VA = "0x182A2C4E0")]
	internal KNLMCFLAKBL(EGPMBGNKJOC MLFHHDFGEFM, int IIJDDLOGCCA, string DJFMCHMDHGK, string IONHIMIACFO, bool AOOELKAKPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x2A2C420", Offset = "0x2A2AA20", VA = "0x182A2C420")]
	protected string CDCJOEBIPLC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public abstract class EPJEJMEILJM : IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public virtual EGPMBGNKJOC LPEIOEMLEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(EGPMBGNKJOC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public abstract int DGBEIHMBLFP
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
	internal abstract void OOIGDCNPPFG();

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void KMLBEHGKDFG(KNLMCFLAKBL HFIBCJNFGFO);

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract void ILGIIDKGJNI(KNLMCFLAKBL HFIBCJNFGFO);

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	protected EPJEJMEILJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[DefaultMember("Item")]
public class JAOBAKJHDCH<T> : EPJEJMEILJM where T : KNLMCFLAKBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	internal List<T> DBBENFIKPLC;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	internal T HJKDNKKHGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public override int DGBEIHMBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x549CE90", Offset = "0x549B490", VA = "0x18549CE90", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x549D180", Offset = "0x549B780", VA = "0x18549D180")]
	internal JAOBAKJHDCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x549CED0", Offset = "0x549B4D0", VA = "0x18549CED0", Slot = "7")]
	public override IEnumerator GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x549D120", Offset = "0x549B720", VA = "0x18549D120", Slot = "8")]
	internal override void OOIGDCNPPFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x549D040", Offset = "0x549B640", VA = "0x18549D040", Slot = "9")]
	internal override void KMLBEHGKDFG(KNLMCFLAKBL HFIBCJNFGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x549CF60", Offset = "0x549B560", VA = "0x18549CF60", Slot = "10")]
	internal override void ILGIIDKGJNI(KNLMCFLAKBL HFIBCJNFGFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class EIMHDLAFEHN : JAOBAKJHDCH<DGHDPNCMGDF>
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public override EGPMBGNKJOC LPEIOEMLEEK
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "5")]
		get
		{
			return default(EGPMBGNKJOC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x2A22160", Offset = "0x2A20760", VA = "0x182A22160")]
	public EIMHDLAFEHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class DMJMMEMPCDE : JAOBAKJHDCH<HLLDKDDIAEG>
{
	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public override EGPMBGNKJOC LPEIOEMLEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0xC21180", Offset = "0xC1F780", VA = "0x180C21180", Slot = "5")]
		get
		{
			return default(EGPMBGNKJOC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x2A22020", Offset = "0x2A20620", VA = "0x182A22020")]
	public DMJMMEMPCDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class PCLKAFLDHBE : JAOBAKJHDCH<OPOEELIIOAK>
{
	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public override EGPMBGNKJOC LPEIOEMLEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0xAF6010", Offset = "0xAF4610", VA = "0x180AF6010", Slot = "5")]
		get
		{
			return default(EGPMBGNKJOC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x2A37B00", Offset = "0x2A36100", VA = "0x182A37B00")]
	public PCLKAFLDHBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class DGHDPNCMGDF : KNLMCFLAKBL
{
	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x2A21EC0", Offset = "0x2A204C0", VA = "0x182A21EC0")]
	internal DGHDPNCMGDF(int IIJDDLOGCCA, string DJFMCHMDHGK, string IONHIMIACFO, bool AOOELKAKPKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class HLLDKDDIAEG : KNLMCFLAKBL
{
	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x2A28110", Offset = "0x2A26710", VA = "0x182A28110")]
	internal HLLDKDDIAEG(int IIJDDLOGCCA, string DJFMCHMDHGK, string IONHIMIACFO, bool AOOELKAKPKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class OPOEELIIOAK : KNLMCFLAKBL
{
	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x2A37AD0", Offset = "0x2A360D0", VA = "0x182A37AD0")]
	internal OPOEELIIOAK(int IIJDDLOGCCA, string DJFMCHMDHGK, string IONHIMIACFO, bool AOOELKAKPKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface MAELJHAOCHO
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface GDONPFBIJEC
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface ADANFEFBKAN
{
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public static class EPOGJEAMGEK
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public enum JNOKELABMAB
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
	[Cpp2IlInjected.Address(RVA = "0x2A24010", Offset = "0x2A22610", VA = "0x182A24010")]
	public static Func<float, float> OEPLENMANDH(JNOKELABMAB JCPDLNNDAMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x2A23CA0", Offset = "0x2A222A0", VA = "0x182A23CA0")]
	public static float GFPHBFMBNBH(float IHNLGGEEIFC, float DOIPOHHHILF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x2A23C60", Offset = "0x2A22260", VA = "0x182A23C60")]
	public static float GBGBOMENAFA(float IHNLGGEEIFC, float DOIPOHHHILF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x2A23D60", Offset = "0x2A22360", VA = "0x182A23D60")]
	public static float IHEMCPKCALK(float IHNLGGEEIFC, float DOIPOHHHILF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x2A23CB0", Offset = "0x2A222B0", VA = "0x182A23CB0")]
	public static float GGLKMIOKJEL(float IHNLGGEEIFC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
	public static float JJNGEMIPJGB(float IHNLGGEEIFC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x2A23FC0", Offset = "0x2A225C0", VA = "0x182A23FC0")]
	public static float NJOFJILNMAE(float IHNLGGEEIFC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x2A23AD0", Offset = "0x2A220D0", VA = "0x182A23AD0")]
	public static float AIENGBJNFMC(float IHNLGGEEIFC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x2A23DE0", Offset = "0x2A223E0", VA = "0x182A23DE0")]
	public static float IIEKCJLFIDC(float IHNLGGEEIFC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x2A23EE0", Offset = "0x2A224E0", VA = "0x182A23EE0")]
	public static float KHHIKMEGKMK(float IHNLGGEEIFC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x2A23EF0", Offset = "0x2A224F0", VA = "0x182A23EF0")]
	public static float MKOLFOHJAKA(float IHNLGGEEIFC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x2A23E60", Offset = "0x2A22460", VA = "0x182A23E60")]
	public static float KEMDPLAMKFI(float IHNLGGEEIFC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x2A23B90", Offset = "0x2A22190", VA = "0x182A23B90")]
	public static float CBPLMPBBABE(float IHNLGGEEIFC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x2A23D20", Offset = "0x2A22320", VA = "0x182A23D20")]
	public static float GLLEJJBKGGD(float IHNLGGEEIFC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x2A23B10", Offset = "0x2A22110", VA = "0x182A23B10")]
	public static float CACAEHDHBIC(float IHNLGGEEIFC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x2A24580", Offset = "0x2A22B80", VA = "0x182A24580")]
	public static float PFIEDEOBODA(float IHNLGGEEIFC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x2A23FD0", Offset = "0x2A225D0", VA = "0x182A23FD0")]
	public static float OBNAEMIDMCD(float IHNLGGEEIFC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x2A23BA0", Offset = "0x2A221A0", VA = "0x182A23BA0")]
	public static float CHLNEJFJJBJ(float IHNLGGEEIFC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x2A23C20", Offset = "0x2A22220", VA = "0x182A23C20")]
	public static float CJPEHKABPAL(float IHNLGGEEIFC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x2A23CD0", Offset = "0x2A222D0", VA = "0x182A23CD0")]
	public static float GHIEPPEOPIE(float IHNLGGEEIFC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x2A23F30", Offset = "0x2A22530", VA = "0x182A23F30")]
	public static float NFBCIFINECC(float IHNLGGEEIFC)
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
		[Cpp2IlInjected.Address(RVA = "0x2A285C0", Offset = "0x2A26BC0", VA = "0x182A285C0")]
		public bool HCEHGADACEB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x2A28600", Offset = "0x2A26C00", VA = "0x182A28600")]
		public string NOJMFKJKHKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x2A284F0", Offset = "0x2A26AF0", VA = "0x182A284F0")]
		public static bool EJBELALFPGK(string DMGMBCGCHOD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x2A28440", Offset = "0x2A26A40", VA = "0x182A28440")]
		private static bool DHLNGAAEIAM(string DMGMBCGCHOD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x2A284B0", Offset = "0x2A26AB0", VA = "0x182A284B0")]
		private bool EJBELALFPGK()
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
		[Cpp2IlInjected.Address(RVA = "0x2A28140", Offset = "0x2A26740", VA = "0x182A28140", Slot = "4")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x2A281C0", Offset = "0x2A267C0", VA = "0x182A281C0")]
		public string NOJMFKJKHKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x2A283B0", Offset = "0x2A269B0", VA = "0x182A283B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x2A2C5F0", Offset = "0x2A2ABF0", VA = "0x182A2C5F0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public KeyAuthData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class IPPOMOLKIEN
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private class LBAOGHJCDNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public RenderTexture BHNOPLHICEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public long HGOBOADNGMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public bool ICLBMJHIDHC;

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public LBAOGHJCDNA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public enum DJBNKFGJPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		POINT,
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		LINEAR
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private List<LBAOGHJCDNA[]> PEIJCAMFPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private MediaPlayer CKPDEFLAOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private RenderTexture[] ODFANFJJMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private int PMJINGOKJKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private int JCBJOLJJGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private int OGAEMKNCIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private long FAPIIGHJFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private float IOCMNNLIHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private Material JLPBCMKIODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private DJBNKFGJPDJ PEHJFNGKMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private string KHEFOKJFPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private long OKMFJLGHLNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private int ALDIOEFHOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private long FIOJJCLDHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private int KLGNLDKJPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	private long IJNACIELBNG;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	private const string IGBLMNDOKHB = "_t";

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	private const string NHCENKMKDHF = "_AfterTex";

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000341")]
	private int OPLOHNMNHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000342")]
	private int EMBMFPJNDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000343")]
	private float PJJMJANCCEH;

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private float HFPLGBCHBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x1629B50", Offset = "0x1628150", VA = "0x181629B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	private long ECMKKEEKKJK
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x2A29DD0", Offset = "0x2A283D0", VA = "0x182A29DD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public Texture[] DLNPJPALMLB
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x2A29CF0", Offset = "0x2A282F0", VA = "0x182A29CF0")]
	public void GJNPKHJOBIP(MediaPlayer DPAFDJOAOAE, MediaPlayerEvent.BHFBPEFIMHM HBCMLPDPBCA, HIICDHDBEHA DCHHIMINIKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x2A2B020", Offset = "0x2A29620", VA = "0x182A2B020")]
	public IPPOMOLKIEN(MediaPlayer LIOICDJHFAF, string DJFMCHMDHGK, int NMBDPLPODMD = 2, DJBNKFGJPDJ EDKKOMCPMID = DJBNKFGJPDJ.LINEAR)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x2A2A050", Offset = "0x2A28650", VA = "0x182A2A050")]
	public void IMGLACMMFNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x2A2AF60", Offset = "0x2A29560", VA = "0x182A2AF60")]
	public void PILMPNHBFAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x2A29E00", Offset = "0x2A28400", VA = "0x182A29E00")]
	private void ICADAHHPBMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x2A2A9E0", Offset = "0x2A28FE0", VA = "0x182A2A9E0")]
	private void OFCHKDILFFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x2A28E10", Offset = "0x2A27410", VA = "0x182A28E10")]
	private bool DHDPMENHAHF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x2A289C0", Offset = "0x2A26FC0", VA = "0x182A289C0")]
	private int AKBIJGHFFNM(int PLKPFEKJAPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x2A2A070", Offset = "0x2A28670", VA = "0x182A2A070")]
	private int JMDEGBHABNO(int PLKPFEKJAPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x2A28690", Offset = "0x2A26C90", VA = "0x182A28690")]
	private void ADKHPMAMBGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x2A2A880", Offset = "0x2A28E80", VA = "0x182A2A880")]
	private void ODJBHNFDCNP(int PLKPFEKJAPP, int GPMLPINMHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x2A2A230", Offset = "0x2A28830", VA = "0x182A2A230")]
	private void KEELPPEJDII(int GPMLPINMHNP, int LNEKGLFIPFI, int MGNFDNDLFHK, float IHNLGGEEIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x2A28BE0", Offset = "0x2A271E0", VA = "0x182A28BE0")]
	private void DBMOGJBLGOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x2A2A4E0", Offset = "0x2A28AE0", VA = "0x182A2A4E0")]
	private void MNAACPGOHHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x2A2A5E0", Offset = "0x2A28BE0", VA = "0x182A2A5E0")]
	private float NHBMAPHOBGD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x2A291C0", Offset = "0x2A277C0", VA = "0x182A291C0")]
	public void FLHPFKIPOFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x2A29DE0", Offset = "0x2A283E0", VA = "0x182A29DE0")]
	public void GMHMNPKNDCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class LAHNBAHGNCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public int LEPAEEGOBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public string DMGMBCGCHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public double GADFNBGCICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public double PDNDKEHJHJC;

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x2A2C7F0", Offset = "0x2A2ADF0", VA = "0x182A2C7F0")]
	public bool GDGBHGDBDOB(double FLCAFPMKFLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public LAHNBAHGNCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public class NNBNEDLCMCB
{
	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x2A34FA0", Offset = "0x2A335A0", VA = "0x182A34FA0")]
	private static double OCNNFCABFKP(string DMGMBCGCHOD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x2A34B50", Offset = "0x2A33150", VA = "0x182A34B50")]
	public static List<LAHNBAHGNCC> DICOALPJAEP(string DAJAOHIJHHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct FHBFMADDBJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private string KHEFOKJFPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private int MFKEMOGOFKD;

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public int AFPIOPNCMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x2A280C0", Offset = "0x2A266C0", VA = "0x182A280C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x2A280F0", Offset = "0x2A266F0", VA = "0x182A280F0")]
	public FHBFMADDBJI(string DJFMCHMDHGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class OLAGHBFDJKJ
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[Flags]
	public enum MLBFNEMIFCF
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
	public static readonly FHBFMADDBJI MCLLMPENLKI;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly FHBFMADDBJI DAABOCJCKKM;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly FHBFMADDBJI ACPMPAPEOJM;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly FHBFMADDBJI NCPFCCIIGBH;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly FHBFMADDBJI KGBIIJJMDPA;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly FHBFMADDBJI DCBKABNHPJB;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly FHBFMADDBJI GLEIPDDPBOF;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly FHBFMADDBJI EKIBACJKGBO;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly FHBFMADDBJI DCHEOFCBEHK;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly FHBFMADDBJI APOGAMMNEAN;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static string IAIPHLKFFIO;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly FHBFMADDBJI HFMBGIJIKLF;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly FHBFMADDBJI FGEBLKLLFIF;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly FHBFMADDBJI PKJLCCLFJII;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly FHBFMADDBJI NIMEFMDFENP;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly FHBFMADDBJI AOHDPDEEEMI;

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x2A36C70", Offset = "0x2A35270", VA = "0x182A36C70")]
	public static Material MLMEJACFJME(bool FMNINJAGFNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x2A37450", Offset = "0x2A35A50", VA = "0x182A37450")]
	public static void PJBAGBFKLPM(Material JKDFAJLFBEL, NOPENGNBHNN NNENKPCPHBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x2A35240", Offset = "0x2A33840", VA = "0x182A35240")]
	public static void CBFACDGFNNF(Material JKDFAJLFBEL, OICPENEHCJE PINCNJJGJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x2A35B10", Offset = "0x2A34110", VA = "0x182A35B10")]
	public static void DGIDKPPICAA(Material JKDFAJLFBEL, ALDPFJHPMEB PINCNJJGJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x2A360E0", Offset = "0x2A346E0", VA = "0x182A360E0")]
	public static void HBCCLNHCFAG(Material JKDFAJLFBEL, bool IKIOMMPDDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x2A35C50", Offset = "0x2A34250", VA = "0x182A35C50")]
	public static void EFIDCGBJNAL(Material JKDFAJLFBEL, Matrix4x4 JAHKFPBBGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x2A36030", Offset = "0x2A34630", VA = "0x182A36030")]
	public static void ENHOACCBEJJ(Material JKDFAJLFBEL, bool IEJOIJKOADG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x2A350E0", Offset = "0x2A336E0", VA = "0x182A350E0")]
	public static Texture AAMBPIAMDCD(MediaPlayer DDGBEDKCOOJ, int MCFGNCOBMBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x2A36E90", Offset = "0x2A35490", VA = "0x182A36E90")]
	public static void ODIKEFOAOMH(Material JKDFAJLFBEL, MediaPlayer DDGBEDKCOOJ, int HEGDMOEGAAG = -1, [Optional] Texture HEMPBAIFJFK, bool FBBOCEIDDKF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x2A36760", Offset = "0x2A34D60", VA = "0x182A36760")]
	internal static void JNGCCKBBDNL(Material JKDFAJLFBEL, bool DLJIMNFJONF, bool IKIOMMPDDKG, Matrix4x4 DKIDFKHNFGA, Texture NKJLENBCPFB, Matrix4x4 BHAFOADIMHP, NOPENGNBHNN NNENKPCPHBP = NOPENGNBHNN.Normal, OICPENEHCJE IODMGGHPAHK = OICPENEHCJE.None, ALDPFJHPMEB CBDFCLEAFKG = ALDPFJHPMEB.None)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x2A35D50", Offset = "0x2A34350", VA = "0x182A35D50")]
	public static void EKBCNNJLKAC(Material JKDFAJLFBEL, VideoResolveOptions EEPOAHLOJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x2A36170", Offset = "0x2A34770", VA = "0x182A36170")]
	public static RenderTexture HKMOIMOBFAK(Material APPEGEFBHNI, RenderTexture EAOABPCKLJL, LOLDIHPFCMA BHNOPLHICEP, MLBFNEMIFCF OAKCIAMNOIJ, ScaleMode LGLNIIIKLFF = ScaleMode.StretchToFill)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x2A36D10", Offset = "0x2A35310", VA = "0x182A36D10")]
	public static void NABBCAJGIAL(ALDPFJHPMEB CBDFCLEAFKG, OICPENEHCJE IODMGGHPAHK, BOABNNLGPJF MNPGHAOHAJC, float HNIHPPFHNAA, Matrix4x4 MOCBMHEOMHJ, int JCJCKGHEDMK, int PDKDGENFDGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x2A354F0", Offset = "0x2A33AF0", VA = "0x182A354F0")]
	public static void COLPIMKLHDD(Rect HKHNMPOFLLL, Texture BHNOPLHICEP, ScaleMode LGLNIIIKLFF, ALDPFJHPMEB CBDFCLEAFKG, float HNIHPPFHNAA, Material JKDFAJLFBEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public enum KPPJNBCOJHF
{
	[Cpp2IlInjected.Token(Token = "0x4000367")]
	SDR,
	[Cpp2IlInjected.Token(Token = "0x4000368")]
	HLG,
	[Cpp2IlInjected.Token(Token = "0x4000369")]
	PQ
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public enum MNDOLODCPOB : uint
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
public class LACOBJPJJJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400037A")]
	private int OIOBNJNFILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400037B")]
	private int EKKPJPMCFEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400037C")]
	private int EKNFJJMPIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400037D")]
	private int HKIPIOGDAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400037E")]
	private int EKEAFNLOCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400037F")]
	private MNDOLODCPOB IEMIGJDICKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000380")]
	private float DFPLNANKMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000381")]
	private KPPJNBCOJHF HLMDCOEDHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000382")]
	private MNDOLODCPOB MKMMIEHOOOP;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	private static LACOBJPJJJA IMEIGJPMIFJ;

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x2A2C770", Offset = "0x2A2AD70", VA = "0x182A2C770")]
	public LACOBJPJJJA(int MEABEDMFFCH, int NIBGCEOPOFH, int ELGNOAAMKBG, int OLACCABJDHJ, int IBKMKKCNAMK = 0, MNDOLODCPOB LFFNNEMEIFK = MNDOLODCPOB.unknown, float HJNMMJFIGLB = 0f, KPPJNBCOJHF NDODHHMHKBI = KPPJNBCOJHF.SDR, MNDOLODCPOB FBNHBEPKOFC = MNDOLODCPOB.unknown)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[DefaultMember("Item")]
public interface BIPHNHHBPBH : IEnumerable
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
