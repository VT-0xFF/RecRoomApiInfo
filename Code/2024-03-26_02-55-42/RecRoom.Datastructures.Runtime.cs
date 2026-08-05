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
		[Cpp2IlInjected.Address(RVA = "0x7E7D80", Offset = "0x7E7180", VA = "0x1807E7D80")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x618EA20", Offset = "0x618DE20", VA = "0x18618EA20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E8560", Offset = "0x7E7960", VA = "0x1807E8560")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7E85A0", Offset = "0x7E79A0", VA = "0x1807E85A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NBBFNALBJFP : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7CD100", Offset = "0x7CC500", VA = "0x1807CD100")]
	public NBBFNALBJFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, KGMECFNCPNG, CLDKOKPKMEM, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7BE4B0", Offset = "0x7BD8B0", VA = "0x1807BE4B0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7C1040", Offset = "0x7C0440", VA = "0x1807C1040", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7BE4C0", Offset = "0x7BD8C0", VA = "0x1807BE4C0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x87D480", Offset = "0x87C880", VA = "0x18087D480", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash EMBOHFOBPMK);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8A68F0", Offset = "0x8A5CF0", VA = "0x1808A68F0")]
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
	[SerializeField]
	[IPAIEPBNPDL]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[SerializeField]
	[HideInInspector]
	[IPAIEPBNPDL]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x618FF00", Offset = "0x618F300", VA = "0x18618FF00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x618FEC0", Offset = "0x618F2C0", VA = "0x18618FEC0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x618FF40", Offset = "0x618F340", VA = "0x18618FF40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x61900F0", Offset = "0x618F4F0", VA = "0x1861900F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6190060", Offset = "0x618F460", VA = "0x186190060")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x944730", Offset = "0x943B30", VA = "0x180944730")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9FAB00", Offset = "0x9F9F00", VA = "0x1809FAB00")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x618FE80", Offset = "0x618F280", VA = "0x18618FE80")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x618FFD0", Offset = "0x618F3D0", VA = "0x18618FFD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x618F8F0", Offset = "0x618ECF0", VA = "0x18618F8F0")]
	public void CopyBounds(SavedExtents MGDPHHCBMMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x618FDD0", Offset = "0x618F1D0", VA = "0x18618FDD0")]
	public void SetLocalSpaceBounds(Bounds ININPDGMBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA165E0", Offset = "0xA159E0", VA = "0x180A165E0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x618FDC0", Offset = "0x618F1C0", VA = "0x18618FDC0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x618F920", Offset = "0x618ED20", VA = "0x18618F920")]
	private void LLONAICDPGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x618FBA0", Offset = "0x618EFA0", VA = "0x18618FBA0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x618F280", Offset = "0x618E680", VA = "0x18618F280")]
	public static void CalculateLocalBoundsFor(GameObject LMKHHJAKBGC, [Out] Bounds ININPDGMBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x618FAE0", Offset = "0x618EEE0", VA = "0x18618FAE0")]
	private static void OMOLJJDOHMO(Bounds GJKNLEMINPO, Color EJPBINEJNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x618FDF0", Offset = "0x618F1F0", VA = "0x18618FDF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BC180", Offset = "0x7BB580", VA = "0x1807BC180")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7C6790", Offset = "0x7C5B90", VA = "0x1807C6790")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xE5E760", Offset = "0xE5DB60", VA = "0x180E5E760")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x438FD80", Offset = "0x438F180", VA = "0x18438FD80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "4")]
	public virtual void ALBIJJPAONN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
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
	[SerializeField]
	[NBBFNALBJFP]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x438F960", Offset = "0x438ED60", VA = "0x18438F960", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x438E600", Offset = "0x438DA00", VA = "0x18438E600", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x438FCB0", Offset = "0x438F0B0", VA = "0x18438FCB0")]
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
	private sealed class NOKFBGAALNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public NOKFBGAALNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4007730", Offset = "0x4006B30", VA = "0x184007730")]
		internal int AFNKJNCDLEE(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[NBBFNALBJFP]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x337EDD0", Offset = "0x337E1D0", VA = "0x18337EDD0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x337EE20", Offset = "0x337E220", VA = "0x18337EE20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x337ECD0", Offset = "0x337E0D0", VA = "0x18337ECD0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey NIOPCMHKLMB]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x337ED70", Offset = "0x337E170", VA = "0x18337ED70", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x337EBB0", Offset = "0x337DFB0", VA = "0x18337EBB0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x337E8D0", Offset = "0x337DCD0", VA = "0x18337E8D0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x337DD70", Offset = "0x337D170", VA = "0x18337DD70", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x337DD10", Offset = "0x337D110", VA = "0x18337DD10", Slot = "14")]
	protected virtual string IAIAJMAIMJP(TKeyVal CDKLOELLLBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x337DBF0", Offset = "0x337CFF0", VA = "0x18337DBF0", Slot = "4")]
	public bool ContainsKey(TKey NIOPCMHKLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x337EA70", Offset = "0x337DE70", VA = "0x18337EA70", Slot = "5")]
	public bool TryGetValue(TKey NIOPCMHKLMB, [Out] TVal PCGOHCLJAPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x337DC40", Offset = "0x337D040", VA = "0x18337DC40", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x337DC40", Offset = "0x337D040", VA = "0x18337DC40", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x337EAC0", Offset = "0x337DEC0", VA = "0x18337EAC0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class BJPFMGPMNDC<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class DOMAANKENCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public float KMBPNPEHFPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public T EIHNEEOMIED;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public DOMAANKENCH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class PFLDIJNHPEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public PFLDIJNHPEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x41981E0", Offset = "0x41975E0", VA = "0x1841981E0")]
		internal bool DCFOHILDNFF(DOMAANKENCH sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly float KJMNNFKCDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly float HKDHOKMDALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<DOMAANKENCH> IABAAFKLHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private EKJKPBAIBIP<DOMAANKENCH> EHGJCNBBBNM;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int HJKLOMKOCKF
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4813A60", Offset = "0x4812E60", VA = "0x184813A60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4814680", Offset = "0x4813A80", VA = "0x184814680")]
	public BJPFMGPMNDC(float IMMPALHLECP, float OOHFGALJGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4813CA0", Offset = "0x48130A0", VA = "0x184813CA0")]
	public bool KGLHMDHFPAI(float BBPLEPJCAHF, T PCGOHCLJAPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4813FB0", Offset = "0x48133B0", VA = "0x184813FB0")]
	public IEnumerable<T> NMEFOIOJOPL(float BBPLEPJCAHF, [Optional] float? EPBLKJEGNGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4814610", Offset = "0x4813A10", VA = "0x184814610")]
	public void OIGNPMFKFFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4813B40", Offset = "0x4812F40", VA = "0x184813B40")]
	private void BNMJHHMIACA(float BBPLEPJCAHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class LGENBOPBNML<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct BGIPDAHKDIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public T EIHNEEOMIED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public float CLNKEFLHKFN;
	}

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static float KBKGEFENCMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private List<T> FOIGMMGPDCL;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private const int HDAOAEENIAF = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private BGIPDAHKDIC[] KGECIFKDBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int EAHDGOLPEHK;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float JKENCPCIMKH
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x848FE0", Offset = "0x8483E0", VA = "0x180848FE0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8786E0", Offset = "0x877AE0", VA = "0x1808786E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3D143F0", Offset = "0x3D137F0", VA = "0x183D143F0")]
	public LGENBOPBNML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3D14300", Offset = "0x3D13700", VA = "0x183D14300")]
	public LGENBOPBNML(int HIAJHKACHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3D139E0", Offset = "0x3D12DE0", VA = "0x183D139E0")]
	public void FFIECPFJEFG(float BBPLEPJCAHF, T PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3D141B0", Offset = "0x3D135B0", VA = "0x183D141B0")]
	public void OIGNPMFKFFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3D136F0", Offset = "0x3D12AF0", VA = "0x183D136F0")]
	public bool ENDPELCELON(float DFBILAELKII, float LMBDGINPCPC, [Out] T PCGOHCLJAPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3D13D30", Offset = "0x3D13130", VA = "0x183D13D30")]
	public bool MNDAIANDHMI(float DFBILAELKII, float LMBDGINPCPC, [Out] T PCGOHCLJAPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3D13AA0", Offset = "0x3D12EA0", VA = "0x183D13AA0")]
	public void MEDGFHFMDGF(float DFBILAELKII, float LMBDGINPCPC, List<T> DPJOGLFAKHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3D138F0", Offset = "0x3D12CF0", VA = "0x183D138F0")]
	private int ENPJEAIBIIK(int DEFLLFNOIHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3D13420", Offset = "0x3D12820", VA = "0x183D13420")]
	private void AGEGNPGIJAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T LDJKIMHDBLF();

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T LDOPBPLJKKD(T PCGOHCLJAPN, float PLGHLMOEPOB);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T OMDCPFAHPNO(T LCALDLBCJKP, T JPKPFNMFEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T GPPBADLHANI(T LCALDLBCJKP, T JPKPFNMFEIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class KFMFEHFAHKE : LGENBOPBNML<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7CD990", Offset = "0x7CCD90", VA = "0x1807CD990", Slot = "4")]
	protected override Vector3 LDJKIMHDBLF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x618E700", Offset = "0x618DB00", VA = "0x18618E700", Slot = "5")]
	protected override Vector3 LDOPBPLJKKD(Vector3 PCGOHCLJAPN, float PLGHLMOEPOB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x618E740", Offset = "0x618DB40", VA = "0x18618E740", Slot = "6")]
	protected override Vector3 OMDCPFAHPNO(Vector3 LCALDLBCJKP, Vector3 JPKPFNMFEIJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x618E680", Offset = "0x618DA80", VA = "0x18618E680", Slot = "7")]
	protected override Vector3 GPPBADLHANI(Vector3 LCALDLBCJKP, Vector3 JPKPFNMFEIJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x618E790", Offset = "0x618DB90", VA = "0x18618E790")]
	public KFMFEHFAHKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class IHGDFGJHIDJ
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x282AA00", Offset = "0x2829E00", VA = "0x18282AA00")]
	public static BLMCJPAANMI<T1, T2> HEJOOLMEDMH<T1, T2>(T1 LJGCGJMMOLP, T2 CDEGGKADHIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x282AA80", Offset = "0x2829E80", VA = "0x18282AA80")]
	public static JKNKPOMNPDB<T1, T2, T3> HEJOOLMEDMH<T1, T2, T3>(T1 LJGCGJMMOLP, T2 CDEGGKADHIJ, T3 DLPCIAJBAEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3F5AB40", Offset = "0x3F59F40", VA = "0x183F5AB40")]
	internal static int LKJMCIKBNCD(int PINMFGPFKOF, int BKNNFLOGFEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x55B30C0", Offset = "0x55B24C0", VA = "0x1855B30C0")]
	internal static int LKJMCIKBNCD(int PINMFGPFKOF, int BKNNFLOGFEP, int AGPNFEPBMDF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class BLMCJPAANMI<T1, T2> : IComparable<BLMCJPAANMI<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly T1 FFPFHHEOPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly T2 IOMLDMBNBPI;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4832930", Offset = "0x4831D30", VA = "0x184832930")]
	public BLMCJPAANMI(T1 LJGCGJMMOLP, T2 CDEGGKADHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x48313C0", Offset = "0x48307C0", VA = "0x1848313C0", Slot = "4")]
	public int CompareTo(BLMCJPAANMI<T1, T2> MGDPHHCBMMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4831870", Offset = "0x4830C70", VA = "0x184831870", Slot = "0")]
	public override bool Equals(object MGDPHHCBMMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4831FE0", Offset = "0x48313E0", VA = "0x184831FE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x48320B0", Offset = "0x48314B0", VA = "0x1848320B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class JKNKPOMNPDB<T1, T2, T3> : IComparable<JKNKPOMNPDB<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly T1 FFPFHHEOPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly T2 IOMLDMBNBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly T3 BECMMPIIFLF;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3BAAE00", Offset = "0x3BAA200", VA = "0x183BAAE00")]
	public JKNKPOMNPDB(T1 LJGCGJMMOLP, T2 CDEGGKADHIJ, T3 DLPCIAJBAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3BAA600", Offset = "0x3BA9A00", VA = "0x183BAA600", Slot = "4")]
	public int CompareTo(JKNKPOMNPDB<T1, T2, T3> MGDPHHCBMMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3BAA850", Offset = "0x3BA9C50", VA = "0x183BAA850", Slot = "0")]
	public override bool Equals(object MGDPHHCBMMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3BAAA00", Offset = "0x3BA9E00", VA = "0x183BAAA00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3BAAB30", Offset = "0x3BA9F30", VA = "0x183BAAB30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T EIHNEEOMIED
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2101930", Offset = "0x2100D30", VA = "0x182101930")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2101940", Offset = "0x2100D40", VA = "0x182101940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float NGNOLMHMNEN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8BEFE0", Offset = "0x8BE3E0", VA = "0x1808BEFE0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4582380", Offset = "0x4581780", VA = "0x184582380")]
	public T NPGMOHHGJGO(float PLGHLMOEPOB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4581EF0", Offset = "0x45812F0", VA = "0x184581EF0")]
	public T LKBHJCIOKKN(float PLGHLMOEPOB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T AJEBCHEPKHL(T LCALDLBCJKP, T JPKPFNMFEIJ, float PLGHLMOEPOB);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x618DF90", Offset = "0x618D390", VA = "0x18618DF90", Slot = "4")]
	protected override float AJEBCHEPKHL(float LCALDLBCJKP, float JPKPFNMFEIJ, float PLGHLMOEPOB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x618DFD0", Offset = "0x618D3D0", VA = "0x18618DFD0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xCE2F40", Offset = "0xCE2340", VA = "0x180CE2F40", Slot = "4")]
	protected override Vector3 AJEBCHEPKHL(Vector3 LCALDLBCJKP, Vector3 JPKPFNMFEIJ, float PLGHLMOEPOB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6190E00", Offset = "0x6190200", VA = "0x186190E00")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x618BBD0", Offset = "0x618AFD0", VA = "0x18618BBD0", Slot = "4")]
	protected override Color AJEBCHEPKHL(Color LCALDLBCJKP, Color JPKPFNMFEIJ, float PLGHLMOEPOB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x618BC90", Offset = "0x618B090", VA = "0x18618BC90")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class DJGALIAOFAM : BNDIDBCFCNC<string>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x618BD40", Offset = "0x618B140", VA = "0x18618BD40")]
	public DJGALIAOFAM(int MIFMOLKOCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x618BCD0", Offset = "0x618B0D0", VA = "0x18618BCD0", Slot = "6")]
	protected override uint DGIJMNNNFJA(uint EMBOHFOBPMK, string PCGOHCLJAPN)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class LHFBABIPCJG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly IDisposable GDCHCCJBKDM;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public LHFBABIPCJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct FDECPECJDDE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> EFHJHCMPDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int EMPJJMBIMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int EAHCLCJKADJ;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x36B8DA0", Offset = "0x36B81A0", VA = "0x1836B8DA0")]
	private FDECPECJDDE(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> EMAJNKHANNG, int EFFFFHMAONL, int NEDDKOPOKPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x36B8760", Offset = "0x36B7B60", VA = "0x1836B8760")]
	public static FDECPECJDDE<T> HGJFOBLHCKL()
	{
		return default(FDECPECJDDE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x36B80A0", Offset = "0x36B74A0", VA = "0x1836B80A0")]
	public (int, int, Task<T>) GIECODLJGIC(int NAODMDIIJFN, [Optional] CancellationToken KNKAEBKAEBM, double ABEDOEMHLPN = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x36B8860", Offset = "0x36B7C60", VA = "0x1836B8860")]
	public void LCAOFPBPHGF(int NAODMDIIJFN, int NEDDKOPOKPN, [In] T FEADNEEPDLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class EDDOJFJLJCC
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x618CF60", Offset = "0x618C360", VA = "0x18618CF60")]
	public static FDECPECJDDE<GLCFOAMDFIN> HGJFOBLHCKL()
	{
		return default(FDECPECJDDE<GLCFOAMDFIN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x618CFB0", Offset = "0x618C3B0", VA = "0x18618CFB0")]
	public static void LCAOFPBPHGF([In] this FDECPECJDDE<GLCFOAMDFIN> MEEBIDIALDO, int NAODMDIIJFN, int NEDDKOPOKPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class IEMJAHMMLCE<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<TKey, TVal> OGIEAKLJMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly Dictionary<TVal, TKey> EIPHDPCEHOB;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int ALDOGAGGHGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x312D4F0", Offset = "0x312C8F0", VA = "0x18312D4F0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool EFGCLFKEOMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ICollection<TKey> MCCONIHHGMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x399FB30", Offset = "0x399EF30", VA = "0x18399FB30", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> LAGEMNIOLMC
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x39A6910", Offset = "0x39A5D10", VA = "0x1839A6910", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal BEENPNFBNIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x39A6860", Offset = "0x39A5C60", VA = "0x1839A6860", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x39A6950", Offset = "0x39A5D50", VA = "0x1839A6950", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey BEENPNFBNIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x39A5C20", Offset = "0x39A5020", VA = "0x1839A5C20")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x39A5C70", Offset = "0x39A5070", VA = "0x1839A5C70", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x39A6690", Offset = "0x39A5A90", VA = "0x1839A6690", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x39A5B50", Offset = "0x39A4F50", VA = "0x1839A5B50", Slot = "9")]
	public void Add(TKey NIOPCMHKLMB, TVal PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x39A5BA0", Offset = "0x39A4FA0", VA = "0x1839A5BA0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> LPGJEPJPGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x399A840", Offset = "0x3999C40", VA = "0x18399A840", Slot = "8")]
	public bool ContainsKey(TKey NIOPCMHKLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x39A5D30", Offset = "0x39A5130", VA = "0x1839A5D30", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> LPGJEPJPGGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x39A65B0", Offset = "0x39A59B0", VA = "0x1839A65B0", Slot = "10")]
	public bool Remove(TKey NIOPCMHKLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x39A65E0", Offset = "0x39A59E0", VA = "0x1839A65E0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> LPGJEPJPGGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x39A6730", Offset = "0x39A5B30", VA = "0x1839A6730", Slot = "11")]
	public bool TryGetValue(TKey NIOPCMHKLMB, [Out] TVal PCGOHCLJAPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x39A6030", Offset = "0x39A5430", VA = "0x1839A6030", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x39A5D60", Offset = "0x39A5160", VA = "0x1839A5D60", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] KGECIFKDBHF, int PADDMAPAGBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x39A60D0", Offset = "0x39A54D0", VA = "0x1839A60D0")]
	public bool JFDMGELHHBG(TVal NIOPCMHKLMB, [Out] TKey PCGOHCLJAPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x39A6480", Offset = "0x39A5880", VA = "0x1839A6480")]
	private void PANCNPMBFOP(TKey NIOPCMHKLMB, TVal FNMPHGMIIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x39A5F00", Offset = "0x39A5300", VA = "0x1839A5F00")]
	private void FJLKELDEKGD(TKey NIOPCMHKLMB, TVal FNMPHGMIIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x39A6240", Offset = "0x39A5640", VA = "0x1839A6240")]
	private bool JOIPHEONDHE(TKey NIOPCMHKLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x39A6770", Offset = "0x39A5B70", VA = "0x1839A6770")]
	public IEMJAHMMLCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[DefaultMember("Item")]
public class ICOJJPIAIBM<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private ICOJJPIAIBM<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x33C57E0", Offset = "0x33C4BE0", VA = "0x1833C57E0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x33D4450", Offset = "0x33D3850", VA = "0x1833D4450", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x33D4ED0", Offset = "0x33D42D0", VA = "0x1833D4ED0")]
		public Enumerator(ICOJJPIAIBM<T> DPJOGLFAKHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x33D2580", Offset = "0x33D1980", VA = "0x1833D2580", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x33D3100", Offset = "0x33D2500", VA = "0x1833D3100", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x33D1910", Offset = "0x33D0D10", VA = "0x1833D1910")]
		private void ILIAEBMNIAE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private T[] IBONOHEEFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private int CAIMMNKGOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int LEKNPOHFBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int PAKIAOEKDPK;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int ALDOGAGGHGI
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3998F80", Offset = "0x3998380", VA = "0x183998F80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T BEENPNFBNIB
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3997D40", Offset = "0x3997140", VA = "0x183997D40")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x3999680", Offset = "0x3998A80", VA = "0x183999680")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3999C20", Offset = "0x3999020", VA = "0x183999C20")]
	public ICOJJPIAIBM(int MIFMOLKOCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3998DB0", Offset = "0x39981B0", VA = "0x183998DB0")]
	public void FFIECPFJEFG(T PLGHLMOEPOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3999910", Offset = "0x3998D10", VA = "0x183999910")]
	public void OIGNPMFKFFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3997FA0", Offset = "0x39973A0", VA = "0x183997FA0")]
	public void CHDKBPCMAOD(int JDBLGKLFJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3998770", Offset = "0x3997B70", VA = "0x183998770")]
	public void DHBENHADNIK(T[] KGECIFKDBHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3998080", Offset = "0x3997480", VA = "0x183998080")]
	public Enumerator CKFAHJNIOKH()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3999AF0", Offset = "0x3998EF0", VA = "0x183999AF0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3999AF0", Offset = "0x3998EF0", VA = "0x183999AF0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3999510", Offset = "0x3998910", VA = "0x183999510")]
	private int JDNGJBLKJIK(int PMLKPJNGBAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3998180", Offset = "0x3997580", VA = "0x183998180")]
	private int DHAFGDHIKJI(int PMLKPJNGBAD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public class MDMIDMLIECH<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly Func<Internal, External> BNOODEINFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private IReadOnlyList<Internal> OCAIIBKPIPH;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public External BEENPNFBNIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x3EF11F0", Offset = "0x3EF05F0", VA = "0x183EF11F0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int ALDOGAGGHGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3EF11A0", Offset = "0x3EF05A0", VA = "0x183EF11A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5D0", Offset = "0x7C99D0", VA = "0x1807CA5D0")]
	public MDMIDMLIECH(Func<Internal, External> BNOODEINFKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3EF1150", Offset = "0x3EF0550", VA = "0x183EF1150")]
	public MDMIDMLIECH(IReadOnlyList<Internal> OCAIIBKPIPH, Func<Internal, External> BNOODEINFKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3EF10D0", Offset = "0x3EF04D0", VA = "0x183EF10D0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x36C3B00", Offset = "0x36C2F00", VA = "0x1836C3B00", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class LONIALJHEDA<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public delegate Task<TResult> HLADFCEPFDE(TRequest BDAAOBFBLIB, CancellationToken KNKAEBKAEBM);

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum CMHEJBBKNPF
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class GLNFONCHENL
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private const float IGPHKGABMAK = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TimeSpan HNNIJLNJLLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public int EFIOELKADEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public CMHEJBBKNPF BANOAPCLEPF;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public static readonly GLNFONCHENL AEDHDHNAKOP;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float LCLHBNBCIJL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x37E36B0", Offset = "0x37E2AB0", VA = "0x1837E36B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan IGMEEFDEHJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x37E3870", Offset = "0x37E2C70", VA = "0x1837E3870")]
		public GLNFONCHENL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private readonly struct CHIGAHICKGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly TRequest BDAAOBFBLIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly CancellationToken KNKAEBKAEBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly TaskCompletionSource<TResult> IMAIIHOELNA;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x4AEDF20", Offset = "0x4AED320", VA = "0x184AEDF20")]
		public CHIGAHICKGC(TRequest BDAAOBFBLIB, TaskCompletionSource<TResult> IMAIIHOELNA, CancellationToken KNKAEBKAEBM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct PAFLILCBIIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public LONIALJHEDA<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x41927A0", Offset = "0x4191BA0", VA = "0x1841927A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x4192C40", Offset = "0x4192040", VA = "0x184192C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct JCDIHJNEGHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public LONIALJHEDA<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private CHIGAHICKGC <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3B55750", Offset = "0x3B54B50", VA = "0x183B55750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3B563D0", Offset = "0x3B557D0", VA = "0x183B563D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly CancellationTokenSource EIJJDJFGNOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<CHIGAHICKGC> INHPEAHHIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly GLNFONCHENL NPOFFGEAGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly HLADFCEPFDE DINFIBELCIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Task CEFJKEIOGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private int PBLJFFNMKNO;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3D30500", Offset = "0x3D2F900", VA = "0x183D30500")]
	public LONIALJHEDA(HLADFCEPFDE DINFIBELCIG, [Optional] GLNFONCHENL NPOFFGEAGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3D2FAD0", Offset = "0x3D2EED0", VA = "0x183D2FAD0")]
	public Task<TResult> KPMGGBKPDLA(TRequest BDAAOBFBLIB, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3D30240", Offset = "0x3D2F640", VA = "0x183D30240")]
	private void MOEODCAPKIK(CHIGAHICKGC NJKBJJKMLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3D2F7B0", Offset = "0x3D2EBB0", VA = "0x183D2F7B0")]
	[AsyncStateMachine(typeof(LONIALJHEDA<, >.PAFLILCBIIG))]
	private Task JIGBMLPFOBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3D2F060", Offset = "0x3D2E460", VA = "0x183D2F060")]
	private CHIGAHICKGC CJPHJPOMOCC()
	{
		return default(CHIGAHICKGC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3D2F3F0", Offset = "0x3D2E7F0", VA = "0x183D2F3F0")]
	[AsyncStateMachine(typeof(LONIALJHEDA<, >.JCDIHJNEGHN))]
	private Task DMANPMGECEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3D2FFB0", Offset = "0x3D2F3B0", VA = "0x183D2FFB0")]
	private void MBJBKIKAFDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3D2F5D0", Offset = "0x3D2E9D0", VA = "0x183D2F5D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[DefaultMember("Item")]
public class IDJAIIBOHHL<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly List<T> OCAIIBKPIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private HashSet<T> OENHLBEFNCA;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int ALDOGAGGHGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x312D4F0", Offset = "0x312C8F0", VA = "0x18312D4F0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool EFGCLFKEOMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T BEENPNFBNIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3846E80", Offset = "0x3846280", VA = "0x183846E80", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x399B8E0", Offset = "0x399ACE0", VA = "0x18399B8E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3347FE0", Offset = "0x33473E0", VA = "0x183347FE0", Slot = "11")]
	public void Add(T LPGJEPJPGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x399B1F0", Offset = "0x399A5F0", VA = "0x18399B1F0")]
	public bool DIFDGFHIOEH(T LPGJEPJPGGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x399B6B0", Offset = "0x399AAB0", VA = "0x18399B6B0", Slot = "15")]
	public bool Remove(T LPGJEPJPGGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x331C750", Offset = "0x331BB50", VA = "0x18331C750", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x373C960", Offset = "0x373BD60", VA = "0x18373C960", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x399B060", Offset = "0x399A460", VA = "0x18399B060", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x399B0C0", Offset = "0x399A4C0", VA = "0x18399B0C0", Slot = "13")]
	public bool Contains(T LPGJEPJPGGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x399B100", Offset = "0x399A500", VA = "0x18399B100", Slot = "14")]
	public void CopyTo(T[] KGECIFKDBHF, int PADDMAPAGBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x399B2B0", Offset = "0x399A6B0", VA = "0x18399B2B0", Slot = "6")]
	public int IndexOf(T LPGJEPJPGGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x399B300", Offset = "0x399A700", VA = "0x18399B300", Slot = "7")]
	public void Insert(int PMLKPJNGBAD, T LPGJEPJPGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x399B4C0", Offset = "0x399A8C0", VA = "0x18399B4C0", Slot = "8")]
	public void RemoveAt(int PMLKPJNGBAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x399B7F0", Offset = "0x399ABF0", VA = "0x18399B7F0")]
	public IDJAIIBOHHL()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x1F80B80", Offset = "0x1F7FF80", VA = "0x181F80B80")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6190490", Offset = "0x618F890", VA = "0x186190490")]
		public SerializedGuid([In] Guid GFLAAGJEJNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6190220", Offset = "0x618F620", VA = "0x186190220")]
		public static SerializedGuid EDHOBIAKGHC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6190180", Offset = "0x618F580", VA = "0x186190180")]
		public static SerializedGuid BFMOKFFENGM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6190380", Offset = "0x618F780", VA = "0x186190380")]
		public bool LPBPADBNJKC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6190460", Offset = "0x618F860", VA = "0x186190460", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x61903E0", Offset = "0x618F7E0", VA = "0x1861903E0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x61902A0", Offset = "0x618F6A0", VA = "0x1861902A0", Slot = "7")]
		public bool Equals(SerializedGuid MGDPHHCBMMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x61902E0", Offset = "0x618F6E0", VA = "0x1861902E0", Slot = "0")]
		public override bool Equals(object LIKEKIACGIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6190370", Offset = "0x618F770", VA = "0x186190370", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x61901F0", Offset = "0x618F5F0", VA = "0x1861901F0", Slot = "6")]
		public int CompareTo(SerializedGuid MGDPHHCBMMP)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class IJAEDODDAND : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly Type IOKJJEBDBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly string NFENMJIHHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly bool OKDHJDBGLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly bool IKMHNPDEPFJ;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x618E180", Offset = "0x618D580", VA = "0x18618E180")]
	public IJAEDODDAND(Type HKANHPPCFEM, string NBPLAHILHIF, bool OIPOCPGBKGB = false, bool HCAGMGLGHGE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class OHKLINEMLLN<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public readonly struct HBLGBAJJAOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly long ECCONLDFHDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly long GICDLFAAEKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly int LCCAECNNIGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly int ODLANABICKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly bool CDACJJAFABB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly string IFPEGOBJKGO;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3840A10", Offset = "0x383FE10", VA = "0x183840A10")]
		public HBLGBAJJAOK(long ECCONLDFHDF, int LCCAECNNIGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x38409E0", Offset = "0x383FDE0", VA = "0x1838409E0")]
		public HBLGBAJJAOK(long ECCONLDFHDF, long GICDLFAAEKK, int LCCAECNNIGB, int ODLANABICKN, bool CDACJJAFABB, string IFPEGOBJKGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3840870", Offset = "0x383FC70", VA = "0x183840870")]
		public int GDNHDBNGIIH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x38409C0", Offset = "0x383FDC0", VA = "0x1838409C0")]
		public int PKNMNFAKCDD(int IMHNFDLKPPM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3840960", Offset = "0x383FD60", VA = "0x183840960")]
		public double PDBLGCFOMIE()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x38408C0", Offset = "0x383FCC0", VA = "0x1838408C0")]
		public HBLGBAJJAOK HKNBLKOKKBA(long GICDLFAAEKK, int ODLANABICKN)
		{
			return default(HBLGBAJJAOK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class IECBLACBOCC : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private struct CMKKMEFEGCI<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public IECBLACBOCC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public Func<IECBLACBOCC, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private IECBLACBOCC <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x4CB2680", Offset = "0x4CB1A80", VA = "0x184CB2680", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x3848380", Offset = "0x3847780", VA = "0x183848380", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public readonly TKey OIALKEIONCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly OHKLINEMLLN<TKey> CBCAJLKKHCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly GFLOJPOFOAD DFBIKANGICJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private List<IECBLACBOCC> AJBNMNAMOBC;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string HLIDAIDEMFN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x39A3040", Offset = "0x39A2440", VA = "0x1839A3040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IEnumerable<IECBLACBOCC> JNEPNPFHGIE
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x39A3200", Offset = "0x39A2600", VA = "0x1839A3200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public HBLGBAJJAOK GGHMCBPJFHL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x39A3240", Offset = "0x39A2640", VA = "0x1839A3240")]
			[CompilerGenerated]
			get
			{
				return default(HBLGBAJJAOK);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x39A3070", Offset = "0x39A2470", VA = "0x1839A3070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x39A3260", Offset = "0x39A2660", VA = "0x1839A3260")]
		internal IECBLACBOCC(OHKLINEMLLN<TKey> CBCAJLKKHCH, TKey NIOPCMHKLMB, GFLOJPOFOAD DFBIKANGICJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x39A30A0", Offset = "0x39A24A0", VA = "0x1839A30A0")]
		public IECBLACBOCC MABHLLONMDI(TKey NIOPCMHKLMB, [Optional] GFLOJPOFOAD? HLFPCGNNPDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2599410", Offset = "0x2598810", VA = "0x182599410")]
		[AsyncStateMachine(typeof(CMKKMEFEGCI<>))]
		public Task<T> MIJCDDLJIBL<T>(TKey NIOPCMHKLMB, Func<IECBLACBOCC, Task<T>> KNFHKDLGIMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x39A2E40", Offset = "0x39A2240", VA = "0x1839A2E40", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class DMNIHJFIBDN : IEnumerable<(TKey, List<TKey>, HBLGBAJJAOK)>, IEnumerable, IEnumerator<(TKey, List<TKey>, HBLGBAJJAOK)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private (TKey key, List<TKey> path, HBLGBAJJAOK timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public OHKLINEMLLN<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private IEnumerator<(TKey key, List<TKey> path, HBLGBAJJAOK timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, HBLGBAJJAOK) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x1F7B2E0", Offset = "0x1F7A6E0", VA = "0x181F7B2E0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, HBLGBAJJAOK));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x50FEA60", Offset = "0x50FDE60", VA = "0x1850FEA60", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x1F7B3D0", Offset = "0x1F7A7D0", VA = "0x181F7B3D0")]
		[DebuggerHidden]
		public DMNIHJFIBDN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x36BEDD0", Offset = "0x36BE1D0", VA = "0x1836BEDD0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x50FE5B0", Offset = "0x50FD9B0", VA = "0x1850FE5B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x50FE560", Offset = "0x50FD960", VA = "0x1850FE560")]
		private void CLBCIEJIKHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x50FEA10", Offset = "0x50FDE10", VA = "0x1850FEA10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x50FE950", Offset = "0x50FDD50", VA = "0x1850FE950", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, HBLGBAJJAOK)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x36C7200", Offset = "0x36C6600", VA = "0x1836C7200", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class CIFMMJLBLME : IEnumerable<(TKey, List<TKey>, HBLGBAJJAOK)>, IEnumerable, IEnumerator<(TKey, List<TKey>, HBLGBAJJAOK)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private (TKey key, List<TKey> path, HBLGBAJJAOK timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private IECBLACBOCC timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public IECBLACBOCC <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public OHKLINEMLLN<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private IEnumerator<IECBLACBOCC> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private IEnumerator<(TKey key, List<TKey> path, HBLGBAJJAOK timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private (TKey, List<TKey>, HBLGBAJJAOK) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x1F7B2E0", Offset = "0x1F7A6E0", VA = "0x181F7B2E0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, HBLGBAJJAOK));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x4AEF0A0", Offset = "0x4AEE4A0", VA = "0x184AEF0A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x1F7B3D0", Offset = "0x1F7A7D0", VA = "0x181F7B3D0")]
		[DebuggerHidden]
		public CIFMMJLBLME(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x4AEF100", Offset = "0x4AEE500", VA = "0x184AEF100", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x4AEE760", Offset = "0x4AEDB60", VA = "0x184AEE760", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x4AEE700", Offset = "0x4AEDB00", VA = "0x184AEE700")]
		private void CLBCIEJIKHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4AEEF10", Offset = "0x4AEE310", VA = "0x184AEEF10")]
		private void ODFILHFIFPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4AEF050", Offset = "0x4AEE450", VA = "0x184AEF050", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4AEEF70", Offset = "0x4AEE370", VA = "0x184AEEF70", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, HBLGBAJJAOK)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x43A39A0", Offset = "0x43A2DA0", VA = "0x1843A39A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly Action<TKey, HBLGBAJJAOK, GFLOJPOFOAD> IFDEEMMGNNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly Action<TKey, HBLGBAJJAOK, GFLOJPOFOAD> GFJLAAEKGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Action<OHKLINEMLLN<TKey>, GFLOJPOFOAD> MCIEOMFMFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly GFLOJPOFOAD DFBIKANGICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly IECBLACBOCC EOOIIDGFAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private bool KFEECCNBOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private int DFICOBPGKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly Stopwatch ENBBPLEAMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly int MANHEIGIKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private string FOIBLFCFNNE;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public IECBLACBOCC AGDOGNCHEJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[NotNull]
	public string HLIDAIDEMFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7C29B0", Offset = "0x7C1DB0", VA = "0x1807C29B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x40D3EF0", Offset = "0x40D32F0", VA = "0x1840D3EF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x40D40B0", Offset = "0x40D34B0", VA = "0x1840D40B0")]
	public OHKLINEMLLN(TKey HFAEIPJOIBO, GFLOJPOFOAD DFBIKANGICJ, [Optional] int? LCCAECNNIGB, [Optional][CanBeNull] Stopwatch ENBBPLEAMEL, [Optional] Action<TKey, HBLGBAJJAOK, GFLOJPOFOAD> IFDEEMMGNNF, [Optional] Action<TKey, HBLGBAJJAOK, GFLOJPOFOAD> GFJLAAEKGBJ, [Optional] Action<OHKLINEMLLN<TKey>, GFLOJPOFOAD> MCIEOMFMFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x40D3DE0", Offset = "0x40D31E0", VA = "0x1840D3DE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x40D3F50", Offset = "0x40D3350", VA = "0x1840D3F50")]
	[IteratorStateMachine(typeof(OHKLINEMLLN<>.DMNIHJFIBDN))]
	public IEnumerable<(TKey, List<TKey>, HBLGBAJJAOK)> MAJONBEKPBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x40D3FE0", Offset = "0x40D33E0", VA = "0x1840D3FE0")]
	[IteratorStateMachine(typeof(OHKLINEMLLN<>.CIFMMJLBLME))]
	private IEnumerable<(TKey, List<TKey>, HBLGBAJJAOK)> MAJONBEKPBD(List<TKey> GBHBCPBCKNM, IECBLACBOCC NOBBJKIAMOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x40D3E70", Offset = "0x40D3270", VA = "0x1840D3E70")]
	private (long, int) HDANMMNDKFM()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public abstract class FKBDPPLLGDH<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut BDGNLODDMKH(OHKLINEMLLN<TKey> CBCAJLKKHCH);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	protected FKBDPPLLGDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public abstract class LJEOHJNGPBN<TKey> : FKBDPPLLGDH<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public delegate string AHOBOLAFIGN(TKey NIOPCMHKLMB);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3D1CF80", Offset = "0x3D1C380", VA = "0x183D1CF80")]
	private static string PJOLMBMIMEA(TKey NIOPCMHKLMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3D1CEC0", Offset = "0x3D1C2C0", VA = "0x183D1CEC0", Slot = "4")]
	public override string BDGNLODDMKH(OHKLINEMLLN<TKey> CBCAJLKKHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3D1CD70", Offset = "0x3D1C170", VA = "0x183D1CD70")]
	public string BDGNLODDMKH(OHKLINEMLLN<TKey> CBCAJLKKHCH, [NotNull] AHOBOLAFIGN HDBCEJNLLEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string PMINBMCBHJG(OHKLINEMLLN<TKey> CBCAJLKKHCH, [NotNull] AHOBOLAFIGN HDBCEJNLLEG);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3313840", Offset = "0x3312C40", VA = "0x183313840")]
	protected LJEOHJNGPBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class MFPKFJBMDDE<TKey> : FKBDPPLLGDH<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate string DPJEDMGACLP(TKey NIOPCMHKLMB);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly string MCDANMEJKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly double LOIFGCHIIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly bool FCCNOLFKBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly int NCHBPIEKFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly ISet<string> PDHFMFKLALE;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3EF8A40", Offset = "0x3EF7E40", VA = "0x183EF8A40")]
	private static string PJOLMBMIMEA(TKey NIOPCMHKLMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3EF8A80", Offset = "0x3EF7E80", VA = "0x183EF8A80")]
	public MFPKFJBMDDE(string MCDANMEJKNC = "F2", double LOIFGCHIIGM = double.MaxValue, bool FCCNOLFKBNC = false, int NCHBPIEKFNP = int.MaxValue, [Optional] ISet<string> PDHFMFKLALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3EF88A0", Offset = "0x3EF7CA0", VA = "0x183EF88A0", Slot = "4")]
	public override Dictionary<string, string> BDGNLODDMKH(OHKLINEMLLN<TKey> CBCAJLKKHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3EF8960", Offset = "0x3EF7D60", VA = "0x183EF8960")]
	private bool PFJHCGBPONN(string IIAPPBFDDDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3EF82B0", Offset = "0x3EF76B0", VA = "0x183EF82B0")]
	public Dictionary<string, string> BDGNLODDMKH(OHKLINEMLLN<TKey> CBCAJLKKHCH, DPJEDMGACLP HDBCEJNLLEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3EF7F10", Offset = "0x3EF7310", VA = "0x183EF7F10")]
	private string AAPKBLJBNJF(StringBuilder OLEHKMDIAIC, List<TKey> AKEIKDEPFMO, DPJEDMGACLP HDBCEJNLLEG, bool CCMPAIBBNJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3EF8150", Offset = "0x3EF7550", VA = "0x183EF8150")]
	private static void BAFNJFPOONF(StringBuilder OMLNGKAOOCF, string OENJOHCEEDO, bool CHNHFEPIHBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class MMOEIPPJDML<TKey> : LJEOHJNGPBN<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct LKMADMLGNDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AHOBOLAFIGN keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static MMOEIPPJDML<TKey> GDCHCCJBKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly string[] BLFNDDFOOJB;

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3F184B0", Offset = "0x3F178B0", VA = "0x183F184B0")]
	private MMOEIPPJDML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3F17540", Offset = "0x3F16940", VA = "0x183F17540", Slot = "5")]
	protected override string PMINBMCBHJG(OHKLINEMLLN<TKey> CBCAJLKKHCH, AHOBOLAFIGN HDBCEJNLLEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3F17450", Offset = "0x3F16850", VA = "0x183F17450")]
	[CompilerGenerated]
	internal static string BMNLGKKINEJ(string PCBLAABLMAD, TKey NIOPCMHKLMB, LKMADMLGNDL P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class OHMKNFEFFLF : OHKLINEMLLN<string>
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class PAJJCEOADAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public Action<OHMKNFEFFLF, GFLOJPOFOAD> callback;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public PAJJCEOADAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x618ECB0", Offset = "0x618E0B0", VA = "0x18618ECB0")]
		internal void NHIKEHJNDMH(OHKLINEMLLN<string> timer, GFLOJPOFOAD log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x618EB60", Offset = "0x618DF60", VA = "0x18618EB60")]
	public OHMKNFEFFLF(GFLOJPOFOAD DFBIKANGICJ, [Optional] string KOBBILELCIP, [Optional] int? LCCAECNNIGB, [Optional] Stopwatch ENBBPLEAMEL, [Optional] Action<string, HBLGBAJJAOK, GFLOJPOFOAD> IFDEEMMGNNF, [Optional] Action<string, HBLGBAJJAOK, GFLOJPOFOAD> GFJLAAEKGBJ, [Optional] Action<OHMKNFEFFLF, GFLOJPOFOAD> MCIEOMFMFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x618EAA0", Offset = "0x618DEA0", VA = "0x18618EAA0")]
	private static Action<OHKLINEMLLN<string>, GFLOJPOFOAD> DBJEPOOAEFP(Action<OHMKNFEFFLF, GFLOJPOFOAD> KCNCNEMPBGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public abstract class HLCBNACEKGE
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private class MNJDBLIOHHF : HLCBNACEKGE
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static HLCBNACEKGE GDCHCCJBKDM
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x618E8D0", Offset = "0x618DCD0", VA = "0x18618E8D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override float PAFOEHCLHAM
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x1DA5F10", Offset = "0x1DA5310", VA = "0x181DA5F10", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x618E9D0", Offset = "0x618DDD0", VA = "0x18618E9D0")]
		public MNJDBLIOHHF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static HLCBNACEKGE EHAMKAFMDNC;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static HLCBNACEKGE AEDHDHNAKOP
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x618E010", Offset = "0x618D410", VA = "0x18618E010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public abstract float PAFOEHCLHAM
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	protected HLCBNACEKGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface CALGGIPCOCH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool ILIOJLEOEKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface COOEPIMPOKM<T> : CALGGIPCOCH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	[NotNull]
	Task<T> AKPBMMIEEAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	[NotNull]
	JNFFOANFOAP<T> CHDAIPGOHPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class GONBMILFOJH
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private sealed class NOMMDFAMFCM<T> : GBCLKIFENIG<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override Task<T?> AKPBMMIEEAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override JNFFOANFOAP<T?> CHDAIPGOHPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x7C1040", Offset = "0x7C0440", VA = "0x1807C1040", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x4007B10", Offset = "0x4006F10", VA = "0x184007B10")]
		public NOMMDFAMFCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "10")]
		protected override void IPAFBDEHFFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private sealed class OFKOIDJHMAE<T> : GBCLKIFENIG<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override Task<T> AKPBMMIEEAB
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override JNFFOANFOAP<T> CHDAIPGOHPH
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x7C1040", Offset = "0x7C0440", VA = "0x1807C1040", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x40D0360", Offset = "0x40CF760", VA = "0x1840D0360")]
		public OFKOIDJHMAE(Exception KDFDGCCFNMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "10")]
		protected override void IPAFBDEHFFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private sealed class HCFPHODDKME<T> : GBCLKIFENIG<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private struct BIKGNJMADIP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public Task<COOEPIMPOKM<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			private TaskAwaiter<COOEPIMPOKM<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x480D160", Offset = "0x480C560", VA = "0x18480D160", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x480D650", Offset = "0x480CA50", VA = "0x18480D650", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct EDICLMLFPAI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public Task<COOEPIMPOKM<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private TaskAwaiter<COOEPIMPOKM<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x331E620", Offset = "0x331DA20", VA = "0x18331E620", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x331E850", Offset = "0x331DC50", VA = "0x18331E850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly Task<COOEPIMPOKM<T>> EPOPBIPAAOH;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override Task<T> AKPBMMIEEAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x7C1040", Offset = "0x7C0440", VA = "0x1807C1040", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override JNFFOANFOAP<T> CHDAIPGOHPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x7C1020", Offset = "0x7C0420", VA = "0x1807C1020", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x3846CB0", Offset = "0x38460B0", VA = "0x183846CB0")]
		public HCFPHODDKME(Task<COOEPIMPOKM<T>> JKFKBCIOAGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x38469D0", Offset = "0x3845DD0", VA = "0x1838469D0", Slot = "10")]
		protected override void IPAFBDEHFFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x3846A60", Offset = "0x3845E60", VA = "0x183846A60")]
		[AsyncStateMachine(typeof(HCFPHODDKME<>.BIKGNJMADIP))]
		[CompilerGenerated]
		internal static Task<T> JEAPFKBNGBJ(Task<COOEPIMPOKM<T>> JKFKBCIOAGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x3846BC0", Offset = "0x3845FC0", VA = "0x183846BC0")]
		[AsyncStateMachine(typeof(HCFPHODDKME<>.EDICLMLFPAI))]
		[CompilerGenerated]
		internal static Task PCFILOAKAEL(Task<COOEPIMPOKM<T>> JKFKBCIOAGB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x27F43B0", Offset = "0x27F37B0", VA = "0x1827F43B0")]
	public static COOEPIMPOKM<T> CCDCOKAGGMA<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x2623F10", Offset = "0x2623310", VA = "0x182623F10")]
	public static COOEPIMPOKM<T> NNIICLAIIEL<T>(Exception KDFDGCCFNMI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x2623F10", Offset = "0x2623310", VA = "0x182623F10")]
	public static COOEPIMPOKM<T> LHJMOKPEOEB<T>(Task<COOEPIMPOKM<T>> JKFKBCIOAGB) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public abstract class GBCLKIFENIG<T> : COOEPIMPOKM<T>, CALGGIPCOCH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly LKGPDLCIFPA NMCHFOKCMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private bool KFEECCNBOJI;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool ILIOJLEOEKF
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xA15AA0", Offset = "0xA14EA0", VA = "0x180A15AA0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public abstract Task<T> AKPBMMIEEAB
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public abstract JNFFOANFOAP<T> CHDAIPGOHPH
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x379CED0", Offset = "0x379C2D0", VA = "0x18379CED0")]
	public GBCLKIFENIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x379CC70", Offset = "0x379C070", VA = "0x18379CC70", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void IPAFBDEHFFO();
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public abstract class ADGBOHCIBCG<TTask, T> : GBCLKIFENIG<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class PLGLNKIOEKB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public PLGLNKIOEKB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x311C670", Offset = "0x311BA70", VA = "0x18311C670", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x311CBE0", Offset = "0x311BFE0", VA = "0x18311CBE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public ADGBOHCIBCG<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public PLGLNKIOEKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x41B2E90", Offset = "0x41B2290", VA = "0x1841B2E90")]
		[AsyncStateMachine(typeof(ADGBOHCIBCG<, >.PLGLNKIOEKB.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> GJBFCIKHFEC(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly Task<T> JKFKBCIOAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	protected readonly CancellationTokenSource MCEEHGKCGKG;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public override Task<T> AKPBMMIEEAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public override JNFFOANFOAP<T> CHDAIPGOHPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7C1040", Offset = "0x7C0440", VA = "0x1807C1040", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x3781990", Offset = "0x3780D90", VA = "0x183781990")]
	protected ADGBOHCIBCG(TTask JKFKBCIOAGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x37817A0", Offset = "0x3780BA0", VA = "0x1837817A0", Slot = "10")]
	protected override void IPAFBDEHFFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T MDKKMKKHGNE(TTask OFGPEJMLPPD);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void CACEIIMLPCD();
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class NPDHPNKMPJO<T> : GBCLKIFENIG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly FIOJPADPCHG<Task<T>> AICCCNKOPPK;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public override Task<T> AKPBMMIEEAB
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x33698D0", Offset = "0x3368CD0", VA = "0x1833698D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public override JNFFOANFOAP<T> CHDAIPGOHPH
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7C1040", Offset = "0x7C0440", VA = "0x1807C1040", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x40080A0", Offset = "0x40074A0", VA = "0x1840080A0")]
	public NPDHPNKMPJO(FIOJPADPCHG<Task<T>> BHKEDIOOGCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x4008080", Offset = "0x4007480", VA = "0x184008080", Slot = "10")]
	protected override void IPAFBDEHFFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class DNLINNIHHKA
{
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x618CE80", Offset = "0x618C280", VA = "0x18618CE80")]
	[NotNull]
	public static byte[] NFOGCIFAHPB(this KGMECFNCPNG NEOJKELNMPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x618CEF0", Offset = "0x618C2F0", VA = "0x18618CEF0")]
	[NotNull]
	public static byte[] NFOGCIFAHPB(this KGMECFNCPNG NEOJKELNMPF, HashAlgorithmName MGCNDMPOLDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x618CBD0", Offset = "0x618BFD0", VA = "0x18618CBD0")]
	public static bool FOHLHEDBJBJ([CanBeNull] this KGMECFNCPNG NEOJKELNMPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x618CA30", Offset = "0x618BE30", VA = "0x18618CA30")]
	public static bool FOHLHEDBJBJ([CanBeNull] this KGMECFNCPNG NEOJKELNMPF, [Out] string NBDBHDLNPOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x618CD60", Offset = "0x618C160", VA = "0x18618CD60")]
	private static bool INLIMFFJAFC([NotNull] KGMECFNCPNG NEOJKELNMPF, [Out][CanBeNull] byte[] DKOGDENDHMH, [Out][CanBeNull] byte[] EHHKEHKDFDP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class BJMGBJDGGMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x618B990", Offset = "0x618AD90", VA = "0x18618B990")]
	[NotNull]
	public static byte[] NFOGCIFAHPB(this CLDKOKPKMEM MDAAKLJIJGL, HashAlgorithmName MGCNDMPOLDD, byte[] CIDKEGFHKBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface CLDKOKPKMEM
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash EMBOHFOBPMK);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface KGMECFNCPNG : CLDKOKPKMEM
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	[CanBeNull]
	byte[] OOEKIBDGNOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	[CanBeNull]
	byte[] CPBIAODCBBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class DNFGFNFPBDF
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly ArrayPool<byte> IPKEJFBHGKB;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static bool LBEIMGCGADC;

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x2668110", Offset = "0x2667510", VA = "0x182668110")]
	public static void HABDLCBLFBI<T>(this IncrementalHash DFMCBDOCNDK, [CanBeNull] T MGFEBOILECI) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x26681D0", Offset = "0x26675D0", VA = "0x1826681D0")]
	public static void KHBJCBGFAFE<T>(this IncrementalHash DFMCBDOCNDK, [CanBeNull] T MDAAKLJIJGL) where T : CLDKOKPKMEM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x2667BF0", Offset = "0x2666FF0", VA = "0x182667BF0")]
	public static void GOCBALEBBEK<T>(this IncrementalHash DFMCBDOCNDK, [CanBeNull] IList<T> OLODDDPFFMH) where T : CLDKOKPKMEM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x618C430", Offset = "0x618B830", VA = "0x18618C430")]
	private static bool KDDBIKDDLNC([CanBeNull] CLDKOKPKMEM MDAAKLJIJGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x618BD90", Offset = "0x618B190", VA = "0x18618BD90")]
	public static void BGANINDFNFC(this IncrementalHash EMBOHFOBPMK, [CanBeNull] string GIBKAKIJEAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x618BF60", Offset = "0x618B360", VA = "0x18618BF60")]
	public static void CKLKCBGPDGC(this IncrementalHash EMBOHFOBPMK, long ECGEJABPMFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x618C4C0", Offset = "0x618B8C0", VA = "0x18618C4C0")]
	public static void KKHHEBCBKPG(this IncrementalHash EMBOHFOBPMK, int FMLPJCAKCOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x618C690", Offset = "0x618BA90", VA = "0x18618C690")]
	public static void LGKAPHMCACL(this IncrementalHash EMBOHFOBPMK, short KMPFLEAAMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x618C2C0", Offset = "0x618B6C0", VA = "0x18618C2C0")]
	public static void GLMCDFECFAC(this IncrementalHash EMBOHFOBPMK, byte DBGLLKMBBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x618BDF0", Offset = "0x618B1F0", VA = "0x18618BDF0")]
	public static void BHLEFHBPPNF(this IncrementalHash EMBOHFOBPMK, bool HCKGCNFBCHP, bool MMPPHHNPJAB = false, bool KLIOFBLEAOC = false, bool HOMAGLOBECO = false, bool LANDHLHFNFN = false, bool KCECNBBKNMG = false, bool OINEPDHAHGK = false, bool ABKEIPCOEHN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x26675C0", Offset = "0x26669C0", VA = "0x1826675C0")]
	public static void CMFMJEHDHMD<T>(this IncrementalHash EMBOHFOBPMK, T EKIHNFGMJAF) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x618C260", Offset = "0x618B660", VA = "0x18618C260")]
	public static void EEAPHOBAPNP(this IncrementalHash EMBOHFOBPMK, float JPACCKBAALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x618C3D0", Offset = "0x618B7D0", VA = "0x18618C3D0")]
	public static void HIMLGNJHFKI(this IncrementalHash EMBOHFOBPMK, ulong DCLCAPLOONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x618C860", Offset = "0x618BC60", VA = "0x18618C860")]
	public static void OMOHPGAICIK(this IncrementalHash EMBOHFOBPMK, uint LGMGMBGKNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x618C8C0", Offset = "0x618BCC0", VA = "0x18618C8C0")]
	public static void PJIILHKIEMN(this IncrementalHash EMBOHFOBPMK, ushort NLLNIICDGNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x618C130", Offset = "0x618B530", VA = "0x18618C130")]
	public static void DDLINHKKNLF(this IncrementalHash EMBOHFOBPMK, Vector3 FMOKAECBKMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class KFOFCCELJCC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x618E7F0", Offset = "0x618DBF0", VA = "0x18618E7F0")]
	public KFOFCCELJCC(string JEBCFBFPEMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class AFJEMJLGFMN<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal class CGMANAOHDPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public TNode MEEBIDIALDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public TNode NCGFJMKBOIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public KIAGKLOBIAF KHEIPMEJPAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public List<KIAGKLOBIAF> JFEPFJPCOIF;

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public CGMANAOHDPP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	internal struct KIAGKLOBIAF : IComparable<KIAGKLOBIAF>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public int FEOEIKFIFFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public TClaimant CAHKFJJPACH;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xC40350", Offset = "0xC3F750", VA = "0x180C40350")]
		public KIAGKLOBIAF(int FEOEIKFIFFF, TClaimant CAHKFJJPACH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3C77CA0", Offset = "0x3C770A0", VA = "0x183C77CA0")]
		public bool KIAMBJEAPAO([In] KIAGKLOBIAF MGDPHHCBMMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3C77C90", Offset = "0x3C77090", VA = "0x183C77C90")]
		public bool JPBBMDABKAF([In] KIAGKLOBIAF MGDPHHCBMMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3C77C80", Offset = "0x3C77080", VA = "0x183C77C80", Slot = "4")]
		public int CompareTo(KIAGKLOBIAF MGDPHHCBMMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3C77D00", Offset = "0x3C77100", VA = "0x183C77D00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public enum CFAAFFDLAGH
	{
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class MHEDMBBDIAC : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public AFJEMJLGFMN<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x818520", Offset = "0x817920", VA = "0x180818520")]
		[DebuggerHidden]
		public MHEDMBBDIAC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3F00550", Offset = "0x3EFF950", VA = "0x183F00550", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3F00710", Offset = "0x3EFFB10", VA = "0x183F00710", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3F00630", Offset = "0x3EFFA30", VA = "0x183F00630", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3369110", Offset = "0x3368510", VA = "0x183369110", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly EKJKPBAIBIP<CGMANAOHDPP> GKIENEHPJLF;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly EKJKPBAIBIP<List<KIAGKLOBIAF>> JGEMAJOOPLA;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static int PGBLGHBDKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	internal readonly Dictionary<TClaimant, TNode> LNEPBELJHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	internal readonly Dictionary<TNode, CGMANAOHDPP> OGPPKGMEBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private CFAAFFDLAGH LFOBHMCPMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private bool HFCDDCNLIBB;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode LFIPMLKHNMH(TNode HBIAHPFPLFB);

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void NKJDMICFGMA(TNode HBIAHPFPLFB, TClaimant JEPECCMKMLD, TClaimant IMEFPCAPAJF);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x3921B40", Offset = "0x3920F40", VA = "0x183921B40")]
	public AFJEMJLGFMN(CFAAFFDLAGH LFOBHMCPMIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x39209A0", Offset = "0x391FDA0", VA = "0x1839209A0")]
	public void HPMIMOMCIDA(TNode HBIAHPFPLFB, TNode FANLJCAEFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x3920F70", Offset = "0x3920370", VA = "0x183920F70")]
	public void LMFCLJCOEFK(TClaimant CAHKFJJPACH, TNode HPBGFPDOMFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x3920660", Offset = "0x391FA60", VA = "0x183920660", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x3920C30", Offset = "0x3920030", VA = "0x183920C30")]
	private void KEPJBGPJOOH(TClaimant CAHKFJJPACH, TNode IOAKHNKOBFM, TNode HPBGFPDOMFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x3921450", Offset = "0x3920850", VA = "0x183921450")]
	private int MODDKDFABFK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x3921640", Offset = "0x3920A40", VA = "0x183921640")]
	private void PCCNKJNDIDD(TClaimant CAHKFJJPACH, TNode HIBCEKNDBNG, TNode HPGBPDFJMIP, int GJHMKLBPIEK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x39215B0", Offset = "0x39209B0", VA = "0x1839215B0")]
	private void OFGPAMFJMPA(KIAGKLOBIAF BICJEHMPPNP, CGMANAOHDPP NCELHEHEEBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x3921090", Offset = "0x3920490", VA = "0x183921090")]
	private void MFKHBIHNICG(TClaimant CAHKFJJPACH, TNode HIBCEKNDBNG, TNode HPGBPDFJMIP, int GJHMKLBPIEK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x3920A30", Offset = "0x391FE30", VA = "0x183920A30")]
	private void INOOAEGLGME(KIAGKLOBIAF BICJEHMPPNP, TNode HBIAHPFPLFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x39214C0", Offset = "0x39208C0", VA = "0x1839214C0")]
	private void NDLDAHCGOAI(KIAGKLOBIAF BICJEHMPPNP, CGMANAOHDPP NCELHEHEEBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x3920E40", Offset = "0x3920240", VA = "0x183920E40")]
	private void LHFIJHGKACP(CGMANAOHDPP NCELHEHEEBE, bool EBCBAINNEPJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x3920320", Offset = "0x391F720", VA = "0x183920320")]
	private void AHJCPNHJKAO(CGMANAOHDPP NCELHEHEEBE, TNode FANLJCAEFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x3921370", Offset = "0x3920770", VA = "0x183921370")]
	[IteratorStateMachine(typeof(AFJEMJLGFMN<, >.MHEDMBBDIAC))]
	private IEnumerable<TNode> MNBHNOGICBF(TNode HIBCEKNDBNG, TNode HPGBPDFJMIP, bool LPEMFGABDPK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x3920B40", Offset = "0x391FF40", VA = "0x183920B40")]
	private CGMANAOHDPP IPDCPIDPLON(TNode HBIAHPFPLFB, TNode NCGFJMKBOIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x3920CD0", Offset = "0x39200D0", VA = "0x183920CD0")]
	private CGMANAOHDPP LFOBHGKEDBG(TNode HBIAHPFPLFB, TNode NCGFJMKBOIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x3920830", Offset = "0x391FC30", VA = "0x183920830")]
	private void EJNNNPLONLE(CGMANAOHDPP NCELHEHEEBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class BNDIDBCFCNC<T> : IEnumerable<BNDIDBCFCNC<T>.HFGMGOJIEGL>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct HFGMGOJIEGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public T PCGOHCLJAPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int PMLKPJNGBAD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public class BPLNCJEDBDK : IEnumerator<HFGMGOJIEGL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private BNDIDBCFCNC<T> BCBIHGDDHMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private int PMLKPJNGBAD;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x337F560", Offset = "0x337E960", VA = "0x18337F560", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public HFGMGOJIEGL MPGEHNMDMNL
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x483BB70", Offset = "0x483AF70", VA = "0x18483BB70", Slot = "4")]
			get
			{
				return default(HFGMGOJIEGL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x483BA80", Offset = "0x483AE80", VA = "0x18483BA80")]
		public BPLNCJEDBDK(BNDIDBCFCNC<T> BCBIHGDDHMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x483BA00", Offset = "0x483AE00", VA = "0x18483BA00", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x33D2DC0", Offset = "0x33D21C0", VA = "0x1833D2DC0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x879580", Offset = "0x878980", VA = "0x180879580", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private struct DGBLCBLHJBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public bool PDJOEEDIKFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public T PCGOHCLJAPN;
	}

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private const int MGPGOBPMHIF = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly Dictionary<T, int> NGJDAIFDNOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private DGBLCBLHJBM[] HMCMAHDLKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private int INAACFACLFJ;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public int JOGBOHNGNPK
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x7FC300", Offset = "0x7FB700", VA = "0x1807FC300")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x7FB980", Offset = "0x7FAD80", VA = "0x1807FB980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public int ALDOGAGGHGI
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x312D4F0", Offset = "0x312C8F0", VA = "0x18312D4F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x4835130", Offset = "0x4834530", VA = "0x184835130")]
	public BNDIDBCFCNC(int MIFMOLKOCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x48355E0", Offset = "0x48349E0", VA = "0x1848355E0")]
	public BNDIDBCFCNC(HFGMGOJIEGL[] CCHFPJOLPKK, bool KELAOLIOGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x4834970", Offset = "0x4833D70", VA = "0x184834970")]
	public int HGFGFPMEPDA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x4834D30", Offset = "0x4834130", VA = "0x184834D30")]
	private int NINGOEGGJFE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x4834400", Offset = "0x4833800", VA = "0x184834400", Slot = "6")]
	protected virtual uint DGIJMNNNFJA(uint EMBOHFOBPMK, T PCGOHCLJAPN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x4834AF0", Offset = "0x4833EF0", VA = "0x184834AF0")]
	public bool MFIKBOJGPMD(T PCGOHCLJAPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x4834F80", Offset = "0x4834380", VA = "0x184834F80")]
	public int NKDIAECKIJJ(T PCGOHCLJAPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x4834FF0", Offset = "0x48343F0", VA = "0x184834FF0")]
	public T PLGGDCCMHCN(int PMLKPJNGBAD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x48344B0", Offset = "0x48338B0", VA = "0x1848344B0")]
	public bool DIFDGFHIOEH(T PCGOHCLJAPN, bool BJMKMEGEDLB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x4834500", Offset = "0x4833900", VA = "0x184834500")]
	public bool DIFDGFHIOEH(T PCGOHCLJAPN, int PMLKPJNGBAD, bool BJMKMEGEDLB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x4834A50", Offset = "0x4833E50", VA = "0x184834A50")]
	private int JJFCHCOGHEF(int CAIMMNKGOCP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x48350B0", Offset = "0x48344B0", VA = "0x1848350B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x48350B0", Offset = "0x48344B0", VA = "0x1848350B0", Slot = "4")]
	private IEnumerator<HFGMGOJIEGL> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class EKJKPBAIBIP<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly Stack<T> DIFGCPFKLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly List<T> PHBLHKEPHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly int JIDDMPEIGCB;

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x3368470", Offset = "0x3367870", VA = "0x183368470")]
	public static EKJKPBAIBIP<T> FFCKCBJFDOD(int MIFMOLKOCID = 0, int JIDDMPEIGCB = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x3368250", Offset = "0x3367650", VA = "0x183368250")]
	public static EKJKPBAIBIP<T> BLFJKABAJKE(int MIFMOLKOCID = 0, int JIDDMPEIGCB = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x3368C40", Offset = "0x3368040", VA = "0x183368C40")]
	public EKJKPBAIBIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x3368AA0", Offset = "0x3367EA0", VA = "0x183368AA0")]
	public EKJKPBAIBIP(int MIFMOLKOCID, int JIDDMPEIGCB = int.MaxValue, bool CBBAOADBJLD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x3368840", Offset = "0x3367C40", VA = "0x183368840")]
	public T OEJEFNKDECM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x3368570", Offset = "0x3367970", VA = "0x183368570")]
	public void LBDCCEJODEM(T PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x33689C0", Offset = "0x3367DC0", VA = "0x1833689C0")]
	private void OOKOIBKKPDG(T PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x3368550", Offset = "0x3367950", VA = "0x183368550")]
	private void FLLBCFPAKEJ(T PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x3368330", Offset = "0x3367730", VA = "0x183368330", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x3368640", Offset = "0x3367A40", VA = "0x183368640")]
	private void NGLOCGJBBFA(IEnumerable<T> JFCBPFNIMNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class ENGAIMLLIEP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private Dictionary<int, T> HIPPGGLCLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private T JMLKGDNFJLA;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public virtual T JOBJAFILCBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7BE4B0", Offset = "0x7BD8B0", VA = "0x1807BE4B0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x336C490", Offset = "0x336B890", VA = "0x18336C490")]
	public bool KEEOLFKBIJH(T PCGOHCLJAPN, int FEOEIKFIFFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x336BFF0", Offset = "0x336B3F0", VA = "0x18336BFF0")]
	public bool EHEEBOIOGGL(int FEOEIKFIFFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x336C0B0", Offset = "0x336B4B0", VA = "0x18336C0B0")]
	public T JKDMLACCOHO(int LACEIOOIPFC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x336C580", Offset = "0x336B980", VA = "0x18336C580")]
	private bool OLKGFFLHGJG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x336C060", Offset = "0x336B460", VA = "0x18336C060")]
	public bool JFDMGELHHBG(int FEOEIKFIFFF, [Out] T PCGOHCLJAPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x336C730", Offset = "0x336BB30", VA = "0x18336C730")]
	public ENGAIMLLIEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class FLKMNPBEHFE<T>
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	protected struct KJHFJHDOENN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public T EIHNEEOMIED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public int NPJJMFFADMM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	protected readonly List<KJHFJHDOENN> IBONOHEEFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private T CKDNECJOKIK;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public int ALDOGAGGHGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x312D4F0", Offset = "0x312C8F0", VA = "0x18312D4F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x36F2080", Offset = "0x36F1480", VA = "0x1836F2080")]
	public bool LBFIBDMBLKM(T PCGOHCLJAPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x36F1E80", Offset = "0x36F1280", VA = "0x1836F1E80")]
	public void FFIECPFJEFG(T PCGOHCLJAPN, int FEOEIKFIFFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x36F22E0", Offset = "0x36F16E0", VA = "0x1836F22E0")]
	public bool PIABDNKCBCD(T PCGOHCLJAPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x36F2280", Offset = "0x36F1680", VA = "0x1836F2280")]
	public void OIGNPMFKFFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x36F2200", Offset = "0x36F1600", VA = "0x1836F2200")]
	public T MJAHJLEINNA()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x36F1F20", Offset = "0x36F1320", VA = "0x1836F1F20")]
	private void ICHLAKEJKBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x36F2430", Offset = "0x36F1830", VA = "0x1836F2430")]
	public FLKMNPBEHFE()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		[GIMHEFLPFNM(FMDIPNBCKBB.Self, false, false, false)]
		[SerializeField]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x618EE80", Offset = "0x618E280", VA = "0x18618EE80")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x618F150", Offset = "0x618E550", VA = "0x18618F150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x618F060", Offset = "0x618E460", VA = "0x18618F060")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x618EDD0", Offset = "0x618E1D0", VA = "0x18618EDD0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x618F0A0", Offset = "0x618E4A0", VA = "0x18618F0A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x618EFB0", Offset = "0x618E3B0", VA = "0x18618EFB0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x618ED40", Offset = "0x618E140", VA = "0x18618ED40")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x4358BB0", Offset = "0x4357FB0", VA = "0x184358BB0", Slot = "4")]
		public virtual T GEJOJBPLADJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class FOLBBJFBHLD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly Dictionary<byte, IMCOPMIKJAN> LGHILLMDAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly EKJKPBAIBIP<IMCOPMIKJAN> MMDEHHICNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly bool FGGGAMBDHGH;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public IMCOPMIKJAN LEKDBDAMOJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A50", Offset = "0x7BFE50", VA = "0x1807C0A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public Vector2 DMIMNICPOKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xBBCC30", Offset = "0xBBC030", VA = "0x180BBCC30")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xEA5350", Offset = "0xEA4750", VA = "0x180EA5350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	private Vector2 PFPGGOPBMLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xEE46F0", Offset = "0xEE3AF0", VA = "0x180EE46F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public Vector2 MPHOCBHDGCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x618D880", Offset = "0x618CC80", VA = "0x18618D880")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7C4660", Offset = "0x7C3A60", VA = "0x1807C4660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public int IPALFELGJHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7C0C80", Offset = "0x7C0080", VA = "0x1807C0C80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A90", Offset = "0x7BFE90", VA = "0x1807C0A90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x618DB00", Offset = "0x618CF00", VA = "0x18618DB00")]
	public FOLBBJFBHLD(Bounds NLHJJODOMAG, Vector2[] IOCODIDHGDJ, int PJCJNHNOHPB, byte CAIMMNKGOCP, float LKKCPHDJEGH = 0f, [Optional] EKJKPBAIBIP<IMCOPMIKJAN> MMDEHHICNMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x618DAA0", Offset = "0x618CEA0", VA = "0x18618DAA0")]
	public IMCOPMIKJAN POKCKMIGGFA(byte PMLKPJNGBAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x618D3E0", Offset = "0x618C7E0", VA = "0x18618D3E0")]
	public void BJEJOPALAOG(Vector3 CJBHLOLHNJP, float AEMOOOGLMDM, float BMDKGKGJKIN, List<byte> PLOIDGHLAPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x590E320", Offset = "0x590D720", VA = "0x18590E320")]
	public void PLCNKIKOAPL(IMCOPMIKJAN.PEMMAMMMNGP DMHDODBOLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x618D790", Offset = "0x618CB90", VA = "0x18618D790")]
	public static int GNOAKBCMMNN(Vector2[] IOCODIDHGDJ, int PJCJNHNOHPB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x618D8A0", Offset = "0x618CCA0", VA = "0x18618D8A0")]
	private IMCOPMIKJAN IDCLILDAHLL(byte PMLKPJNGBAD, IMCOPMIKJAN.HLLBGHKOHEJ CEBJGHHAPGC, IMCOPMIKJAN NCGFJMKBOIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x618D030", Offset = "0x618C430", VA = "0x18618D030")]
	private void BEELNHLDOFP(IMCOPMIKJAN NCGFJMKBOIN, Vector2[] IOCODIDHGDJ, int HIGDJNOGBOD, int LAACGCFOJBN, int IDNNJAELGHM, int NJHFCPPNJCC, float LKKCPHDJEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x618D510", Offset = "0x618C910", VA = "0x18618D510")]
	private void EJGODHENEGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x618D4B0", Offset = "0x618C8B0", VA = "0x18618D4B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x618D730", Offset = "0x618CB30", VA = "0x18618D730", Slot = "1")]
	~FOLBBJFBHLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class IMCOPMIKJAN
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public enum HLLBGHKOHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public enum PEMMAMMMNGP
	{
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public byte KGFFFPMLIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public Vector3 IFMMKKAIADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public Vector3 JOOOJCLOMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public Vector3 HCAOFCBGPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public Vector3 DNFLMIINGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public HLLBGHKOHEJ OCPBNMGKBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public IMCOPMIKJAN PLHMPAHPDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public List<IMCOPMIKJAN> MPNPJONBMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public bool LMKFDAFPDND;

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x618E660", Offset = "0x618DA60", VA = "0x18618E660")]
	public IMCOPMIKJAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x618E510", Offset = "0x618D910", VA = "0x18618E510")]
	public void HFLJCFEFFHN(IMCOPMIKJAN FGOLIAHPGNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
	public void PLCNKIKOAPL(int BNJLKNPGNDB, PEMMAMMMNGP DMHDODBOLDK, int MOGIOJIPFMD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x618E220", Offset = "0x618D620", VA = "0x18618E220")]
	public void BJEJOPALAOG(List<byte> PLOIDGHLAPK, Vector3 CJBHLOLHNJP, float AEMOOOGLMDM, float BMDKGKGJKIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x618E630", Offset = "0x618DA30", VA = "0x18618E630")]
	public bool OKHLENEMGAG(Vector3 AJNCJEIJBDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x618E1F0", Offset = "0x618D5F0", VA = "0x18618E1F0")]
	public bool ANDBJGCBGBP(Vector3 AJNCJEIJBDA, float OCPFEAKMPGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x618E480", Offset = "0x618D880", VA = "0x18618E480")]
	public void EOPEJCOCBHD()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000065")]
		public struct OFDBPCIDIFM<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			private readonly List<Component> OCAIIBKPIPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			private readonly bool IBEMPOLLJAJ;

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x37B8E60", Offset = "0x37B8260", VA = "0x1837B8E60")]
			public OFDBPCIDIFM(List<Component> OCAIIBKPIPH, bool IBEMPOLLJAJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x40CDC50", Offset = "0x40CD050", VA = "0x1840CDC50")]
			public NCBMEJFCJBB<T> CKFAHJNIOKH()
			{
				return default(NCBMEJFCJBB<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x40CDCC0", Offset = "0x40CD0C0", VA = "0x1840CDCC0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x40CDCC0", Offset = "0x40CD0C0", VA = "0x1840CDCC0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		public struct NCBMEJFCJBB<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			private readonly List<Component> OCAIIBKPIPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			private readonly bool IBEMPOLLJAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			private int PMLKPJNGBAD;

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			public T MPGEHNMDMNL
			{
				[Cpp2IlInjected.Token(Token = "0x60001FD")]
				[Cpp2IlInjected.Address(RVA = "0x3F6C080", Offset = "0x3F6B480", VA = "0x183F6C080", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001FE")]
				[Cpp2IlInjected.Address(RVA = "0x3F6C010", Offset = "0x3F6B410", VA = "0x183F6C010", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x3F6C050", Offset = "0x3F6B450", VA = "0x183F6C050")]
			public NCBMEJFCJBB(List<Component> OCAIIBKPIPH, bool IBEMPOLLJAJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x3F6BF50", Offset = "0x3F6B350", VA = "0x183F6BF50", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x3F6BF60", Offset = "0x3F6B360", VA = "0x183F6BF60", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x33C3AE0", Offset = "0x33C2EE0", VA = "0x1833C3AE0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x61904C0", Offset = "0x618F8C0", VA = "0x1861904C0")]
		private void EOPEJCOCBHD(GameObject NGNKIPEBKDP, bool DOPMCGBECME = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x6190630", Offset = "0x618FA30", VA = "0x186190630")]
		public static void EOPEJCOCBHD(GameObject NGNKIPEBKDP, ToolHierarchyCache PNLGEMHJHFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x2A94140", Offset = "0x2A93540", VA = "0x182A94140")]
		public void NEKHFGGNJEN<T>(Action<T> PNAPELFIIEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x2A940D0", Offset = "0x2A934D0", VA = "0x182A940D0")]
		public T KNBGMDFIGKA<T>(bool IBEMPOLLJAJ = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x2A94010", Offset = "0x2A93410", VA = "0x182A94010")]
		public OFDBPCIDIFM<T> AAIKKHOEDMI<T>(bool IBEMPOLLJAJ = false) where T : class
		{
			return default(OFDBPCIDIFM<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x61908E0", Offset = "0x618FCE0", VA = "0x1861908E0")]
		public List<Component> PEPPLKMDBMC(Type NBMJAHOKHAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x61907F0", Offset = "0x618FBF0", VA = "0x1861907F0", Slot = "4")]
		public bool Equals(ToolHierarchyCache LCKGOLLEJPE, ToolHierarchyCache OHIBEIOBHMK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6190870", Offset = "0x618FC70", VA = "0x186190870", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache LIKEKIACGIL)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class FFBNLEMHGGB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private int MIFMOLKOCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private int FLOCBEOCLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private List<T> LFDAFBILLFC;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int ALDOGAGGHGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x33698D0", Offset = "0x3368CD0", VA = "0x1833698D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public T KPEIOJKKKLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x36D3460", Offset = "0x36D2860", VA = "0x1836D3460")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public T ILHFBPAINPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x36D3040", Offset = "0x36D2440", VA = "0x1836D3040")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public T FINLAJOHGJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x36D3380", Offset = "0x36D2780", VA = "0x1836D3380")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x36D3670", Offset = "0x36D2A70", VA = "0x1836D3670")]
	public FFBNLEMHGGB(int MIFMOLKOCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x36D3190", Offset = "0x36D2590", VA = "0x1836D3190")]
	public void FFIECPFJEFG(T LNIGNALJMAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x36D35D0", Offset = "0x36D29D0", VA = "0x1836D35D0")]
	public void OIGNPMFKFFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x36D30B0", Offset = "0x36D24B0", VA = "0x1836D30B0")]
	public void CPKBJPOPLGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x36D3610", Offset = "0x36D2A10", VA = "0x1836D3610")]
	public void OKPJCGEHHHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x36D3180", Offset = "0x36D2580", VA = "0x1836D3180")]
	public void FFBFBLLIAHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class IDJBKGEFNLO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private struct MHCOGKOGAKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public int NPJJMFFADMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public T EIHNEEOMIED;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly Dictionary<object, MHCOGKOGAKC> HIPPGGLCLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly EqualityComparer<T> PGAOIOBNFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private T JMLKGDNFJLA;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public virtual T JOBJAFILCBC
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x107D0D0", Offset = "0x107C4D0", VA = "0x18107D0D0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x399BC80", Offset = "0x399B080", VA = "0x18399BC80", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool MLEHHLOOALM
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x399BCA0", Offset = "0x399B0A0", VA = "0x18399BCA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public object FAAMNDLMPBI
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F80", Offset = "0x7C1380", VA = "0x1807C1F80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x399BBC0", Offset = "0x399AFC0", VA = "0x18399BBC0")]
	public bool KEEOLFKBIJH(T PCGOHCLJAPN, object ICNJFMMNIKL, int FEOEIKFIFFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x399BAA0", Offset = "0x399AEA0", VA = "0x18399BAA0")]
	public bool EHEEBOIOGGL(object ICNJFMMNIKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x399BB30", Offset = "0x399AF30", VA = "0x18399BB30")]
	public bool JFDMGELHHBG(object ICNJFMMNIKL, [Out] T PCGOHCLJAPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x399BCF0", Offset = "0x399B0F0", VA = "0x18399BCF0")]
	public void OIGNPMFKFFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x399BD20", Offset = "0x399B120", VA = "0x18399BD20")]
	private bool OLKGFFLHGJG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x399C000", Offset = "0x399B400", VA = "0x18399C000")]
	public IDJBKGEFNLO()
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
