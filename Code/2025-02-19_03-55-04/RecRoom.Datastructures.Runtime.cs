using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecRoom.Attributes;
using RecRoom.Core.DataStructures;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7475E40", Offset = "0x7474A40", VA = "0x187475E40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9836D0", Offset = "0x9822D0", VA = "0x1809836D0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x983710", Offset = "0x982310", VA = "0x180983710")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class OCFEEFAGLHF : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1DE31B0", Offset = "0x1DE1DB0", VA = "0x181DE31B0")]
	public OCFEEFAGLHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, GIMKAEOLMJJ, NOHNEKNBLCP, ISerializationCallbackReceiver
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[SerializeField]
	private byte[] stableHash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	private byte[] seed;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public byte[] StableHash
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x957510", Offset = "0x956110", VA = "0x180957510", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x957550", Offset = "0x956150", VA = "0x180957550", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x957500", Offset = "0x956100", VA = "0x180957500", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB17D80", Offset = "0xB16980", VA = "0x180B17D80", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash DGGBCMIMPNF);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xA4A930", Offset = "0xA49530", VA = "0x180A4A930")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[ReadOnlyField]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[ReadOnlyField]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7478080", Offset = "0x7476C80", VA = "0x187478080")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7478040", Offset = "0x7476C40", VA = "0x187478040")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x74780C0", Offset = "0x7476CC0", VA = "0x1874780C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7478270", Offset = "0x7476E70", VA = "0x187478270")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x74781E0", Offset = "0x7476DE0", VA = "0x1874781E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xD69C10", Offset = "0xD68810", VA = "0x180D69C10")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xBE6C40", Offset = "0xBE5840", VA = "0x180BE6C40")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7478000", Offset = "0x7476C00", VA = "0x187478000")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7478150", Offset = "0x7476D50", VA = "0x187478150")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7477C50", Offset = "0x7476850", VA = "0x187477C50")]
	public void CopyBounds(SavedExtents PELBNOCGOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7477F50", Offset = "0x7476B50", VA = "0x187477F50")]
	public void SetLocalSpaceBounds(Bounds NAIPIAHMHAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x11DD8C0", Offset = "0x11DC4C0", VA = "0x1811DD8C0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7477F40", Offset = "0x7476B40", VA = "0x187477F40")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7477460", Offset = "0x7476060", VA = "0x187477460")]
	private void AFENOEMMLCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7477D40", Offset = "0x7476940", VA = "0x187477D40")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7477610", Offset = "0x7476210", VA = "0x187477610")]
	public static void CalculateLocalBoundsFor(GameObject PHPLOOLODCB, [Out] Bounds NAIPIAHMHAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7477C80", Offset = "0x7476880", VA = "0x187477C80")]
	private static void KBJLNEOHOKC(Bounds LJEHMGANCNG, Color NFEBCHCLBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7477F70", Offset = "0x7476B70", VA = "0x187477F70")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9571A0", Offset = "0x955DA0", VA = "0x1809571A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x95DED0", Offset = "0x95CAD0", VA = "0x18095DED0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x166AEE0", Offset = "0x1669AE0", VA = "0x18166AEE0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5285010", Offset = "0x5283C10", VA = "0x185285010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "4")]
	public virtual void HHLIPDJOHCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[OCFEEFAGLHF]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5284B40", Offset = "0x5283740", VA = "0x185284B40", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5283620", Offset = "0x5282220", VA = "0x185283620", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5284F20", Offset = "0x5283B20", VA = "0x185284F20")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class KNNPHPAGBAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public KNNPHPAGBAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4A826A0", Offset = "0x4A812A0", VA = "0x184A826A0")]
		internal int EKOKHHKAPII(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[OCFEEFAGLHF]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4010E50", Offset = "0x400FA50", VA = "0x184010E50", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4010EB0", Offset = "0x400FAB0", VA = "0x184010EB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4010D20", Offset = "0x400F920", VA = "0x184010D20", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey NKANGPLHEGE]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4010DE0", Offset = "0x400F9E0", VA = "0x184010DE0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4010BC0", Offset = "0x400F7C0", VA = "0x184010BC0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4010840", Offset = "0x400F440", VA = "0x184010840", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x400FBB0", Offset = "0x400E7B0", VA = "0x18400FBB0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x400FB80", Offset = "0x400E780", VA = "0x18400FB80", Slot = "14")]
	protected virtual string OELHMAMICDI(TKeyVal CHENLDDPOOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x400FA10", Offset = "0x400E610", VA = "0x18400FA10", Slot = "4")]
	public bool ContainsKey(TKey NKANGPLHEGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4010A30", Offset = "0x400F630", VA = "0x184010A30", Slot = "5")]
	public bool TryGetValue(TKey NKANGPLHEGE, [Out] TVal MPDLOLIOGJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x400FA70", Offset = "0x400E670", VA = "0x18400FA70", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x400FA70", Offset = "0x400E670", VA = "0x18400FA70", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4010A90", Offset = "0x400F690", VA = "0x184010A90")]
	protected EditableSerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class SerializedReferenceKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[SerializeField]
	[SerializeReference]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x957520", Offset = "0x956120", VA = "0x180957520")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x957510", Offset = "0x956110", VA = "0x180957510")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	protected SerializedReferenceKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class SerializedReferenceDictionary<TKey, TVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private class SerializedReferenceKeyValuePair : SerializedReferenceKeyVal<TKey, TVal>
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3F81250", Offset = "0x3F7FE50", VA = "0x183F81250")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[OCFEEFAGLHF]
	[SerializeField]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5286AB0", Offset = "0x52856B0", VA = "0x185286AB0")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x52862A0", Offset = "0x5284EA0", VA = "0x1852862A0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x52857E0", Offset = "0x52843E0", VA = "0x1852857E0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class AGBBFBFABOH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct AMHBPDHCAGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public T GNLOKINMAMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public float DNCPGALHJHO;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int BIGFIJDIIFC = 16;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const float PEICMAPJNMH = -1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected readonly AMHBPDHCAGP[] CPOMPIIIEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	protected int PFFIGJAGPBI;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float HLGPGFJELOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xAB7810", Offset = "0xAB6410", VA = "0x180AB7810")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xAF5C10", Offset = "0xAF4810", VA = "0x180AF5C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public T MFPBJIDFDPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x957510", Offset = "0x956110", VA = "0x180957510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x46641F0", Offset = "0x4662DF0", VA = "0x1846641F0")]
	protected AGBBFBFABOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4664230", Offset = "0x4662E30", VA = "0x184664230")]
	protected AGBBFBFABOH(int FJJGAGKDECJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4663ED0", Offset = "0x4662AD0", VA = "0x184663ED0")]
	public void GFCJDEIJPEO(float MKKLKGKOEPB, T MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool JGKNNLONPAA(float EICIOFHBACJ, float MFJLPANNKMF, [Out] T MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool LICGNODACIB(float EICIOFHBACJ, float MFJLPANNKMF, [Out] T MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4664120", Offset = "0x4662D20", VA = "0x184664120")]
	public void NGMONOEHMBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class IGFNJJCMBEJ : AGBBFBFABOH<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x74754F0", Offset = "0x74740F0", VA = "0x1874754F0", Slot = "4")]
	public override bool JGKNNLONPAA(float EICIOFHBACJ, float MFJLPANNKMF, [Out] Vector3 MPDLOLIOGJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7475650", Offset = "0x7474250", VA = "0x187475650", Slot = "5")]
	public override bool LICGNODACIB(float EICIOFHBACJ, float MFJLPANNKMF, [Out] Vector3 MPDLOLIOGJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7475790", Offset = "0x7474390", VA = "0x187475790")]
	public IGFNJJCMBEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class GHPAAMFJBEG
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3379850", Offset = "0x3378450", VA = "0x183379850")]
	public static BPKHKDGAAFG<T1, T2> EPPBBCFCJMI<T1, T2>(T1 MHHOIBKNCFL, T2 ACJIBDMCFPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x33798F0", Offset = "0x33784F0", VA = "0x1833798F0")]
	public static LNOAOFBGNCI<T1, T2, T3> EPPBBCFCJMI<T1, T2, T3>(T1 MHHOIBKNCFL, T2 ACJIBDMCFPG, T3 CAGMPLLMGNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4DD3960", Offset = "0x4DD2560", VA = "0x184DD3960")]
	internal static int EECDAHBANMD(int JCAJOFMHIKE, int NGJGLCNBLOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x678CC70", Offset = "0x678B870", VA = "0x18678CC70")]
	internal static int EECDAHBANMD(int JCAJOFMHIKE, int NGJGLCNBLOF, int JPINJMIMKKJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class BPKHKDGAAFG<T1, T2> : IComparable<BPKHKDGAAFG<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T1 MJABKEFJDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T2 KPACNLAIJBJ;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x586FCC0", Offset = "0x586E8C0", VA = "0x18586FCC0")]
	public BPKHKDGAAFG(T1 MHHOIBKNCFL, T2 ACJIBDMCFPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x586DEF0", Offset = "0x586CAF0", VA = "0x18586DEF0", Slot = "4")]
	public int CompareTo(BPKHKDGAAFG<T1, T2> PELBNOCGOOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x586E840", Offset = "0x586D440", VA = "0x18586E840", Slot = "0")]
	public override bool Equals(object PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x586F210", Offset = "0x586DE10", VA = "0x18586F210", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x586F8B0", Offset = "0x586E4B0", VA = "0x18586F8B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class LNOAOFBGNCI<T1, T2, T3> : IComparable<LNOAOFBGNCI<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T1 MJABKEFJDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T2 KPACNLAIJBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T3 NPCBLGEINNN;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4B4C9F0", Offset = "0x4B4B5F0", VA = "0x184B4C9F0")]
	public LNOAOFBGNCI(T1 MHHOIBKNCFL, T2 ACJIBDMCFPG, T3 CAGMPLLMGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4B4C050", Offset = "0x4B4AC50", VA = "0x184B4C050", Slot = "4")]
	public int CompareTo(LNOAOFBGNCI<T1, T2, T3> PELBNOCGOOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4B4C430", Offset = "0x4B4B030", VA = "0x184B4C430", Slot = "0")]
	public override bool Equals(object PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4B4C680", Offset = "0x4B4B280", VA = "0x184B4C680", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4B4C720", Offset = "0x4B4B320", VA = "0x184B4C720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public AnimationCurve EACFDKGELPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T HELBFEFBIFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1095A60", Offset = "0x1094660", VA = "0x181095A60")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T OJAKODGIIOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xAA6F30", Offset = "0xAA5B30", VA = "0x180AA6F30")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T GNLOKINMAMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x28D80B0", Offset = "0x28D6CB0", VA = "0x1828D80B0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x28D80C0", Offset = "0x28D6CC0", VA = "0x1828D80C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float FEPGJMJCAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA9DDF0", Offset = "0xA9C9F0", VA = "0x180A9DDF0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5513090", Offset = "0x5511C90", VA = "0x185513090")]
	public T IHEPONKCGCP(float LDIBCOFKEDC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5512E50", Offset = "0x5511A50", VA = "0x185512E50")]
	public T FMMNINBKPHO(float LDIBCOFKEDC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T ACLPGCAEDHN(T IFMENDFGFGN, T DPEOCFNLADP, float LDIBCOFKEDC);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7474200", Offset = "0x7472E00", VA = "0x187474200", Slot = "4")]
	protected override float ACLPGCAEDHN(float IFMENDFGFGN, float DPEOCFNLADP, float LDIBCOFKEDC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7474240", Offset = "0x7472E40", VA = "0x187474240")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x14E1360", Offset = "0x14DFF60", VA = "0x1814E1360", Slot = "4")]
	protected override Vector3 ACLPGCAEDHN(Vector3 IFMENDFGFGN, Vector3 DPEOCFNLADP, float LDIBCOFKEDC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7479040", Offset = "0x7477C40", VA = "0x187479040")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7473150", Offset = "0x7471D50", VA = "0x187473150", Slot = "4")]
	protected override Color ACLPGCAEDHN(Color IFMENDFGFGN, Color DPEOCFNLADP, float LDIBCOFKEDC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7473210", Offset = "0x7471E10", VA = "0x187473210")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class IBBOGOCCMCJ : ILLEABLABNC<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x74742F0", Offset = "0x7472EF0", VA = "0x1874742F0")]
	public IBBOGOCCMCJ(int MFFEHHIHGMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7474280", Offset = "0x7472E80", VA = "0x187474280", Slot = "6")]
	protected override uint AMDLNGJEDLC(uint DGGBCMIMPNF, string MPDLOLIOGJL)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class BGCIHAOBPGC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly IDisposable FFLNCJPMHOJ;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public BGCIHAOBPGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct DBDOHBNMFFF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> LHNAEKFBMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int DNPFEJBMPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int KPPNOFBCPMN;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4D3A940", Offset = "0x4D39540", VA = "0x184D3A940")]
	private DBDOHBNMFFF(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> GDOOPIMKIEP, int PMPPKFJKJFK, int LJGCIGNLJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x62ED740", Offset = "0x62EC340", VA = "0x1862ED740")]
	public static DBDOHBNMFFF<T> JPHABLICNHB()
	{
		return default(DBDOHBNMFFF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x62EE710", Offset = "0x62ED310", VA = "0x1862EE710")]
	public (int, int, Task<T>) ODHJDODGAFN(int BLMGFGJJCEO, [Optional] CancellationToken NAOIMKEDKEJ, double NOCMKPDPIPA = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x62ED130", Offset = "0x62EBD30", VA = "0x1862ED130")]
	public void CONEEMIGIMC(int BLMGFGJJCEO, int LJGCIGNLJBK, [In] T HBANOBDOKBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class LGEHCHGKFDA
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7475C40", Offset = "0x7474840", VA = "0x187475C40")]
	public static DBDOHBNMFFF<BODKGJBCKHC> JPHABLICNHB()
	{
		return default(DBDOHBNMFFF<BODKGJBCKHC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7475BC0", Offset = "0x74747C0", VA = "0x187475BC0")]
	public static void CONEEMIGIMC([In] this DBDOHBNMFFF<BODKGJBCKHC> DKGDAEBOJKO, int BLMGFGJJCEO, int LJGCIGNLJBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class CHFCJGFBHGF<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly Dictionary<TKey, TVal> FEGJCEFBKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TVal, TKey> OJELHCJOKPJ;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int PHJGKILIPGP
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3CCA4E0", Offset = "0x3CC90E0", VA = "0x183CCA4E0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool EDFBHKBNGLD
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> NMPNIMOKCIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x463B380", Offset = "0x4639F80", VA = "0x18463B380", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> MLGCHFNMEPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x4526540", Offset = "0x4525140", VA = "0x184526540", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal MPDHFMNHCEB
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5AAF540", Offset = "0x5AAE140", VA = "0x185AAF540", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5AAF5B0", Offset = "0x5AAE1B0", VA = "0x185AAF5B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey MPDHFMNHCEB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5AAF190", Offset = "0x5AADD90", VA = "0x185AAF190")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5AAEBC0", Offset = "0x5AAD7C0", VA = "0x185AAEBC0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5AAF360", Offset = "0x5AADF60", VA = "0x185AAF360", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5AAE940", Offset = "0x5AAD540", VA = "0x185AAE940", Slot = "9")]
	public void Add(TKey NKANGPLHEGE, TVal MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5AAE990", Offset = "0x5AAD590", VA = "0x185AAE990", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> HLGDOFMLIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5AAEC70", Offset = "0x5AAD870", VA = "0x185AAEC70", Slot = "8")]
	public bool ContainsKey(TKey NKANGPLHEGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5AAED10", Offset = "0x5AAD910", VA = "0x185AAED10", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> HLGDOFMLIOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5AAF250", Offset = "0x5AADE50", VA = "0x185AAF250", Slot = "10")]
	public bool Remove(TKey NKANGPLHEGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5AAF290", Offset = "0x5AADE90", VA = "0x185AAF290", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> HLGDOFMLIOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5AAF3B0", Offset = "0x5AADFB0", VA = "0x185AAF3B0", Slot = "11")]
	public bool TryGetValue(TKey NKANGPLHEGE, [Out] TVal MPDLOLIOGJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5AAEDE0", Offset = "0x5AAD9E0", VA = "0x185AAEDE0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5AAED50", Offset = "0x5AAD950", VA = "0x185AAED50", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] CPOMPIIIEGC, int LECIFCCAAMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5AAF130", Offset = "0x5AADD30", VA = "0x185AAF130")]
	public bool JLHCCLDIOMP(TVal NKANGPLHEGE, [Out] TKey MPDLOLIOGJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5AAE6D0", Offset = "0x5AAD2D0", VA = "0x185AAE6D0")]
	private void AFPJKAEBFCE(TKey NKANGPLHEGE, TVal ODFJOPDFEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5AAE9E0", Offset = "0x5AAD5E0", VA = "0x185AAE9E0")]
	private void CECIBHKDAJM(TKey NKANGPLHEGE, TVal ODFJOPDFEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5AAEE80", Offset = "0x5AADA80", VA = "0x185AAEE80")]
	private bool HGPPGOFCOIB(TKey NKANGPLHEGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5AAF410", Offset = "0x5AAE010", VA = "0x185AAF410")]
	public CHFCJGFBHGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class GJLLDCLCHIP<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private GJLLDCLCHIP<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x405D490", Offset = "0x405C090", VA = "0x18405D490", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x406B2B0", Offset = "0x4069EB0", VA = "0x18406B2B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x406CFD0", Offset = "0x406BBD0", VA = "0x18406CFD0")]
		public Enumerator(GJLLDCLCHIP<T> IOKDPJEDBMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x4069480", Offset = "0x4068080", VA = "0x184069480", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x406A750", Offset = "0x4069350", VA = "0x18406A750", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4068840", Offset = "0x4067440", VA = "0x184068840")]
		private void BOFDDPPDEHN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private T[] JABLPMBIKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int PKAJCFBDMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int CHBFPOHEPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int HBIBCNEICNM;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int PHJGKILIPGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x44DC900", Offset = "0x44DB500", VA = "0x1844DC900")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T MPDHFMNHCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x44DE870", Offset = "0x44DD470", VA = "0x1844DE870")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x44DCD20", Offset = "0x44DB920", VA = "0x1844DCD20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x44DEC10", Offset = "0x44DD810", VA = "0x1844DEC10")]
	public GJLLDCLCHIP(int MFFEHHIHGMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x44DD110", Offset = "0x44DBD10", VA = "0x1844DD110")]
	public void GFCJDEIJPEO(T LDIBCOFKEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x44DE5E0", Offset = "0x44DD1E0", VA = "0x1844DE5E0")]
	public void NGMONOEHMBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x44DC940", Offset = "0x44DB540", VA = "0x1844DC940")]
	public void CMDBPLGMGCF(int EBDKDADIOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x44DE1B0", Offset = "0x44DCDB0", VA = "0x1844DE1B0")]
	public void GMALBHFEFIA(T[] CPOMPIIIEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x44DE570", Offset = "0x44DD170", VA = "0x1844DE570")]
	public Enumerator HCMJLOGCBCL()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x44DEAD0", Offset = "0x44DD6D0", VA = "0x1844DEAD0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x44DEAD0", Offset = "0x44DD6D0", VA = "0x1844DEAD0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x44DD930", Offset = "0x44DC530", VA = "0x1844DD930")]
	private int GHIFCNPLJID(int BIEEMEKMINN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x44DCA20", Offset = "0x44DB620", VA = "0x1844DCA20")]
	private int FIDABPIFMDC(int BIEEMEKMINN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class JMDEJCKPPGD<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate Task<TResult> NHDJHBAEEMD(TRequest AGFMCIMDGME, CancellationToken NAOIMKEDKEJ);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum HADBMANNGNL
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class OHADNCHLOLI
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const float PFCKPNMKNBI = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TimeSpan ONFJMHGNIAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int LGBDMJOCDKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public HADBMANNGNL GOKAFCGJGIK;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly OHADNCHLOLI EPMIHDCFDJH;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float FCCBHICDPCM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x4F7B5C0", Offset = "0x4F7A1C0", VA = "0x184F7B5C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public TimeSpan IFCHCEDLKDG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x4F7B710", Offset = "0x4F7A310", VA = "0x184F7B710")]
		public OHADNCHLOLI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private readonly struct EEBIGJIOHCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public readonly TRequest AGFMCIMDGME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly CancellationToken NAOIMKEDKEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly TaskCompletionSource<TResult> LEFMCEKDBEO;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3FBCA80", Offset = "0x3FBB680", VA = "0x183FBCA80")]
		public EEBIGJIOHCC(TRequest AGFMCIMDGME, TaskCompletionSource<TResult> LEFMCEKDBEO, CancellationToken NAOIMKEDKEJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct KOEEFALEABI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public JMDEJCKPPGD<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x4A84010", Offset = "0x4A82C10", VA = "0x184A84010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4A84480", Offset = "0x4A83080", VA = "0x184A84480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct GHMMGMMHBCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public JMDEJCKPPGD<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private EEBIGJIOHCC <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x44DABF0", Offset = "0x44D97F0", VA = "0x1844DABF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x44DB200", Offset = "0x44D9E00", VA = "0x1844DB200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CancellationTokenSource AGKIOBHEKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly List<EEBIGJIOHCC> GKBGELEJANM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly OHADNCHLOLI FFNAPIEHMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly NHDJHBAEEMD OIHCAINHJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Task ENOLDFKKLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int IKAGAMOJHFI;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4943270", Offset = "0x4941E70", VA = "0x184943270")]
	public JMDEJCKPPGD(NHDJHBAEEMD OIHCAINHJFO, [Optional] OHADNCHLOLI FFNAPIEHMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4941FA0", Offset = "0x4940BA0", VA = "0x184941FA0")]
	public Task<TResult> EOFFAGGHNIJ(TRequest AGFMCIMDGME, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x49428A0", Offset = "0x49414A0", VA = "0x1849428A0")]
	private void HDEELPHCLLE(EEBIGJIOHCC IBAIKCOBLOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4942470", Offset = "0x4941070", VA = "0x184942470")]
	[AsyncStateMachine(typeof(JMDEJCKPPGD<, >.KOEEFALEABI))]
	private Task GGILKJGPKIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4942C60", Offset = "0x4941860", VA = "0x184942C60")]
	private EEBIGJIOHCC LJOCDINHKOG()
	{
		return default(EEBIGJIOHCC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4941810", Offset = "0x4940410", VA = "0x184941810")]
	[AsyncStateMachine(typeof(JMDEJCKPPGD<, >.GHMMGMMHBCF))]
	private Task CDOLMGOKJJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4941A30", Offset = "0x4940630", VA = "0x184941A30")]
	private void EGOGFIHOODG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x49419F0", Offset = "0x49405F0", VA = "0x1849419F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class MGJIJPJGFAH<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly List<T> DGHHCPPFODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private HashSet<T> IIDNCGNMCEG;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int PHJGKILIPGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3CCA4E0", Offset = "0x3CC90E0", VA = "0x183CCA4E0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool EDFBHKBNGLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T MPDHFMNHCEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x32AAB10", Offset = "0x32A9710", VA = "0x1832AAB10", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4D44E70", Offset = "0x4D43A70", VA = "0x184D44E70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x443C860", Offset = "0x443B460", VA = "0x18443C860", Slot = "11")]
	public void Add(T HLGDOFMLIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4D44570", Offset = "0x4D43170", VA = "0x184D44570")]
	public bool PIBDMDIJCIO(T HLGDOFMLIOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4D44B20", Offset = "0x4D43720", VA = "0x184D44B20", Slot = "15")]
	public bool Remove(T HLGDOFMLIOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4D44240", Offset = "0x4D42E40", VA = "0x184D44240", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x44839A0", Offset = "0x44825A0", VA = "0x1844839A0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4D440D0", Offset = "0x4D42CD0", VA = "0x184D440D0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4D44180", Offset = "0x4D42D80", VA = "0x184D44180", Slot = "13")]
	public bool Contains(T HLGDOFMLIOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4D441E0", Offset = "0x4D42DE0", VA = "0x184D441E0", Slot = "14")]
	public void CopyTo(T[] CPOMPIIIEGC, int LECIFCCAAMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4A4ED60", Offset = "0x4A4D960", VA = "0x184A4ED60", Slot = "6")]
	public int IndexOf(T HLGDOFMLIOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4D44420", Offset = "0x4D43020", VA = "0x184D44420", Slot = "7")]
	public void Insert(int BIEEMEKMINN, T HLGDOFMLIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4D448F0", Offset = "0x4D434F0", VA = "0x184D448F0", Slot = "8")]
	public void RemoveAt(int BIEEMEKMINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4D44BF0", Offset = "0x4D437F0", VA = "0x184D44BF0")]
	public MGJIJPJGFAH()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x27541E0", Offset = "0x2752DE0", VA = "0x1827541E0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7478610", Offset = "0x7477210", VA = "0x187478610")]
		public SerializedGuid([In] Guid IEIMOIIMGDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7478480", Offset = "0x7477080", VA = "0x187478480")]
		public static SerializedGuid NCCAOOOBBKA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7478410", Offset = "0x7477010", VA = "0x187478410")]
		public static SerializedGuid HJLACCLIDDB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7478500", Offset = "0x7477100", VA = "0x187478500")]
		public bool OIEJENPKAEM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x74785E0", Offset = "0x74771E0", VA = "0x1874785E0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7478560", Offset = "0x7477160", VA = "0x187478560", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7478330", Offset = "0x7476F30", VA = "0x187478330", Slot = "7")]
		public bool Equals(SerializedGuid PELBNOCGOOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7478370", Offset = "0x7476F70", VA = "0x187478370", Slot = "0")]
		public override bool Equals(object CFMCKCBBBKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7478400", Offset = "0x7477000", VA = "0x187478400", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7478300", Offset = "0x7476F00", VA = "0x187478300", Slot = "6")]
		public int CompareTo(SerializedGuid PELBNOCGOOJ)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class DCBDFKDGJLD : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Type AHGJKBPCMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly string CPHNHJNPCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly bool AEBAHIHAJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly bool MNCJHIHLLAN;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7473250", Offset = "0x7471E50", VA = "0x187473250")]
	public DCBDFKDGJLD(Type FFJKBFCPHML, string MMEJDNAONFP, bool EDLIKCKFLHH = false, bool OAJMFLBBIDJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface JDOHDOANBLG<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	int HJIKLFMLIHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<T> MAOPEKLDJFG(float MKKLKGKOEPB, [Optional] float? CHCHJNBFGAO);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BIDFFCDHNMD(float MKKLKGKOEPB, T MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NGMONOEHMBH();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Obsolete("Use ITimeSeriesRollingWindow<T> instead")]
public class JLPFGAIMOEF<T> : JDOHDOANBLG<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private class AFNNKONHOLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float FOKJPOOOCBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public T GNLOKINMAMH;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public AFNNKONHOLE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class OKKEKACAMLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public OKKEKACAMLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x4F83B70", Offset = "0x4F82770", VA = "0x184F83B70")]
		internal bool DNFAAEMEHFB(AFNNKONHOLE sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly float HJPCCPOKMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly float OAMAPFKKMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<AFNNKONHOLE> AHBDAIANPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private NOLPMEOMMPP<AFNNKONHOLE> GHINPLMJACC;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int HJIKLFMLIHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x49413B0", Offset = "0x493FFB0", VA = "0x1849413B0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4941550", Offset = "0x4940150", VA = "0x184941550")]
	public JLPFGAIMOEF(float MCEPNLELEGD, float MJAABJPJBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x49408C0", Offset = "0x493F4C0", VA = "0x1849408C0", Slot = "6")]
	public bool BIDFFCDHNMD(float MKKLKGKOEPB, T MPDLOLIOGJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4941010", Offset = "0x493FC10", VA = "0x184941010", Slot = "5")]
	public IEnumerable<T> MAOPEKLDJFG(float MKKLKGKOEPB, float? CHCHJNBFGAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4941490", Offset = "0x4940090", VA = "0x184941490", Slot = "7")]
	public void NGMONOEHMBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4940AB0", Offset = "0x493F6B0", VA = "0x184940AB0")]
	private void ECMJCCBBJKB(float MKKLKGKOEPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class PCOCFPHOAKA<T> : JDOHDOANBLG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct NFLKAJNDAAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly T GNLOKINMAMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly float FOKJPOOOCBG;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x463DC70", Offset = "0x463C870", VA = "0x18463DC70")]
		public NFLKAJNDAAJ(T MPDLOLIOGJL, float MKKLKGKOEPB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class PJCBNCPEMJL : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public PCOCFPHOAKA<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float <>3__time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private float? minTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public float? <>3__minTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private int <count>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xD30330", Offset = "0xD2EF30", VA = "0x180D30330")]
		[DebuggerHidden]
		public PJCBNCPEMJL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5048CB0", Offset = "0x50478B0", VA = "0x185048CB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x50491F0", Offset = "0x5047DF0", VA = "0x1850491F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5049110", Offset = "0x5047D10", VA = "0x185049110", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x44A5ED0", Offset = "0x44A4AD0", VA = "0x1844A5ED0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly float MCEPNLELEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly float MJAABJPJBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly List<NFLKAJNDAAJ> AHBDAIANPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int PKAJCFBDMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int IDAFDLNPJJI;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int HJIKLFMLIHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x95B840", Offset = "0x95A440", VA = "0x18095B840", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x503DF70", Offset = "0x503CB70", VA = "0x18503DF70")]
	public PCOCFPHOAKA(float MCEPNLELEGD, float MJAABJPJBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x503D470", Offset = "0x503C070", VA = "0x18503D470", Slot = "6")]
	public bool BIDFFCDHNMD(float MKKLKGKOEPB, T MPDLOLIOGJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x503D760", Offset = "0x503C360", VA = "0x18503D760", Slot = "8")]
	public int EIMEPONFOCO(float MKKLKGKOEPB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x503D7B0", Offset = "0x503C3B0", VA = "0x18503D7B0", Slot = "5")]
	[IteratorStateMachine(typeof(PCOCFPHOAKA<>.PJCBNCPEMJL))]
	public IEnumerable<T> MAOPEKLDJFG(float MKKLKGKOEPB, float? CHCHJNBFGAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x503D950", Offset = "0x503C550", VA = "0x18503D950", Slot = "7")]
	public void NGMONOEHMBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x503DB60", Offset = "0x503C760", VA = "0x18503DB60")]
	private void PBGMOHBFDJH(float MKKLKGKOEPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x503D9B0", Offset = "0x503C5B0", VA = "0x18503D9B0")]
	private NFLKAJNDAAJ OLAKEAEBEIA()
	{
		return default(NFLKAJNDAAJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class FNEANCIAOBI<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public readonly struct ADALECFBCJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly long CDDKDAMPKJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly long OJLBIGFOMNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly int OHONKOGOJNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly int MHLKOIHGCNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly bool DOIKCFHFODO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly string LDIJDCKFNLH;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x4546B20", Offset = "0x4545720", VA = "0x184546B20")]
		public ADALECFBCJF(long CDDKDAMPKJI, int OHONKOGOJNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4546B90", Offset = "0x4545790", VA = "0x184546B90")]
		public ADALECFBCJF(long CDDKDAMPKJI, long OJLBIGFOMNJ, int OHONKOGOJNI, int MHLKOIHGCNL, bool DOIKCFHFODO, string LDIJDCKFNLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x45469B0", Offset = "0x45455B0", VA = "0x1845469B0")]
		public int GCDOFAEGEGL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4546A00", Offset = "0x4545600", VA = "0x184546A00")]
		public int KDFGHNANADL(int DLEPDKPKHLJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4546A20", Offset = "0x4545620", VA = "0x184546A20")]
		public double LCNOLHMFMPO()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4546A80", Offset = "0x4545680", VA = "0x184546A80")]
		public ADALECFBCJF PFNJNAJNLAJ(long OJLBIGFOMNJ, int MHLKOIHGCNL)
		{
			return default(ADALECFBCJF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class IDKBCAKILKJ : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private struct AOMCJGDLJGP<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public IDKBCAKILKJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Func<IDKBCAKILKJ, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private IDKBCAKILKJ <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x477CDA0", Offset = "0x477B9A0", VA = "0x18477CDA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x3FF7550", Offset = "0x3FF6150", VA = "0x183FF7550", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly TKey JFPNHMHDAFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly FNEANCIAOBI<TKey> IFHLDBMAMPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly NDNFAPMFFIF DFFCPCMIFOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private List<IDKBCAKILKJ> IHBOPMMPKMB;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string EOIDECKDIAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x46EA480", Offset = "0x46E9080", VA = "0x1846EA480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public IEnumerable<IDKBCAKILKJ> GIFGPMEDCNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x46E9FF0", Offset = "0x46E8BF0", VA = "0x1846E9FF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public ADALECFBCJF ODGMMBAHHJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x46EA4E0", Offset = "0x46E90E0", VA = "0x1846EA4E0")]
			[CompilerGenerated]
			get
			{
				return default(ADALECFBCJF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x46EA290", Offset = "0x46E8E90", VA = "0x1846EA290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x46EA500", Offset = "0x46E9100", VA = "0x1846EA500")]
		internal IDKBCAKILKJ(FNEANCIAOBI<TKey> IFHLDBMAMPN, TKey NKANGPLHEGE, NDNFAPMFFIF DFFCPCMIFOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x46EA2C0", Offset = "0x46E8EC0", VA = "0x1846EA2C0")]
		public IDKBCAKILKJ FMDOFLNIEIO(TKey NKANGPLHEGE, [Optional] NDNFAPMFFIF? CEIACNNBGKC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x33CA010", Offset = "0x33C8C10", VA = "0x1833CA010")]
		[AsyncStateMachine(typeof(AOMCJGDLJGP<>))]
		public Task<T> GGBHMOAAMCL<T>(TKey NKANGPLHEGE, Func<IDKBCAKILKJ, Task<T>> ONHFNCNDFHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x46EA030", Offset = "0x46E8C30", VA = "0x1846EA030", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class LLLIFEMKLNL : IEnumerable<(TKey, List<TKey>, ADALECFBCJF)>, IEnumerable, IEnumerator<(TKey, List<TKey>, ADALECFBCJF)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private (TKey key, List<TKey> path, ADALECFBCJF timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public FNEANCIAOBI<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private IEnumerator<(TKey key, List<TKey> path, ADALECFBCJF timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private (TKey, List<TKey>, ADALECFBCJF) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x2751140", Offset = "0x274FD40", VA = "0x182751140", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, ADALECFBCJF));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x4B47690", Offset = "0x4B46290", VA = "0x184B47690", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2751230", Offset = "0x274FE30", VA = "0x182751230")]
		[DebuggerHidden]
		public LLLIFEMKLNL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x4451930", Offset = "0x4450530", VA = "0x184451930", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4B471B0", Offset = "0x4B45DB0", VA = "0x184B471B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4B47160", Offset = "0x4B45D60", VA = "0x184B47160")]
		private void AOMOFJGADBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x4B47640", Offset = "0x4B46240", VA = "0x184B47640", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x4B47560", Offset = "0x4B46160", VA = "0x184B47560", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, ADALECFBCJF)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x3FD4DE0", Offset = "0x3FD39E0", VA = "0x183FD4DE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class PADNIJBMFIB : IEnumerable<(TKey, List<TKey>, ADALECFBCJF)>, IEnumerable, IEnumerator<(TKey, List<TKey>, ADALECFBCJF)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private (TKey key, List<TKey> path, ADALECFBCJF timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private IDKBCAKILKJ timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public IDKBCAKILKJ <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public FNEANCIAOBI<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IEnumerator<IDKBCAKILKJ> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private IEnumerator<(TKey key, List<TKey> path, ADALECFBCJF timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private (TKey, List<TKey>, ADALECFBCJF) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x2751140", Offset = "0x274FD40", VA = "0x182751140", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, ADALECFBCJF));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x5031BD0", Offset = "0x50307D0", VA = "0x185031BD0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2751230", Offset = "0x274FE30", VA = "0x182751230")]
		[DebuggerHidden]
		public PADNIJBMFIB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5031C30", Offset = "0x5030830", VA = "0x185031C30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5031260", Offset = "0x502FE60", VA = "0x185031260", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x50311A0", Offset = "0x502FDA0", VA = "0x1850311A0")]
		private void AOMOFJGADBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5031200", Offset = "0x502FE00", VA = "0x185031200")]
		private void BENEFBJOBNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5031B80", Offset = "0x5030780", VA = "0x185031B80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5031A40", Offset = "0x5030640", VA = "0x185031A40", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, ADALECFBCJF)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5031B40", Offset = "0x5030740", VA = "0x185031B40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Action<TKey, ADALECFBCJF, NDNFAPMFFIF> MHLPOGMEMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Action<TKey, ADALECFBCJF, NDNFAPMFFIF> BHCPMKLJGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly Action<FNEANCIAOBI<TKey>, NDNFAPMFFIF> CCJCGEJAFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly IDKBCAKILKJ EFNEGONDFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private bool BPEPOBJKFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int BIICKFKIJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Stopwatch CDDJGDCABGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly int ENMBNENKJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private string BMCDMOGAEJA;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public IDKBCAKILKJ EEFNEPDFKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x9574D0", Offset = "0x9560D0", VA = "0x1809574D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	[NotNull]
	public string EOIDECKDIAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x95F000", Offset = "0x95DC00", VA = "0x18095F000")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x441B7C0", Offset = "0x441A3C0", VA = "0x18441B7C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x441B820", Offset = "0x441A420", VA = "0x18441B820")]
	public FNEANCIAOBI(TKey EJHFEMALDME, NDNFAPMFFIF DFFCPCMIFOD, [Optional] int? OHONKOGOJNI, [Optional][CanBeNull] Stopwatch CDDJGDCABGF, [Optional] Action<TKey, ADALECFBCJF, NDNFAPMFFIF> MHLPOGMEMHG, [Optional] Action<TKey, ADALECFBCJF, NDNFAPMFFIF> BHCPMKLJGJD, [Optional] Action<FNEANCIAOBI<TKey>, NDNFAPMFFIF> CCJCGEJAFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x441B660", Offset = "0x441A260", VA = "0x18441B660", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x441B4C0", Offset = "0x441A0C0", VA = "0x18441B4C0")]
	[IteratorStateMachine(typeof(FNEANCIAOBI<>.LLLIFEMKLNL))]
	public IEnumerable<(TKey, List<TKey>, ADALECFBCJF)> CKLBIBJPDEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x441B570", Offset = "0x441A170", VA = "0x18441B570")]
	[IteratorStateMachine(typeof(FNEANCIAOBI<>.PADNIJBMFIB))]
	private IEnumerable<(TKey, List<TKey>, ADALECFBCJF)> CKLBIBJPDEB(List<TKey> ICLCPILCBMO, IDKBCAKILKJ IABIPFABHPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x441B740", Offset = "0x441A340", VA = "0x18441B740")]
	private (long, int) GOKKOHNKAFI()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public abstract class FEGHPNNOONF<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut DCBJOAFBCID(FNEANCIAOBI<TKey> IFHLDBMAMPN);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	protected FEGHPNNOONF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class DBHDKDPALKL<TKey> : FEGHPNNOONF<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public delegate string AMPFFJKPCFB(TKey NKANGPLHEGE);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x62F0830", Offset = "0x62EF430", VA = "0x1862F0830")]
	private static string IBFHGHPDCDN(TKey NKANGPLHEGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x62F0740", Offset = "0x62EF340", VA = "0x1862F0740", Slot = "4")]
	public override string DCBJOAFBCID(FNEANCIAOBI<TKey> IFHLDBMAMPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x62F05E0", Offset = "0x62EF1E0", VA = "0x1862F05E0")]
	public string DCBJOAFBCID(FNEANCIAOBI<TKey> IFHLDBMAMPN, [NotNull] AMPFFJKPCFB NDAKKINOAMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string DOCKCAKJHDF(FNEANCIAOBI<TKey> IFHLDBMAMPN, [NotNull] AMPFFJKPCFB NDAKKINOAMH);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x471FD80", Offset = "0x471E980", VA = "0x18471FD80")]
	protected DBHDKDPALKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class HCDFGOEPIFL<TKey> : FEGHPNNOONF<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public delegate string DANGEJKCODE(TKey NKANGPLHEGE);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly string AHELPDDOKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly double ENFNHBKOLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly bool LHKACDGMODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly int KOCBEGBCJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly ISet<string> ONBGFBNLKMA;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x456FDE0", Offset = "0x456E9E0", VA = "0x18456FDE0")]
	private static string IBFHGHPDCDN(TKey NKANGPLHEGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x4570060", Offset = "0x456EC60", VA = "0x184570060")]
	public HCDFGOEPIFL(string AHELPDDOKPE = "F2", double ENFNHBKOLED = double.MaxValue, bool LHKACDGMODC = false, int KOCBEGBCJKI = int.MaxValue, [Optional] ISet<string> ONBGFBNLKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x456FA70", Offset = "0x456E670", VA = "0x18456FA70", Slot = "4")]
	public override Dictionary<string, string> DCBJOAFBCID(FNEANCIAOBI<TKey> IFHLDBMAMPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x456FF80", Offset = "0x456EB80", VA = "0x18456FF80")]
	private bool LLPMKHPOEKN(string DPMCFOPNFMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x456F420", Offset = "0x456E020", VA = "0x18456F420")]
	public Dictionary<string, string> DCBJOAFBCID(FNEANCIAOBI<TKey> IFHLDBMAMPN, DANGEJKCODE NDAKKINOAMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x456FB60", Offset = "0x456E760", VA = "0x18456FB60")]
	private string DFEMDPFDMIB(StringBuilder KGOLKKHGLAN, List<TKey> HJANBHLHMON, DANGEJKCODE NDAKKINOAMH, bool CHAKGJBGDOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x456FE20", Offset = "0x456EA20", VA = "0x18456FE20")]
	private static void KOJDKIDFADI(StringBuilder LMBNKDAJMHB, string DCMAMKBPKMJ, bool MKLAHKLKLLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class CBGHKCAIMGH<TKey> : DBHDKDPALKL<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct BKPPOKKOEFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AMPFFJKPCFB keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static CBGHKCAIMGH<TKey> FFLNCJPMHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly string[] CFOEHHNODIO;

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x59B9020", Offset = "0x59B7C20", VA = "0x1859B9020")]
	private CBGHKCAIMGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x59B8080", Offset = "0x59B6C80", VA = "0x1859B8080", Slot = "5")]
	protected override string DOCKCAKJHDF(FNEANCIAOBI<TKey> IFHLDBMAMPN, AMPFFJKPCFB NDAKKINOAMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x59B7F70", Offset = "0x59B6B70", VA = "0x1859B7F70")]
	[CompilerGenerated]
	internal static string AONJFDCHJAM(string PMEMJIOCOBG, TKey NKANGPLHEGE, BKPPOKKOEFI P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class DEIKLFGHCIF : FNEANCIAOBI<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class FLHODDNBCBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Action<DEIKLFGHCIF, NDNFAPMFFIF> callback;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public FLHODDNBCBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7473880", Offset = "0x7472480", VA = "0x187473880")]
		internal void EPAMFMGHJHG(FNEANCIAOBI<string> timer, NDNFAPMFFIF log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7473380", Offset = "0x7471F80", VA = "0x187473380")]
	public DEIKLFGHCIF(NDNFAPMFFIF DFFCPCMIFOD, [Optional] string CKHAMLHEFEL, [Optional] int? OHONKOGOJNI, [Optional] Stopwatch CDDJGDCABGF, [Optional] Action<string, ADALECFBCJF, NDNFAPMFFIF> MHLPOGMEMHG, [Optional] Action<string, ADALECFBCJF, NDNFAPMFFIF> BHCPMKLJGJD, [Optional] Action<DEIKLFGHCIF, NDNFAPMFFIF> CCJCGEJAFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x74732C0", Offset = "0x7471EC0", VA = "0x1874732C0")]
	private static Action<FNEANCIAOBI<string>, NDNFAPMFFIF> JJLCLGCGDPH(Action<DEIKLFGHCIF, NDNFAPMFFIF> DKDPAFJDNNF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public abstract class CEJEAPLGIKK
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private class JABILACMAJO : CEJEAPLGIKK
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static CEJEAPLGIKK FFLNCJPMHOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x74757D0", Offset = "0x74743D0", VA = "0x1874757D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override float EHKPMPGMBHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0xFF7260", Offset = "0xFF5E60", VA = "0x180FF7260", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x74758C0", Offset = "0x74744C0", VA = "0x1874758C0")]
		public JABILACMAJO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static CEJEAPLGIKK ABJGNAJJMDJ;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static CEJEAPLGIKK EPMIHDCFDJH
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7472FF0", Offset = "0x7471BF0", VA = "0x187472FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public abstract float EHKPMPGMBHG
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	protected CEJEAPLGIKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface OLBLCJOKKJF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	bool LIANHAMAEMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface OBLFPJIHAJD<T> : OLBLCJOKKJF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	[NotNull]
	Task<T> OBMOKPFEHIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[NotNull]
	JOIICJDLMNO<T> LBDFGDHDBFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class FGHPBJCCKNC
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x3352310", Offset = "0x3350F10", VA = "0x183352310")]
	public static OBLFPJIHAJD<TResource> GEPJBOBNKBE<TResource, TId>(this NIDMLILKNFO<TId, TResource> POACKIHOABP, TId HGEMPDBGGBJ, [Optional] Func<TId, CancellationToken, Task<TResource>>? FONIJMEKCDD) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class EGFDAPBDLGE
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private sealed class OMFKAKDFLEK<T> : HAFODOPCEDD<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<T?> OBMOKPFEHIH
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override JOIICJDLMNO<T?> LBDFGDHDBFD
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x957550", Offset = "0x956150", VA = "0x180957550", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x4F93990", Offset = "0x4F92590", VA = "0x184F93990")]
		public OMFKAKDFLEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "10")]
		protected override void HNPHOKMJKIJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class GIOKHAGBDMM<T> : HAFODOPCEDD<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly T NDCELFEJNCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly Action<T>? DEIPKCACFPN;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Task<T> OBMOKPFEHIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x95CEF0", Offset = "0x95BAF0", VA = "0x18095CEF0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override JOIICJDLMNO<T> LBDFGDHDBFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x961640", Offset = "0x960240", VA = "0x180961640", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x44DC3E0", Offset = "0x44DAFE0", VA = "0x1844DC3E0")]
		public GIOKHAGBDMM(T AAHFBBEIMOH, Action<T>? IMIFPEHACLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x44DC330", Offset = "0x44DAF30", VA = "0x1844DC330", Slot = "10")]
		protected override void HNPHOKMJKIJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class PODBBABPGIP<T> : HAFODOPCEDD<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override Task<T> OBMOKPFEHIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override JOIICJDLMNO<T> LBDFGDHDBFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x957550", Offset = "0x956150", VA = "0x180957550", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x5086FA0", Offset = "0x5085BA0", VA = "0x185086FA0")]
		public PODBBABPGIP(Exception MKDAJBJBGPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "10")]
		protected override void HNPHOKMJKIJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private sealed class JPAPGIBCKMO<T> : HAFODOPCEDD<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct LBDEGJIBMNK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public Task<OBLFPJIHAJD<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<OBLFPJIHAJD<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x4B10FF0", Offset = "0x4B0FBF0", VA = "0x184B10FF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x4B11530", Offset = "0x4B10130", VA = "0x184B11530", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct HGEBJIGMOBG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public Task<OBLFPJIHAJD<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private TaskAwaiter<OBLFPJIHAJD<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x45B3620", Offset = "0x45B2220", VA = "0x1845B3620", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x45B3B00", Offset = "0x45B2700", VA = "0x1845B3B00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly Task<OBLFPJIHAJD<T>> EMENAIGKBLJ;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override Task<T> OBMOKPFEHIH
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x957550", Offset = "0x956150", VA = "0x180957550", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override JOIICJDLMNO<T> LBDFGDHDBFD
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x9574C0", Offset = "0x9560C0", VA = "0x1809574C0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x49596E0", Offset = "0x49582E0", VA = "0x1849596E0")]
		public JPAPGIBCKMO(Task<OBLFPJIHAJD<T>> LFJIOJDNNEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x4959650", Offset = "0x4958250", VA = "0x184959650", Slot = "10")]
		protected override void HNPHOKMJKIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x49590E0", Offset = "0x4957CE0", VA = "0x1849590E0")]
		[AsyncStateMachine(typeof(JPAPGIBCKMO<>.LBDEGJIBMNK))]
		[CompilerGenerated]
		internal static Task<T> ALKIDBJHBFI(Task<OBLFPJIHAJD<T>> LFJIOJDNNEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x49593E0", Offset = "0x4957FE0", VA = "0x1849593E0")]
		[AsyncStateMachine(typeof(JPAPGIBCKMO<>.HGEBJIGMOBG))]
		[CompilerGenerated]
		internal static Task FLKBKPMBLEB(Task<OBLFPJIHAJD<T>> LFJIOJDNNEN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private sealed class LGNKBBDAHHO<TIn, TOut> : HAFODOPCEDD<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private struct MHOCHCDDMPJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public AsyncTaskMethodBuilder<TOut> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public Func<TIn, TOut> transformFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public Task<TIn> innerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private Func<TIn, TOut> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private TaskAwaiter<TIn> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x4D4A2A0", Offset = "0x4D48EA0", VA = "0x184D4A2A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x46E59A0", Offset = "0x46E45A0", VA = "0x1846E59A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly OBLFPJIHAJD<TIn> IIMEOKNFPME;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override Task<TOut> OBMOKPFEHIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x957550", Offset = "0x956150", VA = "0x180957550", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override JOIICJDLMNO<TOut> LBDFGDHDBFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x9574C0", Offset = "0x9560C0", VA = "0x1809574C0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x4B31940", Offset = "0x4B30540", VA = "0x184B31940")]
		public LGNKBBDAHHO(OBLFPJIHAJD<TIn> EJPINMOHBMG, Func<TIn, TOut> OIBGLDNGLNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x4B318A0", Offset = "0x4B304A0", VA = "0x184B318A0", Slot = "10")]
		protected override void HNPHOKMJKIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x4B31580", Offset = "0x4B30180", VA = "0x184B31580")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(LGNKBBDAHHO<, >.MHOCHCDDMPJ))]
		internal static Task<TOut> DNEGKDHMKKC(Task<TIn> OBKCLFBIBFD, Func<TIn, TOut> OIBGLDNGLNH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x31CEFB0", Offset = "0x31CDBB0", VA = "0x1831CEFB0")]
	public static OBLFPJIHAJD<T> PCKMBPNMICK<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x31CEF00", Offset = "0x31CDB00", VA = "0x1831CEF00")]
	public static OBLFPJIHAJD<T> JDPJOKGHBEL<T>(T HBANOBDOKBJ, [Optional] Action<T>? IMIFPEHACLF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x30E8390", Offset = "0x30E6F90", VA = "0x1830E8390")]
	public static OBLFPJIHAJD<T> BMENMOLCCAI<T>(Exception MKDAJBJBGPA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x30E8390", Offset = "0x30E6F90", VA = "0x1830E8390")]
	public static OBLFPJIHAJD<T> DDAJHIDAOEB<T>(Task<OBLFPJIHAJD<T>> LFJIOJDNNEN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x30E9000", Offset = "0x30E7C00", VA = "0x1830E9000")]
	public static OBLFPJIHAJD<TOut> DKANJPNMCLP<TOut, TIn>(OBLFPJIHAJD<TIn> EHNDIPGCOKP, Func<TIn, TOut> OIBGLDNGLNH) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class HAFODOPCEDD<T> : OBLFPJIHAJD<T>, OLBLCJOKKJF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly string GJHFBCILGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly AEHCGFGPDIG PNEHLKKHJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private bool BPEPOBJKFCM;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool LIANHAMAEMH
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xB44370", Offset = "0xB42F70", VA = "0x180B44370", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public abstract Task<T> OBMOKPFEHIH
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public abstract JOIICJDLMNO<T> LBDFGDHDBFD
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x456B8D0", Offset = "0x456A4D0", VA = "0x18456B8D0")]
	public HAFODOPCEDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x456B510", Offset = "0x456A110", VA = "0x18456B510", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void HNPHOKMJKIJ();
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class ANEOOMKOHBG<TTask, T> : HAFODOPCEDD<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class FHLMPCJINPA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public FHLMPCJINPA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x3CB86D0", Offset = "0x3CB72D0", VA = "0x183CB86D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x3CB8C40", Offset = "0x3CB7840", VA = "0x183CB8C40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public ANEOOMKOHBG<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public FHLMPCJINPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x4399300", Offset = "0x4397F00", VA = "0x184399300")]
		[AsyncStateMachine(typeof(ANEOOMKOHBG<, >.FHLMPCJINPA.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> MENJBKKHLDC(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Task<T> LFJIOJDNNEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	protected readonly CancellationTokenSource HGGNOAGNIMP;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public override Task<T> OBMOKPFEHIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public override JOIICJDLMNO<T> LBDFGDHDBFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x957550", Offset = "0x956150", VA = "0x180957550", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x47746A0", Offset = "0x47732A0", VA = "0x1847746A0")]
	protected ANEOOMKOHBG(TTask LFJIOJDNNEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x4774650", Offset = "0x4773250", VA = "0x184774650", Slot = "10")]
	protected override void HNPHOKMJKIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T PIEPOLPLKDF(TTask GOFCIKMELLJ);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void LDPKOMCCOKH();
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class OLLNBMMDBAF<T> : HAFODOPCEDD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly PAGNEAPPJJN<Task<T>> ABFAMACJFEI;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override Task<T> OBMOKPFEHIH
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x4713780", Offset = "0x4712380", VA = "0x184713780", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override JOIICJDLMNO<T> LBDFGDHDBFD
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x957550", Offset = "0x956150", VA = "0x180957550", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x4F8FD70", Offset = "0x4F8E970", VA = "0x184F8FD70")]
	public OLLNBMMDBAF(PAGNEAPPJJN<Task<T>> BMCDDCGMAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x4F8FD50", Offset = "0x4F8E950", VA = "0x184F8FD50", Slot = "10")]
	protected override void HNPHOKMJKIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class FLNNABFDKFK
{
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly HashAlgorithmName CINOMCKIECK;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly ThreadLocal<IncrementalHash> OMMEJPKADAO;

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7473910", Offset = "0x7472510", VA = "0x187473910")]
	public static int MGCNBPKBMMH(this GIMKAEOLMJJ CEDKCCNPKIJ, IncrementalHash DGGBCMIMPNF, byte[] FHLMPNKAFBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7473990", Offset = "0x7472590", VA = "0x187473990")]
	public static bool NDGJJIAKEJF([CanBeNull] this GIMKAEOLMJJ CEDKCCNPKIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7473D20", Offset = "0x7472920", VA = "0x187473D20")]
	public static bool NDGJJIAKEJF([CanBeNull] this GIMKAEOLMJJ CEDKCCNPKIJ, [Out] string AHPAHIHOBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x74739F0", Offset = "0x74725F0", VA = "0x1874739F0")]
	public static bool NDGJJIAKEJF([CanBeNull] this GIMKAEOLMJJ CEDKCCNPKIJ, IncrementalHash DGGBCMIMPNF, byte[] FHLMPNKAFBP, [Out] string AHPAHIHOBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7474030", Offset = "0x7472C30", VA = "0x187474030")]
	private static bool PKECLIJMJDD(byte[] OOPNAEIDHON, Span<byte> MBBLKDHLNCE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class EMHONNJCNNN
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x74734D0", Offset = "0x74720D0", VA = "0x1874734D0")]
	public static int EGHLLDKJGND(HashAlgorithmName LBFDLEJOANH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7473620", Offset = "0x7472220", VA = "0x187473620")]
	public static int MGCNBPKBMMH(this NOHNEKNBLCP GNOFHPDCBLD, byte[] HNGOGIGJCPJ, IncrementalHash DGGBCMIMPNF, byte[] FPHMMIMAIIM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface NOHNEKNBLCP
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash DGGBCMIMPNF);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface GIMKAEOLMJJ : NOHNEKNBLCP
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	[CanBeNull]
	byte[] HPJJAOBOKHA
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	[CanBeNull]
	byte[] PAKFEBIPBHM
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class IFCCIMAEAKG
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static bool OJHHLNCENMH;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly ArrayPool<byte> CNBOKJLIKGP;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly ArrayPool<char> BPEDJHIMBKG;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly Encoding BLECCEIPNOB;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly ThreadLocal<Encoder> GJCGNEHFBPE;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x33B2150", Offset = "0x33B0D50", VA = "0x1833B2150")]
	public static void MPMNDNEEJHH<T>(this IncrementalHash OELNDPIJCMC, [CanBeNull] T AKHNIBOPJIM) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x33B1BA0", Offset = "0x33B07A0", VA = "0x1833B1BA0")]
	public static void BLLDKHONGGE<T>(this IncrementalHash OELNDPIJCMC, [CanBeNull] T GNOFHPDCBLD) where T : NOHNEKNBLCP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x33B1C30", Offset = "0x33B0830", VA = "0x1833B1C30")]
	public static void ENPODLDCDAA<T>(this IncrementalHash OELNDPIJCMC, [CanBeNull] IList<T> NKPEKGHOEFM) where T : NOHNEKNBLCP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x7474680", Offset = "0x7473280", VA = "0x187474680")]
	private static bool GCFMLPDBPGE([CanBeNull] NOHNEKNBLCP GNOFHPDCBLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x7474820", Offset = "0x7473420", VA = "0x187474820")]
	public static void JMEADAHFJBO(this IncrementalHash DGGBCMIMPNF, string? MEINAOGBNOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x74750A0", Offset = "0x7473CA0", VA = "0x1874750A0")]
	public static void PGCGICPECOD(this IncrementalHash DGGBCMIMPNF, long BAHPJGLKGNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x74744B0", Offset = "0x74730B0", VA = "0x1874744B0")]
	public static void ELGKLMFGAPH(this IncrementalHash DGGBCMIMPNF, int BDDBBFFFBDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7474D40", Offset = "0x7473940", VA = "0x187474D40")]
	public static void MKOKLLKPFKE(this IncrementalHash DGGBCMIMPNF, short JKAFGIAKCPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7474710", Offset = "0x7473310", VA = "0x187474710")]
	public static void GJDEMKOBEHK(this IncrementalHash DGGBCMIMPNF, byte IFNFJOIFNKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7474340", Offset = "0x7472F40", VA = "0x187474340")]
	public static void CNFJHPFOLCJ(this IncrementalHash DGGBCMIMPNF, bool PCKFLPPLLIM, bool IMABEGPBONI = false, bool HMOIIFCMADK = false, bool EIGMBNGNELM = false, bool EAHEFHPJOLB = false, bool CKMONDMJIMH = false, bool MFBGOHCBPLC = false, bool KHJKLELJMHJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x33B2210", Offset = "0x33B0E10", VA = "0x1833B2210")]
	public static void OJGGJNMDCLF<T>(this IncrementalHash DGGBCMIMPNF, T HLFIFJFGNJJ) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7474CE0", Offset = "0x74738E0", VA = "0x187474CE0")]
	public static void MBKADNCIJMJ(this IncrementalHash DGGBCMIMPNF, float LIBMOBHPPFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7475040", Offset = "0x7473C40", VA = "0x187475040")]
	public static void OIKKODOCDAO(this IncrementalHash DGGBCMIMPNF, ulong AHJDOPCFMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7474C20", Offset = "0x7473820", VA = "0x187474C20")]
	public static void KEOHALMFJEP(this IncrementalHash DGGBCMIMPNF, uint DDOKHHAMALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7474C80", Offset = "0x7473880", VA = "0x187474C80")]
	public static void LDEMIEOPKDF(this IncrementalHash DGGBCMIMPNF, ushort AGCAHJFJIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7474F10", Offset = "0x7473B10", VA = "0x187474F10")]
	public static void OHELALLBFCK(this IncrementalHash DGGBCMIMPNF, Vector3 FAJGEKOKMBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class KDMBKKGGFOA : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x7475910", Offset = "0x7474510", VA = "0x187475910")]
	public KDMBKKGGFOA(string KBPDEFFIKOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class KFOLLPNGEBL
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public delegate void LGGHBGCPJJG(ushort ABACPLNNBDG, ushort DNLCAMDLCAI, ushort BCHMDOEPFJL, ushort IHFHKLIIEBA);

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate void BMAMJOJAPPA(ushort BAEOCADLGBE, ushort KBOMJGPBPLN);

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate void OEHMPPICLNK();

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const ushort JBMDIAMDIJH = ushort.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	protected KFOLLPNGEBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public abstract class GOFCPDOMPFD<T> : KFOLLPNGEBL where T : GOFCPDOMPFD<T>.JMFPHNOBIND
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public interface JMFPHNOBIND
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		BMAMJOJAPPA LDBAENJPMBH
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		BMAMJOJAPPA CFAFACJFNAM
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		OEHMPPICLNK AECKOPDNOGD
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Dictionary<uint, T> KHPDEPDJJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private OEHMPPICLNK BEEMLBCOEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private OEHMPPICLNK GNLPBOICCOP;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool FFKNBPEPDFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xBB8D00", Offset = "0xBB7900", VA = "0x180BB8D00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963120", VA = "0x180964520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public ushort HAKEFKJKLEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4521DC0", Offset = "0x45209C0", VA = "0x184521DC0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x45218D0", Offset = "0x45204D0", VA = "0x1845218D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public ushort OBDFJKEIBNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4521560", Offset = "0x4520160", VA = "0x184521560")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x45219B0", Offset = "0x45205B0", VA = "0x1845219B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public ushort DKOHJOPEPGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xC4F480", Offset = "0xC4E080", VA = "0x180C4F480")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xC4F580", Offset = "0xC4E180", VA = "0x180C4F580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public ushort EIDLBGAJOFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x4521800", Offset = "0x4520400", VA = "0x184521800")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x45214B0", Offset = "0x45200B0", VA = "0x1845214B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	protected bool EOCBECKODGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x1561030", Offset = "0x155FC30", VA = "0x181561030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected bool BFFOEPIAELN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xD25100", Offset = "0xD23D00", VA = "0x180D25100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event LGGHBGCPJJG LGIOPAGIDBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x45214C0", Offset = "0x45200C0", VA = "0x1845214C0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4521C50", Offset = "0x4520850", VA = "0x184521C50")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x45218E0", Offset = "0x45204E0", VA = "0x1845218E0")]
	private T IIFKKJFPBKI(ushort BOPLKFIGMPG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x4521730", Offset = "0x4520330", VA = "0x184521730")]
	private T FCPLEBEEDPP(ushort BOPLKFIGMPG, ushort FGFIBKIMEGI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x4521D00", Offset = "0x4520900", VA = "0x184521D00")]
	protected T MGHPDHGEENF(uint NBHJCKGJDJJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x4522670", Offset = "0x4521270", VA = "0x184522670")]
	protected GOFCPDOMPFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x45215D0", Offset = "0x45201D0", VA = "0x1845215D0")]
	public void EKABFNOLMLF(ushort BABIDEDADHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x4521570", Offset = "0x4520170", VA = "0x184521570")]
	public void EKABFNOLMLF(ushort BABIDEDADHH, ushort NLCPNKGCHDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x4521610", Offset = "0x4520210", VA = "0x184521610", Slot = "4")]
	protected virtual void EKABFNOLMLF(uint HIGIJGIKHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x4521DD0", Offset = "0x45209D0", VA = "0x184521DD0")]
	protected void OJOKILMGAEN(uint HIGIJGIKHGI, uint JBMDKGCANPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x4521810", Offset = "0x4520410", VA = "0x184521810")]
	protected void HEDCOLMPBNF(ushort BOPLKFIGMPG, ushort FGFIBKIMEGI, T CMPEMMPBPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x4521D60", Offset = "0x4520960", VA = "0x184521D60")]
	private void NIOJOJCKHIM(uint NBHJCKGJDJJ, T CMPEMMPBPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x45219C0", Offset = "0x45205C0", VA = "0x1845219C0")]
	protected void KLKIIMAKHPN(float BLINLOHDAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x45219A0", Offset = "0x45205A0", VA = "0x1845219A0")]
	protected uint JBCBCJKAGMK(ushort BOPLKFIGMPG, ushort FGFIBKIMEGI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x45218C0", Offset = "0x45204C0", VA = "0x1845218C0")]
	protected ushort ICNLKDLDPHC(uint BNEGCOGOCOI)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x4521CF0", Offset = "0x45208F0", VA = "0x184521CF0")]
	protected ushort LIDPOAODJNO(uint BNEGCOGOCOI)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public abstract class KOGBIEIMBED : GOFCPDOMPFD<KOGBIEIMBED.NCDONNGDMDH>
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class NCDONNGDMDH : JMFPHNOBIND
	{
		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public BMAMJOJAPPA LDBAENJPMBH
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x957520", Offset = "0x956120", VA = "0x180957520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public BMAMJOJAPPA CFAFACJFNAM
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x957510", Offset = "0x956110", VA = "0x180957510")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public OEHMPPICLNK AECKOPDNOGD
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x957550", Offset = "0x956150", VA = "0x180957550", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x957500", Offset = "0x956100", VA = "0x180957500")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public NCDONNGDMDH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x7475A50", Offset = "0x7474650", VA = "0x187475A50")]
	public void EJJOOHECDOC(ushort CFBHPDJKJIN, BMAMJOJAPPA GBLKEPEGHHH, BMAMJOJAPPA LNLIPBHKBMF, OEHMPPICLNK CEMGLEAMMLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7475970", Offset = "0x7474570", VA = "0x187475970")]
	public void EJJOOHECDOC(ushort BOPLKFIGMPG, ushort FGFIBKIMEGI, BMAMJOJAPPA GBLKEPEGHHH, BMAMJOJAPPA LNLIPBHKBMF, OEHMPPICLNK CEMGLEAMMLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7475B30", Offset = "0x7474730", VA = "0x187475B30")]
	public void KAFGFLAKMPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7475B80", Offset = "0x7474780", VA = "0x187475B80")]
	protected KOGBIEIMBED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class MKBKBOKOBAG : KOGBIEIMBED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private bool HCJHBFOPPPA;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool DFIMOLGJAJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xAB3FC0", Offset = "0xAB2BC0", VA = "0x180AB3FC0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xBAC4A0", Offset = "0xBAB0A0", VA = "0x180BAC4A0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x7475DE0", Offset = "0x74749E0", VA = "0x187475DE0")]
	public void AIMKJDEKJHN(ushort NEDNHHFFHPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x7475D80", Offset = "0x7474980", VA = "0x187475D80")]
	public void AIMKJDEKJHN(ushort NEDNHHFFHPO, ushort HCANFMBHJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7475B80", Offset = "0x7474780", VA = "0x187475B80")]
	public MKBKBOKOBAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public abstract class PNBJANABKMJ<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	internal class NBPDFMMFMKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public TNode DKGDAEBOJKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public TNode KOIBCEOILEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public DNPLADKFCIE MGIILDCJJIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public List<DNPLADKFCIE> DNBFEECDLAN;

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public NBPDFMMFMKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal struct DNPLADKFCIE : IComparable<DNPLADKFCIE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int NCDDNNAKJAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public TClaimant HNPAAKPOIKC;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x142BCA0", Offset = "0x142A8A0", VA = "0x18142BCA0")]
		public DNPLADKFCIE(int NCDDNNAKJAH, TClaimant HNPAAKPOIKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x6332FB0", Offset = "0x6331BB0", VA = "0x186332FB0")]
		public bool NGPFDMKNHCJ([In] DNPLADKFCIE PELBNOCGOOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x6332FA0", Offset = "0x6331BA0", VA = "0x186332FA0")]
		public bool KGCCAIFPNKI([In] DNPLADKFCIE PELBNOCGOOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x6332F90", Offset = "0x6331B90", VA = "0x186332F90", Slot = "4")]
		public int CompareTo(DNPLADKFCIE PELBNOCGOOJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x6333010", Offset = "0x6331C10", VA = "0x186333010", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public enum LAMHHCFFFPN
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class EBIBAGLMAPD : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public PNBJANABKMJ<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0xD30330", Offset = "0xD2EF30", VA = "0x180D30330")]
		[DebuggerHidden]
		public EBIBAGLMAPD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3FB1090", Offset = "0x3FAFC90", VA = "0x183FB1090", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x3FB12B0", Offset = "0x3FAFEB0", VA = "0x183FB12B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3FB1170", Offset = "0x3FAFD70", VA = "0x183FB1170", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3FB1270", Offset = "0x3FAFE70", VA = "0x183FB1270", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly NOLPMEOMMPP<NBPDFMMFMKH> BMAEHGHNOEM;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly NOLPMEOMMPP<List<DNPLADKFCIE>> HAIIMKLHBGG;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static int IGLMNELFHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	internal readonly Dictionary<TClaimant, TNode> ELKIEPCACLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	internal readonly Dictionary<TNode, NBPDFMMFMKH> EFJODKOAPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private LAMHHCFFFPN GLPFCMCNEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool EIHBPFOIIHI;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode BHGPEABHJBH(TNode PCMPEACCDMA);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void BCNDKDBNNEO(TNode PCMPEACCDMA, TClaimant EACOHLGAMAP, TClaimant DJKDDNMHEJB);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5075FE0", Offset = "0x5074BE0", VA = "0x185075FE0")]
	public PNBJANABKMJ(LAMHHCFFFPN GLPFCMCNEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x5074730", Offset = "0x5073330", VA = "0x185074730")]
	public void BBABOMPGMNB(TNode PCMPEACCDMA, TNode BDHPANPFDPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x5075AD0", Offset = "0x50746D0", VA = "0x185075AD0")]
	public void PABLJMOGKAF(TClaimant HNPAAKPOIKC, TNode MONPJNGCDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x5074AA0", Offset = "0x50736A0", VA = "0x185074AA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x5074CC0", Offset = "0x50738C0", VA = "0x185074CC0")]
	private void ECNPLIEIJKK(TClaimant HNPAAKPOIKC, TNode MOBGADKLBJG, TNode MONPJNGCDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x5074F00", Offset = "0x5073B00", VA = "0x185074F00")]
	private int HCJNNLOANED()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x50743D0", Offset = "0x5072FD0", VA = "0x1850743D0")]
	private void AIJGJCKELNE(TClaimant HNPAAKPOIKC, TNode CGGPBJHANIA, TNode JECGKJCNLGP, int ECIJONDAJLP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x50759F0", Offset = "0x50745F0", VA = "0x1850759F0")]
	private void NEJHNNBDDAB(DNPLADKFCIE DEOIPPINBHN, NBPDFMMFMKH HDBPBMNJNAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x5075070", Offset = "0x5073C70", VA = "0x185075070")]
	private void HPIGNJCNPDN(TClaimant HNPAAKPOIKC, TNode CGGPBJHANIA, TNode JECGKJCNLGP, int ECIJONDAJLP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x5074800", Offset = "0x5073400", VA = "0x185074800")]
	private void BKNGMHHLEMG(DNPLADKFCIE DEOIPPINBHN, TNode PCMPEACCDMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x5074D90", Offset = "0x5073990", VA = "0x185074D90")]
	private void GIMBCJCCNIM(DNPLADKFCIE DEOIPPINBHN, NBPDFMMFMKH HDBPBMNJNAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x5074940", Offset = "0x5073540", VA = "0x185074940")]
	private void CCAEEEGNJGH(NBPDFMMFMKH HDBPBMNJNAE, bool FDHCJDOMKJG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x5075370", Offset = "0x5073F70", VA = "0x185075370")]
	private void MDKDHJFFHMB(NBPDFMMFMKH HDBPBMNJNAE, TNode BDHPANPFDPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5074F70", Offset = "0x5073B70", VA = "0x185074F70")]
	[IteratorStateMachine(typeof(PNBJANABKMJ<, >.EBIBAGLMAPD))]
	private IEnumerable<TNode> HPCILBLAGAI(TNode CGGPBJHANIA, TNode JECGKJCNLGP, bool JDIGGCLDDIB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5075700", Offset = "0x5074300", VA = "0x185075700")]
	private NBPDFMMFMKH MJBMAGCLIKD(TNode PCMPEACCDMA, TNode KOIBCEOILEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5075C70", Offset = "0x5074870", VA = "0x185075C70")]
	private NBPDFMMFMKH PCLOLODJGDD(TNode PCMPEACCDMA, TNode KOIBCEOILEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5075820", Offset = "0x5074420", VA = "0x185075820")]
	private void NDMOLLGMNIB(NBPDFMMFMKH HDBPBMNJNAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class ILLEABLABNC<T> : IEnumerable<ILLEABLABNC<T>.GGJKIIPAEMJ>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public struct GGJKIIPAEMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public T MPDLOLIOGJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public int BIEEMEKMINN;
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class NOGALGCGBFE : IEnumerator<GGJKIIPAEMJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private ILLEABLABNC<T> LIJANAIJBCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int BIEEMEKMINN;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x40118A0", Offset = "0x40104A0", VA = "0x1840118A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public GGJKIIPAEMJ OAKKBGDNIKI
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x4E60850", Offset = "0x4E5F450", VA = "0x184E60850", Slot = "4")]
			get
			{
				return default(GGJKIIPAEMJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x4E60810", Offset = "0x4E5F410", VA = "0x184E60810")]
		public NOGALGCGBFE(ILLEABLABNC<T> LIJANAIJBCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x4E60790", Offset = "0x4E5F390", VA = "0x184E60790", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x406E930", Offset = "0x406D530", VA = "0x18406E930", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xF73A20", Offset = "0xF72620", VA = "0x180F73A20", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private struct ILEFPHIFAIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public bool ENIBBGDOODD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public T MPDLOLIOGJL;
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private const int CDNFKDNKPMA = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly Dictionary<T, int> KOBPADOHFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private ILEFPHIFAIK[] HOHJHIPNIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int DKOIMKFCANF;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int BPMIKBMHNFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x9994B0", Offset = "0x9980B0", VA = "0x1809994B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x998AA0", Offset = "0x9976A0", VA = "0x180998AA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int PHJGKILIPGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3CCA4E0", Offset = "0x3CC90E0", VA = "0x183CCA4E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x470BB10", Offset = "0x470A710", VA = "0x18470BB10")]
	public ILLEABLABNC(int MFFEHHIHGMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x470BC00", Offset = "0x470A800", VA = "0x18470BC00")]
	public ILLEABLABNC(GGJKIIPAEMJ[] MJBFNNENGJD, bool AMOFFPHGJBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x470B2A0", Offset = "0x4709EA0", VA = "0x18470B2A0")]
	public int ONKIKCEHPIM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x470AD70", Offset = "0x4709970", VA = "0x18470AD70")]
	private int JBMICGHLFEE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x470ABB0", Offset = "0x47097B0", VA = "0x18470ABB0", Slot = "6")]
	protected virtual uint AMDLNGJEDLC(uint DGGBCMIMPNF, T MPDLOLIOGJL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x470ACB0", Offset = "0x47098B0", VA = "0x18470ACB0")]
	public bool INKNHBFADMF(T MPDLOLIOGJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x470B3F0", Offset = "0x4709FF0", VA = "0x18470B3F0")]
	public int PFNHNAGBAMA(T MPDLOLIOGJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x470B230", Offset = "0x4709E30", VA = "0x18470B230")]
	public T NEMCFBJMFJD(int BIEEMEKMINN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x470B9A0", Offset = "0x470A5A0", VA = "0x18470B9A0")]
	public bool PIBDMDIJCIO(T MPDLOLIOGJL, bool OJMNKAPLPHI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x470B480", Offset = "0x470A080", VA = "0x18470B480")]
	public bool PIBDMDIJCIO(T MPDLOLIOGJL, int BIEEMEKMINN, bool OJMNKAPLPHI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x470AC10", Offset = "0x4709810", VA = "0x18470AC10")]
	private int FJGIJEHGDGD(int PKAJCFBDMNB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x470BA70", Offset = "0x470A670", VA = "0x18470BA70", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x470BA70", Offset = "0x470A670", VA = "0x18470BA70", Slot = "4")]
	private IEnumerator<GGJKIIPAEMJ> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class NOLPMEOMMPP<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly Stack<T> NGCIGINBCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly List<T> NJBKEFFAKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly int JGPEOEKPFEC;

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x4E61770", Offset = "0x4E60370", VA = "0x184E61770")]
	public static NOLPMEOMMPP<T> BLFODCLFNHP(int MFFEHHIHGMB = 0, int JGPEOEKPFEC = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x4E62020", Offset = "0x4E60C20", VA = "0x184E62020")]
	public static NOLPMEOMMPP<T> POHDLNDGPJK(int MFFEHHIHGMB = 0, int JGPEOEKPFEC = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x4E62120", Offset = "0x4E60D20", VA = "0x184E62120")]
	public NOLPMEOMMPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x4E62170", Offset = "0x4E60D70", VA = "0x184E62170")]
	public NOLPMEOMMPP(int MFFEHHIHGMB, int JGPEOEKPFEC = int.MaxValue, bool ONEGKIEKHKM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x4E61B00", Offset = "0x4E60700", VA = "0x184E61B00")]
	public T FDMJAGPJNJE()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x4E61EE0", Offset = "0x4E60AE0", VA = "0x184E61EE0")]
	public void GFEMBPJJFIN(T MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x4E61A00", Offset = "0x4E60600", VA = "0x184E61A00")]
	private void FCDBIDDFEBH(T MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x4E61FD0", Offset = "0x4E60BD0", VA = "0x184E61FD0")]
	private void HKHMKAHGKOJ(T MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x4E61870", Offset = "0x4E60470", VA = "0x184E61870", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x4E61CE0", Offset = "0x4E608E0", VA = "0x184E61CE0")]
	private void FPMNJGEBIJI(IEnumerable<T> FKBJBKHIAAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class JFGENNBFBML<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private Dictionary<int, T> FLHCIALOJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private T JJKAIAGNFFH;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public virtual T PHHMBCMMKBF
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x957510", Offset = "0x956110", VA = "0x180957510", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x4933310", Offset = "0x4931F10", VA = "0x184933310")]
	public bool GPELINLBKLH(T MPDLOLIOGJL, int NCDDNNAKJAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x462D0A0", Offset = "0x462BCA0", VA = "0x18462D0A0")]
	public bool KFMHBEHFAMB(int NCDDNNAKJAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x4933920", Offset = "0x4932520", VA = "0x184933920")]
	public T MAHDOMGBFOD(int NGGNGHJMIID)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x4933590", Offset = "0x4932190", VA = "0x184933590")]
	private bool LICBGCFECMN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x4933470", Offset = "0x4932070", VA = "0x184933470")]
	public bool JLHCCLDIOMP(int NCDDNNAKJAH, [Out] T MPDLOLIOGJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x4933B40", Offset = "0x4932740", VA = "0x184933B40")]
	public JFGENNBFBML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class HIIANICOLAO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	protected struct OHGPNNKBCNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public T GNLOKINMAMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int EKAHNEHFJDM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	protected readonly List<OHGPNNKBCNI> JABLPMBIKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private T DGDHBLPOJEL;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public int PHJGKILIPGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3CCA4E0", Offset = "0x3CC90E0", VA = "0x183CCA4E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x462AAB0", Offset = "0x46296B0", VA = "0x18462AAB0")]
	public bool IKPHFMNIAIK(T MPDLOLIOGJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x462A770", Offset = "0x4629370", VA = "0x18462A770")]
	public void GFCJDEIJPEO(T MPDLOLIOGJL, int NCDDNNAKJAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x462A560", Offset = "0x4629160", VA = "0x18462A560")]
	public bool BLAPNJAELFA(T MPDLOLIOGJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x462AE50", Offset = "0x4629A50", VA = "0x18462AE50")]
	public void NGMONOEHMBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x462AD10", Offset = "0x4629910", VA = "0x18462AD10")]
	public T LEAOKCHCFND()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x462B090", Offset = "0x4629C90", VA = "0x18462B090")]
	protected void PBBFAIELMAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x462B220", Offset = "0x4629E20", VA = "0x18462B220")]
	public HIIANICOLAO()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[NEHJBMHDGNH(EGFPEOBPDHA.Self, false, false, false)]
		[SerializeField]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x7477060", Offset = "0x7475C60", VA = "0x187477060")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x7477330", Offset = "0x7475F30", VA = "0x187477330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x7477240", Offset = "0x7475E40", VA = "0x187477240")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x7476FB0", Offset = "0x7475BB0", VA = "0x187476FB0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x7477280", Offset = "0x7475E80", VA = "0x187477280")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x7477190", Offset = "0x7475D90", VA = "0x187477190")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7476F30", Offset = "0x7475B30", VA = "0x187476F30")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x523D760", Offset = "0x523C360", VA = "0x18523D760", Slot = "4")]
		public virtual T HFLDMOCABOP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class OKDBKDGLNMO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private Dictionary<byte, ALEHEINNBJN> NINPHMKDKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly NOLPMEOMMPP<ALEHEINNBJN> HHBCIFJDEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly bool CEBBIDGMNBK;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public ALEHEINNBJN AJAOBHNNAHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x957520", Offset = "0x956120", VA = "0x180957520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector2 HCIJJMDFFMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x13A9660", Offset = "0x13A8260", VA = "0x1813A9660")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xAFA780", Offset = "0xAF9380", VA = "0x180AFA780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	private Vector2 MDFGHHKFMJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xB46DD0", Offset = "0xB459D0", VA = "0x180B46DD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector2 HACMIGFLODE
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7476E50", Offset = "0x7475A50", VA = "0x187476E50")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x95CF10", Offset = "0x95BB10", VA = "0x18095CF10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int EILKMDHIIIE
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x966260", Offset = "0x964E60", VA = "0x180966260")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x965EF0", Offset = "0x964AF0", VA = "0x180965EF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x7476E70", Offset = "0x7475A70", VA = "0x187476E70")]
	public OKDBKDGLNMO(Bounds EGJLEJJBIAG, Vector2[] OAFKALGDDKO, int IBOJIEDICGL, byte PKAJCFBDMNB, float NPPIPJIAJEF = 0f, [Optional] NOLPMEOMMPP<ALEHEINNBJN> HHBCIFJDEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x7475FB0", Offset = "0x7474BB0", VA = "0x187475FB0")]
	public void CPNGIGPGOIB(Bounds EGJLEJJBIAG, Vector2[] OAFKALGDDKO, int IBOJIEDICGL, byte PKAJCFBDMNB, float NPPIPJIAJEF = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x7476DF0", Offset = "0x74759F0", VA = "0x187476DF0")]
	public ALEHEINNBJN KDHEOCCAGOM(byte BIEEMEKMINN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x7475EE0", Offset = "0x7474AE0", VA = "0x187475EE0")]
	public void BLCJKDJAJJF(Vector3 FCININPMBGJ, float FKGMEFCFBAA, float FOCNBHPKMKF, List<byte> JPMPLPDNNKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x7475EC0", Offset = "0x7474AC0", VA = "0x187475EC0")]
	public void AIKJFENOHEI(ALEHEINNBJN.LGKEGNGEHBO GEKDNKLKOMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x7476A80", Offset = "0x7475680", VA = "0x187476A80")]
	public static int FFBPPLCNDKE(Vector2[] OAFKALGDDKO, int IBOJIEDICGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x7476B60", Offset = "0x7475760", VA = "0x187476B60")]
	private ALEHEINNBJN FLGNACOBNGK(byte BIEEMEKMINN, ALEHEINNBJN.IIEDDKELIIL JPPHEOEPOIM, ALEHEINNBJN KOIBCEOILEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x74764A0", Offset = "0x74750A0", VA = "0x1874764A0")]
	private void EFCNFMFMMBN(ALEHEINNBJN KOIBCEOILEL, Vector2[] OAFKALGDDKO, int NDFPNAGPHJA, int HHHPGDJADLM, int OGPNEABFFOO, int FBBDJKCJMJA, float NPPIPJIAJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x7476860", Offset = "0x7475460", VA = "0x187476860")]
	private void FAFPAPMCNNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x7476440", Offset = "0x7475040", VA = "0x187476440", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x7476D90", Offset = "0x7475990", VA = "0x187476D90", Slot = "1")]
	~OKDBKDGLNMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class ALEHEINNBJN
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public enum IIEDDKELIIL
	{
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public enum LGKEGNGEHBO
	{
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public byte BJDOFIJCIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public Vector3 JODBPODNMAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public Vector3 BNJMONPHFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public Vector3 DOPFDDJCEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public Vector3 ONGEGBBINEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public IIEDDKELIIL CNIPMOGEGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public ALEHEINNBJN HNLFKIAHAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public List<ALEHEINNBJN> AMBLIAHGPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public bool GNLDCJBIEDM;

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x7472E70", Offset = "0x7471A70", VA = "0x187472E70")]
	public ALEHEINNBJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x7472D00", Offset = "0x7471900", VA = "0x187472D00")]
	public void FOMJBDKJEKF(ALEHEINNBJN DEDKLMDDBBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0")]
	public void AIKJFENOHEI(int GPCCCOLDHFC, LGKEGNGEHBO GEKDNKLKOMN, int MJLAHLDPOLN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x7472AA0", Offset = "0x74716A0", VA = "0x187472AA0")]
	public void BLCJKDJAJJF(List<byte> JPMPLPDNNKB, Vector3 FCININPMBGJ, float FKGMEFCFBAA, float FOCNBHPKMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x7472E40", Offset = "0x7471A40", VA = "0x187472E40")]
	public bool HJGDGFCIBLC(Vector3 LMLKPPMEPBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x7472A70", Offset = "0x7471670", VA = "0x187472A70")]
	public bool BCIIHGAMKCP(Vector3 LMLKPPMEPBH, float APHNDBHBHNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x74729E0", Offset = "0x74715E0", VA = "0x1874729E0")]
	public void AIMKJDEKJHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public interface MDAGAAGHHNH
{
	[Cpp2IlInjected.Token(Token = "0x17000075")]
	ToolHierarchyCache EKGCBICKJKK
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		public struct IPAFNDJOACJ<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			private readonly List<Component> DGHHCPPFODF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			private readonly bool CDEPDLNPIIG;

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x1554050", Offset = "0x1552C50", VA = "0x181554050")]
			public IPAFNDJOACJ(List<Component> DGHHCPPFODF, bool CDEPDLNPIIG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x47199C0", Offset = "0x47185C0", VA = "0x1847199C0")]
			public MAAJHJILMCO<T> HCMJLOGCBCL()
			{
				return default(MAAJHJILMCO<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x4719A30", Offset = "0x4718630", VA = "0x184719A30", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x4719A30", Offset = "0x4718630", VA = "0x184719A30", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public struct MAAJHJILMCO<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			private readonly List<Component> DGHHCPPFODF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			private readonly bool CDEPDLNPIIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			private int BIEEMEKMINN;

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public T OAKKBGDNIKI
			{
				[Cpp2IlInjected.Token(Token = "0x6000261")]
				[Cpp2IlInjected.Address(RVA = "0x4D22570", Offset = "0x4D21170", VA = "0x184D22570", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000262")]
				[Cpp2IlInjected.Address(RVA = "0x4D22500", Offset = "0x4D21100", VA = "0x184D22500", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x4D22540", Offset = "0x4D21140", VA = "0x184D22540")]
			public MAAJHJILMCO(List<Component> DGHHCPPFODF, bool CDEPDLNPIIG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x4D22440", Offset = "0x4D21040", VA = "0x184D22440", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x4D22450", Offset = "0x4D21050", VA = "0x184D22450", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x405BDE0", Offset = "0x405A9E0", VA = "0x18405BDE0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x7478D20", Offset = "0x7477920", VA = "0x187478D20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x74786D0", Offset = "0x74772D0", VA = "0x1874786D0")]
		private void AIMKJDEKJHN(GameObject JLPPPOOLECD, bool NBNIPGNLIMD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x7478640", Offset = "0x7477240", VA = "0x187478640")]
		public static void AIMKJDEKJHN(GameObject JLPPPOOLECD, ToolHierarchyCache POACKIHOABP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x7478930", Offset = "0x7477530", VA = "0x187478930")]
		public void HFOENCNPEGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x36DE920", Offset = "0x36DD520", VA = "0x1836DE920")]
		public void KJIBLBPCCPL<T>(Action<T> OAGMINHECCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x36DE880", Offset = "0x36DD480", VA = "0x1836DE880")]
		public T FCHPOFHPKEC<T>(bool CDEPDLNPIIG = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x36DE7C0", Offset = "0x36DD3C0", VA = "0x1836DE7C0")]
		public IPAFNDJOACJ<T> AAAMEIHDGOI<T>(bool CDEPDLNPIIG = false) where T : class
		{
			return default(IPAFNDJOACJ<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x7478940", Offset = "0x7477540", VA = "0x187478940")]
		public List<Component> LAPCPNBFABE(Type ADFFEBFOCBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x7478840", Offset = "0x7477440", VA = "0x187478840", Slot = "4")]
		public bool Equals(ToolHierarchyCache MDFKHKOGFDI, ToolHierarchyCache ELJEANFLEPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x74788C0", Offset = "0x74774C0", VA = "0x1874788C0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache CFMCKCBBBKK)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class BLMLLLHGLGF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int MFFEHHIHGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int FEFJIFCPGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private List<T> EJIKONGOMAJ;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public int PHJGKILIPGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x4713780", Offset = "0x4712380", VA = "0x184713780")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public T CHADECDLCFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x5812000", Offset = "0x5810C00", VA = "0x185812000")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public T FLKPDLMCFPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x5811E10", Offset = "0x5810A10", VA = "0x185811E10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public T EIPBBIEDNBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x5812530", Offset = "0x5811130", VA = "0x185812530")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x5812690", Offset = "0x5811290", VA = "0x185812690")]
	public BLMLLLHGLGF(int MFFEHHIHGMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x5812350", Offset = "0x5810F50", VA = "0x185812350")]
	public void GFCJDEIJPEO(T LJDJMGGJMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x5812630", Offset = "0x5811230", VA = "0x185812630")]
	public void NGMONOEHMBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x58120E0", Offset = "0x5810CE0", VA = "0x1858120E0")]
	public void FJNJBGPPLLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x58124C0", Offset = "0x58110C0", VA = "0x1858124C0")]
	public void HANKNOHDIKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x5812620", Offset = "0x5811220", VA = "0x185812620")]
	public void LLNKIHHFLDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x5811E90", Offset = "0x5810A90", VA = "0x185811E90")]
	public List<T> DDMLPECBBKN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class GOPCCLCPPEB<T>
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private struct APNOECAKNHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public int EKAHNEHFJDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public T GNLOKINMAMH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly Dictionary<object, APNOECAKNHH> FLHCIALOJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly EqualityComparer<T> DBNLGLIFMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private T JJKAIAGNFFH;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public virtual T PHHMBCMMKBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xBDB0A0", Offset = "0xBD9CA0", VA = "0x180BDB0A0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x4524CD0", Offset = "0x45238D0", VA = "0x184524CD0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool GPAPHLJCFLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x4524D30", Offset = "0x4523930", VA = "0x184524D30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public object JEFGHLBHLFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x9574D0", Offset = "0x9560D0", VA = "0x1809574D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x9574E0", Offset = "0x9560E0", VA = "0x1809574E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x45250F0", Offset = "0x4523CF0", VA = "0x1845250F0")]
	public bool GPELINLBKLH(T MPDLOLIOGJL, object IKLHDHMJFFL, int NCDDNNAKJAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x45254D0", Offset = "0x45240D0", VA = "0x1845254D0")]
	public bool KFMHBEHFAMB(object IKLHDHMJFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x45253A0", Offset = "0x4523FA0", VA = "0x1845253A0")]
	public bool JLHCCLDIOMP(object IKLHDHMJFFL, [Out] T MPDLOLIOGJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x4526540", Offset = "0x4525140", VA = "0x184526540")]
	public void NGMONOEHMBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x4525590", Offset = "0x4524190", VA = "0x184525590")]
	private bool LICBGCFECMN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x45265A0", Offset = "0x45251A0", VA = "0x1845265A0")]
	public GOPCCLCPPEB()
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
