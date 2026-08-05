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
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x75C2C60", Offset = "0x75C1E60", VA = "0x1875C2C60")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x98D6C0", Offset = "0x98C8C0", VA = "0x18098D6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x98D700", Offset = "0x98C900", VA = "0x18098D700")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class MHCPMLHHPED : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1E79E60", Offset = "0x1E79060", VA = "0x181E79E60")]
	public MHCPMLHHPED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, EMPGDIIHNBM, EFNGFPIAFBC, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9642A0", Offset = "0x9634A0", VA = "0x1809642A0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9642B0", Offset = "0x9634B0", VA = "0x1809642B0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB81020", Offset = "0xB80220", VA = "0x180B81020", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash HFFPIBBOHEG);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xAA8D90", Offset = "0xAA7F90", VA = "0x180AA8D90")]
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
		[Cpp2IlInjected.Address(RVA = "0x75C4620", Offset = "0x75C3820", VA = "0x1875C4620")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x75C45E0", Offset = "0x75C37E0", VA = "0x1875C45E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x75C4660", Offset = "0x75C3860", VA = "0x1875C4660")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x75C4810", Offset = "0x75C3A10", VA = "0x1875C4810")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x75C4780", Offset = "0x75C3980", VA = "0x1875C4780")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xDE8360", Offset = "0xDE7560", VA = "0x180DE8360")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xC30C00", Offset = "0xC2FE00", VA = "0x180C30C00")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x75C45A0", Offset = "0x75C37A0", VA = "0x1875C45A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x75C46F0", Offset = "0x75C38F0", VA = "0x1875C46F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x75C41F0", Offset = "0x75C33F0", VA = "0x1875C41F0")]
	public void CopyBounds(SavedExtents LDKNLBHIGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x75C44F0", Offset = "0x75C36F0", VA = "0x1875C44F0")]
	public void SetLocalSpaceBounds(Bounds OODMIMPICHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1263F30", Offset = "0x1263130", VA = "0x181263F30")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x75C44E0", Offset = "0x75C36E0", VA = "0x1875C44E0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x75C3A00", Offset = "0x75C2C00", VA = "0x1875C3A00")]
	private void CGDIHNCGDIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x75C42E0", Offset = "0x75C34E0", VA = "0x1875C42E0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x75C3BB0", Offset = "0x75C2DB0", VA = "0x1875C3BB0")]
	public static void CalculateLocalBoundsFor(GameObject LNIONOAAAEO, [Out] Bounds OODMIMPICHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x75C4220", Offset = "0x75C3420", VA = "0x1875C4220")]
	private static void GKMDJCMMGKF(Bounds FHOBAJOBBGC, Color CPCFIJBFPJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x75C4510", Offset = "0x75C3710", VA = "0x1875C4510")]
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
		[Cpp2IlInjected.Address(RVA = "0x9611A0", Offset = "0x9603A0", VA = "0x1809611A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x971850", Offset = "0x970A50", VA = "0x180971850")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x16CDED0", Offset = "0x16CD0D0", VA = "0x1816CDED0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5334480", Offset = "0x5333680", VA = "0x185334480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "4")]
	public virtual void OKGGDKHCGGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
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
	[MHCPMLHHPED]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5334000", Offset = "0x5333200", VA = "0x185334000", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5332C10", Offset = "0x5331E10", VA = "0x185332C10", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x53343A0", Offset = "0x53335A0", VA = "0x1853343A0")]
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
	private sealed class MPLIFIGDEMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public MPLIFIGDEMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4DC65C0", Offset = "0x4DC57C0", VA = "0x184DC65C0")]
		internal int FOLAOMAPIAO(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[MHCPMLHHPED]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4129940", Offset = "0x4128B40", VA = "0x184129940", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x41299A0", Offset = "0x4128BA0", VA = "0x1841299A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x41297C0", Offset = "0x41289C0", VA = "0x1841297C0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey MBDBONINAPC]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4129880", Offset = "0x4128A80", VA = "0x184129880", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4129670", Offset = "0x4128870", VA = "0x184129670", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4129310", Offset = "0x4128510", VA = "0x184129310", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4128700", Offset = "0x4127900", VA = "0x184128700", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4128540", Offset = "0x4127740", VA = "0x184128540", Slot = "14")]
	protected virtual string BPAAJOJPHDH(TKeyVal FFKJOAKBCNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x41285A0", Offset = "0x41277A0", VA = "0x1841285A0", Slot = "4")]
	public bool ContainsKey(TKey MBDBONINAPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x41294F0", Offset = "0x41286F0", VA = "0x1841294F0", Slot = "5")]
	public bool TryGetValue(TKey MBDBONINAPC, [Out] TVal OMFJNFBDJCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4128660", Offset = "0x4127860", VA = "0x184128660", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4128660", Offset = "0x4127860", VA = "0x184128660", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4129550", Offset = "0x4128750", VA = "0x184129550")]
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
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x964780", Offset = "0x963980", VA = "0x180964780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9642A0", Offset = "0x9634A0", VA = "0x1809642A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x40A7EB0", Offset = "0x40A70B0", VA = "0x1840A7EB0")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[MHCPMLHHPED]
	[SerializeField]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5335DB0", Offset = "0x5334FB0", VA = "0x185335DB0")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5335620", Offset = "0x5334820", VA = "0x185335620", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5334BF0", Offset = "0x5333DF0", VA = "0x185334BF0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class CKIOMANFDIF<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct PBEKHMJCCCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public T CADNOMLIGCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public float OGGHJKLPAOO;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int DABONNBKFKE = 16;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const float FOALOGDLEMD = -1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected readonly PBEKHMJCCCL[] LGLFHJLCKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	protected int DBPILKOELJI;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float MJBIGBAAMOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xB087C0", Offset = "0xB079C0", VA = "0x180B087C0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xB78510", Offset = "0xB77710", VA = "0x180B78510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public T HEJEDAKJCFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9642A0", Offset = "0x9634A0", VA = "0x1809642A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5CDF600", Offset = "0x5CDE800", VA = "0x185CDF600")]
	protected CKIOMANFDIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5CDF570", Offset = "0x5CDE770", VA = "0x185CDF570")]
	protected CKIOMANFDIF(int IAGJHPFNLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5CDF330", Offset = "0x5CDE530", VA = "0x185CDF330")]
	public void OFEFHMDJLMD(float HFMGEOLGMMO, T OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool AIEPBAGFLKD(float GEPPIPLKAPF, float DABEEMEOADO, [Out] T OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool ECIIHJOPOKC(float GEPPIPLKAPF, float DABEEMEOADO, [Out] T OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5CDF270", Offset = "0x5CDE470", VA = "0x185CDF270")]
	public void NLADMABHKNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class OJODLOBJCDI : CKIOMANFDIF<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x75C2CE0", Offset = "0x75C1EE0", VA = "0x1875C2CE0", Slot = "4")]
	public override bool AIEPBAGFLKD(float GEPPIPLKAPF, float DABEEMEOADO, [Out] Vector3 OMFJNFBDJCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x75C2E40", Offset = "0x75C2040", VA = "0x1875C2E40", Slot = "5")]
	public override bool ECIIHJOPOKC(float GEPPIPLKAPF, float DABEEMEOADO, [Out] Vector3 OMFJNFBDJCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x75C2F80", Offset = "0x75C2180", VA = "0x1875C2F80")]
	public OJODLOBJCDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class DPCLMFEGAFI
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x32D20A0", Offset = "0x32D12A0", VA = "0x1832D20A0")]
	public static HAMAAIFHDEF<T1, T2> JENMMFKNHKF<T1, T2>(T1 GDJNALNMDFL, T2 CICLIAPMOPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x32D2130", Offset = "0x32D1330", VA = "0x1832D2130")]
	public static LPJEJMOKMAN<T1, T2, T3> JENMMFKNHKF<T1, T2, T3>(T1 GDJNALNMDFL, T2 CICLIAPMOPJ, T3 DKCAIEDHOIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4DF3CD0", Offset = "0x4DF2ED0", VA = "0x184DF3CD0")]
	internal static int BLJCOGJLILI(int LLMOLAELKIO, int BFNIEAAJHGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6862270", Offset = "0x6861470", VA = "0x186862270")]
	internal static int BLJCOGJLILI(int LLMOLAELKIO, int BFNIEAAJHGM, int EIEGJDGBHPL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HAMAAIFHDEF<T1, T2> : IComparable<HAMAAIFHDEF<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T1 GLLLPCGIEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T2 KGFEHKFAGOH;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x468F090", Offset = "0x468E290", VA = "0x18468F090")]
	public HAMAAIFHDEF(T1 GDJNALNMDFL, T2 CICLIAPMOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x468D690", Offset = "0x468C890", VA = "0x18468D690", Slot = "4")]
	public int CompareTo(HAMAAIFHDEF<T1, T2> LDKNLBHIGFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x468E140", Offset = "0x468D340", VA = "0x18468E140", Slot = "0")]
	public override bool Equals(object LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x468E5E0", Offset = "0x468D7E0", VA = "0x18468E5E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x468EE00", Offset = "0x468E000", VA = "0x18468EE00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class LPJEJMOKMAN<T1, T2, T3> : IComparable<LPJEJMOKMAN<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T1 GLLLPCGIEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T2 KGFEHKFAGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T3 FIBJFNFNHFI;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4B9AF00", Offset = "0x4B9A100", VA = "0x184B9AF00")]
	public LPJEJMOKMAN(T1 GDJNALNMDFL, T2 CICLIAPMOPJ, T3 DKCAIEDHOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4B9A6F0", Offset = "0x4B998F0", VA = "0x184B9A6F0", Slot = "4")]
	public int CompareTo(LPJEJMOKMAN<T1, T2, T3> LDKNLBHIGFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4B9A840", Offset = "0x4B99A40", VA = "0x184B9A840", Slot = "0")]
	public override bool Equals(object LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4B9AB10", Offset = "0x4B99D10", VA = "0x184B9AB10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4B9AD50", Offset = "0x4B99F50", VA = "0x184B9AD50", Slot = "3")]
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
	public AnimationCurve ENCEJPGAJHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T MGBDCILGKMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xE11FB0", Offset = "0xE111B0", VA = "0x180E11FB0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T JEINKFEPJNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xAF8440", Offset = "0xAF7640", VA = "0x180AF8440")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T CADNOMLIGCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x29575D0", Offset = "0x29567D0", VA = "0x1829575D0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2957520", Offset = "0x2956720", VA = "0x182957520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float BGIAAMFACJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xAE43C0", Offset = "0xAE35C0", VA = "0x180AE43C0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x55B8430", Offset = "0x55B7630", VA = "0x1855B8430")]
	public T JFPPPBJFPAD(float FDDEDLKEPIJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x55B8940", Offset = "0x55B7B40", VA = "0x1855B8940")]
	public T JIIICDOHAOD(float FDDEDLKEPIJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T GIFBGFGJLNC(T DOEPDJPJMCB, T DHHGPPJBNNK, float FDDEDLKEPIJ);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x75BF3C0", Offset = "0x75BE5C0", VA = "0x1875BF3C0", Slot = "4")]
	protected override float GIFBGFGJLNC(float DOEPDJPJMCB, float DHHGPPJBNNK, float FDDEDLKEPIJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x75BF400", Offset = "0x75BE600", VA = "0x1875BF400")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1551450", Offset = "0x1550650", VA = "0x181551450", Slot = "4")]
	protected override Vector3 GIFBGFGJLNC(Vector3 DOEPDJPJMCB, Vector3 DHHGPPJBNNK, float FDDEDLKEPIJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x75C55B0", Offset = "0x75C47B0", VA = "0x1875C55B0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x75BF010", Offset = "0x75BE210", VA = "0x1875BF010", Slot = "4")]
	protected override Color GIFBGFGJLNC(Color DOEPDJPJMCB, Color DHHGPPJBNNK, float FDDEDLKEPIJ)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x75BF0D0", Offset = "0x75BE2D0", VA = "0x1875BF0D0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class DJMBKLMJMGD : DIJIFHIFGBF<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x75BF1F0", Offset = "0x75BE3F0", VA = "0x1875BF1F0")]
	public DJMBKLMJMGD(int ECPBKIMJCKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x75BF180", Offset = "0x75BE380", VA = "0x1875BF180", Slot = "6")]
	protected override uint EHNKMBDIIIJ(uint HFFPIBBOHEG, string OMFJNFBDJCA)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class MPENLLAAEEF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly IDisposable JLGHKLNHGNO;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public MPENLLAAEEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct GKACANJFKFN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> BPKJILNPOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int HIOLAFHLHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int LONACJDIGBD;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x461A750", Offset = "0x4619950", VA = "0x18461A750")]
	private GKACANJFKFN(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> CCNLEKEFHEL, int NIMJOBFEKPC, int JOCGDHKJFDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x461A650", Offset = "0x4619850", VA = "0x18461A650")]
	public static GKACANJFKFN<T> PEFMILKIAFF()
	{
		return default(GKACANJFKFN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4618A10", Offset = "0x4617C10", VA = "0x184618A10")]
	public (int, int, Task<T>) JMBDINDJOLC(int MJBKPLCECIO, [Optional] CancellationToken KPIINMODKFJ, double KDJGAOFKCEM = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4618810", Offset = "0x4617A10", VA = "0x184618810")]
	public void DNMIBMPKFOB(int MJBKPLCECIO, int JOCGDHKJFDF, [In] T CMLOHOMLNDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class MEMLBJDEFIL
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x75C1930", Offset = "0x75C0B30", VA = "0x1875C1930")]
	public static GKACANJFKFN<OJADAPCHIGK> PEFMILKIAFF()
	{
		return default(GKACANJFKFN<OJADAPCHIGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x75C18B0", Offset = "0x75C0AB0", VA = "0x1875C18B0")]
	public static void DNMIBMPKFOB([In] this GKACANJFKFN<OJADAPCHIGK> NAELBAPCKEH, int MJBKPLCECIO, int JOCGDHKJFDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class BBIILLILECM<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly Dictionary<TKey, TVal> PJOEDNEJFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TVal, TKey> LDDGCOMBJEK;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int ABNMPHLJIIM
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3D86B30", Offset = "0x3D85D30", VA = "0x183D86B30", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool KNKMFKKGHON
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> PFMMGLFCDHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5898490", Offset = "0x5897690", VA = "0x185898490", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> EIIIMHCDFFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x463A390", Offset = "0x4639590", VA = "0x18463A390", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal EPCJHJAGLJO
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5898430", Offset = "0x5897630", VA = "0x185898430", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x58984E0", Offset = "0x58976E0", VA = "0x1858984E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey EPCJHJAGLJO
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5897BB0", Offset = "0x5896DB0", VA = "0x185897BB0")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5897960", Offset = "0x5896B60", VA = "0x185897960", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5898260", Offset = "0x5897460", VA = "0x185898260", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x58976B0", Offset = "0x58968B0", VA = "0x1858976B0", Slot = "9")]
	public void Add(TKey MBDBONINAPC, TVal OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5897660", Offset = "0x5896860", VA = "0x185897660", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> LOKFKJLCEOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5897A00", Offset = "0x5896C00", VA = "0x185897A00", Slot = "8")]
	public bool ContainsKey(TKey MBDBONINAPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5897AF0", Offset = "0x5896CF0", VA = "0x185897AF0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> LOKFKJLCEOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5898150", Offset = "0x5897350", VA = "0x185898150", Slot = "10")]
	public bool Remove(TKey MBDBONINAPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5898190", Offset = "0x5897390", VA = "0x185898190", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> LOKFKJLCEOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x58982B0", Offset = "0x58974B0", VA = "0x1858982B0", Slot = "11")]
	public bool TryGetValue(TKey MBDBONINAPC, [Out] TVal OMFJNFBDJCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5897C70", Offset = "0x5896E70", VA = "0x185897C70", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5897B30", Offset = "0x5896D30", VA = "0x185897B30", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] LGLFHJLCKKH, int BOCNEABHGNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5897D10", Offset = "0x5896F10", VA = "0x185897D10")]
	public bool JGIAJCMJDDJ(TVal MBDBONINAPC, [Out] TKey OMFJNFBDJCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5898060", Offset = "0x5897260", VA = "0x185898060")]
	private void OMIDDOPIKIB(TKey MBDBONINAPC, TVal HBMPJOCKNNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5897DD0", Offset = "0x5896FD0", VA = "0x185897DD0")]
	private void NDNPNCPDDLI(TKey MBDBONINAPC, TVal HBMPJOCKNNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5897740", Offset = "0x5896940", VA = "0x185897740")]
	private bool COMPPHKPLBC(TKey MBDBONINAPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5898310", Offset = "0x5897510", VA = "0x185898310")]
	public BBIILLILECM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class MDLBGMKHLKH<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private MDLBGMKHLKH<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x10DD940", Offset = "0x10DCB40", VA = "0x1810DD940", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x418AFB0", Offset = "0x418A1B0", VA = "0x18418AFB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x418B960", Offset = "0x418AB60", VA = "0x18418B960")]
		public Enumerator(MDLBGMKHLKH<T> LPBGEKCBGMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x4189050", Offset = "0x4188250", VA = "0x184189050", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x4189C10", Offset = "0x4188E10", VA = "0x184189C10", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4188090", Offset = "0x4187290", VA = "0x184188090")]
		private void CFFFKIIEAAA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private T[] NGFNHFEAIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int JMHJAFCGEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int LPCCFPHDMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int LCLBPLEFKON;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int ABNMPHLJIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x4D956F0", Offset = "0x4D948F0", VA = "0x184D956F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T EPCJHJAGLJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4D94C50", Offset = "0x4D93E50", VA = "0x184D94C50")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x4D94870", Offset = "0x4D93A70", VA = "0x184D94870")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4D96940", Offset = "0x4D95B40", VA = "0x184D96940")]
	public MDLBGMKHLKH(int ECPBKIMJCKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4D95C20", Offset = "0x4D94E20", VA = "0x184D95C20")]
	public void OFEFHMDJLMD(T FDDEDLKEPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4D95730", Offset = "0x4D94930", VA = "0x184D95730")]
	public void NLADMABHKNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4D96590", Offset = "0x4D95790", VA = "0x184D96590")]
	public void PLGHCLDIJHE(int IPBKHOJKHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4D952A0", Offset = "0x4D944A0", VA = "0x184D952A0")]
	public void MPPBMNJFIOP(T[] LGLFHJLCKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4D95DA0", Offset = "0x4D94FA0", VA = "0x184D95DA0")]
	public Enumerator PACLDABBHPO()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4D968A0", Offset = "0x4D95AA0", VA = "0x184D968A0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4D968A0", Offset = "0x4D95AA0", VA = "0x184D968A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4D960D0", Offset = "0x4D952D0", VA = "0x184D960D0")]
	private int PIKHLHMIJPK(int KOOLKCPAFBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4D95E40", Offset = "0x4D95040", VA = "0x184D95E40")]
	private int PAPCPENEHME(int KOOLKCPAFBB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class FIIPNJENADE<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate Task<TResult> BJAPNEICIEI(TRequest NKJDMJIDCOG, CancellationToken KPIINMODKFJ);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum JMJBPNOLAIA
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class NPCFOKCOKJD
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const float KNBADHJAFGC = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TimeSpan LJGMMEMBIAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int CELGPEFKFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public JMJBPNOLAIA LCEDKMIGDCL;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly NPCFOKCOKJD IDMKIMBBHMK;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float CFOHLGHBJBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x4E5DB10", Offset = "0x4E5CD10", VA = "0x184E5DB10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public TimeSpan ELLOCDMHBFM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x4E5DBF0", Offset = "0x4E5CDF0", VA = "0x184E5DBF0")]
		public NPCFOKCOKJD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private readonly struct OMLDLFAEANJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public readonly TRequest NKJDMJIDCOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly CancellationToken KPIINMODKFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly TaskCompletionSource<TResult> LEGMNCHIOIB;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x5013850", Offset = "0x5012A50", VA = "0x185013850")]
		public OMLDLFAEANJ(TRequest NKJDMJIDCOG, TaskCompletionSource<TResult> LEGMNCHIOIB, CancellationToken KPIINMODKFJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct NGMCACAIAJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public FIIPNJENADE<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x4E2F4E0", Offset = "0x4E2E6E0", VA = "0x184E2F4E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4E2F940", Offset = "0x4E2EB40", VA = "0x184E2F940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct FLADLCGLLND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public FIIPNJENADE<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private OMLDLFAEANJ <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x453D380", Offset = "0x453C580", VA = "0x18453D380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x453DFA0", Offset = "0x453D1A0", VA = "0x18453DFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CancellationTokenSource GAEKIBOIGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly List<OMLDLFAEANJ> GLCFPGKEFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly NPCFOKCOKJD LGINFINHNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly BJAPNEICIEI FEBFADHLENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Task JAAJBOJGLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int BBBEFALPNBO;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x44D0AF0", Offset = "0x44CFCF0", VA = "0x1844D0AF0")]
	public FIIPNJENADE(BJAPNEICIEI FEBFADHLENM, [Optional] NPCFOKCOKJD LGINFINHNAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x44CF090", Offset = "0x44CE290", VA = "0x1844CF090")]
	public Task<TResult> CLJBBLFKBDE(TRequest NKJDMJIDCOG, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x44CF940", Offset = "0x44CEB40", VA = "0x1844CF940")]
	private void HIIDHKBGNBA(OMLDLFAEANJ OMNOBDDPMFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x44CFAD0", Offset = "0x44CECD0", VA = "0x1844CFAD0")]
	[AsyncStateMachine(typeof(FIIPNJENADE<, >.NGMCACAIAJB))]
	private Task ILHDKDMCOIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x44D0520", Offset = "0x44CF720", VA = "0x1844D0520")]
	private OMLDLFAEANJ LIJONDMEBDL()
	{
		return default(OMLDLFAEANJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x44CEFA0", Offset = "0x44CE1A0", VA = "0x1844CEFA0")]
	[AsyncStateMachine(typeof(FIIPNJENADE<, >.FLADLCGLLND))]
	private Task BHICLBELCIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x44CFE70", Offset = "0x44CF070", VA = "0x1844CFE70")]
	private void KMGDNKFHJMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x44CF760", Offset = "0x44CE960", VA = "0x1844CF760", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class DBEJDPHNOBA<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly List<T> KBPAKCCMOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private HashSet<T> DAMLJBCFJNJ;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int ABNMPHLJIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3D86B30", Offset = "0x3D85D30", VA = "0x183D86B30", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool KNKMFKKGHON
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T EPCJHJAGLJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6378390", Offset = "0x6377590", VA = "0x186378390", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6378510", Offset = "0x6377710", VA = "0x186378510", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4579130", Offset = "0x4578330", VA = "0x184579130", Slot = "11")]
	public void Add(T LOKFKJLCEOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x63779A0", Offset = "0x6376BA0", VA = "0x1863779A0")]
	public bool HJGDJNCJEIA(T LOKFKJLCEOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x63781B0", Offset = "0x63773B0", VA = "0x1863781B0", Slot = "15")]
	public bool Remove(T LOKFKJLCEOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x58B1700", Offset = "0x58B0900", VA = "0x1858B1700", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x45BD470", Offset = "0x45BC670", VA = "0x1845BD470", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6377800", Offset = "0x6376A00", VA = "0x186377800", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x63778F0", Offset = "0x6376AF0", VA = "0x1863778F0", Slot = "13")]
	public bool Contains(T LOKFKJLCEOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6377940", Offset = "0x6376B40", VA = "0x186377940", Slot = "14")]
	public void CopyTo(T[] LGLFHJLCKKH, int BOCNEABHGNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6377B90", Offset = "0x6376D90", VA = "0x186377B90", Slot = "6")]
	public int IndexOf(T LOKFKJLCEOD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6377BF0", Offset = "0x6376DF0", VA = "0x186377BF0", Slot = "7")]
	public void Insert(int KOOLKCPAFBB, T LOKFKJLCEOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6377E70", Offset = "0x6377070", VA = "0x186377E70", Slot = "8")]
	public void RemoveAt(int KOOLKCPAFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6378270", Offset = "0x6377470", VA = "0x186378270")]
	public DBEJDPHNOBA()
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
			[Cpp2IlInjected.Address(RVA = "0x27E6FC0", Offset = "0x27E61C0", VA = "0x1827E6FC0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2339BC0", Offset = "0x2338DC0", VA = "0x182339BC0")]
		public SerializedGuid([In] Guid FGPNICIMMFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x75C48D0", Offset = "0x75C3AD0", VA = "0x1875C48D0")]
		public static SerializedGuid EGDBFFAJBKH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x75C4A90", Offset = "0x75C3C90", VA = "0x1875C4A90")]
		public static SerializedGuid OLECPHJLLHJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x75C4A30", Offset = "0x75C3C30", VA = "0x1875C4A30")]
		public bool KHBFGBFEAPJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x75C4B80", Offset = "0x75C3D80", VA = "0x1875C4B80", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x75C4B00", Offset = "0x75C3D00", VA = "0x1875C4B00", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x75C4950", Offset = "0x75C3B50", VA = "0x1875C4950", Slot = "7")]
		public bool Equals(SerializedGuid LDKNLBHIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x75C4990", Offset = "0x75C3B90", VA = "0x1875C4990", Slot = "0")]
		public override bool Equals(object ONELFPFEALD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x75C4A20", Offset = "0x75C3C20", VA = "0x1875C4A20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x75C48A0", Offset = "0x75C3AA0", VA = "0x1875C48A0", Slot = "6")]
		public int CompareTo(SerializedGuid LDKNLBHIGFL)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class DELKFKMCPLL : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Type AJMBFIMPDEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly string DBFPHBEKCPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly bool ENNCPJAJIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly bool GGHPJLAHPDI;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x75BF110", Offset = "0x75BE310", VA = "0x1875BF110")]
	public DELKFKMCPLL(Type KNDLJCKNODD, string FMIDIMIPPOA, bool HMHHPHEFIAI = false, bool FHJPGHIHKLP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface MIFFFKHKLPI<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	int ENNGJGAMCJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<T> EFHLNAPNFBN(float HFMGEOLGMMO, [Optional] float? KCOMEMFOJID);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LEJDHAHGJGM(float HFMGEOLGMMO, T OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NLADMABHKNO();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Obsolete("Use ITimeSeriesRollingWindow<T> instead")]
public class CPLDOAILLAG<T> : MIFFFKHKLPI<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private class NPLKILHPIII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float JEBELGDGHIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public T CADNOMLIGCM;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public NPLKILHPIII()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class GKLEEDKBCII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public GKLEEDKBCII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x461BE20", Offset = "0x461B020", VA = "0x18461BE20")]
		internal bool MKCIIEGJFPB(NPLKILHPIII sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly float IAHNDGAKADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly float ANLDFAKEJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<NPLKILHPIII> LAANAMEMAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private JCHFLJBCGMG<NPLKILHPIII> NAPNCKHMNEK;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int ENNGJGAMCJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5DCFE60", Offset = "0x5DCF060", VA = "0x185DCFE60", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5DCFF40", Offset = "0x5DCF140", VA = "0x185DCFF40")]
	public CPLDOAILLAG(float ELKDMGAMJCF, float IFEONIMOJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5DCFA30", Offset = "0x5DCEC30", VA = "0x185DCFA30", Slot = "6")]
	public bool LEJDHAHGJGM(float HFMGEOLGMMO, T OMFJNFBDJCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5DCF6D0", Offset = "0x5DCE8D0", VA = "0x185DCF6D0", Slot = "5")]
	public IEnumerable<T> EFHLNAPNFBN(float HFMGEOLGMMO, float? KCOMEMFOJID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5DCFDB0", Offset = "0x5DCEFB0", VA = "0x185DCFDB0", Slot = "7")]
	public void NLADMABHKNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5DCF1C0", Offset = "0x5DCE3C0", VA = "0x185DCF1C0")]
	private void BIOCBOOGMEN(float HFMGEOLGMMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class PGICFPMBCAB<T> : MIFFFKHKLPI<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct CALLPGGJADC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly T CADNOMLIGCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly float JEBELGDGHIJ;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x4B1C160", Offset = "0x4B1B360", VA = "0x184B1C160")]
		public CALLPGGJADC(T OMFJNFBDJCA, float HFMGEOLGMMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class COFNBJOMLHK : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
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
		public PGICFPMBCAB<T> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xD7DCC0", Offset = "0xD7CEC0", VA = "0x180D7DCC0")]
		[DebuggerHidden]
		public COFNBJOMLHK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5DC0B00", Offset = "0x5DBFD00", VA = "0x185DC0B00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5DC0EB0", Offset = "0x5DC00B0", VA = "0x185DC0EB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5DC0CC0", Offset = "0x5DBFEC0", VA = "0x185DC0CC0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x45DF8A0", Offset = "0x45DEAA0", VA = "0x1845DF8A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly float ELKDMGAMJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly float IFEONIMOJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly List<CALLPGGJADC> LAANAMEMAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int JMHJAFCGEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int HLLAIODCKNP;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int ENNGJGAMCJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x96C080", Offset = "0x96B280", VA = "0x18096C080", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x50C19C0", Offset = "0x50C0BC0", VA = "0x1850C19C0")]
	public PGICFPMBCAB(float ELKDMGAMJCF, float IFEONIMOJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x50C1520", Offset = "0x50C0720", VA = "0x1850C1520", Slot = "6")]
	public bool LEJDHAHGJGM(float HFMGEOLGMMO, T OMFJNFBDJCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x50C0ED0", Offset = "0x50C00D0", VA = "0x1850C0ED0", Slot = "8")]
	public int DHILAPMPDFL(float HFMGEOLGMMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x50C0F20", Offset = "0x50C0120", VA = "0x1850C0F20", Slot = "5")]
	[IteratorStateMachine(typeof(PGICFPMBCAB<>.COFNBJOMLHK))]
	public IEnumerable<T> EFHLNAPNFBN(float HFMGEOLGMMO, float? KCOMEMFOJID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x50C1960", Offset = "0x50C0B60", VA = "0x1850C1960", Slot = "7")]
	public void NLADMABHKNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x50C1190", Offset = "0x50C0390", VA = "0x1850C1190")]
	private void GPGIMMMLEJF(float HFMGEOLGMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x50C17D0", Offset = "0x50C09D0", VA = "0x1850C17D0")]
	private CALLPGGJADC NJAKHNKCANH()
	{
		return default(CALLPGGJADC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class AGOOCHPPHOP<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public readonly struct CIBCCPOLHOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly long EHBHAEHNIMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly long ICMPBANIGPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly int EOJBAIHJAIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly int IGNCFNHAKGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly bool LLDNHIOBOGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly string NKOBNJPJPCJ;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5BFBC20", Offset = "0x5BFAE20", VA = "0x185BFBC20")]
		public CIBCCPOLHOG(long EHBHAEHNIMC, int EOJBAIHJAIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5BFBC90", Offset = "0x5BFAE90", VA = "0x185BFBC90")]
		public CIBCCPOLHOG(long EHBHAEHNIMC, long ICMPBANIGPP, int EOJBAIHJAIC, int IGNCFNHAKGP, bool LLDNHIOBOGC, string NKOBNJPJPCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5BFBAB0", Offset = "0x5BFACB0", VA = "0x185BFBAB0")]
		public int AJPPIIKKDGG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5BFBB60", Offset = "0x5BFAD60", VA = "0x185BFBB60")]
		public int BBBEHAKMKLL(int JANENIGHHGN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5BFBB00", Offset = "0x5BFAD00", VA = "0x185BFBB00")]
		public double AKCNEGCOBHM()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5BFBB80", Offset = "0x5BFAD80", VA = "0x185BFBB80")]
		public CIBCCPOLHOG CILMBKFCHMK(long ICMPBANIGPP, int IGNCFNHAKGP)
		{
			return default(CIBCCPOLHOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class ABBPACGFNKJ : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private struct JPOOLADMOAM<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public ABBPACGFNKJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Func<ABBPACGFNKJ, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private ABBPACGFNKJ <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x49AAD40", Offset = "0x49A9F40", VA = "0x1849AAD40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x495DD00", Offset = "0x495CF00", VA = "0x18495DD00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly TKey MPHEPKMCCCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly AGOOCHPPHOP<TKey> MLINJELIMFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly PBBCGFNIILA NPAEAIAJLAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private List<ABBPACGFNKJ> MFHBCLHOBHN;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string BBNMEDEOGCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x464AA50", Offset = "0x4649C50", VA = "0x18464AA50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public IEnumerable<ABBPACGFNKJ> EALBHAANOIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x464AA10", Offset = "0x4649C10", VA = "0x18464AA10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public CIBCCPOLHOG EOEEFHOCCFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x464AEC0", Offset = "0x464A0C0", VA = "0x18464AEC0")]
			[CompilerGenerated]
			get
			{
				return default(CIBCCPOLHOG);
			}
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x464ACE0", Offset = "0x4649EE0", VA = "0x18464ACE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x464AEE0", Offset = "0x464A0E0", VA = "0x18464AEE0")]
		internal ABBPACGFNKJ(AGOOCHPPHOP<TKey> MLINJELIMFI, TKey MBDBONINAPC, PBBCGFNIILA NPAEAIAJLAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x464AD10", Offset = "0x4649F10", VA = "0x18464AD10")]
		public ABBPACGFNKJ LDMAJCIAOKM(TKey MBDBONINAPC, [Optional] PBBCGFNIILA? FMHOEFJDCCK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2C2E170", Offset = "0x2C2D370", VA = "0x182C2E170")]
		[AsyncStateMachine(typeof(JPOOLADMOAM<>))]
		public Task<T> LFNCJGOAFLN<T>(TKey MBDBONINAPC, Func<ABBPACGFNKJ, Task<T>> GGGDPGAGPON)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x464AAA0", Offset = "0x4649CA0", VA = "0x18464AAA0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class DAMEIKAILMH : IEnumerable<(TKey, List<TKey>, CIBCCPOLHOG)>, IEnumerable, IEnumerator<(TKey, List<TKey>, CIBCCPOLHOG)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private (TKey key, List<TKey> path, CIBCCPOLHOG timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AGOOCHPPHOP<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private IEnumerator<(TKey key, List<TKey> path, CIBCCPOLHOG timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private (TKey, List<TKey>, CIBCCPOLHOG) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x27D2100", Offset = "0x27D1300", VA = "0x1827D2100", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, CIBCCPOLHOG));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x6372970", Offset = "0x6371B70", VA = "0x186372970", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x27D21F0", Offset = "0x27D13F0", VA = "0x1827D21F0")]
		[DebuggerHidden]
		public DAMEIKAILMH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x458D1C0", Offset = "0x458C3C0", VA = "0x18458D1C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6372460", Offset = "0x6371660", VA = "0x186372460", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6372800", Offset = "0x6371A00", VA = "0x186372800")]
		private void PIKGOAEJJIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6372920", Offset = "0x6371B20", VA = "0x186372920", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6372850", Offset = "0x6371A50", VA = "0x186372850", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, CIBCCPOLHOG)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x45A6730", Offset = "0x45A5930", VA = "0x1845A6730", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class AIPIPNDCDHA : IEnumerable<(TKey, List<TKey>, CIBCCPOLHOG)>, IEnumerable, IEnumerator<(TKey, List<TKey>, CIBCCPOLHOG)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private (TKey key, List<TKey> path, CIBCCPOLHOG timerEntry) <>2__current;

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
		private ABBPACGFNKJ timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public ABBPACGFNKJ <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public AGOOCHPPHOP<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IEnumerator<ABBPACGFNKJ> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private IEnumerator<(TKey key, List<TKey> path, CIBCCPOLHOG timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private (TKey, List<TKey>, CIBCCPOLHOG) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x27D2100", Offset = "0x27D1300", VA = "0x1827D2100", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, CIBCCPOLHOG));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x4663C70", Offset = "0x4662E70", VA = "0x184663C70", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x27D21F0", Offset = "0x27D13F0", VA = "0x1827D21F0")]
		[DebuggerHidden]
		public AIPIPNDCDHA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x4663CD0", Offset = "0x4662ED0", VA = "0x184663CD0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x46632C0", Offset = "0x46624C0", VA = "0x1846632C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x4663A80", Offset = "0x4662C80", VA = "0x184663A80")]
		private void PIKGOAEJJIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x4663260", Offset = "0x4662460", VA = "0x184663260")]
		private void HEIMKCGCNNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x4663C20", Offset = "0x4662E20", VA = "0x184663C20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x4663AE0", Offset = "0x4662CE0", VA = "0x184663AE0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, CIBCCPOLHOG)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x4663BE0", Offset = "0x4662DE0", VA = "0x184663BE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Action<TKey, CIBCCPOLHOG, PBBCGFNIILA> CNEIJBFOJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Action<TKey, CIBCCPOLHOG, PBBCGFNIILA> HOCKJHFMIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly Action<AGOOCHPPHOP<TKey>, PBBCGFNIILA> JDPFCKGIHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly ABBPACGFNKJ BJFLCHAPBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private bool FEHOKBMGFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int IJAHEBCNCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Stopwatch FDFLGBNOOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly int FOGOKGHKDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private string GCNGDBOENGI;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public ABBPACGFNKJ NLDHKLEMDAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x964EC0", Offset = "0x9640C0", VA = "0x180964EC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	[NotNull]
	public string BBNMEDEOGCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x961630", Offset = "0x960830", VA = "0x180961630")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4656E20", Offset = "0x4656020", VA = "0x184656E20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4657150", Offset = "0x4656350", VA = "0x184657150")]
	public AGOOCHPPHOP(TKey IOEKIEHCFEF, PBBCGFNIILA NPAEAIAJLAP, [Optional] int? EOJBAIHJAIC, [Optional][CanBeNull] Stopwatch FDFLGBNOOMD, [Optional] Action<TKey, CIBCCPOLHOG, PBBCGFNIILA> CNEIJBFOJDA, [Optional] Action<TKey, CIBCCPOLHOG, PBBCGFNIILA> HOCKJHFMIHC, [Optional] Action<AGOOCHPPHOP<TKey>, PBBCGFNIILA> JDPFCKGIHOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x4656E80", Offset = "0x4656080", VA = "0x184656E80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4656F50", Offset = "0x4656150", VA = "0x184656F50")]
	[IteratorStateMachine(typeof(AGOOCHPPHOP<>.DAMEIKAILMH))]
	public IEnumerable<(TKey, List<TKey>, CIBCCPOLHOG)> KOPAMOHDECD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4656FF0", Offset = "0x46561F0", VA = "0x184656FF0")]
	[IteratorStateMachine(typeof(AGOOCHPPHOP<>.AIPIPNDCDHA))]
	private IEnumerable<(TKey, List<TKey>, CIBCCPOLHOG)> KOPAMOHDECD(List<TKey> PFECANJBHHJ, ABBPACGFNKJ HAAAAGLKPNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x46570D0", Offset = "0x46562D0", VA = "0x1846570D0")]
	private (long, int) OJBFIOODJLF()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public abstract class CHJBMGNOMOC<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut HCFLKNKOPMC(AGOOCHPPHOP<TKey> MLINJELIMFI);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	protected CHJBMGNOMOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class LKPCPKEMFDN<TKey> : CHJBMGNOMOC<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public delegate string AHABGEAKFHI(TKey MBDBONINAPC);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x4B89560", Offset = "0x4B88760", VA = "0x184B89560")]
	private static string JBPGKFAKEJG(TKey MBDBONINAPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4B89480", Offset = "0x4B88680", VA = "0x184B89480", Slot = "4")]
	public override string HCFLKNKOPMC(AGOOCHPPHOP<TKey> MLINJELIMFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4B89330", Offset = "0x4B88530", VA = "0x184B89330")]
	public string HCFLKNKOPMC(AGOOCHPPHOP<TKey> MLINJELIMFI, [NotNull] AHABGEAKFHI IIPHJOIEBJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string HCAHDNLMIHH(AGOOCHPPHOP<TKey> MLINJELIMFI, [NotNull] AHABGEAKFHI IIPHJOIEBJF);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x4655850", Offset = "0x4654A50", VA = "0x184655850")]
	protected LKPCPKEMFDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class AEMJKDBEEMP<TKey> : CHJBMGNOMOC<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public delegate string EKAPLJMBEAF(TKey MBDBONINAPC);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly string MCDAFHLBLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly double FENICIJJMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly bool FKHAFDHNPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly int JCCPCBPPBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly ISet<string> GFBNGBJDLKE;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x4653300", Offset = "0x4652500", VA = "0x184653300")]
	private static string JBPGKFAKEJG(TKey MBDBONINAPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x4653340", Offset = "0x4652540", VA = "0x184653340")]
	public AEMJKDBEEMP(string MCDAFHLBLLI = "F2", double FENICIJJMNE = double.MaxValue, bool FKHAFDHNPBD = false, int JCCPCBPPBEE = int.MaxValue, [Optional] ISet<string> GFBNGBJDLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x4652BF0", Offset = "0x4651DF0", VA = "0x184652BF0", Slot = "4")]
	public override Dictionary<string, string> HCFLKNKOPMC(AGOOCHPPHOP<TKey> MLINJELIMFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x4652890", Offset = "0x4651A90", VA = "0x184652890")]
	private bool BOHKAHPLNPD(string MMJIEOFEBMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4652CD0", Offset = "0x4651ED0", VA = "0x184652CD0")]
	public Dictionary<string, string> HCFLKNKOPMC(AGOOCHPPHOP<TKey> MLINJELIMFI, EKAPLJMBEAF IIPHJOIEBJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x4652970", Offset = "0x4651B70", VA = "0x184652970")]
	private string CNBAJPCJKEE(StringBuilder PECBJJHBFFK, List<TKey> OJNNGNOKFIL, EKAPLJMBEAF IIPHJOIEBJF, bool AMFFLNDBALC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x4652730", Offset = "0x4651930", VA = "0x184652730")]
	private static void BDDIMBJJKEG(StringBuilder CLLALCDBNFN, string JKHAMGNEKEA, bool MCNNDJFMOKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class LCDMPDDJFKJ<TKey> : LKPCPKEMFDN<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct IODKDCPOPDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AHABGEAKFHI keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static LCDMPDDJFKJ<TKey> JLGHKLNHGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly string[] LLCAGMLICLG;

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x4B2ECE0", Offset = "0x4B2DEE0", VA = "0x184B2ECE0")]
	private LCDMPDDJFKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x4B2DD50", Offset = "0x4B2CF50", VA = "0x184B2DD50", Slot = "5")]
	protected override string HCAHDNLMIHH(AGOOCHPPHOP<TKey> MLINJELIMFI, AHABGEAKFHI IIPHJOIEBJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x4B2DC50", Offset = "0x4B2CE50", VA = "0x184B2DC50")]
	[CompilerGenerated]
	internal static string FMJLEGAPAHG(string COHKJMJCLFL, TKey MBDBONINAPC, IODKDCPOPDC P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class MJMACNLKPDH : AGOOCHPPHOP<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class ENPGKLLILMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Action<MJMACNLKPDH, PBBCGFNIILA> callback;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public ENPGKLLILMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x75BF240", Offset = "0x75BE440", VA = "0x1875BF240")]
		internal void NGLGAMHDNLJ(AGOOCHPPHOP<string> timer, PBBCGFNIILA log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x75C1A40", Offset = "0x75C0C40", VA = "0x1875C1A40")]
	public MJMACNLKPDH(PBBCGFNIILA NPAEAIAJLAP, [Optional] string IGAGFKLJBKI, [Optional] int? EOJBAIHJAIC, [Optional] Stopwatch FDFLGBNOOMD, [Optional] Action<string, CIBCCPOLHOG, PBBCGFNIILA> CNEIJBFOJDA, [Optional] Action<string, CIBCCPOLHOG, PBBCGFNIILA> HOCKJHFMIHC, [Optional] Action<MJMACNLKPDH, PBBCGFNIILA> JDPFCKGIHOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x75C1980", Offset = "0x75C0B80", VA = "0x1875C1980")]
	private static Action<AGOOCHPPHOP<string>, PBBCGFNIILA> KOIDPDCLBAF(Action<MJMACNLKPDH, PBBCGFNIILA> GIIPLELNBKP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public abstract class PBHJGACJIPJ
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private class GNFKAEMBCHL : PBHJGACJIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static PBHJGACJIPJ JLGHKLNHGNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x75C05E0", Offset = "0x75BF7E0", VA = "0x1875C05E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override float JLLGOKJHMCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x1050820", Offset = "0x104FA20", VA = "0x181050820", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x75C06D0", Offset = "0x75BF8D0", VA = "0x1875C06D0")]
		public GNFKAEMBCHL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static PBHJGACJIPJ MCIEHEIFJCP;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static PBHJGACJIPJ IDMKIMBBHMK
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x75C2FC0", Offset = "0x75C21C0", VA = "0x1875C2FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public abstract float JLLGOKJHMCD
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	protected PBHJGACJIPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface DIPMDJLELCL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	bool HMMGIGDCPMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface CAFFOJNOKAH<T> : DIPMDJLELCL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	[NotNull]
	Task<T> GANLIOAONNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[NotNull]
	JBBNLHPJHLB<T> LCCFCMKKLEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class HIPDLBKPLJL
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x34B70A0", Offset = "0x34B62A0", VA = "0x1834B70A0")]
	public static CAFFOJNOKAH<TResource> JNHOLCHDFDN<TResource, TId>(this PGEPNDCGIJP<TId, TResource> HLFGGMAKDBH, TId JDNOHHGIHEO, [Optional] Func<TId, CancellationToken, Task<TResource>>? JKLIHDNFNHK) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class DHNAGNIDMML
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private sealed class CHPLLPAICOO<T> : MNGGIKHPNHD<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<T?> GANLIOAONNN
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override JBBNLHPJHLB<T?> LCCFCMKKLEA
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x5BF9DE0", Offset = "0x5BF8FE0", VA = "0x185BF9DE0")]
		public CHPLLPAICOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "10")]
		protected override void EDGCODLIKNA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class MEGGIHBDDPL<T> : MNGGIKHPNHD<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly T KMIPANFPOPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly Action<T>? HHOPCPJCIOF;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Task<T> GANLIOAONNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x964F30", Offset = "0x964130", VA = "0x180964F30", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override JBBNLHPJHLB<T> LCCFCMKKLEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x96A6B0", Offset = "0x9698B0", VA = "0x18096A6B0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x4D9A520", Offset = "0x4D99720", VA = "0x184D9A520")]
		public MEGGIHBDDPL(T DMCBANBGNBP, Action<T>? JMDPHDEMCAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x4D9A2F0", Offset = "0x4D994F0", VA = "0x184D9A2F0", Slot = "10")]
		protected override void EDGCODLIKNA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class OOILLFEHDFL<T> : MNGGIKHPNHD<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override Task<T> GANLIOAONNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override JBBNLHPJHLB<T> LCCFCMKKLEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x501D6A0", Offset = "0x501C8A0", VA = "0x18501D6A0")]
		public OOILLFEHDFL(Exception OLLOHIKPLMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "10")]
		protected override void EDGCODLIKNA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private sealed class GFGJDIFBCFA<T> : MNGGIKHPNHD<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct FLALOGJJMEK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public Task<CAFFOJNOKAH<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<CAFFOJNOKAH<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x453E5A0", Offset = "0x453D7A0", VA = "0x18453E5A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x453EAA0", Offset = "0x453DCA0", VA = "0x18453EAA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct FJLFOIEJOFF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public Task<CAFFOJNOKAH<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private TaskAwaiter<CAFFOJNOKAH<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x44D2BC0", Offset = "0x44D1DC0", VA = "0x1844D2BC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x44D3080", Offset = "0x44D2280", VA = "0x1844D3080", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly Task<CAFFOJNOKAH<T>> HGBKBJGAIDF;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override Task<T> GANLIOAONNN
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override JBBNLHPJHLB<T> LCCFCMKKLEA
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x964CD0", Offset = "0x963ED0", VA = "0x180964CD0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x4600F60", Offset = "0x4600160", VA = "0x184600F60")]
		public GFGJDIFBCFA(Task<CAFFOJNOKAH<T>> JJCLBODJJAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x4600B80", Offset = "0x45FFD80", VA = "0x184600B80", Slot = "10")]
		protected override void EDGCODLIKNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x4600E00", Offset = "0x4600000", VA = "0x184600E00")]
		[AsyncStateMachine(typeof(GFGJDIFBCFA<>.FLALOGJJMEK))]
		[CompilerGenerated]
		internal static Task<T> MNGCABLPABM(Task<CAFFOJNOKAH<T>> JJCLBODJJAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x46009C0", Offset = "0x45FFBC0", VA = "0x1846009C0")]
		[AsyncStateMachine(typeof(GFGJDIFBCFA<>.FJLFOIEJOFF))]
		[CompilerGenerated]
		internal static Task BOCHFOJPAJO(Task<CAFFOJNOKAH<T>> JJCLBODJJAC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private sealed class FBNJFHCPBGC<TIn, TOut> : MNGGIKHPNHD<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private struct KCICJEBHKMJ : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x4A67880", Offset = "0x4A66A80", VA = "0x184A67880", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x4A67EF0", Offset = "0x4A670F0", VA = "0x184A67EF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly CAFFOJNOKAH<TIn> GCEEIFDDLGH;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override Task<TOut> GANLIOAONNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override JBBNLHPJHLB<TOut> LCCFCMKKLEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x964CD0", Offset = "0x963ED0", VA = "0x180964CD0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x44AF080", Offset = "0x44AE280", VA = "0x1844AF080")]
		public FBNJFHCPBGC(CAFFOJNOKAH<TIn> FEPALGILLOE, Func<TIn, TOut> CKGKGNJCDGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x44AECE0", Offset = "0x44ADEE0", VA = "0x1844AECE0", Slot = "10")]
		protected override void EDGCODLIKNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x44AED80", Offset = "0x44ADF80", VA = "0x1844AED80")]
		[AsyncStateMachine(typeof(FBNJFHCPBGC<, >.KCICJEBHKMJ))]
		[CompilerGenerated]
		internal static Task<TOut> PFHHJNDGPLD(Task<TIn> EECAOFEPDNG, Func<TIn, TOut> CKGKGNJCDGK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x32C8F50", Offset = "0x32C8150", VA = "0x1832C8F50")]
	public static CAFFOJNOKAH<T> CENLOHBLGNG<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x32C8FC0", Offset = "0x32C81C0", VA = "0x1832C8FC0")]
	public static CAFFOJNOKAH<T> FMBOOCOHEIH<T>(T CMLOHOMLNDL, [Optional] Action<T>? JMDPHDEMCAN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x32C8ED0", Offset = "0x32C80D0", VA = "0x1832C8ED0")]
	public static CAFFOJNOKAH<T> KBPEDHHIGFI<T>(Exception OLLOHIKPLMG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x32C8ED0", Offset = "0x32C80D0", VA = "0x1832C8ED0")]
	public static CAFFOJNOKAH<T> AIGCIJAEJLF<T>(Task<CAFFOJNOKAH<T>> JJCLBODJJAC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3209070", Offset = "0x3208270", VA = "0x183209070")]
	public static CAFFOJNOKAH<TOut> FFFKHKBLIED<TOut, TIn>(CAFFOJNOKAH<TIn> PBLKLOBKEHJ, Func<TIn, TOut> CKGKGNJCDGK) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class MNGGIKHPNHD<T> : CAFFOJNOKAH<T>, DIPMDJLELCL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly string PLKGNIGJCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly BCBDICAALGE EMFAOLJGKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private bool FEHOKBMGFLG;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool HMMGIGDCPMP
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xB97590", Offset = "0xB96790", VA = "0x180B97590", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public abstract Task<T> GANLIOAONNN
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public abstract JBBNLHPJHLB<T> LCCFCMKKLEA
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x4DB2EC0", Offset = "0x4DB20C0", VA = "0x184DB2EC0")]
	public MNGGIKHPNHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x4DB2C30", Offset = "0x4DB1E30", VA = "0x184DB2C30", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void EDGCODLIKNA();
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class IDBBBBEBFDN<TTask, T> : MNGGIKHPNHD<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class LJAJHNNDKBF
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
			public LJAJHNNDKBF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x3D75270", Offset = "0x3D74470", VA = "0x183D75270", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x3D757C0", Offset = "0x3D749C0", VA = "0x183D757C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public IDBBBBEBFDN<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public LJAJHNNDKBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x4B82190", Offset = "0x4B81390", VA = "0x184B82190")]
		[AsyncStateMachine(typeof(IDBBBBEBFDN<, >.LJAJHNNDKBF.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> NOPDBCBNLPA(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Task<T> JJCLBODJJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	protected readonly CancellationTokenSource IFEDHDENNPG;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public override Task<T> GANLIOAONNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public override JBBNLHPJHLB<T> LCCFCMKKLEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x476C490", Offset = "0x476B690", VA = "0x18476C490")]
	protected IDBBBBEBFDN(TTask JJCLBODJJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x476C440", Offset = "0x476B640", VA = "0x18476C440", Slot = "10")]
	protected override void EDGCODLIKNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T KENMNOPMMMD(TTask NEPFHLFNEFB);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void AHCOAACLOKB();
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class GKCPEOINLGO<T> : MNGGIKHPNHD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly OABDMFMONOH<Task<T>> IHJGLJNNHMM;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override Task<T> GANLIOAONNN
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x461A7B0", Offset = "0x46199B0", VA = "0x18461A7B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override JBBNLHPJHLB<T> LCCFCMKKLEA
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x461A800", Offset = "0x4619A00", VA = "0x18461A800")]
	public GKCPEOINLGO(OABDMFMONOH<Task<T>> BHKJNLAHFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x461A790", Offset = "0x4619990", VA = "0x18461A790", Slot = "10")]
	protected override void EDGCODLIKNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class KKEDPPDBDGD
{
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly HashAlgorithmName GNCIEGMCMLH;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly ThreadLocal<IncrementalHash> CKGCONAKNML;

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x75C16F0", Offset = "0x75C08F0", VA = "0x1875C16F0")]
	public static int OJCKLHJNFHI(this EMPGDIIHNBM IGEKHKFONKL, IncrementalHash HFFPIBBOHEG, byte[] PDCILMLNAHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x75C1380", Offset = "0x75C0580", VA = "0x1875C1380")]
	public static bool MPMPLNELGCC([CanBeNull] this EMPGDIIHNBM IGEKHKFONKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x75C13E0", Offset = "0x75C05E0", VA = "0x1875C13E0")]
	public static bool MPMPLNELGCC([CanBeNull] this EMPGDIIHNBM IGEKHKFONKL, [Out] string HHOJHACJLGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x75C1050", Offset = "0x75C0250", VA = "0x1875C1050")]
	public static bool MPMPLNELGCC([CanBeNull] this EMPGDIIHNBM IGEKHKFONKL, IncrementalHash HFFPIBBOHEG, byte[] PDCILMLNAHL, [Out] string HHOJHACJLGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x75C0FC0", Offset = "0x75C01C0", VA = "0x1875C0FC0")]
	private static bool AGKOICJCABP(byte[] AMCJEBPELJF, Span<byte> FCAPMFFKAAO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class PJBDBNNAKNK
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x75C3120", Offset = "0x75C2320", VA = "0x1875C3120")]
	public static int FICFENCOMID(HashAlgorithmName GCJMKGPJJOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x75C3270", Offset = "0x75C2470", VA = "0x1875C3270")]
	public static int OJCKLHJNFHI(this EFNGFPIAFBC KIMALDHOMAB, byte[] ECIEOHGBIFO, IncrementalHash HFFPIBBOHEG, byte[] ACCPPDAEIKO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface EFNGFPIAFBC
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash HFFPIBBOHEG);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface EMPGDIIHNBM : EFNGFPIAFBC
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	[CanBeNull]
	byte[] LENPAPOHALL
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	[CanBeNull]
	byte[] DIMOBLMDEDI
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class GHPMOOPCKOJ
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static bool DCFLABNPKGD;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly ArrayPool<byte> FPCMKJCJMNP;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly ArrayPool<char> NHDNNLJJOBL;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly Encoding IEKHCKGLJGA;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly ThreadLocal<Encoder> FJBFBMHAAHK;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x3493280", Offset = "0x3492480", VA = "0x183493280")]
	public static void DELOPNMBCOB<T>(this IncrementalHash JMOLMFJAJLP, [CanBeNull] T BNCELPABAGA) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x34931F0", Offset = "0x34923F0", VA = "0x1834931F0")]
	public static void BOKAEOKLJLN<T>(this IncrementalHash JMOLMFJAJLP, [CanBeNull] T KIMALDHOMAB) where T : EFNGFPIAFBC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3493340", Offset = "0x3492540", VA = "0x183493340")]
	public static void GDPIABOPCFD<T>(this IncrementalHash JMOLMFJAJLP, [CanBeNull] IList<T> KMJJBDAAFHO) where T : EFNGFPIAFBC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x75BF970", Offset = "0x75BEB70", VA = "0x1875BF970")]
	private static bool HHNFLGOIOAJ([CanBeNull] EFNGFPIAFBC KIMALDHOMAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x75BFDA0", Offset = "0x75BEFA0", VA = "0x1875BFDA0")]
	public static void PNLNDDNHNMG(this IncrementalHash HFFPIBBOHEG, string? BBCKJHHNEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x75C01A0", Offset = "0x75BF3A0", VA = "0x1875C01A0")]
	public static void PNPPLJIAGEO(this IncrementalHash HFFPIBBOHEG, long LHCFKHLJBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x75BFA00", Offset = "0x75BEC00", VA = "0x1875BFA00")]
	public static void KFLGIDAOOCJ(this IncrementalHash HFFPIBBOHEG, int MPKCBFANOLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x75BF570", Offset = "0x75BE770", VA = "0x1875BF570")]
	public static void DELOKNKAGIA(this IncrementalHash HFFPIBBOHEG, short LEOMCHGEKFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x75BF740", Offset = "0x75BE940", VA = "0x1875BF740")]
	public static void DGJKHGMHIAM(this IncrementalHash HFFPIBBOHEG, byte JLPLLGIKNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x75BFBD0", Offset = "0x75BEDD0", VA = "0x1875BFBD0")]
	public static void NFHNLOEENGL(this IncrementalHash HFFPIBBOHEG, bool ABIMKBGPFAP, bool KFGHEHMHHLI = false, bool HJAJAICAKFE = false, bool KBJEDGLBIPI = false, bool OHKOAECECKO = false, bool LEJEGBENGNM = false, bool PLDCDBCKDKE = false, bool OMBPKNEJFAD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x3493860", Offset = "0x3492A60", VA = "0x183493860")]
	public static void HFKJDLEKINL<T>(this IncrementalHash HFFPIBBOHEG, T PMBHGOELOML) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x75BF910", Offset = "0x75BEB10", VA = "0x1875BF910")]
	public static void HDJGIFPPNJA(this IncrementalHash HFFPIBBOHEG, float JAFMHINNCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x75BF850", Offset = "0x75BEA50", VA = "0x1875BF850")]
	public static void FCIPDCEDAGL(this IncrementalHash HFFPIBBOHEG, ulong HODECFFBHDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x75BFD40", Offset = "0x75BEF40", VA = "0x1875BFD40")]
	public static void PNBBDBBGGPM(this IncrementalHash HFFPIBBOHEG, uint FPGIBJKELLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x75BF8B0", Offset = "0x75BEAB0", VA = "0x1875BF8B0")]
	public static void GPOOGMDEMPN(this IncrementalHash HFFPIBBOHEG, ushort IHJMLLBPAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x75BF440", Offset = "0x75BE640", VA = "0x1875BF440")]
	public static void CFBAMILBLLD(this IncrementalHash HFFPIBBOHEG, Vector3 JFACIAPEJMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class AKNLIMJJMBO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x75BEFB0", Offset = "0x75BE1B0", VA = "0x1875BEFB0")]
	public AKNLIMJJMBO(string DCEACFEGBDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class LMJKCEGBCJB
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public delegate void IAGBFIENMFG(ushort ODAHLLAHEDK, ushort FCEKNBAJCPK, ushort ALFPAFKHCHK, ushort PFFAMLECCOK);

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate void FKPIKKJCAMG(ushort IAKDDBLEPKD, ushort NCCBHEFIOJM);

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate void BKMLBHNBOAN();

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const ushort NDAINLBKKPB = ushort.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	protected LMJKCEGBCJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public abstract class FGEMLDMPOPF<T> : LMJKCEGBCJB where T : FGEMLDMPOPF<T>.BNNACPCEENE
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public interface BNNACPCEENE
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		FKPIKKJCAMG OMFPCGMGPBA
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		FKPIKKJCAMG BGDIEGOBBML
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		BKMLBHNBOAN NHPAFMBCMFG
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Dictionary<uint, T> FJPEDFLEIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private BKMLBHNBOAN KGCHEJNGBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private BKMLBHNBOAN NGDEMBKKDNL;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool AOJCOOENGPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xC04650", Offset = "0xC03850", VA = "0x180C04650")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x964790", Offset = "0x963990", VA = "0x180964790")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public ushort GMFNKPCCCHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x44BFB90", Offset = "0x44BED90", VA = "0x1844BFB90")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x44BFAF0", Offset = "0x44BECF0", VA = "0x1844BFAF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public ushort MIPPLDAKHHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x44BFB00", Offset = "0x44BED00", VA = "0x1844BFB00")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x44BFB10", Offset = "0x44BED10", VA = "0x1844BFB10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public ushort CIJPEDAFCHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xCD6550", Offset = "0xCD5750", VA = "0x180CD6550")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xCD6690", Offset = "0xCD5890", VA = "0x180CD6690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public ushort OOGCDEGIACJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x44BF680", Offset = "0x44BE880", VA = "0x1844BF680")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x44BFB80", Offset = "0x44BED80", VA = "0x1844BFB80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	protected bool GDAGNEIILLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x15D18A0", Offset = "0x15D0AA0", VA = "0x1815D18A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected bool IMCEOCECHKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xD929A0", Offset = "0xD91BA0", VA = "0x180D929A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event IAGBFIENMFG KCEBLDDMJOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x44BF730", Offset = "0x44BE930", VA = "0x1844BF730")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x44BF690", Offset = "0x44BE890", VA = "0x1844BF690")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x44BF7D0", Offset = "0x44BE9D0", VA = "0x1844BF7D0")]
	private T BFCPGAFAPCG(ushort MJBJABDLDFN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x44C0420", Offset = "0x44BF620", VA = "0x1844C0420")]
	private T OANHGAPFOPH(ushort MJBJABDLDFN, ushort GHPCLNMDDEL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x44BFB20", Offset = "0x44BED20", VA = "0x1844BFB20")]
	protected T GGGBGIPFHPK(uint GDHBKBMLJAF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x44C0690", Offset = "0x44BF890", VA = "0x1844C0690")]
	protected FGEMLDMPOPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x44C0540", Offset = "0x44BF740", VA = "0x1844C0540")]
	public void OBCMACPMLAN(ushort JDGLCGFKBBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x44C04E0", Offset = "0x44BF6E0", VA = "0x1844C04E0")]
	public void OBCMACPMLAN(ushort JDGLCGFKBBK, ushort PHDHNHFNOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x44C0580", Offset = "0x44BF780", VA = "0x1844C0580", Slot = "4")]
	protected virtual void OBCMACPMLAN(uint KMFLNLBIHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x44BFC10", Offset = "0x44BEE10", VA = "0x1844BFC10")]
	protected void LDOLKKEDDGK(uint KMFLNLBIHOK, uint DGJIBEENGHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x44BF5E0", Offset = "0x44BE7E0", VA = "0x1844BF5E0")]
	protected void AAOGKMPKKFJ(ushort MJBJABDLDFN, ushort GHPCLNMDDEL, T LEOMHHEDCFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x44BFBB0", Offset = "0x44BEDB0", VA = "0x1844BFBB0")]
	private void KOJEHCCAIAG(uint GDHBKBMLJAF, T LEOMHHEDCFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x44BF880", Offset = "0x44BEA80", VA = "0x1844BF880")]
	protected void BHPPPBMAHEN(float JMHDFCLJGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x44C0410", Offset = "0x44BF610", VA = "0x1844C0410")]
	protected uint NJNIHBCIHHA(ushort MJBJABDLDFN, ushort GHPCLNMDDEL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x44C0680", Offset = "0x44BF880", VA = "0x1844C0680")]
	protected ushort OGCPGJPOOJN(uint GHEOCNJEFDL)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x44BFBA0", Offset = "0x44BEDA0", VA = "0x1844BFBA0")]
	protected ushort JIJHBOPCFCO(uint GHEOCNJEFDL)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public abstract class JNJEJDIHKIF : FGEMLDMPOPF<JNJEJDIHKIF.MIBOMEJNJAE>
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class MIBOMEJNJAE : BNNACPCEENE
	{
		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public FKPIKKJCAMG OMFPCGMGPBA
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x964780", Offset = "0x963980", VA = "0x180964780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public FKPIKKJCAMG BGDIEGOBBML
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x9642A0", Offset = "0x9634A0", VA = "0x1809642A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public BKMLBHNBOAN NHPAFMBCMFG
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x9642B0", Offset = "0x9634B0", VA = "0x1809642B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public MIBOMEJNJAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x75C0EE0", Offset = "0x75C00E0", VA = "0x1875C0EE0")]
	public void KGEGCJNKCJF(ushort FMGBPFMCJOB, FKPIKKJCAMG NCGHGGBADBB, FKPIKKJCAMG MMGMKABBLMO, BKMLBHNBOAN EBKNEBCCDML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x75C0E00", Offset = "0x75C0000", VA = "0x1875C0E00")]
	public void KGEGCJNKCJF(ushort MJBJABDLDFN, ushort GHPCLNMDDEL, FKPIKKJCAMG NCGHGGBADBB, FKPIKKJCAMG MMGMKABBLMO, BKMLBHNBOAN EBKNEBCCDML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x75C0DB0", Offset = "0x75BFFB0", VA = "0x1875C0DB0")]
	public void DJHAIOPCIPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x75C08D0", Offset = "0x75BFAD0", VA = "0x1875C08D0")]
	protected JNJEJDIHKIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class ILKCAEGHIBJ : JNJEJDIHKIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private bool BDELFOAOOCO;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool OBBODMNOFFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xB05420", Offset = "0xB04620", VA = "0x180B05420")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xBF5DE0", Offset = "0xBF4FE0", VA = "0x180BF5DE0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x75C0870", Offset = "0x75BFA70", VA = "0x1875C0870")]
	public void PDAIGIIELDH(ushort FCPEHHPFODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x75C0810", Offset = "0x75BFA10", VA = "0x1875C0810")]
	public void PDAIGIIELDH(ushort FCPEHHPFODL, ushort FIBABGCGJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x75C08D0", Offset = "0x75BFAD0", VA = "0x1875C08D0")]
	public ILKCAEGHIBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public abstract class DEPJPGNJJMD<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	internal class MJNMCAHHKDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public TNode NAELBAPCKEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public TNode JNGEIJHHFEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public OABHLHLKOJD CMDONCAECIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public List<OABHLHLKOJD> GDEDCBFNGOM;

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public MJNMCAHHKDC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal struct OABHLHLKOJD : IComparable<OABHLHLKOJD>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int JHJIKIHJMOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public TClaimant OGGCPPHMIHE;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x148D4D0", Offset = "0x148C6D0", VA = "0x18148D4D0")]
		public OABHLHLKOJD(int JHJIKIHJMOH, TClaimant OGGCPPHMIHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x4F43460", Offset = "0x4F42660", VA = "0x184F43460")]
		public bool HHKOJIJCFBE([In] OABHLHLKOJD LDKNLBHIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x4F43450", Offset = "0x4F42650", VA = "0x184F43450")]
		public bool GIDBPIFHGJH([In] OABHLHLKOJD LDKNLBHIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x4F43440", Offset = "0x4F42640", VA = "0x184F43440", Slot = "4")]
		public int CompareTo(OABHLHLKOJD LDKNLBHIGFL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4F434C0", Offset = "0x4F426C0", VA = "0x184F434C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public enum AEFGMHJBHKI
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class DDKLONDADFJ : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public DEPJPGNJJMD<TClaimant, TNode> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0xD7DCC0", Offset = "0xD7CEC0", VA = "0x180D7DCC0")]
		[DebuggerHidden]
		public DDKLONDADFJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6382C00", Offset = "0x6381E00", VA = "0x186382C00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6382DD0", Offset = "0x6381FD0", VA = "0x186382DD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x6382CE0", Offset = "0x6381EE0", VA = "0x186382CE0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x458E770", Offset = "0x458D970", VA = "0x18458E770", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly JCHFLJBCGMG<MJNMCAHHKDC> JCFGFOLFAGG;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly JCHFLJBCGMG<List<OABHLHLKOJD>> GHLDEENOLDM;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static int NPHJNOHJBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	internal readonly Dictionary<TClaimant, TNode> GMBNBECBCLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	internal readonly Dictionary<TNode, MJNMCAHHKDC> JCBPGDIPHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private AEFGMHJBHKI PCJPKAENIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool JPJEOEDAIGH;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode KDDMJMFFAFG(TNode ILLDGNOPAEF);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void HECMCPGJKGE(TNode ILLDGNOPAEF, TClaimant BPNFOGGDEKN, TClaimant HDEBKODLMNC);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x638BC00", Offset = "0x638AE00", VA = "0x18638BC00")]
	public DEPJPGNJJMD(AEFGMHJBHKI PCJPKAENIHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x638AB70", Offset = "0x6389D70", VA = "0x18638AB70")]
	public void IAONANAJMBO(TNode ILLDGNOPAEF, TNode NAAOBFPOHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x638B850", Offset = "0x638AA50", VA = "0x18638B850")]
	public void NKMOJAHGGBL(TClaimant OGGCPPHMIHE, TNode CJLKOJFFMIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x638A680", Offset = "0x6389880", VA = "0x18638A680", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x638AC30", Offset = "0x6389E30", VA = "0x18638AC30")]
	private void IDNJNPIAGFG(TClaimant OGGCPPHMIHE, TNode ECHJAGEMKNM, TNode CJLKOJFFMIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x638B9D0", Offset = "0x638ABD0", VA = "0x18638B9D0")]
	private int PLEFFMLALKG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x638A230", Offset = "0x6389430", VA = "0x18638A230")]
	private void BIKNGADHOJG(TClaimant OGGCPPHMIHE, TNode NNEBCFOOAKK, TNode GBDMMBHHOEC, int DHBPKDBMPLK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x638B470", Offset = "0x638A670", VA = "0x18638B470")]
	private void KIGCKANMBGH(OABHLHLKOJD PBPPOACGCLI, MJNMCAHHKDC CPHOLCKELIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x638A880", Offset = "0x6389A80", VA = "0x18638A880")]
	private void GBDAEBKIJIN(TClaimant OGGCPPHMIHE, TNode NNEBCFOOAKK, TNode GBDMMBHHOEC, int DHBPKDBMPLK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x638B340", Offset = "0x638A540", VA = "0x18638B340")]
	private void KAKJMNBONLF(OABHLHLKOJD PBPPOACGCLI, TNode ILLDGNOPAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x638B6F0", Offset = "0x638A8F0", VA = "0x18638B6F0")]
	private void MJNDCHANLNL(OABHLHLKOJD PBPPOACGCLI, MJNMCAHHKDC CPHOLCKELIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x638AE80", Offset = "0x638A080", VA = "0x18638AE80")]
	private void INAIJOEJIFF(MJNMCAHHKDC CPHOLCKELIL, bool BIIILHPLIFM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x638AFD0", Offset = "0x638A1D0", VA = "0x18638AFD0")]
	private void IOMMEFKGFKE(MJNMCAHHKDC CPHOLCKELIL, TNode NAAOBFPOHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x638A140", Offset = "0x6389340", VA = "0x18638A140")]
	[IteratorStateMachine(typeof(DEPJPGNJJMD<, >.DDKLONDADFJ))]
	private IEnumerable<TNode> AKOJEGNAGOM(TNode NNEBCFOOAKK, TNode GBDMMBHHOEC, bool LOIFMKHEFGC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x638A570", Offset = "0x6389770", VA = "0x18638A570")]
	private MJNMCAHHKDC CGAHNBFCFJM(TNode ILLDGNOPAEF, TNode JNGEIJHHFEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x638AD00", Offset = "0x6389F00", VA = "0x18638AD00")]
	private MJNMCAHHKDC IIBLIPCKMDG(TNode ILLDGNOPAEF, TNode JNGEIJHHFEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x638B540", Offset = "0x638A740", VA = "0x18638B540")]
	private void LBFOCELIAHE(MJNMCAHHKDC CPHOLCKELIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class DIJIFHIFGBF<T> : IEnumerable<DIJIFHIFGBF<T>.HFAFLPGFGEG>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public struct HFAFLPGFGEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public T OMFJNFBDJCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public int KOOLKCPAFBB;
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class EKBJJFFGKCI : IEnumerator<HFAFLPGFGEG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private DIJIFHIFGBF<T> INMHGMBPIOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int KOOLKCPAFBB;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x4102B00", Offset = "0x4101D00", VA = "0x184102B00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public HFAFLPGFGEG PEOKKFBMNKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x4102BC0", Offset = "0x4101DC0", VA = "0x184102BC0", Slot = "4")]
			get
			{
				return default(HFAFLPGFGEG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x4102B80", Offset = "0x4101D80", VA = "0x184102B80")]
		public EKBJJFFGKCI(DIJIFHIFGBF<T> INMHGMBPIOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x4102A00", Offset = "0x4101C00", VA = "0x184102A00", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x4102A80", Offset = "0x4101C80", VA = "0x184102A80", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xFE6320", Offset = "0xFE5520", VA = "0x180FE6320", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private struct MDAHHHICNJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public bool JPNPJCADOAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public T OMFJNFBDJCA;
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private const int LABHOLDKHBM = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly Dictionary<T, int> NOCNGDEBBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private MDAHHHICNJN[] HEBNOBDFECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int CKHHOOCOBPF;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int MGBDEGLDIAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xC156D0", Offset = "0xC148D0", VA = "0x180C156D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xDB4A90", Offset = "0xDB3C90", VA = "0x180DB4A90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int ABNMPHLJIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3D86B30", Offset = "0x3D85D30", VA = "0x183D86B30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x63DDE00", Offset = "0x63DD000", VA = "0x1863DDE00")]
	public DIJIFHIFGBF(int ECPBKIMJCKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x63DD9E0", Offset = "0x63DCBE0", VA = "0x1863DD9E0")]
	public DIJIFHIFGBF(HFAFLPGFGEG[] DAJHMACHOJE, bool EHDJMNHHDJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x63DD2B0", Offset = "0x63DC4B0", VA = "0x1863DD2B0")]
	public int MINIGCFKINJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x63DD090", Offset = "0x63DC290", VA = "0x1863DD090")]
	private int KHEOJLOBCFM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x63DC7D0", Offset = "0x63DB9D0", VA = "0x1863DC7D0", Slot = "6")]
	protected virtual uint EHNKMBDIIIJ(uint HFFPIBBOHEG, T OMFJNFBDJCA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x63DD4C0", Offset = "0x63DC6C0", VA = "0x1863DD4C0")]
	public bool MOKPABAEOMC(T OMFJNFBDJCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x63DD360", Offset = "0x63DC560", VA = "0x1863DD360")]
	public int MJJLMEFENCF(T OMFJNFBDJCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x63DC710", Offset = "0x63DB910", VA = "0x1863DC710")]
	public T AOLELDFNFOC(int KOOLKCPAFBB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x63DCE10", Offset = "0x63DC010", VA = "0x1863DCE10")]
	public bool HJGDJNCJEIA(T OMFJNFBDJCA, bool MAFJOIOCPGN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x63DC910", Offset = "0x63DBB10", VA = "0x1863DC910")]
	public bool HJGDJNCJEIA(T OMFJNFBDJCA, int KOOLKCPAFBB, bool MAFJOIOCPGN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x63DC820", Offset = "0x63DBA20", VA = "0x1863DC820")]
	private int GMHIHKOFGEG(int JMHJAFCGEDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x63DD520", Offset = "0x63DC720", VA = "0x1863DD520", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x63DD520", Offset = "0x63DC720", VA = "0x1863DD520", Slot = "4")]
	private IEnumerator<HFAFLPGFGEG> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class JCHFLJBCGMG<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly Stack<T> OAOKGDDADJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly List<T> EJCGOFNKEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly int OEJCIOBMBJJ;

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x4959310", Offset = "0x4958510", VA = "0x184959310")]
	public static JCHFLJBCGMG<T> MBHJJJIENDE(int ECPBKIMJCKH = 0, int OEJCIOBMBJJ = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x4959220", Offset = "0x4958420", VA = "0x184959220")]
	public static JCHFLJBCGMG<T> LOPNLINNEEA(int ECPBKIMJCKH = 0, int OEJCIOBMBJJ = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x4959730", Offset = "0x4958930", VA = "0x184959730")]
	public JCHFLJBCGMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x4959780", Offset = "0x4958980", VA = "0x184959780")]
	public JCHFLJBCGMG(int ECPBKIMJCKH, int OEJCIOBMBJJ = int.MaxValue, bool CGBNOCMOEGP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x4959050", Offset = "0x4958250", VA = "0x184959050")]
	public T KFHNOPODNCM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x4958F70", Offset = "0x4958170", VA = "0x184958F70")]
	public void FANKGHIJBAH(T OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x49595F0", Offset = "0x49587F0", VA = "0x1849595F0")]
	private void PCENMNLJHJD(T OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x49596F0", Offset = "0x49588F0", VA = "0x1849596F0")]
	private void PEPOFJEBMNC(T OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x4958DF0", Offset = "0x4957FF0", VA = "0x184958DF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x4959400", Offset = "0x4958600", VA = "0x184959400")]
	private void MDMDMKMFBLJ(IEnumerable<T> ALKPNNHBNLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class MMKPDPJIIEF<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private Dictionary<int, T> AJOKDFPIHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private T IJPABNIGPIP;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public virtual T OOGHNPOLGML
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x9642A0", Offset = "0x9634A0", VA = "0x1809642A0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x4DB1CA0", Offset = "0x4DB0EA0", VA = "0x184DB1CA0")]
	public bool GGOLBHOOOCA(T OMFJNFBDJCA, int JHJIKIHJMOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x4AA1610", Offset = "0x4AA0810", VA = "0x184AA1610")]
	public bool PHNPAMJAFEM(int JHJIKIHJMOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x4DB1AA0", Offset = "0x4DB0CA0", VA = "0x184DB1AA0")]
	public T DIOOGHGAPIJ(int EDAACDPLGGE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x4DB1DA0", Offset = "0x4DB0FA0", VA = "0x184DB1DA0")]
	private bool JHGLDLOBCBA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x4DB1D40", Offset = "0x4DB0F40", VA = "0x184DB1D40")]
	public bool JGIAJCMJDDJ(int JHJIKIHJMOH, [Out] T OMFJNFBDJCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x4DB1EE0", Offset = "0x4DB10E0", VA = "0x184DB1EE0")]
	public MMKPDPJIIEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class MDCHDPDNEIJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	protected struct GAGKKDNPJMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public T CADNOMLIGCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int JPKMCCPDGPB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	protected readonly List<GAGKKDNPJMH> NGFNHFEAIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private T HCFCNDMKIBC;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public int ABNMPHLJIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3D86B30", Offset = "0x3D85D30", VA = "0x183D86B30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x4D93B90", Offset = "0x4D92D90", VA = "0x184D93B90")]
	public bool JMGJGLJLLLB(T OMFJNFBDJCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x4D93E70", Offset = "0x4D93070", VA = "0x184D93E70")]
	public void OFEFHMDJLMD(T OMFJNFBDJCA, int JHJIKIHJMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x4D93FF0", Offset = "0x4D931F0", VA = "0x184D93FF0")]
	public bool OGPGHNCGHLC(T OMFJNFBDJCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x4D93DE0", Offset = "0x4D92FE0", VA = "0x184D93DE0")]
	public void NLADMABHKNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x4D943E0", Offset = "0x4D935E0", VA = "0x184D943E0")]
	public T PNHMPKJHABM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x4D93870", Offset = "0x4D92A70", VA = "0x184D93870")]
	protected void JIJBAIJILDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x4D94480", Offset = "0x4D93680", VA = "0x184D94480")]
	public MDCHDPDNEIJ()
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
		[KPPBIEPJJJL(ADOEJJMOABO.Self, false, false, false)]
		[SerializeField]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x75C3600", Offset = "0x75C2800", VA = "0x1875C3600")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x75C38D0", Offset = "0x75C2AD0", VA = "0x1875C38D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x75C37E0", Offset = "0x75C29E0", VA = "0x1875C37E0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x75C3550", Offset = "0x75C2750", VA = "0x1875C3550")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x75C3820", Offset = "0x75C2A20", VA = "0x1875C3820")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x75C3730", Offset = "0x75C2930", VA = "0x1875C3730")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x75C34D0", Offset = "0x75C26D0", VA = "0x1875C34D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x52EF140", Offset = "0x52EE340", VA = "0x1852EF140", Slot = "4")]
		public virtual T COPPMDIFLFJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class NLALOOIMCCN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private Dictionary<byte, JMIJGJICLMJ> MLFEHOOBBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly JCHFLJBCGMG<JMIJGJICLMJ> ICGMFMIJFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly bool PAGHFEHILFE;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public JMIJGJICLMJ PPANPNAOGMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x964780", Offset = "0x963980", VA = "0x180964780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector2 FPGJKPKLNND
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x1402FA0", Offset = "0x14021A0", VA = "0x181402FA0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xB62B50", Offset = "0xB61D50", VA = "0x180B62B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	private Vector2 FDPGMFCMLDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xBB6150", Offset = "0xBB5350", VA = "0x180BB6150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector2 JNNNCFJAIKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x75C1C00", Offset = "0x75C0E00", VA = "0x1875C1C00")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x964ED0", Offset = "0x9640D0", VA = "0x180964ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int AEGDLGAPDFC
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x96EC20", Offset = "0x96DE20", VA = "0x18096EC20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x96E8A0", Offset = "0x96DAA0", VA = "0x18096E8A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x75C2BA0", Offset = "0x75C1DA0", VA = "0x1875C2BA0")]
	public NLALOOIMCCN(Bounds CJHKKIEPGAM, Vector2[] HBDGAOFLMOM, int IHPIFLAONDG, byte JMHJAFCGEDO, float NPJCEKPPINE = 0f, [Optional] JCHFLJBCGMG<JMIJGJICLMJ> ICGMFMIJFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x75C2710", Offset = "0x75C1910", VA = "0x1875C2710")]
	public void PLOHOJBINMO(Bounds CJHKKIEPGAM, Vector2[] HBDGAOFLMOM, int IHPIFLAONDG, byte JMHJAFCGEDO, float NPJCEKPPINE = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x75C26B0", Offset = "0x75C18B0", VA = "0x1875C26B0")]
	public JMIJGJICLMJ PJHPHEKHFBK(byte KOOLKCPAFBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x75C1D00", Offset = "0x75C0F00", VA = "0x1875C1D00")]
	public void LNFFACNFHNF(Vector3 LBPAIJGCICL, float JIJKCIEDGPM, float NIDGIGKABGO, List<byte> ACMGHADNECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x75C1C20", Offset = "0x75C0E20", VA = "0x1875C1C20")]
	public void DKMNDCDJHFK(JMIJGJICLMJ.HNHEDEKKJKA ONEPHMPBBHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x75C25D0", Offset = "0x75C17D0", VA = "0x1875C25D0")]
	public static int OGFHHIMIBDC(Vector2[] HBDGAOFLMOM, int IHPIFLAONDG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x75C1DD0", Offset = "0x75C0FD0", VA = "0x1875C1DD0")]
	private JMIJGJICLMJ NDDCAKACBMA(byte KOOLKCPAFBB, JMIJGJICLMJ.LEJKFKHFAOP FOENGCKDINJ, JMIJGJICLMJ JNGEIJHHFEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x75C1FF0", Offset = "0x75C11F0", VA = "0x1875C1FF0")]
	private void NPIIFGHMCON(JMIJGJICLMJ JNGEIJHHFEP, Vector2[] HBDGAOFLMOM, int HJAADBMOBHF, int MNGFDJDGAIN, int LPCJBIMOELF, int NNMIBAKGNOH, float NPJCEKPPINE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x75C23B0", Offset = "0x75C15B0", VA = "0x1875C23B0")]
	private void OAHADOAFCON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x75C1C40", Offset = "0x75C0E40", VA = "0x1875C1C40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x75C1CA0", Offset = "0x75C0EA0", VA = "0x1875C1CA0", Slot = "1")]
	~NLALOOIMCCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class JMIJGJICLMJ
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public enum LEJKFKHFAOP
	{
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public enum HNHEDEKKJKA
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
	public byte HOJBPJFAOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public Vector3 EJPEHBNOFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public Vector3 HNAECDILAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public Vector3 OBLKNIDDJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public Vector3 LOKIPBCGIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public LEJKFKHFAOP CMDFEIFCLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public JMIJGJICLMJ JCHDMDCGBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public List<JMIJGJICLMJ> PPDOIGEAKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public bool KHPCECDOOGN;

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x75C0D90", Offset = "0x75BFF90", VA = "0x1875C0D90")]
	public JMIJGJICLMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x75C0940", Offset = "0x75BFB40", VA = "0x1875C0940")]
	public void DLFMCGODDHH(JMIJGJICLMJ OAOLODPFDMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00")]
	public void DKMNDCDJHFK(int BEFFNCNPJDN, HNHEDEKKJKA ONEPHMPBBHL, int HELKJOLNKEN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x75C0AA0", Offset = "0x75BFCA0", VA = "0x1875C0AA0")]
	public void LNFFACNFHNF(List<byte> ACMGHADNECO, Vector3 LBPAIJGCICL, float JIJKCIEDGPM, float NIDGIGKABGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x75C0910", Offset = "0x75BFB10", VA = "0x1875C0910")]
	public bool DGDKMBKBEGI(Vector3 MLHHPBDBAOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x75C0A70", Offset = "0x75BFC70", VA = "0x1875C0A70")]
	public bool LDFGIILDCCK(Vector3 MLHHPBDBAOC, float ONFFICAPNKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x75C0D00", Offset = "0x75BFF00", VA = "0x1875C0D00")]
	public void PDAIGIIELDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public interface HGDBLBFBLNJ
{
	[Cpp2IlInjected.Token(Token = "0x17000075")]
	ToolHierarchyCache EGBJBEJIDPB
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
		public struct IPJFGLAJBMI<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			private readonly List<Component> KBPAKCCMOCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			private readonly bool OEKBCFJNHFD;

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x15EF900", Offset = "0x15EEB00", VA = "0x1815EF900")]
			public IPJFGLAJBMI(List<Component> KBPAKCCMOCP, bool OEKBCFJNHFD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x478BF00", Offset = "0x478B100", VA = "0x18478BF00")]
			public KAILFFHNAJH<T> PACLDABBHPO()
			{
				return default(KAILFFHNAJH<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x478BF60", Offset = "0x478B160", VA = "0x18478BF60", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x478BF60", Offset = "0x478B160", VA = "0x18478BF60", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public struct KAILFFHNAJH<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			private readonly List<Component> KBPAKCCMOCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			private readonly bool OEKBCFJNHFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			private int KOOLKCPAFBB;

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public T PEOKKFBMNKJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000261")]
				[Cpp2IlInjected.Address(RVA = "0x4A51A80", Offset = "0x4A50C80", VA = "0x184A51A80", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000262")]
				[Cpp2IlInjected.Address(RVA = "0x4A51A10", Offset = "0x4A50C10", VA = "0x184A51A10", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x4A51A50", Offset = "0x4A50C50", VA = "0x184A51A50")]
			public KAILFFHNAJH(List<Component> KBPAKCCMOCP, bool OEKBCFJNHFD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x4A51950", Offset = "0x4A50B50", VA = "0x184A51950", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x4A51960", Offset = "0x4A50B60", VA = "0x184A51960", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x417AA40", Offset = "0x4179C40", VA = "0x18417AA40", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x75C5290", Offset = "0x75C4490", VA = "0x1875C5290")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x75C5000", Offset = "0x75C4200", VA = "0x1875C5000")]
		private void PDAIGIIELDH(GameObject NJBBCBKLFLI, bool CPGNGBBHKKK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x75C5170", Offset = "0x75C4370", VA = "0x1875C5170")]
		public static void PDAIGIIELDH(GameObject NJBBCBKLFLI, ToolHierarchyCache HLFGGMAKDBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x75C4CA0", Offset = "0x75C3EA0", VA = "0x1875C4CA0")]
		public void HPKMOJCOHPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x37F0C80", Offset = "0x37EFE80", VA = "0x1837F0C80")]
		public void BIBIKKKHJLI<T>(Action<T> GJDAMJHNAPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x37F0EB0", Offset = "0x37F00B0", VA = "0x1837F0EB0")]
		public T ENNDPCDODEG<T>(bool OEKBCFJNHFD = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x37F0F50", Offset = "0x37F0150", VA = "0x1837F0F50")]
		public IPJFGLAJBMI<T> GDPOPLCLCLI<T>(bool OEKBCFJNHFD = false) where T : class
		{
			return default(IPJFGLAJBMI<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x75C4CB0", Offset = "0x75C3EB0", VA = "0x1875C4CB0")]
		public List<Component> MBLLMOPJNCM(Type NNILCBOLNDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x75C4BB0", Offset = "0x75C3DB0", VA = "0x1875C4BB0", Slot = "4")]
		public bool Equals(ToolHierarchyCache NNDJDIFFAID, ToolHierarchyCache AMFIBFNKFFJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x75C4C30", Offset = "0x75C3E30", VA = "0x1875C4C30", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache ONELFPFEALD)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class KCHMBKKPPKE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int ECPBKIMJCKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int EKDFGBODAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private List<T> FKONFNGBCPP;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public int ABNMPHLJIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x461A7B0", Offset = "0x46199B0", VA = "0x18461A7B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public T GOKBCIEPFDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x4A670D0", Offset = "0x4A662D0", VA = "0x184A670D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public T GEIFMBLKNKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x4A671D0", Offset = "0x4A663D0", VA = "0x184A671D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public T KMMKKONBFCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x4A673A0", Offset = "0x4A665A0", VA = "0x184A673A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x4A677D0", Offset = "0x4A669D0", VA = "0x184A677D0")]
	public KCHMBKKPPKE(int ECPBKIMJCKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x4A67580", Offset = "0x4A66780", VA = "0x184A67580")]
	public void OFEFHMDJLMD(T ALGKPOBCDFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x4A672D0", Offset = "0x4A664D0", VA = "0x184A672D0")]
	public void NLADMABHKNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x4A676E0", Offset = "0x4A668E0", VA = "0x184A676E0")]
	public void PLENAJOOHKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x4A66F10", Offset = "0x4A66110", VA = "0x184A66F10")]
	public void EANIIBMPOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x4A671C0", Offset = "0x4A663C0", VA = "0x184A671C0")]
	public void IEOCBCIKGBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x4A66F80", Offset = "0x4A66180", VA = "0x184A66F80")]
	public List<T> EFCPECODBJH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class GODAFHEHLEH<T>
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private struct LLPONOMCIDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public int JPKMCCPDGPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public T CADNOMLIGCM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly Dictionary<object, LLPONOMCIDK> AJOKDFPIHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly EqualityComparer<T> CHLMLBNOGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private T IJPABNIGPIP;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public virtual T OOGHNPOLGML
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xC1E1C0", Offset = "0xC1D3C0", VA = "0x180C1E1C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x4639190", Offset = "0x4638390", VA = "0x184639190", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool CHIHKFCFCHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x46391D0", Offset = "0x46383D0", VA = "0x1846391D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public object FEJIKNDJAPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x964EC0", Offset = "0x9640C0", VA = "0x180964EC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x968CE0", Offset = "0x967EE0", VA = "0x180968CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x4639460", Offset = "0x4638660", VA = "0x184639460")]
	public bool GGOLBHOOOCA(T OMFJNFBDJCA, object GIIKHLJPAKH, int JHJIKIHJMOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x463A3E0", Offset = "0x46395E0", VA = "0x18463A3E0")]
	public bool PHNPAMJAFEM(object GIIKHLJPAKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x4639670", Offset = "0x4638870", VA = "0x184639670")]
	public bool JGIAJCMJDDJ(object GIIKHLJPAKH, [Out] T OMFJNFBDJCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x463A390", Offset = "0x4639590", VA = "0x18463A390")]
	public void NLADMABHKNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x4639A70", Offset = "0x4638C70", VA = "0x184639A70")]
	private bool JHGLDLOBCBA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x463A490", Offset = "0x4639690", VA = "0x18463A490")]
	public GODAFHEHLEH()
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
