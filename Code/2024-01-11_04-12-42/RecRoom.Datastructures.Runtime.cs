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
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class JBLOPBKLMGI : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x79F100", Offset = "0x79DB00", VA = "0x18079F100")]
	public JBLOPBKLMGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, KAGGPMOKOIP, JCILFAGDNPA, ISerializationCallbackReceiver
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[SerializeField]
	private byte[] stableHash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	private byte[] seed;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public byte[] StableHash
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x790C90", Offset = "0x78F690", VA = "0x180790C90", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x793B40", Offset = "0x792540", VA = "0x180793B40", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x790CA0", Offset = "0x78F6A0", VA = "0x180790CA0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8723D0", Offset = "0x870DD0", VA = "0x1808723D0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash JCKOPCANIKJ);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x81C660", Offset = "0x81B060", VA = "0x18081C660")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[SerializeField]
	[OPNGFCBBDGN]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[OPNGFCBBDGN]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5FA64C0", Offset = "0x5FA4EC0", VA = "0x185FA64C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5FA6480", Offset = "0x5FA4E80", VA = "0x185FA6480")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5FA6500", Offset = "0x5FA4F00", VA = "0x185FA6500")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5FA66B0", Offset = "0x5FA50B0", VA = "0x185FA66B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5FA6620", Offset = "0x5FA5020", VA = "0x185FA6620")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x89F540", Offset = "0x89DF40", VA = "0x18089F540")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x969BE0", Offset = "0x9685E0", VA = "0x180969BE0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5FA6440", Offset = "0x5FA4E40", VA = "0x185FA6440")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5FA6590", Offset = "0x5FA4F90", VA = "0x185FA6590")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5FA5EB0", Offset = "0x5FA48B0", VA = "0x185FA5EB0")]
	public void CopyBounds(SavedExtents CGDFJMJIABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5FA6390", Offset = "0x5FA4D90", VA = "0x185FA6390")]
	public void SetLocalSpaceBounds(Bounds CMNEEGHKJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x984E40", Offset = "0x983840", VA = "0x180984E40")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5FA6380", Offset = "0x5FA4D80", VA = "0x185FA6380")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5FA5EE0", Offset = "0x5FA48E0", VA = "0x185FA5EE0")]
	private void HKNFNLMOFFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5FA6160", Offset = "0x5FA4B60", VA = "0x185FA6160")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5FA5840", Offset = "0x5FA4240", VA = "0x185FA5840")]
	public static void CalculateLocalBoundsFor(GameObject PKKHAEKNIBL, [Out] Bounds CMNEEGHKJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5FA60A0", Offset = "0x5FA4AA0", VA = "0x185FA60A0")]
	private static void KDCKAGCJCCA(Bounds OIKFNBPLIOK, Color BDAHFBGOEJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5FA63B0", Offset = "0x5FA4DB0", VA = "0x185FA63B0")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x78E180", Offset = "0x78CB80", VA = "0x18078E180")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7965B0", Offset = "0x794FB0", VA = "0x1807965B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xDAA210", Offset = "0xDA8C10", VA = "0x180DAA210")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4278EE0", Offset = "0x42778E0", VA = "0x184278EE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "4")]
	public virtual void MPNJBGKMILH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[JBLOPBKLMGI]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4278AC0", Offset = "0x42774C0", VA = "0x184278AC0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4277760", Offset = "0x4276160", VA = "0x184277760", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4278E10", Offset = "0x4277810", VA = "0x184278E10")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class DBOOLMJACNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public DBOOLMJACNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4F59E70", Offset = "0x4F58870", VA = "0x184F59E70")]
		internal int CJNNANILIJO(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[JBLOPBKLMGI]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3271220", Offset = "0x326FC20", VA = "0x183271220", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3271270", Offset = "0x326FC70", VA = "0x183271270", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3271120", Offset = "0x326FB20", VA = "0x183271120", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey FHLJKJHFEEK]
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x32711C0", Offset = "0x326FBC0", VA = "0x1832711C0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3271000", Offset = "0x326FA00", VA = "0x183271000", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3270C90", Offset = "0x326F690", VA = "0x183270C90", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3270130", Offset = "0x326EB30", VA = "0x183270130", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3270E30", Offset = "0x326F830", VA = "0x183270E30", Slot = "14")]
	protected virtual string PABJHGIBDGE(TKeyVal JGJHGNJNKMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3270040", Offset = "0x326EA40", VA = "0x183270040", Slot = "4")]
	public bool ContainsKey(TKey FHLJKJHFEEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3270EC0", Offset = "0x326F8C0", VA = "0x183270EC0", Slot = "5")]
	public bool TryGetValue(TKey FHLJKJHFEEK, [Out] TVal BEEGCHJLJFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3270090", Offset = "0x326EA90", VA = "0x183270090", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3270090", Offset = "0x326EA90", VA = "0x183270090", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3270F10", Offset = "0x326F910", VA = "0x183270F10")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class NOAAFCAJPFF<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class BCBPEENBKDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public BCBPEENBKDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x46DE6E0", Offset = "0x46DD0E0", VA = "0x1846DE6E0")]
		internal bool KFALKAMKGIP(NOOLFONLJNE<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float CNANJCKMLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float PLEEPBEEGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<NOOLFONLJNE<float, T>> FMECGIGPJDA;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int LHNOODKDPPL
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3EB52B0", Offset = "0x3EB3CB0", VA = "0x183EB52B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3EB54B0", Offset = "0x3EB3EB0", VA = "0x183EB54B0")]
	public NOAAFCAJPFF(float LNHPBJKNAJL, float PODDFIMMLPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3EB5320", Offset = "0x3EB3D20", VA = "0x183EB5320")]
	public bool NPICPEPGDEP(float AFJGHIJFDOD, T BEEGCHJLJFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3EB4FA0", Offset = "0x3EB39A0", VA = "0x183EB4FA0")]
	public IEnumerable<T> KFFJNANFFHB(float AFJGHIJFDOD, [Optional] float? LDAIJNDPDOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3EB4E90", Offset = "0x3EB3890", VA = "0x183EB4E90")]
	public void JOBLGFAFDNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3EB4EC0", Offset = "0x3EB38C0", VA = "0x183EB4EC0")]
	private void KDBKOHCKFGO(float AFJGHIJFDOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class GHGOEIILAOL<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct BIBDADDHFBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T BMLGNHJJEIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float FDMJPJGHNIL;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float OAMEHHMNEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> AMKKGDPKOLM;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int POGICHLNJNA = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private BIBDADDHFBB[] BHNHFMPCKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int CCJEPGHAEDG;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float MFLJICDEGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xB4EC20", Offset = "0xB4D620", VA = "0x180B4EC20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xB4EC30", Offset = "0xB4D630", VA = "0x180B4EC30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x36AC690", Offset = "0x36AB090", VA = "0x1836AC690")]
	public GHGOEIILAOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x36AC5A0", Offset = "0x36AAFA0", VA = "0x1836AC5A0")]
	public GHGOEIILAOL(int DDIMFHFNGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x36ABEE0", Offset = "0x36AA8E0", VA = "0x1836ABEE0")]
	public void DGLLAPEBOKO(float AFJGHIJFDOD, T BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x36AC420", Offset = "0x36AAE20", VA = "0x1836AC420")]
	public void JOBLGFAFDNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x36ABBD0", Offset = "0x36AA5D0", VA = "0x1836ABBD0")]
	public bool BCDNLKBGJIG(float BKCFGHIDDBA, float CCNPANOEFBN, [Out] T BEEGCHJLJFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x36AC190", Offset = "0x36AAB90", VA = "0x1836AC190")]
	public bool DLELGDMLKCL(float BKCFGHIDDBA, float CCNPANOEFBN, [Out] T BEEGCHJLJFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x36AB810", Offset = "0x36AA210", VA = "0x1836AB810")]
	public void APEAPIAFNAB(float BKCFGHIDDBA, float CCNPANOEFBN, List<T> LMJJBGCJLAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x36AC510", Offset = "0x36AAF10", VA = "0x1836AC510")]
	private int LKNNFMLHBPD(int CAPGHBNNLCH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x36ABDD0", Offset = "0x36AA7D0", VA = "0x1836ABDD0")]
	private void BPDICGCCEDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T NIKLAAFOCKB();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T NJJFPNKONPI(T BEEGCHJLJFC, float FIGFLJOONIE);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T DEEELEOMBKD(T KKLPBLEHAEB, T MFJBAALKDKH);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T LHAJMIGOFKH(T KKLPBLEHAEB, T MFJBAALKDKH);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class MPKCBKKDDAB : GHGOEIILAOL<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x79F990", Offset = "0x79E390", VA = "0x18079F990", Slot = "4")]
	protected override Vector3 NIKLAAFOCKB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5FA3E10", Offset = "0x5FA2810", VA = "0x185FA3E10", Slot = "5")]
	protected override Vector3 NJJFPNKONPI(Vector3 BEEGCHJLJFC, float FIGFLJOONIE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5FA3D40", Offset = "0x5FA2740", VA = "0x185FA3D40", Slot = "6")]
	protected override Vector3 DEEELEOMBKD(Vector3 KKLPBLEHAEB, Vector3 MFJBAALKDKH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5FA3D90", Offset = "0x5FA2790", VA = "0x185FA3D90", Slot = "7")]
	protected override Vector3 LHAJMIGOFKH(Vector3 KKLPBLEHAEB, Vector3 MFJBAALKDKH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5FA3E50", Offset = "0x5FA2850", VA = "0x185FA3E50")]
	public MPKCBKKDDAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class CNHFKDGMEBC
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x244FD10", Offset = "0x244E710", VA = "0x18244FD10")]
	public static NOOLFONLJNE<T1, T2> CMMJGECCMDN<T1, T2>(T1 OEIAHLJHDGK, T2 KAHMNGICGND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x244FD90", Offset = "0x244E790", VA = "0x18244FD90")]
	public static PPEBJANGDMC<T1, T2, T3> CMMJGECCMDN<T1, T2, T3>(T1 OEIAHLJHDGK, T2 KAHMNGICGND, T3 DFNKKIEPKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3E26590", Offset = "0x3E24F90", VA = "0x183E26590")]
	internal static int EIKCGILJADD(int HIKJAAOJGNF, int ACAOBPIFNHJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x540D0C0", Offset = "0x540BAC0", VA = "0x18540D0C0")]
	internal static int EIKCGILJADD(int HIKJAAOJGNF, int ACAOBPIFNHJ, int KILLAGLAKKM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NOOLFONLJNE<T1, T2> : IComparable<NOOLFONLJNE<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T1 NICGJKMHEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T2 JFGCHDHKIII;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3EBA930", Offset = "0x3EB9330", VA = "0x183EBA930")]
	public NOOLFONLJNE(T1 OEIAHLJHDGK, T2 KAHMNGICGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3EB88E0", Offset = "0x3EB72E0", VA = "0x183EB88E0", Slot = "4")]
	public int CompareTo(NOOLFONLJNE<T1, T2> CGDFJMJIABO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3EB9140", Offset = "0x3EB7B40", VA = "0x183EB9140", Slot = "0")]
	public override bool Equals(object CGDFJMJIABO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3EB9B80", Offset = "0x3EB8580", VA = "0x183EB9B80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3EB9D20", Offset = "0x3EB8720", VA = "0x183EB9D20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class PPEBJANGDMC<T1, T2, T3> : IComparable<PPEBJANGDMC<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T1 NICGJKMHEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T2 JFGCHDHKIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly T3 KPLOEPPBLAJ;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x40A99A0", Offset = "0x40A83A0", VA = "0x1840A99A0")]
	public PPEBJANGDMC(T1 OEIAHLJHDGK, T2 KAHMNGICGND, T3 DFNKKIEPKLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x40A9060", Offset = "0x40A7A60", VA = "0x1840A9060", Slot = "4")]
	public int CompareTo(PPEBJANGDMC<T1, T2, T3> CGDFJMJIABO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x40A92E0", Offset = "0x40A7CE0", VA = "0x1840A92E0", Slot = "0")]
	public override bool Equals(object CGDFJMJIABO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x40A95A0", Offset = "0x40A7FA0", VA = "0x1840A95A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x40A97E0", Offset = "0x40A81E0", VA = "0x1840A97E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T BMLGNHJJEIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2018180", Offset = "0x2016B80", VA = "0x182018180")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2018130", Offset = "0x2016B30", VA = "0x182018130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float HPKGOIJCMBP
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x81C740", Offset = "0x81B140", VA = "0x18081C740")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x448E990", Offset = "0x448D390", VA = "0x18448E990")]
	public T HMPKIECCEAP(float FIGFLJOONIE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x448EDD0", Offset = "0x448D7D0", VA = "0x18448EDD0")]
	public T JJONNDCCHIA(float FIGFLJOONIE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T HMOMCECEPDJ(T KKLPBLEHAEB, T MFJBAALKDKH, float FIGFLJOONIE);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5FA2620", Offset = "0x5FA1020", VA = "0x185FA2620", Slot = "4")]
	protected override float HMOMCECEPDJ(float KKLPBLEHAEB, float MFJBAALKDKH, float FIGFLJOONIE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5FA2660", Offset = "0x5FA1060", VA = "0x185FA2660")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xC6ADF0", Offset = "0xC697F0", VA = "0x180C6ADF0", Slot = "4")]
	protected override Vector3 HMOMCECEPDJ(Vector3 KKLPBLEHAEB, Vector3 MFJBAALKDKH, float FIGFLJOONIE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5FA73C0", Offset = "0x5FA5DC0", VA = "0x185FA73C0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5FA1FC0", Offset = "0x5FA09C0", VA = "0x185FA1FC0", Slot = "4")]
	protected override Color HMOMCECEPDJ(Color KKLPBLEHAEB, Color MFJBAALKDKH, float FIGFLJOONIE)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5FA2080", Offset = "0x5FA0A80", VA = "0x185FA2080")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class JACGEENDEJM : LOKFCJOGCJL<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5FA36F0", Offset = "0x5FA20F0", VA = "0x185FA36F0")]
	public JACGEENDEJM(int HCAPAJGPPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5FA3680", Offset = "0x5FA2080", VA = "0x185FA3680", Slot = "6")]
	protected override uint PKGHCIDILBP(uint JCKOPCANIKJ, string BEEGCHJLJFC)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class GFFEPBFBGPD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly IDisposable KHPIFBDMEAA;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public GFFEPBFBGPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct HAMLFPHGHME<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> FLNKGFDHCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int EDADJIKJBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int KENPMEMCCND;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1D10F70", Offset = "0x1D0F970", VA = "0x181D10F70")]
	private HAMLFPHGHME(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> HFAPELHLEEM, int ADJKNDGDMPO, int NEEHAJCGMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x36E7060", Offset = "0x36E5A60", VA = "0x1836E7060")]
	public static HAMLFPHGHME<T> KBFODEGLBLG()
	{
		return default(HAMLFPHGHME<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x36E56E0", Offset = "0x36E40E0", VA = "0x1836E56E0")]
	public (int, int, Task<T>) EKGCOENELMH(int AJIMMEDNKKA, [Optional] CancellationToken EAPNOLMLMHM, double GPIPKOHJNJJ = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x36E6E70", Offset = "0x36E5870", VA = "0x1836E6E70")]
	public void FKBJCBFFLPK(int AJIMMEDNKKA, int NEEHAJCGMBG, [In] T JHJJOGFODKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class AFIBBPPEHAP
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5FA1F70", Offset = "0x5FA0970", VA = "0x185FA1F70")]
	public static HAMLFPHGHME<NBACEGLOLCA> KBFODEGLBLG()
	{
		return default(HAMLFPHGHME<NBACEGLOLCA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5FA1EF0", Offset = "0x5FA08F0", VA = "0x185FA1EF0")]
	public static void FKBJCBFFLPK([In] this HAMLFPHGHME<NBACEGLOLCA> JFFAAHPEFOB, int AJIMMEDNKKA, int NEEHAJCGMBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[DefaultMember("Item")]
public class COEDLFJDMNE<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TKey, TVal> ALPOCNDAOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly Dictionary<TVal, TKey> INHCEEFFGJC;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int MDLNLAAIONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x305E200", Offset = "0x305CC00", VA = "0x18305E200", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool KNBLDDIDMLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ICollection<TKey> MFKCEJAEENG
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4046540", Offset = "0x4044F40", VA = "0x184046540", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> FLAFNEAGBDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x4D8C210", Offset = "0x4D8AC10", VA = "0x184D8C210", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal OBNEKGFINAA
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x4D8C1B0", Offset = "0x4D8ABB0", VA = "0x184D8C1B0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x4D8C270", Offset = "0x4D8AC70", VA = "0x184D8C270", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey OBNEKGFINAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4D8BA10", Offset = "0x4D8A410", VA = "0x184D8BA10")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4D8B860", Offset = "0x4D8A260", VA = "0x184D8B860", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4D8BF90", Offset = "0x4D8A990", VA = "0x184D8BF90", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4D8B640", Offset = "0x4D8A040", VA = "0x184D8B640", Slot = "9")]
	public void Add(TKey FHLJKJHFEEK, TVal BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4D8B670", Offset = "0x4D8A070", VA = "0x184D8B670", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> PPIDKPHGGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4D8B8C0", Offset = "0x4D8A2C0", VA = "0x184D8B8C0", Slot = "8")]
	public bool ContainsKey(TKey FHLJKJHFEEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4D8B930", Offset = "0x4D8A330", VA = "0x184D8B930", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> PPIDKPHGGGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4D8BF00", Offset = "0x4D8A900", VA = "0x184D8BF00", Slot = "10")]
	public bool Remove(TKey FHLJKJHFEEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4D8BF60", Offset = "0x4D8A960", VA = "0x184D8BF60", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> PPIDKPHGGGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4D8C080", Offset = "0x4D8AA80", VA = "0x184D8C080", Slot = "11")]
	public bool TryGetValue(TKey FHLJKJHFEEK, [Out] TVal BEEGCHJLJFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4D8BBE0", Offset = "0x4D8A5E0", VA = "0x184D8BBE0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4D8B990", Offset = "0x4D8A390", VA = "0x184D8B990", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] BHNHFMPCKPL, int DOMAOCHEEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4D8BB00", Offset = "0x4D8A500", VA = "0x184D8BB00")]
	public bool GFGJHMKHGPD(TVal FHLJKJHFEEK, [Out] TKey BEEGCHJLJFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4D8B730", Offset = "0x4D8A130", VA = "0x184D8B730")]
	private void BCIECOJMFIH(TKey FHLJKJHFEEK, TVal FJNMPOJLNAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4D8B540", Offset = "0x4D89F40", VA = "0x184D8B540")]
	private void AMPNCIEAPEL(TKey FHLJKJHFEEK, TVal FJNMPOJLNAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4D8BE20", Offset = "0x4D8A820", VA = "0x184D8BE20")]
	private bool OBDEGALKEFO(TKey FHLJKJHFEEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4D8C0C0", Offset = "0x4D8AAC0", VA = "0x184D8C0C0")]
	public COEDLFJDMNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DefaultMember("Item")]
public class ANGLDIIDNDI<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private ANGLDIIDNDI<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x32B90F0", Offset = "0x32B7AF0", VA = "0x1832B90F0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x32C4F40", Offset = "0x32C3940", VA = "0x1832C4F40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x32C5BE0", Offset = "0x32C45E0", VA = "0x1832C5BE0")]
		public Enumerator(ANGLDIIDNDI<T> LMJJBGCJLAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x32C3360", Offset = "0x32C1D60", VA = "0x1832C3360", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x32C40C0", Offset = "0x32C2AC0", VA = "0x1832C40C0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x32C2980", Offset = "0x32C1380", VA = "0x1832C2980")]
		private void ICDMPPPGMPJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private T[] CKKKCBCEIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int MGKCHJOOGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int EMNKNOHDDNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int BKOLDLDNEOO;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int MDLNLAAIONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x38A3990", Offset = "0x38A2390", VA = "0x1838A3990")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T OBNEKGFINAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x38A3300", Offset = "0x38A1D00", VA = "0x1838A3300")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x38A3AA0", Offset = "0x38A24A0", VA = "0x1838A3AA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x38A4AE0", Offset = "0x38A34E0", VA = "0x1838A4AE0")]
	public ANGLDIIDNDI(int HCAPAJGPPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x38A36D0", Offset = "0x38A20D0", VA = "0x1838A36D0")]
	public void DGLLAPEBOKO(T FIGFLJOONIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x38A3970", Offset = "0x38A2370", VA = "0x1838A3970")]
	public void JOBLGFAFDNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x38A38C0", Offset = "0x38A22C0", VA = "0x1838A38C0")]
	public void FCBBPIGPBIA(int MPNHPMPEEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x38A3F00", Offset = "0x38A2900", VA = "0x1838A3F00")]
	public void NINGLLKJKGL(T[] BHNHFMPCKPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x38A3880", Offset = "0x38A2280", VA = "0x1838A3880")]
	public Enumerator DHCNIOBIIDB()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x38A49A0", Offset = "0x38A33A0", VA = "0x1838A49A0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x38A49A0", Offset = "0x38A33A0", VA = "0x1838A49A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x38A4680", Offset = "0x38A3080", VA = "0x1838A4680")]
	private int PALEDLGCHLD(int BNALCEABILL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x38A3150", Offset = "0x38A1B50", VA = "0x1838A3150")]
	private int BDKPMFHAHMJ(int BNALCEABILL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class AIGFFIPJFPC<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Func<Internal, External> ANLBKIADEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private IReadOnlyList<Internal> BPDJICGMKNG;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public External OBNEKGFINAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x3679770", Offset = "0x3678170", VA = "0x183679770", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int MDLNLAAIONI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3679720", Offset = "0x3678120", VA = "0x183679720", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7904D0", Offset = "0x78EED0", VA = "0x1807904D0")]
	public AIGFFIPJFPC(Func<Internal, External> ANLBKIADEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x36796D0", Offset = "0x36780D0", VA = "0x1836796D0")]
	public AIGFFIPJFPC(IReadOnlyList<Internal> BPDJICGMKNG, Func<Internal, External> ANLBKIADEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3679650", Offset = "0x3678050", VA = "0x183679650", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x34A8890", Offset = "0x34A7290", VA = "0x1834A8890", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class NFOGKJFLOMC<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate Task<TResult> OBBIHCMKOPP(TRequest GOAJPHFIKLF, CancellationToken EAPNOLMLMHM);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public enum BAGBKEBBPGB
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class KDFGFDCOIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private const float INNMCIMAEME = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TimeSpan NGILKLFGABI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int KKEGDLIEHFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public BAGBKEBBPGB ELNGEJJOPOJ;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public static readonly KDFGFDCOIFJ MBNAEHMDPIA;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float FIECAKBPHNG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x3ACD480", Offset = "0x3ACBE80", VA = "0x183ACD480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan LBCFPHOMOJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x3ACD6B0", Offset = "0x3ACC0B0", VA = "0x183ACD6B0")]
		public KDFGFDCOIFJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private readonly struct KJHIBJMHHPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public readonly TRequest GOAJPHFIKLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public readonly CancellationToken EAPNOLMLMHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly TaskCompletionSource<TResult> FFEDDICINOC;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3AE8220", Offset = "0x3AE6C20", VA = "0x183AE8220")]
		public KJHIBJMHHPL(TRequest GOAJPHFIKLF, TaskCompletionSource<TResult> FFEDDICINOC, CancellationToken EAPNOLMLMHM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct EGFIKKOGFPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public NFOGKJFLOMC<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x3245FE0", Offset = "0x32449E0", VA = "0x183245FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x32463C0", Offset = "0x3244DC0", VA = "0x1832463C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct IIMPOPIAOLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public NFOGKJFLOMC<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private KJHIBJMHHPL <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x3843DB0", Offset = "0x38427B0", VA = "0x183843DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3844A30", Offset = "0x3843430", VA = "0x183844A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly CancellationTokenSource OMHMPNFEKFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly List<KJHIBJMHHPL> EICJDODIPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly KDFGFDCOIFJ BNFJGENAINF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly OBBIHCMKOPP FIMGAHBMFDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Task DECJPAHDLMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private int KEOKDCNHKLO;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3E590A0", Offset = "0x3E57AA0", VA = "0x183E590A0")]
	public NFOGKJFLOMC(OBBIHCMKOPP FIMGAHBMFDL, [Optional] KDFGFDCOIFJ BNFJGENAINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3E58420", Offset = "0x3E56E20", VA = "0x183E58420")]
	public Task<TResult> ICOKBPDMKNF(TRequest GOAJPHFIKLF, CancellationToken EAPNOLMLMHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3E58E80", Offset = "0x3E57880", VA = "0x183E58E80")]
	private void OFCKBIOBEOL(KJHIBJMHHPL DEEBFBHIKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3E58280", Offset = "0x3E56C80", VA = "0x183E58280")]
	[AsyncStateMachine(typeof(NFOGKJFLOMC<, >.EGFIKKOGFPL))]
	private Task HOAHKOKMLHA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3E579E0", Offset = "0x3E563E0", VA = "0x183E579E0")]
	private KJHIBJMHHPL FELJLJDMAAD()
	{
		return default(KJHIBJMHHPL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3E57800", Offset = "0x3E56200", VA = "0x183E57800")]
	[AsyncStateMachine(typeof(NFOGKJFLOMC<, >.IIMPOPIAOLD))]
	private Task EBIGBAENJAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3E58C40", Offset = "0x3E57640", VA = "0x183E58C40")]
	private void NFFCDKMNLME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3E576C0", Offset = "0x3E560C0", VA = "0x183E576C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[DefaultMember("Item")]
public class JOIJPHDLDMJ<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly List<T> BPDJICGMKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private HashSet<T> BIMDINEJNJM;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int MDLNLAAIONI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x305E200", Offset = "0x305CC00", VA = "0x18305E200", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool KNBLDDIDMLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T OBNEKGFINAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x378F0D0", Offset = "0x378DAD0", VA = "0x18378F0D0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3A64BB0", Offset = "0x3A635B0", VA = "0x183A64BB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3607190", Offset = "0x3605B90", VA = "0x183607190", Slot = "11")]
	public void Add(T PPIDKPHGGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3A645F0", Offset = "0x3A62FF0", VA = "0x183A645F0")]
	public bool LDAOGDIKOCA(T PPIDKPHGGGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3A648A0", Offset = "0x3A632A0", VA = "0x183A648A0", Slot = "15")]
	public bool Remove(T PPIDKPHGGGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x35E2740", Offset = "0x35E1140", VA = "0x1835E2740", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x35E97F0", Offset = "0x35E81F0", VA = "0x1835E97F0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3A64250", Offset = "0x3A62C50", VA = "0x183A64250", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3A642B0", Offset = "0x3A62CB0", VA = "0x183A642B0", Slot = "13")]
	public bool Contains(T PPIDKPHGGGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3A642F0", Offset = "0x3A62CF0", VA = "0x183A642F0", Slot = "14")]
	public void CopyTo(T[] BHNHFMPCKPL, int DOMAOCHEEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3A64320", Offset = "0x3A62D20", VA = "0x183A64320", Slot = "6")]
	public int IndexOf(T PPIDKPHGGGP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3A64370", Offset = "0x3A62D70", VA = "0x183A64370", Slot = "7")]
	public void Insert(int BNALCEABILL, T PPIDKPHGGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3A647B0", Offset = "0x3A631B0", VA = "0x183A647B0", Slot = "8")]
	public void RemoveAt(int BNALCEABILL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3A649E0", Offset = "0x3A633E0", VA = "0x183A649E0")]
	public JOIJPHDLDMJ()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x1E77650", Offset = "0x1E76050", VA = "0x181E77650")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5FA6A50", Offset = "0x5FA5450", VA = "0x185FA6A50")]
		public SerializedGuid([In] Guid DMMBGEACBPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5FA6920", Offset = "0x5FA5320", VA = "0x185FA6920")]
		public static SerializedGuid KICCFLJCOFA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5FA6850", Offset = "0x5FA5250", VA = "0x185FA6850")]
		public static SerializedGuid INOLJACJEDA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5FA68C0", Offset = "0x5FA52C0", VA = "0x185FA68C0")]
		public bool KBMKICIKMEP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5FA6A20", Offset = "0x5FA5420", VA = "0x185FA6A20", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5FA69A0", Offset = "0x5FA53A0", VA = "0x185FA69A0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5FA6770", Offset = "0x5FA5170", VA = "0x185FA6770", Slot = "7")]
		public bool Equals(SerializedGuid CGDFJMJIABO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5FA67B0", Offset = "0x5FA51B0", VA = "0x185FA67B0", Slot = "0")]
		public override bool Equals(object GKNPKJAGNGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5FA6840", Offset = "0x5FA5240", VA = "0x185FA6840", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5FA6740", Offset = "0x5FA5140", VA = "0x185FA6740", Slot = "6")]
		public int CompareTo(SerializedGuid CGDFJMJIABO)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class KMJLOMJFEPB : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly Type DIMJEAAMPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly string EELBLIBECCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly bool OJKGNAOEMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly bool KJCALAFDOME;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5FA3740", Offset = "0x5FA2140", VA = "0x185FA3740")]
	public KMJLOMJFEPB(Type DAJJMFHFCNM, string KAPEDLIMHCJ, bool OMGAKECLMGL = false, bool EOPHFEFLEOC = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class MBGNCDNKJOE<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public readonly struct EHGIIMONJJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public readonly long DBPLMKMMHAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public readonly long JPDBMFBALFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly int CBODFDLEDCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly int OOEPONIKMLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly bool BDFGELIAAPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly string JBMCAKEBHFN;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x324C490", Offset = "0x324AE90", VA = "0x18324C490")]
		public EHGIIMONJJP(long DBPLMKMMHAE, int CBODFDLEDCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x324C500", Offset = "0x324AF00", VA = "0x18324C500")]
		public EHGIIMONJJP(long DBPLMKMMHAE, long JPDBMFBALFO, int CBODFDLEDCC, int OOEPONIKMLK, bool BDFGELIAAPG, string JBMCAKEBHFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x324C420", Offset = "0x324AE20", VA = "0x18324C420")]
		public int LBCCHJLPMPF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x324C470", Offset = "0x324AE70", VA = "0x18324C470")]
		public int MNAPAKKGFHG(int GENCDKEPGDF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x324C3C0", Offset = "0x324ADC0", VA = "0x18324C3C0")]
		public double DPKAGAFGFPA()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x324C320", Offset = "0x324AD20", VA = "0x18324C320")]
		public EHGIIMONJJP CDMBCLKCMAA(long JPDBMFBALFO, int OOEPONIKMLK)
		{
			return default(EHGIIMONJJP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class GOJEFEHEBEO : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private struct GBACMEICGEA<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public GOJEFEHEBEO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public Func<GOJEFEHEBEO, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private GOJEFEHEBEO <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x3699100", Offset = "0x3697B00", VA = "0x183699100", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x3699620", Offset = "0x3698020", VA = "0x183699620", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly TKey MEIMJOBMJKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly MBGNCDNKJOE<TKey> ENLHLLPMOMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly EACOFNPIGGG ACIECAMLMIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private List<GOJEFEHEBEO> IMPIHFCBGJL;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string FPJJIIEIJEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x36BC560", Offset = "0x36BAF60", VA = "0x1836BC560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IEnumerable<GOJEFEHEBEO> PHBLENHDKPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x36BC7C0", Offset = "0x36BB1C0", VA = "0x1836BC7C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public EHGIIMONJJP OBFIFEPLMOP
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x36BC800", Offset = "0x36BB200", VA = "0x1836BC800")]
			[CompilerGenerated]
			get
			{
				return default(EHGIIMONJJP);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x36BC790", Offset = "0x36BB190", VA = "0x1836BC790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x36BC980", Offset = "0x36BB380", VA = "0x1836BC980")]
		internal GOJEFEHEBEO(MBGNCDNKJOE<TKey> ENLHLLPMOMA, TKey FHLJKJHFEEK, EACOFNPIGGG ACIECAMLMIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x36BC820", Offset = "0x36BB220", VA = "0x1836BC820")]
		public GOJEFEHEBEO LHMNAINGGFO(TKey FHLJKJHFEEK, [Optional] EACOFNPIGGG? AMAIAHJPGML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2F1DE00", Offset = "0x2F1C800", VA = "0x182F1DE00")]
		[AsyncStateMachine(typeof(GBACMEICGEA<>))]
		public Task<T> BDBMBMJOCAP<T>(TKey FHLJKJHFEEK, Func<GOJEFEHEBEO, Task<T>> NBNCFKKHMMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x36BC590", Offset = "0x36BAF90", VA = "0x1836BC590", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class OJGHAHPDCLM : IEnumerable<(TKey, List<TKey>, EHGIIMONJJP)>, IEnumerable, IEnumerator<(TKey, List<TKey>, EHGIIMONJJP)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private (TKey key, List<TKey> path, EHGIIMONJJP timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public MBGNCDNKJOE<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private IEnumerator<(TKey key, List<TKey> path, EHGIIMONJJP timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, EHGIIMONJJP) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x1E6AB30", Offset = "0x1E69530", VA = "0x181E6AB30", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, EHGIIMONJJP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x3F8C670", Offset = "0x3F8B070", VA = "0x183F8C670", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x1E6AC20", Offset = "0x1E69620", VA = "0x181E6AC20")]
		[DebuggerHidden]
		public OJGHAHPDCLM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3269050", Offset = "0x3267A50", VA = "0x183269050", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3F8C170", Offset = "0x3F8AB70", VA = "0x183F8C170", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3F8C510", Offset = "0x3F8AF10", VA = "0x183F8C510")]
		private void OEKMCAOJCOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3F8C620", Offset = "0x3F8B020", VA = "0x183F8C620", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3F8C560", Offset = "0x3F8AF60", VA = "0x183F8C560", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, EHGIIMONJJP)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x34AC370", Offset = "0x34AAD70", VA = "0x1834AC370", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class KLLGLMHCKDH : IEnumerable<(TKey, List<TKey>, EHGIIMONJJP)>, IEnumerable, IEnumerator<(TKey, List<TKey>, EHGIIMONJJP)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private (TKey key, List<TKey> path, EHGIIMONJJP timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private GOJEFEHEBEO timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public GOJEFEHEBEO <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public MBGNCDNKJOE<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private IEnumerator<GOJEFEHEBEO> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private IEnumerator<(TKey key, List<TKey> path, EHGIIMONJJP timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private (TKey, List<TKey>, EHGIIMONJJP) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x1E6AB30", Offset = "0x1E69530", VA = "0x181E6AB30", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, EHGIIMONJJP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x3AEBFA0", Offset = "0x3AEA9A0", VA = "0x183AEBFA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x1E6AC20", Offset = "0x1E69620", VA = "0x181E6AC20")]
		[DebuggerHidden]
		public KLLGLMHCKDH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3AEC000", Offset = "0x3AEAA00", VA = "0x183AEC000", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3AEB630", Offset = "0x3AEA030", VA = "0x183AEB630", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3AEBDE0", Offset = "0x3AEA7E0", VA = "0x183AEBDE0")]
		private void OEKMCAOJCOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3AEB5D0", Offset = "0x3AE9FD0", VA = "0x183AEB5D0")]
		private void ILPGDGAIKKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3AEBF50", Offset = "0x3AEA950", VA = "0x183AEBF50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x3AEBE40", Offset = "0x3AEA840", VA = "0x183AEBE40", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, EHGIIMONJJP)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3AEBF20", Offset = "0x3AEA920", VA = "0x183AEBF20", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly Action<TKey, EHGIIMONJJP, EACOFNPIGGG> PIANBHPDNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly Action<TKey, EHGIIMONJJP, EACOFNPIGGG> JJFFIDJLCHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly Action<MBGNCDNKJOE<TKey>, EACOFNPIGGG> LAPKGMDEHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly EACOFNPIGGG ACIECAMLMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly GOJEFEHEBEO CNLDKBBHBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private bool KFPLPOJFILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private int MJJCOOCDCAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Stopwatch PNGLIAFEMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public readonly int AMJKABGCGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private string FCCOOFOIIJD;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public GOJEFEHEBEO AEFAGMHIAAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x799000", Offset = "0x797A00", VA = "0x180799000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[NotNull]
	public string FPJJIIEIJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x78FC90", Offset = "0x78E690", VA = "0x18078FC90")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3DC7AC0", Offset = "0x3DC64C0", VA = "0x183DC7AC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3DC7D90", Offset = "0x3DC6790", VA = "0x183DC7D90")]
	public MBGNCDNKJOE(TKey LCJFILHNJDC, EACOFNPIGGG ACIECAMLMIJ, [Optional] int? CBODFDLEDCC, [Optional][CanBeNull] Stopwatch PNGLIAFEMOP, [Optional] Action<TKey, EHGIIMONJJP, EACOFNPIGGG> PIANBHPDNJI, [Optional] Action<TKey, EHGIIMONJJP, EACOFNPIGGG> JJFFIDJLCHN, [Optional] Action<MBGNCDNKJOE<TKey>, EACOFNPIGGG> LAPKGMDEHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3DC7BA0", Offset = "0x3DC65A0", VA = "0x183DC7BA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3DC7D00", Offset = "0x3DC6700", VA = "0x183DC7D00")]
	[IteratorStateMachine(typeof(MBGNCDNKJOE<>.OJGHAHPDCLM))]
	public IEnumerable<(TKey, List<TKey>, EHGIIMONJJP)> KABCFEHMBCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3DC7C30", Offset = "0x3DC6630", VA = "0x183DC7C30")]
	[IteratorStateMachine(typeof(MBGNCDNKJOE<>.KLLGLMHCKDH))]
	private IEnumerable<(TKey, List<TKey>, EHGIIMONJJP)> KABCFEHMBCM(List<TKey> FFGOGGNCCME, GOJEFEHEBEO POKEGKFFCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3DC7B20", Offset = "0x3DC6520", VA = "0x183DC7B20")]
	private (long, int) BKDJEEPJBPB()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public abstract class LKDOGGHCNKE<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut PEPELCMCJKA(MBGNCDNKJOE<TKey> ENLHLLPMOMA);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	protected LKDOGGHCNKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public abstract class CJBEIDGFJFI<TKey> : LKDOGGHCNKE<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate string CBNCMFPKNEM(TKey FHLJKJHFEEK);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x4CA4A10", Offset = "0x4CA3410", VA = "0x184CA4A10")]
	private static string EOILEGBDJHP(TKey FHLJKJHFEEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x4CA4A50", Offset = "0x4CA3450", VA = "0x184CA4A50", Slot = "4")]
	public override string PEPELCMCJKA(MBGNCDNKJOE<TKey> ENLHLLPMOMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x4CA4B10", Offset = "0x4CA3510", VA = "0x184CA4B10")]
	public string PEPELCMCJKA(MBGNCDNKJOE<TKey> ENLHLLPMOMA, [NotNull] CBNCMFPKNEM CIANGPIGPLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string EPGGLDLJGBG(MBGNCDNKJOE<TKey> ENLHLLPMOMA, [NotNull] CBNCMFPKNEM CIANGPIGPLK);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3241C80", Offset = "0x3240680", VA = "0x183241C80")]
	protected CJBEIDGFJFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class NFDKIHFHGOE<TKey> : LKDOGGHCNKE<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public delegate string KFKAALPONFA(TKey FHLJKJHFEEK);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly string MLOFIEFNGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly double OPNJDAAIAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly bool IDKNEFEFEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly int AKLCGJIDENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly ISet<string> BIBLFOHPPMI;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3E4CE20", Offset = "0x3E4B820", VA = "0x183E4CE20")]
	private static string EOILEGBDJHP(TKey FHLJKJHFEEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3E4D750", Offset = "0x3E4C150", VA = "0x183E4D750")]
	public NFDKIHFHGOE(string MLOFIEFNGJB = "F2", double OPNJDAAIAOK = double.MaxValue, bool IDKNEFEFEEI = false, int AKLCGJIDENB = int.MaxValue, [Optional] ISet<string> BIBLFOHPPMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3E4D0A0", Offset = "0x3E4BAA0", VA = "0x183E4D0A0", Slot = "4")]
	public override Dictionary<string, string> PEPELCMCJKA(MBGNCDNKJOE<TKey> ENLHLLPMOMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3E4CE60", Offset = "0x3E4B860", VA = "0x183E4CE60")]
	private bool HGKHAIJAHFM(string KHAOCOCEMNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3E4D160", Offset = "0x3E4BB60", VA = "0x183E4D160")]
	public Dictionary<string, string> PEPELCMCJKA(MBGNCDNKJOE<TKey> ENLHLLPMOMA, KFKAALPONFA CIANGPIGPLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3E4CBE0", Offset = "0x3E4B5E0", VA = "0x183E4CBE0")]
	private string AHHBPAICCFL(StringBuilder CLALMAKECMD, List<TKey> KPMOBGOFOBE, KFKAALPONFA CIANGPIGPLK, bool KLCEIKMHKKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3E4CF40", Offset = "0x3E4B940", VA = "0x183E4CF40")]
	private static void JAEKDEPFGNP(StringBuilder HCCKMBHMGAM, string OJGDEFHMIDL, bool BDOBNEPKJJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class BDFNNAOPBJA<TKey> : CJBEIDGFJFI<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct DDAMBGKIEFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public CBNCMFPKNEM keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static BDFNNAOPBJA<TKey> KHPIFBDMEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly string[] OOHKIFPAALB;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x46F6E30", Offset = "0x46F5830", VA = "0x1846F6E30")]
	private BDFNNAOPBJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x46F5E00", Offset = "0x46F4800", VA = "0x1846F5E00", Slot = "5")]
	protected override string EPGGLDLJGBG(MBGNCDNKJOE<TKey> ENLHLLPMOMA, CBNCMFPKNEM CIANGPIGPLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x46F5D10", Offset = "0x46F4710", VA = "0x1846F5D10")]
	[CompilerGenerated]
	internal static string EFANMDDKCEE(string KCFPPLEPGBL, TKey FHLJKJHFEEK, DDAMBGKIEFJ P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class DMJNLNLPMOP : MBGNCDNKJOE<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class EEJAHHCJHIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Action<DMJNLNLPMOP, EACOFNPIGGG> callback;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public EEJAHHCJHIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5FA2420", Offset = "0x5FA0E20", VA = "0x185FA2420")]
		internal void KEIPNNOMPPH(MBGNCDNKJOE<string> timer, EACOFNPIGGG log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5FA22D0", Offset = "0x5FA0CD0", VA = "0x185FA22D0")]
	public DMJNLNLPMOP(EACOFNPIGGG ACIECAMLMIJ, [Optional] string DKOPPENMHDN, [Optional] int? CBODFDLEDCC, [Optional] Stopwatch PNGLIAFEMOP, [Optional] Action<string, EHGIIMONJJP, EACOFNPIGGG> PIANBHPDNJI, [Optional] Action<string, EHGIIMONJJP, EACOFNPIGGG> JJFFIDJLCHN, [Optional] Action<DMJNLNLPMOP, EACOFNPIGGG> LAPKGMDEHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5FA2210", Offset = "0x5FA0C10", VA = "0x185FA2210")]
	private static Action<MBGNCDNKJOE<string>, EACOFNPIGGG> HPLJLANECHI(Action<DMJNLNLPMOP, EACOFNPIGGG> MKEOIOPNPIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public abstract class FECOMAPAJFG
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private class DMJNHKHOHEN : FECOMAPAJFG
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static FECOMAPAJFG KHPIFBDMEAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x5FA20C0", Offset = "0x5FA0AC0", VA = "0x185FA20C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override float HLJPFHIOKKL
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x1CE79F0", Offset = "0x1CE63F0", VA = "0x181CE79F0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5FA21C0", Offset = "0x5FA0BC0", VA = "0x185FA21C0")]
		public DMJNHKHOHEN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static FECOMAPAJFG AKIJBFHEJDA;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static FECOMAPAJFG MBNAEHMDPIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5FA24B0", Offset = "0x5FA0EB0", VA = "0x185FA24B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public abstract float HLJPFHIOKKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	protected FECOMAPAJFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class IDBHFEBNCAF<T> : PGIJLLFCBAB<T> where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public override Task<T> LKACNNIFJCN
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public override HECHONBOMGO<T> GKLDEHMEPDL
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x793B40", Offset = "0x792540", VA = "0x180793B40", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x381A970", Offset = "0x3819370", VA = "0x18381A970")]
	public IDBHFEBNCAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "10")]
	protected override void NCEPPALKHML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class LGDNFEADAKA<T> : PGIJLLFCBAB<T> where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public override Task<T> LKACNNIFJCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public override HECHONBOMGO<T> GKLDEHMEPDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x793B40", Offset = "0x792540", VA = "0x180793B40", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3BCCAA0", Offset = "0x3BCB4A0", VA = "0x183BCCAA0")]
	public LGDNFEADAKA(Exception IMCCCAHFJAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "10")]
	protected override void NCEPPALKHML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface HILPILOBADM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool KHGKOOPGFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface GDNMOKOHIIO<T> : HILPILOBADM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	[NotNull]
	Task<T> LKACNNIFJCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	[NotNull]
	HECHONBOMGO<T> GKLDEHMEPDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public abstract class PGIJLLFCBAB<T> : GDNMOKOHIIO<T>, HILPILOBADM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly FDBPKJCCENB LMGHKLCAPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private bool KFPLPOJFILA;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool KHGKOOPGFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x97E8B0", Offset = "0x97D2B0", VA = "0x18097E8B0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public abstract Task<T> LKACNNIFJCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public abstract HECHONBOMGO<T> GKLDEHMEPDL
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x4093930", Offset = "0x4092330", VA = "0x184093930")]
	public PGIJLLFCBAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x4093830", Offset = "0x4092230", VA = "0x184093830", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void NCEPPALKHML();
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public abstract class MMHLGDAPAIC<TTask, T> : PGIJLLFCBAB<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class PLDHPCGODKA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public PLDHPCGODKA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x304E300", Offset = "0x304CD00", VA = "0x18304E300", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x304E8A0", Offset = "0x304D2A0", VA = "0x18304E8A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public MMHLGDAPAIC<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public PLDHPCGODKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x409E750", Offset = "0x409D150", VA = "0x18409E750")]
		[AsyncStateMachine(typeof(MMHLGDAPAIC<, >.PLDHPCGODKA.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> AFBCDMBFODE(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly Task<T> HGLNIMPGIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	protected readonly CancellationTokenSource DCEAHKDKEFI;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public override Task<T> LKACNNIFJCN
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public override HECHONBOMGO<T> GKLDEHMEPDL
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x793B40", Offset = "0x792540", VA = "0x180793B40", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x3DEFFA0", Offset = "0x3DEE9A0", VA = "0x183DEFFA0")]
	protected MMHLGDAPAIC(TTask HGLNIMPGIKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3DEFF50", Offset = "0x3DEE950", VA = "0x183DEFF50", Slot = "10")]
	protected override void NCEPPALKHML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T CGGJEOPOLGL(TTask IABCGENNOAD);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void BCPFFKDHKBH();
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class MMGFCKNFGJA<T> : PGIJLLFCBAB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly OGDBMBLCOHC<Task<T>> AMAIOJCNMLI;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public override Task<T> LKACNNIFJCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x35A02E0", Offset = "0x359ECE0", VA = "0x1835A02E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public override HECHONBOMGO<T> GKLDEHMEPDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x793B40", Offset = "0x792540", VA = "0x180793B40", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3DEFE90", Offset = "0x3DEE890", VA = "0x183DEFE90")]
	public MMGFCKNFGJA(OGDBMBLCOHC<Task<T>> ACOCEDOKGEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3DEFE70", Offset = "0x3DEE870", VA = "0x183DEFE70", Slot = "10")]
	protected override void NCEPPALKHML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class MCEOGIEHBDK
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5FA39A0", Offset = "0x5FA23A0", VA = "0x185FA39A0")]
	[NotNull]
	public static byte[] IOOHAHAHBIK(this KAGGPMOKOIP MNOGMCOJIHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5FA3930", Offset = "0x5FA2330", VA = "0x185FA3930")]
	[NotNull]
	public static byte[] IOOHAHAHBIK(this KAGGPMOKOIP MNOGMCOJIHB, HashAlgorithmName CNKBCOOBLFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5FA3A10", Offset = "0x5FA2410", VA = "0x185FA3A10")]
	public static bool PMMLNKOPAEO([CanBeNull] this KAGGPMOKOIP MNOGMCOJIHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5FA3BA0", Offset = "0x5FA25A0", VA = "0x185FA3BA0")]
	public static bool PMMLNKOPAEO([CanBeNull] this KAGGPMOKOIP MNOGMCOJIHB, [Out] string BNFACNGELAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5FA3810", Offset = "0x5FA2210", VA = "0x185FA3810")]
	private static bool DJDBDHELONA([NotNull] KAGGPMOKOIP MNOGMCOJIHB, [Out][CanBeNull] byte[] ENIJABJGEJJ, [Out][CanBeNull] byte[] JIOKFLDJEFE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class PLHNFCMAMDD
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5FA50C0", Offset = "0x5FA3AC0", VA = "0x185FA50C0")]
	[NotNull]
	public static byte[] IOOHAHAHBIK(this JCILFAGDNPA NEKFKBHILPF, HashAlgorithmName CNKBCOOBLFP, byte[] APCDPPCIBPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface JCILFAGDNPA
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash JCKOPCANIKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface KAGGPMOKOIP : JCILFAGDNPA
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	[CanBeNull]
	byte[] FKMOBGHIFEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	[CanBeNull]
	byte[] JBAMMFANBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class ODBHJNOCKEN
{
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static readonly ArrayPool<byte> FKAMFEJEEDM;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static bool AOLKCHAEEPI;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4840", Offset = "0x5FA3240", VA = "0x185FA4840")]
	public static void LJFBHNJELHL(this IncrementalHash APNIBEGPAJD, [CanBeNull] GameObject PKKHAEKNIBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x276C8A0", Offset = "0x276B2A0", VA = "0x18276C8A0")]
	public static void LJFBHNJELHL<T>(this IncrementalHash APNIBEGPAJD, [CanBeNull] T BBNHMANAAIO) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x276C810", Offset = "0x276B210", VA = "0x18276C810")]
	public static void LIBLDNDNKBL<T>(this IncrementalHash APNIBEGPAJD, [CanBeNull] T NEKFKBHILPF) where T : JCILFAGDNPA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x276C2F0", Offset = "0x276ACF0", VA = "0x18276C2F0")]
	public static void GEDLPDCMCCO<T>(this IncrementalHash APNIBEGPAJD, [CanBeNull] IList<T> OBCGFNNGNND) where T : JCILFAGDNPA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4A30", Offset = "0x5FA3430", VA = "0x185FA4A30")]
	private static bool NBGMPOGPBKF([CanBeNull] JCILFAGDNPA NEKFKBHILPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4080", Offset = "0x5FA2A80", VA = "0x185FA4080")]
	public static void DBNMDMHKGLN(this IncrementalHash JCKOPCANIKJ, [CanBeNull] string PGANIKJNCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5FA44A0", Offset = "0x5FA2EA0", VA = "0x185FA44A0")]
	public static void KMADDIKFHFD(this IncrementalHash JCKOPCANIKJ, long PJKBEPHBIFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5FA3EB0", Offset = "0x5FA28B0", VA = "0x185FA3EB0")]
	public static void ABAICPHFKGD(this IncrementalHash JCKOPCANIKJ, int EKENPHLLDNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4670", Offset = "0x5FA3070", VA = "0x185FA4670")]
	public static void LIMMBKFBPKA(this IncrementalHash JCKOPCANIKJ, short ACNEBFCDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4920", Offset = "0x5FA3320", VA = "0x185FA4920")]
	public static void MKPCOMIDFID(this IncrementalHash JCKOPCANIKJ, byte NDKPOHOEIDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4200", Offset = "0x5FA2C00", VA = "0x185FA4200")]
	public static void IFHCNEPODEI(this IncrementalHash JCKOPCANIKJ, bool JIJOKKNPMNH, bool DGOKCFBNNNE = false, bool JKLOLJFIMHK = false, bool LFNBGCKEMBN = false, bool FLMFEOMKAJK = false, bool BLPDPMDACNM = false, bool LCFCNDFPAJE = false, bool PMKKPKGNFAF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x276BCC0", Offset = "0x276A6C0", VA = "0x18276BCC0")]
	public static void DNCHPNPEEFP<T>(this IncrementalHash JCKOPCANIKJ, T IPDIFFOOAAI) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5FA41A0", Offset = "0x5FA2BA0", VA = "0x185FA41A0")]
	public static void ICBPBKBDGEM(this IncrementalHash JCKOPCANIKJ, float HIIIBNPJLAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4AC0", Offset = "0x5FA34C0", VA = "0x185FA4AC0")]
	public static void PGKCIHAMDME(this IncrementalHash JCKOPCANIKJ, ulong OIBAGHCKEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5FA40E0", Offset = "0x5FA2AE0", VA = "0x185FA40E0")]
	public static void DHBHAGFEBAF(this IncrementalHash JCKOPCANIKJ, uint BDMDGBOLDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4140", Offset = "0x5FA2B40", VA = "0x185FA4140")]
	public static void DMILAFMMNEG(this IncrementalHash JCKOPCANIKJ, ushort CEOALNMLHAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4370", Offset = "0x5FA2D70", VA = "0x185FA4370")]
	public static void KKHFBCCCCKG(this IncrementalHash JCKOPCANIKJ, Vector3 MLEOEANAIMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class LOEDDMOEDDG : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5FA37B0", Offset = "0x5FA21B0", VA = "0x185FA37B0")]
	public LOEDDMOEDDG(string BKNCBJIACBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public abstract class AODAFNOEJDF<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal class ONGMBAJFHBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public TNode JFFAAHPEFOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public TNode CDMOGOKIPKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public CPLGNOOMAKJ KMGENFCCMDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public List<CPLGNOOMAKJ> HMNOPONKMJP;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public ONGMBAJFHBE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	internal struct CPLGNOOMAKJ : IComparable<CPLGNOOMAKJ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int HPLMCDPDBHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public TClaimant NJMFJIJPMGD;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xB9F900", Offset = "0xB9E300", VA = "0x180B9F900")]
		public CPLGNOOMAKJ(int HPLMCDPDBHP, TClaimant NJMFJIJPMGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x4D8D960", Offset = "0x4D8C360", VA = "0x184D8D960")]
		public bool IBFGHGMCHBH([In] CPLGNOOMAKJ CGDFJMJIABO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x4D8D9C0", Offset = "0x4D8C3C0", VA = "0x184D8D9C0")]
		public bool KIOLLDOENNK([In] CPLGNOOMAKJ CGDFJMJIABO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x4D8D950", Offset = "0x4D8C350", VA = "0x184D8D950", Slot = "4")]
		public int CompareTo(CPLGNOOMAKJ CGDFJMJIABO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x4D8D9D0", Offset = "0x4D8C3D0", VA = "0x184D8D9D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public enum MLBANMCACCC
	{
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class FJPEIHNODJO : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public AODAFNOEJDF<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x930310", Offset = "0x92ED10", VA = "0x180930310")]
		[DebuggerHidden]
		public FJPEIHNODJO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x35C4A50", Offset = "0x35C3450", VA = "0x1835C4A50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x35C4C10", Offset = "0x35C3610", VA = "0x1835C4C10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x35C4B30", Offset = "0x35C3530", VA = "0x1835C4B30", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x334DED0", Offset = "0x334C8D0", VA = "0x18334DED0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly HAKICBOMODM<ONGMBAJFHBE> LIHOCCPDJLA;

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static readonly HAKICBOMODM<List<CPLGNOOMAKJ>> ECAAPADEDAC;

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static int GNDICOBIJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	internal readonly Dictionary<TClaimant, TNode> PNPPOMDJKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	internal readonly Dictionary<TNode, ONGMBAJFHBE> LOHMJBCPNPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private MLBANMCACCC GMLCEBAHCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private bool BDLHHIBLMII;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode OHHJABMAFBC(TNode NADDHKKGBAN);

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void HLNMONGEANI(TNode NADDHKKGBAN, TClaimant AIHBCDIEGPB, TClaimant GEKFCFLAPIL);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x38AF940", Offset = "0x38AE340", VA = "0x1838AF940")]
	public AODAFNOEJDF(MLBANMCACCC GMLCEBAHCFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x38AF030", Offset = "0x38ADA30", VA = "0x1838AF030")]
	public void MKCJOHOCNJA(TNode NADDHKKGBAN, TNode FPOAHANPCBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x38AF660", Offset = "0x38AE060", VA = "0x1838AF660")]
	public void PKLOAEHIMGG(TClaimant NJMFJIJPMGD, TNode CFJLIJGEMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x38AE850", Offset = "0x38AD250", VA = "0x1838AE850", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x38AF0C0", Offset = "0x38ADAC0", VA = "0x1838AF0C0")]
	private void MLMBLAKBAIF(TClaimant NJMFJIJPMGD, TNode NGGHGEKGLCH, TNode CFJLIJGEMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x38AEA20", Offset = "0x38AD420", VA = "0x1838AEA20")]
	private int ELLOKJAJPBD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x38AE120", Offset = "0x38ACB20", VA = "0x1838AE120")]
	private void AAMCMODCELP(TClaimant NJMFJIJPMGD, TNode MPHJHPCIHCH, TNode NDNCPFOMPGG, int AOCCGDDJHLI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x38AEDD0", Offset = "0x38AD7D0", VA = "0x1838AEDD0")]
	private void KGKGLONAMFM(CPLGNOOMAKJ KBMNJOLOMPL, ONGMBAJFHBE AKBGHNHAADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x38AE460", Offset = "0x38ACE60", VA = "0x1838AE460")]
	private void APBFDOINKHM(TClaimant NJMFJIJPMGD, TNode MPHJHPCIHCH, TNode NDNCPFOMPGG, int AOCCGDDJHLI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x38AE740", Offset = "0x38AD140", VA = "0x1838AE740")]
	private void DNMCJFPNGGN(CPLGNOOMAKJ KBMNJOLOMPL, TNode NADDHKKGBAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x38AEF40", Offset = "0x38AD940", VA = "0x1838AEF40")]
	private void LEFECNCHNPF(CPLGNOOMAKJ KBMNJOLOMPL, ONGMBAJFHBE AKBGHNHAADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x38AF530", Offset = "0x38ADF30", VA = "0x1838AF530")]
	private void PFPEMELOCIO(ONGMBAJFHBE AKBGHNHAADP, bool LMFMNKMPOME = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x38AEA90", Offset = "0x38AD490", VA = "0x1838AEA90")]
	private void KDBGMLNGODN(ONGMBAJFHBE AKBGHNHAADP, TNode FPOAHANPCBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x38AEE60", Offset = "0x38AD860", VA = "0x1838AEE60")]
	[IteratorStateMachine(typeof(AODAFNOEJDF<, >.FJPEIHNODJO))]
	private IEnumerable<TNode> LAJIJLHDPLK(TNode MPHJHPCIHCH, TNode NDNCPFOMPGG, bool DIHNEGDEMEJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x38AF160", Offset = "0x38ADB60", VA = "0x1838AF160")]
	private ONGMBAJFHBE NNNEKJPLADM(TNode NADDHKKGBAN, TNode CDMOGOKIPKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x38AF250", Offset = "0x38ADC50", VA = "0x1838AF250")]
	private ONGMBAJFHBE OCKJIIGCKDD(TNode NADDHKKGBAN, TNode CDMOGOKIPKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x38AF3C0", Offset = "0x38ADDC0", VA = "0x1838AF3C0")]
	private void OCOKHMHOJMB(ONGMBAJFHBE AKBGHNHAADP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class LOKFCJOGCJL<T> : IEnumerable<LOKFCJOGCJL<T>.MJDFIIEBOOI>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public struct MJDFIIEBOOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public T BEEGCHJLJFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public int BNALCEABILL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class MCPLBIKANPF : IEnumerator<MJDFIIEBOOI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private LOKFCJOGCJL<T> NEMNDLOFKLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int BNALCEABILL;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x32764B0", Offset = "0x3274EB0", VA = "0x1832764B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public MJDFIIEBOOI POOCAABBIHB
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x3DCC290", Offset = "0x3DCAC90", VA = "0x183DCC290", Slot = "4")]
			get
			{
				return default(MJDFIIEBOOI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3DCC250", Offset = "0x3DCAC50", VA = "0x183DCC250")]
		public MCPLBIKANPF(LOKFCJOGCJL<T> NEMNDLOFKLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3DCC1D0", Offset = "0x3DCABD0", VA = "0x183DCC1D0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x32C3DF0", Offset = "0x32C27F0", VA = "0x1832C3DF0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x1B6A610", Offset = "0x1B69010", VA = "0x181B6A610", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct LAHHOBMDLPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public bool FGCGFHPFGKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public T BEEGCHJLJFC;
	}

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private const int DGKLGJFNFBI = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly Dictionary<T, int> GANMCDBFMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private LAHHOBMDLPC[] FJAHMKAIDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private int LMDEGELCMBN;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int JNNIMIKFAAE
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7CEA20", Offset = "0x7CD420", VA = "0x1807CEA20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7CE080", Offset = "0x7CCA80", VA = "0x1807CE080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int MDLNLAAIONI
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x305E200", Offset = "0x305CC00", VA = "0x18305E200")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x3BF5C30", Offset = "0x3BF4630", VA = "0x183BF5C30")]
	public LOKFCJOGCJL(int HCAPAJGPPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x3BF5D10", Offset = "0x3BF4710", VA = "0x183BF5D10")]
	public LOKFCJOGCJL(MJDFIIEBOOI[] FDLJPDMNHAL, bool KDAKHHKGBEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x3BF4B30", Offset = "0x3BF3530", VA = "0x183BF4B30")]
	public int BHALDKKCBJD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3BF4D00", Offset = "0x3BF3700", VA = "0x183BF4D00")]
	private int GBGBOGINOGM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3BF56C0", Offset = "0x3BF40C0", VA = "0x183BF56C0", Slot = "6")]
	protected virtual uint PKGHCIDILBP(uint JCKOPCANIKJ, T BEEGCHJLJFC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x3BF4C60", Offset = "0x3BF3660", VA = "0x183BF4C60")]
	public bool FPLFKEGBHBN(T BEEGCHJLJFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x3BF5140", Offset = "0x3BF3B40", VA = "0x183BF5140")]
	public int IGKJGJAJAPN(T BEEGCHJLJFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x3BF5770", Offset = "0x3BF4170", VA = "0x183BF5770")]
	public T PKNFAIDBGDG(int BNALCEABILL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x3BF53C0", Offset = "0x3BF3DC0", VA = "0x183BF53C0")]
	public bool LDAOGDIKOCA(T BEEGCHJLJFC, bool IPDKKGELLPL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x3BF51B0", Offset = "0x3BF3BB0", VA = "0x183BF51B0")]
	public bool LDAOGDIKOCA(T BEEGCHJLJFC, int BNALCEABILL, bool IPDKKGELLPL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x3BF4BC0", Offset = "0x3BF35C0", VA = "0x183BF4BC0")]
	private int CIFBODPFCGE(int MGKCHJOOGGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x3BF57E0", Offset = "0x3BF41E0", VA = "0x183BF57E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x3BF57E0", Offset = "0x3BF41E0", VA = "0x183BF57E0", Slot = "4")]
	private IEnumerator<MJDFIIEBOOI> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class HAKICBOMODM<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Stack<T> NLHKHACGNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly List<T> LDFGGGJLJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly int FEKBCEBHNLM;

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x36E4DA0", Offset = "0x36E37A0", VA = "0x1836E4DA0")]
	public static HAKICBOMODM<T> AIMPFBIJEOI(int HCAPAJGPPGD = 0, int FEKBCEBHNLM = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x36E5510", Offset = "0x36E3F10", VA = "0x1836E5510")]
	public HAKICBOMODM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x36E5540", Offset = "0x36E3F40", VA = "0x1836E5540")]
	public HAKICBOMODM(int HCAPAJGPPGD, int FEKBCEBHNLM = int.MaxValue, bool BMOMJGHPFNM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x36E5080", Offset = "0x36E3A80", VA = "0x1836E5080")]
	public T DICMGHLFJCL()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x36E5440", Offset = "0x36E3E40", VA = "0x1836E5440")]
	public void KHFIPNFMONP(T BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x36E5200", Offset = "0x36E3C00", VA = "0x1836E5200")]
	private void DMJIPCMMNCP(T BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x36E5420", Offset = "0x36E3E20", VA = "0x1836E5420")]
	private void FONEKFCKDCL(T BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x36E52E0", Offset = "0x36E3CE0", VA = "0x1836E52E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x36E4E80", Offset = "0x36E3880", VA = "0x1836E4E80")]
	private void AMPFIKJGDNJ(IEnumerable<T> AKMHBKNPLFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class POOHCNJDAJC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Dictionary<int, T> FFHAGOKFHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private T MCIOFCBEIKJ;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual T FPDBIDBPCCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x790C90", Offset = "0x78F690", VA = "0x180790C90", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x40A7FA0", Offset = "0x40A69A0", VA = "0x1840A7FA0")]
	public bool FMFEHDPAEEC(T BEEGCHJLJFC, int HPLMCDPDBHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x3DFB860", Offset = "0x3DFA260", VA = "0x183DFB860")]
	public bool PFNDOGOFMHK(int HPLMCDPDBHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x40A8290", Offset = "0x40A6C90", VA = "0x1840A8290")]
	public T HJGMOLDDNLA(int LIBLKIMBDOA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x40A80E0", Offset = "0x40A6AE0", VA = "0x1840A80E0")]
	private bool HGPPGCPHOBJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x40A8090", Offset = "0x40A6A90", VA = "0x1840A8090")]
	public bool GFGJHMKHGPD(int HPLMCDPDBHP, [Out] T BEEGCHJLJFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x40A8670", Offset = "0x40A7070", VA = "0x1840A8670")]
	public POOHCNJDAJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class DKLIKEGALHF<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	protected struct JFMNGNMGKPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public T BMLGNHJJEIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public int DMBBLJCKKCC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	protected readonly List<JFMNGNMGKPE> CKKKCBCEIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private T NAMOMAHMLND;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int MDLNLAAIONI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x305E200", Offset = "0x305CC00", VA = "0x18305E200")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x4F6D880", Offset = "0x4F6C280", VA = "0x184F6D880")]
	public bool EODOHENOEFA(T BEEGCHJLJFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x4F6D7E0", Offset = "0x4F6C1E0", VA = "0x184F6D7E0")]
	public void DGLLAPEBOKO(T BEEGCHJLJFC, int HPLMCDPDBHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x4F6D690", Offset = "0x4F6C090", VA = "0x184F6D690")]
	public bool BPOFHEGLDCM(T BEEGCHJLJFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x4F6DA00", Offset = "0x4F6C400", VA = "0x184F6DA00")]
	public void JOBLGFAFDNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x4F6DA60", Offset = "0x4F6C460", VA = "0x184F6DA60")]
	public T KDJGGCPKCKG()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x4F6DAE0", Offset = "0x4F6C4E0", VA = "0x184F6DAE0")]
	private void KOKDIBIKLII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x4F6DC40", Offset = "0x4F6C640", VA = "0x184F6DC40")]
	public DKLIKEGALHF()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[IGEHDIPFLIF(EEBNILOIPCE.Self, false, false, false)]
		[SerializeField]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x5FA5440", Offset = "0x5FA3E40", VA = "0x185FA5440")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x5FA5710", Offset = "0x5FA4110", VA = "0x185FA5710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x5FA5620", Offset = "0x5FA4020", VA = "0x185FA5620")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x5FA5390", Offset = "0x5FA3D90", VA = "0x185FA5390")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x5FA5660", Offset = "0x5FA4060", VA = "0x185FA5660")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x5FA5570", Offset = "0x5FA3F70", VA = "0x185FA5570")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x5FA5300", Offset = "0x5FA3D00", VA = "0x185FA5300")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x4241310", Offset = "0x423FD10", VA = "0x184241310", Slot = "4")]
		public virtual T KMEAFHLFMLA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class GNEIDOIJFAM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly Dictionary<byte, PACMBBAJBON> EKLDINHGLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly HAKICBOMODM<PACMBBAJBON> CJEANKLNMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private readonly bool KDOGMBPODEA;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public PACMBBAJBON LKHNENDAEGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x790420", Offset = "0x78EE20", VA = "0x180790420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public Vector2 OEMDAOCKCEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xB25BD0", Offset = "0xB245D0", VA = "0x180B25BD0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xE0B620", Offset = "0xE0A020", VA = "0x180E0B620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private Vector2 FMPJNGAICOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xE36AB0", Offset = "0xE354B0", VA = "0x180E36AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public Vector2 IGBIKHOHKAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5FA2940", Offset = "0x5FA1340", VA = "0x185FA2940")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x799140", Offset = "0x797B40", VA = "0x180799140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public int PFPHELBLMPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x793B20", Offset = "0x792520", VA = "0x180793B20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x793B00", Offset = "0x792500", VA = "0x180793B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x5FA31F0", Offset = "0x5FA1BF0", VA = "0x185FA31F0")]
	public GNEIDOIJFAM(Bounds APHJMMDCKMH, Vector2[] HPLGEMOADNO, int FMACBKPOELF, byte MGKCHJOOGGA, float BODBBCEIBOP = 0f, [Optional] HAKICBOMODM<PACMBBAJBON> CJEANKLNMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x5FA3060", Offset = "0x5FA1A60", VA = "0x185FA3060")]
	public PACMBBAJBON FMMDCIEPHCB(byte BNALCEABILL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5FA3120", Offset = "0x5FA1B20", VA = "0x185FA3120")]
	public void MAICBBNABPL(Vector3 CJONGNPPIAD, float HLAOLJDHLEG, float PPKGMGBDPED, List<byte> KPKLEIDAFFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x5CBCE60", Offset = "0x5CBB860", VA = "0x185CBCE60")]
	public void ENILDAIPOGB(PACMBBAJBON.CMLOKIFNAKK GMJLHHKOMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5FA2960", Offset = "0x5FA1360", VA = "0x185FA2960")]
	public static int BPLKKCAGJEE(Vector2[] HPLGEMOADNO, int FMACBKPOELF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5FA2E60", Offset = "0x5FA1860", VA = "0x185FA2E60")]
	private PACMBBAJBON FBLPOCLLIPO(byte BNALCEABILL, PACMBBAJBON.OGOLEBMLANI EKIFPBDJHBM, PACMBBAJBON CDMOGOKIPKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x5FA2AB0", Offset = "0x5FA14B0", VA = "0x185FA2AB0")]
	private void ENPKOGHCFJJ(PACMBBAJBON CDMOGOKIPKH, Vector2[] HPLGEMOADNO, int MFJJCAEEBBK, int AEKAGMNPKDA, int PBPOIJBPGOA, int LHDFAFNDKNI, float BODBBCEIBOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5FA2720", Offset = "0x5FA1120", VA = "0x185FA2720")]
	private void AGLBHDFLFID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5FA2A50", Offset = "0x5FA1450", VA = "0x185FA2A50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5FA30C0", Offset = "0x5FA1AC0", VA = "0x185FA30C0", Slot = "1")]
	~GNEIDOIJFAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class PACMBBAJBON
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public enum OGOLEBMLANI
	{
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public enum CMLOKIFNAKK
	{
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public byte MILBLOILOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public Vector3 JBPEFCMIKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public Vector3 DGFKKGBDDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public Vector3 CAEEPCJOMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public Vector3 MCMHCMBEILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public OGOLEBMLANI CPPOEMPEFLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public PACMBBAJBON HOANOOGFEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public List<PACMBBAJBON> CGLHBPCGBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public bool DCOCNDJOPPJ;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x5FA50A0", Offset = "0x5FA3AA0", VA = "0x185FA50A0")]
	public PACMBBAJBON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4C60", Offset = "0x5FA3660", VA = "0x185FA4C60")]
	public void ECOOBADFKEJ(PACMBBAJBON PMJGAJHPHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210")]
	public void ENILDAIPOGB(int FLGHHCLDJGE, CMLOKIFNAKK GMJLHHKOMKJ, int CPHNJLMKMOM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4E40", Offset = "0x5FA3840", VA = "0x185FA4E40")]
	public void MAICBBNABPL(List<byte> KPKLEIDAFFF, Vector3 CJONGNPPIAD, float HLAOLJDHLEG, float PPKGMGBDPED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4C30", Offset = "0x5FA3630", VA = "0x185FA4C30")]
	public bool CJLFAGDCLKH(Vector3 HPCONAOEEAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4D80", Offset = "0x5FA3780", VA = "0x185FA4D80")]
	public bool EOGMAKMJMIF(Vector3 HPCONAOEEAJ, float PGDFOIACEKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4DB0", Offset = "0x5FA37B0", VA = "0x185FA4DB0")]
	public void IAMMEFBKIFH()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		public struct BMEPOCHJFLC<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private readonly List<Component> BPDJICGMKNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private readonly bool LGKENECBMLI;

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x35D5650", Offset = "0x35D4050", VA = "0x1835D5650")]
			public BMEPOCHJFLC(List<Component> BPDJICGMKNG, bool LGKENECBMLI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x4814990", Offset = "0x4813390", VA = "0x184814990")]
			public KNEGKMELIPM<T> DHCNIOBIIDB()
			{
				return default(KNEGKMELIPM<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x4814A00", Offset = "0x4813400", VA = "0x184814A00", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x4814A00", Offset = "0x4813400", VA = "0x184814A00", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		public struct KNEGKMELIPM<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private readonly List<Component> BPDJICGMKNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private readonly bool LGKENECBMLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private int BNALCEABILL;

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public T POOCAABBIHB
			{
				[Cpp2IlInjected.Token(Token = "0x60001EB")]
				[Cpp2IlInjected.Address(RVA = "0x3B435E0", Offset = "0x3B41FE0", VA = "0x183B435E0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001EC")]
				[Cpp2IlInjected.Address(RVA = "0x3B43570", Offset = "0x3B41F70", VA = "0x183B43570", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x3B435B0", Offset = "0x3B41FB0", VA = "0x183B435B0")]
			public KNEGKMELIPM(List<Component> BPDJICGMKNG, bool LGKENECBMLI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x3B434B0", Offset = "0x3B41EB0", VA = "0x183B434B0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x3B434C0", Offset = "0x3B41EC0", VA = "0x183B434C0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x1D10F10", Offset = "0x1D0F910", VA = "0x181D10F10", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5FA6EC0", Offset = "0x5FA58C0", VA = "0x185FA6EC0")]
		private void IAMMEFBKIFH(GameObject IMHBKLJNIOJ, bool JAAMGDODLLF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5FA7030", Offset = "0x5FA5A30", VA = "0x185FA7030")]
		public static void IAMMEFBKIFH(GameObject IMHBKLJNIOJ, ToolHierarchyCache JOHPOAIIMHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x28B8470", Offset = "0x28B6E70", VA = "0x1828B8470")]
		public void GLGBEKIAILG<T>(Action<T> GMHPLHJININ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x28B8750", Offset = "0x28B7150", VA = "0x1828B8750")]
		public T KAEMFPCIMIB<T>(bool LGKENECBMLI = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x28B8690", Offset = "0x28B7090", VA = "0x1828B8690")]
		public BMEPOCHJFLC<T> HPLBDPDGHCD<T>(bool LGKENECBMLI = false) where T : class
		{
			return default(BMEPOCHJFLC<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5FA6B00", Offset = "0x5FA5500", VA = "0x185FA6B00")]
		public List<Component> FPAECHMOONH(Type AKDFFJNHJJN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5FA6A80", Offset = "0x5FA5480", VA = "0x185FA6A80", Slot = "4")]
		public bool Equals(ToolHierarchyCache MGCANBJCGMI, ToolHierarchyCache MMANNCDCEPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5FA6E50", Offset = "0x5FA5850", VA = "0x185FA6E50", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache GKNPKJAGNGH)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class PNENOKBBPEE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private int HCAPAJGPPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private int JDGCGEIADCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private List<T> HBAGFCLKGMJ;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int MDLNLAAIONI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x35A02E0", Offset = "0x359ECE0", VA = "0x1835A02E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public T JDJFMHPKACE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x40A4EC0", Offset = "0x40A38C0", VA = "0x1840A4EC0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public T JPEOCMHMODL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x40A4CD0", Offset = "0x40A36D0", VA = "0x1840A4CD0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public T JGKFAKHMLJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x40A4B90", Offset = "0x40A3590", VA = "0x1840A4B90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x40A51C0", Offset = "0x40A3BC0", VA = "0x1840A51C0")]
	public PNENOKBBPEE(int HCAPAJGPPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x40A5070", Offset = "0x40A3A70", VA = "0x1840A5070")]
	public void DGLLAPEBOKO(T CPENBCGAFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x40A5170", Offset = "0x40A3B70", VA = "0x1840A5170")]
	public void JOBLGFAFDNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x40A4D40", Offset = "0x40A3740", VA = "0x1840A4D40")]
	public void CDHEJPBDEMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x40A4C10", Offset = "0x40A3610", VA = "0x1840A4C10")]
	public void BNPCKHPIPKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x40A51B0", Offset = "0x40A3BB0", VA = "0x1840A51B0")]
	public void LEGCBIJKELG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class CHFHMHFCHNC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private struct GAKNIBHGHEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int DMBBLJCKKCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public T BMLGNHJJEIP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly Dictionary<object, GAKNIBHGHEB> FFHAGOKFHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly EqualityComparer<T> HELEEFKOGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private T MCIOFCBEIKJ;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public virtual T FPDBIDBPCCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xF022E0", Offset = "0xF00CE0", VA = "0x180F022E0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x4BCC890", Offset = "0x4BCB290", VA = "0x184BCC890", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool DECOLGLKDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x4BCC900", Offset = "0x4BCB300", VA = "0x184BCC900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public object AHEMKKAIJAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x799000", Offset = "0x797A00", VA = "0x180799000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x79A7B0", Offset = "0x7991B0", VA = "0x18079A7B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x4BCCF50", Offset = "0x4BCB950", VA = "0x184BCCF50")]
	public bool FMFEHDPAEEC(T BEEGCHJLJFC, object BDAPLOBBPIE, int HPLMCDPDBHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x4BD0570", Offset = "0x4BCEF70", VA = "0x184BD0570")]
	public bool PFNDOGOFMHK(object BDAPLOBBPIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x4BCD410", Offset = "0x4BCBE10", VA = "0x184BCD410")]
	public bool GFGJHMKHGPD(object BDAPLOBBPIE, [Out] T BEEGCHJLJFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x4BD0510", Offset = "0x4BCEF10", VA = "0x184BD0510")]
	public void JOBLGFAFDNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x4BCF8D0", Offset = "0x4BCE2D0", VA = "0x184BCF8D0")]
	private bool HGPPGCPHOBJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x4BD0600", Offset = "0x4BCF000", VA = "0x184BD0600")]
	public CHFHMHFCHNC()
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
