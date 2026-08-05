using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mono.Math;
using RecRoom;
using RecRoom.Core.DataStructures;
using RecRoom.Core.Imposters;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class ImposterPreviewCustomFraming : MonoBehaviour, PAFNGPMCLOE
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float PDDLJAAGNJF = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "4")]
	public void PrepareImposter(NKDCNPEGJNP IEOIKHEEPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x41651E0", Offset = "0x41639E0", VA = "0x1841651E0")]
	public void SetReferencePoint(Vector3 NDFADLNAIEP, Quaternion DEOODMICGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4164F40", Offset = "0x4163740", VA = "0x184164F40")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4165170", Offset = "0x4163970", VA = "0x184165170")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1FDDCC0", Offset = "0x1FDC4C0", VA = "0x181FDDCC0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct ONHFPKFJFOI
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static ONHFPKFJFOI BCJAIDOHPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public float BIJFEDIDPHJ;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xAABB80", Offset = "0xAAA380", VA = "0x180AABB80")]
	public ONHFPKFJFOI(float MFFFEMCJBNI)
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class IncreaseTransparentRenderQueueWhenInUI : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		[AFEANLAOHEH(BOGMEFLEKOL.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const int IGDAPKAKHFA = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const int GPMPIIENJND = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly List<Material> GOJCDJDGFFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool FIINJLJIFCI;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x41653A0", Offset = "0x4163BA0", VA = "0x1841653A0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x41652A0", Offset = "0x4163AA0", VA = "0x1841652A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4165580", Offset = "0x4163D80", VA = "0x184165580")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class CenterInImposter : MonoBehaviour, PAFNGPMCLOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x41623F0", Offset = "0x4160BF0", VA = "0x1841623F0", Slot = "4")]
		public void PrepareImposter(NKDCNPEGJNP IEOIKHEEPLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x628F80", Offset = "0x627780", VA = "0x180628F80")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x628F80", Offset = "0x627780", VA = "0x180628F80")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface PAFNGPMCLOE
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(NKDCNPEGJNP IEOIKHEEPLI);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface OKFCEJLABAF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IEnumerable<Type> BGOKKGCEKGC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<Type> OFMMCHMBCIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface LCEHFEGOGIK
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LBGNFGMCEKE(params Type[] PDJCGKDLAGG);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BNGMHAAMKMP(params Type[] PDJCGKDLAGG);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject CAENJHGBPME(GameObject IIFCAFGLJID, Transform CELKNCFBAOE, bool DHHFGDOACMD = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T CAENJHGBPME<T>(T IIFCAFGLJID, Transform CELKNCFBAOE, bool DHHFGDOACMD = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T CAENJHGBPME<T>(GameObject IIFCAFGLJID, Transform CELKNCFBAOE, bool DHHFGDOACMD = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject CAENJHGBPME(GameObject IIFCAFGLJID, Transform CELKNCFBAOE, NKDCNPEGJNP IEOIKHEEPLI, bool DHHFGDOACMD);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T CAENJHGBPME<T>(GameObject IIFCAFGLJID, Transform CELKNCFBAOE, NKDCNPEGJNP IEOIKHEEPLI, bool DHHFGDOACMD) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T CAENJHGBPME<T>(T IIFCAFGLJID, Transform CELKNCFBAOE, NKDCNPEGJNP IEOIKHEEPLI, bool DHHFGDOACMD) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class NMFACCHIODP : IDisposable, LCEHFEGOGIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly HashSet<Type> KAKGLPFBKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly HashSet<Type> MFDABJEFDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private Transform BAENHFFFGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly List<Component> NKPOBEGHLLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> ILNGLNAKMJP;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4165690", Offset = "0x4163E90", VA = "0x184165690")]
	[BCECNELPMON(FBFJKBDMJLC.None)]
	public static void AIOOGGJLIGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4166110", Offset = "0x4164910", VA = "0x184166110")]
	[Preserve]
	public NMFACCHIODP([EDDGBBNJGJM(null)] OKFCEJLABAF CINNGODHJPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x41658F0", Offset = "0x41640F0", VA = "0x1841658F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4165B30", Offset = "0x4164330", VA = "0x184165B30", Slot = "5")]
	public void LBGNFGMCEKE(params Type[] PDJCGKDLAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4165780", Offset = "0x4163F80", VA = "0x184165780", Slot = "6")]
	public void BNGMHAAMKMP(params Type[] PDJCGKDLAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x41657D0", Offset = "0x4163FD0", VA = "0x1841657D0", Slot = "7")]
	public GameObject CAENJHGBPME(GameObject IIFCAFGLJID, Transform CELKNCFBAOE, bool DHHFGDOACMD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xA87E10", Offset = "0xA86610", VA = "0x180A87E10", Slot = "8")]
	public T CAENJHGBPME<T>(T IIFCAFGLJID, Transform CELKNCFBAOE, bool DHHFGDOACMD = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xA87D00", Offset = "0xA86500", VA = "0x180A87D00", Slot = "9")]
	public T CAENJHGBPME<T>(GameObject IIFCAFGLJID, Transform CELKNCFBAOE, bool DHHFGDOACMD = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4165860", Offset = "0x4164060", VA = "0x184165860", Slot = "10")]
	public GameObject CAENJHGBPME(GameObject IIFCAFGLJID, Transform CELKNCFBAOE, NKDCNPEGJNP IEOIKHEEPLI, bool DHHFGDOACMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xA87D30", Offset = "0xA86530", VA = "0x180A87D30", Slot = "11")]
	public T CAENJHGBPME<T>(GameObject IIFCAFGLJID, Transform CELKNCFBAOE, NKDCNPEGJNP IEOIKHEEPLI, bool DHHFGDOACMD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xA87D80", Offset = "0xA86580", VA = "0x180A87D80", Slot = "12")]
	public T CAENJHGBPME<T>(T IIFCAFGLJID, Transform CELKNCFBAOE, NKDCNPEGJNP IEOIKHEEPLI, bool DHHFGDOACMD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xA877C0", Offset = "0xA85FC0", VA = "0x180A877C0")]
	private T CAENJHGBPME<T>(GameObject IIFCAFGLJID, Transform CELKNCFBAOE, NKDCNPEGJNP IEOIKHEEPLI, bool DHHFGDOACMD, out GameObject EHLHGKMAOAD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA87E80", Offset = "0xA86680", VA = "0x180A87E80")]
	private T PKOCBPMOEIH<T>(GameObject KFNNOPCEBCG, NKDCNPEGJNP IEOIKHEEPLI, bool DHHFGDOACMD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4165B80", Offset = "0x4164380", VA = "0x184165B80")]
	private void MOKHDIENNBA(Component CFCFGDKOLFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4165CA0", Offset = "0x41644A0", VA = "0x184165CA0")]
	private void OIDCDCAFCII(Component CFCFGDKOLFC, NKDCNPEGJNP IEOIKHEEPLI, bool DHHFGDOACMD, [Optional] Type HDOOPBHFACD, [Optional] Type GNAINKOAGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x41659F0", Offset = "0x41641F0", VA = "0x1841659F0")]
	private void KKCMJHDIBIB(GameObject KFNNOPCEBCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct NKDCNPEGJNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private Dictionary<Type, object> HLJNFMLDKKB;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0xDAE730", Offset = "0xDACF30", VA = "0x180DAE730")]
	public NKDCNPEGJNP HEMBJNPDPPJ<T>(T PIBKCCAKALF)
	{
		return default(NKDCNPEGJNP);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA87700", Offset = "0xA85F00", VA = "0x180A87700")]
	public T NOBGIOELFLB<T>(T KKLAFEAHDFJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xFA7C70", Offset = "0xFA6470", VA = "0x180FA7C70")]
	public bool APHJBAJPDLG<T>(out T PIBKCCAKALF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct JOEMJKLDNOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public bool PMILOOPLGJK;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x10CD9C0", Offset = "0x10CC1C0", VA = "0x1810CD9C0")]
	public JOEMJKLDNOJ(bool GJLPECKJDNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct PGHBGIBIPJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly bool NLFBICOIGFH;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4166480", Offset = "0x4164C80", VA = "0x184166480")]
	public PGHBGIBIPJD(bool JOPFJMDMOOO)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x628F80", Offset = "0x627780", VA = "0x180628F80")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ScaleInImposter : MonoBehaviour, PAFNGPMCLOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4166A80", Offset = "0x4165280", VA = "0x184166A80", Slot = "4")]
		public void PrepareImposter(NKDCNPEGJNP IEOIKHEEPLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x628F80", Offset = "0x627780", VA = "0x180628F80")]
		public ScaleInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CreateAssetMenu]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public class LightConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			[Header("Shadows")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x4165600", Offset = "0x4163E00", VA = "0x184165600")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x41655F0", Offset = "0x4163DF0", VA = "0x1841655F0")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[Header("Environment Lighting")]
		[ColorUsage(false, true)]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4165220", Offset = "0x4163A20", VA = "0x184165220")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class HHJLHPFAINN
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<URPLight> IONEOCBOEKC;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly Vector3 NHLIOLBKBHF;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly Vector3 MDDNGGHGPND;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static Camera EDFFLJOIEFA;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public const string MBEIEBPEHJO = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public const AOGGEKMHBLL OHCLMOIEGHK = AOGGEKMHBLL.Water;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static readonly List<Renderer> PIKJJNOGHHK;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static AmbientMode KEILFIHPOFG;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static Color MAFMHKNKKDI;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static Color NPMLOMENIOF;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static Color GHCIBDLDLMC;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static Cubemap ABADPHKDDAK;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static bool ANOLCBHDNGO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static Camera IFGEEJFBEAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4163BC0", Offset = "0x41623C0", VA = "0x184163BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x41637B0", Offset = "0x4161FB0", VA = "0x1841637B0")]
	public static void GFHLNMCIBJC(Vector3 DLKEMHHOJHF, Quaternion GMPGOEPFKDE, ImposterRenderConfig GFCFPLLAONI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4164790", Offset = "0x4162F90", VA = "0x184164790")]
	private static void NDPLPHANJPF(Vector3 DLKEMHHOJHF, Quaternion GMPGOEPFKDE, URPLight PELHLDGFCNK, ImposterRenderConfig.LightConfig JEIKDCBELJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x41646B0", Offset = "0x4162EB0", VA = "0x1841646B0")]
	public static void NCPCCMPELGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4162EE0", Offset = "0x41616E0", VA = "0x184162EE0")]
	private static void CPPLAOJNILP(int CKFFFJCJNKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4164530", Offset = "0x4162D30", VA = "0x184164530")]
	public static void NCCGNILBKNC(ImposterRenderConfig GFCFPLLAONI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4163470", Offset = "0x4161C70", VA = "0x184163470")]
	public static void DJNAIPMHMMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x41642E0", Offset = "0x4162AE0", VA = "0x1841642E0")]
	public static void KMNPHLEBKIA(GameObject DDMNLFCLFPP, RenderTexture MKPDKFFCGAE, ImposterRenderConfig GFCFPLLAONI, ONHFPKFJFOI BFDMOGNJGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4163DC0", Offset = "0x41625C0", VA = "0x184163DC0")]
	private static void KDHHDKBDLLD(GameObject DDMNLFCLFPP, RenderTexture MKPDKFFCGAE, ImposterRenderConfig GFCFPLLAONI, ONHFPKFJFOI BFDMOGNJGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x41631E0", Offset = "0x41619E0", VA = "0x1841631E0")]
	private static void DGGMGPDFLCJ(GameObject DDMNLFCLFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4163A30", Offset = "0x4162230", VA = "0x184163A30")]
	public static void GOEDODEJBAC(List<Renderer> LIKDGEGPGOE, List<Material> KFEJGCCEDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4164AD0", Offset = "0x41632D0", VA = "0x184164AD0")]
	public static void NENOPLPMMNG(GameObject IIFCAFGLJID, Vector3 EKBIPPBBJJN, Vector3 BNIIHCAJMNP, float PKELBIOGCIC, ONHFPKFJFOI BFDMOGNJGBC, out Vector3 GGAFPHIAAIA, out Quaternion PKAEFAJOPIH, out float NGAMHNAFGIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4164490", Offset = "0x4162C90", VA = "0x184164490")]
	public static RenderTexture KOAGDKJEKGP(int AEHBFLGCOBN, int ELIOJOIGIEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4163570", Offset = "0x4161D70", VA = "0x184163570")]
	public static void FEPDEJABINN()
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public struct NBGJBGLAMGJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public CBHCDHNKCAP KNOKDKJNIIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public GameObject AABDBECHBCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public RenderTexture OJDKBCPLINJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public ImposterRenderConfig PAMBGIPCOEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public ONHFPKFJFOI ONHFPKFJFOI;

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x4165620", Offset = "0x4163E20", VA = "0x184165620")]
			public NBGJBGLAMGJ(CBHCDHNKCAP BBCOFFFEBJD, GameObject BHCIPHKEMLC, RenderTexture MKPDKFFCGAE, ImposterRenderConfig MPFALJPAPJJ, ONHFPKFJFOI BFDMOGNJGBC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int KGMDBMAKEFB = 1;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int JICJLFIJBGP = 6;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static global::LJOEHJLDFGB<NBGJBGLAMGJ, RenderTexture> OHFFOMKLANO;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static readonly List<NBGJBGLAMGJ> OGEGJLBEDDJ;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int CIFCCLCOJNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6CC3D0", Offset = "0x6CABD0", VA = "0x1806CC3D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4162A70", Offset = "0x4161270", VA = "0x184162A70")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject DDMNLFCLFPP, RenderTexture MKPDKFFCGAE, ImposterRenderConfig GFCFPLLAONI, ONHFPKFJFOI BFDMOGNJGBC, CancellationToken NFKHAKHIBIO, bool FMFLHKBMKPD = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4162570", Offset = "0x4160D70", VA = "0x184162570", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x41629E0", Offset = "0x41611E0", VA = "0x1841629E0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4162690", Offset = "0x4160E90", VA = "0x184162690")]
		private static Task<RenderTexture> FEDEBIOLKCA(NBGJBGLAMGJ IPCPMANPBND, CancellationToken NFKHAKHIBIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4162E80", Offset = "0x4161680", VA = "0x184162E80")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class PGKFNNKCMAN
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static byte[] EGKMOPGLIPA;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static int JGABFFAEPHC;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static int OCNADIFHHML;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static BigInteger GACCCDCMEHO;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public PGKFNNKCMAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4166490", Offset = "0x4164C90", VA = "0x184166490")]
	private static string HDJAHDEMDDI(byte[] FLEBMPFFCAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4166590", Offset = "0x4164D90", VA = "0x184166590")]
	public static string OMJPKAOBENG(byte[] FCDIIMLAMIO, bool PCFPPGPONLG)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
