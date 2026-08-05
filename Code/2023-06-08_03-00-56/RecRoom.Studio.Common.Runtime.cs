using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class JHEIFJCGNFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Vector3 AIGMHLBKCKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Quaternion EMNOFGLPALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Vector3 HGLPLEFODCG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6EF23D0", Offset = "0x6EF11D0", VA = "0x186EF23D0")]
	public bool LBMEGKCMCKF(Collider DMENEKHAENG, ref Bounds INLPHPEDOPO, bool PDPIAAIBEHF, bool HDLHBAPEIEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6EF28F0", Offset = "0x6EF16F0", VA = "0x186EF28F0")]
	public bool LCIGMEAELIM(Collider GIDHMIEAOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6EF2910", Offset = "0x6EF1710", VA = "0x186EF2910")]
	public bool NAKIMMCHFHN(Collider GIDHMIEAOPG, bool PDPIAAIBEHF, bool HDLHBAPEIEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6EF14C0", Offset = "0x6EF02C0", VA = "0x186EF14C0")]
	public void INJBFHKFKGB(JHEIFJCGNFA FGBEDAPNDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6EF2D40", Offset = "0x6EF1B40", VA = "0x186EF2D40")]
	private static void NNGDBIFCHJK(ref Vector3 DMGBLCHJFOM, ref Vector3 AFEELFFAOPA, Vector3 IHBDKLJGANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6EF1FC0", Offset = "0x6EF0DC0", VA = "0x186EF1FC0")]
	public static JHEIFJCGNFA JEFGGJDKNHE(GameObject BHODGDEIEBD, Quaternion EMNOFGLPALH, bool JMAEPDOIGIO, bool MJJPJMAKBAM, bool PDPIAAIBEHF = false, bool HDLHBAPEIEI = false, bool KCMALOFOKBK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public JHEIFJCGNFA()
	{
	}
}
namespace RecRoom.Core.Studio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x3F46540", Offset = "0x3F45340", VA = "0x183F46540")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8300", Offset = "0x6EF7100", VA = "0x186EF8300")]
		public SerializedGuid(in Guid LOOGPKNLJEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6EF82D0", Offset = "0x6EF70D0", VA = "0x186EF82D0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8230", Offset = "0x6EF7030", VA = "0x186EF8230", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8170", Offset = "0x6EF6F70", VA = "0x186EF8170", Slot = "7")]
		public bool Equals(SerializedGuid FGBEDAPNDEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8090", Offset = "0x6EF6E90", VA = "0x186EF8090", Slot = "0")]
		public override bool Equals(object GNOEFMFMEOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8220", Offset = "0x6EF7020", VA = "0x186EF8220", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8060", Offset = "0x6EF6E60", VA = "0x186EF8060", Slot = "6")]
		public int CompareTo(SerializedGuid FGBEDAPNDEP)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RecRoomAudioClipRegistryAsset : RecRoomStudioBuildAsset<RecRoomAudioClipRegistryAsset>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		internal RecRoomAudioClipEntry[] clips;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public IReadOnlyList<RecRoomAudioClipEntry> Clips
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6EF4E80", Offset = "0x6EF3C80", VA = "0x186EF4E80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4E40", Offset = "0x6EF3C40", VA = "0x186EF4E40")]
		public RecRoomAudioClipRegistryAsset()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class RecRoomAudioClipEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AudioClip Clip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public SerializedGuid UniqueId;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public RecRoomAudioClipEntry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class RecRoomObjectPrefabRegistryAsset : RecRoomStudioBuildAsset<RecRoomObjectPrefabRegistryAsset>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private RecRoomObjectPrefabEntry[] prefabs;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public RecRoomObjectPrefabEntry[] Prefabs
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6EF6860", Offset = "0x6EF5660", VA = "0x186EF6860")]
		public RecRoomObjectPrefabRegistryAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[AddComponentMenu("Rec Room Studio/Rec Room Studio Hud Canvas")]
	[RequireComponent(typeof(Canvas))]
	public class RecRoomStudioHudCanvas : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x98DDD0", Offset = "0x98CBD0", VA = "0x18098DDD0")]
		public RecRoomStudioHudCanvas()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[AddComponentMenu("")]
	public sealed class RecRoomObjectPrefabRegistry : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static RecRoomObjectPrefabRegistry EJBAOAKFGMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		[HideInInspector]
		private RecRoomObjectPrefabEntry[] prefabs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[SerializeField]
		private RecRoomObjectPrefabRegistryAsset prefabsAsset;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static RecRoomObjectPrefabRegistry LNABDBHCENK
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6EF6B60", Offset = "0x6EF5960", VA = "0x186EF6B60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public IReadOnlyList<RecRoomObjectPrefabEntry> KPFPAMDIFIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6EF6AC0", Offset = "0x6EF58C0", VA = "0x186EF6AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6EF68A0", Offset = "0x6EF56A0", VA = "0x186EF68A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6EF6990", Offset = "0x6EF5790", VA = "0x186EF6990")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x98DDD0", Offset = "0x98CBD0", VA = "0x18098DDD0")]
		public RecRoomObjectPrefabRegistry()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class RecRoomObjectPrefabEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public RecRoomObject Prefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public SerializedGuid UniqueId;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public RecRoomObjectPrefabEntry()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.Field)]
public class BAAICAHIGGJ : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6EF0610", Offset = "0x6EEF410", VA = "0x186EF0610")]
	public BAAICAHIGGJ(string LNCLBGGHDHA, bool AJGAJNPFFJP, string CBNCFPKPGLH)
	{
	}
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[AddComponentMenu("")]
	public sealed class RecRoomAudioClipRegistry : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static RecRoomAudioClipRegistry EJBAOAKFGMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		private RecRoomAudioClipRegistryAsset entriesAsset;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static RecRoomAudioClipRegistry LNABDBHCENK
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6EF51B0", Offset = "0x6EF3FB0", VA = "0x186EF51B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RecRoomAudioClipRegistryAsset ELAICJBBNJM
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IReadOnlyList<RecRoomAudioClipEntry> HHNLHIDCCFM
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6EF50F0", Offset = "0x6EF3EF0", VA = "0x186EF50F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4ED0", Offset = "0x6EF3CD0", VA = "0x186EF4ED0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4FC0", Offset = "0x6EF3DC0", VA = "0x186EF4FC0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x98DDD0", Offset = "0x98CBD0", VA = "0x18098DDD0")]
		public RecRoomAudioClipRegistry()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[AttributeUsage(AttributeTargets.Class)]
public class KCICFJGJGNP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8389E0", Offset = "0x8377E0", VA = "0x1808389E0")]
	public KCICFJGJGNP()
	{
	}
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class RecRoomBuiltInObjectData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private RecRoomBuiltInObject[] builtInObjects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private Dictionary<Guid, RecRoomBuiltInObject> lookup;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private Dictionary<Guid, RecRoomBuiltInObject> Lookup
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6EF64E0", Offset = "0x6EF52E0", VA = "0x186EF64E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public IReadOnlyDictionary<Guid, RecRoomBuiltInObject> AllBuiltInObjects
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6EF64D0", Offset = "0x6EF52D0", VA = "0x186EF64D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6EF63E0", Offset = "0x6EF51E0", VA = "0x186EF63E0")]
		public void GMIABJEBAJH(IEnumerable<RecRoomBuiltInObject> MNKEGEDJNGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6EF6450", Offset = "0x6EF5250", VA = "0x186EF6450")]
		public bool NENMDMPJEFC(Guid OCFEBKDAIIH, out RecRoomBuiltInObject PAGNMMOKMGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xD69BC0", Offset = "0xD689C0", VA = "0x180D69BC0")]
		public RecRoomBuiltInObjectData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum EKDPLNCOPCC
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Prop,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Gadget
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[AddComponentMenu("")]
	public class MaterialMap : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public class TextureProperty
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public Texture value;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public class FloatProperty
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public float value;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public class VectorProperty
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public Vector4 value;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public class ColorProperty
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public Color value;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public class MaterialEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public Material material;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public string shaderName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public MaterialGlobalIlluminationFlags globalIlluminationFlags;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public int renderQueue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public bool doubleSidedGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public TextureProperty[] texProps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public FloatProperty[] floatProps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public VectorProperty[] vecProps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public ColorProperty[] colorProps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private Dictionary<string, float> floatPropsDict;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private Dictionary<int, float> floatPropIdDict;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private Dictionary<int, Texture> texPropIdDict;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			private Dictionary<int, Vector4> vecPropIdDict;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private Dictionary<int, Color> colorPropIdDict;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6EF2FB0", Offset = "0x6EF1DB0", VA = "0x186EF2FB0")]
			public void ECFAKADHIPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6EF2F40", Offset = "0x6EF1D40", VA = "0x186EF2F40")]
			public float BHCCCDICCCJ(string PPPOJKMOIGD)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6EF2ED0", Offset = "0x6EF1CD0", VA = "0x186EF2ED0")]
			public float BHCCCDICCCJ(int BOKNODKDNKE)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6EF35F0", Offset = "0x6EF23F0", VA = "0x186EF35F0")]
			public Texture PEBCAFOBGLG(int BOKNODKDNKE)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6EF34D0", Offset = "0x6EF22D0", VA = "0x186EF34D0")]
			public Vector4 KDLDCJCKLCH(int BOKNODKDNKE)
			{
				return default(Vector4);
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6EF3560", Offset = "0x6EF2360", VA = "0x186EF3560")]
			public Color NKKPHHHCNIF(int BOKNODKDNKE)
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static MaterialMap EJBAOAKFGMC;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<MaterialEntry> FGOFBJHMMED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		[HideInInspector]
		private MaterialEntry[] entries;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private MaterialMapAsset entriesAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private Dictionary<Material, MaterialEntry> MDFHDDONOBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private HashSet<Material> NLMACPBLEAL;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static MaterialMap LNABDBHCENK
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6EF3C50", Offset = "0x6EF2A50", VA = "0x186EF3C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public MaterialEntry[] ELAICJBBNJM
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6EF3BC0", Offset = "0x6EF29C0", VA = "0x186EF3BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6EF36A0", Offset = "0x6EF24A0", VA = "0x186EF36A0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3B20", Offset = "0x6EF2920", VA = "0x186EF3B20")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3AB0", Offset = "0x6EF28B0", VA = "0x186EF3AB0")]
		public MaterialEntry GetEntryForMaterial(Material NEOHGOGPALD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3910", Offset = "0x6EF2710", VA = "0x186EF3910")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x98DDD0", Offset = "0x98CBD0", VA = "0x18098DDD0")]
		public MaterialMap()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[AddComponentMenu("")]
	public sealed class RecRoomAudioMixerRegistry : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public enum GKDCLIAFCFK
		{
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			SeparateMixers,
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			SingleMixer
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public enum BJBHEIFMCBB
		{
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			Ambience,
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			Music,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			Sounds,
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			Voice,
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			Voice_LowPitch,
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			Voice_HighPitch,
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			Voice_Radio,
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			Voice_Radio_LowPitch,
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			Voice_Radio_HighPitch
		}

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static readonly Dictionary<BJBHEIFMCBB, string> HJKCKIBOPJK;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const string MusicName = "Music";

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public const string AmbienceName = "Ambience";

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public const string SoundsName = "Sounds";

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private const string ANLBGEOJEMO = "Assets";

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private const string GJDIEECJABH = "RecRoomStudio";

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private const string OMPDFDDGMJI = "Audio";

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly string CLDBNPELIDL;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static readonly string OFAOJMAAPNP;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static RecRoomAudioMixerRegistry EJBAOAKFGMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[JKCCHBDBLCH]
		[SerializeField]
		private GKDCLIAFCFK version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		[BGIKKFCOFAN("version", 0, false)]
		private AudioMixer music;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		[BGIKKFCOFAN("version", 0, false)]
		private AudioMixer ambience;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		[BGIKKFCOFAN("version", 0, false)]
		private AudioMixer sounds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		[BGIKKFCOFAN("version", 1, false)]
		private AudioMixer studioMixer;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static RecRoomAudioMixerRegistry LNABDBHCENK
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6EF6160", Offset = "0x6EF4F60", VA = "0x186EF6160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public AudioMixer PCBOKPCGLBL
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8204A0", Offset = "0x81F2A0", VA = "0x1808204A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool PDHBIJBGJPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6EF61C0", Offset = "0x6EF4FC0", VA = "0x186EF61C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public GKDCLIAFCFK MKCLCLCLGPO
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x86DAD0", Offset = "0x86C8D0", VA = "0x18086DAD0")]
			get
			{
				return default(GKDCLIAFCFK);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6EF6330", Offset = "0x6EF5130", VA = "0x186EF6330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5560", Offset = "0x6EF4360", VA = "0x186EF5560")]
		public static string GetAudioGroupPath(BJBHEIFMCBB MGEJIPALLKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5680", Offset = "0x6EF4480", VA = "0x186EF5680")]
		public AudioMixerGroup GetMixerGroup(BJBHEIFMCBB MGEJIPALLKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5320", Offset = "0x6EF4120", VA = "0x186EF5320")]
		private static AudioMixerGroup BPPBGINNGNO(AudioMixer HFODOAJFIIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6EF51F0", Offset = "0x6EF3FF0", VA = "0x186EF51F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5D50", Offset = "0x6EF4B50", VA = "0x186EF5D50")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5AF0", Offset = "0x6EF48F0", VA = "0x186EF5AF0")]
		public bool IsValidOutputGroup(AudioMixerGroup JPKPFLMKOPF, out string JKCLFNEEMGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6EF53D0", Offset = "0x6EF41D0", VA = "0x186EF53D0")]
		private bool CKBENOEDALI(AudioMixerGroup JPKPFLMKOPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5870", Offset = "0x6EF4670", VA = "0x186EF5870")]
		private bool IFBCCFNLJIP(AudioMixerGroup NEBLBIKEMBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x98DDD0", Offset = "0x98CBD0", VA = "0x18098DDD0")]
		public RecRoomAudioMixerRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[RequireComponent(typeof(Canvas))]
	[AddComponentMenu("Rec Room Studio/Rec Room Studio Canvas Interaction")]
	public sealed class RecRoomStudioCanvasInteraction : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[SerializeField]
		[Tooltip("Allows the player to interact with elements on the canvas directly")]
		private bool isInteractable;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool JIALOHKBKAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x935A20", Offset = "0x934820", VA = "0x180935A20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x17A0290", Offset = "0x179F090", VA = "0x1817A0290")]
		public RecRoomStudioCanvasInteraction()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface BHGEOEDFCIL
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	AudioMixerGroup MKFJKLAIILL
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	BHGEOEDFCIL ELDFLCOHEBO
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	IReadOnlyList<BHGEOEDFCIL> JPOCNGPAMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string OAJNBCAMANF
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class HGOCPFEKDCO
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class GLMHBGFMHMI : BHGEOEDFCIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal readonly List<BHGEOEDFCIL> ABCBHLNMKBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal readonly GLMHBGFMHMI ANLOMPAGGBM;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public BHGEOEDFCIL ELDFLCOHEBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public AudioMixerGroup MKFJKLAIILL
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8FAD40", Offset = "0x8F9B40", VA = "0x1808FAD40", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyList<BHGEOEDFCIL> JPOCNGPAMHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public string OAJNBCAMANF
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x81B570", Offset = "0x81A370", VA = "0x18081B570", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6EF0720", Offset = "0x6EEF520", VA = "0x186EF0720")]
		internal GLMHBGFMHMI(AudioMixerGroup LMNBADHDHAF, GLMHBGFMHMI GMBPOBACJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x81B570", Offset = "0x81A370", VA = "0x18081B570", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public BHGEOEDFCIL KEIBDHMDJNC
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public AudioMixer JFLGGCCDMIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6EF0830", Offset = "0x6EEF630", VA = "0x186EF0830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8FF650", Offset = "0x8FE450", VA = "0x1808FF650")]
	private HGOCPFEKDCO(GLMHBGFMHMI PACFCBLGFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6EF0910", Offset = "0x6EEF710", VA = "0x186EF0910")]
	public static HGOCPFEKDCO PIBIEGHCHEC(AudioMixer HFODOAJFIIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6EF0E50", Offset = "0x6EEFC50", VA = "0x186EF0E50")]
	public BHGEOEDFCIL PKBHNNENEBI(string IICHAOLBDGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6EF0C10", Offset = "0x6EEFA10", VA = "0x186EF0C10")]
	public BHGEOEDFCIL PKBHNNENEBI(AudioMixerGroup LMNBADHDHAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6EF0890", Offset = "0x6EEF690", VA = "0x186EF0890")]
	private static int HDKJGAOHEKF(string EMNEBALMLGH, int IOEACHBFFDL)
	{
		return default(int);
	}
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[AddComponentMenu("")]
	public sealed class RecRoomVisualPostProcessing : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		[JKCCHBDBLCH]
		public VolumeProfile PostProcessingProfile;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static RecRoomVisualPostProcessing EJBAOAKFGMC;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static RecRoomVisualPostProcessing LNABDBHCENK
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6EF8020", Offset = "0x6EF6E20", VA = "0x186EF8020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7DE0", Offset = "0x6EF6BE0", VA = "0x186EF7DE0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7ED0", Offset = "0x6EF6CD0", VA = "0x186EF7ED0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x98DDD0", Offset = "0x98CBD0", VA = "0x18098DDD0")]
		public RecRoomVisualPostProcessing()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public sealed class RecRoomObjectProperty
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			Hide
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		private string propertyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		private RecRoomObjectPropertyAccessor propertyAccessor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[SerializeField]
		private BoardConfig boardConfig;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public string PropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5DC2850", Offset = "0x5DC1650", VA = "0x185DC2850")]
		public bool NENMDMPJEFC<T>(out T KKLNCEHOHED, out string JKCLFNEEMGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6EF6D80", Offset = "0x6EF5B80", VA = "0x186EF6D80")]
		public static string NCOCJHADAMO(Type FHCFEADADAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public RecRoomObjectProperty()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[AddComponentMenu("")]
	public class RecRoomBuiltInObject : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[SerializeField]
		[HideInInspector]
		private SerializedGuid prefabId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[JKCCHBDBLCH]
		[SerializeField]
		private string friendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[JKCCHBDBLCH]
		[SerializeField]
		private EKDPLNCOPCC category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[SerializeField]
		[HideInInspector]
		private byte[] spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[SerializeField]
		[JKCCHBDBLCH]
		private bool availableInMakerPen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[SerializeField]
		[JKCCHBDBLCH]
		private bool isBetaItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[HideInInspector]
		[SerializeField]
		private bool availableToDevsOnly;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Guid MLLEGPPHODO
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6EF6730", Offset = "0x6EF5530", VA = "0x186EF6730")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6EF67D0", Offset = "0x6EF55D0", VA = "0x186EF67D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string EKLOELJJDOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8FAD40", Offset = "0x8F9B40", VA = "0x1808FAD40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x903350", Offset = "0x902150", VA = "0x180903350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public EKDPLNCOPCC FGCOGMKJMDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x93D1F0", Offset = "0x93BFF0", VA = "0x18093D1F0")]
			get
			{
				return default(EKDPLNCOPCC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8FE380", Offset = "0x8FD180", VA = "0x1808FE380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool PLBBPDFDIHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x9D8000", Offset = "0x9D6E00", VA = "0x1809D8000")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x9D7FF0", Offset = "0x9D6DF0", VA = "0x1809D7FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool OOJDNOGKAAB
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xEA1C40", Offset = "0xEA0A40", VA = "0x180EA1C40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x11DE290", Offset = "0x11DD090", VA = "0x1811DE290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool AFNAIFCPAEO
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x18A9F10", Offset = "0x18A8D10", VA = "0x1818A9F10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x1207E20", Offset = "0x1206C20", VA = "0x181207E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool EDHEAHNHPKO
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6EF6710", Offset = "0x6EF5510", VA = "0x186EF6710")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool OHGJFJNCKKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x6EF66C0", Offset = "0x6EF54C0", VA = "0x186EF66C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6EF6680", Offset = "0x6EF5480", VA = "0x186EF6680")]
		public byte[] GetSpawnableTemplateDataCopy()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x952E30", Offset = "0x951C30", VA = "0x180952E30")]
		public void SetSpawnableTemplateData(byte[] LCOOFFMHMKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9A4910", Offset = "0x9A3710", VA = "0x1809A4910")]
		public void ClearSpawnableTemplateData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x98DDD0", Offset = "0x98CBD0", VA = "0x18098DDD0")]
		public RecRoomBuiltInObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class RecRoomStudioBuildAsset<AssetType> : ScriptableObject where AssetType : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x331A810", Offset = "0x3319610", VA = "0x18331A810")]
		public RecRoomStudioBuildAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[KCICFJGJGNP]
	[DisallowMultipleComponent]
	[AddComponentMenu("Rec Room Studio/Rec Room Object")]
	public sealed class RecRoomObject : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class <GetEventsWithName>d__26 : IEnumerable<NamedUnityEventBase>, IEnumerable, IEnumerator<NamedUnityEventBase>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private NamedUnityEventBase <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private string eventName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public string <>3__eventName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public RecRoomObject <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private NamedUnityEventBase[] <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private int <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private NamedUnityEventBase <e>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			NamedUnityEventBase IEnumerator<NamedUnityEventBase>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xD2EFB0", Offset = "0xD2DDB0", VA = "0x180D2EFB0")]
			[DebuggerHidden]
			public <GetEventsWithName>d__26(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x6EF8330", Offset = "0x6EF7130", VA = "0x186EF8330", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x6EF8500", Offset = "0x6EF7300", VA = "0x186EF8500", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6EF8450", Offset = "0x6EF7250", VA = "0x186EF8450", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<NamedUnityEventBase> IEnumerable<NamedUnityEventBase>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x6EF8450", Offset = "0x6EF7250", VA = "0x186EF8450", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		private RecRoomObjectConfiguration defaultConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[HideInInspector]
		[SerializeField]
		internal RecRoomObjectProperty[] properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[HideInInspector]
		[SerializeReference]
		internal NamedUnityEventBase[] unityEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private Dictionary<string, RecRoomObjectProperty> propertyLookup;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public RecRoomObjectProperty[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x8FAD40", Offset = "0x8F9B40", VA = "0x1808FAD40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public NamedUnityEventBase[] UnityEvents
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x81B570", Offset = "0x81A370", VA = "0x18081B570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public RecRoomObjectConfiguration DefaultConfiguration
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6EF7C40", Offset = "0x6EF6A40", VA = "0x186EF7C40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<RecRoomObject, string> OnSendCircuitsEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x6EF7BA0", Offset = "0x6EF69A0", VA = "0x186EF7BA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6EF7CC0", Offset = "0x6EF6AC0", VA = "0x186EF7CC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7020", Offset = "0x6EF5E20", VA = "0x186EF7020")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6EF72E0", Offset = "0x6EF60E0", VA = "0x186EF72E0")]
		public bool TryGetProperty(string propertyName, out RecRoomObjectProperty property)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6EF75A0", Offset = "0x6EF63A0", VA = "0x186EF75A0")]
		public bool TryRaiseUnityEvent(string eventName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6EF70C0", Offset = "0x6EF5EC0", VA = "0x186EF70C0")]
		public void SendCircuitsEvent(string eventName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5DC4660", Offset = "0x5DC3460", VA = "0x185DC4660")]
		private bool TryRaiseUnityEvent<T0, T1, TEvent>(string eventName, T0 value0, T1 value1) where TEvent : UnityEvent<T0, T1>, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7900", Offset = "0x6EF6700", VA = "0x186EF7900")]
		public bool TryRaiseUnityEvent(string eventName, bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7AC0", Offset = "0x6EF68C0", VA = "0x186EF7AC0")]
		public bool TryRaiseUnityEvent(string eventName, float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7740", Offset = "0x6EF6540", VA = "0x186EF7740")]
		public bool TryRaiseUnityEvent(string eventName, int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6EF74C0", Offset = "0x6EF62C0", VA = "0x186EF74C0")]
		public bool TryRaiseUnityEvent(string eventName, string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6EF79E0", Offset = "0x6EF67E0", VA = "0x186EF79E0")]
		public bool TryRaiseUnityEvent(string eventName, string value0, bool value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7890", Offset = "0x6EF6690", VA = "0x186EF7890")]
		public bool TryRaiseUnityEvent(string eventName, string value0, float value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7820", Offset = "0x6EF6620", VA = "0x186EF7820")]
		public bool TryRaiseUnityEvent(string eventName, string value0, int value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7A50", Offset = "0x6EF6850", VA = "0x186EF7A50")]
		public bool TryRaiseUnityEvent(string eventName, string value0, string value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6EF6F90", Offset = "0x6EF5D90", VA = "0x186EF6F90")]
		[IteratorStateMachine(typeof(<GetEventsWithName>d__26))]
		private IEnumerable<NamedUnityEventBase> GetEventsWithName(string eventName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7120", Offset = "0x6EF5F20", VA = "0x186EF7120")]
		private bool TryFindAndInvoke(string eventName, Func<NamedUnityEventBase, bool> invoke)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x98DDD0", Offset = "0x98CBD0", VA = "0x18098DDD0")]
		public RecRoomObject()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public abstract class NamedUnityEventBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		private string eventName;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void InvokeEvent();

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x81CAB0", Offset = "0x81B8B0", VA = "0x18081CAB0", Slot = "5")]
		public virtual bool TryInvokeEvent(bool KKLNCEHOHED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x81CAB0", Offset = "0x81B8B0", VA = "0x18081CAB0", Slot = "6")]
		public virtual bool TryInvokeEvent(float KKLNCEHOHED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x81CAB0", Offset = "0x81B8B0", VA = "0x18081CAB0", Slot = "7")]
		public virtual bool TryInvokeEvent(int KKLNCEHOHED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x81CAB0", Offset = "0x81B8B0", VA = "0x18081CAB0", Slot = "8")]
		public virtual bool TryInvokeEvent(string KKLNCEHOHED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		protected NamedUnityEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public abstract class NamedUnityEventBase<TUnityEvent> : NamedUnityEventBase where TUnityEvent : UnityEventBase, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[SerializeField]
		private TUnityEvent unityEvent;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public TUnityEvent Event
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x4F41CF0", Offset = "0x4F40AF0", VA = "0x184F41CF0")]
		protected NamedUnityEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public sealed class UnityBooleanEvent : UnityEvent<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8730", Offset = "0x6EF7530", VA = "0x186EF8730")]
		public UnityBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public sealed class UnityFloatEvent : UnityEvent<float>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8770", Offset = "0x6EF7570", VA = "0x186EF8770")]
		public UnityFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public sealed class UnityIntEvent : UnityEvent<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6EF87B0", Offset = "0x6EF75B0", VA = "0x186EF87B0")]
		public UnityIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public sealed class UnityStringEvent : UnityEvent<string>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8830", Offset = "0x6EF7630", VA = "0x186EF8830")]
		public UnityStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public sealed class UnityStringBooleanEvent : UnityEvent<string, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6EF87F0", Offset = "0x6EF75F0", VA = "0x186EF87F0")]
		public UnityStringBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public sealed class UnityStringIntEvent : UnityEvent<string, int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6EF88B0", Offset = "0x6EF76B0", VA = "0x186EF88B0")]
		public UnityStringIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public sealed class UnityStringFloatEvent : UnityEvent<string, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8870", Offset = "0x6EF7670", VA = "0x186EF8870")]
		public UnityStringFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class UnityStringStringEvent : UnityEvent<string, string>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6EF88F0", Offset = "0x6EF76F0", VA = "0x186EF88F0")]
		public UnityStringStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[KCICFJGJGNP]
	[Preserve]
	public sealed class NamedUnityEvent : NamedUnityEventBase<UnityEvent>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			Hide
		}

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3E90", Offset = "0x6EF2C90", VA = "0x186EF3E90", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3F50", Offset = "0x6EF2D50", VA = "0x186EF3F50")]
		public NamedUnityEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[KCICFJGJGNP]
	[Preserve]
	public abstract class OneParamNamedUnityEvent<TUnityEvent> : NamedUnityEventBase<TUnityEvent> where TUnityEvent : UnityEventBase, new()
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			Hide,
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			HideParam
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x1C4E3D0", Offset = "0x1C4D1D0", VA = "0x181C4E3D0")]
		protected OneParamNamedUnityEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[KCICFJGJGNP]
	[Preserve]
	public abstract class TwoParamNamedUnityEvent<TUnityEvent> : NamedUnityEventBase<TUnityEvent> where TUnityEvent : UnityEventBase, new()
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			Hide,
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			HideParam1,
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			HideBothParams
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[SerializeField]
		protected string defaultValue1;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x1C4E3D0", Offset = "0x1C4D1D0", VA = "0x181C4E3D0")]
		protected TwoParamNamedUnityEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[Preserve]
	[KCICFJGJGNP]
	public sealed class NamedUnityBooleanEvent : OneParamNamedUnityEvent<UnityBooleanEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[SerializeField]
		private bool defaultValue;

		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3C90", Offset = "0x6EF2A90", VA = "0x186EF3C90", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3CF0", Offset = "0x6EF2AF0", VA = "0x186EF3CF0", Slot = "5")]
		public override bool TryInvokeEvent(bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3E50", Offset = "0x6EF2C50", VA = "0x186EF3E50")]
		public NamedUnityBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[KCICFJGJGNP]
	[Preserve]
	public sealed class NamedUnityFloatEvent : OneParamNamedUnityEvent<UnityFloatEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[SerializeField]
		private float defaultValue;

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3F90", Offset = "0x6EF2D90", VA = "0x186EF3F90", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3FF0", Offset = "0x6EF2DF0", VA = "0x186EF3FF0", Slot = "6")]
		public override bool TryInvokeEvent(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4150", Offset = "0x6EF2F50", VA = "0x186EF4150")]
		public NamedUnityFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[KCICFJGJGNP]
	[Preserve]
	public sealed class NamedUnityIntEvent : OneParamNamedUnityEvent<UnityIntEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[SerializeField]
		private int defaultValue;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4190", Offset = "0x6EF2F90", VA = "0x186EF4190", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6EF41F0", Offset = "0x6EF2FF0", VA = "0x186EF41F0", Slot = "7")]
		public override bool TryInvokeEvent(int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4350", Offset = "0x6EF3150", VA = "0x186EF4350")]
		public NamedUnityIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[KCICFJGJGNP]
	[Preserve]
	public sealed class NamedUnityStringEvent : OneParamNamedUnityEvent<UnityStringEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		private string defaultValue;

		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6EF45C0", Offset = "0x6EF33C0", VA = "0x186EF45C0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4620", Offset = "0x6EF3420", VA = "0x186EF4620", Slot = "8")]
		public override bool TryInvokeEvent(string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4780", Offset = "0x6EF3580", VA = "0x186EF4780")]
		public NamedUnityStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[KCICFJGJGNP]
	[Preserve]
	public sealed class NamedUnityStringBooleanEvent : TwoParamNamedUnityEvent<UnityStringBooleanEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[SerializeField]
		private bool defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4390", Offset = "0x6EF3190", VA = "0x186EF4390", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6EF43F0", Offset = "0x6EF31F0", VA = "0x186EF43F0", Slot = "5")]
		public override bool TryInvokeEvent(bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4580", Offset = "0x6EF3380", VA = "0x186EF4580")]
		public NamedUnityStringBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[KCICFJGJGNP]
	[Preserve]
	public sealed class NamedUnityStringFloatEvent : TwoParamNamedUnityEvent<UnityStringFloatEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[SerializeField]
		private float defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6EF47C0", Offset = "0x6EF35C0", VA = "0x186EF47C0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4820", Offset = "0x6EF3620", VA = "0x186EF4820", Slot = "6")]
		public override bool TryInvokeEvent(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6EF49B0", Offset = "0x6EF37B0", VA = "0x186EF49B0")]
		public NamedUnityStringFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[KCICFJGJGNP]
	[Preserve]
	public sealed class NamedUnityStringIntEvent : TwoParamNamedUnityEvent<UnityStringIntEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[SerializeField]
		private int defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6EF49F0", Offset = "0x6EF37F0", VA = "0x186EF49F0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4A50", Offset = "0x6EF3850", VA = "0x186EF4A50", Slot = "7")]
		public override bool TryInvokeEvent(int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4BE0", Offset = "0x6EF39E0", VA = "0x186EF4BE0")]
		public NamedUnityStringIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[Preserve]
	[KCICFJGJGNP]
	public sealed class NamedUnityStringStringEvent : TwoParamNamedUnityEvent<UnityStringStringEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[SerializeField]
		private string defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4C20", Offset = "0x6EF3A20", VA = "0x186EF4C20", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4C80", Offset = "0x6EF3A80", VA = "0x186EF4C80", Slot = "8")]
		public override bool TryInvokeEvent(string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4E00", Offset = "0x6EF3C00", VA = "0x186EF4E00")]
		public NamedUnityStringStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class RecRoomObjectPropertyAccessor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public UnityEngine.Object target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public string targetAssemblyTypeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public string propertyMethodName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private MethodInfo cachedTargetMethod;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private string FormattedPropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x6EF6D10", Offset = "0x6EF5B10", VA = "0x186EF6D10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6EF6CA0", Offset = "0x6EF5AA0", VA = "0x186EF6CA0")]
		public MethodInfo OANONEMGFPG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6EF6BA0", Offset = "0x6EF59A0", VA = "0x186EF6BA0")]
		public string JPJCLLFLJMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public RecRoomObjectPropertyAccessor()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct NFMCEHMNLJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public byte[] CMDEFNMIHDC;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0xD2AC10", Offset = "0xD29A10", VA = "0x180D2AC10")]
	public NFMCEHMNLJE(byte[] GNCDGJDGENH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct CNMLFFPNJBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public byte[] CMDEFNMIHDC;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0xD2AC10", Offset = "0xD29A10", VA = "0x180D2AC10")]
	public CNMLFFPNJBL(byte[] GNCDGJDGENH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class ILFDIKLANAE
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6EF1300", Offset = "0x6EF0100", VA = "0x186EF1300")]
	public static (NFMCEHMNLJE, CNMLFFPNJBL) MMPDIPMJACM(Stream LHFNIFCKGEK)
	{
		return default((NFMCEHMNLJE, CNMLFFPNJBL));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6EF11B0", Offset = "0x6EEFFB0", VA = "0x186EF11B0")]
	public static void AGGOEKEFCGJ(Stream LHFNIFCKGEK, NFMCEHMNLJE ODBMILJBDKN, CNMLFFPNJBL OIAFMJFBNPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public enum FEHCKGOHLGC : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	WindowsDesktop,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	MobileIOS,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	MobileAndroid,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	OculusQuest,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	XboxOne,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Playstation4,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	Playstation5
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[AttributeUsage(AttributeTargets.Field)]
public class JKCCHBDBLCH : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x9B3AA0", Offset = "0x9B28A0", VA = "0x1809B3AA0")]
	public JKCCHBDBLCH()
	{
	}
}
namespace RecRoom.Core.Studio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class RecRoomStudioChipMetadata : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct IndividualChipMetadata
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			[HideInInspector]
			[SerializeField]
			private SerializedGuid guid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			[SerializeField]
			public string ClassName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			[SerializeField]
			public string FriendlyName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			[SerializeField]
			public string Description;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			[SerializeField]
			public List<string> Filters;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			[SerializeField]
			public bool IsBetaChip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			[SerializeField]
			public bool IsHiddenInPalette;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			[SerializeField]
			public bool IsDevChip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			[SerializeField]
			public bool IsStudioChip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			[SerializeField]
			public bool IsTrollingRisk;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			[SerializeField]
			public bool IsRoleAssignmentRisk;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			[SerializeField]
			public List<PortDesc> InputPorts;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			[SerializeField]
			public List<PortDesc> OutputPorts;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public struct PortDesc
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			[SerializeField]
			public string Name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			[SerializeField]
			public string Type;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[SerializeField]
		public List<IndividualChipMetadata> MetadataList;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7D60", Offset = "0x6EF6B60", VA = "0x186EF7D60")]
		public RecRoomStudioChipMetadata()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public enum FDCNBGNOPAN
{
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	Environment = 0,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	Decoration = 1,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	Physical = 4
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public enum GDEEBLPELJM
{
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Environment = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	Decoration = 1,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	Physical_Sticky = 2,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	Physical = 4
}
namespace RecRoom.Core.Studio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public class RecRoomObjectConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		[JKCCHBDBLCH]
		[SerializeField]
		private bool isBuiltInObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		[SerializeField]
		[Header("Basic Interactions")]
		private bool isFrozen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		[SerializeField]
		[BAAICAHIGGJ("isClimbable", false, "Is Grabbable can only be enabled if Is Climbable is not enabled")]
		private bool isGrabbable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[SerializeField]
		[BAAICAHIGGJ("isGrabbable", false, "Is Climbable can only be enabled if Is Grabbable is not enabled")]
		private bool isClimbable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		[SerializeField]
		private bool supportsWallRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		[SerializeField]
		private bool supportsClambering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		[SerializeField]
		[Header("Physics")]
		[KPMKDLIIFEJ("isBuiltInObject", false, false)]
		private FDCNBGNOPAN physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		[SerializeField]
		[KPMKDLIIFEJ("isShapeContainer", true, false)]
		private GDEEBLPELJM shapePhysicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		[HideInInspector]
		[SerializeField]
		private bool isShapeContainer;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool IsBuiltInObject
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x8040B0", Offset = "0x802EB0", VA = "0x1808040B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6EF6840", Offset = "0x6EF5640", VA = "0x186EF6840")]
		public RecRoomObjectConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public abstract class CODBHCPFABD : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6EF06D0", Offset = "0x6EEF4D0", VA = "0x186EF06D0")]
	protected CODBHCPFABD(string LNCLBGGHDHA, bool NCMJFNEGFHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[AttributeUsage(AttributeTargets.Field)]
public class KPMKDLIIFEJ : CODBHCPFABD
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6EF2E70", Offset = "0x6EF1C70", VA = "0x186EF2E70")]
	public KPMKDLIIFEJ(string LNCLBGGHDHA, bool AJGAJNPFFJP, bool NCMJFNEGFHA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[AttributeUsage(AttributeTargets.Field)]
public class BGIKKFCOFAN : CODBHCPFABD
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6EF0670", Offset = "0x6EEF470", VA = "0x186EF0670")]
	public BGIKKFCOFAN(string LNCLBGGHDHA, int AJGAJNPFFJP, bool NCMJFNEGFHA = false)
	{
	}
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class MaterialMapAsset : RecRoomStudioBuildAsset<MaterialMapAsset>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[SerializeField]
		private MaterialMap.MaterialEntry[] entries;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MaterialMap.MaterialEntry[] Entries
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x12E79C0", Offset = "0x12E67C0", VA = "0x1812E79C0")]
		public void DJCLOIMJOMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3660", Offset = "0x6EF2460", VA = "0x186EF3660")]
		public MaterialMapAsset()
		{
		}
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
